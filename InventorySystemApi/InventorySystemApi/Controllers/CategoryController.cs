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
    public class CategoryController : ControllerBase
    {
        private  ICategoryService categoryService;

        public CategoryController(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }
        [HttpGet]
        [Route("loadAllCategory")]
        public List<Category> LoadAll()
        {
            List<Category> li = categoryService.LoadAll();
            return li;
        }
        [HttpPost]
        [Route("Insert")]
        public void Insert(Category category)
        {
            categoryService.Insert(category);
        }
        [HttpGet]
        [Route("loadByName/{name}")]
        public List<Category> LaodByName(string name)
        {
            List<Category> li = categoryService.LaodByName(name);
            return li;
        }
        [HttpGet]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            categoryService.Remove(id);
        }
        [HttpGet]
        [Route("LoadByID/{id}")]
        public Category LoadByID(int id)
        {
            Category li = categoryService.LoadByID(id);
            return li;
        }
        [HttpPost]
        [Route("update")]
        public void update(Category category)
        {
            categoryService.update(category);
        }
    }
}
