using InventoryDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryBusinessLogic.SpeceficRepository
{
    public interface IStoreService
    {
        List<store> LoadAll();

        void Insert(store s);
        void Delete(int id);

        List<store> LoadByName(string name);

        store LoadByID(int id);
        void update(store s);


    }
}
