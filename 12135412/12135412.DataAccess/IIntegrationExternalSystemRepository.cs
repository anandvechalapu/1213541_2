using 12135412.DTO;
namespace 12135412.Service 
{
    public interface IIntegrationExternalSystemRepository
    {
        Task<IntegrationExternalSystemModel> GetByIdAsync(int id);
        Task<IEnumerable<IntegrationExternalSystemModel>> GetAllAsync();
        Task<IntegrationExternalSystemModel> AddAsync(IntegrationExternalSystemModel model);
        Task<IntegrationExternalSystemModel> UpdateAsync(IntegrationExternalSystemModel model);
        Task DeleteAsync(int id);
    }
}