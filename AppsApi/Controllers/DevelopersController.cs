using AppsApi.DTOs.AppDTOs;
using AppsApi.DTOs.DeveloperDTOs;
using AppsApi.DTOs.GenreDTOs;
using AppsApi.Services;
using AppsApi.Services.Abstractions;
using AppsApi.Utils;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace AppsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevelopersController : ControllerBase
    {
        private readonly IDeveloperService _developerService;
  
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DevelopersController(IDeveloperService developerService ,IHttpContextAccessor httpContextAccessor)
        {
            _developerService = developerService;          
            _httpContextAccessor = httpContextAccessor;
        }

       
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeveloperDetailResponseDTO>>> GetDevelopers()
        {
            return (await _developerService.GetDevelopersAsync()).ToList();
        }

        
        [HttpPost]
        public async Task<ActionResult<DeveloperDetailResponseDTO>> PostDeveloper([FromForm]DeveloperRequestDTO dev)
        {
            var uploadFile = await Helper.UploadImageLocally(dev.ProfileFile, "ImageProfiles" , _httpContextAccessor);

            dev.ProfilePath = uploadFile;
            if (await _developerService.AddDeveloperAsync(dev) == true)
            {
                return Ok();
            }

            return StatusCode(500); 
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<DeveloperDetailResponseDTO>> GetDeveloperDetailsById(int id)
        {
            var dev = await _developerService.GetDeveloperDetailsByIdAsync(id);

            if (dev == null)
            {
                return NotFound();
            }

            return dev;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteById(int id)
        {
            if(await _developerService.DeleteDeveloperByIdAsync(id))
            {
                return Ok();
            }
            return StatusCode(500);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateDeveloper([FromForm] DeveloperRequestDTO dev)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var oldProfilePath = dev.ProfilePath.Substring(37);
            if (dev.ProfileFile != null)
            {
                var uploadFile = await Helper.UploadImageLocally(dev.ProfileFile, "ImageProfiles" , _httpContextAccessor);
               dev.ProfilePath = uploadFile;

            }
            if(await _developerService.UpdateDeveloperAsync(dev) == true)
            {
                Helper.DeleteImageLocally(oldProfilePath , "ImageProfiles");
                return Ok();
            }

            return StatusCode(500);

        }
    }
}
