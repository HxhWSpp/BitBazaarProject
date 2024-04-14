using Microsoft.AspNetCore.Identity;

namespace AppsApi.Data.Entities
{
    public class User : IdentityUser
    {
        public User()
        {
            Reviews = new HashSet<Review>();
            AppsWishlist = new HashSet<App>();
            AppsLibrary = new HashSet<App>();
        }
        public string Description { get; set; }
        public string ProfilePicture { get; set; }
        public double Wallet { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; }
        public virtual ICollection<App>? AppsWishlist { get; set; }
        public virtual ICollection<App>? AppsLibrary { get; set; }
    }
}
