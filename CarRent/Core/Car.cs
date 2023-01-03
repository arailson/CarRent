using CarRent.Enum;

namespace CarRent.Core
{
    public class Car
    {
        public Category Category { get; set; }
        public string Name { get; set; }
        public EStatus Status { get; set; }

        public Car(Category _category, string _name, EStatus _status)
        {
            Category = _category;
            Name = _name;
            Status = _status;
        }
    }
}
