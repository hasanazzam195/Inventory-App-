using InventoryDataAccess.Entity;
using InventoryDataAccess.generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryBusinessLogic.SpeceficRepository
{
    public class OrderService : IOrderService
    {
        public void Delete(int id)
        {
            IGeneric<Order> generic = new Generic<Order>();
            generic.Delete(id);
        }

        public Order find(int id)
        {
            IGeneric<Order> generic = new Generic<Order>();
            Order order = generic.LoadBy(id);
            return order;
        }

        public void Insert(Order order)
        {
            IGeneric<Order> generic = new Generic<Order>();
            generic.Insert(order);
        }

        public List<Order> LoadAll()
        {
            IGeneric<Order> generic = new Generic<Order>();
            List<Order> li = generic.LoadAll();
            return li;
        }

        public void Update(Order order)
        {
            IGeneric<Order> generic = new Generic<Order>();
            generic.update(order);
        }
    }
}
