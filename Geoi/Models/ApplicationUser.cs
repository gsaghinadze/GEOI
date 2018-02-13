using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Geoi.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string Region { get; set; }

        public string School { get; set; }

        public string Class { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PersonID { get; set; }
        public string Password { get; set; }
    }
}
