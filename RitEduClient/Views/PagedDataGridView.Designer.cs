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
            this.dgv = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.lblPageDescription = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lnkFirstPage = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lnkPreviousPage = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lnkPageA = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lnkPageB = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lnkPageC = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lnkPageD = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lnkPageE = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lnkNextPage = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lnkLastPage = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(698, 307);
            this.dgv.TabIndex = 22;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // lblPageDescription
            // 
            this.lblPageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPageDescription.Location = new System.Drawing.Point(0, 313);
            this.lblPageDescription.Name = "lblPageDescription";
            this.lblPageDescription.Size = new System.Drawing.Size(103, 20);
            this.lblPageDescription.TabIndex = 23;
            this.lblPageDescription.Values.Text = "Page Description";
            // 
            // lnkFirstPage
            // 
            this.lnkFirstPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkFirstPage.Location = new System.Drawing.Point(331, 313);
            this.lnkFirstPage.Name = "lnkFirstPage";
            this.lnkFirstPage.Size = new System.Drawing.Size(33, 20);
            this.lnkFirstPage.TabIndex = 24;
            this.lnkFirstPage.Values.Text = "First";
            this.lnkFirstPage.Visible = false;
            this.lnkFirstPage.LinkClicked += new System.EventHandler(this.lnkFirstPage_LinkClicked);
            // 
            // lnkPreviousPage
            // 
            this.lnkPreviousPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkPreviousPage.Location = new System.Drawing.Point(365, 313);
            this.lnkPreviousPage.Name = "lnkPreviousPage";
            this.lnkPreviousPage.Size = new System.Drawing.Size(57, 20);
            this.lnkPreviousPage.TabIndex = 25;
            this.lnkPreviousPage.Values.Text = "Previous";
            this.lnkPreviousPage.Visible = false;
            this.lnkPreviousPage.LinkClicked += new System.EventHandler(this.lnkPreviousPage_LinkClicked);
            // 
            // lnkPageA
            // 
            this.lnkPageA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkPageA.Location = new System.Drawing.Point(422, 313);
            this.lnkPageA.Name = "lnkPageA";
            this.lnkPageA.Size = new System.Drawing.Size(37, 20);
            this.lnkPageA.TabIndex = 26;
            this.lnkPageA.Values.Text = "1000";
            this.lnkPageA.Visible = false;
            this.lnkPageA.LinkClicked += new System.EventHandler(this.lnkPageA_LinkClicked);
            // 
            // lnkPageB
            // 
            this.lnkPageB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkPageB.Location = new System.Drawing.Point(464, 313);
            this.lnkPageB.Name = "lnkPageB";
            this.lnkPageB.Size = new System.Drawing.Size(37, 20);
            this.lnkPageB.TabIndex = 27;
            this.lnkPageB.Values.Text = "2000";
            this.lnkPageB.Visible = false;
            this.lnkPageB.LinkClicked += new System.EventHandler(this.lnkPageB_LinkClicked);
            // 
            // lnkPageC
            // 
            this.lnkPageC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkPageC.Location = new System.Drawing.Point(507, 313);
            this.lnkPageC.Name = "lnkPageC";
            this.lnkPageC.Size = new System.Drawing.Size(37, 20);
            this.lnkPageC.TabIndex = 28;
            this.lnkPageC.Values.Text = "3000";
            this.lnkPageC.Visible = false;
            this.lnkPageC.LinkClicked += new System.EventHandler(this.lnkPageC_LinkClicked);
            // 
            // lnkPageD
            // 
            this.lnkPageD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkPageD.Location = new System.Drawing.Point(548, 313);
            this.lnkPageD.Name = "lnkPageD";
            this.lnkPageD.Size = new System.Drawing.Size(37, 20);
            this.lnkPageD.TabIndex = 29;
            this.lnkPageD.Values.Text = "4000";
            this.lnkPageD.Visible = false;
            this.lnkPageD.LinkClicked += new System.EventHandler(this.lnkPageD_LinkClicked);
            // 
            // lnkPageE
            // 
            this.lnkPageE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkPageE.Location = new System.Drawing.Point(586, 313);
            this.lnkPageE.Name = "lnkPageE";
            this.lnkPageE.Size = new System.Drawing.Size(37, 20);
            this.lnkPageE.TabIndex = 30;
            this.lnkPageE.Values.Text = "5000";
            this.lnkPageE.Visible = false;
            this.lnkPageE.LinkClicked += new System.EventHandler(this.lnkPageE_LinkClicked);
            // 
            // lnkNextPage
            // 
            this.lnkNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkNextPage.Location = new System.Drawing.Point(629, 313);
            this.lnkNextPage.Name = "lnkNextPage";
            this.lnkNextPage.Size = new System.Drawing.Size(36, 20);
            this.lnkNextPage.TabIndex = 31;
            this.lnkNextPage.Values.Text = "Next";
            this.lnkNextPage.Visible = false;
            this.lnkNextPage.LinkClicked += new System.EventHandler(this.lnkNextPage_LinkClicked);
            // 
            // lnkLastPage
            // 
            this.lnkLastPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkLastPage.Location = new System.Drawing.Point(666, 313);
            this.lnkLastPage.Name = "lnkLastPage";
            this.lnkLastPage.Size = new System.Drawing.Size(32, 20);
            this.lnkLastPage.TabIndex = 32;
            this.lnkLastPage.Values.Text = "Last";
            this.lnkLastPage.Visible = false;
            this.lnkLastPage.LinkClicked += new System.EventHandler(this.lnkLastPage_LinkClicked);
            // 
            // PagedDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
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
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PagedDataGridView";
            this.Size = new System.Drawing.Size(698, 350);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPageDescription;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkFirstPage;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkPreviousPage;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkPageA;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkPageB;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkPageC;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkPageD;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkPageE;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkNextPage;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkLastPage;
    }
}
