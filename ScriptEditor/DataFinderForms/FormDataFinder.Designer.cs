namespace ScriptEditor
{
    partial class FormDataFinder
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
            this.lstData = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSelectNone = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelectUnchanged = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID});
            this.lstData.FullRowSelect = true;
            this.lstData.GridLines = true;
            this.lstData.HideSelection = false;
            this.lstData.Location = new System.Drawing.Point(12, 56);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(650, 305);
            this.lstData.TabIndex = 0;
            this.lstData.UseCompatibleStateImageBehavior = false;
            this.lstData.View = System.Windows.Forms.View.Details;
            this.lstData.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstData_ColumnClick);
            this.lstData.ItemActivate += new System.EventHandler(this.lstData_ItemActivate);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 49;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(560, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(579, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Location = new System.Drawing.Point(411, 367);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(88, 23);
            this.btnSelectNone.TabIndex = 3;
            this.btnSelectNone.Text = "Select -NONE-";
            this.btnSelectNone.UseVisualStyleBackColor = true;
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(505, 367);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter text or Id to search for:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(586, 367);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelectUnchanged
            // 
            this.btnSelectUnchanged.Location = new System.Drawing.Point(305, 367);
            this.btnSelectUnchanged.Name = "btnSelectUnchanged";
            this.btnSelectUnchanged.Size = new System.Drawing.Size(100, 23);
            this.btnSelectUnchanged.TabIndex = 8;
            this.btnSelectUnchanged.Text = "Select -IGNORE-";
            this.btnSelectUnchanged.UseVisualStyleBackColor = true;
            this.btnSelectUnchanged.Visible = false;
            this.btnSelectUnchanged.Click += new System.EventHandler(this.btnSelectUnchanged_Click);
            // 
            // FormDataFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 393);
            this.ControlBox = false;
            this.Controls.Add(this.btnSelectUnchanged);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSelectNone);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstData);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDataFinder";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Data Finder";
            this.ResizeEnd += new System.EventHandler(this.FormDataFinder_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ListView lstData;
        protected System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSelect;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.Button btnSelectNone;
        private System.Windows.Forms.Button btnSelectUnchanged;
    }
}