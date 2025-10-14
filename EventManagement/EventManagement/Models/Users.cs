using Microsoft.AspNetCore.Identity;

namespace EventManagement.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
