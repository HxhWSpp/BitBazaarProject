using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppsApi.Data;
using AppsApi.Data.Entities;
using AppsApi.Services.Abstractions;
using AppsApi.Services;
using Humanizer.Localisation;
using AppsApi.DTOs.AppDTOs;
using AppsApi.DTOs.GenreDTOs;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.OpenApi.Writers;
using AppsApi.Utils;
using AutoMapper.Configuration.Annotations;
using Microsoft.AspNetCore.Authorization;

namespace AppsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppsController : ControllerBase
    {
        private readonly IAppService _appService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AppsController(IAppService appService, IHttpContextAccessor httpContextAccessor)
        {
            _appService = appService;           
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: api/Apps
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<AppResponseDTO>>> GetApps()
        {
            return (await _appService.GetAppsAsync()).ToList();
        }
       

        // GET: api/Apps/ById/5
        [HttpGet("Details/{id}")]
        public async Task<ActionResult<AppDetailResponseDTO>> GetAppDetailsById(int id)
        {
            var app = await _appService.GetAppDetailsByIdAsync(id);

            if (app == null)
            {
                return NotFound();
            }

            return app;
        }

        // GET: api/Apps/ByName/Test
        [HttpGet("DetailsByName/{name}")]
        public async Task<ActionResult<AppDetailResponseDTO>> GetAppDetailsByName(string name)
        {
            var app = await _appService.GetAppDetailsByNameAsync(name);

            if (app == null)
            {
                return NotFound();
            }

            return app;
        }

       

        // DELETE: api/Apps/5      
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAppByid(int id)
        {                     
            if(await _appService.DeleteAppByIdAsync(id) == true)
            {
                return Ok();
            }
            return StatusCode(500);
        }

        // POST: api/Apps       
        [HttpPost]
        public async Task<ActionResult<AppDetailResponseDTO>> PostApp([FromForm]AppCreateDTO app)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            if (app.TitleCardFile != null & app.ImageFiles != null)
            {
                var uploadFile = await Helper.UploadImageLocally(app.TitleCardFile, "TitleCards", _httpContextAccessor);
                app.TitleCardPath = uploadFile;
                var uploadFiles = await Helper.UploadMultipleImagesLocally(app.ImageFiles, "ImagesForApps", _httpContextAccessor);
                app.ImagePaths = uploadFiles;

                if (await _appService.AddAppAsync(app) == true)
                {
                    return Ok();
                }
                
                return StatusCode(500);
            }
            else
            {
                return BadRequest();
            }                              
        }


        [HttpPut]
        public async Task<ActionResult> UpdateApp([FromForm]AppEditDTO app)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (app.TitleCardFile != null)
            {               
               
                var uploadFile = await Helper.UploadImageLocally(app.TitleCardFile, "TitleCards", _httpContextAccessor);
                app.TitleCardPath = uploadFile;
            }

            if (app.ImageFiles != null)
            {
                var uploadFiles = await Helper.UploadMultipleImagesLocally(app.ImageFiles, "ImagesForApps", _httpContextAccessor);
                app.ImagePaths = uploadFiles;
            }

            if (await _appService.UpdateAppAsync(app) == true)
            {
                return Ok();
            }
            return StatusCode(500);
           

            

        }
    }
}
