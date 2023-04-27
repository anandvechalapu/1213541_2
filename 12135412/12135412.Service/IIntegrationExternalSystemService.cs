namespace 12135412.Service
{
    using 12135412.DataAccess;
    using 12135412.DTO;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IIntegrationExternalSystemService
    {
        Task<IntegrationExternalSystemDTO> GetByIdAsync(int id);
        Task<IEnumerable<IntegrationExternalSystemDTO>> GetAllAsync();
        Task<IntegrationExternalSystemDTO> AddAsync(IntegrationExternalSystemDTO dto);
        Task<IntegrationExternalSystemDTO> UpdateAsync(IntegrationExternalSystemDTO dto);
        Task DeleteAsync(int id);
    }
}