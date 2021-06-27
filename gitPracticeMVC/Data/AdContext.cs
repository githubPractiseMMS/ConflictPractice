using System;
using gitPracticeMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace gitPracticeMVC.Data
{
    public class AdContext : DbContext
    {
        public AdContext(DbContextOptions<AdContext> options) : base(options)
        {
        }

        // Adding tables to the database 
        public DbSet<ProductModel> Products { get; set; }



        //Fluent API 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seeding data 


        }

    }
}
