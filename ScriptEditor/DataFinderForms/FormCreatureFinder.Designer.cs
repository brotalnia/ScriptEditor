namespace ScriptEditor
{
    partial class FormCreatureFinder
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
            this.columnLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnLevel,
            this.columnRank,
            this.columnName});
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.Text = "Enter name or Id to search for:";
            // 
            // columnLevel
            // 
            this.columnLevel.Text = "Level";
            this.columnLevel.Width = 90;
            // 
            // columnRank
            // 
            this.columnRank.Text = "Rank";
            this.columnRank.Width = 90;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 415;
            // 
            // FormCreatureFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 393);
            this.Name = "FormCreatureFinder";
            this.Text = "Creature Finder";
            this.ResizeEnd += new System.EventHandler(this.FormCreatureFinder_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnLevel;
        private System.Windows.Forms.ColumnHeader columnRank;
        private System.Windows.Forms.ColumnHeader columnName;
    }
}
