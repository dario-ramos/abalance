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
            _model.TrainingTabLoaded += OnTrainingTabLoaded;
            _model.TreatmentTabLoaded += OnTreatmentTabLoaded;
        }

        public async Task LoadTabs(int orgId)
        {
            await _model.LoadTabs(orgId);
        }

        public DataTable GetPage(string dataSetId, int pageIndex, int pageSize)
        {
            return _model.GetResultsPage(dataSetId, pageIndex, pageSize);
        }

        public int GetRecordCount(string dataSetId)
        {
            return _model.GetRecordCount(dataSetId);
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

        private void OnTrainingTabLoaded()
        {
            _view.LoadTrainingTab();
        }

        private void OnTreatmentTabLoaded()
        {
            _view.LoadTreatmentTab();
        }

    }
}