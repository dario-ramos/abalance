namespace RitEduClient
{
    partial class PagedDataGridView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblPageDescription = new System.Windows.Forms.Label();
            this.lnkLastPage = new System.Windows.Forms.LinkLabel();
            this.lnkNextPage = new System.Windows.Forms.LinkLabel();
            this.lnkPageE = new System.Windows.Forms.LinkLabel();
            this.lnkPageD = new System.Windows.Forms.LinkLabel();
            this.lnkPageC = new System.Windows.Forms.LinkLabel();
            this.lnkPageB = new System.Windows.Forms.LinkLabel();
            this.lnkPageA = new System.Windows.Forms.LinkLabel();
            this.lnkPreviousPage = new System.Windows.Forms.LinkLabel();
            this.lnkFirstPage = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(15, 18);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(687, 344);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // lblPageDescription
            // 
            this.lblPageDescription.AutoSize = true;
            this.lblPageDescription.Location = new System.Drawing.Point(12, 374);
            this.lblPageDescription.Name = "lblPageDescription";
            this.lblPageDescription.Size = new System.Drawing.Size(88, 13);
            this.lblPageDescription.TabIndex = 2;
            this.lblPageDescription.Text = "Page Description";
            // 
            // lnkLastPage
            // 
            this.lnkLastPage.AutoSize = true;
            this.lnkLastPage.Location = new System.Drawing.Point(676, 374);
            this.lnkLastPage.Name = "lnkLastPage";
            this.lnkLastPage.Size = new System.Drawing.Size(27, 13);
            this.lnkLastPage.TabIndex = 21;
            this.lnkLastPage.TabStop = true;
            this.lnkLastPage.Text = "Last";
            this.lnkLastPage.Visible = false;
            this.lnkLastPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLastPage_LinkClicked);
            // 
            // lnkNextPage
            // 
            this.lnkNextPage.AutoSize = true;
            this.lnkNextPage.Location = new System.Drawing.Point(641, 374);
            this.lnkNextPage.Name = "lnkNextPage";
            this.lnkNextPage.Size = new System.Drawing.Size(29, 13);
            this.lnkNextPage.TabIndex = 20;
            this.lnkNextPage.TabStop = true;
            this.lnkNextPage.Text = "Next";
            this.lnkNextPage.Visible = false;
            this.lnkNextPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNextPage_LinkClicked);
            // 
            // lnkPageE
            // 
            this.lnkPageE.Location = new System.Drawing.Point(601, 374);
            this.lnkPageE.Name = "lnkPageE";
            this.lnkPageE.Size = new System.Drawing.Size(35, 13);
            this.lnkPageE.TabIndex = 19;
            this.lnkPageE.TabStop = true;
            this.lnkPageE.Text = "5000";
            this.lnkPageE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkPageE.Visible = false;
            this.lnkPageE.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPageE_LinkClicked);
            // 
            // lnkPageD
            // 
            this.lnkPageD.Location = new System.Drawing.Point(564, 374);
            this.lnkPageD.Name = "lnkPageD";
            this.lnkPageD.Size = new System.Drawing.Size(35, 13);
            this.lnkPageD.TabIndex = 18;
            this.lnkPageD.TabStop = true;
            this.lnkPageD.Text = "4000";
            this.lnkPageD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkPageD.Visible = false;
            this.lnkPageD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPageD_LinkClicked);
            // 
            // lnkPageC
            // 
            this.lnkPageC.Location = new System.Drawing.Point(525, 374);
            this.lnkPageC.Name = "lnkPageC";
            this.lnkPageC.Size = new System.Drawing.Size(35, 13);
            this.lnkPageC.TabIndex = 17;
            this.lnkPageC.TabStop = true;
            this.lnkPageC.Text = "3000";
            this.lnkPageC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkPageC.Visible = false;
            this.lnkPageC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPageC_LinkClicked);
            // 
            // lnkPageB
            // 
            this.lnkPageB.Location = new System.Drawing.Point(486, 374);
            this.lnkPageB.Name = "lnkPageB";
            this.lnkPageB.Size = new System.Drawing.Size(35, 13);
            this.lnkPageB.TabIndex = 16;
            this.lnkPageB.TabStop = true;
            this.lnkPageB.Text = "2000";
            this.lnkPageB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkPageB.Visible = false;
            this.lnkPageB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPageB_LinkClicked);
            // 
            // lnkPageA
            // 
            this.lnkPageA.Location = new System.Drawing.Point(450, 374);
            this.lnkPageA.Name = "lnkPageA";
            this.lnkPageA.Size = new System.Drawing.Size(35, 13);
            this.lnkPageA.TabIndex = 15;
            this.lnkPageA.TabStop = true;
            this.lnkPageA.Text = "1000";
            this.lnkPageA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkPageA.Visible = false;
            this.lnkPageA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPageA_LinkClicked);
            // 
            // lnkPreviousPage
            // 
            this.lnkPreviousPage.AutoSize = true;
            this.lnkPreviousPage.Location = new System.Drawing.Point(400, 374);
            this.lnkPreviousPage.Name = "lnkPreviousPage";
            this.lnkPreviousPage.Size = new System.Drawing.Size(48, 13);
            this.lnkPreviousPage.TabIndex = 14;
            this.lnkPreviousPage.TabStop = true;
            this.lnkPreviousPage.Text = "Previous";
            this.lnkPreviousPage.Visible = false;
            this.lnkPreviousPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPreviousPage_LinkClicked);
            // 
            // lnkFirstPage
            // 
            this.lnkFirstPage.AutoSize = true;
            this.lnkFirstPage.Location = new System.Drawing.Point(364, 374);
            this.lnkFirstPage.Name = "lnkFirstPage";
            this.lnkFirstPage.Size = new System.Drawing.Size(26, 13);
            this.lnkFirstPage.TabIndex = 13;
            this.lnkFirstPage.TabStop = true;
            this.lnkFirstPage.Text = "First";
            this.lnkFirstPage.Visible = false;
            this.lnkFirstPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFirstPage_LinkClicked);
            // 
            // PagedDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lnkLastPage);
            this.Controls.Add(this.lnkNextPage);
            this.Controls.Add(this.lnkPageE);
            this.Controls.Add(this.lnkPageD);
            this.Controls.Add(this.lnkPageC);
            this.Controls.Add(this.lnkPageB);
            this.Controls.Add(this.lnkPageA);
            this.Controls.Add(this.lnkPreviousPage);
            this.Controls.Add(this.lnkFirstPage);
            this.Controls.Add(this.lblPageDescription);
            this.Controls.Add(this.dgv);
            this.Name = "PagedDataGridView";
            this.Size = new System.Drawing.Size(722, 402);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblPageDescription;
        private System.Windows.Forms.LinkLabel lnkLastPage;
        private System.Windows.Forms.LinkLabel lnkNextPage;
        private System.Windows.Forms.LinkLabel lnkPageE;
        private System.Windows.Forms.LinkLabel lnkPageD;
        private System.Windows.Forms.LinkLabel lnkPageC;
        private System.Windows.Forms.LinkLabel lnkPageB;
        private System.Windows.Forms.LinkLabel lnkPageA;
        private System.Windows.Forms.LinkLabel lnkPreviousPage;
        private System.Windows.Forms.LinkLabel lnkFirstPage;
    }
}
