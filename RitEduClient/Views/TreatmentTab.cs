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
    public partial class TreatmentTab : UserControl
    {
        public TreatmentTab()
        {
            InitializeComponent();
            pdgvTreatments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pdgvTreatments.ReadOnly = true;
        }

        public int PageSize
        {
            set
            {
                pdgvTreatments.PageSize = value;
            }
        }

        public IPagedDataProvider PagedDataProvider
        {
            set
            {
                pdgvTreatments.PagedDataProvider = value;
            }
        }

        public string DataSetId
        {
            set
            {
                pdgvTreatments.DataSetId = value;
            }
        }

        public void SelectPage(int pageIndex)
        {
            pdgvTreatments.SelectPage(pageIndex);
        }
    }
}
