using RitEduClient.Models;
using RitEduClient.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RitEduClient
{
    public partial class OrganizationInfoForm : Form, IOrganizationInfoView
    {
        private int _orgId;
        private OrganizationInfoPresenter _presenter;

        public OrganizationInfoForm(int orgId)
        {
            InitializeComponent();
            _orgId = orgId;
        }

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

        private void OrganizationInfoForm_Load(object sender, EventArgs e)
        {
            _presenter = new OrganizationInfoPresenter(this);
            _presenter.LoadTabs(_orgId).Wait();
        }

    }
}
