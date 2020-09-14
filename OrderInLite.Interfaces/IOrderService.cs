using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrderInLite.Models.Business;

namespace OrderInLite.Interfaces
{
    public interface IOrderService
    {
        Task<OrderConfirmationModel> PlaceOrder(OrderPlacementModel order);
        Task<List<FoodSearchResultItem>> SearchFoodByCity(string searchPhrase);
    }
}
