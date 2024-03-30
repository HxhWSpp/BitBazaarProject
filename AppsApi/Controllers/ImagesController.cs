using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppsApi.Data;
using AppsApi.Data.Entities;
using AppsApi.Services;
using AppsApi.Services.Abstractions;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.CodeAnalysis.Operations;
using AppsApi.DTOs.ImageDTOs;
using AppsApi.DTOs.AppDTOs;
using AppsApi.Utils;

namespace AppsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {

        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IImageService _imageService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ImagesController(IImageService imageService, IWebHostEnvironment webHostEnvironment , IHttpContextAccessor httpContextAccessor)
        {
            _imageService = imageService;
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
    }

        

        [HttpPost("UploadImage")]
        public async Task<ActionResult> UploadImage([FromForm]ImageRequestDTO image)
        {
            var imagePath = await Helper.UploadImageLocally(image.ImageFile, _webHostEnvironment, "ImagesForApps" , _httpContextAccessor);
            image.ImagePath = imagePath;
            await _imageService.AddImageToAppAsync(image);
           
            return Ok();

        }

        [HttpPost("UploadMultipleImages")]
        public async Task<ActionResult> UploadMultipleImages([FromForm] ImagesRequestDTO image)
        {
            var imagePath = await Helper.UploadMultipleImagesLocally(image.ImageFiles, _webHostEnvironment, "ImagesForApps");
            image.ImagePaths = imagePath;
            await _imageService.AddMultipleImagesToAppAsync(image);

            return Ok();

        }

        [HttpGet("GetAppImages")]
        public async Task<ICollection<ImageResponseDTO>> GetAppImages(int appId)
        {
            return await _imageService.GetImagesOfAppAsync(appId);            
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteById(int id)
        {
            string path = await _imageService.DeleteImageByIdAsync(id);
            var _bool = Helper.DeleteImageLocally(path);
            if (_bool)
            {
                return Ok();
            }
            return StatusCode(500);
        }

        [HttpDelete("Multiple/{ids}")]
        public async Task<ActionResult> DeleteMultipleById(int[] id)
        {
            var paths = await _imageService.DeleteMultipleImagesByIdAsync(id);
            var _bool = Helper.DeleteMultipleImagesLocally(paths);
            if (_bool)
            {
                return Ok();
            }
            return StatusCode(500);
        }






    } 
}  
        
        