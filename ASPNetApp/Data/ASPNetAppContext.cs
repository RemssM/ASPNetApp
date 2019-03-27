using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPNetApp.Models;

namespace ASPNetApp.Models
{
    public class ASPNetAppContext : DbContext
    {
        public ASPNetAppContext (DbContextOptions<ASPNetAppContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNetApp.Models.Movie> Movie { get; set; }

        public DbSet<ASPNetApp.Models.ToDo> ToDo { get; set; }
    }
}
