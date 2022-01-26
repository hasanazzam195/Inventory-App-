using InventoryDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryBusinessLogic.SpeceficRepository
{
    public interface IProductService
    {
        void Insert(Product product);
        Product LoadBy(int id);
        //Product LastOrder();
        List<Product> LoadAll();

        void Update(Product product);

        void delete(int id);

       
       

    }
}
