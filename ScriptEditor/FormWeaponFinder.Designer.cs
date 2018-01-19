namespace ScriptEditor
{
    partial class FormWeaponFinder
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
            this.btnSelectUnchanged = new System.Windows.Forms.Button();
            this.columnInventoryType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDisplayId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnInventoryType,
            this.columnDisplayId,
            this.columnName});
            // 
            // btnSelectUnchanged
            // 
            this.btnSelectUnchanged.Location = new System.Drawing.Point(271, 367);
            this.btnSelectUnchanged.Name = "btnSelectUnchanged";
            this.btnSelectUnchanged.Size = new System.Drawing.Size(134, 23);
            this.btnSelectUnchanged.TabIndex = 7;
            this.btnSelectUnchanged.Text = "Select - UNCHANGED-";
            this.btnSelectUnchanged.UseVisualStyleBackColor = true;
            this.btnSelectUnchanged.Click += new System.EventHandler(this.btnSelectUnchanged_Click);
            // 
            // columnInventoryType
            // 
            this.columnInventoryType.Text = "Type";
            this.columnInventoryType.Width = 90;
            // 
            // columnDisplayId
            // 
            this.columnDisplayId.Text = "Display Id";
            this.columnDisplayId.Width = 90;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 415;
            // 
            // FormWeaponFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 393);
            this.Controls.Add(this.btnSelectUnchanged);
            this.Name = "FormWeaponFinder";
            this.Text = "Weapon Finder";
            this.ResizeEnd += new System.EventHandler(this.FormWeaponFinder_ResizeEnd);
            this.Controls.SetChildIndex(this.lstData, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnSelectUnchanged, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectUnchanged;
        private System.Windows.Forms.ColumnHeader columnInventoryType;
        private System.Windows.Forms.ColumnHeader columnDisplayId;
        private System.Windows.Forms.ColumnHeader columnName;
    }
}
