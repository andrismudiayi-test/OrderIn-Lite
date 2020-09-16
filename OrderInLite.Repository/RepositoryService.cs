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
using AutoMapper;

namespace OrderInLite.Repository
{
    public class RepositoryService : IRepositoryService
    {
        private readonly DbContextOptions _options;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public RepositoryService(DbContextOptions options, ILogger<RepositoryService> logger, IMapper mapper)
        {
            _options = options;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<List<FoodSearchResultItem>> SearchFoodByCity(string foodName, string cityName)
        {
            try
            {
                List<MenuItem> menuItemsList = new List<MenuItem>();
                List<Restaurant> restaurants = new List<Restaurant>();

                using (var db = new OrderInLiteDbContext(_options))
                {
                    menuItemsList = await db.MenuItem
                        .Where(m => m.Name.Contains(foodName))
                        .Include(c => c.Category)
                        .Where(c => c.Category.Name.Contains(foodName))
                        .Include(r => r.Restaurant)
                        .Include(ct => ct.Restaurant.City)
                        .Distinct()
                        .Where(r => r.Restaurant.City.Name == cityName)                        
                        .ToListAsync();
                }

                var flattenedResult = from r in menuItemsList
                                      select new Restaurant()
                                      {
                                          Id = r.Restaurant.Id,
                                          Name = r.Restaurant.Name,
                                          LogoPath = r.Restaurant.LogoPath,
                                          Suburb = r.Restaurant.Suburb,
                                          Rank = r.Restaurant.Rank,
                                          MenuItem = (from m in r.Restaurant.MenuItem
                                                      select new MenuItem
                                                      {
                                                          Id = m.Id,
                                                          Name = m.Name,
                                                          Price = m.Price
                                                      }).ToList()
                                      };

                var foodSearchResultList = from r in flattenedResult
                                           select new FoodSearchResultItem()
                                           {
                                               RestaurantId = r.Id,
                                               LogoPath = r.LogoPath,
                                               RestaurantName = r.Name,
                                               SuburbName = r.Suburb,
                                               RankNumber = r.Rank,
                                               MenuItems = (from m in r.MenuItem
                                                            select new MenuItemModel()
                                                            {
                                                                MenuItemId = m.Id,
                                                                Name = m.Name,
                                                                Price = (double)m.Price
                                                            }).ToList()
                                           };

                return foodSearchResultList.Any() ? foodSearchResultList.Cast<FoodSearchResultItem>()
                    .OrderByDescending(r => r.RankNumber)
                    .ToList() : null;
            }
            catch (Exception ex)
            {
                _logger.LogError($"error:{ex.Message}");
                throw new Exception();
            }
        }

        public async Task<OrderConfirmationModel> PlaceOrder(int customerId, int[] MenuItemIds)
        {
            var currentOrder = new FoodOrder { CustomerId = customerId, OrderStatusId = 1, OrderTime = DateTime.Now };

            using (var db = new OrderInLiteDbContext(_options))
            {
                using (var transc = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.FoodOrder.Add(currentOrder);
                        await db.SaveChangesAsync();

                        int currentOrderId = currentOrder.Id;

                        foreach (var menuItem in MenuItemIds)
                        {
                            db.OrderItem.Add(new OrderItem() { FoodOrderId = currentOrderId, MenuItemId = menuItem });
                            await db.SaveChangesAsync();
                        }

                        transc.Commit();

                        return new OrderConfirmationModel() { OrderId = currentOrderId };
                    }
                    catch (Exception ex)
                    {
                        transc.Rollback();
                        _logger.LogError(ex.Message);
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
                    citiesList = await db.City.ToListAsync();
                };

                foreach (var city in citiesList)
                {
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
                    menuItemsList = await db.MenuItem.ToListAsync();
                };

                foreach (var menuItem in menuItemsList)
                {
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




