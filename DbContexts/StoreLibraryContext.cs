using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace core_api.DbContexts
{
    public class StoreLibraryContext : DbContext
    {
        public StoreLibraryContext(DbContextOptions<StoreLibraryContext> options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductDetails>().HasData(
                new ProductDetails()
                {
                    Id = Guid.NewGuid(),
                    Name = "Pixel 3a",
                    Price = 299.99m,
                    Image = "https://i.pcmag.com/imagery/articles/03L1cFptUWr6Nz2wDLvD2ue-5.fit_scale.size_1028x578.v1569484000.jpg",
                    Description = "The Google Pixel 3a is a thoroughly excellent phone with access to some of the best software and camera features Google has cooked up.",
                    quantityInStock = 7,
                    CategoryId = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b")
                },
                new ProductDetails()
                {
                    Id = Guid.NewGuid(),
                    Name = "iPhone SE",
                    Price = 399.99m,
                    Image = "https://cdn.mos.cms.futurecdn.net/Dd8iKhoWGpLSYBaFrM3Sc6-970-80.jpg.webp",
                    Description = "The iPhone SE 2020 is built around one goal: to create a new iPhone for less money than ever, and it achieves that well.",
                    quantityInStock = 15,
                    CategoryId = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b")
                },
                new ProductDetails()
                {
                    Id = Guid.NewGuid(),
                    Name = "Kick in the Door Bring Back The 44",
                    Price = 39.99m,
                    Image = "https://www.dropbox.com/s/136zp6hnoi75g1m/garyPromo.PNG",
                    Description = "Clever Clothing.",
                    quantityInStock = 7,
                    CategoryId = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee")
                });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                    Title = "Mobile"
                },
                new Category()
                {
                    Id = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                    Title = "Clothing"
                });
            base.OnModelCreating(modelBuilder);

        }
    }
}
