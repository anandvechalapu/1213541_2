using System.Threading.Tasks;

namespace 12135412
{
    public class CustomerRepository : ICustomerRepository
    {
        public async Task<CustomerDTO> GetCustomerAsync(int id)
        {
            // Get customer from external system
            // Return customer as CustomerDTO
            return await Task.FromResult(new CustomerDTO());
        }

        public async Task<bool> CreateCustomerAsync(CustomerDTO customer)
        {
            // Create customer in external system
            // Return true if customer is created successfully
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateCustomerAsync(CustomerDTO customer)
        {
            // Update customer in external system
            // Return true if customer is updated successfully
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteCustomerAsync(int id)
        {
            // Delete customer in external system
            // Return true if customer is deleted successfully
            return await Task.FromResult(true);
        }
    }
}