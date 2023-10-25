using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Interfaces.Base
{
   public interface ICustomerBaseService
    {
        List<Models.ICustomer> GetAllCustomers();
        Models.ICustomer GetCustomer(int id);
        bool CreateCustomer(string firstname, string lastname, string phonenumber, string email);
        bool UpdateCustomer(string firstname, string lastname, string phonenumber, string email, int id);
        bool DeleteCustomer(int id);
    }
}
