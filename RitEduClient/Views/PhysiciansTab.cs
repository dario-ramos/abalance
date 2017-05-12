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
        }

        public int PageSize
        {
            set
            {
                pdgvPhysicians.PageSize = value;
            }
        }

        public IPagedDataProvider PagedDataProvider
        {
            set
            {
                pdgvPhysicians.PagedDataProvider = value;
            }
        }

        public string DataSetId
        {
            set
            {
                pdgvPhysicians.DataSetId = value;
            }
        }

        public void SelectPage(int pageIndex)
        {
            pdgvPhysicians.SelectPage(pageIndex);
        }
    }
}
