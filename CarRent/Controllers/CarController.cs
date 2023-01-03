using CarRent.Model;
using Microsoft.AspNetCore.Mvc;

namespace CarRent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private static List<Car> DB_CARS = new List<Car>();

        public CarController()
        {
            Car compass = new Car(Enum.ECategory.Suv, "Compass", Enum.EStatus.ALUGADO);
            Car azera = new Car(Enum.ECategory.Sedan, "Azera", Enum.EStatus.DISPONIVEL);
            Car hb20 = new Car(Enum.ECategory.Hatch, "HB20", Enum.EStatus.INDISPONIVEL);

            DB_CARS.Add(hb20);
            DB_CARS.Add(azera);
            DB_CARS.Add(compass);

            Console.WriteLine("Lista de carros => " + DB_CARS);
        }


        [HttpGet]
        public IEnumerable<Car> GetCars()
        {
            return DB_CARS;
        }
    }
}
