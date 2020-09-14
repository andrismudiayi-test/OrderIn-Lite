using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderInLite.Models.Repository
{

    public partial class Category
    {
        public Category()
        {
            MenuItem = new HashSet<MenuItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MenuItem> MenuItem { get; set; }
    }

    public partial class City
    {
        public City()
        {
            Restaurant = new HashSet<Restaurant>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Restaurant> Restaurant { get; set; }
    }

    public partial class Restaurant
    {
        public Restaurant()
        {
            MenuItem = new HashSet<MenuItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CityId { get; set; }
        public string Suburb { get; set; }
        public string LogoPath { get; set; }
        public int Rank { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<MenuItem> MenuItem { get; set; }
    }

    public partial class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? RestaurantId { get; set; }
        public int? CategoryId { get; set; }
        public decimal Price { get; set; }

        public virtual Category Category { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }

    [Table("OrderItem")]
    public partial class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int? FoodOrderId { get; set; }
        public int? MenuItemId { get; set; }
        public virtual FoodOrder FoodOrder { get; set; }
        public virtual MenuItem MenuItem { get; set; }
    }

    /* orders */

    public partial class Customer
    {
        public Customer()
        {
            FoodOrder = new HashSet<FoodOrder>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<FoodOrder> FoodOrder { get; set; }
    }

    public partial class OrderStatus
    {
        public OrderStatus()
        {
            FoodOrder = new HashSet<FoodOrder>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FoodOrder> FoodOrder { get; set; }
    }

    public partial class FoodOrder
    {
        public int Id { get; set; }
        public DateTime OrderTime { get; set; }
        public int? OrderStatusId { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
    }



    /* query result */

    public class FoodSearchResult
    {
        [Key]
        public int RestaurantId { get; set; }
        public string LogoPath { get; set; }
        public string RestaurantName { get; set; }
        public string SuburbName { get; set; }
        public int RankNumber { get; set; }

        public int MenuitemId { get; set; }
        public string MenuItemName { get; set; }
        public decimal FoodPrice { get; set; }
        public string CategoryName { get; set; }
        public string CityName { get; set; }
    }
}