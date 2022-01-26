using InventoryDataAccess.Context;
using InventoryDataAccess.Entity;
using InventoryDataAccess.generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryBusinessLogic.SpeceficRepository
{
    public class StoreService:IStoreService
    {
        InventoryContext context;
        public StoreService()
        {
            context = new InventoryContext();
        }

        public List<store> LoadAll()
        {
            IGeneric<store> genericStore = new Generic<store>();
            List<store> li = genericStore.LoadAll();
            return li;
        }

        public void Insert(store s)
        {
            IGeneric<store> genericStore = new Generic<store>();
            genericStore.Insert(s);
        }

        public void Delete(int id)
        {
            IGeneric<store> genericStore = new Generic<store>();
            genericStore.Delete(id);
        }

        public List<store> LoadByName(string name)
        {
            List<store> li = context.stores.Where(x => x.Name == name).ToList();
            return li;
        }

        public store LoadByID(int id)
        {
            IGeneric<store> genericStore = new Generic<store>();
            store li = genericStore.LoadBy(id);
            return li;
        }

        public void update(store s)
        {
            IGeneric<store> genericStore = new Generic<store>();
            genericStore.update(s);
        }
    }
}
