using System.Collections;
using System.ComponentModel;
using Microsoft.AspNetCore.Identity;

namespace Adventures.Data
{
    public class User:IdentityUser
    {
        [DisplayName("First name")]
        public string FirstName { get; set; }
        
        [DisplayName("Last name")]
        public string LastName { get; set; }

        public virtual ICollection<EventReservation> EventReservations { get; set; }
    }
}
