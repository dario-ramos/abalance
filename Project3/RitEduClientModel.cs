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
    class RitEduClientModel
    {
        private const string ESD_SERVICE_URL = @"http://simon.ist.rit.edu:8080/Services/resources/";
        private HttpClient _httpClient;

        public RitEduClientModel()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(ESD_SERVICE_URL);
        }

        public async Task<OrganizationTypeList> GetOrganizationTypes()
        {
            return await GetEntityList<OrganizationTypeList>("ESD/OrgTypes");
        }

        public async Task<StateList> GetStates()
        {
            return await GetEntityList<StateList>("ESD/States");
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
