namespace RitEduClient
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Search = new System.Windows.Forms.GroupBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.txtOrgName = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.Zip = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.state = new System.Windows.Forms.Label();
            this.organizationName = new System.Windows.Forms.Label();
            this.organizationType = new System.Windows.Forms.Label();
            this.cmbOrgType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResultsInfo = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lnkFirstPage = new System.Windows.Forms.LinkLabel();
            this.lnkPreviousPage = new System.Windows.Forms.LinkLabel();
            this.lnkPageA = new System.Windows.Forms.LinkLabel();
            this.lnkPageB = new System.Windows.Forms.LinkLabel();
            this.lnkPageC = new System.Windows.Forms.LinkLabel();
            this.lnkPageD = new System.Windows.Forms.LinkLabel();
            this.lnkPageE = new System.Windows.Forms.LinkLabel();
            this.lnkNextPage = new System.Windows.Forms.LinkLabel();
            this.lnkLastPage = new System.Windows.Forms.LinkLabel();
            this.Search.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Controls.Add(this.txtCounty);
            this.Search.Controls.Add(this.label1);
            this.Search.Controls.Add(this.cmbCity);
            this.Search.Controls.Add(this.txtOrgName);
            this.Search.Controls.Add(this.btnReset);
            this.Search.Controls.Add(this.btnSearch);
            this.Search.Controls.Add(this.txtZip);
            this.Search.Controls.Add(this.Zip);
            this.Search.Controls.Add(this.cmbState);
            this.Search.Controls.Add(this.state);
            this.Search.Controls.Add(this.organizationName);
            this.Search.Controls.Add(this.organizationType);
            this.Search.Controls.Add(this.cmbOrgType);
            this.Search.Location = new System.Drawing.Point(27, 23);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(766, 132);
            this.Search.TabIndex = 11;
            this.Search.TabStop = false;
            this.Search.Text = "Search";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(492, 56);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(121, 20);
            this.txtCounty.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "County";
            // 
            // cmbCity
            // 
            this.cmbCity.Enabled = false;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(243, 56);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 21);
            this.cmbCity.TabIndex = 40;
            this.cmbCity.Text = "-- select any value --";
            // 
            // txtOrgName
            // 
            this.txtOrgName.Location = new System.Drawing.Point(492, 27);
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.Size = new System.Drawing.Size(121, 20);
            this.txtOrgName.TabIndex = 20;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(663, 88);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(97, 32);
            this.btnReset.TabIndex = 80;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(560, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 32);
            this.btnSearch.TabIndex = 70;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(116, 86);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(121, 20);
            this.txtZip.TabIndex = 60;
            // 
            // Zip
            // 
            this.Zip.AutoSize = true;
            this.Zip.Location = new System.Drawing.Point(7, 88);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(22, 13);
            this.Zip.TabIndex = 15;
            this.Zip.Text = "Zip";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(116, 56);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(121, 21);
            this.cmbState.TabIndex = 30;
            this.cmbState.Text = "-- select any value --";
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(7, 59);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(52, 13);
            this.state.TabIndex = 12;
            this.state.Text = "State-City";
            // 
            // organizationName
            // 
            this.organizationName.AutoSize = true;
            this.organizationName.Location = new System.Drawing.Point(383, 30);
            this.organizationName.Name = "organizationName";
            this.organizationName.Size = new System.Drawing.Size(97, 13);
            this.organizationName.TabIndex = 10;
            this.organizationName.Text = "Organization Name";
            // 
            // organizationType
            // 
            this.organizationType.AutoSize = true;
            this.organizationType.Location = new System.Drawing.Point(6, 30);
            this.organizationType.Name = "organizationType";
            this.organizationType.Size = new System.Drawing.Size(93, 13);
            this.organizationType.TabIndex = 9;
            this.organizationType.Text = "Organization Type";
            // 
            // cmbOrgType
            // 
            this.cmbOrgType.FormattingEnabled = true;
            this.cmbOrgType.Location = new System.Drawing.Point(116, 27);
            this.cmbOrgType.Name = "cmbOrgType";
            this.cmbOrgType.Size = new System.Drawing.Size(121, 21);
            this.cmbOrgType.TabIndex = 10;
            this.cmbOrgType.Text = "-- select any value --";
            this.cmbOrgType.SelectedIndexChanged += new System.EventHandler(this.cmbOrgType_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkLastPage);
            this.groupBox1.Controls.Add(this.lnkNextPage);
            this.groupBox1.Controls.Add(this.lnkPageE);
            this.groupBox1.Controls.Add(this.lnkPageD);
            this.groupBox1.Controls.Add(this.lnkPageC);
            this.groupBox1.Controls.Add(this.lnkPageB);
            this.groupBox1.Controls.Add(this.lnkPageA);
            this.groupBox1.Controls.Add(this.lnkPreviousPage);
            this.groupBox1.Controls.Add(this.lnkFirstPage);
            this.groupBox1.Controls.Add(this.lblResultsInfo);
            this.groupBox1.Controls.Add(this.dgvResults);
            this.groupBox1.Location = new System.Drawing.Point(27, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 365);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // lblResultsInfo
            // 
            this.lblResultsInfo.AutoSize = true;
            this.lblResultsInfo.Location = new System.Drawing.Point(7, 323);
            this.lblResultsInfo.Name = "lblResultsInfo";
            this.lblResultsInfo.Size = new System.Drawing.Size(88, 13);
            this.lblResultsInfo.TabIndex = 1;
            this.lblResultsInfo.Text = "Page Description";
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(9, 20);
            this.dgvResults.Name = "dgvResults";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResults.Size = new System.Drawing.Size(750, 291);
            this.dgvResults.TabIndex = 0;
            // 
            // lnkFirstPage
            // 
            this.lnkFirstPage.AutoSize = true;
            this.lnkFirstPage.Location = new System.Drawing.Point(518, 323);
            this.lnkFirstPage.Name = "lnkFirstPage";
            this.lnkFirstPage.Size = new System.Drawing.Size(26, 13);
            this.lnkFirstPage.TabIndex = 4;
            this.lnkFirstPage.TabStop = true;
            this.lnkFirstPage.Text = "First";
            this.lnkFirstPage.Visible = false;
            // 
            // lnkPreviousPage
            // 
            this.lnkPreviousPage.AutoSize = true;
            this.lnkPreviousPage.Location = new System.Drawing.Point(548, 323);
            this.lnkPreviousPage.Name = "lnkPreviousPage";
            this.lnkPreviousPage.Size = new System.Drawing.Size(48, 13);
            this.lnkPreviousPage.TabIndex = 5;
            this.lnkPreviousPage.TabStop = true;
            this.lnkPreviousPage.Text = "Previous";
            this.lnkPreviousPage.Visible = false;
            // 
            // lnkPageA
            // 
            this.lnkPageA.AutoSize = true;
            this.lnkPageA.Location = new System.Drawing.Point(602, 323);
            this.lnkPageA.Name = "lnkPageA";
            this.lnkPageA.Size = new System.Drawing.Size(13, 13);
            this.lnkPageA.TabIndex = 6;
            this.lnkPageA.TabStop = true;
            this.lnkPageA.Text = "1";
            this.lnkPageA.Visible = false;
            this.lnkPageA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPageA_LinkClicked);
            // 
            // lnkPageB
            // 
            this.lnkPageB.AutoSize = true;
            this.lnkPageB.Location = new System.Drawing.Point(621, 323);
            this.lnkPageB.Name = "lnkPageB";
            this.lnkPageB.Size = new System.Drawing.Size(13, 13);
            this.lnkPageB.TabIndex = 7;
            this.lnkPageB.TabStop = true;
            this.lnkPageB.Text = "2";
            this.lnkPageB.Visible = false;
            this.lnkPageB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPageB_LinkClicked);
            // 
            // lnkPageC
            // 
            this.lnkPageC.AutoSize = true;
            this.lnkPageC.Location = new System.Drawing.Point(640, 323);
            this.lnkPageC.Name = "lnkPageC";
            this.lnkPageC.Size = new System.Drawing.Size(13, 13);
            this.lnkPageC.TabIndex = 8;
            this.lnkPageC.TabStop = true;
            this.lnkPageC.Text = "3";
            this.lnkPageC.Visible = false;
            this.lnkPageC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPageC_LinkClicked);
            // 
            // lnkPageD
            // 
            this.lnkPageD.AutoSize = true;
            this.lnkPageD.Location = new System.Drawing.Point(659, 323);
            this.lnkPageD.Name = "lnkPageD";
            this.lnkPageD.Size = new System.Drawing.Size(13, 13);
            this.lnkPageD.TabIndex = 9;
            this.lnkPageD.TabStop = true;
            this.lnkPageD.Text = "4";
            this.lnkPageD.Visible = false;
            this.lnkPageD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPageD_LinkClicked);
            // 
            // lnkPageE
            // 
            this.lnkPageE.AutoSize = true;
            this.lnkPageE.Location = new System.Drawing.Point(678, 323);
            this.lnkPageE.Name = "lnkPageE";
            this.lnkPageE.Size = new System.Drawing.Size(13, 13);
            this.lnkPageE.TabIndex = 10;
            this.lnkPageE.TabStop = true;
            this.lnkPageE.Text = "5";
            this.lnkPageE.Visible = false;
            this.lnkPageE.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPageE_LinkClicked);
            // 
            // lnkNextPage
            // 
            this.lnkNextPage.AutoSize = true;
            this.lnkNextPage.Location = new System.Drawing.Point(697, 323);
            this.lnkNextPage.Name = "lnkNextPage";
            this.lnkNextPage.Size = new System.Drawing.Size(29, 13);
            this.lnkNextPage.TabIndex = 11;
            this.lnkNextPage.TabStop = true;
            this.lnkNextPage.Text = "Next";
            this.lnkNextPage.Visible = false;
            // 
            // lnkLastPage
            // 
            this.lnkLastPage.AutoSize = true;
            this.lnkLastPage.Location = new System.Drawing.Point(732, 323);
            this.lnkLastPage.Name = "lnkLastPage";
            this.lnkLastPage.Size = new System.Drawing.Size(27, 13);
            this.lnkLastPage.TabIndex = 12;
            this.lnkLastPage.TabStop = true;
            this.lnkLastPage.Text = "Last";
            this.lnkLastPage.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 538);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "RitEdu client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Search;
        private System.Windows.Forms.TextBox txtOrgName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label Zip;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label organizationName;
        private System.Windows.Forms.Label organizationType;
        private System.Windows.Forms.ComboBox cmbOrgType;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label lblResultsInfo;
        private System.Windows.Forms.LinkLabel lnkFirstPage;
        private System.Windows.Forms.LinkLabel lnkPreviousPage;
        private System.Windows.Forms.LinkLabel lnkPageA;
        private System.Windows.Forms.LinkLabel lnkPageB;
        private System.Windows.Forms.LinkLabel lnkPageD;
        private System.Windows.Forms.LinkLabel lnkPageC;
        private System.Windows.Forms.LinkLabel lnkPageE;
        private System.Windows.Forms.LinkLabel lnkNextPage;
        private System.Windows.Forms.LinkLabel lnkLastPage;
    }
}

