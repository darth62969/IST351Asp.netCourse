using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCStuff.Models
{
    public class MVCStuffContext : DbContext
    {
        public MVCStuffContext (DbContextOptions<MVCStuffContext> options)
            : base(options)
        {
        }

        public DbSet<MVCStuff.Models.Student> Student { get; set; }
    }
}
