namespace 12135412
{
    public class RepositoryService
    {
        private 12135412.DataAccess.Repository _repository;
        private INTEGRATION_WITH_EXTERNAL_SYSTEM.ExternalSystem _externalSystem;

        public RepositoryService(12135412.DataAccess.Repository repository, INTEGRATION_WITH_EXTERNAL_SYSTEM.ExternalSystem externalSystem)
        {
            _repository = repository;
            _externalSystem = externalSystem;
        }

        public 12135412.DTO.Result Create(INTEGRATION_WITH_EXTERNAL_SYSTEM.ExternalSystem externalSystem)
        {
            //TODO: Add code to create item in repository
            return new 12135412.DTO.Result();
        }

        public INTEGRATION_WITH_EXTERNAL_SYSTEM.ExternalSystem Read(int id)
        {
            //TODO: Add code to read item from repository
            return _externalSystem;
        }

        public 12135412.DTO.Result Update(INTEGRATION_WITH_EXTERNAL_SYSTEM.ExternalSystem externalSystem)
        {
            //TODO: Add code to update item in repository
            return new 12135412.DTO.Result();
        }

        public 12135412.DTO.Result Delete(int id)
        {
            //TODO: Add code to delete item in repository
            return new 12135412.DTO.Result();
        }
    }
}