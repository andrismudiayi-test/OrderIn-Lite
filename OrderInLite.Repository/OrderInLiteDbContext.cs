using System;
using Microsoft.EntityFrameworkCore;
using OrderInLite.Models.Repository;
using AutoMapper;

namespace OrderInLite.Repository
{

    public partial class OrderInLiteDbContext : DbContext
    {
        public OrderInLiteDbContext()
        {
        }

        public OrderInLiteDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<FoodOrder> FoodOrder { get; set; }
        public virtual DbSet<MenuItem> MenuItem { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<Restaurant> Restaurant { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FoodOrder>(entity =>
            {
                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.FoodOrder)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__FoodOrder__Custo__5441852A");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.FoodOrder)
                    .HasForeignKey(d => d.OrderStatusId)
                    .HasConstraintName("FK__FoodOrder__Order__534D60F1");
            });

            modelBuilder.Entity<MenuItem>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MenuItem)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__MenuItem__Catego__3F466844");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.MenuItem)
                    .HasForeignKey(d => d.RestaurantId)
                    .HasConstraintName("FK__MenuItem__Restau__3E52440B");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasOne(d => d.FoodOrder)
                    .WithMany()
                    .HasForeignKey(d => d.FoodOrderId)
                    .HasConstraintName("FK__OrderItem__FoodO__5629CD9C");

                entity.HasOne(d => d.MenuItem)
                    .WithMany()
                    .HasForeignKey(d => d.MenuItemId)
                    .HasConstraintName("FK__OrderItem__MenuI__571DF1D5");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.Property(e => e.LogoPath)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Suburb)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Restaurant)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK__Restauran__CityI__3A81B327");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}
