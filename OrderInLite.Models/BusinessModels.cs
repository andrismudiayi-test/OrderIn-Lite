using System.Collections.Generic;
using System.ComponentModel;

namespace OrderInLite.Models.Business
{
          
    public enum City
    {
        [Description("Cape Town")]
        CPT = 1,
        [Description("Johannesburg")]
        JHB = 2,
        [Description("Durban")]
        DBN = 3
    }

    public enum OrderStatus
    {
        [Description("Done")]
        DONE = 1,
        [Description("Pending")]
        PENDING = 2,
        [Description("Placed")]
        PLACED = 3
    }

    public class OrderCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class OrderMenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    
    public class OrderRestaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Suburb { get; set; }
        public int Rank { get; set; }
        public string CityName { get; set; }
        public string LogoPath { get; set; }
    }
       
    public class FoodSearchResultItem
    {
        public string MenuItemName { get; set; }
        public float Price { get; set; }
        public string CategoryName { get; set; }
        public string CityName { get; set; }
        public string Rank { get; set; }
    }

    public class OrderPlacement
    {
        public int OrderId { get; set; }
        public int[] MenuItemIds { get; set; }
    }

}