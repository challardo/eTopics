using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace eTopics.Data.Models
{
   public class ApplicationUsers: IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        [PersonalData]
        public string LastName { get; set; }

        public string SubHeader { get; set; }
        public string AboutContent { get; set; }
    }
}
