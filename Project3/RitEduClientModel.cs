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
            var response = _httpClient.GetAsync("ESD/OrgTypes").Result;
            string responseContent = await response.Content.ReadAsStringAsync();
            var readBuffer = Encoding.UTF8.GetBytes(responseContent);
            using (var stream = new MemoryStream(readBuffer))
            {
                XmlReader reader = XmlReader.Create(stream);
                var serializer = new XmlSerializer(typeof(OrganizationTypeList));
                return (OrganizationTypeList)serializer.Deserialize(reader);
            }
        }
    }
}
