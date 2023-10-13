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
            using (var context = new TanejaShoeStoreContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TanejaShoeStoreContext>>()))
            {
                // Look for any movies.
                if (context.Shoe.Any())
                {
                    return;   // DB has been seeded
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
                },
                new Shoe
                {
                    ModelName = "Geox",
                    ReleaseDate = DateTime.Parse("2021-08-21"),
                    Category = "School Uniform",
                    Price = 51.38M,
                    Ratings = 5
                },
                  new Shoe
                  {
                      ModelName = "Sketchers",
                      ReleaseDate = DateTime.Parse("2011-04-19"),
                      Category = "Keds kids",
                      Price = 51.38M,
                      Ratings = 5
                  },
                    new Shoe
                    {
                        ModelName = "New Balance",
                        ReleaseDate = DateTime.Parse("2021-08-21"),
                        Category = "Running Shoe",
                        Price = 51.38M,
                        Ratings = 5
                    },
                     new Shoe
                     {
                         ModelName = "New Balance",
                         ReleaseDate = DateTime.Parse("2019-05-26"),
                         Category = "Belly",
                         Price = 51.38M,
                         Ratings = 4
                     },
                      new Shoe
                      {
                          ModelName = "Gaga Boot",
                          ReleaseDate = DateTime.Parse("2012-09-21"),
                          Category = "Women Boot Shoe",
                          Price = 11.00M,
                          Ratings = 1
                      },
                       new Shoe
                       {
                           ModelName = "Puma",
                           ReleaseDate = DateTime.Parse("2011-15-16"),
                           Category = "Unisex Running Shoe",
                           Price = 81.18M,
                           Ratings = 5
                       }


                );
                context.SaveChanges();



            }

        }

    }
}