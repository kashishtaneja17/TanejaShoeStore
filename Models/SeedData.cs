using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TanejaShoeStore.Data;
using System;
using System.Linq;


namespace TanejaShoeStore.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new TanejaShoeStoreContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TanejaShoeStoreContext>>());
            //lOOKING FOR ANY SHOE
           // if (context.Shoe.Any())
            {
                return; //db has been seeded
            }
            context.Shoe.AddRange(
                new Shoe
                {

                    ModelName = "Nike",
                    ReleaseDate = DateTime.Parse("2022-10-09"),
                    Category = "Running",
                    Price = 44.99M,
                    Ratings = 5

                },
                new Shoe
                {

                    ModelName = "Reebok",
                    ReleaseDate = DateTime.Parse("2022-12-10"),
                    Category = "Gym Athletic Shoes",
                    Price = 110.22M,
                    Ratings = 4
                },
                new Shoe
                {

                    ModelName = "Under Armour",
                    ReleaseDate = DateTime.Parse("2023-01-16"),
                    Category = "Sneaker",
                    Price = 91.99M,
                    Ratings = 3
                },
                new Shoe
                {

                    ModelName = "Adidas",
                    ReleaseDate = DateTime.Parse("2023-11-10"),
                    Category = "Running",
                    Price = 56.98M,
                    Ratings = 5
                }
                );
            context.SaveChanges();



        }



    }
}
