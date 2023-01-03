using CarRent.Model;
using Microsoft.AspNetCore.Mvc;

namespace CarRent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase
    {
        private static List<Store> DB_STORES = new List<Store>();

        public StoreController()
        {
          
        }
        
        [HttpPost]
        public void AddStore([FromBody] Store store)
        {
            DB_STORES.Add(store);
        }

        [HttpGet]
        public IEnumerable<Store> RecuperaStore()
        {
            return DB_STORES;
        }
    }
}
