namespace ScriptEditor
{
    partial class FormTextFinder
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
            this.columnText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnChatType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLanguage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnText,
            this.columnChatType,
            this.columnLanguage});
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
            // FormTextFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(672, 393);
            this.Name = "FormTextFinder";
            this.Text = "Text Finder";
            this.ResizeEnd += new System.EventHandler(this.FormTextFinder_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnText;
        private System.Windows.Forms.ColumnHeader columnChatType;
        private System.Windows.Forms.ColumnHeader columnLanguage;
    }
}
