namespace RitEduClient.Views
{
    partial class PeopleTab
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
            this.pdgvPeople = new RitEduClient.PagedDataGridView();
            this.SuspendLayout();
            // 
            // pdgvPeople
            // 
            this.pdgvPeople.DataSetId = null;
            this.pdgvPeople.DefaultColumnSortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pdgvPeople.Location = new System.Drawing.Point(0, 3);
            this.pdgvPeople.Name = "pdgvPeople";
            this.pdgvPeople.PageSize = 0;
            this.pdgvPeople.Size = new System.Drawing.Size(795, 454);
            this.pdgvPeople.TabIndex = 0;
            // 
            // PeopleTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pdgvPeople);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PeopleTab";
            this.Size = new System.Drawing.Size(798, 460);
            this.ResumeLayout(false);

        }

        #endregion

        private PagedDataGridView pdgvPeople;
    }
}
