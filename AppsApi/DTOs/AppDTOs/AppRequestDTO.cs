using AppsApi.Data.Entities;
using AppsApi.DTOs.Abstractions;
using AppsApi.DTOs.GenreDTOs;
using AppsApi.DTOs.ImageDTOs;

namespace AppsApi.DTOs.AppDTOs
{
    public class AppRequestDTO : BaseRequestDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime ReleaseDate { get; set; }

        public virtual string? TitleCardPath { get; set; }

        public IFormFile? TitleCardFile { get; set; }

    }
}
