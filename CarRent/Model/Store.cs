namespace CarRent.Model
{
    public class Store
    {
        public Store(string name, string cnpj, string cep)
        {
            this.Name = name;
            this.Cnpj = cnpj;
            this.Cep = cep;
        }

        public string Name { get; set; }
        public string Cnpj { get; set; }
        public string Cep { get; set; }
    }
}
