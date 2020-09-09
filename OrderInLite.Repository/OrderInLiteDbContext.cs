using System;
using Microsoft.EntityFrameworkCore;
using OrderInLite.Models.Repository;
namespace OrderInLite.Repository
{
    public class OrderInLiteDbContext : DbContext
    {
        public OrderInLiteDbContext()
        {
            Database.GetDbConnection().ConnectionString = "SqlServerConnection";
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }

        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FoodOrder> FoodOrders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<FoodSearchResult> MenuSearchResults { get; set; }
        public DbSet<OrderPlacementResult> OrderPlacementResults { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodSearchResult>().HasNoKey();
            modelBuilder.Entity<OrderPlacementResult>().HasNoKey();
        }

        
        
    }
}
