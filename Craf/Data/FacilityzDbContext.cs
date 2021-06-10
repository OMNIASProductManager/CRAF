using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Facilityz.Models;

namespace Facilityz.Data
{
    public class FacilityzDbContext : DbContext
    {
        public FacilityzDbContext (DbContextOptions<FacilityzDbContext> options)
            : base(options)
        {
        }

        public DbSet<Facilityz.Models.Craf> Craf { get; set; }
    }
}
