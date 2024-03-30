using AppsApi.Data.Entities.Abstractions;

namespace AppsApi.Data.Entities
{
    public class Image : BaseEntity
    {            
        public string ImagePath { get; set; }
        public virtual App? App { get; set; }

    }
}
