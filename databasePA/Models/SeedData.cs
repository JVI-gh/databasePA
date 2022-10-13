using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using databasePA.Data;
using System;
using System.Linq;

namespace databasePA.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new databasePAContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<databasePAContext>>()))
            {
                if (context.Country.Any())
                {
                    return;   
                }

                context.Country.AddRange(
                    new Country
                    {
                        id = "AF",
                        name = "Afghanistan"
                    },

                    new Country
                    {
                        id = "AX",
                        name = "Aland Islands"
                    },

                    new Country
                    {
                        id = "AL",
                        name = "Albania"
                    },

                    new Country
                    {
                        id = "DZ",
                        name = "Algeria"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}