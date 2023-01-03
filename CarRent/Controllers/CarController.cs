using CarRent.Core;
using Microsoft.AspNetCore.Mvc;

namespace CarRent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private static List<Car> cars = new List<Car>();

        public CarController()
        {

            Car compass = new Car(Enum.ECategory.Suv, "Compass", Enum.EStatus.ALUGADO);
            Car azera = new Car(Enum.ECategory.Sedan, "Azera", Enum.EStatus.DISPONIVEL);
            Car hb20 = new Car(Enum.ECategory.Hatch, "HB20", Enum.EStatus.INDISPONIVEL);

            //Car[] listCar = { compass, azera, hb20 };
            //Console.WriteLine("Lista de carros => "+ listCar[1].Name);

            cars.Add(hb20);
            cars.Add(azera);
            cars.Add(compass);

            Console.WriteLine("Lista de carros => " + cars);
        }

        [HttpGet]
        public IEnumerable<Car> GetCars()
        {
            return cars;
        }
    }
}
