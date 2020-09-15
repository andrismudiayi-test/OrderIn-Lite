using System;
using System.Threading.Tasks;
using Xunit;
using Moq;
using OrderInLite;
using OrderInLite.Controllers;
using OrderInLite.Interfaces;
using OrderInLite.Models.Business;
using System.Collections.Generic;


namespace OrderInLite.Test
{
    public class OrderControllerTests: BaseOrderTests
    {
        [Fact]
        public override async Task GivenSearchPhrase_ShouldReturnResult()
        {
            var searchPhrase = "Taco in Cape Town";

            base.MockService.Setup(srv => srv.SearchFoodByCity(searchPhrase))                           
            .ReturnsAsync(base.FoodSearchResultMock);

            var controller = new OrderController(base.MockService.Object);
            
            var result = await controller.SearchFood(searchPhrase);

            var viewResult = Assert.IsType<List<FoodSearchResultItem>>(result);

            var model = Assert.IsAssignableFrom<List<FoodSearchResultItem>>(result);

            Assert.Equal(2, model.Count);            
        }

        [Fact]
        public override async Task GivenEmptySearchPhrase_ShouldReturnNull()
        {
            List<FoodSearchResultItem> foodSearchNullResultMock = null;
            
            base.MockService.Setup(srv => srv.SearchFoodByCity(string.Empty))
            .ReturnsAsync(foodSearchNullResultMock);

            var controller = new OrderController(base.MockService.Object);

            var result = await controller.SearchFood(string.Empty);
            Assert.Null(result);

        }

        [Fact]
        public override async Task GivenMenuIds_ShouldConfirmOrder()
        {

        }

        [Fact]
        public override async Task GivenNoMenuIds_ShouldReturnNull()
        {

        }


    }
}
