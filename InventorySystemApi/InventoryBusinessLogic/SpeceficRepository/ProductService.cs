using InventoryDataAccess.Context;
using InventoryDataAccess.Entity;
using InventoryDataAccess.generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryBusinessLogic.SpeceficRepository
{
    public class ProductService : IProductService
    {
        private InventoryContext context;

        public ProductService()
        {
            context = new InventoryContext();
        }
        public void Insert(Product product)
        {
            IGeneric<Product> generic = new Generic<Product>();
            generic.Insert(product);
        }

        public Product LoadBy(int id)
        {
            IGeneric<Product> generic = new Generic<Product>();
             Product p = generic.LoadBy(id);
            return p;
        }

        //public Product LastOrder()
        //{
        //    Product p = context.products.ToList().LastOrDefault();
        //    return p;
        //}

        public List<Product> LoadAll()
        {
            List<Product> li = context.products.Include("store").ToList();
            return li;
        }

        
        public void Update(Product product)
        {
            IGeneric<Product> generic = new Generic<Product>();
            generic.update(product);
        }

        public void delete(int id)
        {
            IGeneric<Product> generic = new Generic<Product>();
            generic.Delete(id);
        }

       
    }
}
