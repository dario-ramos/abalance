﻿using System;
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

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<string> beers = new List<string>();
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
                Console.Write("Error");
            }
        }
    }



}
