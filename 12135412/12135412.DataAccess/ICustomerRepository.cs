using 12135412.DTO;
using System.Threading.Tasks;

namespace 12135412.Service
{
    public interface ICustomerRepository
    {
        Task<CustomerDTO> GetCustomerAsync(int id);
        Task<bool> CreateCustomerAsync(CustomerDTO customer);
        Task<bool> UpdateCustomerAsync(CustomerDTO customer);
        Task<bool> DeleteCustomerAsync(int id);
    }
}