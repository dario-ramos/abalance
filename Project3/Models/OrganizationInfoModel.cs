using RitEduClient.Entities;
using RitEduClient.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RitEduClient.Models
{
    public class OrganizationInfoModel
    {
        public event Action LocationTabLoaded;
        public event Action<OrganizationGeneralInfo> GeneralTabLoaded;
        private ESDService _esdService;
        private LocationList _locationList;

        public OrganizationInfoModel(ESDService esdService)
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

        public int RecordCount
        {
            get
            {
                return _locationList.Locations.Length;
            }
        }

        public DataTable GetResultsPage(int pageIndex, int pageSize)
        {
            var pageContents = new DataTable();
            pageContents.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Type"), new DataColumn("Address: 1,2"), new DataColumn("City"),
                new DataColumn("State"), new DataColumn("Zip"), new DataColumn("Phone"),
                new DataColumn("TtyPhone"), new DataColumn("Fax"), new DataColumn("Latitude/Longitude"),
                new DataColumn("County")
            });
            for (int i = 0; i < pageSize && ((pageIndex - 1) * pageSize + i < _locationList.Locations.Length); i++)
            {
                Location location = _locationList.Locations[(pageIndex - 1) * pageSize + i];
                pageContents.Rows.Add
                (
                    location.Type, location.Address1 + ", " + location.Address2, location.City,
                    location.State, location.Zip, location.Phone,
                    location.TtyPhone, location.Fax, location.Latitude + "/" + location.Longitude,
                    location.CountyName
                );
            }
            return pageContents;
        }

        public async Task LoadTabs(int orgId)
        {
            TabList tabs = await _esdService.GetTabs(orgId);
            foreach (Tab tab in tabs.Tabs)
            {
                if (tab.Name.ToUpper() == Enum.GetName(typeof(TabName), TabName.GENERAL))
                {
                    OrganizationGeneralInfo generalInfo = await _esdService.GetOrganizationGeneralInfo(orgId);
                    GeneralTabLoaded?.Invoke(generalInfo);
                }
                else if(tab.Name.ToUpper() == Enum.GetName(typeof(TabName), TabName.LOCATIONS))
                {
                    _locationList = await _esdService.GetOrganizationLocations(orgId);
                    LocationTabLoaded?.Invoke();
                }
            }
        }

    }
}
