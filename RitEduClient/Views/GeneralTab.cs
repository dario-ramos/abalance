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

        /**
         * Load data in UI
         */
        public string OrganizationDescription
        {
            set
            {
                lblGeneralInfoDescription.Text = value;
            }
        }

        /**
         * Load data in UI
         */
        public string OrganizationEmail
        {
            set
            {
                lblGeneralInfoEmail.Text = value;
            }
        }

        /**
         * Load data in UI
         */
        public string OrganizationName
        {
            set
            {
                lblGeneralInfoName.Text = value;
            }
        }

        /**
         * Load data in UI
         */
        public string OrganizationNumCalls
        {
            set
            {
                lblGeneralInfoNumCalls.Text = value;
            }
        }

        /**
         * Load data in UI
         */
        public string OrganizationNumMembers
        {
            set
            {
                lblGeneralInfoNumMem.Text = value;
            }
        }

        /**
         * Load data in UI
         */
        public string OrganizationWebsite
        {
            set
            {
                lblGeneralInfoWebsite.Text = value;
            }
        }
    }
}
