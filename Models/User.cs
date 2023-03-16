using Microsoft.AspNetCore.Identity;

namespace iapCoursework2.Models
{
    public class AppUser : IdentityUser
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
