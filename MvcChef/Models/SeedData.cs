using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcChef.Data;
using MvcChef.Models;
using System;
using System.Linq;

namespace MvcChefs.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcChefContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcChefContext>>()))
            {
                // Look for any movies.
                if (context.Chef.Any())
                {
                    return;   // DB has been seeded
                }

                context.Chef.AddRange(
                    new Chef
                    {
                        FirstName = "Gordon",
                        LastName = "Ramsay",
                        Restaurant = "Hell's Kitchen"
                    },

                    new Chef
                    {
                        FirstName = "Guy",
                        LastName = "Fieri",
                        Restaurant = "Johnny Garlic's"
                    },

                    new Chef
                    {
                        FirstName = "Micheal",
                        LastName = "Caines",
                        Restaurant = "Mickeys Beach Bar and Restaurant"
                    },

                    new Chef
                    {
                        FirstName = "Jamie",
                        LastName = "Oliver",
                        Restaurant = "Jamie Oliver's Diner Piccadilly"
                    },
                    new Chef
                    {
                        FirstName = "Bobby",
                        LastName = "Flay",
                        Restaurant = "GATO"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}