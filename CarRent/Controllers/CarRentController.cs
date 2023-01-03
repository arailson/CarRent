using CarRent.Core;
using CarRent.Model;
using Microsoft.AspNetCore.Mvc;

namespace CarRent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarRentController
    {
        private static List<Store> stores = new List<Store>();

        public CarRentController()
        {
            Category suv = new Category("suv");
            Category sedan = new Category("sedan");
            Category hatch = new Category("hatch");

            Car compass = new Car(suv, "Compass", Enum.EStatus.ALUGADO);
            Car azera = new Car(sedan, "Azera", Enum.EStatus.DISPONIVEL);
            Car hb20 = new Car(hatch, "HB20", Enum.EStatus.EM_MANUTENCAO);

            Car[] listCar = { compass, azera, hb20 };
            Console.WriteLine("Lista de carros => "+ listCar[1].Name);

        }
        
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
