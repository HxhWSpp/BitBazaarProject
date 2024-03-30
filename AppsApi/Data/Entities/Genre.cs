using AppsApi.Data.Entities.Abstractions;

namespace AppsApi.Data.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<App>? Apps { get; set; }
    }
}
