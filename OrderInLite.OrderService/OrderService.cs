using System;
using System.Collections.Generic;
using OrderInLite.Interfaces;
using OrderInLite.Models;
using OrderInLite.Models.Business;

namespace OrderInLite.OrderService
{
    public class OrderService : IOrderService
    {
        string IOrderService.PlaceOrder(OrderPlacement order)
        {
            throw new NotImplementedException();
        }

        List<FoodSearchResultItem> IOrderService.SearchMenuItems(string SearchTerm, string city)
        {
            throw new NotImplementedException();
        }
     
    }
}
