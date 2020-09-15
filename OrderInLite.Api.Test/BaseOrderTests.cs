using System;
using System.Collections.Generic;
using OrderInLite.Models.Business;
using OrderInLite.Models.Repository;
using OrderInLite.Interfaces;
using System.Threading.Tasks;
using Moq;


namespace OrderInLite.Test
{
    public abstract class BaseOrderTests
    {
        protected readonly SearchModel SearchModel;
        protected readonly Mock<IOrderService> MockService;
        protected readonly Mock<IRepositoryService> MockRepo;

        #region mock data

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
            MockService = new Mock<IOrderService>();
            MockRepo = new Mock<IRepositoryService>();

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


        public abstract Task GivenSearchPhrase_ShouldReturnResult();
        public abstract Task GivenEmptySearchPhrase_ShouldReturnNull();
        public abstract Task GivenMenuIds_ShouldConfirmOrder();
        public abstract Task GivenNoMenuIds_ShouldReturnNull();

    }
}
