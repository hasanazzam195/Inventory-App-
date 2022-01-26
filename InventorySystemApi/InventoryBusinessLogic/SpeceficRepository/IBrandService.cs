using InventoryDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryBusinessLogic.SpeceficRepository
{
    public interface IBrandService
    {
        void Insert(Brand b);
        List<Brand> LoadAll();
        List<Brand> Search(string name);
        Brand LoadBy(int a);
        void Remove(int id);
        void update(Brand b);
    }
}
