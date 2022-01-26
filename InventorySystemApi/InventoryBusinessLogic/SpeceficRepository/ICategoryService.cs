using InventoryDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryBusinessLogic.SpeceficRepository
{
    public interface ICategoryService
    {
        List<Category> LoadAll();
        void Insert(Category category);
        List<Category> LaodByName(string name);
        void Remove(int id);
        Category LoadByID(int id);
        void update(Category category);
    }
}
