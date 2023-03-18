using Microsoft.AspNetCore.Identity;

namespace Adventures.Data
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid RoleId { get; set; }

    }
}
