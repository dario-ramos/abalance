﻿namespace RitEduClient.Views
{
    partial class TreatmentTab
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
            this.pdgvTreatments = new RitEduClient.PagedDataGridView();
            this.SuspendLayout();
            // 
            // pdgvTreatments
            // 
            this.pdgvTreatments.BackColor = System.Drawing.SystemColors.Control;
            this.pdgvTreatments.DataSetId = null;
            this.pdgvTreatments.DefaultColumnSortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pdgvTreatments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdgvTreatments.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdgvTreatments.Location = new System.Drawing.Point(0, 0);
            this.pdgvTreatments.Name = "pdgvTreatments";
            this.pdgvTreatments.PageSize = 0;
            this.pdgvTreatments.Size = new System.Drawing.Size(798, 460);
            this.pdgvTreatments.TabIndex = 0;
            // 
            // TreatmentTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pdgvTreatments);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TreatmentTab";
            this.Size = new System.Drawing.Size(798, 460);
            this.ResumeLayout(false);

        }

        #endregion

        private PagedDataGridView pdgvTreatments;
    }
}
