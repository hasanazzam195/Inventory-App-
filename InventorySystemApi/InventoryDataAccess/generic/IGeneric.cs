using InventoryDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryDataAccess.generic
{
    public interface IGeneric<T> where T :class
    {
        void Insert(T obj);
        void update(T obj);
        List<T> LoadAll();
        T LoadBy(int id);
        void Delete(int id);


    }

}
