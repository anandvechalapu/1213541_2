namespace 12135412
{
    using INTEGRATION_WITH_EXTERNAL_SYSTEM_12135412;
    using 12135412.DTO;
    public class IntegrationExternalSystemRepository : IIntegrationExternalSystemRepository
    {
        private readonly DbContext _dbContext;

        public IntegrationExternalSystemRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IntegrationExternalSystemModel> GetByIdAsync(int id)
        {
            return await _dbContext.IntegrationExternalSystem.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<IntegrationExternalSystemModel>> GetAllAsync()
        {
            return await _dbContext.IntegrationExternalSystem.ToListAsync();
        }

        public async Task<IntegrationExternalSystemModel> AddAsync(IntegrationExternalSystemModel model)
        {
            _dbContext.IntegrationExternalSystem.Add(model);
            await _dbContext.SaveChangesAsync();
            return model;
        }

        public async Task<IntegrationExternalSystemModel> UpdateAsync(IntegrationExternalSystemModel model)
        {
            _dbContext.IntegrationExternalSystem.Update(model);
            await _dbContext.SaveChangesAsync();
            return model;
        }

        public async Task DeleteAsync(int id)
        {
            var model = await GetByIdAsync(id);
            _dbContext.IntegrationExternalSystem.Remove(model);
            await _dbContext.SaveChangesAsync();
        }
    }
}