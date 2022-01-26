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
    public class CountryController : ControllerBase
    {
        private  ICountryService coutryService;

        public CountryController(ICountryService _coutryService)
        {
            coutryService = _coutryService;
        }
        [HttpGet]
        public List<Country> LoadAll()
        {
            List<Country> li = coutryService.LoadAll();
            return li;
        }
    }
}
