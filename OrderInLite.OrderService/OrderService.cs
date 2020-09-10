using System;
using System.Collections.Generic;
using OrderInLite.Interfaces;
using OrderInLite.Models.Repository;
using OrderInLite.Models.Business;
using System.Threading.Tasks;
using System.Linq;

namespace OrderInLite.Service
{
    public class OrderService : IOrderService
    {
        private IRepositoryService _repository { get; set; }        

        public OrderService(IRepositoryService repository)
        {
            _repository = repository;
        }        

        public async Task<List<FoodSearchResultModel>> SearchFoodByCity(string searchPhrase)
        {
            var searchModel = await ParseSearchPhrase(searchPhrase);
            return await _repository.SearchFoodByCity(searchModel.FoodName, searchModel.CityName);
        }

        public async Task<OrderConfirmationModel> PlaceOrder(OrderPlacementModel newOrder)
        {
            var customerMockId = 1;

            var confirmedOrder = await _repository.PlaceOrder(customerMockId, newOrder.MenuItemIds);

            return  new OrderConfirmationModel { OrderId = confirmedOrder.OrderId };
        }

        private async Task<SearchModel> ParseSearchPhrase(string searchPhrase)
        {            
            var searchModel = new SearchModel();
            
            var cities = await _repository.GetCityNames();
            foreach(var city in cities)
            {
                if (searchPhrase.Contains(city))
                {
                    searchModel.CityName = city;
                    break;
                }
                throw new ArgumentException();
            }

            var foods = await _repository.GetFoodNames();
            foreach(var foodName in foods)
            {
                if (searchPhrase.Contains(foodName))
                {
                    searchModel.FoodName = foodName;
                    break;
                }
                throw new ArgumentException();
            }

            return searchModel;
        }

    }
}
