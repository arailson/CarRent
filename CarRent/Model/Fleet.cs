using CarRent.Enum;

namespace CarRent.Model
{
    public class Fleet
    {
        public List<Car> StockCar { get; set; }
        public List<CarRentModel> CarRentModelList { get; set; }
        public Fleet()
        {
            var compass = new Car(Enum.ECategory.Suv, "Compass", Enum.EStatus.DISPONIVEL);
            var kicks = new Car(Enum.ECategory.Suv, "Kicks", Enum.EStatus.DISPONIVEL);
            var azera = new Car(Enum.ECategory.Sedan, "Azera", Enum.EStatus.DISPONIVEL);
            var duster = new Car(Enum.ECategory.Suv, "Duster", Enum.EStatus.DISPONIVEL);

            var creta = new Car(Enum.ECategory.Suv, "Creta", Enum.EStatus.DISPONIVEL);
            var tcross = new Car(Enum.ECategory.Suv, "T-Cross", Enum.EStatus.DISPONIVEL);
            var hb20 = new Car(Enum.ECategory.Hatch, "HB20", Enum.EStatus.INDISPONIVEL);

            this.StockCar = new List<Car> { compass, kicks, azera, creta, tcross, duster, hb20 };

            this.CarRentModelList = new List<CarRentModel>
            {
                new CarRentModel(1, new Customer(1, "Patati"), compass, new DateTime(2022, 12, 5), new DateTime(2022, 12, 11)),
                new CarRentModel(2, new Customer(2, "Patata"), kicks, new DateTime(2022, 12, 10), new DateTime(2022, 12, 17)),
                new CarRentModel(3, new Customer(3, "Bozo"), azera, new DateTime(2022, 12, 14), new DateTime(2022, 12, 21)),
                new CarRentModel(4, new Customer(4, "It o Palhaço"), duster, new DateTime(2022, 1, 1), new DateTime(2042, 12, 31)),
            };
        }

        public List<Car> AmountVehiclesByCategory(ECategory category)
        {
            List<Car> carList = new();
            foreach (Car vehicle in this.StockCar)
            {
                if (vehicle.Category == category)
                {
                    carList.Add(vehicle);
                }
            }

            return carList;
        }

        public bool IsAvailable(Car car)
        {
            return this.IsAvailable(car, DateTime.Now, DateTime.Now);
        }

        public bool IsAvailable(Car car, DateTime begin, DateTime end)
        {
            foreach (CarRentModel rentItem in this.CarRentModelList)
            {
                if (rentItem.Car == car && begin < rentItem.End)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
