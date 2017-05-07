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
            this.orgName = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.CountyComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchZip = new System.Windows.Forms.TextBox();
            this.Zip = new System.Windows.Forms.Label();
            this.county = new System.Windows.Forms.Label();
            this.StateComboBox = new System.Windows.Forms.ComboBox();
            this.state = new System.Windows.Forms.Label();
            this.organizationName = new System.Windows.Forms.Label();
            this.organizationType = new System.Windows.Forms.Label();
            this.cmbOrgType = new System.Windows.Forms.ComboBox();
            this.Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Controls.Add(this.orgName);
            this.Search.Controls.Add(this.resetButton);
            this.Search.Controls.Add(this.CountyComboBox);
            this.Search.Controls.Add(this.searchButton);
            this.Search.Controls.Add(this.searchZip);
            this.Search.Controls.Add(this.Zip);
            this.Search.Controls.Add(this.county);
            this.Search.Controls.Add(this.StateComboBox);
            this.Search.Controls.Add(this.state);
            this.Search.Controls.Add(this.organizationName);
            this.Search.Controls.Add(this.organizationType);
            this.Search.Controls.Add(this.cmbOrgType);
            this.Search.Location = new System.Drawing.Point(27, 23);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(478, 263);
            this.Search.TabIndex = 11;
            this.Search.TabStop = false;
            this.Search.Text = "Search";
            // 
            // orgName
            // 
            this.orgName.Location = new System.Drawing.Point(182, 67);
            this.orgName.Name = "orgName";
            this.orgName.Size = new System.Drawing.Size(121, 20);
            this.orgName.TabIndex = 20;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(360, 225);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(97, 32);
            this.resetButton.TabIndex = 19;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // CountyComboBox
            // 
            this.CountyComboBox.FormattingEnabled = true;
            this.CountyComboBox.Location = new System.Drawing.Point(182, 146);
            this.CountyComboBox.Name = "CountyComboBox";
            this.CountyComboBox.Size = new System.Drawing.Size(121, 21);
            this.CountyComboBox.TabIndex = 18;
            this.CountyComboBox.Text = "-- select any value --";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(244, 225);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(97, 32);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchZip
            // 
            this.searchZip.Location = new System.Drawing.Point(182, 189);
            this.searchZip.Name = "searchZip";
            this.searchZip.Size = new System.Drawing.Size(121, 20);
            this.searchZip.TabIndex = 17;
            // 
            // Zip
            // 
            this.Zip.AutoSize = true;
            this.Zip.Location = new System.Drawing.Point(6, 189);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(22, 13);
            this.Zip.TabIndex = 15;
            this.Zip.Text = "Zip";
            // 
            // county
            // 
            this.county.AutoSize = true;
            this.county.Location = new System.Drawing.Point(6, 154);
            this.county.Name = "county";
            this.county.Size = new System.Drawing.Size(40, 13);
            this.county.TabIndex = 14;
            this.county.Text = "County";
            // 
            // StateComboBox
            // 
            this.StateComboBox.FormattingEnabled = true;
            this.StateComboBox.Location = new System.Drawing.Point(182, 106);
            this.StateComboBox.Name = "StateComboBox";
            this.StateComboBox.Size = new System.Drawing.Size(121, 21);
            this.StateComboBox.TabIndex = 13;
            this.StateComboBox.Text = "-- select any value --";
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(6, 114);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(32, 13);
            this.state.TabIndex = 12;
            this.state.Text = "State";
            // 
            // organizationName
            // 
            this.organizationName.AutoSize = true;
            this.organizationName.Location = new System.Drawing.Point(6, 74);
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
            this.cmbOrgType.Location = new System.Drawing.Point(182, 27);
            this.cmbOrgType.Name = "cmbOrgType";
            this.cmbOrgType.Size = new System.Drawing.Size(121, 21);
            this.cmbOrgType.TabIndex = 7;
            this.cmbOrgType.Text = "-- select any value --";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 405);
            this.Controls.Add(this.Search);
            this.Name = "MainForm";
            this.Text = "RitEdu client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Search;
        private System.Windows.Forms.TextBox orgName;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ComboBox CountyComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchZip;
        private System.Windows.Forms.Label Zip;
        private System.Windows.Forms.Label county;
        private System.Windows.Forms.ComboBox StateComboBox;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.Label organizationName;
        private System.Windows.Forms.Label organizationType;
        private System.Windows.Forms.ComboBox cmbOrgType;
    }
}

