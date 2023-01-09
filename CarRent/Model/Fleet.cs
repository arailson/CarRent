using CarRent.Enum;
using CarRent.Interfaces;

namespace CarRent.Model
{
    public class Fleet
    {
        public List<ICar> StockCar { get; set; }
        public List<CarRentModel> CarRentModelList { get; set; }
        public Fleet()
        {
            ICar compass = new Car(ECategory.Suv, "Compass", EStatus.DISPONIVEL);
            ICar kicks = new Car(ECategory.Suv, "Kicks", EStatus.DISPONIVEL);
            ICar azera = new Car(ECategory.Sedan, "Azera", EStatus.DISPONIVEL);
            ICar fluence = new Car(ECategory.Sedan, "Fluence", EStatus.DISPONIVEL);
            ICar duster = new Car(ECategory.Suv, "Duster", EStatus.DISPONIVEL);
            ICar creta = new Car(ECategory.Suv, "Creta", EStatus.DISPONIVEL);
            ICar tcross = new Car(ECategory.Suv, "T-Cross", EStatus.INDISPONIVEL);
            ICar hb20 = new Car(ECategory.Hatch, "HB20", EStatus.INDISPONIVEL);
            ICar mustang = new Car(ECategory.Foguete, "Mustang", EStatus.DISPONIVEL);


            this.StockCar = new List<ICar> { compass, kicks, azera, fluence, creta, tcross, duster, hb20, mustang };

            this.CarRentModelList = new List<CarRentModel>
            {
                new CarRentModel(1, new Customer(1, "Patati"), compass, new DateTime(2022, 12, 5), new DateTime(2022, 12, 11)),
                new CarRentModel(2, new Customer(2, "Patata"), kicks, new DateTime(2022, 12, 10), new DateTime(2022, 12, 17)),
                new CarRentModel(3, new Customer(3, "Bozo"), azera, new DateTime(2022, 12, 14), new DateTime(2022, 12, 21)),
                new CarRentModel(4, new Customer(4, "It o Palhaço"), duster, new DateTime(2022, 1, 1), new DateTime(2042, 12, 31)),
                new CarRentModel(5, new Customer(5, "Palhaço do Mc'Donald"), fluence, new DateTime(2022, 1, 10), new DateTime(2022, 1, 14)),
                new CarRentModel(6, new Customer(6, "Arailson"), mustang, new DateTime(2022, 12, 25), new DateTime(2023, 1, 1)),
            };
        }

        public List<ICar> AmountVehiclesByCategory(ECategory category)
        {
            List<ICar> carList = new();
            foreach (ICar vehicle in this.StockCar)
            {
                if (vehicle.Category == category)
                {
                    carList.Add(vehicle);
                }
            }

            return carList;
        }

        public bool IsAvailable(ICar car)
        {
            return this.IsAvailable(car, DateTime.Now, DateTime.Now);
        }

        public bool IsAvailable(ICar car, DateTime begin, DateTime end)
        {
            foreach (CarRentModel rentItem in this.CarRentModelList)
            {
                if (car.Status == EStatus.INDISPONIVEL)
                {
                    return false;
                }
                if (rentItem.Car == car && begin < rentItem.End)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
