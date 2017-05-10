using RitEduClient.Entities;
using RitEduClient.Models.Entities;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace RitEduClient
{
    public class ESDService
    {
        private const string ESD_SERVICE_URL = @"http://simon.ist.rit.edu:8080/Services/resources/";
        private HttpClient _httpClient;

        public ESDService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(ESD_SERVICE_URL);
        }

        public async Task<CityList> GetCities(State state)
        {
            return await GetEntity<CityList>("ESD/Cities?state=" + state.Name);
        }

        public async Task<CountyList> GetCounties(State state)
        {
            return await GetEntity<CountyList>("ESD/Counties?state=" + state.Name);
        }

        public async Task<LocationList> GetOrganizationLocations(int orgId)
        {
            return await GetEntity<LocationList>("ESD/" + orgId + "/Locations");
        }

        public async Task<OrganizationGeneralInfo> GetOrganizationGeneralInfo(int orgId)
        {
            return await GetEntity<OrganizationGeneralInfo>("ESD/" + orgId + "/General");
        }

        public async Task<TrainingList> GetOrganizationTrainings(int orgId)
        {
            return await GetEntity<TrainingList>("ESD/" + orgId + "/Training");
        }

        public async Task<TreatmentList> GetOrganizationTreatments(int orgId)
        {
            return await GetEntity<TreatmentList>("ESD/" + orgId + "/Treatments");
        }

        public async Task<OrganizationTypeList> GetOrganizationTypes()
        {
            return await GetEntity<OrganizationTypeList>("ESD/OrgTypes");
        }

        public async Task<StateList> GetStates()
        {
            return await GetEntity<StateList>("ESD/States");
        }

        public async Task<TabList> GetTabs(int orgId)
        {
            return await GetEntity<TabList>("ESD/Application/Tabs?orgId=" + orgId);
        }

        public async Task<OrganizationList> SearchOrganizations(OrganizationType searchOrgType, string searchOrgName, State searchState,
                                              City searchCity, string searchCounty, string searchZip)
        {
            string queryString = "ESD/Organizations?" +
                "type=" + (searchOrgType != null ? searchOrgType.Name : "") + "&" +
                "name=" + searchOrgName + "&" +
                "town=" + (searchCity != null ? searchCity.Name : "") + "&" +
                "state=" + (searchState != null ? searchState.Name : "") + "&" +
                "zip=" + searchZip + "&" +
                "county=" + searchCounty;
            return await GetEntity<OrganizationList>(queryString);
        }

        private async Task<T> GetEntity<T>(string url)
        {
            var response = _httpClient.GetAsync(url).Result;
            string responseContent = await response.Content.ReadAsStringAsync();
            var readBuffer = Encoding.UTF8.GetBytes(responseContent);
            using (var stream = new MemoryStream(readBuffer))
            {
                XmlReader reader = XmlReader.Create(stream);
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}
