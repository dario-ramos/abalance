using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RitEduClient
{
    public partial class PagedDataGridView : UserControl
    {
        public event Action<object, DataGridViewCellEventArgs> CellContentClick;

        private int _currentPageIndex;

        public PagedDataGridView()
        {
            InitializeComponent();
        }

        /**
         * Defer to dgv
         */
        public bool ReadOnly
        {
            set
            {
                dgv.ReadOnly = value;
            }
        }

        /**
         * Defer to dgv
         */
        public DataGridViewAutoSizeColumnsMode AutoSizeColumnsMode {
            set
            {
                dgv.AutoSizeColumnsMode = value;
            }
        }

        /**
         * This property must be set in order for the dgv to be able to read its data
         */
        public IPagedDataProvider PagedDataProvider { private get; set; }

        /**
         * Defer to dgv
         */
        public DataGridViewColumnSortMode DefaultColumnSortMode { get; set; }

        /**
         * Defines page size
         */
        public int PageSize{ get; set; }

        /**
         * This property must be set in order to find the dataset from which to read and tell
         * it apart from other potential datasets inside the same provider
         */
        public string DataSetId { get; set; }

        /**
         * Defer to dgv
         */
        public object GetCellValue(int rowIndex, string columnName)
        {
            return dgv.Rows[rowIndex].Cells[columnName].Value;
        }

        /**
         * Defer to dgv
         */
        public string GetColumnName(int columnIndex)
        {
            return dgv.Columns[columnIndex].Name;
        }

        /**
         * Defer to dgv
         */
        public void Clear()
        {
            dgv.DataSource = null;
        }

        /**
         * Read the page from the provider, set the sort mode, and update all of the pagination links
         * If page 1 is selected, don't show "First" and "Previous" links.
         * If last page selected, don't show "Next" and "Last" links.
         * If a page has no data, don't set a link to it.
         */
        public void SelectPage(int pageIndex)
        {
            _currentPageIndex = pageIndex;
            dgv.DataSource = PagedDataProvider.GetPage(DataSetId, pageIndex, PageSize);
            foreach(DataGridViewColumn col in dgv.Columns)
            {
                col.SortMode = DefaultColumnSortMode;
            }
            SetPageDescription(GetPageDescription(pageIndex, PagedDataProvider.GetRecordCount(DataSetId)));
            int pageCount = GetPageCount(PagedDataProvider.GetRecordCount(DataSetId));
            if(PagedDataProvider.GetRecordCount(DataSetId) > PageSize)
            {
                lnkFirstPage.Visible = (pageIndex != 1);
                lnkPreviousPage.Visible = (pageIndex != 1);
                SetPageLinks(pageIndex);
                lnkNextPage.Visible = (pageIndex != pageCount);
                lnkLastPage.Visible = (pageIndex != pageCount);
            }else
            {
                lnkFirstPage.Visible = lnkLastPage.Visible = false;
                lnkPreviousPage.Visible = lnkNextPage.Visible = false;
                lnkPageA.Visible = lnkPageB.Visible = lnkPageC.Visible = lnkPageD.Visible = lnkPageE.Visible = false;
            }
        }

        /**
         * Defer to dgv 
         */
        public void SetColumnSortGlyphDirection(string colName, SortOrder direction)
        {
            dgv.Columns[colName].HeaderCell.SortGlyphDirection = direction;
        }

        /**
         * Defer to dgv 
         */
        public void SetColumnVisibility(string colName, bool visible)
        {
            dgv.Columns[colName].Visible = visible;
        }

        /**
         * Set description text. It can define the record numbers shown, or whatever the user wants
         */
        public void SetPageDescription(string info)
        {
            lblPageDescription.Text = info;
        }

        /**
         * The page count is calculated from the record count and page size
         */
        private int GetPageCount(int recordCount)
        {
            return (int)Math.Ceiling((decimal)recordCount / PageSize);
        }

        /**
         * Use page size and record count to describe the record numbers shown
         */
        private string GetPageDescription(int pageIndex, int recordCount)
        {
            return "Showing " + (Math.Min((pageIndex - 1) * PageSize + 1, recordCount)).ToString() +
                   " to " + (Math.Min(pageIndex * PageSize, recordCount)).ToString() +
                   " of " + recordCount + " entries";
        }

        /**
         * Fire CellContentClick event so that client can capture it without seeing the dgv
         */
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CellContentClick?.Invoke(sender, e);
        }

        /**
         * Go to first page
         */
        private void lnkFirstPage_LinkClicked(object sender, EventArgs e)
        {
            SelectPage(1);
        }

        /**
         * Go to last page
         */
        private void lnkLastPage_LinkClicked(object sender, EventArgs e)
        {
            int pageCount = GetPageCount(PagedDataProvider.GetRecordCount(DataSetId));
            SelectPage(pageCount);
        }

        /**
         * Go to next page
         */
        private void lnkNextPage_LinkClicked(object sender, EventArgs e)
        {
            SelectPage(_currentPageIndex + 1);
        }

        /**
         * Go to n-2 page
         */
        private void lnkPageA_LinkClicked(object sender, EventArgs e)
        {
            int pageIndex = int.Parse(lnkPageA.Text);
            SelectPage(pageIndex);
        }

        /**
         * Go to n-1 page
         */
        private void lnkPageB_LinkClicked(object sender, EventArgs e)
        {
            int pageIndex = int.Parse(lnkPageB.Text);
            SelectPage(pageIndex);
        }

        /**
         * Go to n page
         */
        private void lnkPageC_LinkClicked(object sender, EventArgs e)
        {
            int pageIndex = int.Parse(lnkPageC.Text);
            SelectPage(pageIndex);
        }

        /**
         * Go to n+1 page
         */
        private void lnkPageD_LinkClicked(object sender, EventArgs e)
        {
            int pageIndex = int.Parse(lnkPageD.Text);
            SelectPage(pageIndex);
        }

        /**
         * Go to n+2 page
         */
        private void lnkPageE_LinkClicked(object sender, EventArgs e)
        {
            int pageIndex = int.Parse(lnkPageE.Text);
            SelectPage(pageIndex);
        }

        /**
         * Go to previous page
         */
        private void lnkPreviousPage_LinkClicked(object sender, EventArgs e)
        {
            SelectPage(_currentPageIndex - 1);
        }

        /**
         * Treat edge cases (1, 2, before last, last) separately, and the rest generically
         */
        private void SetPageLinks(int pageIndex)
        {
            lnkPageA.Enabled = lnkPageB.Enabled = lnkPageC.Enabled = lnkPageD.Enabled = lnkPageE.Enabled = true;
            lnkPageA.Visible = true;
            lnkPageB.Visible = true;
            lnkPageC.Visible = (PagedDataProvider.GetRecordCount(DataSetId) > 2 * PageSize);
            lnkPageD.Visible = (PagedDataProvider.GetRecordCount(DataSetId) > 3 * PageSize);
            lnkPageE.Visible = (PagedDataProvider.GetRecordCount(DataSetId) > 4 * PageSize);
            int pageCount = GetPageCount(PagedDataProvider.GetRecordCount(DataSetId));
            //Edge cases: 1, 2, last one and before last one
            if (pageIndex == 1)
            {
                SetPageLinksForPage1();
            }
            else if (pageIndex == 2)
            {
                SetPageLinksForPage2();
            }
            else if (pageIndex == pageCount)
            {
                SetPageLinksForLastPage(pageCount);
            }
            else if (pageIndex == pageCount - 1)
            {
                SetPageLinksForPageBeforeLast(pageCount);
            }
            else //General case: center page selected
            {
                SetPageLinksForInnerPage(pageIndex);
            }
        }

        /**
         * Disable link for current page 
         */
        private void SetPageLinksForPage1()
        {
            lnkPageA.Text = "1";
            lnkPageA.Enabled = false;
            lnkPageB.Text = "2";
            lnkPageC.Text = "3";
            lnkPageD.Text = "4";
            lnkPageE.Text = "5";
        }

        /**
         * Disable link for current page 
         */
        private void SetPageLinksForPage2()
        {
            lnkPageA.Text = "1";
            lnkPageB.Text = "2";
            lnkPageB.Enabled = false;
            lnkPageC.Text = "3";
            lnkPageD.Text = "4";
            lnkPageE.Text = "5";
        }

        /**
         * Disable link for current page 
         */
        private void SetPageLinksForInnerPage(int pageIndex)
        {
            lnkPageA.Text = (pageIndex - 2).ToString();
            lnkPageB.Text = (pageIndex - 1).ToString();
            lnkPageC.Text = pageIndex.ToString();
            lnkPageC.Enabled = false;
            lnkPageD.Text = (pageIndex + 1).ToString();
            lnkPageE.Text = (pageIndex + 2).ToString();
        }

        /**
         * Disable link for current page 
         */
        private void SetPageLinksForLastPage(int pageCount)
        {
            lnkPageA.Text = (pageCount - 4).ToString();
            lnkPageB.Text = (pageCount - 3).ToString();
            lnkPageC.Text = (pageCount - 2).ToString();
            lnkPageD.Text = (pageCount - 1).ToString();
            lnkPageE.Text = pageCount.ToString();
            lnkPageE.Enabled = false;
        }

        /**
         * Disable link for current page 
         */
        private void SetPageLinksForPageBeforeLast(int pageCount)
        {
            lnkPageA.Text = (pageCount - 4).ToString();
            lnkPageB.Text = (pageCount - 3).ToString();
            lnkPageC.Text = (pageCount - 2).ToString();
            lnkPageD.Text = (pageCount - 1).ToString();
            lnkPageD.Enabled = false;
            lnkPageE.Text = pageCount.ToString();
        }

    }
}
