using InventoryDataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryDataAccess.generic
{

    public class Generic<T> : IGeneric<T> where T : class
    {
        InventoryContext context;
        public Generic()
        {
            context = new InventoryContext();
        }
        public void Insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public void update(T obj)
        {
            context.Set<T>().Attach(obj);
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public List<T> LoadAll()
        {
            List<T> li = context.Set<T>().ToList();
            return li;
        }

        public T LoadBy(int a)
        {
            T t = context.Set<T>().Find(a);
            return t;
        }

        public void Delete(int id)
        {
           T obj= context.Set<T>().Find(id);
           context.Remove(obj);
           context.SaveChanges();
        }
    }
}
