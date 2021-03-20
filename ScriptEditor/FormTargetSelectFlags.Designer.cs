namespace ScriptEditor
{
    partial class FormTargetSelectFlags
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
            this.chkFlag1 = new System.Windows.Forms.CheckBox();
            this.chkFlag2 = new System.Windows.Forms.CheckBox();
            this.chkFlag4 = new System.Windows.Forms.CheckBox();
            this.chkFlag8 = new System.Windows.Forms.CheckBox();
            this.chkFlag16 = new System.Windows.Forms.CheckBox();
            this.chkFlag32 = new System.Windows.Forms.CheckBox();
            this.chkFlag128 = new System.Windows.Forms.CheckBox();
            this.chkFlag64 = new System.Windows.Forms.CheckBox();
            this.chkFlag512 = new System.Windows.Forms.CheckBox();
            this.chkFlag256 = new System.Windows.Forms.CheckBox();
            this.chkFlag2048 = new System.Windows.Forms.CheckBox();
            this.chkFlag1024 = new System.Windows.Forms.CheckBox();
            this.chkFlag8192 = new System.Windows.Forms.CheckBox();
            this.chkFlag4096 = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkFlag1
            // 
            this.chkFlag1.AutoSize = true;
            this.chkFlag1.Location = new System.Drawing.Point(40, 30);
            this.chkFlag1.Name = "chkFlag1";
            this.chkFlag1.Size = new System.Drawing.Size(97, 17);
            this.chkFlag1.TabIndex = 0;
            this.chkFlag1.Text = "In Line of Sight";
            this.chkFlag1.UseVisualStyleBackColor = true;
            this.chkFlag1.CheckedChanged += new System.EventHandler(this.chkFlag1_CheckedChanged);
            // 
            // chkFlag2
            // 
            this.chkFlag2.AutoSize = true;
            this.chkFlag2.Location = new System.Drawing.Point(205, 30);
            this.chkFlag2.Name = "chkFlag2";
            this.chkFlag2.Size = new System.Drawing.Size(55, 17);
            this.chkFlag2.TabIndex = 1;
            this.chkFlag2.Text = "Player";
            this.chkFlag2.UseVisualStyleBackColor = true;
            this.chkFlag2.CheckedChanged += new System.EventHandler(this.chkFlag2_CheckedChanged);
            // 
            // chkFlag4
            // 
            this.chkFlag4.AutoSize = true;
            this.chkFlag4.Location = new System.Drawing.Point(40, 70);
            this.chkFlag4.Name = "chkFlag4";
            this.chkFlag4.Size = new System.Drawing.Size(86, 17);
            this.chkFlag4.TabIndex = 2;
            this.chkFlag4.Text = "Power Mana";
            this.chkFlag4.UseVisualStyleBackColor = true;
            this.chkFlag4.CheckedChanged += new System.EventHandler(this.chkFlag4_CheckedChanged);
            // 
            // chkFlag8
            // 
            this.chkFlag8.AutoSize = true;
            this.chkFlag8.Location = new System.Drawing.Point(205, 70);
            this.chkFlag8.Name = "chkFlag8";
            this.chkFlag8.Size = new System.Drawing.Size(85, 17);
            this.chkFlag8.TabIndex = 3;
            this.chkFlag8.Text = "Power Rage";
            this.chkFlag8.UseVisualStyleBackColor = true;
            this.chkFlag8.CheckedChanged += new System.EventHandler(this.chkFlag8_CheckedChanged);
            // 
            // chkFlag16
            // 
            this.chkFlag16.AutoSize = true;
            this.chkFlag16.Location = new System.Drawing.Point(40, 110);
            this.chkFlag16.Name = "chkFlag16";
            this.chkFlag16.Size = new System.Drawing.Size(92, 17);
            this.chkFlag16.TabIndex = 4;
            this.chkFlag16.Text = "Power Energy";
            this.chkFlag16.UseVisualStyleBackColor = true;
            this.chkFlag16.CheckedChanged += new System.EventHandler(this.chkFlag16_CheckedChanged);
            // 
            // chkFlag32
            // 
            this.chkFlag32.AutoSize = true;
            this.chkFlag32.Location = new System.Drawing.Point(205, 110);
            this.chkFlag32.Name = "chkFlag32";
            this.chkFlag32.Size = new System.Drawing.Size(101, 17);
            this.chkFlag32.TabIndex = 5;
            this.chkFlag32.Text = "Unused Flag 32";
            this.chkFlag32.UseVisualStyleBackColor = true;
            this.chkFlag32.CheckedChanged += new System.EventHandler(this.chkFlag32_CheckedChanged);
            // 
            // chkFlag128
            // 
            this.chkFlag128.AutoSize = true;
            this.chkFlag128.Location = new System.Drawing.Point(205, 150);
            this.chkFlag128.Name = "chkFlag128";
            this.chkFlag128.Size = new System.Drawing.Size(122, 17);
            this.chkFlag128.TabIndex = 7;
            this.chkFlag128.Text = "Not In Melee Range";
            this.chkFlag128.UseVisualStyleBackColor = true;
            this.chkFlag128.CheckedChanged += new System.EventHandler(this.chkFlag128_CheckedChanged);
            // 
            // chkFlag64
            // 
            this.chkFlag64.AutoSize = true;
            this.chkFlag64.Location = new System.Drawing.Point(40, 150);
            this.chkFlag64.Name = "chkFlag64";
            this.chkFlag64.Size = new System.Drawing.Size(102, 17);
            this.chkFlag64.TabIndex = 6;
            this.chkFlag64.Text = "In Melee Range";
            this.chkFlag64.UseVisualStyleBackColor = true;
            this.chkFlag64.CheckedChanged += new System.EventHandler(this.chkFlag64_CheckedChanged);
            // 
            // chkFlag512
            // 
            this.chkFlag512.AutoSize = true;
            this.chkFlag512.Location = new System.Drawing.Point(205, 190);
            this.chkFlag512.Name = "chkFlag512";
            this.chkFlag512.Size = new System.Drawing.Size(105, 17);
            this.chkFlag512.TabIndex = 9;
            this.chkFlag512.Text = "Not Gamemaster";
            this.chkFlag512.UseVisualStyleBackColor = true;
            this.chkFlag512.CheckedChanged += new System.EventHandler(this.chkFlag512_CheckedChanged);
            // 
            // chkFlag256
            // 
            this.chkFlag256.AutoSize = true;
            this.chkFlag256.Location = new System.Drawing.Point(40, 190);
            this.chkFlag256.Name = "chkFlag256";
            this.chkFlag256.Size = new System.Drawing.Size(73, 17);
            this.chkFlag256.TabIndex = 8;
            this.chkFlag256.Text = "No Totem";
            this.chkFlag256.UseVisualStyleBackColor = true;
            this.chkFlag256.CheckedChanged += new System.EventHandler(this.chkFlag256_CheckedChanged);
            // 
            // chkFlag2048
            // 
            this.chkFlag2048.AutoSize = true;
            this.chkFlag2048.Location = new System.Drawing.Point(205, 230);
            this.chkFlag2048.Name = "chkFlag2048";
            this.chkFlag2048.Size = new System.Drawing.Size(75, 17);
            this.chkFlag2048.TabIndex = 11;
            this.chkFlag2048.Text = "Not Player";
            this.chkFlag2048.UseVisualStyleBackColor = true;
            this.chkFlag2048.CheckedChanged += new System.EventHandler(this.chkFlag2048_CheckedChanged);
            // 
            // chkFlag1024
            // 
            this.chkFlag1024.AutoSize = true;
            this.chkFlag1024.Location = new System.Drawing.Point(40, 230);
            this.chkFlag1024.Name = "chkFlag1024";
            this.chkFlag1024.Size = new System.Drawing.Size(42, 17);
            this.chkFlag1024.TabIndex = 10;
            this.chkFlag1024.Text = "Pet";
            this.chkFlag1024.UseVisualStyleBackColor = true;
            this.chkFlag1024.CheckedChanged += new System.EventHandler(this.chkFlag1024_CheckedChanged);
            // 
            // chkFlag8192
            // 
            this.chkFlag8192.AutoSize = true;
            this.chkFlag8192.Location = new System.Drawing.Point(205, 270);
            this.chkFlag8192.Name = "chkFlag8192";
            this.chkFlag8192.Size = new System.Drawing.Size(113, 17);
            this.chkFlag8192.TabIndex = 13;
            this.chkFlag8192.Text = "Unused Flag 8192";
            this.chkFlag8192.UseVisualStyleBackColor = true;
            this.chkFlag8192.CheckedChanged += new System.EventHandler(this.chkFlag8192_CheckedChanged);
            // 
            // chkFlag4096
            // 
            this.chkFlag4096.AutoSize = true;
            this.chkFlag4096.Location = new System.Drawing.Point(40, 270);
            this.chkFlag4096.Name = "chkFlag4096";
            this.chkFlag4096.Size = new System.Drawing.Size(106, 17);
            this.chkFlag4096.TabIndex = 12;
            this.chkFlag4096.Text = "Power Not Mana";
            this.chkFlag4096.UseVisualStyleBackColor = true;
            this.chkFlag4096.CheckedChanged += new System.EventHandler(this.chkFlag4096_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(109, 315);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(190, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormTargetSelectFlags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 355);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chkFlag8192);
            this.Controls.Add(this.chkFlag4096);
            this.Controls.Add(this.chkFlag2048);
            this.Controls.Add(this.chkFlag1024);
            this.Controls.Add(this.chkFlag512);
            this.Controls.Add(this.chkFlag256);
            this.Controls.Add(this.chkFlag128);
            this.Controls.Add(this.chkFlag64);
            this.Controls.Add(this.chkFlag32);
            this.Controls.Add(this.chkFlag16);
            this.Controls.Add(this.chkFlag8);
            this.Controls.Add(this.chkFlag4);
            this.Controls.Add(this.chkFlag2);
            this.Controls.Add(this.chkFlag1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormTargetSelectFlags";
            this.Text = "Target Selection Flags";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkFlag1;
        private System.Windows.Forms.CheckBox chkFlag2;
        private System.Windows.Forms.CheckBox chkFlag4;
        private System.Windows.Forms.CheckBox chkFlag8;
        private System.Windows.Forms.CheckBox chkFlag16;
        private System.Windows.Forms.CheckBox chkFlag32;
        private System.Windows.Forms.CheckBox chkFlag128;
        private System.Windows.Forms.CheckBox chkFlag64;
        private System.Windows.Forms.CheckBox chkFlag512;
        private System.Windows.Forms.CheckBox chkFlag256;
        private System.Windows.Forms.CheckBox chkFlag2048;
        private System.Windows.Forms.CheckBox chkFlag1024;
        private System.Windows.Forms.CheckBox chkFlag8192;
        private System.Windows.Forms.CheckBox chkFlag4096;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}