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

        public OrderService()
        {
            
        }

        public OrderService(IRepositoryService repository)
        {
            _repository = repository;
        }

        public async Task<List<FoodSearchResultItem>> SearchFoodByCity(string searchPhrase)
        {
            var searchModel = await ParseSearchPhrase(searchPhrase);
            if (searchModel.CityName == null || searchModel.FoodName == null)
            {
                throw new ArgumentNullException();
            }
            return await _repository.SearchFoodByCity(searchModel.FoodName, searchModel.CityName);
        }

        public async Task<OrderConfirmationModel> PlaceOrder(OrderPlacementModel newOrder)
        {           
            var confirmedOrder = await _repository.PlaceOrder(1, newOrder.MenuItemIds);
            
            return new OrderConfirmationModel { OrderId = confirmedOrder.OrderId };
        }

        private async Task<SearchModel> ParseSearchPhrase(string searchPhrase)
        {
            var searchModel = new SearchModel();
            searchPhrase.ToLower();

            var cities = await _repository.GetCityNames();
            foreach (var city in cities)
            {
                if (searchPhrase.ToLower().Contains(city.ToLower()))
                {
                    searchModel.CityName = city;
                    break;
                }
                else
                {
                    continue;
                }
            }

            var foods = await _repository.GetFoodNames();
            string[] searchPhraseSplit = searchPhrase.Split(" ");

            foreach (var foodName in foods)
            {
                var foodSplitTest = foodName.Split(" ");


                var foundFood = foodSplitTest.Intersect(searchPhraseSplit);

                if (foundFood.Any())
                {
                    searchModel.FoodName = searchPhraseSplit[0]; //assuming food is always first item in search
                    break;
                }
                else
                {
                    continue;
                }
            }
            return searchModel;
        }
    }

}
