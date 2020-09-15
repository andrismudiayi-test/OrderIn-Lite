using System;
using System.Threading.Tasks;
using Xunit;
using Moq;
using OrderInLite;
using OrderInLite.Controllers;
using OrderInLite.Interfaces;
using OrderInLite.Models.Business;
using System.Collections.Generic;
using OrderInLite.Repository;

namespace OrderInLite.Test
{
    public class OrderRepositoryTests : BaseOrderTests
    {
        public OrderRepositoryTests()
        {
        }

        [Fact]
        public override async Task GivenSearchPhrase_ShouldReturnResult()
        {

        }

        [Fact]
        public override async Task GivenEmptySearchPhrase_ShouldReturnNull()
        {
            List<FoodSearchResultItem> foodSearchNullResultMock = null;

            base.MockRepo.Setup(repo => repo.SearchFoodByCity(string.Empty))
            .ReturnsAsync(foodSearchNullResultMock);

            var repo = new RepositoryService (base.MockRepo.Object);

            var result = await repo.SearchFoodByCity(string.Empty);
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

        [Fact]
        public override async Task ShouldReturnListOfCityNames()
        {

        }

        [Fact]
        public override async Task ShouldReturnListOfFoodsNames()
        {

        }

    }
}
