using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab13_miya.Models
{
    public class lab13_miyaContext : DbContext
    {
        public lab13_miyaContext (DbContextOptions<lab13_miyaContext> options)
            : base(options)
        {
        }

        public DbSet<lab13_miya.Models.Register> Register { get; set; }
    }
}
