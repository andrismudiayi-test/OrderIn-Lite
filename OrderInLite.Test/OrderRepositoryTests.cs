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
        public async Task GivenValidSearch_ShouldReturnResult()
        {
            throw new NotImplementedException();
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
        public  async Task ShouldReturnListOfCityNames()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public  async Task ShouldReturnListOfFoodsNames()
        {
            throw new NotImplementedException();
        }

    }
}
