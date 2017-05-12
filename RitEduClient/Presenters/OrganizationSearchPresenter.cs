using System;
using System.Data;
using System.Threading.Tasks;
using RitEduClient.Entities;
using RitEduClient.Models;

namespace RitEduClient
{
    public class OrganizationSearchPresenter : IPagedDataProvider
    {
        private OrganizationSearchModel _model;
        private IOrganizationSearchView _view;

        public OrganizationSearchPresenter(IOrganizationSearchView view)
        {
            _model = ModelFactory.CreateOrganizationSearchModel();
            _view = view;
        }

        public int GetRecordCount(string dataSetId)
        {
            return _model.GetRecordCount(dataSetId);
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
            _view.ShowResults(1);
        }

        public DataTable GetPage(string dataSetId, int pageIndex, int pageSize)
        {
            return _model.GetResultsPage(dataSetId, pageIndex, pageSize);
        }
    }
}
