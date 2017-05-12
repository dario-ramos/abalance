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
            this.components = new System.ComponentModel.Container();
            this.rtbMessageLog = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kgbxMessageLog = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kbgxSearch = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.cmbOrgType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbState = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtZip = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmbCity = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtOrgName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtCounty = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnReset = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pdgvResults = new RitEduClient.PagedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kgbxMessageLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgbxMessageLog.Panel)).BeginInit();
            this.kgbxMessageLog.Panel.SuspendLayout();
            this.kgbxMessageLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kbgxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kbgxSearch.Panel)).BeginInit();
            this.kbgxSearch.Panel.SuspendLayout();
            this.kbgxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrgType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCity)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbMessageLog
            // 
            this.rtbMessageLog.Location = new System.Drawing.Point(7, 10);
            this.rtbMessageLog.Name = "rtbMessageLog";
            this.rtbMessageLog.Size = new System.Drawing.Size(708, 96);
            this.rtbMessageLog.TabIndex = 0;
            this.rtbMessageLog.Text = "";
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.SparkleBlue;
            // 
            // kgbxMessageLog
            // 
            this.kgbxMessageLog.CaptionOverlap = 1D;
            this.kgbxMessageLog.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.kgbxMessageLog.Location = new System.Drawing.Point(12, 620);
            this.kgbxMessageLog.Name = "kgbxMessageLog";
            // 
            // kgbxMessageLog.Panel
            // 
            this.kgbxMessageLog.Panel.Controls.Add(this.rtbMessageLog);
            this.kgbxMessageLog.Size = new System.Drawing.Size(729, 131);
            this.kgbxMessageLog.TabIndex = 15;
            this.kgbxMessageLog.Values.Heading = "Message Log";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 150);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel1.TabIndex = 17;
            this.kryptonLabel1.Values.Text = "Results";
            // 
            // kbgxSearch
            // 
            this.kbgxSearch.CaptionOverlap = 1D;
            this.kbgxSearch.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.kbgxSearch.Location = new System.Drawing.Point(12, 4);
            this.kbgxSearch.Name = "kbgxSearch";
            // 
            // kbgxSearch.Panel
            // 
            this.kbgxSearch.Panel.Controls.Add(this.btnSearch);
            this.kbgxSearch.Panel.Controls.Add(this.btnReset);
            this.kbgxSearch.Panel.Controls.Add(this.kryptonLabel6);
            this.kbgxSearch.Panel.Controls.Add(this.txtCounty);
            this.kbgxSearch.Panel.Controls.Add(this.kryptonLabel5);
            this.kbgxSearch.Panel.Controls.Add(this.txtOrgName);
            this.kbgxSearch.Panel.Controls.Add(this.kryptonLabel4);
            this.kbgxSearch.Panel.Controls.Add(this.cmbCity);
            this.kbgxSearch.Panel.Controls.Add(this.kryptonLabel3);
            this.kbgxSearch.Panel.Controls.Add(this.txtZip);
            this.kbgxSearch.Panel.Controls.Add(this.cmbState);
            this.kbgxSearch.Panel.Controls.Add(this.kryptonLabel2);
            this.kbgxSearch.Panel.Controls.Add(this.cmbOrgType);
            this.kbgxSearch.Size = new System.Drawing.Size(729, 140);
            this.kbgxSearch.TabIndex = 81;
            this.kbgxSearch.Values.Heading = "Search";
            // 
            // cmbOrgType
            // 
            this.cmbOrgType.DropDownWidth = 133;
            this.cmbOrgType.Location = new System.Drawing.Point(136, 13);
            this.cmbOrgType.Name = "cmbOrgType";
            this.cmbOrgType.Size = new System.Drawing.Size(133, 21);
            this.cmbOrgType.TabIndex = 0;
            this.cmbOrgType.Text = "-- select any value --";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(19, 14);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(111, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Organization Type";
            // 
            // cmbState
            // 
            this.cmbState.DropDownWidth = 133;
            this.cmbState.Location = new System.Drawing.Point(136, 47);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(133, 21);
            this.cmbState.TabIndex = 2;
            this.cmbState.Text = "-- select any value --";
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(136, 82);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(133, 23);
            this.txtZip.TabIndex = 3;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(19, 47);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(64, 20);
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "State-City";
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownWidth = 133;
            this.cmbCity.Location = new System.Drawing.Point(286, 47);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(133, 21);
            this.cmbCity.TabIndex = 5;
            this.cmbCity.Text = "-- select any value --";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(19, 82);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(28, 20);
            this.kryptonLabel4.TabIndex = 6;
            this.kryptonLabel4.Values.Text = "Zip";
            // 
            // txtOrgName
            // 
            this.txtOrgName.Location = new System.Drawing.Point(564, 13);
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.Size = new System.Drawing.Size(133, 23);
            this.txtOrgName.TabIndex = 7;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(441, 14);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(117, 20);
            this.kryptonLabel5.TabIndex = 8;
            this.kryptonLabel5.Values.Text = "Organization Name";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(564, 47);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(133, 23);
            this.txtCounty.TabIndex = 9;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(508, 47);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(50, 20);
            this.kryptonLabel6.TabIndex = 10;
            this.kryptonLabel6.Values.Text = "County";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(607, 82);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 25);
            this.btnReset.TabIndex = 11;
            this.btnReset.Values.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(508, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 25);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Values.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pdgvResults
            // 
            this.pdgvResults.BackColor = System.Drawing.SystemColors.Control;
            this.pdgvResults.DataSetId = null;
            this.pdgvResults.DefaultColumnSortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pdgvResults.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdgvResults.Location = new System.Drawing.Point(12, 172);
            this.pdgvResults.Name = "pdgvResults";
            this.pdgvResults.PageSize = 0;
            this.pdgvResults.Size = new System.Drawing.Size(729, 451);
            this.pdgvResults.TabIndex = 16;
            this.pdgvResults.CellContentClick += new System.Action<object, System.Windows.Forms.DataGridViewCellEventArgs>(this.pdgvResults_CellContentClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 763);
            this.Controls.Add(this.kbgxSearch);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.pdgvResults);
            this.Controls.Add(this.kgbxMessageLog);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RitEdu client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kgbxMessageLog.Panel)).EndInit();
            this.kgbxMessageLog.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgbxMessageLog)).EndInit();
            this.kgbxMessageLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kbgxSearch.Panel)).EndInit();
            this.kbgxSearch.Panel.ResumeLayout(false);
            this.kbgxSearch.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kbgxSearch)).EndInit();
            this.kbgxSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbOrgType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox rtbMessageLog;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kgbxMessageLog;
        private PagedDataGridView pdgvResults;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kbgxSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbOrgType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbState;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtZip;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbCity;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtOrgName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCounty;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnReset;
    }
}

