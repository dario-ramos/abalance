namespace RitEduClient.Views
{
    partial class EquipmentTab
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
            this.pdgvEquipments = new RitEduClient.PagedDataGridView();
            this.SuspendLayout();
            // 
            // pdgvEquipments
            // 
            this.pdgvEquipments.BackColor = System.Drawing.SystemColors.Control;
            this.pdgvEquipments.DataSetId = null;
            this.pdgvEquipments.DefaultColumnSortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pdgvEquipments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdgvEquipments.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdgvEquipments.Location = new System.Drawing.Point(0, 0);
            this.pdgvEquipments.Name = "pdgvEquipments";
            this.pdgvEquipments.PageSize = 0;
            this.pdgvEquipments.Size = new System.Drawing.Size(798, 460);
            this.pdgvEquipments.TabIndex = 0;
            // 
            // EquipmentTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pdgvEquipments);
            this.Name = "EquipmentTab";
            this.Size = new System.Drawing.Size(798, 460);
            this.ResumeLayout(false);

        }

        #endregion

        private PagedDataGridView pdgvEquipments;
    }
}
