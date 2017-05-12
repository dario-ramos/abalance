using ComponentFactory.Krypton.Toolkit;
using RitEduClient.Entities;
using System;
using System.Windows.Forms;

namespace RitEduClient
{
    public partial class MainForm : KryptonForm, IOrganizationSearchView
    {
        private OrganizationSearchPresenter _presenter;

        public MainForm()
        {
            InitializeComponent();
            pdgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pdgvResults.DataSetId = Constants.ORGANIZATIONS_DATASET_ID;
            pdgvResults.DefaultColumnSortMode = DataGridViewColumnSortMode.Programmatic;
            pdgvResults.PageSize = 10;
            pdgvResults.ReadOnly = true;
            pdgvResults.SetPageDescription("");
        }

        /**
         * Render search results (sort byt type and hide id column)
         */
        public void ShowResults(int pageIndex)
        {
            pdgvResults.SelectPage(pageIndex);
            pdgvResults.SetColumnSortGlyphDirection("Type", SortOrder.Ascending);
            pdgvResults.SetColumnVisibility("Id", false);
        }

        /**
         * Mark UI status as "Searching...", read search criteria from form and initiate search
         */
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                pdgvResults.Clear();
                pdgvResults.SetPageDescription("Searching...");
                OrganizationType searchOrgType = null;
                if (cmbOrgType.SelectedIndex != 0)
                {
                    searchOrgType = (OrganizationType)cmbOrgType.SelectedItem;
                }
                string searchOrgName = txtOrgName.Text;
                State searchState = null;
                if (cmbState.SelectedIndex != 0)
                {
                    searchState = (State)cmbState.SelectedItem;
                }
                City searchCity = (City)cmbCity.SelectedItem;
                string searchCounty = txtCounty.Text;
                string searchZip = txtZip.Text;
                await _presenter.SearchOrganizations
                (
                    searchOrgType, searchOrgName, searchState,
                    searchCity, searchCounty, searchZip
                );
            }
            catch (AggregateException aex)
            {
                HandleAggregateException(aex);
            }
            catch (Exception ex)
            {
                HandleGeneralException(ex);
            }
        }

        /**
         * Set form search criteria to initial values
         */
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                cmbOrgType.SelectedIndex = 0;
                cmbState.SelectedIndex = 0;
                cmbCity.SelectedIndex = -1;
                cmbCity.Items.Clear();
                cmbCity.Enabled = false;
                cmbCity.Text = "       ---- cities ----";
                txtOrgName.Text = "";
                txtCounty.Text = "";
                txtZip.Text = "";
            }
            catch (AggregateException aex)
            {
                HandleAggregateException(aex);
            }
            catch (Exception ex)
            {
                HandleGeneralException(ex);
            }
        }

        /**
         * Initialize combo box values
         */
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                _presenter = new OrganizationSearchPresenter(this);
                pdgvResults.PagedDataProvider = _presenter;
                OrganizationTypeList orgTypes = _presenter.GetOrganizationTypes().Result;
                cmbOrgType.Items.Add("All Organization Types");
                foreach (OrganizationType orgType in orgTypes.OrganizationTypes)
                {
                    cmbOrgType.Items.Add(orgType);
                }
                cmbOrgType.SelectedIndex = 0;
                StateList states = _presenter.GetStates().Result;
                cmbState.Items.Add("All States");
                foreach (State state in states.States)
                {
                    cmbState.Items.Add(state);
                }
                cmbState.SelectedIndex = 0;
            }
            catch (AggregateException aex)
            {
                HandleAggregateException(aex);
            }
            catch (Exception ex)
            {
                HandleGeneralException(ex);
            }
        }

        /**
         * When a state is selected, load all its cities in the City combo box.
         * If "All states" selected, don't load anything.
         */
        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbState.SelectedIndex < 0)
                {
                    return;
                }
                if (cmbState.SelectedIndex == 0)
                {
                    cmbCity.Items.Clear();
                    cmbCity.Text = "       ---- cities ----";
                    return;
                }
                cmbCity.Enabled = false;
                State selectedState = (State)cmbState.SelectedItem;
                CityList stateCities = _presenter.GetCities(selectedState).Result;
                cmbCity.Items.Clear();
                foreach(City city in stateCities.Cities)
                {
                    cmbCity.Items.Add(city);
                }
                cmbCity.Text = "       ---- cities ----";
                cmbCity.Enabled = true;
            }
            catch (AggregateException aex)
            {
                HandleAggregateException(aex);
            }
            catch (Exception ex)
            {
                HandleGeneralException(ex);
            }
        }

        /**
         * Flatten the Aggregate exception for easy visualization, and render its message in the message log control
         */
        private void HandleAggregateException(AggregateException aex)
        {
            aex = aex.Flatten();
            rtbMessageLog.AppendText("ERROR: " + aex.InnerException.Message);
        }

        /**
         * Render error message in the message log control
         */
        private void HandleGeneralException(Exception ex)
        {
            rtbMessageLog.AppendText("ERROR: " + ex.Message + Environment.NewLine);
        }

        /**
         * When an organization name is clicked, read its id and open an instance of OrganizationInfoForm for it
         */
        private void pdgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                if (pdgvResults.GetColumnName(e.ColumnIndex) == "Name")
                {
                    int orgId = int.Parse(pdgvResults.GetCellValue(e.RowIndex, "Id").ToString());
                    var orgInfo = new OrganizationInfoForm(orgId);
                    orgInfo.Show();
                }
            }
            catch (AggregateException aex)
            {
                HandleAggregateException(aex);
            }
            catch (Exception ex)
            {
                HandleGeneralException(ex);
            }
        }

    }

}
