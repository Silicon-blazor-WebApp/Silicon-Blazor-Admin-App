using Microsoft.AspNetCore.Identity;

namespace Silicon_Blazor_Admin_App.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string RoleName { get; set; } = null!;
    }

}
