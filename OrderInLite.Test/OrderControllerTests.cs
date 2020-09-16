using System;
using System.Threading.Tasks;
using Xunit;
using Moq;
using OrderInLite;
using OrderInLite.Controllers;
using OrderInLite.Interfaces;
using OrderInLite.Models.Business;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace OrderInLite.Test
{
    public class OrderControllerTests: BaseOrderTests
    {
        [Fact]
        public async Task GivenValidSearch_ShouldReturnOK()
        {
            var searchPhrase = "Taco in Cape Town";

            base._mockService.Setup(srv => srv.SearchFoodByCity(searchPhrase))                           
            .ReturnsAsync(base.FoodSearchResultMock);

            var controller = new OrderController(base._mockService.Object);
            
            var result = await controller.SearchFood(searchPhrase);

            var viewResult = Assert.IsType<OkObjectResult>(result);

            var resultModel = Assert.IsAssignableFrom<OkObjectResult>(viewResult);

            Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)resultModel.StatusCode);

            var model = Assert.IsAssignableFrom<List<FoodSearchResultItem>>(resultModel.Value);            

            Assert.NotNull(model);
            
        }

        [Fact]
        public async Task GivenInvalidSearch_ShouldReturnNotFound()
        {
            List<FoodSearchResultItem> foodSearchNullResultMock = null;
            
            base._mockService.Setup(srv => srv.SearchFoodByCity(string.Empty))
            .ReturnsAsync(foodSearchNullResultMock);

            var controller = new OrderController(base._mockService.Object);

            var result = await controller.SearchFood(string.Empty);

            var viewResult = Assert.IsType<NotFoundResult>(result);

            var resultModel = Assert.IsAssignableFrom<NotFoundResult>(viewResult);

            Assert.Equal(HttpStatusCode.NotFound, (HttpStatusCode)resultModel.StatusCode);

        }

        [Fact]
        public async Task GivenMenuIds_ShouldConfirmOrder()
        {
            OrderPlacementModel newOrder = new OrderPlacementModel { CustomerId = 1, MenuItemIds = new int[] { 123, 456, 789 } };

            OrderConfirmationModel confirmedOrder = new OrderConfirmationModel { CustomerName = "foo", OrderId = 300 };

            base._mockService.Setup(srv => srv.PlaceOrder(newOrder))
            .ReturnsAsync(confirmedOrder);

            var controller = new OrderController(base._mockService.Object);

            var result = await controller.PlaceOrder(newOrder);

            var viewResult = Assert.IsType<OkObjectResult>(result);

            var resultModel = Assert.IsAssignableFrom<OkObjectResult>(viewResult);

            Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)resultModel.StatusCode);

            var model = Assert.IsAssignableFrom<OrderConfirmationModel> (resultModel.Value);

            Assert.NotNull(model);

        }

        [Fact]        
        public async Task GivenNoInvalidOrder_ShouldReturnErroCode()
        {            
            //todo: make [InlineData]?? 
            OrderPlacementModel invalidOrder_noCustomerId = new OrderPlacementModel
            {
                CustomerId = 0,
                MenuItemIds = new int[] { 1, 2, 3 },
                OrderId = 1 //todo: should be a nullable 
            };

            OrderPlacementModel invalidOrder_noOrderIds = new OrderPlacementModel
            {
                CustomerId = 1,
                MenuItemIds = { },
                OrderId = 1 
            };
            
            OrderConfirmationModel confirmedOrder = null;

            _mockService.Setup(srv => srv.PlaceOrder(invalidOrder_noCustomerId))
            .ReturnsAsync(confirmedOrder);

            var controller = new OrderController(base._mockService.Object);

            var result = await controller.PlaceOrder(null);

            var viewResult = Assert.IsType<BadRequestResult>(result);

            var resultModel = Assert.IsAssignableFrom<BadRequestResult>(viewResult);

            Assert.Equal(HttpStatusCode.BadRequest, (HttpStatusCode)resultModel.StatusCode);
        }

    }
}
