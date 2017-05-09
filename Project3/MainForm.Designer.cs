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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lnkLastPage = new System.Windows.Forms.LinkLabel();
            this.lnkNextPage = new System.Windows.Forms.LinkLabel();
            this.lnkPageE = new System.Windows.Forms.LinkLabel();
            this.lnkPageD = new System.Windows.Forms.LinkLabel();
            this.lnkPageC = new System.Windows.Forms.LinkLabel();
            this.lnkPageB = new System.Windows.Forms.LinkLabel();
            this.lnkPageA = new System.Windows.Forms.LinkLabel();
            this.lnkPreviousPage = new System.Windows.Forms.LinkLabel();
            this.lnkFirstPage = new System.Windows.Forms.LinkLabel();
            this.lblResultsInfo = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.tbcMainTabs = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabLocation = new System.Windows.Forms.TabPage();
            this.tabTraining = new System.Windows.Forms.TabPage();
            this.tabTreatment = new System.Windows.Forms.TabPage();
            this.tabFacilities = new System.Windows.Forms.TabPage();
            this.tabEquipment = new System.Windows.Forms.TabPage();
            this.tabPhysicians = new System.Windows.Forms.TabPage();
            this.tabPeople = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGeneralInfoName = new System.Windows.Forms.Label();
            this.lblGeneralInfoDescription = new System.Windows.Forms.Label();
            this.lblGeneralInfoEmail = new System.Windows.Forms.Label();
            this.lblGeneralInfoWebsite = new System.Windows.Forms.Label();
            this.lblGeneralInfoNumMem = new System.Windows.Forms.Label();
            this.lblGeneralInfoNumCalls = new System.Windows.Forms.Label();
            this.Search.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.tbcMainTabs.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.Search.Location = new System.Drawing.Point(18, 16);
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
            this.groupBox1.Location = new System.Drawing.Point(18, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 365);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
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
            this.lnkLastPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLastPage_LinkClicked);
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
            this.lnkNextPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNextPage_LinkClicked);
            // 
            // lnkPageE
            // 
            this.lnkPageE.Location = new System.Drawing.Point(657, 323);
            this.lnkPageE.Name = "lnkPageE";
            this.lnkPageE.Size = new System.Drawing.Size(35, 13);
            this.lnkPageE.TabIndex = 10;
            this.lnkPageE.TabStop = true;
            this.lnkPageE.Text = "5000";
            this.lnkPageE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkPageE.Visible = false;
            this.lnkPageE.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPageE_LinkClicked);
            // 
            // lnkPageD
            // 
            this.lnkPageD.Location = new System.Drawing.Point(620, 323);
            this.lnkPageD.Name = "lnkPageD";
            this.lnkPageD.Size = new System.Drawing.Size(35, 13);
            this.lnkPageD.TabIndex = 9;
            this.lnkPageD.TabStop = true;
            this.lnkPageD.Text = "4000";
            this.lnkPageD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkPageD.Visible = false;
            this.lnkPageD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPageD_LinkClicked);
            // 
            // lnkPageC
            // 
            this.lnkPageC.Location = new System.Drawing.Point(581, 323);
            this.lnkPageC.Name = "lnkPageC";
            this.lnkPageC.Size = new System.Drawing.Size(35, 13);
            this.lnkPageC.TabIndex = 8;
            this.lnkPageC.TabStop = true;
            this.lnkPageC.Text = "3000";
            this.lnkPageC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkPageC.Visible = false;
            this.lnkPageC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPageC_LinkClicked);
            // 
            // lnkPageB
            // 
            this.lnkPageB.Location = new System.Drawing.Point(542, 323);
            this.lnkPageB.Name = "lnkPageB";
            this.lnkPageB.Size = new System.Drawing.Size(35, 13);
            this.lnkPageB.TabIndex = 7;
            this.lnkPageB.TabStop = true;
            this.lnkPageB.Text = "2000";
            this.lnkPageB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkPageB.Visible = false;
            this.lnkPageB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPageB_LinkClicked);
            // 
            // lnkPageA
            // 
            this.lnkPageA.Location = new System.Drawing.Point(506, 323);
            this.lnkPageA.Name = "lnkPageA";
            this.lnkPageA.Size = new System.Drawing.Size(35, 13);
            this.lnkPageA.TabIndex = 6;
            this.lnkPageA.TabStop = true;
            this.lnkPageA.Text = "1000";
            this.lnkPageA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkPageA.Visible = false;
            this.lnkPageA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPageA_LinkClicked);
            // 
            // lnkPreviousPage
            // 
            this.lnkPreviousPage.AutoSize = true;
            this.lnkPreviousPage.Location = new System.Drawing.Point(456, 323);
            this.lnkPreviousPage.Name = "lnkPreviousPage";
            this.lnkPreviousPage.Size = new System.Drawing.Size(48, 13);
            this.lnkPreviousPage.TabIndex = 5;
            this.lnkPreviousPage.TabStop = true;
            this.lnkPreviousPage.Text = "Previous";
            this.lnkPreviousPage.Visible = false;
            this.lnkPreviousPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPreviousPage_LinkClicked);
            // 
            // lnkFirstPage
            // 
            this.lnkFirstPage.AutoSize = true;
            this.lnkFirstPage.Location = new System.Drawing.Point(416, 323);
            this.lnkFirstPage.Name = "lnkFirstPage";
            this.lnkFirstPage.Size = new System.Drawing.Size(26, 13);
            this.lnkFirstPage.TabIndex = 4;
            this.lnkFirstPage.TabStop = true;
            this.lnkFirstPage.Text = "First";
            this.lnkFirstPage.Visible = false;
            this.lnkFirstPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFirstPage_LinkClicked);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResults.Size = new System.Drawing.Size(750, 291);
            this.dgvResults.TabIndex = 0;
            this.dgvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellContentClick);
            // 
            // tbcMainTabs
            // 
            this.tbcMainTabs.Controls.Add(this.tabMain);
            this.tbcMainTabs.Controls.Add(this.tabGeneral);
            this.tbcMainTabs.Controls.Add(this.tabLocation);
            this.tbcMainTabs.Controls.Add(this.tabTraining);
            this.tbcMainTabs.Controls.Add(this.tabTreatment);
            this.tbcMainTabs.Controls.Add(this.tabFacilities);
            this.tbcMainTabs.Controls.Add(this.tabEquipment);
            this.tbcMainTabs.Controls.Add(this.tabPhysicians);
            this.tbcMainTabs.Controls.Add(this.tabPeople);
            this.tbcMainTabs.Location = new System.Drawing.Point(21, 12);
            this.tbcMainTabs.Name = "tbcMainTabs";
            this.tbcMainTabs.SelectedIndex = 0;
            this.tbcMainTabs.Size = new System.Drawing.Size(821, 568);
            this.tbcMainTabs.TabIndex = 13;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.Search);
            this.tabMain.Controls.Add(this.groupBox1);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(813, 542);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tableLayoutPanel1);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(813, 542);
            this.tabGeneral.TabIndex = 1;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tabLocation
            // 
            this.tabLocation.Location = new System.Drawing.Point(4, 22);
            this.tabLocation.Name = "tabLocation";
            this.tabLocation.Size = new System.Drawing.Size(813, 542);
            this.tabLocation.TabIndex = 2;
            this.tabLocation.Text = "Location";
            this.tabLocation.UseVisualStyleBackColor = true;
            // 
            // tabTraining
            // 
            this.tabTraining.Location = new System.Drawing.Point(4, 22);
            this.tabTraining.Name = "tabTraining";
            this.tabTraining.Size = new System.Drawing.Size(813, 542);
            this.tabTraining.TabIndex = 3;
            this.tabTraining.Text = "Training";
            this.tabTraining.UseVisualStyleBackColor = true;
            // 
            // tabTreatment
            // 
            this.tabTreatment.Location = new System.Drawing.Point(4, 22);
            this.tabTreatment.Name = "tabTreatment";
            this.tabTreatment.Size = new System.Drawing.Size(813, 542);
            this.tabTreatment.TabIndex = 4;
            this.tabTreatment.Text = "Treatment";
            this.tabTreatment.UseVisualStyleBackColor = true;
            // 
            // tabFacilities
            // 
            this.tabFacilities.Location = new System.Drawing.Point(4, 22);
            this.tabFacilities.Name = "tabFacilities";
            this.tabFacilities.Size = new System.Drawing.Size(813, 542);
            this.tabFacilities.TabIndex = 5;
            this.tabFacilities.Text = "Facilities";
            this.tabFacilities.UseVisualStyleBackColor = true;
            // 
            // tabEquipment
            // 
            this.tabEquipment.Location = new System.Drawing.Point(4, 22);
            this.tabEquipment.Name = "tabEquipment";
            this.tabEquipment.Size = new System.Drawing.Size(813, 542);
            this.tabEquipment.TabIndex = 6;
            this.tabEquipment.Text = "Equipment";
            this.tabEquipment.UseVisualStyleBackColor = true;
            // 
            // tabPhysicians
            // 
            this.tabPhysicians.Location = new System.Drawing.Point(4, 22);
            this.tabPhysicians.Name = "tabPhysicians";
            this.tabPhysicians.Size = new System.Drawing.Size(813, 542);
            this.tabPhysicians.TabIndex = 7;
            this.tabPhysicians.Text = "Physicians";
            this.tabPhysicians.UseVisualStyleBackColor = true;
            // 
            // tabPeople
            // 
            this.tabPeople.Location = new System.Drawing.Point(4, 22);
            this.tabPeople.Name = "tabPeople";
            this.tabPeople.Size = new System.Drawing.Size(813, 542);
            this.tabPeople.TabIndex = 8;
            this.tabPeople.Text = "People";
            this.tabPeople.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblGeneralInfoName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblGeneralInfoDescription, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGeneralInfoEmail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGeneralInfoWebsite, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGeneralInfoNumMem, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblGeneralInfoNumCalls, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 121);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Website";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Number of Members";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Number of Calls";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGeneralInfoName
            // 
            this.lblGeneralInfoName.AutoSize = true;
            this.lblGeneralInfoName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGeneralInfoName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGeneralInfoName.Location = new System.Drawing.Point(154, 0);
            this.lblGeneralInfoName.Name = "lblGeneralInfoName";
            this.lblGeneralInfoName.Size = new System.Drawing.Size(599, 20);
            this.lblGeneralInfoName.TabIndex = 6;
            this.lblGeneralInfoName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGeneralInfoDescription
            // 
            this.lblGeneralInfoDescription.AutoSize = true;
            this.lblGeneralInfoDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGeneralInfoDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGeneralInfoDescription.Location = new System.Drawing.Point(154, 20);
            this.lblGeneralInfoDescription.Name = "lblGeneralInfoDescription";
            this.lblGeneralInfoDescription.Size = new System.Drawing.Size(599, 20);
            this.lblGeneralInfoDescription.TabIndex = 7;
            this.lblGeneralInfoDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGeneralInfoEmail
            // 
            this.lblGeneralInfoEmail.AutoSize = true;
            this.lblGeneralInfoEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGeneralInfoEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGeneralInfoEmail.Location = new System.Drawing.Point(154, 40);
            this.lblGeneralInfoEmail.Name = "lblGeneralInfoEmail";
            this.lblGeneralInfoEmail.Size = new System.Drawing.Size(599, 20);
            this.lblGeneralInfoEmail.TabIndex = 8;
            this.lblGeneralInfoEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGeneralInfoWebsite
            // 
            this.lblGeneralInfoWebsite.AutoSize = true;
            this.lblGeneralInfoWebsite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGeneralInfoWebsite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGeneralInfoWebsite.Location = new System.Drawing.Point(154, 60);
            this.lblGeneralInfoWebsite.Name = "lblGeneralInfoWebsite";
            this.lblGeneralInfoWebsite.Size = new System.Drawing.Size(599, 20);
            this.lblGeneralInfoWebsite.TabIndex = 9;
            this.lblGeneralInfoWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGeneralInfoNumMem
            // 
            this.lblGeneralInfoNumMem.AutoSize = true;
            this.lblGeneralInfoNumMem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGeneralInfoNumMem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGeneralInfoNumMem.Location = new System.Drawing.Point(154, 80);
            this.lblGeneralInfoNumMem.Name = "lblGeneralInfoNumMem";
            this.lblGeneralInfoNumMem.Size = new System.Drawing.Size(599, 20);
            this.lblGeneralInfoNumMem.TabIndex = 10;
            this.lblGeneralInfoNumMem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGeneralInfoNumCalls
            // 
            this.lblGeneralInfoNumCalls.AutoSize = true;
            this.lblGeneralInfoNumCalls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGeneralInfoNumCalls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGeneralInfoNumCalls.Location = new System.Drawing.Point(154, 100);
            this.lblGeneralInfoNumCalls.Name = "lblGeneralInfoNumCalls";
            this.lblGeneralInfoNumCalls.Size = new System.Drawing.Size(599, 21);
            this.lblGeneralInfoNumCalls.TabIndex = 11;
            this.lblGeneralInfoNumCalls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 601);
            this.Controls.Add(this.tbcMainTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "RitEdu client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.tbcMainTabs.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.TabControl tbcMainTabs;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabLocation;
        private System.Windows.Forms.TabPage tabTraining;
        private System.Windows.Forms.TabPage tabTreatment;
        private System.Windows.Forms.TabPage tabFacilities;
        private System.Windows.Forms.TabPage tabEquipment;
        private System.Windows.Forms.TabPage tabPhysicians;
        private System.Windows.Forms.TabPage tabPeople;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGeneralInfoName;
        private System.Windows.Forms.Label lblGeneralInfoDescription;
        private System.Windows.Forms.Label lblGeneralInfoEmail;
        private System.Windows.Forms.Label lblGeneralInfoWebsite;
        private System.Windows.Forms.Label lblGeneralInfoNumMem;
        private System.Windows.Forms.Label lblGeneralInfoNumCalls;
    }
}

