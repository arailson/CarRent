namespace CarRent.Model
{
    public class CarRentModel
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Car Car { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }

        public CarRentModel(int id, Customer customer, Car car, DateTime begin, DateTime end)
        {
            this.Id = id;
            this.Customer = customer;
            this.Car = car;
            this.Begin = begin;
            this.End = end;
        }
    }
}
