using Microsoft.AspNetCore.Mvc;
using OrderManagement.Application.Services;
using OrderManagement.Domain.Entities;

namespace OrderManagementAPI.Controllers
{ 
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public IActionResult CreateOrder([FromBody] Order order)
        {
            _orderService.CreateOrder(order);
            return Ok("Order created successfully.");
        }
    }

}
