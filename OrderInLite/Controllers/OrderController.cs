using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderInLite.Models.Business;
using System.Text.Json;
using OrderInLite.Interfaces;
using OrderInLite.Service;
using Microsoft.AspNetCore.Http;

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
        public async Task<IActionResult> SearchFood(string searchPhrase)
        {
            if (string.IsNullOrWhiteSpace(searchPhrase)) return NotFound();

            var result =  await _orderService.SearchFoodByCity(searchPhrase);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PlaceOrder([FromBody] OrderPlacementModel newOrder)
        {
             if (! await IsValidOrder(newOrder)) return BadRequest();

            var confirmedOrder = await _orderService.PlaceOrder(newOrder);

            if (confirmedOrder.OrderId == 0) return StatusCode(500);

            return Ok(confirmedOrder);
        }

        private async Task<bool> IsValidOrder(OrderPlacementModel newOrder)
        {
            return newOrder != null && newOrder.CustomerId > 0 && newOrder.MenuItemIds.Any();
        }
    }
}
