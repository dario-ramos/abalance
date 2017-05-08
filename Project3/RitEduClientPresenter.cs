using System;
using System.Threading.Tasks;
using RitEduClient.Entities;

namespace RitEduClient
{
    class RitEduClientPresenter
    {
        private RitEduClientModel _model;

        public RitEduClientPresenter()
        {
            _model = new RitEduClientModel(); 
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

    }
}
