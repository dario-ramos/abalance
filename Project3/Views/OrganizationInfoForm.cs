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

        public void LoadGeneralTab()
        {
            TabPage generalTabPage = new TabPage("General");
            GeneralTab generalTab = new GeneralTab();
            generalTabPage.Controls.Add(generalTab);
            tabOrganization.TabPages.Add(generalTabPage);
        }

        private void OrganizationInfoForm_Load(object sender, EventArgs e)
        {
            _presenter = new OrganizationInfoPresenter(this);
            _presenter.LoadTabs(_orgId).Wait();
        }

        /*public void LoadGeneralTab(OrganizationGeneralInfo generalInfo)
        {
            lblGeneralInfoName.Text = generalInfo.Name;
            lblGeneralInfoDescription.Text = generalInfo.Description;
            lblGeneralInfoEmail.Text = generalInfo.Email;
            lblGeneralInfoWebsite.Text = generalInfo.Website;
            lblGeneralInfoNumMem.Text = generalInfo.NumMembers;
            lblGeneralInfoNumCalls.Text = generalInfo.NumCalls;
        }*/

        //private void ClearGeneralTab()
        //{
        //    lblGeneralInfoName.Text = "";
        //    lblGeneralInfoDescription.Text = "";
        //    lblGeneralInfoEmail.Text = "";
        //    lblGeneralInfoWebsite.Text = "";
        //    lblGeneralInfoNumMem.Text = "";
        //    lblGeneralInfoNumCalls.Text = "";
        //}
    }
}
