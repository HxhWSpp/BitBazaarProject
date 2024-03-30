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
            await _genreService.AddGenreAsync(genre);
            return CreatedAtAction("GetGenreById", new { id = genre.Id }, genre);
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

        [HttpGet("GetAppsByGenre/{id}")]
        public async Task<ActionResult<GenreDetailResponseDTO>> GetAppsByGenre(int id)
        {
            var genre = await _genreService.GetAppsByGenreId(id);

            if (genre == null)
            {
                return NotFound();
            }

            return genre;
        }

        // DELETE : api/Genres/5
        [HttpDelete("{id}")]
        public async Task DeleteGenreById(int id)
        {
            await _genreService.DeleteGenreByIdAsync(id);
        }

    }
}
