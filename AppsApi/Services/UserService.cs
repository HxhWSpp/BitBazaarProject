using AppsApi.Data.Entities;
using AppsApi.Data.Repositories.Abstractions;
using AppsApi.DTOs.UserDTOs;
using AppsApi.Services.Abstractions;
using AppsApi.Utils;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace AppsApi.Services
{
    public class UserService : IUserService
    {
        private readonly IAppRepository _appRepository;
        private readonly IReviewRepository _reviewRepository;
        private readonly UserManager<User> _userManager;

        private readonly IMapper _mapper;
        public UserService(IAppRepository appService, UserManager<User> userManager, IMapper mapper , IReviewRepository reviewRepository)
        {
            _appRepository = appService;
            _reviewRepository = reviewRepository;
            _userManager = userManager;    
            _mapper = mapper;
        }

               
        public async Task<bool> AddAppToWishlist(string userId, int appId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            var app = await _appRepository.GetByIdAsync(appId);
            if (user == null && app == null )
            {
                throw new Exception("Either app or user are null");                
            }
            else
            {
                if (!user.AppsLibrary.Contains(app))
                {
                    user.AppsWishlist.Add(app);
                    return (await _userManager.UpdateAsync(user)).Succeeded;
                }
                else
                {
                    throw new Exception($"{app.Title} is already in User's Library");
                }


            }           

        }

        public async Task<UserDetailResponseDTO> GetUserDetail(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            return _mapper.Map<UserDetailResponseDTO>(user);
        }

        public async Task<UserResponseDTO> GetUserById(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            return _mapper.Map<UserResponseDTO>(user);
        }

        public async Task<ICollection<UserResponseDTO>> GetUsers()
        {
            var users = await _userManager.Users.ToListAsync();
            return _mapper.Map<ICollection<UserResponseDTO>>(users);
        }

        public async Task<string> Login(UserLoginDTO user , IConfigurationSection _jwtSettings)
        {
            var authUser = await _userManager.FindByEmailAsync(user.Email);

            if (authUser != null && await _userManager.CheckPasswordAsync(authUser, user.Password))
            {
                var signingCredentials = Helper.GetSigningCredentials(_jwtSettings);
                var claims = await Helper.GetClaims(authUser , _userManager);
                var tokenOptions = Helper.GenerateTokenOptions(signingCredentials, claims , _jwtSettings);
                var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                return token;
            }
            else
            {
                return "Invalid Auth";
            }
        }

        public async Task<bool> Register(UserRegisterDTO userRegister)
        {
            var user = _mapper.Map<User>(userRegister);
            user.Wallet = 0;
            var userCreated = await _userManager.CreateAsync(user, userRegister.Password);

            if (userCreated.Succeeded)
            {
                return true;
            }
            else
            {
                throw new Exception($"{userCreated.Errors}");
            }
        }

        public async Task<bool> RemoveAppFromWishlist(string userId, int appId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            var app = await _appRepository.GetByIdAsync(appId);
            if (user == null && app == null)
            {
                throw new Exception("Either app or user are null");
            }
            else
            {
                user.AppsWishlist.Remove(app);
                return (await _userManager.UpdateAsync(user)).Succeeded;
            }
        }

        public async Task<bool> AddAppToLibrary(string userId, int appId)
        {
            var user = await _userManager.FindByIdAsync(userId);           
            var app = await _appRepository.GetByIdAsync(appId);
            if (user == null && app == null)
            {
                throw new Exception("Either app or user are null");
            }
            else
            {
                if (user.AppsWishlist.Contains(app))
                {
                    user.AppsWishlist.Remove(app);
                }
                user.AppsLibrary.Add(app);
                user.Wallet -= app.Price;
                return (await _userManager.UpdateAsync(user)).Succeeded;
            }
        }

        public async Task<bool> UpdateUser(UserEditDTO userDTO)
        {
            var userEntity = await _userManager.FindByIdAsync(userDTO.Id);
            if (userEntity == null)
            {
                throw new Exception($"{userDTO.Id} - User does not exist");
            }
            else
            {
                userEntity.UserName = userDTO.UserName;
                userEntity.Description = userDTO.Description;
                userEntity.ProfilePicture = userDTO.ProfilePicture;
                return (await _userManager.UpdateAsync(userEntity)).Succeeded;
            }
        }

        public async Task<bool> AddFunds(string userId, double ammount)
        {
            var userEntity = await _userManager.FindByIdAsync(userId);
            if (userEntity == null)
            {
                throw new Exception($"{userId} - User does not exist");
            }
            else
            {
                userEntity.Wallet += ammount;
                return (await _userManager.UpdateAsync(userEntity)).Succeeded;
            }
        }

        public async Task<bool> DeleteUser(string userId)
        {
            var userEntity = await _userManager.FindByIdAsync(userId);
            if (userEntity == null)
            {
                throw new Exception($"{userId} - User does not exist");
            }
            else
            {
                

                if ((await _userManager.DeleteAsync(userEntity)).Succeeded)
                {
                    Helper.DeleteImageLocally(userEntity.ProfilePicture.Substring(37), "ImageProfiles");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
