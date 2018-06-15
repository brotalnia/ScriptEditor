namespace ScriptEditor
{
    partial class FormConditionFinder
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
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValue1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValue2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFlags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValue3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValue4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnType,
            this.columnValue1,
            this.columnValue2,
            this.columnValue3,
            this.columnValue4,
            this.columnFlags});
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.Text = "Enter Id to search for:";
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            this.columnType.Width = 145;
            // 
            // columnValue1
            // 
            this.columnValue1.Text = "Value 1";
            this.columnValue1.Width = 90;
            // 
            // columnValue2
            // 
            this.columnValue2.Text = "Value 2";
            this.columnValue2.Width = 90;
            // 
            // columnFlags
            // 
            this.columnFlags.Text = "Flags";
            this.columnFlags.Width = 90;
            // 
            // columnValue3
            // 
            this.columnValue3.Text = "Value 3";
            this.columnValue3.Width = 90;
            // 
            // columnValue4
            // 
            this.columnValue4.Text = "Value 4";
            this.columnValue4.Width = 90;
            // 
            // FormConditionFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 393);
            this.Name = "FormConditionFinder";
            this.Text = "Condition Finder";
            this.ResizeEnd += new System.EventHandler(this.FormConditionFinder_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnValue1;
        private System.Windows.Forms.ColumnHeader columnValue2;
        private System.Windows.Forms.ColumnHeader columnFlags;
        private System.Windows.Forms.ColumnHeader columnValue3;
        private System.Windows.Forms.ColumnHeader columnValue4;
    }
}
