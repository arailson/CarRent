using CarRent.Enum;

namespace CarRent.Model
{
    public class Car
    {
        public ECategory CategoryName { get; set; }
        public string Name { get; set; }
        public EStatus Status { get; set; }

        public Car(ECategory _category, string _name, EStatus _status)
        {
            CategoryName = _category;
            Name = _name;
            Status = _status;
        }
    }
}
