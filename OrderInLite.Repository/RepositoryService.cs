using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using OrderInLite.Interfaces;
using OrderInLite.Models.Repository;

namespace OrderInLite.Repository
{
    public class RepositoryService : IRepositoryService
    {

        private readonly OrderInLiteDbContext _dbContext;

        public RepositoryService()
        {
            _dbContext = new OrderInLiteDbContext();
        }


        public void SearchFoodItemsByCity(string foodName, string cityName)
        {
            try
            {
                IEnumerable<FoodSearchResult> foodSearchResult = null;

                using (var db = _dbContext)
                {                    
                    foodSearchResult = db.MenuSearchResults
                        .FromSqlRaw($"EXEC dbo.usp_SearchFoodByCity @FoodName = {foodName}, @CityName = {cityName}");
                };


                //todo: map to poco

                //todo: return list of search results

            }
            catch (Exception ex)
            {

            }
        }


        public void PlaceOrder(int customerId, int[] MenuItemIds)
        {

            var currentOrder = new FoodOrder()
            { CustomerId = customerId, OrderStatusId = 1, OrderTime = DateTime.Now };
            using (var db = _dbContext)
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


                        //todo: map to poco


                        //todo: return orderId

                    }
                    catch (Exception ex)
                    {
                        transc.Rollback();
                    }
                }

            }
        }
    }
}




