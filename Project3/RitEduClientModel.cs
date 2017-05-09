using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using RitEduClient.Entities;

namespace RitEduClient
{
    internal class RitEduClientModel
    {
        private const string ESD_SERVICE_URL = @"http://simon.ist.rit.edu:8080/Services/resources/";
        private HttpClient _httpClient;
        private OrganizationList _lastSearchResults;
        private static int _pageSize = 10; //TODO Make configurable

        public int PageCount
        {
            get
            {
                return (int)Math.Ceiling((decimal)ResultsCount / PageSize);
            }
        }

        public int PageSize {
            get
            {
                return _pageSize;
            }
            private set
            {
                _pageSize = value;
            }
        }

        public int ResultsCount {
            get
            {
                return _lastSearchResults.Organizations.Length;
            }
        }

        public RitEduClientModel()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(ESD_SERVICE_URL);
        }

        public async Task<CityList> GetCities(State state)
        {
            return await GetEntityList<CityList>("ESD/Cities?state=" + state.Name);
        }

        public async Task<CountyList> GetCounties(State state)
        {
            return await GetEntityList<CountyList>("ESD/Counties?state=" + state.Name);
        }

        public async Task<OrganizationTypeList> GetOrganizationTypes()
        {
            return await GetEntityList<OrganizationTypeList>("ESD/OrgTypes");
        }

        public async Task<StateList> GetStates()
        {
            return await GetEntityList<StateList>("ESD/States");
        }

        public async Task SearchOrganizations(OrganizationType searchOrgType, string searchOrgName, State searchState,
                                              City searchCity, string searchCounty, string searchZip)
        {
            string queryString = "ESD/Organizations?" +
                "type=" + (searchOrgType != null? searchOrgType.Name : "" ) + "&" +
                "name=" + searchOrgName + "&" +
                "town=" + (searchCity != null? searchCity.Name : "") + "&" +
                "state=" + (searchState !=null? searchState.Name : "") + "&" +
                "zip=" + searchZip + "&" +
                "county=" + searchCounty;
            _lastSearchResults = await GetEntityList<OrganizationList>(queryString);
            Array.Sort(_lastSearchResults.Organizations, new OrganizationComparerByType());
        }

        public DataTable GetResultsPage(int pageIndex)
        {
            var pageContents = new DataTable();
            pageContents.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Type"), new DataColumn("Name"), new DataColumn("City"),
                new DataColumn("Zip"), new DataColumn("County"), new DataColumn("State"),
            });
            for(int i=0; i<_pageSize && ((pageIndex-1) * _pageSize + i < _lastSearchResults.Organizations.Length); i++)
            {
                Organization org = _lastSearchResults.Organizations[(pageIndex-1) * _pageSize + i];
                pageContents.Rows.Add
                (
                    org.Type, org.Name, org.City,
                    org.Zip, org.CountyName, org.State
                );
            }
            return pageContents;
        }

        private async Task<T> GetEntityList<T>(string url)
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
