using System;
using System.Collections.Generic;
using System.Text;
using InventoryDataAccess.Entity;
using Microsoft.EntityFrameworkCore;

namespace InventoryDataAccess.Context
{
    public class InventoryContext:DbContext
    {
        public DbSet<Brand> brands { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<store> stores { get; set; }
        public DbSet<Attributes> attributes { get; set; }
        public DbSet<AttributeValue> attributeValues  { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<Currency> currencies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=localhost;initial catalog=InventoryDb;integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
