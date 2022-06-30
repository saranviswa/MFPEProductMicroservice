using Microsoft.EntityFrameworkCore;
using ProductMicroservices.Model;

namespace ProductMicroservices.Context
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product() { Id = 1, Price = 129999, Name = "iPhone 13 Pro Max", Description = "APPLE iPhone 13 pro Max(Graphite 128 GB)", Image_Name = "Iphone.jpg", Rating = 2 },
                    new Product() { Id = 2, Price = 2490, Name = "Brass Diamond Bracelet", Description = "Brass Diamond bracelet with crystal clear finish", Image_Name = "bracelet.jpg", Rating = 3 },
                    new Product() { Id = 3, Price = 999, Name = "Shirt", Description = "Men Slim Fit check slim collar casual shirt", Image_Name = "shirt.jpg", Rating = 3 },
                    new Product() { Id = 4, Price = 20999, Name = "Blue Star Inverter AC", Description = "Blue Star Comvertible 4-in-1 Cooling 1.5 Ton 5 Star AC", Image_Name = "ac.jpg", Rating = 3 },
                    new Product() { Id = 5, Price = 13190, Name = "SAMSUNG Refrigerator", Description = "SAMSUNG 192L Direct Cool Single Door 2 Star Refrigerator", Image_Name = "refri.jpg", Rating = 3 }
                );
        }



    }
}
