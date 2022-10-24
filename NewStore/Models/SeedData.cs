using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NewStore.Models
{
    public static class SeedData
    {   // заполение таблиц категорий и продуктов начальными данными
        public static void SeedDataBase(DataContext context)
        {
             context.Database.Migrate();
            if (context.Products.Count()==0 && context.Categories.Count()==0)
            {
                Category c1 = new Category { Name = "Popular" };
                Category c2 = new Category { Name = "TShirt", IsClothes=true };
                Category c3 = new Category { Name = "Shoes" };
                
                Category c5 = new Category { Name = "Pants", IsClothes = true };
                Category c6 = new Category { Name = "Sweater", IsClothes = true };
                Category c7 = new Category { Name = "Jacket", IsClothes = true };
                context.Categories.AddRange(c1, c2, c3);
                context.SaveChanges();

                context.Products.AddRange(
                new Product { Name = "Black T-Shirt", Price = 3000, Composition = "Cotton", Size = "M", Country = "USA", IsMan = true, Category = c2 },
                new Product { Name = "White T-Shirt", Price = 2500, Composition = "Syntetic", Size = "S", Country = "Italy", IsMan = true, Category = c2 },
                 new Product { Name = "Black Sneakers", Price = 8000, Composition = "Cotton", Size = "10", Country = "France", IsMan = true, Category = c3 },
                  new Product { Name = "White Sneakers", Price = 8000, Composition = "Cotton", Size = "9", Country = "Vietnam", IsMan = true, Category = c3 },
                    new Product { Name = "Levi's Jeans", Price = 5000, Composition = "Denim", Size = "M", Country = "Italy", IsMan = true, Category = c5 },
                      new Product { Name = "Lee Jeans", Price = 4500, Composition = "Denim", Size = "S", Country = "USA", IsMan = true, Category = c5},
                        new Product { Name = "Black Hoodie", Price = 6000, Composition = "Cotton", Size = "M", Country = "France", IsMan = true, Category = c6 },
                         new Product { Name = "White SweatShirt", Price = 6000, Composition = "Cotton", Size = "S", Country = "Russia", IsMan = true, Category = c6 },
                          new Product { Name = "Denim Jacket Levi's", Price = 10000, Composition = "Denim", Size = "M", Country = "Italy", IsMan = true, Category = c7 },
                           new Product { Name = "Raincoat", Price = 12000, Composition = "Cotton", Size = "S", Country = "Russia", IsMan = true, Category = c7 },

                new Product { Name = "Black woman T-Shirt", Price = 3000, Composition = "Cotton", Size = "M", Country = "USA", Category = c2 },
                new Product { Name = "White woman T-Shirt", Price = 2500, Composition = "Syntetic", Size = "S", Country = "Italy", Category = c2 },
                 new Product { Name = "Black woman Sneakers", Price = 8000, Composition = "Cotton", Size = "10", Country = "France", Category = c3 },
                  new Product { Name = "White woman Sneakers", Price = 8000, Composition = "Cotton", Size = "9", Country = "Vietnam", Category = c3 },
                    new Product { Name = "Levi's woman Jeans", Price = 5000, Composition = "Denim", Size = "M", Country = "Italy", Category = c5 },
                      new Product { Name = "Lee woman Jeans", Price = 4500, Composition = "Denim", Size = "S", Country = "USA", Category = c5 },
                        new Product { Name = "Black woman Hoodie", Price = 6000, Composition = "Cotton", Size = "M", Country = "France", Category = c6 },
                         new Product { Name = "White woman SweatShirt", Price = 6000, Composition = "Cotton", Size = "S", Country = "Russia", Category = c6 },
                          new Product { Name = "Denim woman Jacket Levi's", Price = 10000, Composition = "Denim", Size = "M", Country = "Italy", Category = c7 },
                           new Product { Name = "woman Raincoat", Price = 12000, Composition = "Cotton", Size = "S", Country = "Russia", Category = c7 }
                    );
                context.SaveChanges();
            }

          
        }
    }
}
