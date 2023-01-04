using CarRent.Enum;
using CarRent.Model;
using Microsoft.AspNetCore.Mvc;

namespace CarRent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FleetController : ControllerBase
    {
        private Fleet fleet = new Fleet();

        

        private List<Car> AmountVehiclesSuv()
        {
            return this.AmountVehiclesByCategory(ECategory.Suv);
        }

        private List<Car> AmountVehiclesHatch()
        {
            return this.AmountVehiclesByCategory(ECategory.Hatch);
        }

        private List<Car> AmountVehiclesSedan()
        {
            return this.AmountVehiclesByCategory(ECategory.Sedan);
        }
        private List<Car> AmountVehiclesFoguete()
        {
            return this.AmountVehiclesByCategory(ECategory.Foguete);
        }

        private List<Car> AmountVehiclesByCategory(ECategory category)
        {
            var carList = this.fleet.AmountVehiclesByCategory(category);
            List<Car> returnList = new();
            foreach (var item in carList)
            {
                if (this.fleet.IsAvailable(item))
                    returnList.Add(item);
            }

            return returnList;
        }


        [HttpGet]
        public IEnumerable<Car> GetCars()
        {
            return this.fleet.StockCar;
        }

        [HttpGet]
        [Route("suv")]
        public IEnumerable<Car> GetAvailableSuv()
        {
            return this.AmountVehiclesSuv();
        }

        [HttpGet]
        [Route("sedan")]
        public IEnumerable<Car> GetAvailableSedan()
        {
            return this.AmountVehiclesSedan();
        }

        [HttpGet]
        [Route("hatch")]
        public IEnumerable<Car> GetAvailableHatch()
        {
            return this.AmountVehiclesHatch();
        }

        [HttpGet]
        [Route("foguete")]
        public IEnumerable<Car> GetAvailableFoguete()
        {
            return this.AmountVehiclesFoguete();
        }
    }
}
