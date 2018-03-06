namespace ScriptEditor
{
    partial class FormEventFinder
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
            this.columnOccurrence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPatchMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPatchMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOccurrence,
            this.columnLength,
            this.columnName,
            this.columnPatchMin,
            this.columnPatchMax});
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.Text = "Enter name or Id to search for:";
            // 
            // columnOccurrence
            // 
            this.columnOccurrence.Text = "Occurrence";
            this.columnOccurrence.Width = 90;
            // 
            // columnLength
            // 
            this.columnLength.Text = "Length";
            this.columnLength.Width = 90;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 235;
            // 
            // columnPatchMin
            // 
            this.columnPatchMin.Text = "Patch Min";
            this.columnPatchMin.Width = 90;
            // 
            // columnPatchMax
            // 
            this.columnPatchMax.Text = "Patch Max";
            this.columnPatchMax.Width = 90;
            // 
            // FormEventFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 393);
            this.Name = "FormEventFinder";
            this.Text = "Event Finder";
            this.ResizeEnd += new System.EventHandler(this.FormEventFinder_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnOccurrence;
        private System.Windows.Forms.ColumnHeader columnLength;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPatchMin;
        private System.Windows.Forms.ColumnHeader columnPatchMax;
    }
}
