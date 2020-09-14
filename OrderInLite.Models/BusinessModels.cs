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
        public string MenuItemName { get; set; }
        public decimal Price { get; set; }
    }

    public class FoodSearchResultModel1
    {
        public string LogoPath { get; set; }
        public string RestaurantName { get; set; }
        public string Suburb { get; set; }
        public int Rank { get; set; }
        public List<MenuItemModel> MenuItems { get; set; }
    }

    public class FoodSearchResultModel
    {
        public int RestaurantId { get; set; }
        public string LogoPath { get; set; }
        public string RestaurantName { get; set; }
        public string SuburbName { get; set; }
        public int RankNumber { get; set; }

        public int MenuitemId { get; set; }
        //public int MenuRestaurantId { get; set; }
        public string MenuItemName { get; set; }
        public decimal MenuItemPrice { get; set; }
        public string CategoryName { get; set; }
        public string CityName { get; set; }

    }

    
    public class FoodSearchListModel
    {                
        public string LogoPath { get; set; }
        public string RestaurantName { get; set; }
        public string SuburbName { get; set; }
        public int RankNumber { get; set; }
        public List<FoodItemModel> FoodItemResultsList { get; set; }
    }

    public class FoodItemModel
    {
        public int MenuitemId { get; set; }
        public string MenuItemName { get; set; }
        public decimal FoodPrice { get; set; }        
        public string CityName { get; set; }
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