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
    public partial class LocationTab : UserControl
    {
        public LocationTab()
        {
            InitializeComponent();
        }

        public int PageSize
        {
            set
            {
                pdgvLocations.PageSize = value;
            }
        }

        public IPagedDataProvider PagedDataProvider
        {
            set
            {
                pdgvLocations.PagedDataProvider = value;
            }
        }

        public string DataSetId
        {
            set
            {
                pdgvLocations.DataSetId = value;
            }
        }

        public void SelectPage(int pageIndex)
        {
            pdgvLocations.SelectPage(pageIndex);
        }

    }
}
