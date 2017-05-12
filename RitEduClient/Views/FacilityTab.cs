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
    public partial class FacilityTab : UserControl
    {
        public FacilityTab()
        {
            InitializeComponent();
            pdgvFacilities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pdgvFacilities.ReadOnly = true;
        }

        /**
         *Defer to dgv 
         */
        public int PageSize
        {
            set
            {
                pdgvFacilities.PageSize = value;
            }
        }

        /**
         *Defer to dgv 
         */
        public IPagedDataProvider PagedDataProvider
        {
            set
            {
                pdgvFacilities.PagedDataProvider = value;
            }
        }

        /**
         *Defer to dgv 
         */
        public string DataSetId
        {
            set
            {
                pdgvFacilities.DataSetId = value;
            }
        }

        /**
         *Defer to dgv 
         */
        public void SelectPage(int pageIndex)
        {
            pdgvFacilities.SelectPage(pageIndex);
        }
    }
}
