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

namespace AppsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppsController : ControllerBase
    {
        private readonly IAppService _appService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AppsController(IAppService appService , IWebHostEnvironment webHostEnvironment , IHttpContextAccessor httpContextAccessor)
        {
            _appService = appService;
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: api/Apps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppDetailResponseDTO>>> GetApps()
        {
            return (await _appService.GetAppsAsync()).ToList();
        }

        [HttpPatch("RemoveGenre")]
        public async Task<ActionResult<AppDetailResponseDTO>> RemoveGenreFromApp(int appId, int genreId)
        {
            await _appService.RemoveGenreFromApp(appId, genreId);
            return CreatedAtAction("GetAppById", new { id = appId } ,appId);
        }

        [HttpPatch("AddGenre")]
        public async Task<ActionResult<AppDetailResponseDTO>> AddGenreToApp(int appId, int genreId)
        {
            await _appService.AddGenreToApp(appId, genreId);
            return CreatedAtAction("GetAppById", new { id = appId } ,appId);
        }



        // GET: api/Apps/ById/5
        [HttpGet("ById/{id}")]
        public async Task<ActionResult<AppDetailResponseDTO>> GetAppById(int id)
        {
            var app = await _appService.GetAppByIdAsync(id);

            if (app == null)
            {
                return NotFound();
            }

            return app;
        }

        // GET: api/Apps/ByName/Test
        [HttpGet("ByName/{name}")]
        public async Task<ActionResult<AppDetailResponseDTO>> GetAppByName(string name)
        {
            var app = await _appService.GetAppByNameAsync(name);

            if (app == null)
            {
                return NotFound();
            }

            return app;
        }

        // DELETE: api/Apps/5      
        [HttpDelete("{id}")]
        public async Task DeleteAppByid(int id)
        {                     
            await _appService.DeleteAppByIdAsync(id);            
        }

        // POST: api/Apps       
        [HttpPost]
        public async Task<ActionResult<AppDetailResponseDTO>> PostApp([FromForm]AppCreateDTO app)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }           

            var uploadFile = await Helper.UploadImageLocally(app.TitleCardFile , _webHostEnvironment , "TitleCards" , _httpContextAccessor);
            
            app.TitleCardPath = uploadFile;
            await _appService.AddAppAsync(app);

            return Ok();                              
        }

        [HttpPut]
        public async Task<ActionResult> UpdateApp([FromForm]AppRequestDTO app)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (app.TitleCardFile != null)
            {
                var uploadFile = await Helper.UploadImageLocally(app.TitleCardFile, _webHostEnvironment, "TitleCards" , _httpContextAccessor);                
                app.TitleCardPath = uploadFile;
                
            }
            await _appService.UpdateAppAsync(app);
            

            return Ok();

        }
    }
}
