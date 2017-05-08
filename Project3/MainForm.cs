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
            /*List<string> beers = new List<string>();
            string uri = "http://simon.ist.rit.edu:8080/BeerService/resources/Services/Beers";
            //"http://simon.ist.rit.edu:8080/Services/resources/application.wadl";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "GET";  // get method request on the above web request

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                //converts the response into a usable stream
                Stream stream = response.GetResponseStream();

                // reads the stream as an XML object
                XmlReader xmlReader = XmlReader.Create(stream);

                while (xmlReader.Read())
                {
                    if (xmlReader.Value != "") orgTypeComboBox.Items.Add(xmlReader.Value);
                }
                response.Close();
            }
            catch (Exception ex)
            {
                Console.Write("Error: " + ex);
            }*/
        }
    }



}
