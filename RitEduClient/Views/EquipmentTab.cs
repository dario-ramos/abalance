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

        public int PageSize
        {
            set
            {
                pdgvEquipments.PageSize = value;
            }
        }

        public IPagedDataProvider PagedDataProvider
        {
            set
            {
                pdgvEquipments.PagedDataProvider = value;
            }
        }

        public string DataSetId
        {
            set
            {
                pdgvEquipments.DataSetId = value;
            }
        }

        public void SelectPage(int pageIndex)
        {
            pdgvEquipments.SelectPage(pageIndex);
        }
    }
}
