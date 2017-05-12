using ComponentFactory.Krypton.Toolkit;
using RitEduClient.Views;
using System;
using System.Windows.Forms;

namespace RitEduClient
{
    public partial class OrganizationInfoForm : KryptonForm, IOrganizationInfoView
    {
        private int _orgId;
        private OrganizationInfoPresenter _presenter;

        public OrganizationInfoForm(int orgId)
        {
            InitializeComponent();
            _orgId = orgId;
        }

        /**
         * Render equipment tab dynamically (add it to the TabControl)
         */
        public void LoadEquipmentTab()
        {
            TabPage equipmentTabPage = new TabPage("Equipment");
            EquipmentTab equipmentTab = new EquipmentTab();
            equipmentTab.DataSetId = Constants.EQUIPMENT_DATASET_ID;
            equipmentTab.PagedDataProvider = _presenter;
            equipmentTab.PageSize = 10;
            equipmentTab.SelectPage(1);
            equipmentTabPage.Controls.Add(equipmentTab);
            tabOrganization.TabPages.Add(equipmentTabPage);
        }

        /**
         * Render facility tab dynamically (add it to the TabControl)
         */
        public void LoadFacilityTab()
        {
            TabPage facilityTabPage = new TabPage("Facilities");
            FacilityTab facilityTab = new FacilityTab();
            facilityTab.DataSetId = Constants.FACILITY_DATASET_ID;
            facilityTab.PagedDataProvider = _presenter;
            facilityTab.PageSize = 10;
            facilityTab.SelectPage(1);
            facilityTabPage.Controls.Add(facilityTab);
            tabOrganization.TabPages.Add(facilityTabPage);
        }

        /**
         * Render general tab dynamically (add it to the TabControl)
         */
        public void LoadGeneralTab(string orgName, string orgDesc, string orgEmail,
                                   string orgWebsite, string orgNumMembers, string orgNumCalls)
        {
            TabPage generalTabPage = new TabPage("General");
            GeneralTab generalTab = new GeneralTab()
            {
                OrganizationDescription = orgDesc,
                OrganizationEmail = orgEmail,
                OrganizationName = orgName,
                OrganizationNumCalls = orgNumCalls,
                OrganizationNumMembers = orgNumMembers,
                OrganizationWebsite = orgWebsite
            };
            generalTabPage.Controls.Add(generalTab);
            tabOrganization.TabPages.Add(generalTabPage);
        }

        /**
         * Render location tab dynamically (add it to the TabControl)
         */
        public void LoadLocationTab()
        {
            TabPage locationTabPage = new TabPage("Location");
            LocationTab locationTab = new LocationTab();
            locationTab.DataSetId = Constants.LOCATION_DATASET_ID;
            locationTab.PagedDataProvider = _presenter;
            locationTab.PageSize = 10;
            locationTab.SelectPage(1);
            locationTabPage.Controls.Add(locationTab);
            tabOrganization.TabPages.Add(locationTabPage);
        }

        /**
         * Render people tab dynamically (add it to the TabControl)
         */
        public void LoadPeopleTab()
        {
            TabPage peopleTabPage = new TabPage("People");
            PeopleTab peopleTab = new PeopleTab();
            peopleTab.DataSetId = Constants.PEOPLE_DATASET_ID;
            peopleTab.PagedDataProvider = _presenter;
            peopleTab.PageSize = 10;
            peopleTab.SelectPage(1);
            peopleTabPage.Controls.Add(peopleTab);
            tabOrganization.TabPages.Add(peopleTabPage);
        }

        /**
         * Render physician tab dynamically (add it to the TabControl)
         */
        public void LoadPhysiciansTab()
        {
            TabPage physicianTabPage = new TabPage("Physicians");
            PhysicianTab physicianTab = new PhysicianTab();
            physicianTab.DataSetId = Constants.PHYSICIANS_DATASET_ID;
            physicianTab.PagedDataProvider = _presenter;
            physicianTab.PageSize = 10;
            physicianTab.SelectPage(1);
            physicianTabPage.Controls.Add(physicianTab);
            tabOrganization.TabPages.Add(physicianTabPage);
        }

        /**
         * Render training tab dynamically (add it to the TabControl)
         */
        public void LoadTrainingTab()
        {
            TabPage trainingTabPage = new TabPage("Training");
            TrainingTab trainingTab = new TrainingTab();
            trainingTab.DataSetId = Constants.TRAINING_DATASET_ID;
            trainingTab.PagedDataProvider = _presenter;
            trainingTab.PageSize = 10;
            trainingTab.SelectPage(1);
            trainingTabPage.Controls.Add(trainingTab);
            tabOrganization.TabPages.Add(trainingTabPage);
        }

        /**
         * Render treatment tab dynamically (add it to the TabControl)
         */
        public void LoadTreatmentTab()
        {
            TabPage treatmentTabPage = new TabPage("Treatment");
            TreatmentTab treatmentTab = new TreatmentTab();
            treatmentTab.DataSetId = Constants.TREATMENT_DATASET_ID;
            treatmentTab.PagedDataProvider = _presenter;
            treatmentTab.PageSize = 10;
            treatmentTab.SelectPage(1);
            treatmentTabPage.Controls.Add(treatmentTab);
            tabOrganization.TabPages.Add(treatmentTabPage);
        }

        /**
         * Load all tabs for the given organization id
         */
        private void OrganizationInfoForm_Load(object sender, EventArgs e)
        {
            _presenter = new OrganizationInfoPresenter(this);
            _presenter.LoadTabs(_orgId).Wait();
        }

    }
}
