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

        /**
         * Defer to the model
         */ 
        public int GetRecordCount(string dataSetId)
        {
            return _model.GetRecordCount(dataSetId);
        }

        /**
         * Defer to the model
         */
        public async Task<CityList> GetCities(State state)
        {
            return await _model.ESDService.GetCities(state);
        }

        /**
         * Defer to the model
         */
        public async Task<CountyList> GetCounties(State state)
        {
            return await _model.ESDService.GetCounties(state);
        }

        /**
         * Defer to the model
         */
        public async Task<OrganizationTypeList> GetOrganizationTypes()
        {
            return await _model.ESDService.GetOrganizationTypes();
        }

        /**
         * Defer to the model
         */
        public async Task<StateList> GetStates()
        {
            return await _model.ESDService.GetStates();
        }

        /**
         * Get the search results from the model, and tell the view to render them when ready
         */
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

        /**
         * Defer to the model
         */
        public DataTable GetPage(string dataSetId, int pageIndex, int pageSize)
        {
            return _model.GetResultsPage(dataSetId, pageIndex, pageSize);
        }
    }
}
