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
            this.Search = new System.Windows.Forms.GroupBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.txtOrgName = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.Zip = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.state = new System.Windows.Forms.Label();
            this.organizationName = new System.Windows.Forms.Label();
            this.organizationType = new System.Windows.Forms.Label();
            this.cmbOrgType = new System.Windows.Forms.ComboBox();
            this.Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Controls.Add(this.txtCounty);
            this.Search.Controls.Add(this.label1);
            this.Search.Controls.Add(this.cmbCity);
            this.Search.Controls.Add(this.txtOrgName);
            this.Search.Controls.Add(this.btnReset);
            this.Search.Controls.Add(this.searchButton);
            this.Search.Controls.Add(this.txtZip);
            this.Search.Controls.Add(this.Zip);
            this.Search.Controls.Add(this.cmbState);
            this.Search.Controls.Add(this.state);
            this.Search.Controls.Add(this.organizationName);
            this.Search.Controls.Add(this.organizationType);
            this.Search.Controls.Add(this.cmbOrgType);
            this.Search.Location = new System.Drawing.Point(27, 23);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(405, 251);
            this.Search.TabIndex = 11;
            this.Search.TabStop = false;
            this.Search.Text = "Search";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(116, 142);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(121, 20);
            this.txtCounty.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "County";
            // 
            // cmbCity
            // 
            this.cmbCity.Enabled = false;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(254, 107);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 21);
            this.cmbCity.TabIndex = 40;
            this.cmbCity.Text = "-- select any value --";
            // 
            // txtOrgName
            // 
            this.txtOrgName.Location = new System.Drawing.Point(116, 67);
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.Size = new System.Drawing.Size(121, 20);
            this.txtOrgName.TabIndex = 20;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(265, 213);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(97, 32);
            this.btnReset.TabIndex = 80;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(129, 213);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(97, 32);
            this.searchButton.TabIndex = 70;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(116, 176);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(121, 20);
            this.txtZip.TabIndex = 60;
            // 
            // Zip
            // 
            this.Zip.AutoSize = true;
            this.Zip.Location = new System.Drawing.Point(7, 179);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(22, 13);
            this.Zip.TabIndex = 15;
            this.Zip.Text = "Zip";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(116, 106);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(121, 21);
            this.cmbState.TabIndex = 30;
            this.cmbState.Text = "-- select any value --";
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(6, 110);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(52, 13);
            this.state.TabIndex = 12;
            this.state.Text = "State-City";
            // 
            // organizationName
            // 
            this.organizationName.AutoSize = true;
            this.organizationName.Location = new System.Drawing.Point(6, 69);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 296);
            this.Controls.Add(this.Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "RitEdu client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Search;
        private System.Windows.Forms.TextBox txtOrgName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button searchButton;
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
    }
}

