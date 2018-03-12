namespace ScriptEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picScriptEditor = new System.Windows.Forms.PictureBox();
            this.picEventEditor = new System.Windows.Forms.PictureBox();
            this.picGitLink = new System.Windows.Forms.PictureBox();
            this.picCastsEditor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picScriptEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEventEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGitLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCastsEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // picScriptEditor
            // 
            this.picScriptEditor.BackColor = System.Drawing.Color.Transparent;
            this.picScriptEditor.BackgroundImage = global::ScriptEditor.Properties.Resources.script_editor_button_black;
            this.picScriptEditor.InitialImage = null;
            this.picScriptEditor.Location = new System.Drawing.Point(17, 126);
            this.picScriptEditor.Name = "picScriptEditor";
            this.picScriptEditor.Size = new System.Drawing.Size(138, 97);
            this.picScriptEditor.TabIndex = 0;
            this.picScriptEditor.TabStop = false;
            this.picScriptEditor.Click += new System.EventHandler(this.picScriptEditor_Click);
            this.picScriptEditor.MouseEnter += new System.EventHandler(this.picScriptEditor_MouseEnter);
            this.picScriptEditor.MouseLeave += new System.EventHandler(this.picScriptEditor_MouseLeave);
            // 
            // picEventEditor
            // 
            this.picEventEditor.BackColor = System.Drawing.Color.Transparent;
            this.picEventEditor.BackgroundImage = global::ScriptEditor.Properties.Resources.event_editor_button_black;
            this.picEventEditor.InitialImage = null;
            this.picEventEditor.Location = new System.Drawing.Point(175, 126);
            this.picEventEditor.Name = "picEventEditor";
            this.picEventEditor.Size = new System.Drawing.Size(138, 97);
            this.picEventEditor.TabIndex = 1;
            this.picEventEditor.TabStop = false;
            this.picEventEditor.Click += new System.EventHandler(this.picEventEditor_Click);
            this.picEventEditor.MouseEnter += new System.EventHandler(this.picEventEditor_MouseEnter);
            this.picEventEditor.MouseLeave += new System.EventHandler(this.picEventEditor_MouseLeave);
            // 
            // picGitLink
            // 
            this.picGitLink.BackColor = System.Drawing.Color.Transparent;
            this.picGitLink.BackgroundImage = global::ScriptEditor.Properties.Resources.gitlink1;
            this.picGitLink.Location = new System.Drawing.Point(8, 15);
            this.picGitLink.Name = "picGitLink";
            this.picGitLink.Size = new System.Drawing.Size(314, 47);
            this.picGitLink.TabIndex = 2;
            this.picGitLink.TabStop = false;
            this.picGitLink.Click += new System.EventHandler(this.picGitLink_Click);
            this.picGitLink.MouseEnter += new System.EventHandler(this.picGitLink_MouseEnter);
            this.picGitLink.MouseLeave += new System.EventHandler(this.picGitLink_MouseLeave);
            // 
            // picCastsEditor
            // 
            this.picCastsEditor.BackColor = System.Drawing.Color.Transparent;
            this.picCastsEditor.BackgroundImage = global::ScriptEditor.Properties.Resources.cast_editor_button_black;
            this.picCastsEditor.InitialImage = null;
            this.picCastsEditor.Location = new System.Drawing.Point(96, 233);
            this.picCastsEditor.Name = "picCastsEditor";
            this.picCastsEditor.Size = new System.Drawing.Size(138, 97);
            this.picCastsEditor.TabIndex = 3;
            this.picCastsEditor.TabStop = false;
            this.picCastsEditor.Click += new System.EventHandler(this.picCastsEditor_Click);
            this.picCastsEditor.MouseEnter += new System.EventHandler(this.picCastsEditor_MouseEnter);
            this.picCastsEditor.MouseLeave += new System.EventHandler(this.picCastsEditor_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ScriptEditor.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(330, 371);
            this.Controls.Add(this.picCastsEditor);
            this.Controls.Add(this.picGitLink);
            this.Controls.Add(this.picEventEditor);
            this.Controls.Add(this.picScriptEditor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Light\'s Hope Developer Tools";
            ((System.ComponentModel.ISupportInitialize)(this.picScriptEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEventEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGitLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCastsEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picScriptEditor;
        private System.Windows.Forms.PictureBox picEventEditor;
        private System.Windows.Forms.PictureBox picGitLink;
        private System.Windows.Forms.PictureBox picCastsEditor;
    }
}