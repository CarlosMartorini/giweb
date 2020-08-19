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

        public DbSet<GIWEB.Models.Owners> Owners { get; set; }
    }
}
