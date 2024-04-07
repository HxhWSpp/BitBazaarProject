using Microsoft.AspNetCore.Identity;

namespace AppsApi.Data.Entities
{
    public class User : IdentityUser
    {
        
        public string Description { get; set; }
        public string ProfilePicture { get; set; }
        //public virtual ICollection<Review>? Reviews { get; set; }
        //public virtual ICollection<App>? Wishlist { get; set; }
        //public virtual ICollection<App>? Library { get; set; }
    }
}
