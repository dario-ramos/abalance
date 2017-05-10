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
        }

        public int PageSize
        {
            set
            {
                pdgvTraining.PageSize = value;
            }
        }

        public IPagedDataProvider PagedDataProvider
        {
            set
            {
                pdgvTraining.PagedDataProvider = value;
            }
        }

        public string DataSetId
        {
            set
            {
                pdgvTraining.DataSetId = value;
            }
        }

        public void SelectPage(int pageIndex)
        {
            pdgvTraining.SelectPage(pageIndex);
        }
    }
}
