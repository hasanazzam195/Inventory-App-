using InventoryDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryBusinessLogic.SpeceficRepository
{
    public interface ICurrencyService
    {
        List<Currency> LoadAll();
    }
}
