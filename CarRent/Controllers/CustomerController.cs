using CarRent.Model;
using Microsoft.AspNetCore.Mvc;

namespace CarRent.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private List<Customer> customers = new List<Customer>();

        [HttpPost]
        public void AddCustomer([FromBody] Customer customer)
        {
            customers.Add(customer);
        }

        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return customers;
        }
    }
}
