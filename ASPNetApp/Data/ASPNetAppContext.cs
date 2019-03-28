using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPNetApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ASPNetApp.Models
{
    public class ASPNetAppContext : IdentityDbContext<User>
    {
        public ASPNetAppContext (DbContextOptions<ASPNetAppContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNetApp.Models.Movie> Movie { get; set; }

        public DbSet<ASPNetApp.Models.ToDo> ToDo { get; set; }
        
    }
}
