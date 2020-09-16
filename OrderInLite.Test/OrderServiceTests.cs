using System;
using System.Threading.Tasks;
using Xunit;
using Moq;
using OrderInLite.Models.Business;
using System.Collections.Generic;
using OrderInLite.Service;

namespace OrderInLite.Test
{
    public class OrderServiceTests : BaseOrderTests
    {
        public OrderServiceTests()
        {
        }

        [Fact]
        public async Task GivenValidSearch_ShouldReturnResult()
        {
            string searchPhrase = "Taco in Cape Town";

            SearchModel searchModel = new SearchModel { FoodName = "Taco", CityName = "Cape Town" };

            base._mockRepo.Setup(repo => repo.SearchFoodByCity(searchModel.FoodName, searchModel.CityName))
            .ReturnsAsync(base.FoodSearchResultMock);

            var service = new OrderService(_mockRepo.Object);

            var result = await service.SearchFoodByCity(searchPhrase);
            var viewResult = Assert.IsType<List<FoodSearchResultItem>>(result);

            var model = Assert.IsAssignableFrom<List<FoodSearchResultItem>>(viewResult);

            Assert.Equal(2, model.Count);
        }

        [Fact]
        public async Task GivenInvalidSearch_ShouldReturnNull()
        {

            throw new NotImplementedException();
        }

        [Fact]
        public async Task GivenMenuIds_ShouldConfirmOrder()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public async Task GivenNoMenuIds_ShouldReturnNull()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public async Task GivenSearchPhrase_ShouldPopulateSearchObject()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public async Task GivenInvalidSearchPhrase_ShouldThrowException()
        {
            throw new NotImplementedException();
        }
    }
}
