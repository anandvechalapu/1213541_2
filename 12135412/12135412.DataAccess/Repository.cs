namespace 12135412
{
    public class Repository
    {
        private INTEGRATION_WITH_EXTERNAL_SYSTEM.ExternalSystem _externalSystem;

        public Repository(INTEGRATION_WITH_EXTERNAL_SYSTEM.ExternalSystem externalSystem)
        {
            _externalSystem = externalSystem;
        }

        public int Create(INTEGRATION_WITH_EXTERNAL_SYSTEM.ExternalSystem externalSystem)
        {
            //TODO: Add code to create item in repository
            return 0;
        }

        public INTEGRATION_WITH_EXTERNAL_SYSTEM.ExternalSystem Read(int id)
        {
            //TODO: Add code to read item from repository
            return _externalSystem;
        }

        public int Update(INTEGRATION_WITH_EXTERNAL_SYSTEM.ExternalSystem externalSystem)
        {
            //TODO: Add code to update item in repository
            return 0;
        }

        public int Delete(int id)
        {
            //TODO: Add code to delete item in repository
            return 0;
        }
    }
}