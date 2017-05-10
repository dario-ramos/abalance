using RitEduClient.Entities;
using RitEduClient.Models;
using System.Threading.Tasks;
using System;
using RitEduClient.Views;
using System.Data;

namespace RitEduClient
{
    public class OrganizationInfoPresenter : IPagedDataProvider
    {
        private IOrganizationInfoView _view;
        private OrganizationInfoModel _model;

        public OrganizationInfoPresenter(IOrganizationInfoView view)
        {
            _view = view;
            _model = ModelFactory.CreateOrganizationInfoModel();
            _model.GeneralTabLoaded += OnGeneralTabLoaded;
            _model.LocationTabLoaded += OnLocationTabLoaded;
        }

        public int RecordCount
        {
            get
            {
                return _model.RecordCount;
            }
        }

        public DataTable GetPage(int pageIndex, int pageSize)
        {
            return _model.GetResultsPage(pageIndex, pageSize);
        }

        public async Task LoadTabs(int orgId)
        {
            await _model.LoadTabs(orgId);
        }

        private void OnGeneralTabLoaded(OrganizationGeneralInfo generalInfo)
        {
            _view.LoadGeneralTab
            (
                generalInfo.Name, generalInfo.Description, generalInfo.Email,
                generalInfo.Website, generalInfo.NumMembers, generalInfo.NumCalls
            );
        }

        private void OnLocationTabLoaded()
        {
            _view.LoadLocationTab();
        }

    }
}