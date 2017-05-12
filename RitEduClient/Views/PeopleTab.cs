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
            pdgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pdgvPeople.ReadOnly = true;
        }

        /**
         * Defer to pdgv
         */ 
        public int PageSize
        {
            set
            {
                pdgvPeople.PageSize = value;
            }
        }


        /**
         *Defer to pdgv 
         */
        public IPagedDataProvider PagedDataProvider
        {
            set
            {
                pdgvPeople.PagedDataProvider = value;
            }
        }

        /**
         *Defer to pdgv 
         */
        public string DataSetId
        {
            set
            {
                pdgvPeople.DataSetId = value;
            }
        }

        /**
         *Defer to pdgv 
         */
        public void SelectPage(int pageIndex)
        {
            pdgvPeople.SelectPage(pageIndex);
        }
    }
}
