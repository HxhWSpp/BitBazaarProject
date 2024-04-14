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
using AppsApi.DTOs.ReviewDTOs;
using Microsoft.AspNetCore.Authorization;
using AppsApi.Utils;

namespace AppsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {

        private readonly IReviewService _reviewService;

        public ReviewsController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        // GET: api/Reviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReviewResponseDTO>>> GetReviews()
        {
            return (await _reviewService.GetReviewsAsync()).ToList();
        }

        // GET: api/Reviews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReviewResponseDTO>> GetReview(int id)
        {
            var review = await _reviewService.GetReviewByIdAsync(id);

            if (review == null)
            {
                return NotFound();
            }

            return review;
        }

        // POST: api/Reviews
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<ReviewResponseDTO>> PostReview(ReviewRequestDTO review)
        {
            review.UserId = await Helper.GetUserIdFromJwtToken(Request.Headers.Authorization);
            await _reviewService.AddReviewAsync(review);
            return CreatedAtAction("GetReview", new { id = review.Id }, review);
        }

        // DELETE: api/Reviews/5
        [HttpDelete("{id}")]
        public async Task DeleteReview(int id)
        {
            await _reviewService.DeleteReviewByIdAsync(id);
        }

        [HttpGet("ReviewsOfApp/{appId}")]
        public async Task<ICollection<ReviewResponseDTO>> GetReviewsOfApp(int appId)
        {
            return await _reviewService.GetReviewsOfApp(appId);
        }
    }
}
