namespace CarRent.Model
{
    public class Customer
    {
        public int Code { get; set; }
        public string Name { get; set; }

        public Customer(int code, string name)
        {
            this.Code = code;
            this.Name = name;
        }
    }
}
