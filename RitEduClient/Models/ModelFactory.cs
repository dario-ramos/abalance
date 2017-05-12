namespace RitEduClient.Models
{
    public class ModelFactory
    {
        private static ESDService _esdService;

        static ModelFactory()
        {
            _esdService = new ESDService();
        }

        public static OrganizationInfoModel CreateOrganizationInfoModel()
        {
            return new OrganizationInfoModel(_esdService);
        }

        public static OrganizationSearchModel CreateOrganizationSearchModel()
        {
            return new OrganizationSearchModel(_esdService);
        }
    }
}
