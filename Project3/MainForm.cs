using RitEduClient.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RitEduClient
{
    public partial class MainForm : Form, IRitEduClientView
    {
        private int _currentResultsPageIndex;
        private RitEduClientPresenter _presenter;

        public MainForm()
        {
            InitializeComponent();
            SetResultsInfo("");
            _currentResultsPageIndex = 0;
        }

        public void ShowResults(int pageIndex, int pageSize, int resultsCount, DataTable pageContents)
        {
            _currentResultsPageIndex = pageIndex;
            dgvResults.DataSource = pageContents;
            foreach(DataGridViewColumn col in dgvResults.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
            dgvResults.Columns["Type"].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
            SetResultsInfo(GetPageDescription(pageIndex, pageSize, resultsCount));
            if(resultsCount > pageSize)
            {
                lnkFirstPage.Visible = (pageIndex != 1);
                lnkPreviousPage.Visible = (pageIndex != 1);
                SetPageLinks(pageIndex, pageSize, resultsCount);
                int pageCount = (int) Math.Ceiling((decimal) resultsCount / pageSize);
                lnkNextPage.Visible = ( pageIndex != pageCount );
                lnkLastPage.Visible = (pageIndex != pageCount);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbOrgType.SelectedIndex = -1;
            cmbOrgType.Text = "-- select any value --";
            cmbState.SelectedIndex = -1;
            cmbState.Text = "-- select any value --";
            cmbCity.SelectedIndex = -1;
            cmbCity.Items.Clear();
            cmbCity.Enabled = false;
            cmbCity.Text = "-- select any value --";
            txtOrgName.Text = "";
            txtCounty.Text = "";
            txtZip.Text = "";
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            dgvResults.DataSource = null;
            SetResultsInfo("Searching...");
            OrganizationType searchOrgType = (OrganizationType)cmbOrgType.SelectedItem;
            string searchOrgName = txtOrgName.Text;
            State searchState = (State)cmbState.SelectedItem;
            City searchCity = (City)cmbCity.SelectedItem;
            string searchCounty = txtCounty.Text;
            string searchZip = txtZip.Text;
            await _presenter.SearchOrganizations
            (
                searchOrgType, searchOrgName, searchState,
                searchCity, searchCounty, searchZip
            );
        }

        private string GetPageDescription(int pageIndex, int pageSize, int resultsCount)
        {
            return "Showing " + ((pageIndex - 1) * pageSize + 1).ToString() +
                   " to " + (pageIndex * pageSize).ToString() +
                   " of " + resultsCount + " entries";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _presenter = new RitEduClientPresenter(this);
            OrganizationTypeList orgTypes = _presenter.GetOrganizationTypes().Result;
            foreach(OrganizationType orgType in orgTypes.OrganizationTypes)
            {
                cmbOrgType.Items.Add(orgType);
            }
            StateList states = _presenter.GetStates().Result;
            foreach (State state in states.States)
            {
                cmbState.Items.Add(state);
            }
        }

        private void cmbOrgType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //OrganizationType selectedOrgType = (OrganizationType)cmbOrgType.SelectedItem;
            //TabList tabs = _presenter.GetTabs(selectedOrgType);
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbState.SelectedIndex < 0)
            {
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
            cmbCity.Text = "-- select any value --";
            cmbCity.Enabled = true;
        }

        private void lnkFirstPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowResults(1, _presenter.PageSize, _presenter.ResultsCount, _presenter.GetResultsPage(1));
        }

        private void lnkPageA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowResults(1, _presenter.PageSize, _presenter.ResultsCount, _presenter.GetResultsPage(1));
        }

        private void lnkPageB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowResults(2, _presenter.PageSize, _presenter.ResultsCount, _presenter.GetResultsPage(2));
        }

        private void lnkPageC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowResults(3, _presenter.PageSize, _presenter.ResultsCount, _presenter.GetResultsPage(3));
        }

        private void lnkPageD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowResults(4, _presenter.PageSize, _presenter.ResultsCount, _presenter.GetResultsPage(4));
        }

        private void lnkPageE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowResults(5, _presenter.PageSize, _presenter.ResultsCount, _presenter.GetResultsPage(5));
        }

        private void lnkPreviousPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowResults(_currentResultsPageIndex-1, _presenter.PageSize, _presenter.ResultsCount, _presenter.GetResultsPage(_currentResultsPageIndex - 1));
        }

        private void SetPageLinks(int pageIndex, int pageSize, int resultsCount)
        {
            lnkPageA.Enabled = lnkPageB.Enabled = lnkPageC.Enabled = lnkPageD.Enabled = lnkPageE.Enabled = true;
            lnkPageA.Visible = true;
            if (pageIndex == 1)
            {
                lnkPageA.Enabled = false;
            }
            lnkPageB.Visible = true;
            if (pageIndex == 2)
            {
                lnkPageB.Enabled = false;
            }
            lnkPageC.Visible = (resultsCount > 2 * pageSize);
            if (pageIndex == 3)
            {
                lnkPageC.Enabled = false;
            }
            lnkPageD.Visible = (resultsCount > 3 * pageSize);
            if (pageIndex == 4)
            {
                lnkPageD.Enabled = false;
            }
            lnkPageE.Visible = (resultsCount > 4 * pageSize);
            if (pageIndex == 5)
            {
                lnkPageE.Enabled = false;
            }
        }

        private void SetResultsInfo(string info)
        {
            lblResultsInfo.Text = info;
        }

    }

}
