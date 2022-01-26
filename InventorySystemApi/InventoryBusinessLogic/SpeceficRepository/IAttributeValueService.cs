using InventoryDataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryBusinessLogic.SpeceficRepository
{
    public interface IAttributeValueService
    {
        List<AttributeValue> LoadBy(int id);
        void Insert(AttributeValue attributeValue);
        void Delete(int id);

        AttributeValue Edit(int id);

        void update(AttributeValue value);
        List<AttributeValue> LoadColor();
        List<AttributeValue> LoadSize();
    }
}
