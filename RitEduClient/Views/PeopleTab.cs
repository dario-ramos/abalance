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
    public partial class PeopleTab : UserControl
    {
        public PeopleTab()
        {
            InitializeComponent();
        }

        public int PageSize
        {
            set
            {
                pdgvPeople.PageSize = value;
            }
        }

        public IPagedDataProvider PagedDataProvider
        {
            set
            {
                pdgvPeople.PagedDataProvider = value;
            }
        }

        public string DataSetId
        {
            set
            {
                pdgvPeople.DataSetId = value;
            }
        }

        public void SelectPage(int pageIndex)
        {
            pdgvPeople.SelectPage(pageIndex);
        }
    }
}
