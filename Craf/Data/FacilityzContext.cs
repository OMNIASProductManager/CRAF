using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Facilityz.Models;

namespace Facilityz.Data
{
    public class FacilityzContext : DbContext
    {
        public FacilityzContext (DbContextOptions<FacilityzContext> options)
            : base(options)
        {
        }

        public DbSet<Facilityz.Models.Craf> Craf { get; set; }

        public DbSet<Facilityz.Models.User> User { get; set; }
    }
}
