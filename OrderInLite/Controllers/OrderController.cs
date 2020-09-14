using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderInLite.Models.Business;
using System.Text.Json;
using OrderInLite.Interfaces;
using OrderInLite.Service;

namespace OrderInLite.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<List<FoodSearchResultItem>> SearchFood(string searchPhrase)
        {
            if (string.IsNullOrWhiteSpace(searchPhrase)) return null;

            return await _orderService.SearchFoodByCity(searchPhrase);
        }

        [HttpPost]
        public async Task<OrderConfirmationModel> PlaceOrder([FromBody] OrderPlacementModel newOrder)
        {
            if (newOrder == null) return null;

            var confirmedOrder = await _orderService.PlaceOrder(newOrder);

            return confirmedOrder.OrderId > 0 ? confirmedOrder : null;
        }
    }
}
