using Microsoft.AspNetCore.Identity;
using System.Collections.ObjectModel;

namespace Gym.Models
{
    public class ApplicationUser : IdentityUser
    {

        public ICollection<ApplicationUserGymClass> AttendedClasses { get; set; }
    }
}
