using InventoryDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryBusinessLogic.SpeceficRepository
{
    public interface IOrderService
    {
        void Insert(Order order);
        List<Order> LoadAll();
        void Delete(int id);
        Order find(int id);

        void Update(Order order);

    }
}
