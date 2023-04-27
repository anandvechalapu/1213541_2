namespace 12135412
{
    using 12135412.DataAccess;
    using 12135412.DTO;
    public class IntegrationExternalSystemService : IIntegrationExternalSystemService
    {
        private readonly IntegrationExternalSystemRepository _integrationExternalSystemRepository;
        
        public IntegrationExternalSystemService(IntegrationExternalSystemRepository integrationExternalSystemRepository)
        {
            _integrationExternalSystemRepository = integrationExternalSystemRepository;
        }

        public async Task<IntegrationExternalSystemDTO> GetByIdAsync(int id)
        {
            var model = await _integrationExternalSystemRepository.GetByIdAsync(id);
            return new IntegrationExternalSystemDTO
            {
                Id = model.Id,
                Name = model.Name
            };
        }

        public async Task<IEnumerable<IntegrationExternalSystemDTO>> GetAllAsync()
        {
            var models = await _integrationExternalSystemRepository.GetAllAsync();
            return models.Select(x => new IntegrationExternalSystemDTO
            {
                Id = x.Id,
                Name = x.Name
            });
        }

        public async Task<IntegrationExternalSystemDTO> AddAsync(IntegrationExternalSystemDTO dto)
        {
            var model = new IntegrationExternalSystemModel
            {
                Name = dto.Name
            };

            model = await _integrationExternalSystemRepository.AddAsync(model);
            return new IntegrationExternalSystemDTO
            {
                Id = model.Id,
                Name = model.Name
            };
        }

        public async Task<IntegrationExternalSystemDTO> UpdateAsync(IntegrationExternalSystemDTO dto)
        {
            var model = await _integrationExternalSystemRepository.GetByIdAsync(dto.Id);
            model.Name = dto.Name;

            model = await _integrationExternalSystemRepository.UpdateAsync(model);
            return new IntegrationExternalSystemDTO
            {
                Id = model.Id,
                Name = model.Name
            };
        }

        public async Task DeleteAsync(int id)
        {
            await _integrationExternalSystemRepository.DeleteAsync(id);
        }
    }
}