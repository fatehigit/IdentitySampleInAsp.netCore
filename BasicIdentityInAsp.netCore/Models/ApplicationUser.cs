using Microsoft.AspNetCore.Identity;

namespace BasicIdentityInAsp.netCore.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FullName { get; set; }
        public bool IsActive { get; set; }
        public bool IsApproved { get; set; } = false;
        
    }
}
