using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InventoryDataAccess.Context;
using InventoryDataAccess.Entity;
using InventoryDataAccess.generic;
using InventoryDataAccess.DTO;

namespace InventoryBusinessLogic.SpeceficRepository
{
    public class AttributeService : IAttributeService
    {
        InventoryContext context;
        public AttributeService()
        {
            context = new InventoryContext();
        }
        public List<VMAttribute> LoadAll()
        {
            //IGeneric<Attributes> generic = new Generic<Attributes>();
            //List<Attributes> li = generic.LoadAll();
            //return li;

            List<VMAttribute> li = context.attributes.Select(data =>
            new VMAttribute
            {
                Att = data,
                Count = data.liAttributevalue.Count()
            }
            ).ToList();
            return li;
        }

        public List<Attributes> LoadByName(string name)
        {
            List<Attributes> li = context.attributes.Where(x => x.Name == name).ToList();
            return li;
        }

       


    }
}
