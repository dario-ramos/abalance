using System;
using System.Data;
using System.Threading.Tasks;
using RitEduClient.Entities;
using RitEduClient.Models;

namespace RitEduClient
{
    class OrganizationSearchPresenter
    {
        private OrganizationSearchModel _model;
        private IOrganizationSearchView _view;

        public OrganizationSearchPresenter(IOrganizationSearchView view)
        {
            _model = ModelFactory.CreateOrganizationSearchModel();
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
            return await _model.ESDService.GetCities(state);
        }

        public async Task<CountyList> GetCounties(State state)
        {
            return await _model.ESDService.GetCounties(state);
        }

        public async Task<OrganizationTypeList> GetOrganizationTypes()
        {
            return await _model.ESDService.GetOrganizationTypes();
        }

        public async Task<StateList> GetStates()
        {
            return await _model.ESDService.GetStates();
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
