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

        public IPagedDataProvider PagedDataProvider { private get; set; }

        public DataGridViewColumnSortMode DefaultColumnSortMode { get; set; }

        public int PageSize{ get; set; }

        public object GetCellValue(int rowIndex, string columnName)
        {
            return dgv.Rows[rowIndex].Cells[columnName].Value;
        }

        public string GetColumnName(int columnIndex)
        {
            return dgv.Columns[columnIndex].Name;
        }

        public void Clear()
        {
            dgv.DataSource = null;
        }

        public void SelectPage(int pageIndex)
        {
            _currentPageIndex = pageIndex;
            dgv.DataSource = PagedDataProvider.GetPage(pageIndex, PageSize);
            foreach(DataGridViewColumn col in dgv.Columns)
            {
                col.SortMode = DefaultColumnSortMode;
            }
            SetPageDescription(GetPageDescription(pageIndex, PagedDataProvider.RecordCount));
            int pageCount = GetPageCount(PagedDataProvider.RecordCount);
            if(PagedDataProvider.RecordCount > PageSize)
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

        public void SetColumnSortGlyphDirection(string colName, SortOrder direction)
        {
            dgv.Columns[colName].HeaderCell.SortGlyphDirection = direction;
        }

        public void SetColumnVisibility(string colName, bool visible)
        {
            dgv.Columns[colName].Visible = visible;
        }

        public void SetPageDescription(string info)
        {
            lblPageDescription.Text = info;
        }

        private int GetPageCount(int recordCount)
        {
            return (int)Math.Ceiling((decimal)recordCount / PageSize);
        }

        private string GetPageDescription(int pageIndex, int recordCount)
        {
            return "Showing " + (Math.Min((pageIndex - 1) * PageSize + 1, recordCount)).ToString() +
                   " to " + (Math.Min(pageIndex * PageSize, recordCount)).ToString() +
                   " of " + recordCount + " entries";
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CellContentClick?.Invoke(sender, e);
        }

        private void lnkFirstPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectPage(1);
        }

        private void lnkLastPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int pageCount = GetPageCount(PagedDataProvider.RecordCount);
            SelectPage(pageCount);
        }

        private void lnkNextPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectPage(_currentPageIndex + 1);
        }

        private void lnkPageA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int pageIndex = int.Parse(lnkPageA.Text);
            SelectPage(pageIndex);
        }

        private void lnkPageB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int pageIndex = int.Parse(lnkPageB.Text);
            SelectPage(pageIndex);
        }

        private void lnkPageC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int pageIndex = int.Parse(lnkPageC.Text);
            SelectPage(pageIndex);
        }

        private void lnkPageD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int pageIndex = int.Parse(lnkPageD.Text);
            SelectPage(pageIndex);
        }

        private void lnkPageE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int pageIndex = int.Parse(lnkPageE.Text);
            SelectPage(pageIndex);
        }

        private void lnkPreviousPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectPage(_currentPageIndex - 1);
        }

        private void SetPageLinks(int pageIndex)
        {
            lnkPageA.Enabled = lnkPageB.Enabled = lnkPageC.Enabled = lnkPageD.Enabled = lnkPageE.Enabled = true;
            lnkPageA.Visible = true;
            lnkPageB.Visible = true;
            lnkPageC.Visible = (PagedDataProvider.RecordCount > 2 * PageSize);
            lnkPageD.Visible = (PagedDataProvider.RecordCount > 3 * PageSize);
            lnkPageE.Visible = (PagedDataProvider.RecordCount > 4 * PageSize);
            int pageCount = GetPageCount(PagedDataProvider.RecordCount);
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

        private void SetPageLinksForPage1()
        {
            lnkPageA.Text = "1";
            lnkPageA.Enabled = false;
            lnkPageB.Text = "2";
            lnkPageC.Text = "3";
            lnkPageD.Text = "4";
            lnkPageE.Text = "5";
        }

        private void SetPageLinksForPage2()
        {
            lnkPageA.Text = "1";
            lnkPageB.Text = "2";
            lnkPageB.Enabled = false;
            lnkPageC.Text = "3";
            lnkPageD.Text = "4";
            lnkPageE.Text = "5";
        }

        private void SetPageLinksForInnerPage(int pageIndex)
        {
            lnkPageA.Text = (pageIndex - 2).ToString();
            lnkPageB.Text = (pageIndex - 1).ToString();
            lnkPageC.Text = pageIndex.ToString();
            lnkPageC.Enabled = false;
            lnkPageD.Text = (pageIndex + 1).ToString();
            lnkPageE.Text = (pageIndex + 2).ToString();
        }

        private void SetPageLinksForLastPage(int pageCount)
        {
            lnkPageA.Text = (pageCount - 4).ToString();
            lnkPageB.Text = (pageCount - 3).ToString();
            lnkPageC.Text = (pageCount - 2).ToString();
            lnkPageD.Text = (pageCount - 1).ToString();
            lnkPageE.Text = pageCount.ToString();
            lnkPageE.Enabled = false;
        }

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
