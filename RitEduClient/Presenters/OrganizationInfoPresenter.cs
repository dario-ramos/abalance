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
            _model.EquipmentTabLoaded += OnEquipmentTabLoaded;
            _model.FacilityTabLoaded += OnFacilityTabLoaded;
            _model.GeneralTabLoaded += OnGeneralTabLoaded;
            _model.LocationTabLoaded += OnLocationTabLoaded;
            _model.PeopleTabLoaded += OnPeopleTabLoaded;
            _model.PhysiciansTabLoaded += OnPhysiciansTabLoaded;
            _model.TrainingTabLoaded += OnTrainingTabLoaded;
            _model.TreatmentTabLoaded += OnTreatmentTabLoaded;
        }

        /**
         * Defer to the model
         */ 
        public async Task LoadTabs(int orgId)
        {
            await _model.LoadTabs(orgId);
        }

        /**
         * Defer to the model
         */
        public DataTable GetPage(string dataSetId, int pageIndex, int pageSize)
        {
            return _model.GetResultsPage(dataSetId, pageIndex, pageSize);
        }

        /**
         * Defer to the model
         */
        public int GetRecordCount(string dataSetId)
        {
            return _model.GetRecordCount(dataSetId);
        }

        /**
         * The model told us the equipment data is loaded, so tell the view to render it
         */
        private void OnEquipmentTabLoaded()
        {
            _view.LoadEquipmentTab();
        }

        /**
         * The model told us the facility data is loaded, so tell the view to render it
         */
        private void OnFacilityTabLoaded()
        {
            _view.LoadFacilityTab();
        }

        /**
         * The model told us the general tab data is loaded, so tell the view to render it.
         * Pass the fields instead of the entity to reduce coupling.
         */
        private void OnGeneralTabLoaded(OrganizationGeneralInfo generalInfo)
        {
            _view.LoadGeneralTab
            (
                generalInfo.Name, generalInfo.Description, generalInfo.Email,
                generalInfo.Website, generalInfo.NumMembers, generalInfo.NumCalls
            );
        }

        /**
         * The model told us the location data is loaded, so tell the view to render it
         */
        private void OnLocationTabLoaded()
        {
            _view.LoadLocationTab();
        }

        /**
         * The model told us the people data is loaded, so tell the view to render it
         */
        private void OnPeopleTabLoaded()
        {
            _view.LoadPeopleTab();
        }

        /**
         * The model told us the physician data is loaded, so tell the view to render it
         */
        private void OnPhysiciansTabLoaded()
        {
            _view.LoadPhysiciansTab();
        }

        /**
         * The model told us the training data is loaded, so tell the view to render it
         */
        private void OnTrainingTabLoaded()
        {
            _view.LoadTrainingTab();
        }

        /**
         * The model told us the treatment data is loaded, so tell the view to render it
         */
        private void OnTreatmentTabLoaded()
        {
            _view.LoadTreatmentTab();
        }

    }
}