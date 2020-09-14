using System;
using System.Collections;
using System.Collections.Generic;
using OrderInLite.Models.Business;
using System.Threading.Tasks;
using OrderInLite.Models.Repository;

namespace OrderInLite.Interfaces
{
    public interface IRepositoryService
    {
        Task<List<FoodSearchResultItem>> SearchFoodByCity(string foodName, string cityName);
        Task<OrderConfirmationModel> PlaceOrder(int customerId, int[] MenuItemIds);
        Task<List<string>> GetCityNames();
        Task<List<string>> GetFoodNames();
    }

}
