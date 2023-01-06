using CarRent.Model;
using Microsoft.AspNetCore.Mvc;

namespace CarRent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarRentController : ControllerBase
    {
        private List<CarRentModel> carsRent = new List<CarRentModel>();

        [HttpPost]
        public void AddCarRent([FromBody] CarRentModel carRent)
        {
            carsRent.Add(carRent);
        }

        [HttpGet]
        public IEnumerable<CarRentModel> GetCarRent()
        {
            return carsRent;
        }
    }
}
