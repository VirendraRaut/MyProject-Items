using Microsoft.EntityFrameworkCore;
using MyProject.Models;

namespace MyProject.Data
{
    public class MyAppContext : DbContext

    {

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<SerialNumber>().HasData(
        //        new SerialNumber { Id=10, Name="JioRouter111", itemId=4}
        //        );

        //    base.OnModelCreating(modelBuilder);
        //}


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<SerialNumber>().ToTable("SerialNumbers");
        //    modelBuilder.Entity<Item>().ToTable("Items");

        //    modelBuilder.Entity<SerialNumber>().HasData(
        //        new SerialNumber { Id = 10, Name = "JioRouter111", itemId = 4 }
        //    );

        //    base.OnModelCreating(modelBuilder);
        //}


        public MyAppContext(DbContextOptions<MyAppContext> options) : base (options){ }

    public DbSet<Item> Items { get; set; }

    //public DbSet<SerialNumber> SerialNumbers { get; set; }
    }

}
