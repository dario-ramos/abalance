using System;
using System.Data;
using System.Threading.Tasks;
using RitEduClient.Entities;

namespace RitEduClient
{
    class RitEduClientPresenter
    {
        private RitEduClientModel _model;
        private IRitEduClientView _view;

        public RitEduClientPresenter(IRitEduClientView view)
        {
            _model = new RitEduClientModel();
            _view = view;
        }

        public int PageCount
        {
            get
            {
                return _model.PageCount;
            }
        }

        public int PageSize {
            get
            {
                return _model.PageSize;
            }
        }

        public int ResultsCount
        {
            get
            {
                return _model.ResultsCount;
            }
        }

        public async Task<CityList> GetCities(State state)
        {
            return await _model.GetCities(state);
        }

        public async Task<CountyList> GetCounties(State state)
        {
            return await _model.GetCounties(state);
        }

        public async Task<OrganizationTypeList> GetOrganizationTypes()
        {
            return await _model.GetOrganizationTypes();
        }

        public async Task<StateList> GetStates()
        {
            return await _model.GetStates();
        }

        public async Task LoadTabs(int orgId)
        {
            _view.ClearTabs();
            TabList tabs = await _model.GetTabs(orgId);
            foreach(Tab tab in tabs.Tabs)
            {
                if(tab.Name.ToUpper() == Enum.GetName(typeof(TabName), TabName.GENERAL))
                {
                    OrganizationGeneralInfo generalInfo = await _model.GetOrganizationGeneralInfo(orgId);
                    _view.LoadGeneralTab(generalInfo);
                }
            }
        }

        public async Task SearchOrganizations(OrganizationType searchOrgType, string searchOrgName, State searchState,
                                        City searchCity, string searchCounty, string searchZip)
        {
            await _model.SearchOrganizations
            (
                searchOrgType, searchOrgName, searchState,
                searchCity, searchCounty, searchZip
            );
            _view.ShowResults(1, _model.PageSize, _model.ResultsCount, _model.GetResultsPage(1));
        }

        public DataTable GetResultsPage(int pageIndex)
        {
            return _model.GetResultsPage(pageIndex); ;
        }

    }
}
