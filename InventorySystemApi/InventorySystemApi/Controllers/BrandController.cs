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
    public class BrandController : ControllerBase
    {
        private IBrandService brandService;

        public BrandController(IBrandService _brandService)
        {
            brandService = _brandService;
        } 
        [HttpGet]
        [Route("LoadAllBrand")]
        public List<Brand> LoadAll()
        {
            List<Brand> li = brandService.LoadAll();
            return li;
        }
        [HttpPost]
        [Route("Insert")]
        public void Insert(Brand b)
        {
            brandService.Insert(b);
        }
        [HttpGet]
        [Route("LoadByName/{name}")]
        public List<Brand> LoadByName(string name)
        {
            List<Brand> li = brandService.Search(name);
            return li;
        }
        [HttpGet]
        [Route("Edit/{id}")]
        public Brand Edit(int id)
        {
           Brand li = brandService.LoadBy(id);
            return li;
        }

        [HttpGet]
        [Route("Delete/{id}")]
        public void delete(int id)
        {
            brandService.Remove(id);
        }
        [HttpPost]
        [Route("update")]
        public void updateData(Brand b)
        {
            brandService.update(b);
        }
    }
}
