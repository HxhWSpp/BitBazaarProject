using AppsApi.Data.Entities;
using AppsApi.DTOs.GenreDTOs;

namespace AppsApi.DTOs.AppDTOs
{
    public class AppEditDTO : AppRequestDTO
    {                          
        public ICollection<int>? GenresIdsToRemove { get; set; }

      
        public ICollection<int>? ImageIdsToRemove { get; set; }
        



    }
}
