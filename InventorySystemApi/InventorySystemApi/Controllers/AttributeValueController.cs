using InventoryBusinessLogic.SpeceficRepository;
using InventoryDataAccess.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributeValueController : ControllerBase
    {
        private  IAttributeValueService attributeValueService;

        public AttributeValueController(IAttributeValueService _attributeValueService)
        {
            attributeValueService = _attributeValueService;
        }


        [HttpGet]
        [Route("LoadByID/{id}")]
        public List<AttributeValue> LoadBy(int id)
        {
            List<AttributeValue> li = attributeValueService.LoadBy(id);
            return li;
        }
        [HttpPost]
        [Route("Insert")]
        public void Insert(AttributeValue attributeValue)
        {
            attributeValueService.Insert(attributeValue);
        }
        [HttpGet]
        [Route("Remove/{id}")]
        public void Delete(int id)
        {
            attributeValueService.Delete(id);
        }
        [HttpGet]
        [Route("Edit/{id}")]
        public AttributeValue Edit(int id)
        {
            AttributeValue value = attributeValueService.Edit(id);
            return value;
        }
        [HttpPost]
        [Route("update")]
        public void update(AttributeValue value)
        {
            attributeValueService.update(value);
        }

        [HttpGet]
        [Route("LoadAllColor")]
        public List<AttributeValue> LoadAllColor()
        {
            List<AttributeValue> li = attributeValueService.LoadColor();
            return li;
        }

        [HttpGet]
        [Route("LoadAllSize")]
        public List<AttributeValue> LoadAllSize()
        {
            List<AttributeValue> li = attributeValueService.LoadSize();
            return li;
        }
    }
}
