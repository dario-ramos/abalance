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
    public partial class EquipmentTab : UserControl
    {
        public EquipmentTab()
        {
            InitializeComponent();
            pdgvEquipments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pdgvEquipments.ReadOnly = true;
        }

        /**
         *Defer to pdgv 
         */
        public int PageSize
        {
            set
            {
                pdgvEquipments.PageSize = value;
            }
        }

        /**
         *Defer to pdgv 
         */
        public IPagedDataProvider PagedDataProvider
        {
            set
            {
                pdgvEquipments.PagedDataProvider = value;
            }
        }

        /**
         *Defer to pdgv 
         */
        public string DataSetId
        {
            set
            {
                pdgvEquipments.DataSetId = value;
            }
        }

        /**
         *Defer to pdgv 
         */
        public void SelectPage(int pageIndex)
        {
            pdgvEquipments.SelectPage(pageIndex);
        }
    }
}
