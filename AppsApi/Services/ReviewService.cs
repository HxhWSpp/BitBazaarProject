using AppsApi.Data.Entities;
using AppsApi.Data.Repositories;
using AppsApi.Data.Repositories.Abstractions;
using AppsApi.DTOs.GenreDTOs;
using AppsApi.DTOs.ReviewDTOs;
using AppsApi.Services.Abstractions;
using AutoMapper;
using Humanizer.Localisation;
using Microsoft.AspNetCore.Identity;
using System.Xml.Linq;

namespace AppsApi.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly UserManager<User> _userManager;
        private readonly IAppRepository _appRepository;
        private readonly IMapper _mapper;
        public ReviewService(IReviewRepository reviewRepository , IMapper mapper , IAppRepository appRepository , UserManager<User> userManager)
        {
            _reviewRepository = reviewRepository;
            _appRepository = appRepository;
            _userManager = userManager;
            _mapper = mapper;
        }
        public async Task<bool> AddReviewAsync(ReviewRequestDTO review)
        {
            var reviewEntity = _mapper.Map<Review>(review);
            var appEntity = await _appRepository.GetByIdAsync(review.AppId);
            var userEntity = await _userManager.FindByIdAsync(review.UserId);
            reviewEntity.App = appEntity;
            reviewEntity.User = userEntity;

           return await _reviewRepository.AddAsync(reviewEntity);
        }

        public async Task<bool> DeleteReviewByIdAsync(int id)
        {
            return await _reviewRepository.DeleteByIdAsync(id);
        }

        public async Task<ReviewResponseDTO> GetReviewByIdAsync(int id)
        {
            var reviewEntity = await _reviewRepository.GetByIdAsync(id);
            return _mapper.Map<ReviewResponseDTO>(reviewEntity);
        }

        public async Task<ReviewResponseDTO> GetReviewByNameAsync(string name)
        {
            var reviewEntity = (await _reviewRepository.GetAsync(item => item.Title == name)).FirstOrDefault();
            return _mapper.Map<ReviewResponseDTO>(reviewEntity);
        }

        public async Task<ICollection<ReviewResponseDTO>> GetReviewsAsync()
        {
            var reviewList = (await _reviewRepository.GetAllAsync(null)).ToList();
            return _mapper.Map<ICollection<ReviewResponseDTO>>(reviewList);
        }

        public async Task<ICollection<ReviewResponseDTO>> GetReviewsOfApp(int appId)
        {
            var reviewEntity = (await _reviewRepository.GetAsync(item => item.App.Id == appId)).ToList();
            return _mapper.Map<ICollection<ReviewResponseDTO>>(reviewEntity);
        }

        public Task<bool> UpdateReviewAsync(ReviewRequestDTO review)
        {
            var reviewEntity = _mapper.Map<Review>(review);
            return _reviewRepository.UpdateAsync(reviewEntity);
        }
    }
}
