using AppsApi.Data.Entities.Abstractions;

namespace AppsApi.Data.Entities
{
    public class Developer : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProfilePath { get; set; }

        public virtual ICollection<App>? Apps { get; set; }
    }
}
