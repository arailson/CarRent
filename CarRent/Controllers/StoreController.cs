using CarRent.Data;
using CarRent.Model;
using CarRent.Validator;
using Microsoft.AspNetCore.Mvc;

namespace CarRent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase
    {
        private StoreDbSingleton StoreDb { get; set; }
        public StoreController()
        {
            StoreDb = StoreDbSingleton.Instance;
        }

        [HttpPost]
        public IActionResult AddStore([FromBody] Store store)
        {
            var validator = new StoreValidator().ValidateNome(store.Name).ValidateCnpj(store.Cnpj).ValidateCep(store.Cep);
            if (!validator.isValid()) 
            {
                return StatusCode(400);
            }
            StoreDb.DB_STORES.Add(store);
            return Ok();
        }

        [HttpGet]
        public IEnumerable<Store> RecuperaStore()
        {

            return StoreDb.DB_STORES;
        }
    }
}
