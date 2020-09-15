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
    public class OrderServiceTests:BaseOrderTests
    {
        public OrderServiceTests()
        {
        }

        [Fact]
        public override async Task GivenSearchPhrase_ShouldReturnResult()
        {

        }

        [Fact]
        public override async Task GivenEmptySearchPhrase_ShouldReturnNull()
        {

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
        public async Task GivenSearchPhrase_ShouldParse()
        {

        }

        [Fact]
        public async Task GivenInvalidSearchPhrase_ShouldThrowException()
        {

        }

    }
}
