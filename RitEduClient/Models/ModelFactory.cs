namespace RitEduClient.Models
{
    public class ModelFactory
    {
        private static ESDService _esdService;

        static ModelFactory()
        {
            _esdService = new ESDService();
        }

        /**
         * Create an OrganizationInfoModel abstracting the client from the ESDService dependency
         */
        public static OrganizationInfoModel CreateOrganizationInfoModel()
        {
            return new OrganizationInfoModel(_esdService);
        }

        /**
         * Create an OrganizationSearchModel abstracting the client from the ESDService dependency
         */
        public static OrganizationSearchModel CreateOrganizationSearchModel()
        {
            return new OrganizationSearchModel(_esdService);
        }
    }
}
