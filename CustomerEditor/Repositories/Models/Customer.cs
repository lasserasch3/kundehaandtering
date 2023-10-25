using Abstractions.Interfaces.Models;

namespace Repositories.Models
{
    public class Customer : ICustomer
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phonenumber { get; set; }
        public string? Email { get; set; }
        
    }
}
