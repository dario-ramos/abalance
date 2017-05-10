namespace RitEduClient.Views
{
    partial class LocationTab
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pdgvLocations = new RitEduClient.PagedDataGridView();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(27, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 221);
            this.panel1.TabIndex = 0;
            // 
            // pdgvLocations
            // 
            this.pdgvLocations.DefaultColumnSortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pdgvLocations.Location = new System.Drawing.Point(12, 241);
            this.pdgvLocations.Name = "pdgvLocations";
            this.pdgvLocations.PageSize = 0;
            this.pdgvLocations.Size = new System.Drawing.Size(766, 204);
            this.pdgvLocations.TabIndex = 1;
            // 
            // LocationTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pdgvLocations);
            this.Controls.Add(this.panel1);
            this.Name = "LocationTab";
            this.Size = new System.Drawing.Size(798, 460);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private PagedDataGridView pdgvLocations;
    }
}
