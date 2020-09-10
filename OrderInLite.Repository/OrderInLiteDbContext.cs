using System;
using Microsoft.EntityFrameworkCore;
using OrderInLite.Models.Repository;
namespace OrderInLite.Repository
{
    public class OrderInLiteDbContext : DbContext
    {
        public OrderInLiteDbContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }

        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FoodOrder> FoodOrders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<FoodSearchResult> FoodSearchResults { get; set; }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodSearchResult>().HasNoKey();            
        }

    }
}
