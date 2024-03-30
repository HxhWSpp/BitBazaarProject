using AppsApi.Data.Entities.Abstractions;

namespace AppsApi.Data.Entities
{
    public class App : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string TitleCardPath { get; set; }

       
        public virtual Developer? Developer { get; set; }


        public virtual ICollection<Genre>? Genres { get; set; } = new HashSet<Genre>(){};

        public virtual ICollection<Image>? Images { get; set; } = new HashSet<Image>() {};

        public virtual ICollection<Review>? Reviews { get; set; }
    }
}
