using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrderInLite.Models.Business;

namespace OrderInLite.Interfaces
{
    public interface IOrderService
    {
        Task<List<FoodSearchResultModel>> SearchFoodByCity(string searchPhrase);        
        Task<OrderConfirmationModel> PlaceOrder(OrderPlacementModel order);
        Task<List<MenuItemModel>> SearchMenusByCity(string searchPhrase);
    }
    
}
