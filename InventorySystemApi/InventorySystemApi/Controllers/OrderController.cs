using InventoryBusinessLogic.SpeceficRepository;
using InventoryDataAccess.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private  IOrderService orderService;

        public OrderController(IOrderService _orderService)
        {
            orderService = _orderService;
        }
        [HttpPost]
        [Route("Insert")]
        public void Insert(Order order)
        {
            orderService.Insert(order);
        }
        [HttpGet]
        [Route("LoadAll")]
        public List<Order> LoadAll()
        {
            List<Order> li = orderService.LoadAll();
            return li;
        }
        [HttpGet]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            orderService.Delete(id);
        }
        [HttpGet]
        [Route("Edit/{id}")]
        public Order find(int id)
        {
            Order order = orderService.find(id);
            return order;
        }
        [HttpPost]
        [Route("Update")]
        public void Update(Order order)
        {
            orderService.Update(order);
        }
    }
}
