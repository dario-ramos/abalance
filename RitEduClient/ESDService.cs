using RitEduClient.Entities;
using RitEduClient.Models;
using RitEduClient.Models.Entities;
using System;
using System.Collections.Generic;
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

        /**
         * Read entities from web service
         */
        public async Task<CityList> GetCities(State state)
        {
            return await GetEntity<CityList>("ESD/Cities?state=" + state.Name);
        }

        /**
         * Read entities from web service
         */
        public async Task<CountyList> GetCounties(State state)
        {
            return await GetEntity<CountyList>("ESD/Counties?state=" + state.Name);
        }

        /**
         * Read entities from web service
         */
        public async Task<EquipmentList> GetOrganizationEquipment(int orgId)
        {
            return await GetEntity<EquipmentList>("ESD/" + orgId + "/Equipment");
        }

        /**
         * Read entities from web service
         */
        public async Task<FacilityList> GetOrganizationFacilities(int orgId)
        {
            return await GetEntity<FacilityList>("ESD/" + orgId + "/Facilities");
        }

        /**
         * Read entities from web service
         */
        public async Task<LocationList> GetOrganizationLocations(int orgId)
        {
            return await GetEntity<LocationList>("ESD/" + orgId + "/Locations");
        }

        /**
         * Read entities from web service
         */
        public async Task<OrganizationGeneralInfo> GetOrganizationGeneralInfo(int orgId)
        {
            return await GetEntity<OrganizationGeneralInfo>("ESD/" + orgId + "/General");
        }

        /**
         * This one is different because it requires some conversion. In the XML data returned by ESD, 
         * people are separated by site. That makes pagination hard, so we iterate over the sites and
         * put all their people inside a collection (AggregatedPeopleList).
         */
        public async Task<AggregatedPeopleList> GetOrganizationPeople(int orgId)
        {
            PeopleList people = await GetEntity<PeopleList>("ESD/" + orgId + "/People");
            var aggregatedPeople = new AggregatedPeopleList();
            aggregatedPeople.People = new Tuple<Person, Site>[0];
            if (people.Sites == null)
            {
                return aggregatedPeople;
            }
            var allPeople = new List<Tuple<Person, Site>>();
            for (int i=0; i < people.Sites.Length; i++)
            {
                if(people.Sites[i].People == null)
                {
                    continue;
                }
                for(int j=0; j < people.Sites[i].People.Length; j++)
                {
                    allPeople.Add(new Tuple<Person, Site>(people.Sites[i].People[j], people.Sites[i]));
                }
            }
            aggregatedPeople.People = allPeople.ToArray();
            return aggregatedPeople;
        }

        /**
         * Read entities from web service
         */
        public async Task<PhysicianList> GetOrganizationPhysicians(int orgId)
        {
            return await GetEntity<PhysicianList>("ESD/" + orgId + "/Physicians");
        }

        /**
         * Read entities from web service
         */
        public async Task<TrainingList> GetOrganizationTrainings(int orgId)
        {
            return await GetEntity<TrainingList>("ESD/" + orgId + "/Training");
        }

        /**
         * Read entities from web service
         */
        public async Task<TreatmentList> GetOrganizationTreatments(int orgId)
        {
            return await GetEntity<TreatmentList>("ESD/" + orgId + "/Treatments");
        }

        /**
         * Read entities from web service
         */
        public async Task<OrganizationTypeList> GetOrganizationTypes()
        {
            return await GetEntity<OrganizationTypeList>("ESD/OrgTypes");
        }

        /**
         * Read entities from web service
         */
        public async Task<StateList> GetStates()
        {
            return await GetEntity<StateList>("ESD/States");
        }

        /**
         * Read entities from web service
         */
        public async Task<TabList> GetTabs(int orgId)
        {
            return await GetEntity<TabList>("ESD/Application/Tabs?orgId=" + orgId);
        }

        /**
         * Search entities from web service
         */
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

        /**
         * All entities are read the same way, only their type changes... So we use a generic method
         */
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
