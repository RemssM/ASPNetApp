using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetApp.Models
{
    public class User : IdentityUser
    {
        public string nom { get; set; }
        public string prenom { get; set; }
    }
}
