using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrderInLite.Models.Repository
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public string Suburb { get; set; }
        public string LogoPath { get; set; }
        public int Rank { get; set; }        
    }

    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RestaurantId { get; set; }
        public int CategoryId { get; set; }
    }

    /* orders */

    public class OrderStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }        
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class FoodOrder
    {
        public int Id { get; set; }
        public DateTime OrderTime { get; set; }        
        public int OrderStatusId { get; set; }
        public int CustomerId { get; set; }        
    }

    public class OrderItem
    {
        [Key]
        public int FoodOrderId { get; set; }
        public int MenuItemId { get; set; }

    }

    /* proc results */

    public class FoodSearchResult
    {
        public string MenuItemName { get; set; }
        public float Price { get; set; }
        public string CategoryName { get; set; }
        public string CityName { get; set; }
        public string Rank { get; set; }
    }

}