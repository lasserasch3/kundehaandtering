using Abstractions.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    internal class testrepo : Abstractions.Interfaces.Repositories.ICustomerRepository
    {
        public List<ICustomer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public ICustomer GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public bool CreateCustomer(string firstname, string lastname, string phonenumber, string email)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(string firstname, string lastname, string phonenumber, string email, int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
