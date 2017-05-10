namespace RitEduClient.Views
{
    partial class TrainingTab
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
            this.pdgvTraining = new RitEduClient.PagedDataGridView();
            this.SuspendLayout();
            // 
            // pdgvTraining
            // 
            this.pdgvTraining.DefaultColumnSortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pdgvTraining.Location = new System.Drawing.Point(19, 19);
            this.pdgvTraining.Name = "pdgvTraining";
            this.pdgvTraining.PageSize = 0;
            this.pdgvTraining.Size = new System.Drawing.Size(764, 420);
            this.pdgvTraining.TabIndex = 0;
            // 
            // TrainingTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pdgvTraining);
            this.Name = "TrainingTab";
            this.Size = new System.Drawing.Size(798, 460);
            this.ResumeLayout(false);

        }

        #endregion

        private PagedDataGridView pdgvTraining;
    }
}
