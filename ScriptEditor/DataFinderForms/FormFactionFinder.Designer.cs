namespace ScriptEditor
{
    partial class FormFactionFinder
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
            this.columnTeamId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnReputationId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnReputationId,
            this.columnTeamId,
            this.columnName,
            this.columnDescription});
            // 
            // columnTeamId
            // 
            this.columnTeamId.Text = "Team ID";
            this.columnTeamId.Width = 90;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 150;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            this.columnDescription.Width = 265;
            // 
            // columnReputationId
            // 
            this.columnReputationId.Text = "Reputation ID";
            this.columnReputationId.Width = 90;
            // 
            // FormFactionFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 393);
            this.Name = "FormFactionFinder";
            this.Text = "Faction Template Finder";
            this.ResizeEnd += new System.EventHandler(this.FormFactionFinder_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnTeamId;
        private System.Windows.Forms.ColumnHeader columnReputationId;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDescription;
    }
}
