using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TootedJaKategooriad
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite
            ("Data Source=products.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName="Burgers" },
                new Category { CategoryID = 2, CategoryName="Vegetables" },
                new Category { CategoryID = 3, CategoryName="Cereals" },
                new Category { CategoryID = 4, CategoryName="Fruits" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, CategoryID = 1, ProductName = "Big mac" },
                new Product { ProductID = 2, CategoryID = 1, ProductName = "Cheese burger" },
                new Product { ProductID = 3, CategoryID = 1, ProductName = "Octuple bypass burger" },
                new Product { ProductID = 4, CategoryID = 1, ProductName = "Chicken burger" },
                new Product { ProductID = 5, CategoryID = 1, ProductName = "Vegan burger" },
                new Product { ProductID = 6, CategoryID = 1, ProductName = "Ham burger" },
                new Product { ProductID = 7, CategoryID = 1, ProductName = "Chili burger" },
                new Product { ProductID = 8, CategoryID = 1, ProductName = "Bacon cheeseburger" },
                new Product { ProductID = 9, CategoryID = 2, ProductName = "Spinach" },
                new Product { ProductID = 10, CategoryID = 2, ProductName = "Potato" },
                new Product { ProductID = 11, CategoryID = 2, ProductName = "Cucumber" },
                new Product { ProductID = 12, CategoryID = 2, ProductName = "Beet" },
                new Product { ProductID = 13, CategoryID = 2, ProductName = "Lettuce" },
                new Product { ProductID = 14, CategoryID = 2, ProductName = "Tomato" },
                new Product { ProductID = 15, CategoryID = 2, ProductName = "Onion" },
                new Product { ProductID = 16, CategoryID = 2, ProductName = "Radish" },
                new Product { ProductID = 17, CategoryID = 3, ProductName = "Kellogg's corn flakes" },
                new Product { ProductID = 18, CategoryID = 3, ProductName = "Honey nut cheerios" },
                new Product { ProductID = 19, CategoryID = 3, ProductName = "Frosted flakes" },
                new Product { ProductID = 20, CategoryID = 3, ProductName = "Lucky charms" },
                new Product { ProductID = 21, CategoryID = 3, ProductName = "Apple jacks" },
                new Product { ProductID = 22, CategoryID = 3, ProductName = "Special K" },
                new Product { ProductID = 23, CategoryID = 3, ProductName = "Cinnamon toast crunch" },
                new Product { ProductID = 24, CategoryID = 3, ProductName = "Raisin bran" },
                new Product { ProductID = 25, CategoryID = 4, ProductName = "Banana" },
                new Product { ProductID = 26, CategoryID = 4, ProductName = "Apple" },
                new Product { ProductID = 27, CategoryID = 4, ProductName = "Orange" },
                new Product { ProductID = 28, CategoryID = 4, ProductName = "Blueberry" },
                new Product { ProductID = 29, CategoryID = 4, ProductName = "Kiwi" },
                new Product { ProductID = 30, CategoryID = 4, ProductName = "Watermelon" },
                new Product { ProductID = 31, CategoryID = 4, ProductName = "Mango" },
                new Product { ProductID = 32, CategoryID = 4, ProductName = "Grapefruit" },
                new Product { ProductID = 33, CategoryID = 4, ProductName = "Papaya" }
                );
        }
    }
}
