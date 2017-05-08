using System;
using System.Threading.Tasks;

namespace RitEduClient
{
    class RitEduClientPresenter
    {
        private RitEduClientModel _model;

        public RitEduClientPresenter()
        {
            _model = new RitEduClientModel(); 
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
