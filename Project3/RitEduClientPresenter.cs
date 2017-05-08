using System;
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

        public async Task SearchOrganizations(OrganizationType searchOrgType, string searchOrgName, State searchState,
                                        City searchCity, string searchCounty, string searchZip)
        {
            await _model.SearchOrganizations
            (
                searchOrgType, searchOrgName, searchState,
                searchCity, searchCounty, searchZip
            );
            _view.ShowResults(1, _model.GetResultsPage(1));
        }
    }
}
