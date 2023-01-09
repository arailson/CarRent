using CarRent.Interfaces;
using CarRent.Enum;
using CarRent.Model;
using Microsoft.AspNetCore.Mvc;

namespace ICarRent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FleetController : ControllerBase
    {
        private Fleet fleet = new Fleet();

        

        private List<ICar> AmountVehiclesSuv()
        {
            return this.AmountVehiclesByCategory(ECategory.Suv);
        }

        private List<ICar> AmountVehiclesHatch()
        {
            return this.AmountVehiclesByCategory(ECategory.Hatch);
        }

        private List<ICar> AmountVehiclesSedan()
        {
            return this.AmountVehiclesByCategory(ECategory.Sedan);
        }
        private List<ICar> AmountVehiclesFoguete()
        {
            return this.AmountVehiclesByCategory(ECategory.Foguete);
        }

        private List<ICar> AmountVehiclesByCategory(ECategory category)
        {
            var ICarList = this.fleet.AmountVehiclesByCategory(category);
            List<ICar> returnList = new();
            foreach (var item in ICarList)
            {
                if (this.fleet.IsAvailable(item))
                    returnList.Add(item);
            }

            return returnList;
        }


        [HttpGet]
        public IEnumerable<ICar> GetICars()
        {
            return this.fleet.StockCar;
        }

        [HttpGet]
        [Route("suv")]
        public IEnumerable<ICar> GetAvailableSuv()
        {
            return this.AmountVehiclesSuv();
        }

        [HttpGet]
        [Route("sedan")]
        public IEnumerable<ICar> GetAvailableSedan()
        {
            return this.AmountVehiclesSedan();
        }

        [HttpGet]
        [Route("hatch")]
        public IEnumerable<ICar> GetAvailableHatch()
        {
            return this.AmountVehiclesHatch();
        }

        [HttpGet]
        [Route("foguete")]
        public IEnumerable<ICar> GetAvailableFoguete()
        {
            return this.AmountVehiclesFoguete();
        }
    }
}
