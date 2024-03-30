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
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DevelopersController(IDeveloperService developerService , IWebHostEnvironment webHostEnvironment ,IHttpContextAccessor httpContextAccessor)
        {
            _developerService = developerService;
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
        }

       
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeveloperDetailResponseDTO>>> GetDevelopers()
        {
            return (await _developerService.GetDevelopersAsync()).ToList();
        }

        
        [HttpPost]
        public async Task<ActionResult<DeveloperDetailResponseDTO>> PostDeveloper([FromForm]DeveloperCreateDTO dev)
        {
            var uploadFile = await Helper.UploadImageLocally(dev.ProfileFile, _webHostEnvironment, "ImageProfiles" , _httpContextAccessor);

            dev.ProfilePath = uploadFile;
            await _developerService.AddDeveloperAsync(dev);
            return Ok();
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<DeveloperDetailResponseDTO>> GetDeveloperById(int id)
        {
            var dev = await _developerService.GetDeveloperByIdAsync(id);

            if (dev == null)
            {
                return NotFound();
            }

            return dev;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteById(int id)
        {
            await _developerService.DeleteDeveloperByIdAsync(id);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateDeveloper([FromForm] DeveloperRequestDTO dev)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (dev.ProfilePath == null)
            {
                var uploadFile = await Helper.UploadImageLocally(dev.ProfileFile, _webHostEnvironment, "ImageProfiles" , _httpContextAccessor);
                dev.ProfilePath = uploadFile;

            }
            await _developerService.UpdateDeveloperAsync(dev);


            return Ok();

        }
    }
}
