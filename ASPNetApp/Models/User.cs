using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetApp.Models
{
    public class User : IdentityUser
    {
        [PersonalData]
        public string nom { get; set; }
        [PersonalData]
        public string prenom { get; set; }

    }
}
