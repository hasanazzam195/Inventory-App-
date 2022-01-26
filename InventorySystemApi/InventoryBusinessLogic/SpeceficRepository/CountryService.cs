using InventoryDataAccess.Entity;
using InventoryDataAccess.generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryBusinessLogic.SpeceficRepository
{
    public class CountryService : ICountryService
    {
        public List<Country> LoadAll()
        {
            IGeneric<Country> generic = new Generic<Country>();
            List<Country> li = generic.LoadAll();
            return li;
        }
    }
}
