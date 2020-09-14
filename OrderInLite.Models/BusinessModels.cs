using System.Collections.Generic;
using System.ComponentModel;

namespace OrderInLite.Models.Business
{
    public class SearchModel
    {
        public string CityName { get; set; }
        public string FoodName { get; set; }
    }

    public class MenuItemModel
    {
        public int MenuItemId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class FoodSearchResultItem
    {
        public int RestaurantId { get; set; }
        public string LogoPath { get; set; }
        public string RestaurantName { get; set; }
        public string SuburbName { get; set; }
        public int RankNumber { get; set; }
        public List<MenuItemModel> MenuItems { get; set; }
    }


    /* orders */

    public class OrderPlacementModel
    {
        public int OrderId { get; set; }
        public int[] MenuItemIds { get; set; }
        public int CustomerId { get; set; }
    }

    public class OrderConfirmationModel
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
    }


}