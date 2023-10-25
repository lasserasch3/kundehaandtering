using Abstractions.Interfaces.Models;

namespace Repositories.Repositories
{
    public class CustomerMockedRepository : Abstractions.Interfaces.Repositories.ICustomerRepository
    {

        private readonly List<Abstractions.Interfaces.Models.ICustomer> _customers;

        public CustomerMockedRepository() 
        {
            _customers = new List<ICustomer>();

            _customers.Add(new Models.Customer() {  FirstName = "Lasse 1", LastName = "Rasch", Email = "lara1@ucl.dk", Phonenumber = "20450697" , Id = 1});
            _customers.Add(new Models.Customer() { FirstName = "Lasse 2", LastName = "Rasch",  Email = "lara100@ucl.dk", Phonenumber = "30450697", Id = 2 });
            _customers.Add(new Models.Customer() { FirstName = "Lasse 3", LastName = "Rasch",  Email = "lara12@ucl.dk", Phonenumber = "70340697", Id = 3 });
            _customers.Add(new Models.Customer() { FirstName = "Lasse 4", LastName = "Rasch", Email = "lar22@ucl.dk", Phonenumber = "70450697", Id = 4 });
            _customers.Add(new Models.Customer() { FirstName = "Lasse 5", LastName = "Rasch", Email = "lara3@ucl.dk", Phonenumber = "70455697", Id = 5 });
            _customers.Add(new Models.Customer() { FirstName = "Lasse 6", LastName = "Rasch", Email = "lara4@ucl.dk", Phonenumber = "70457897", Id = 6});

        }
        public bool CreateCustomer(string firstname, string lastname, string phonenumber, string email)
        {
           Models.Customer customer = new Models.Customer();
            customer.FirstName = firstname;
            customer.LastName = lastname;
            customer.Email = email;
            customer.Phonenumber = phonenumber;
            customer.Id = _customers.Count + 1;
            _customers.Add(customer);
            return true;

        }

        public bool DeleteCustomer(int id)
        {
            var customerToDelete = _customers.FirstOrDefault(x => x.Id == id);
            if (customerToDelete != null)
            {
                _customers.Remove(customerToDelete);
                return true;
            }
            return false;
        }
        public List<ICustomer> GetAllCustomers()
        {
            return _customers;
        }

        public ICustomer GetCustomer(int id)
        {
            return _customers.FirstOrDefault(x => x.Id == id);
        }

        public bool UpdateCustomer(string firstname, string lastname, string phonenumber, string email, int id)
        {
            var customer = GetCustomer(id);
            if ( customer != null )
            {
                customer.FirstName = firstname;
                customer.LastName = lastname;
                customer.Phonenumber = phonenumber;
                customer.Email = email;
                return true;
            }

            return false;
        }
    }
}
