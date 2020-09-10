using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using OrderInLite.Interfaces;
using OrderInLite.Models.Repository;
using OrderInLite.Models.Business;
using System.Threading.Tasks;

namespace OrderInLite.Repository
{
    public class RepositoryService : IRepositoryService
    {
        private readonly OrderInLiteDbContext _dbContext;
        private readonly DbContextOptions _options;

        public RepositoryService(DbContextOptions options)
        {
            _options = options;
            _dbContext = new OrderInLiteDbContext(_options);
        }

        public async Task<List<FoodSearchResultModel>> SearchFoodByCity(string foodName, string cityName)
        {
            try
            {
                List<FoodSearchResult> foodSearchResultsList = null;
                List<FoodSearchResultModel> foodSearchResultModels = null;

                using (var db = _dbContext)
                {                    
                    foodSearchResultsList = await db.FoodSearchResults
                        .FromSqlRaw($"EXEC dbo.usp_SearchFoodByCity @FoodName = {foodName}, @CityName = {cityName}").ToListAsync();                    
                };

                foreach(var foodResult in foodSearchResultsList)
                {
                    //todo: map results
                    foodSearchResultModels.Add(new FoodSearchResultModel()
                    {
                        LogoPath = "",
                        RestaurantName = "",
                        Suburb = "",
                        Rank = 1,
                        MenuItems = new List<MenuItemModel>() {
                            new MenuItemModel{MenuItemId = 1, MenuItemName = "taco", Price = 120.000},
                            new MenuItemModel{MenuItemId = 2, MenuItemName = "tacos", Price = 130.000}
                        }
                    });
                }

                return foodSearchResultModels;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<OrderConfirmationModel> PlaceOrder(int customerId, int[] MenuItemIds)
        {
            var currentOrder = new FoodOrder{ CustomerId = customerId, OrderStatusId = 1, OrderTime = DateTime.Now };

            using (var db =  _dbContext)
            {
                using (var transc = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.FoodOrders.Add(currentOrder);
                        db.SaveChanges();

                        int currentOrderId = currentOrder.Id;

                        foreach (var menuItem in MenuItemIds)
                        {
                            db.OrderItems.Add(new OrderItem() { FoodOrderId = currentOrderId, MenuItemId = menuItem });
                            db.SaveChanges();
                        }

                        transc.Commit();
                        
                        return new OrderConfirmationModel() { OrderId = currentOrderId };
                    }
                    catch (Exception ex)
                    {
                        transc.Rollback();
                        throw new Exception(ex.Message);
                    }
                }

            }
        }

        public async Task<List<string>> GetCityNames()
        {
            try
            {
                List<City> citiesList = null;
                List<string> cities = null;

                using (var db = _dbContext){
                    citiesList = await db.Cities.ToListAsync();
                };
                
                foreach(var city in citiesList) {
                    cities.Add(city.Name);
                }

                return cities;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<List<string>> GetFoodNames()
        {
            try
            {
                List<MenuItem> menuItemsList = null;
                List<string> menuItems = null;

                using (var db = _dbContext){                 
                    menuItemsList = await db.MenuItems.ToListAsync();
                };

                foreach(var menuItem in menuItemsList) {
                    menuItems.Add(menuItem.Name);
                }

                return menuItems;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}




