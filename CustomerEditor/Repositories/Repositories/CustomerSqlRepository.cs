using Abstractions.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class CustomerSqlRepository : Abstractions.Interfaces.Repositories.ICustomerRepository
    {
        public List<ICustomer> GetAllCustomers()
        {
            using (Database.CustomerEditorDbContext context = new Database.CustomerEditorDbContext())
            {
                return context.Customers.ToList<ICustomer>();
            }
        }

        public ICustomer GetCustomer(int id)
        {
            using (Database.CustomerEditorDbContext context = new Database.CustomerEditorDbContext())
            {
                return context.Customers.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public bool CreateCustomer(string firstname, string lastname, string phonenumber, string email)
        {
            var customerToSave = new Models.Customer();
            customerToSave.FirstName = firstname;
            customerToSave.LastName = lastname;
            customerToSave.Email = email;
            customerToSave.Phonenumber = phonenumber;

            using (Database.CustomerEditorDbContext context = new Database.CustomerEditorDbContext())
            {
                context.Customers.Add(customerToSave);
                context.SaveChanges();
            }
            return true;
        }

        public bool UpdateCustomer(string firstname, string lastname, string phonenumber, string email, int id)
        {
            using (Database.CustomerEditorDbContext context = new Database.CustomerEditorDbContext())
            {
                var customerToUpdate = context.Customers.FirstOrDefault(x => x.Id == id);

                if (customerToUpdate != null)
                {
                    customerToUpdate.FirstName = firstname;
                    customerToUpdate.LastName = lastname;
                    customerToUpdate.Email = email;
                    customerToUpdate.Phonenumber = phonenumber;

                    context.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool DeleteCustomer(int id)
        {
            using (Database.CustomerEditorDbContext context = new Database.CustomerEditorDbContext())
            {
                var customerToUpdate = context.Customers.FirstOrDefault(x => x.Id == id);

                if (customerToUpdate != null)
                {
                    context.Customers.Remove(customerToUpdate);
                    context.SaveChanges();
                    return true;
                }
            }
            return false;
        }
    }
}
