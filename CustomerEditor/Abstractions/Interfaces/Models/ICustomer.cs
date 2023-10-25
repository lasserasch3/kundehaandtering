namespace Abstractions.Interfaces.Models
{
    public interface ICustomer
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Phonenumber { get; set; }
        string Email { get; set; }
    }
}
