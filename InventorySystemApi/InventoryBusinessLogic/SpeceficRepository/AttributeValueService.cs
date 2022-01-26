using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InventoryDataAccess.Context;
using InventoryDataAccess.Entity;
using InventoryDataAccess.generic;

namespace InventoryBusinessLogic.SpeceficRepository
{
    public class AttributeValueService : IAttributeValueService
    {
        InventoryContext context;
        public AttributeValueService()
        {
            context = new InventoryContext();
        }

        public List<AttributeValue> LoadBy(int id)
        {
            List<AttributeValue> li = context.attributeValues.Where(x => x.Attribute_id == id).ToList();
            return li;
        }

        public void Insert(AttributeValue attributeValue)
        {
            IGeneric<AttributeValue> generic = new Generic<AttributeValue>();
            generic.Insert(attributeValue);
        }

        public void Delete(int id)
        {
            IGeneric<AttributeValue> generic = new Generic<AttributeValue>();
            generic.Delete(id);
        }

        public AttributeValue Edit(int id)
        {
            IGeneric<AttributeValue> generic = new Generic<AttributeValue>();
            AttributeValue value = generic.LoadBy(id);
            return value;
        }

        public void update(AttributeValue value)
        {
            IGeneric<AttributeValue> generic = new Generic<AttributeValue>();
            generic.update(value);
        }

        public List<AttributeValue> LoadColor()
        {
            List<AttributeValue> li = context.attributeValues.Where(x => x.Attribute_id == 1).ToList();
            return li;
        }

        public List<AttributeValue> LoadSize()
        {
            List<AttributeValue> li = context.attributeValues.Where(x => x.Attribute_id == 2).ToList();
            return li;
        }
    }
}
