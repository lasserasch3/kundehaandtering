using Abstractions.Interfaces.Models;

namespace Abstractions.Interfaces.Services
{
    public interface IAddresseService
    {
        List<Models.IAddress> GetAllAddresses();
        Models.IAddress GetAddress(ICustomer customer);
    }
}