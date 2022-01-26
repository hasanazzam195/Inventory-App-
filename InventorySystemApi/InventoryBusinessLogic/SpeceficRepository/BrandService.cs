using System;
using System.Collections.Generic;
using System.Text;
using InventoryDataAccess.Context;
using InventoryDataAccess.Entity;
using InventoryDataAccess.generic;
using System.Linq;

namespace InventoryBusinessLogic.SpeceficRepository
{
    public class BrandService: IBrandService
    {
        private InventoryContext context;

        public BrandService()
        {
            context = new InventoryContext();
        }
        public void Insert(Brand b)
        {
            IGeneric<Brand> genericServBrand = new Generic<Brand>();
            genericServBrand.Insert(b);
        }

        public List<Brand> LoadAll()
        {
            IGeneric<Brand> genericServBrand = new Generic<Brand>();
            List<Brand> li = genericServBrand.LoadAll();
            return li;
        }

        public List<Brand> Search(string name)
        {
            List<Brand> li = context.brands.Where(x => x.Name == name).ToList();
            return li;
        }

        public Brand LoadBy(int id)
        {
            IGeneric<Brand> genericServBrand = new Generic<Brand>();
            Brand li = genericServBrand.LoadBy(id);
            return li;
        }

        public void Remove(int id)
        {
            IGeneric<Brand> genericServBrand = new Generic<Brand>();
            genericServBrand.Delete(id);
        }

        public void update(Brand b)
        {
            IGeneric<Brand> genericServBrand = new Generic<Brand>();
            genericServBrand.update(b);
        }
    }
}
