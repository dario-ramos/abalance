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

        private void OrganizationInfoForm_Load(object sender, EventArgs e)
        {
            _presenter = new OrganizationInfoPresenter(this);
            _presenter.LoadTabs(_orgId).Wait();
        }

    }
}
