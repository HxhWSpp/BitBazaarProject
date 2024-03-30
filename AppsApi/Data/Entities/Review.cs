using AppsApi.Data.Entities.Abstractions;

namespace AppsApi.Data.Entities
{
    public class Review : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Recommended { get; set; }

        public virtual App? App { get; set; }
    }
}
