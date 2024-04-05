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
using AppsApi.DTOs.AppDTOs;
using AppsApi.DTOs.GenreDTOs;
using AppsApi.Services;
using AppsApi.Utils;

namespace AppsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreService _genreService;

        public GenresController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        // GET: api/Genres
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GenreResponseDTO>>> GetGenres()
        {
            return (await _genreService.GetGenresAsync()).ToList();
        }

        // POST: api/Genres       
        [HttpPost]
        public async Task<ActionResult<GenreResponseDTO>> PostGenre(GenreRequestDTO genre)
        {
            if (await _genreService.AddGenreAsync(genre))
            {
                return Ok();
            }
            return StatusCode(500);

        }

        // GET : api/Genres/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GenreResponseDTO>> GetGenreById(int id)
        {
            var genre = await _genreService.GetGenreByIdAsync(id);

            if (genre == null)
            {
                return NotFound();
            }

            return genre;
        }

        [HttpGet("GetGenreDetails/{id}")]
        public async Task<ActionResult<GenreDetailResponseDTO>> GetGenreDetailsById(int id)
        {
            var genre = await _genreService.GetGenreDetailsByIdAsync(id);

            if (genre == null)
            {
                return NotFound();
            }

            return genre;
        }

        // DELETE : api/Genres/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteGenreById(int id)
        {
            if(await _genreService.DeleteGenreByIdAsync(id))
            {
                return Ok();
            }
            return StatusCode(500);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateApp(GenreRequestDTO genre)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           
            if (await _genreService.UpdateGenreAsync(genre) == true)
            {
                return Ok();
            }
            return StatusCode(500);

        }

    }
}
