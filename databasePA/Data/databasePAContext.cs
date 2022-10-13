using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using databasePA.Models;

namespace databasePA.Data
{
    public class databasePAContext : DbContext
    {
        public databasePAContext (DbContextOptions<databasePAContext> options)
            : base(options)
        {
        }

        public DbSet<databasePA.Models.Country> Country { get; set; } = default!;
    }
}
