using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Item
                    {
                        Name = "Kayak", Description = "A boat for one person",
                        Category = "Watersports", Price = 275
                    },
                    new Item
                    {
                        Name = "LIfejacket",
                        Description = "Protective and fasionable",
                        Category = "Watersports",
                        Price = 48.50m
                    },
                    new Item
                    {
                        Name = "Soccer Ball",
                        Description = "FIFA-Approved size and weight",
                        Category = "Soccer", Price = 19.50m,
                    },
                    new Item
                    {
                        Name = "Corner Flags",
                        Description = "Give your playing feild a professional touch",
                        Category = "Soccer", Price = 34.95m,
                    },
                    new Item
                    {
                        Name = "Stadium",
                        Description = "Flat-packed 35,000-seat stadium",
                        Category = "Soccer", Price = 79500,
                    },
                    new Item
                    {
                        Name = "Thinking Cap",
                        Category = "Chess",
                        Description = "Improve brain efficiency by 75%", Price = 16
                    },
                    new Item
                    {
                        Name = "Unsteady Chair",
                        Description = "Secretly give your opponent an unfair advantage",
                        Category = "Chess",
                        Price = 29.95m
                    },
                    new Item
                    {
                        Name = "Human Chess Board",
                        Description = "Fun for the whole family",
                        Category = "Chess", Price = 75
                    },
                    new Item
                    {
                        Name = "Bling-Bling King",
                        Description = "Gold-plated, diamon-studded King",
                        Category = "Chess", Price = 1200
                    }
                    );
                context.SaveChanges();
           
            }
        }
    }
}
