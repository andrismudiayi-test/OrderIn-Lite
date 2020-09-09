using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrderInLite.Models.Business;

namespace OrderInLite.Interfaces
{
    public interface IOrderService
    {
        List<FoodSearchResultItem> SearchMenuItems(string SearchTerm, string city);        
        string PlaceOrder(OrderPlacement order);
    }
    
}
