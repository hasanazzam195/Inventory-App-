using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryDataAccess.DTO;
using InventoryBusinessLogic.SpeceficRepository;
using InventoryDataAccess.Entity;
using System.IO;

namespace InventorySystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private  IAttributeValueService attributeValueService;
        private  IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }
       

       
        
        [HttpPost]
        [Route("Insert")]
        public void Insert(Product product)
        {
            productService.Insert(product);
        }
        [HttpGet]
        [Route("LoadBy/{id}")]
        public Product Edit(int id)
        {
            Product p = productService.LoadBy(id);
            return p;
        }
        //[HttpGet]
        //[Route("LoadLastOrder")]
        //public Product LastOrder()
        //{
        //    Product p = productService.LastOrder();
        //    return p;
        //}
        [HttpGet]
        [Route("LoadAll")]
        public List<Product> LoadAll()
        {
            List<Product> li = productService.LoadAll();
            return li;
        }
        [HttpPost]
        [Route("Update")]
        public void Update(Product product)
        {
            productService.Update(product);
        }
        [HttpGet]
        [Route("Delete/{id}")]
        public void Remove(int id)
        {
            productService.delete(id);
        }
        [HttpPost]
        [Route("Upload")]
        public void UploadFile()
        {
            IFormFile file = HttpContext.Request.Form.Files[0];
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads", file.FileName);
            file.CopyTo(new FileStream(filePath, FileMode.Create));
            
        }
    }
}
