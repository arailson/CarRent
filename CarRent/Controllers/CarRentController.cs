using CarRent.Model;
using Microsoft.AspNetCore.Mvc;

namespace CarRent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarRentController
    {
        private static List<Store> stores = new List<Store>();
        
        [HttpPost]
        public void AddStore([FromBody] Store store)
        {
            stores.Add(store);
        }

        [HttpGet]
        public IEnumerable<Store> RecuperaStore()
        {
            return stores;
        }
    }
}
