using CarRent.Enum;
using CarRent.Interfaces;

namespace CarRent.Model
{
    public class Car : ICar
    {
        public ECategory Category { get; set; }
        public string Name { get; set; }
        public EStatus Status { get; set; }

        public Car(ECategory category, string name, EStatus status)
        {
            this.Category = category;
            this.Name = name;
            this.Status = status;
        }
    }
}
