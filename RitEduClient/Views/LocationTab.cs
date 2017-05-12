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
            pdgvLocations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pdgvLocations.ReadOnly = true;
        }

        
        /**
         *  Defer to pdgv
         */
        public int PageSize
        {
            set
            {
                pdgvLocations.PageSize = value;
            }
        }

        /**
         *  Defer to pdgv
         */
        public IPagedDataProvider PagedDataProvider
        {
            set
            {
                pdgvLocations.PagedDataProvider = value;
            }
        }

        /**
         *  Defer to pdgv
         */
        public string DataSetId
        {
            set
            {
                pdgvLocations.DataSetId = value;
            }
        }

        /**
         *  Defer to pdgv
         */
        public void SelectPage(int pageIndex)
        {
            pdgvLocations.SelectPage(pageIndex);
        }

    }
}
