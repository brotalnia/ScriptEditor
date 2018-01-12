namespace ScriptEditor
{
    partial class FormTextSearcher
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
            this.lstBroadcastTexts = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnChatType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLanguage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSelectNone = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBroadcastTexts
            // 
            this.lstBroadcastTexts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnText,
            this.columnChatType,
            this.columnLanguage});
            this.lstBroadcastTexts.FullRowSelect = true;
            this.lstBroadcastTexts.GridLines = true;
            this.lstBroadcastTexts.HideSelection = false;
            this.lstBroadcastTexts.Location = new System.Drawing.Point(12, 56);
            this.lstBroadcastTexts.Name = "lstBroadcastTexts";
            this.lstBroadcastTexts.Size = new System.Drawing.Size(650, 300);
            this.lstBroadcastTexts.TabIndex = 0;
            this.lstBroadcastTexts.UseCompatibleStateImageBehavior = false;
            this.lstBroadcastTexts.View = System.Windows.Forms.View.Details;
            this.lstBroadcastTexts.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstBroadcastTexts_ColumnClick);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 49;
            // 
            // columnText
            // 
            this.columnText.Text = "Text";
            this.columnText.Width = 415;
            // 
            // columnChatType
            // 
            this.columnChatType.Text = "Chat Type";
            this.columnChatType.Width = 90;
            // 
            // columnLanguage
            // 
            this.columnLanguage.Text = "Language";
            this.columnLanguage.Width = 90;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(560, 20);
            this.txtSearch.TabIndex = 1;
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
            this.btnSelectNone.Location = new System.Drawing.Point(411, 361);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(88, 23);
            this.btnSelectNone.TabIndex = 3;
            this.btnSelectNone.Text = "Select -NONE-";
            this.btnSelectNone.UseVisualStyleBackColor = true;
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(505, 361);
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
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter partial text or Id to search for:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(586, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormTextSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 391);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSelectNone);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstBroadcastTexts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTextSearcher";
            this.Text = "Text Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstBroadcastTexts;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnText;
        private System.Windows.Forms.ColumnHeader columnChatType;
        private System.Windows.Forms.ColumnHeader columnLanguage;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSelectNone;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
    }
}