using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderInLite.Models.Business;
using System.Text.Json;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderInLite.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {        
        [HttpGet]
        public IEnumerable<FoodSearchResultItem> SearchFood(string searchTerm = "tacos in cape town")
        {
            //todo: sanitize and process search string
            if (string.IsNullOrWhiteSpace(searchTerm)) return null; 

            var result =  new List<FoodSearchResultItem>()
            {
                new FoodSearchResultItem(){CategoryName = "abc", CityName ="cape town", Price = 120, MenuItemName="classic taco" },
                new FoodSearchResultItem(){CategoryName = "efj", CityName ="cape town", Price = 120, MenuItemName="classic taco1" },
                new FoodSearchResultItem(){CategoryName = "xyz", CityName ="cape town", Price = 120, MenuItemName="classic taco2" }
            };

            return result;
        }

        [HttpPost]
        public string PlaceOrder([FromBody] OrderPlacement newOrder)
        {
            if (newOrder == null) return null;


            return "success";
        }

        [HttpPost]
        public List<string> SearchMenu(string value)
        {
            return  null;
        }
       
    }
}
