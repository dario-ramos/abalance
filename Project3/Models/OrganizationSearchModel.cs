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
    public class OrganizationSearchModel
    {
        private ESDService _esdService;
        private OrganizationList _lastSearchResults;

        public OrganizationSearchModel(ESDService esdService)
        {
            _esdService = esdService;
        }

        public ESDService ESDService
        {
            get
            {
                return _esdService;
            }
        }

        public async Task SearchOrganizations(OrganizationType searchOrgType, string searchOrgName, State searchState,
                                      City searchCity, string searchCounty, string searchZip)
        {
            _lastSearchResults = await _esdService.SearchOrganizations
            (
                searchOrgType, searchOrgName, searchState,
                searchCity, searchCounty, searchZip
            );
            if (_lastSearchResults.Organizations != null && _lastSearchResults.Organizations.Length > 0)
            {
                Array.Sort(_lastSearchResults.Organizations, new OrganizationComparerByType());
            }
            else
            {
                _lastSearchResults.Organizations = new Organization[0];
            }
        }

        public DataTable GetResultsPage(string dataSetId, int pageIndex, int pageSize)
        {
            var pageContents = new DataTable();
            pageContents.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Type"), new DataColumn("Name"), new DataColumn("City"),
                new DataColumn("Zip"), new DataColumn("County"), new DataColumn("State"),
                new DataColumn("Id")
            });
            for(int i=0; i< pageSize && ((pageIndex-1) * pageSize + i < _lastSearchResults.Organizations.Length); i++)
            {
                Organization org = _lastSearchResults.Organizations[(pageIndex-1) * pageSize + i];
                pageContents.Rows.Add
                (
                    org.Type, org.Name, org.City,
                    org.Zip, org.CountyName, org.State,
                    org.Id
                );
            }
            return pageContents;
        }

        public int GetRecordCount(string dataSetId)
        {
            return _lastSearchResults.Organizations.Length;
        }

    }
}
