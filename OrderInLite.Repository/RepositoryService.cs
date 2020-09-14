using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using OrderInLite.Interfaces;
using OrderInLite.Models.Repository;
using OrderInLite.Models.Business;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace OrderInLite.Repository
{
    public class RepositoryService : IRepositoryService
    {        
        private readonly DbContextOptions _options;
        private readonly ILogger _logger;

        public RepositoryService(DbContextOptions options, ILogger<RepositoryService> logger)
        {
            _options = options;
            _logger = logger;
        }


        public async Task<List<FoodSearchResultModel>> SearchFoodByCity(string foodName, string cityName)
        {
            try
            {
                List<FoodSearchResultModel> foodSearchResults = new List<FoodSearchResultModel>();
                List<FoodSearchResult> foodSearchResultsList = new List<FoodSearchResult>();


                using (var db = new OrderInLiteDbContext(_options))
                {

                    var queryResult = await (from mi in db.MenuItems
                                             join ctgy in db.Categories on mi.CategoryId equals ctgy.Id
                                             join rest in db.Restaurants on mi.Restaurant.Id equals rest.Id
                                             join ct in db.Cities on rest.CityId equals ct.Id
                                             where ctgy.Name.Contains(foodName)
                                             && mi.Name.Contains(foodName)
                                             && ct.Name == cityName
                                             select new
                                             {
                                                 restaurantId = rest.Id,
                                                 restaurantName = rest.Name,
                                                 logoPath = rest.LogoPath,
                                                 suburbName = rest.Suburb,
                                                 RankNumber = rest.Rank,
                                                 menuItemId = mi.Id,                                                 
                                                 menuItemName = mi.Name,
                                                 price = mi.Price,
                                                 categoryName = ctgy.Name,
                                                 cityName = ct.Name
                                             }).ToListAsync();

                     foreach (var q in queryResult)
                     {
                         foodSearchResults.Add(new FoodSearchResultModel()
                         {
                             RestaurantId = q.restaurantId,
                             RestaurantName = q.restaurantName,
                             LogoPath = q.logoPath,
                             SuburbName = q.suburbName,
                             RankNumber = q.RankNumber,
                             MenuitemId = q.menuItemId,                
                             MenuItemName = q.menuItemName,
                             MenuItemPrice = q.price,
                             CategoryName = q.categoryName,
                             CityName = q.cityName
                         });
                     }
                }

                return foodSearchResults;
            }
            catch (Exception ex)
            {
                throw new Exception();
                _logger.LogInformation($"error:{ex.Message}");
            }
        }

        public async Task<List<MenuItemModel>> SearchMenusByCity(string foodName, string cityName)
        {
            try
            {                
                List<MenuItem> menuItemsList = new List<MenuItem>();
                List<MenuItemModel> menuItemsModelList = new List<MenuItemModel>();

                using (var db = new OrderInLiteDbContext(_options))
                {
                    menuItemsList = await db.MenuItems
                        .Where(m => m.Name.Contains(foodName))
                        .Include(c => c.Category)
                        .Where(c => c.Category.Name.Contains(foodName))
                        .Include(r => r.Restaurant)                        
                        .Where(m => m.Restaurant.City.Id == 1).ToListAsync();
                }
                foreach (var mi in menuItemsList)
                {
                    menuItemsModelList.Add(new MenuItemModel() { MenuItemId = mi.Id, MenuItemName = mi.Name, Price = mi.Price });
                }

                return menuItemsModelList;

            }
            catch(Exception ex) {
                throw new Exception();
                _logger.LogInformation($"error:{ex.Message}");
            }
        }

        public async Task<OrderConfirmationModel> PlaceOrder(int customerId, int[] MenuItemIds)
        {
            var currentOrder = new FoodOrder{ CustomerId = customerId, OrderStatusId = 1, OrderTime = DateTime.Now };

            using (var db = new OrderInLiteDbContext(_options))
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
                List<City> citiesList = new List<City>();
                List<string> cities = new List<string>();

                using (var db = new OrderInLiteDbContext(_options))
                {
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
                List<MenuItem> menuItemsList = new List<MenuItem>();
                List<string> menuItems = new List<string>();

                using (var db = new OrderInLiteDbContext(_options))
                {                 
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




