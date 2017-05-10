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
        public event Action TrainingTabLoaded;
        public event Action<OrganizationGeneralInfo> GeneralTabLoaded;
        private ESDService _esdService;
        private LocationList _locationList;
        private TrainingList _trainingList;

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

        public int GetRecordCount(string dataSetId)
        {
            if(dataSetId == Constants.LOCATION_DATASET_ID)
            {
                return _locationList.Locations.Length;
            }else if(dataSetId == Constants.TRAINING_DATASET_ID)
            {
                return _trainingList.Trainings.Length;
            }else
            {
                return 0;
            }
        }

        public DataTable GetResultsPage(string dataSetId, int pageIndex, int pageSize)
        {
            if(dataSetId == Constants.LOCATION_DATASET_ID)
            {
                return GetLocationsResultsPage(pageIndex, pageSize);
            }else if(dataSetId == Constants.TRAINING_DATASET_ID)
            {
                return GetTrainingsResultsPage(pageIndex, pageSize);
            }else
            {
                return new DataTable();
            }
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
                }else if(tab.Name.ToUpper() == Enum.GetName(typeof(TabName), TabName.TRAINING))
                {
                    _trainingList = await _esdService.GetOrganizationTrainings(orgId);
                    TrainingTabLoaded?.Invoke();
                }
            }
        }

        public DataTable GetLocationsResultsPage(int pageIndex, int pageSize)
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

        public DataTable GetTrainingsResultsPage(int pageIndex, int pageSize)
        {
            var pageContents = new DataTable();
            pageContents.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Type ID"), new DataColumn("Type"), new DataColumn("Abbreviation")
            });
            for (int i = 0; i < pageSize && ((pageIndex - 1) * pageSize + i < _trainingList.Trainings.Length); i++)
            {
                Training training = _trainingList.Trainings[(pageIndex - 1) * pageSize + i];
                pageContents.Rows.Add
                (
                    training.TypeId, training.Type, training.Abbreviation
                );
            }
            return pageContents;
        }

    }
}
