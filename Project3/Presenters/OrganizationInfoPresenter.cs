using RitEduClient.Entities;
using RitEduClient.Models;
using System.Threading.Tasks;
using System;
using RitEduClient.Views;

namespace RitEduClient
{
    public class OrganizationInfoPresenter
    {
        private IOrganizationInfoView _view;
        private OrganizationInfoModel _model;

        public OrganizationInfoPresenter(IOrganizationInfoView view)
        {
            _view = view;
            _model = ModelFactory.CreateOrganizationInfoModel();
            _model.GeneralTabLoaded += OnGeneralTabLoaded;
        }

        public async Task LoadTabs(int orgId)
        {
            await _model.LoadTabs(orgId);
        }

        private void OnGeneralTabLoaded(OrganizationGeneralInfo generalInfo)
        {
            _view.LoadGeneralTab();
        }

    }
}