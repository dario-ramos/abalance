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
        public event Action EquipmentTabLoaded;
        public event Action FacilityTabLoaded;
        public event Action LocationTabLoaded;
        public event Action PeopleTabLoaded;
        public event Action PhysiciansTabLoaded;
        public event Action TrainingTabLoaded;
        public event Action TreatmentTabLoaded;
        public event Action<OrganizationGeneralInfo> GeneralTabLoaded;
        private AggregatedPeopleList _peopleList;
        private EquipmentList _equipmentList;
        private ESDService _esdService;
        private FacilityList _facilityList;
        private LocationList _locationList;
        private PhysicianList _physicianList;
        private TrainingList _trainingList;
        private TreatmentList _treatmentList;

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
            if (dataSetId == Constants.EQUIPMENT_DATASET_ID)
            {
                return _equipmentList.Equipments == null ? 0 : _equipmentList.Equipments.Length;
            }
            else if (dataSetId == Constants.FACILITY_DATASET_ID)
            {
                return _facilityList.Facilities == null ? 0 : _facilityList.Facilities.Length;
            }
            else if (dataSetId == Constants.LOCATION_DATASET_ID)
            {
                return _locationList.Locations == null? 0 : _locationList.Locations.Length;
            }
            else if (dataSetId == Constants.PEOPLE_DATASET_ID)
            {
                return _peopleList.People == null ? 0 : _peopleList.People.Length;
            }
            else if (dataSetId == Constants.PHYSICIANS_DATASET_ID)
            {
                return _physicianList.Physicians == null ? 0 : _physicianList.Physicians.Length;
            }
            else if(dataSetId == Constants.TRAINING_DATASET_ID)
            {
                return _trainingList.Trainings == null? 0 : _trainingList.Trainings.Length;
            }
            else if (dataSetId == Constants.TREATMENT_DATASET_ID)
            {
                return _treatmentList.Treatments == null? 0 : _treatmentList.Treatments.Length;
            }
            else
            {
                return 0;
            }
        }

        public DataTable GetResultsPage(string dataSetId, int pageIndex, int pageSize)
        {
            if (dataSetId == Constants.EQUIPMENT_DATASET_ID)
            {
                return GetEquipmentResultsPage(pageIndex, pageSize);
            }
            else if (dataSetId == Constants.FACILITY_DATASET_ID)
            {
                return GetFacilityResultsPage(pageIndex, pageSize);
            }
            else if (dataSetId == Constants.LOCATION_DATASET_ID)
            {
                return GetLocationsResultsPage(pageIndex, pageSize);
            }
            else if (dataSetId == Constants.PEOPLE_DATASET_ID)
            {
                return GetPeopleResultsPage(pageIndex, pageSize);
            }
            else if (dataSetId == Constants.PHYSICIANS_DATASET_ID)
            {
                return GetPhysiciansResultsPage(pageIndex, pageSize);
            }
            else if(dataSetId == Constants.TRAINING_DATASET_ID)
            {
                return GetTrainingsResultsPage(pageIndex, pageSize);
            }
            else if(dataSetId == Constants.TREATMENT_DATASET_ID)
            {
                return GetTreatmentsResultsPage(pageIndex, pageSize);
            }
            else
            {
                return new DataTable();
            }
        }

        public async Task LoadTabs(int orgId)
        {
            TabList tabs = await _esdService.GetTabs(orgId);
            foreach (Tab tab in tabs.Tabs)
            {
                if (tab.Name.ToUpper() == Enum.GetName(typeof(TabName), TabName.EQUIPMENT))
                {
                    _equipmentList = await _esdService.GetOrganizationEquipment(orgId);
                    EquipmentTabLoaded?.Invoke();
                }
                else if (tab.Name.ToUpper() == Enum.GetName(typeof(TabName), TabName.FACILITIES)){
                    _facilityList = await _esdService.GetOrganizationFacilities(orgId);
                    FacilityTabLoaded?.Invoke();
                }
                else if (tab.Name.ToUpper() == Enum.GetName(typeof(TabName), TabName.GENERAL))
                {
                    OrganizationGeneralInfo generalInfo = await _esdService.GetOrganizationGeneralInfo(orgId);
                    GeneralTabLoaded?.Invoke(generalInfo);
                }
                else if(tab.Name.ToUpper() == Enum.GetName(typeof(TabName), TabName.LOCATIONS))
                {
                    _locationList = await _esdService.GetOrganizationLocations(orgId);
                    LocationTabLoaded?.Invoke();
                }
                else if (tab.Name.ToUpper() == Enum.GetName(typeof(TabName), TabName.PEOPLE))
                {
                    _peopleList = await _esdService.GetOrganizationPeople(orgId);
                    PeopleTabLoaded?.Invoke();
                }
                else if (tab.Name.ToUpper() == Enum.GetName(typeof(TabName), TabName.PHYSICIANS))
                {
                    _physicianList = await _esdService.GetOrganizationPhysicians(orgId);
                    PhysiciansTabLoaded?.Invoke();
                }
                else if(tab.Name.ToUpper() == Enum.GetName(typeof(TabName), TabName.TRAINING))
                {
                    _trainingList = await _esdService.GetOrganizationTrainings(orgId);
                    TrainingTabLoaded?.Invoke();
                }else if(tab.Name.ToUpper() == Enum.GetName(typeof(TabName), TabName.TREATMENT))
                {
                    _treatmentList = await _esdService.GetOrganizationTreatments(orgId);
                    TreatmentTabLoaded ?.Invoke();
                }
            }
        }

        public DataTable GetEquipmentResultsPage(int pageIndex, int pageSize)
        {
            var pageContents = new DataTable();
            pageContents.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Type ID"), new DataColumn("Type")
            });
            if (_equipmentList.Equipments == null)
            {
                return pageContents;
            }
            for (int i = 0; i < pageSize && ((pageIndex - 1) * pageSize + i < _equipmentList.Equipments.Length); i++)
            {
                Equipment equipment = _equipmentList.Equipments[(pageIndex - 1) * pageSize + i];
                pageContents.Rows.Add
                (
                    equipment.TypeId, equipment.Type
                );
            }
            return pageContents;
        }

        public DataTable GetFacilityResultsPage(int pageIndex, int pageSize)
        {
            var pageContents = new DataTable();
            pageContents.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Type ID"), new DataColumn("Type"), new DataColumn("Quantity"),
                new DataColumn("Description")
            });
            if (_facilityList.Facilities == null)
            {
                return pageContents;
            }
            for (int i = 0; i < pageSize && ((pageIndex - 1) * pageSize + i < _facilityList.Facilities.Length); i++)
            {
                Facility facility = _facilityList.Facilities[(pageIndex - 1) * pageSize + i];
                pageContents.Rows.Add
                (
                    facility.TypeId, facility.Type, facility.Quantity,
                    facility.Description
                );
            }
            return pageContents;
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
            if(_locationList.Locations == null)
            {
                return pageContents;
            }
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

        public DataTable GetPeopleResultsPage(int pageIndex, int pageSize)
        {
            var pageContents = new DataTable();
            pageContents.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Address"), new DataColumn("Type"), new DataColumn("Site ID"),
                new DataColumn("Person ID"), new DataColumn("Name"), new DataColumn("Role"),
                new DataColumn("Contact Methods")
            });
            if (_peopleList.People == null)
            {
                return pageContents;
            }
            for (int i = 0; i < pageSize && ((pageIndex - 1) * pageSize + i < _peopleList.People.Length); i++)
            {
                Tuple<Person,Site> personAndSite = _peopleList.People[(pageIndex - 1) * pageSize + i];
                pageContents.Rows.Add
                (
                    personAndSite.Item2.Address, personAndSite.Item2.SiteType, personAndSite.Item2.SiteId,
                    personAndSite.Item1.PersonId, personAndSite.Item1.Honorific + " " + personAndSite.Item1.LName + ", " + personAndSite.Item1.FName, personAndSite.Item1.Role,
                    personAndSite.Item1.ContactMethods
                );
            }
            return pageContents;
        }

        public DataTable GetPhysiciansResultsPage(int pageIndex, int pageSize)
        {
            var pageContents = new DataTable();
            pageContents.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID"), new DataColumn("Name"), new DataColumn("Suffix"),
                new DataColumn("Phone"), new DataColumn("License")
            });
            if (_physicianList.Physicians == null)
            {
                return pageContents;
            }
            for (int i = 0; i < pageSize && ((pageIndex - 1) * pageSize + i < _physicianList.Physicians.Length); i++)
            {
                Physician physician = _physicianList.Physicians[(pageIndex - 1) * pageSize + i];
                pageContents.Rows.Add
                (
                    physician.PersonId, physician.LName + ", " + physician.FName + " " + physician.MName, physician.Suffix,
                    physician.Phone, physician.License
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
            if (_trainingList.Trainings == null)
            {
                return new DataTable();
            }
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

        public DataTable GetTreatmentsResultsPage(int pageIndex, int pageSize)
        {
            var pageContents = new DataTable();
            pageContents.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Type ID"), new DataColumn("Type"), new DataColumn("Abbreviation")
            });
            if (_treatmentList.Treatments == null)
            {
                return pageContents;
            }
            for (int i = 0; i < pageSize && ((pageIndex - 1) * pageSize + i < _treatmentList.Treatments.Length); i++)
            {
                Treatment treatment = _treatmentList.Treatments[(pageIndex - 1) * pageSize + i];
                pageContents.Rows.Add
                (
                    treatment.TypeId, treatment.Type, treatment.Abbreviation
                );
            }
            return pageContents;
        }

    }
}
