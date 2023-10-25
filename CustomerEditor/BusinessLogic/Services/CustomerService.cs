using Abstractions.Interfaces.Models;

namespace BusinessLogic.Services
{
    public class CustomerService : Abstractions.Interfaces.Services.ICustomerService
    {
        private readonly Abstractions.Interfaces.Repositories.ICustomerRepository _customerRepository;

        public CustomerService(Abstractions.Interfaces.Repositories.ICustomerRepository customerRepository) 
        {
            _customerRepository = customerRepository;        
        }


        public bool CreateCustomer(string firstname, string lastname, string phonenumber, string email)
        {
           return _customerRepository.CreateCustomer(firstname, lastname, phonenumber, email);
        }

        public bool DeleteCustomer(int id)
        {
            return _customerRepository.DeleteCustomer(id);
        }

        public List<ICustomer> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }

        public ICustomer GetCustomer(int id)
        {
            return _customerRepository.GetCustomer(id);
        }

        public bool UpdateCustomer(string firstname, string lastname, string phonenumber, string email, int id)
        {
          return _customerRepository.UpdateCustomer(firstname, lastname, phonenumber, email, id);
        }
    }
}
