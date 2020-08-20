using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GIWEB.Models;

namespace GIWEB.Data
{
    public class GIWEBContext : DbContext
    {
        public GIWEBContext (DbContextOptions<GIWEBContext> options)
            : base(options)
        {
        }

        public DbSet<Owner> Owner { get; set; }
        public DbSet<Propertie> Propertie { get; set; }
        public DbSet<Tenant> Tenant { get; set; }
        public DbSet<Spouse> Spouse { get; set; }
        public DbSet<Guarantor> Guarantor { get; set; }
        public DbSet<Contract> Contract { get; set; }
        public DbSet<Plots> Plots { get; set; }
    }
}
