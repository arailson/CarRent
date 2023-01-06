using CarRent.Model;
using Microsoft.AspNetCore.Mvc;

namespace CarRent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private List<Car> cars = new List<Car>();

        [HttpPost]
        public void AddCar([FromBody] Car car)
        {
            cars.Add(car);
        }

        [HttpGet]
        public IEnumerable<Car> GetCars()
        {
            return cars;
        }
    }
}
