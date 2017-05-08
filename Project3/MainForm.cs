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
        private RitEduClientPresenter _presenter;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _presenter = new RitEduClientPresenter();
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
    }



}
