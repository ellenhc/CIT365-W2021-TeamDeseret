using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MegaDesk.Data;
using System;
using System.Linq;

namespace MegaDesk.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDeskContext>>()))
            {
                // Look for any movies.
                if (context.DeskQuote.Any())
                {
                    return;   // DB has been seeded
                }

                context.DeskQuote.AddRange(
                    new DeskQuote
                    {
                        CustomerName = "Ellen Carlson",
                        QuoteDate = DateTime.Parse("2021-2-10"),
                        RushDays = 14,
                        Width = 25,
                        Depth = 15,
                        Drawers = 3,
                        SurfaceMaterial = DesktopMaterials.Oak,
                        Price = 550
                    },

                    new DeskQuote
                    {
                        CustomerName = "Jake Maughan",
                        QuoteDate = DateTime.Parse("2021-1-05"),
                        RushDays = 3,
                        Width = 24,
                        Depth = 12,
                        Drawers = 1,
                        SurfaceMaterial = DesktopMaterials.Laminate,
                        Price = 410

                    },

                    new DeskQuote
                    {
                        CustomerName = "Craig Kehl",
                        QuoteDate = DateTime.Parse("2021-2-25"),
                        RushDays = 5,
                        Width = 30,
                        Depth = 20,
                        Drawers = 2,
                        SurfaceMaterial = DesktopMaterials.Pine,
                        Price = 390
                    },

                    new DeskQuote
                    {
                        CustomerName = "Hilkias",
                        QuoteDate = DateTime.Parse("2021-1-18"),
                        RushDays = 7,
                        Width = 40,
                        Depth = 25,
                        Drawers = 5,
                        SurfaceMaterial = DesktopMaterials.Veneer,
                        Price = 615
                    }
                ); 
                context.SaveChanges();
            }
        }
    }
}
