using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SimpleStore.Infrastructure.Data;
using SimpleStore.Infrastructure.Entities;
using System.Linq;

namespace SimpleStore.Infrastructure.Models
{
    public static class SeedSimpleStoreData
    {
        public static void EnsurePopolated(IApplicationBuilder app)
        {
            SinpleStoreDbContext context = app.ApplicationServices.GetRequiredService<SinpleStoreDbContext>();

            context.Database.Migrate();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category
                    {
                        Name = "Mug"
                    },
                    new Category
                    {
                        Name = "T-Shirt"
                    },
                    new Category
                    {
                        Name = "Sheet"
                    }
                    );

                context.SaveChanges();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = ".NET Foundation Sheet",
                        Description = ".NET Foundation Sheet",
                        Price = 275,
                        PictureUri = "/images/products/10.png",
                        CategoryId = 1
                    },
                    new Product
                    {
                        Name = ".NET Black & White Mug",
                        Description = ".NET Black & White Mug",
                        Price = 8.50M,
                        PictureUri = "/images/products/2.png",
                        CategoryId = 2
                    },
                    new Product
                    {
                        Name = ".NET Bot Black Sweatshirt",
                        Description = ".NET Bot Black Sweatshirt",
                        Price = 50,
                        PictureUri = "/images/products/1.png",
                        CategoryId = 3
                    },
                    new Product
                    {
                        Name = "Prism White T-Shirt",
                        Description = "Prism White T-Shirt",
                        Price = 12,
                        PictureUri = "/images/products/3.png",
                        CategoryId = 2
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
