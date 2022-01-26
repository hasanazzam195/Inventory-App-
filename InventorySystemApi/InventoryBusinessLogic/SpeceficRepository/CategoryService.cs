using InventoryDataAccess.Context;
using InventoryDataAccess.Entity;
using InventoryDataAccess.generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryBusinessLogic.SpeceficRepository
{
    public class CategoryService : ICategoryService
    {
        InventoryContext context;
        public CategoryService()
        {
            context = new InventoryContext();
        }
        
        public List<Category> LoadAll()
        {
            IGeneric<Category> genericCategory = new Generic<Category>();
            List<Category> li= genericCategory.LoadAll();
            return li;
        }
        
        public void Insert(Category category)
        {
            IGeneric<Category> genericCategory = new Generic<Category>();
            genericCategory.Insert(category);
        }

        public List<Category> LaodByName(string name)
        {
            List<Category> li = context.categories.Where(x => x.Name == name).ToList();
            return li;
        }

        public void Remove(int id)
        {
            IGeneric<Category> genericCategory = new Generic<Category>();
            genericCategory.Delete(id);
        }

        public Category LoadByID(int id)
        {
            IGeneric<Category> genericCategory = new Generic<Category>();
            Category li = genericCategory.LoadBy(id);
            return li;
        }

        public void update(Category category)
        {
            IGeneric<Category> genericCategory = new Generic<Category>();
            genericCategory.update(category);
        }
    }
}
