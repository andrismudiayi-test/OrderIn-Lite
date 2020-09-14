using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderInLite.Models.Repository
{
    [Table("Category")]
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }      
    }

    [Table("City")]
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Restaurant Restaurant { get; set; }
    }

    [Table("Restaurant")]
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }

        public string Suburb { get; set; }
        public string LogoPath { get; set; }
        public int Rank { get; set; }

        public ICollection<MenuItem> MenuItems { get; set; }
    }

    [Table("MenuItem")]
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public decimal Price { get; set; }
    }

    /* orders */

    [Table("OrderStatus")]
    public class OrderStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }        
    }

    [Table("Customer")]
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    [Table("FoodOrDer")]
    public class FoodOrder
    {
        public int Id { get; set; }
        public DateTime OrderTime { get; set; }        
        public int OrderStatusId { get; set; }
        public int CustomerId { get; set; }        
    }

    [Table("OrderItem")]
    public class OrderItem
    {
        [Key]
        public int FoodOrderId { get; set; }
        public int MenuItemId { get; set; }

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