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
            this.pdgvLocations = new RitEduClient.PagedDataGridView();
            this.kpnlLocations = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kpnlLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // pdgvLocations
            // 
            this.pdgvLocations.BackColor = System.Drawing.SystemColors.Control;
            this.pdgvLocations.DataSetId = null;
            this.pdgvLocations.DefaultColumnSortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pdgvLocations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pdgvLocations.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdgvLocations.Location = new System.Drawing.Point(0, 194);
            this.pdgvLocations.Name = "pdgvLocations";
            this.pdgvLocations.PageSize = 0;
            this.pdgvLocations.Size = new System.Drawing.Size(798, 266);
            this.pdgvLocations.TabIndex = 1;
            // 
            // kpnlLocations
            // 
            this.kpnlLocations.Dock = System.Windows.Forms.DockStyle.Top;
            this.kpnlLocations.Location = new System.Drawing.Point(0, 0);
            this.kpnlLocations.Name = "kpnlLocations";
            this.kpnlLocations.Size = new System.Drawing.Size(798, 188);
            this.kpnlLocations.TabIndex = 2;
            // 
            // LocationTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kpnlLocations);
            this.Controls.Add(this.pdgvLocations);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LocationTab";
            this.Size = new System.Drawing.Size(798, 460);
            ((System.ComponentModel.ISupportInitialize)(this.kpnlLocations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PagedDataGridView pdgvLocations;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kpnlLocations;
    }
}
