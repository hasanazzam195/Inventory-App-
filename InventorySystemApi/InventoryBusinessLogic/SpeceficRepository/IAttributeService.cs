using System;
using System.Collections.Generic;
using System.Text;
using InventoryDataAccess.DTO;
using InventoryDataAccess.Entity;

namespace InventoryBusinessLogic.SpeceficRepository
{
    public interface IAttributeService
    {
        List<VMAttribute> LoadAll();
        List<Attributes> LoadByName(string name);
    }
}
