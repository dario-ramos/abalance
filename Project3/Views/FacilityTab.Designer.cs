﻿namespace RitEduClient.Views
{
    partial class FacilityTab
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
            this.pdgvFacilities = new RitEduClient.PagedDataGridView();
            this.SuspendLayout();
            // 
            // pdgvFacilities
            // 
            this.pdgvFacilities.DataSetId = null;
            this.pdgvFacilities.DefaultColumnSortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pdgvFacilities.Location = new System.Drawing.Point(0, 3);
            this.pdgvFacilities.Name = "pdgvFacilities";
            this.pdgvFacilities.PageSize = 0;
            this.pdgvFacilities.Size = new System.Drawing.Size(795, 454);
            this.pdgvFacilities.TabIndex = 0;
            // 
            // FacilityTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pdgvFacilities);
            this.Name = "FacilityTab";
            this.Size = new System.Drawing.Size(798, 460);
            this.ResumeLayout(false);

        }

        #endregion

        private PagedDataGridView pdgvFacilities;
    }
}
