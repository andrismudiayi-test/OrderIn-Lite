using System;
using System.Collections.Generic;
using OrderInLite.Models.Business;
using OrderInLite.Models.Repository;
using OrderInLite.Interfaces;
using OrderInLite.Repository;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Moq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace OrderInLite.Test
{
    public abstract class BaseOrderTests
    {
        protected readonly Mock<IOrderService> _mockService;
        protected readonly Mock<IRepositoryService> _mockRepo;
        protected readonly Mock<ILogger> _logger;
        protected readonly Mock<IMapper> _mapper;
        protected readonly Mock<DbContextOptions> _dbOptions;
        protected readonly Mock<OrderInLiteDbContext> _context;

        #region mock data

        protected readonly SearchModel ValidSearchModel;
        protected readonly SearchModel InvalidSearchModel;

        protected List<MenuItemModel> MenuItemsMock1 = new List<MenuItemModel>() {
                new MenuItemModel{MenuItemId=1, Name="foo1", Price = 50.00},
                new MenuItemModel{MenuItemId=2, Name="foo2", Price = 45.00},
                new MenuItemModel{MenuItemId=3, Name="foo3", Price = 30.00}
            };

        protected List<MenuItemModel> MenuItemsMock2 = new List<MenuItemModel>() {
                new MenuItemModel{MenuItemId=3, Name="bar1", Price = 50.00},
                new MenuItemModel{MenuItemId=4, Name="bar2", Price = 55.00},
                new MenuItemModel{MenuItemId=5, Name="bar3", Price = 35.00}
            };
        protected List<MenuItemModel> MenuItemsMock3 = new List<MenuItemModel>() {
                new MenuItemModel{MenuItemId=6, Name="hhh", Price = 50.00},
                new MenuItemModel{MenuItemId=7, Name="fff", Price = 45.00},
                new MenuItemModel{MenuItemId=9, Name="ppp", Price = 30.00}
            };

        protected List<FoodSearchResultItem> FoodSearchResultMock;

        #endregion



        public BaseOrderTests()
        {
            _logger = new Mock<ILogger>();
            _mapper = new Mock<IMapper>();
            _mockService = new Mock<IOrderService>();
            _mockRepo = new Mock<IRepositoryService>(_dbOptions, _logger, _mapper);
            ValidSearchModel = new SearchModel() { FoodName = "Taco", CityName = "Cape Town"};
            InvalidSearchModel = null;

            FoodSearchResultMock = new List<FoodSearchResultItem>() {
                new FoodSearchResultItem{RestaurantId = 1,
                    LogoPath = "xyz",
                    RankNumber = 6,
                    RestaurantName = "xyz", SuburbName = "woodstock", MenuItems = MenuItemsMock1},
                new FoodSearchResultItem{RestaurantId = 2,
                    LogoPath = "xyz1",
                    RankNumber = 4,
                    RestaurantName = "zyx", SuburbName = "salt river", MenuItems = MenuItemsMock2}
            };

        }
        
    }
}
