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
    public class CurrencyController : ControllerBase
    {
        private  ICurrencyService currencyService;

        public CurrencyController(ICurrencyService _currencyService)
        {
            currencyService = _currencyService;
        }

        [HttpGet]
        public List<Currency> LoadAll()
        {
            List<Currency> li = currencyService.LoadAll();
            return li;
        }
    }
}
