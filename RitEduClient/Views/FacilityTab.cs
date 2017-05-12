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

        public int PageSize
        {
            set
            {
                pdgvFacilities.PageSize = value;
            }
        }

        public IPagedDataProvider PagedDataProvider
        {
            set
            {
                pdgvFacilities.PagedDataProvider = value;
            }
        }

        public string DataSetId
        {
            set
            {
                pdgvFacilities.DataSetId = value;
            }
        }

        public void SelectPage(int pageIndex)
        {
            pdgvFacilities.SelectPage(pageIndex);
        }
    }
}
