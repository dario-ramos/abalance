using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RitEduClient.Views
{
    public partial class PhysicianTab : UserControl
    {
        public PhysicianTab()
        {
            InitializeComponent();
            pdgvPhysicians.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pdgvPhysicians.ReadOnly = true;
        }

        /**
         *Defer to pdgv 
         */
        public int PageSize
        {
            set
            {
                pdgvPhysicians.PageSize = value;
            }
        }

        /**
         *Defer to pdgv 
         */
        public IPagedDataProvider PagedDataProvider
        {
            set
            {
                pdgvPhysicians.PagedDataProvider = value;
            }
        }

        /**
         *Defer to pdgv 
         */
        public string DataSetId
        {
            set
            {
                pdgvPhysicians.DataSetId = value;
            }
        }

        /**
         *Defer to pdgv 
         */
        public void SelectPage(int pageIndex)
        {
            pdgvPhysicians.SelectPage(pageIndex);
        }
    }
}
