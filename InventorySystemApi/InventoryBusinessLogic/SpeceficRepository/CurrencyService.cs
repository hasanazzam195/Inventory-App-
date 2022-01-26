using InventoryDataAccess.Entity;
using InventoryDataAccess.generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryBusinessLogic.SpeceficRepository
{
    public class CurrencyService : ICurrencyService
    {
        public List<Currency> LoadAll()
        {
            IGeneric<Currency> generic = new Generic<Currency>();
            List<Currency> li = generic.LoadAll();
            return li;
        }
    }
}
