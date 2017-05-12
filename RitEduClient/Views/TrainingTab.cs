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
    public partial class TrainingTab : UserControl
    {
        public TrainingTab()
        {
            InitializeComponent();
            pdgvTraining.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pdgvTraining.ReadOnly = true;
        }

        /**
         *Defer to pdgv 
         */
        public int PageSize
        {
            set
            {
                pdgvTraining.PageSize = value;
            }
        }

        /**
         *Defer to pdgv 
         */
        public IPagedDataProvider PagedDataProvider
        {
            set
            {
                pdgvTraining.PagedDataProvider = value;
            }
        }

        /**
         *Defer to pdgv 
         */
        public string DataSetId
        {
            set
            {
                pdgvTraining.DataSetId = value;
            }
        }

        /**
         *Defer to pdgv 
         */
        public void SelectPage(int pageIndex)
        {
            pdgvTraining.SelectPage(pageIndex);
        }
    }
}
