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

        /**
         *Defer to pdgv 
         */
        public int PageSize
        {
            set
            {
                pdgvTreatments.PageSize = value;
            }
        }

        /**
         *Defer to pdgv 
         */
        public IPagedDataProvider PagedDataProvider
        {
            set
            {
                pdgvTreatments.PagedDataProvider = value;
            }
        }

        /**
         *Defer to pdgv 
         */
        public string DataSetId
        {
            set
            {
                pdgvTreatments.DataSetId = value;
            }
        }

        /**
         *Defer to pdgv 
         */
        public void SelectPage(int pageIndex)
        {
            pdgvTreatments.SelectPage(pageIndex);
        }
    }
}
