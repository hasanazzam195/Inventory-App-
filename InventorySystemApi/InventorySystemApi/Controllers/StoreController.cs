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
    public class StoreController : ControllerBase
    {
        private  IStoreService storeService;

        public StoreController(IStoreService _storeService)
        {
            storeService = _storeService;
        }
        [HttpGet]
        [Route("LoadAllStore")]
        public List<store> LoadAll()
        {
            List<store> li = storeService.LoadAll();
            return li;
        }
        [HttpPost]
        [Route("Insert")]
        public void Insert(store s)
        {
            storeService.Insert(s);
        }
        [HttpGet]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            storeService.Delete(id);
        }
        [HttpGet]
        [Route("LoadByName/{name}")]
        public List<store> LoadByName(string name)
        {
            List<store> li = storeService.LoadByName(name);
            return li;
        }
        [HttpGet]
        [Route("Edit/{id}")]
        public store Edit(int id)
        {
            store li = storeService.LoadByID(id);
            return li;
        }
        [HttpPost]
        [Route("update")]
        public void update(store s)
        {
            storeService.update(s);
        }
    }
}
