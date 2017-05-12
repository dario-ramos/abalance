namespace RitEduClient.Views
{
    partial class PhysicianTab
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
            this.pdgvPhysicians = new RitEduClient.PagedDataGridView();
            this.SuspendLayout();
            // 
            // pdgvPhysicians
            // 
            this.pdgvPhysicians.DataSetId = null;
            this.pdgvPhysicians.DefaultColumnSortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pdgvPhysicians.Location = new System.Drawing.Point(0, 3);
            this.pdgvPhysicians.Name = "pdgvPhysicians";
            this.pdgvPhysicians.PageSize = 0;
            this.pdgvPhysicians.Size = new System.Drawing.Size(795, 454);
            this.pdgvPhysicians.TabIndex = 0;
            // 
            // PhysicianTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pdgvPhysicians);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PhysicianTab";
            this.Size = new System.Drawing.Size(798, 460);
            this.ResumeLayout(false);

        }

        #endregion

        private PagedDataGridView pdgvPhysicians;
    }
}
