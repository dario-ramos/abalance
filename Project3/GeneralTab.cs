using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RitEduClient
{
    public partial class GeneralTab : UserControl
    {
        public GeneralTab()
        {
            InitializeComponent();
        }

        public string OrganizationDescription
        {
            set
            {
                lblGeneralInfoDescription.Text = value;
            }
        }

        public string OrganizationEmail
        {
            set
            {
                lblGeneralInfoEmail.Text = value;
            }
        }

        public string OrganizationName
        {
            set
            {
                lblGeneralInfoName.Text = value;
            }
        }

        public string OrganizationNumCalls
        {
            set
            {
                lblGeneralInfoNumCalls.Text = value;
            }
        }

        public string OrganizationNumMembers
        {
            set
            {
                lblGeneralInfoNumMem.Text = value;
            }
        }

        public string OrganizationWebsite
        {
            set
            {
                lblGeneralInfoWebsite.Text = value;
            }
        }
    }
}
