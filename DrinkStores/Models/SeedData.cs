using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace DrinkStores.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Water",
                        Description= "this is a category use for drink",
                        Img = "...MilkTea.png",
                        Price = 123,
                        Discount = 1,
                        Status = "stocking"
                    },
                    new Product
                    {
                        Name = "Mikl Tea",
                        Description = "this is a category use for drink",
                        Img = "...MilkTea.png",
                        Price = 123,
                        Discount = 1,
                        Status = "stocking"
                    },
                    new Product
                    {
                        Name = "Mikl Tea",
                        Description = "this is a category use for drink",
                        Img = "...MilkTea.png",
                        Price = 123,
                        Discount = 1,
                        Status = "stocking"
                    },
                    new Product
                    {
                        Name = "Mikl Tea",
                        Description = "this is a category use for drink",
                        Img = "...MilkTea.png",
                        Price = 123,
                        Discount = 2,
                        Status = "stocking"
                    },
                    new Product
                    {
                        Name = "Mikl Tea",
                        Description = "this is a category use for drink",
                        Img = "...MilkTea.png",
                        Price = 123,
                        Discount = 2,
                        Status = "stocking"
                    },
                    new Product
                    {
                        Name = "Mikl Tea",
                        Description = "this is a category use for drink",
                        Img = "...MilkTea.png",
                        Price = 123,
                        Discount = 2,
                        Status = "stocking"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
