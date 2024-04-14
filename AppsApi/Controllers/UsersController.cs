using AppsApi.Data.Entities;
using AppsApi.Data.Repositories.Abstractions;
using AppsApi.DTOs.UserDTOs;
using AppsApi.Services.Abstractions;
using AppsApi.Utils;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NuGet.Common;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AppsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IConfigurationSection _jwtSettings;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public UsersController(IConfiguration configuration, IHttpContextAccessor httpContextAccessor, IUserService userService)
        {
            _userService = userService;
            _jwtSettings = configuration.GetSection("JwtSettings");
            _httpContextAccessor = httpContextAccessor;

        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login(UserLoginDTO userModel)
        {
            var token = await _userService.Login(userModel, _jwtSettings);
            if (token != null)
            {
                return Ok(new { token });
            }
            return StatusCode(500);
        }

        [HttpPost("Register")]
        public async Task<ActionResult> Register([FromForm] UserRegisterDTO userModel)
        {
            userModel.ProfilePicture = await Helper.UploadImageLocally(userModel.ProfileFile, "ImageProfiles", _httpContextAccessor);
            if (await _userService.Register(userModel))
            {
                return Ok();
            }
            return StatusCode(500);

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserResponseDTO>>> GetUsers()
        {
            return (await _userService.GetUsers()).ToList();
        }

        [HttpGet("Details/Id")]
        public async Task<ActionResult<UserDetailResponseDTO>> GetUserDetails(string id)
        {
            return (await _userService.GetUserDetail(id));
        }

        [HttpGet("Id")]
        public async Task<ActionResult<UserResponseDTO>> GetUserById(string id)
        {
            return (await _userService.GetUserById(id));
        }


        [HttpPatch("AddToWishlist")]
        [Authorize]
        public async Task<ActionResult> AddAppToWishList(int appId)
        {
            var userId = await Helper.GetUserIdFromJwtToken(Request.Headers.Authorization);
            if (await _userService.AddAppToWishlist(userId, appId))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPatch("RemoveFromWishlist")]
        [Authorize]
        public async Task<ActionResult> RemoveAppFromWishList(int appId)
        {
            var userId = await Helper.GetUserIdFromJwtToken(Request.Headers.Authorization);
            if (await _userService.RemoveAppFromWishlist(userId, appId))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPatch("AddToLibrary")]
        public async Task<ActionResult> AddAppToLibrary(int appId)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            await Console.Out.WriteLineAsync($"{appId}");
            Console.ResetColor();
            var userId = await Helper.GetUserIdFromJwtToken(Request.Headers.Authorization);
            if (await _userService.AddAppToLibrary(userId, appId))
            {
               return Ok();
            }
            return BadRequest();
        }
      
        [HttpPatch("AddFunds")]
        [Authorize]
        public async Task<ActionResult> AddFunds(double ammount)
        {
            var userId = await Helper.GetUserIdFromJwtToken(Request.Headers.Authorization);
            if (await _userService.AddFunds(userId, ammount))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult> UpdateUser([FromForm] UserEditDTO userDTO)
        {
            var userId = await Helper.GetUserIdFromJwtToken(Request.Headers.Authorization);
            userDTO.Id = userId;
            if (userDTO.ProfileFile != null)
            {              
                userDTO.ProfilePicture = await Helper.UploadImageLocally(userDTO.ProfileFile, "UserProfiles", _httpContextAccessor);
            }


            if (await _userService.UpdateUser(userDTO))
            {
                Helper.DeleteImageLocally(userDTO.ProfilePicture.Substring(37), "ImageProfiles");
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete]
        [Authorize]
        public async Task<ActionResult> DeleteUser()
        {
            var userId = await Helper.GetUserIdFromJwtToken(Request.Headers.Authorization);
            if (await _userService.DeleteUser(userId))
            {
                return Ok();
            }
            return BadRequest();

        }




    }
}
