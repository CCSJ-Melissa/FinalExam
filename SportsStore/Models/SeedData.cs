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
            if (!context.Items.Any())
            {
                context.Items.AddRange(
                    new Item
                    {
                        Description = "Antistatic Wipes",
                        UnitsOnHand = 30,
                        Cost = 0.15m,
                        SellingPrice = 0.25m
                    },
                    new Item
                    {
                        Description = "CD Wallet",
                        UnitsOnHand = 12,
                        Cost = 3.45m,
                        SellingPrice = 4.00m
                    },
                    new Item
                    {
                        Description = "Desktop Holder",
                        UnitsOnHand = 4,
                        Cost = 3.85m,
                        SellingPrice = 4.75m,
                    },
                    new Item
                    {
                        Description = "Disks",
                        UnitsOnHand = 175,
                        Cost = 0.20m,
                        SellingPrice = 0.75m,
                    },
                    new Item
                    {
                        Description = "Disk Cases",
                        UnitsOnHand = 12,
                        Cost = 2.20m,
                        SellingPrice = 2.75m,
                    },
                    new Item
                    {
                        Description = "Mouse Holder",
                        UnitsOnHand = 10,
                        Cost = 0.80m,
                        SellingPrice = 1.00m
                    },
                    new Item
                    {
                        Description = "Mouse Pad",
                        UnitsOnHand = 25,
                        Cost = 2.25m,
                        SellingPrice = 3.00m
                    },
                    new Item
                    {
                        Description = "PC Tool Kit",
                        UnitsOnHand = 9,
                        Cost = 7.80m,
                        SellingPrice = 9.00m
                    },
                    new Item
                    {
                        Description = "Wrist Rest",
                        UnitsOnHand = 3,
                        Cost = 2.90m,
                        SellingPrice = 3.25m
                    }
                    );
                context.SaveChanges();

            }
        }
    }
}