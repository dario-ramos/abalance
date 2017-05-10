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
        private static int _pageSize = 10; //TODO Make configurable

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

        public DataTable GetResultsPage(int pageIndex)
        {
            var pageContents = new DataTable();
            pageContents.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Type"), new DataColumn("Name"), new DataColumn("City"),
                new DataColumn("Zip"), new DataColumn("County"), new DataColumn("State"),
                new DataColumn("Id")
            });
            for(int i=0; i<_pageSize && ((pageIndex-1) * _pageSize + i < _lastSearchResults.Organizations.Length); i++)
            {
                Organization org = _lastSearchResults.Organizations[(pageIndex-1) * _pageSize + i];
                pageContents.Rows.Add
                (
                    org.Type, org.Name, org.City,
                    org.Zip, org.CountyName, org.State,
                    org.Id
                );
            }
            return pageContents;
        }

    }
}
