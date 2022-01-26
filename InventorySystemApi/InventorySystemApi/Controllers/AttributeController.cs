using InventoryBusinessLogic.SpeceficRepository;
using InventoryDataAccess.Context;
using InventoryDataAccess.DTO;
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
    public class AttributeController : ControllerBase
    {
        private  IAttributeService attributeService;
        InventoryContext context;
        public AttributeController(IAttributeService _attributeService)
        {
            context = new InventoryContext();
            attributeService = _attributeService;
        }
        [HttpGet]
        [Route("LoadAll")]
        public List<VMAttribute> LoadAll()
        {
            List<VMAttribute> li = attributeService.LoadAll();
            return li;
        }
        [HttpGet]
        [Route("LoadByName/{name}")]
        public List<Attributes> LoadByName(string name)
        {
            List<Attributes> li = attributeService.LoadByName(name);
            return li;
        }
    }
}
