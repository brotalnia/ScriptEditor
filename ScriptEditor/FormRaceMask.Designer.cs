namespace ScriptEditor
{
    partial class FormRaceMask
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
            this.chkRace1 = new System.Windows.Forms.CheckBox();
            this.chkRace2 = new System.Windows.Forms.CheckBox();
            this.chkRace4 = new System.Windows.Forms.CheckBox();
            this.chkRace8 = new System.Windows.Forms.CheckBox();
            this.chkRace16 = new System.Windows.Forms.CheckBox();
            this.chkRace32 = new System.Windows.Forms.CheckBox();
            this.chkRace64 = new System.Windows.Forms.CheckBox();
            this.chkRace128 = new System.Windows.Forms.CheckBox();
            this.grpAlliance = new System.Windows.Forms.GroupBox();
            this.grpHorde = new System.Windows.Forms.GroupBox();
            this.lblTooltip = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpAlliance.SuspendLayout();
            this.grpHorde.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkRace1
            // 
            this.chkRace1.AutoSize = true;
            this.chkRace1.Location = new System.Drawing.Point(6, 19);
            this.chkRace1.Name = "chkRace1";
            this.chkRace1.Size = new System.Drawing.Size(60, 17);
            this.chkRace1.TabIndex = 0;
            this.chkRace1.Text = "Human";
            this.chkRace1.UseVisualStyleBackColor = true;
            this.chkRace1.CheckedChanged += new System.EventHandler(this.chkRace1_CheckedChanged);
            // 
            // chkRace2
            // 
            this.chkRace2.AutoSize = true;
            this.chkRace2.Location = new System.Drawing.Point(6, 19);
            this.chkRace2.Name = "chkRace2";
            this.chkRace2.Size = new System.Drawing.Size(43, 17);
            this.chkRace2.TabIndex = 1;
            this.chkRace2.Text = "Orc";
            this.chkRace2.UseVisualStyleBackColor = true;
            this.chkRace2.CheckedChanged += new System.EventHandler(this.chkRace2_CheckedChanged);
            // 
            // chkRace4
            // 
            this.chkRace4.AutoSize = true;
            this.chkRace4.Location = new System.Drawing.Point(6, 42);
            this.chkRace4.Name = "chkRace4";
            this.chkRace4.Size = new System.Drawing.Size(54, 17);
            this.chkRace4.TabIndex = 2;
            this.chkRace4.Text = "Dwarf";
            this.chkRace4.UseVisualStyleBackColor = true;
            this.chkRace4.CheckedChanged += new System.EventHandler(this.chkRace4_CheckedChanged);
            // 
            // chkRace8
            // 
            this.chkRace8.AutoSize = true;
            this.chkRace8.Location = new System.Drawing.Point(6, 65);
            this.chkRace8.Name = "chkRace8";
            this.chkRace8.Size = new System.Drawing.Size(66, 17);
            this.chkRace8.TabIndex = 3;
            this.chkRace8.Text = "Night Elf";
            this.chkRace8.UseVisualStyleBackColor = true;
            this.chkRace8.CheckedChanged += new System.EventHandler(this.chkRace8_CheckedChanged);
            // 
            // chkRace16
            // 
            this.chkRace16.AutoSize = true;
            this.chkRace16.Location = new System.Drawing.Point(6, 42);
            this.chkRace16.Name = "chkRace16";
            this.chkRace16.Size = new System.Drawing.Size(64, 17);
            this.chkRace16.TabIndex = 4;
            this.chkRace16.Text = "Undead";
            this.chkRace16.UseVisualStyleBackColor = true;
            this.chkRace16.CheckedChanged += new System.EventHandler(this.chkRace16_CheckedChanged);
            // 
            // chkRace32
            // 
            this.chkRace32.AutoSize = true;
            this.chkRace32.Location = new System.Drawing.Point(6, 65);
            this.chkRace32.Name = "chkRace32";
            this.chkRace32.Size = new System.Drawing.Size(60, 17);
            this.chkRace32.TabIndex = 5;
            this.chkRace32.Text = "Tauren";
            this.chkRace32.UseVisualStyleBackColor = true;
            this.chkRace32.CheckedChanged += new System.EventHandler(this.chkRace32_CheckedChanged);
            // 
            // chkRace64
            // 
            this.chkRace64.AutoSize = true;
            this.chkRace64.Location = new System.Drawing.Point(6, 88);
            this.chkRace64.Name = "chkRace64";
            this.chkRace64.Size = new System.Drawing.Size(60, 17);
            this.chkRace64.TabIndex = 6;
            this.chkRace64.Text = "Gnome";
            this.chkRace64.UseVisualStyleBackColor = true;
            this.chkRace64.CheckedChanged += new System.EventHandler(this.chkRace64_CheckedChanged);
            // 
            // chkRace128
            // 
            this.chkRace128.AutoSize = true;
            this.chkRace128.Location = new System.Drawing.Point(6, 88);
            this.chkRace128.Name = "chkRace128";
            this.chkRace128.Size = new System.Drawing.Size(46, 17);
            this.chkRace128.TabIndex = 7;
            this.chkRace128.Text = "Troll";
            this.chkRace128.UseVisualStyleBackColor = true;
            this.chkRace128.CheckedChanged += new System.EventHandler(this.chkRace128_CheckedChanged);
            // 
            // grpAlliance
            // 
            this.grpAlliance.Controls.Add(this.chkRace1);
            this.grpAlliance.Controls.Add(this.chkRace8);
            this.grpAlliance.Controls.Add(this.chkRace64);
            this.grpAlliance.Controls.Add(this.chkRace4);
            this.grpAlliance.Location = new System.Drawing.Point(15, 37);
            this.grpAlliance.Name = "grpAlliance";
            this.grpAlliance.Size = new System.Drawing.Size(128, 114);
            this.grpAlliance.TabIndex = 8;
            this.grpAlliance.TabStop = false;
            this.grpAlliance.Text = "Alliance Races";
            // 
            // grpHorde
            // 
            this.grpHorde.Controls.Add(this.chkRace2);
            this.grpHorde.Controls.Add(this.chkRace16);
            this.grpHorde.Controls.Add(this.chkRace128);
            this.grpHorde.Controls.Add(this.chkRace32);
            this.grpHorde.Location = new System.Drawing.Point(149, 37);
            this.grpHorde.Name = "grpHorde";
            this.grpHorde.Size = new System.Drawing.Size(128, 114);
            this.grpHorde.TabIndex = 9;
            this.grpHorde.TabStop = false;
            this.grpHorde.Text = "Horde Races";
            // 
            // lblTooltip
            // 
            this.lblTooltip.AutoSize = true;
            this.lblTooltip.Location = new System.Drawing.Point(12, 9);
            this.lblTooltip.Name = "lblTooltip";
            this.lblTooltip.Size = new System.Drawing.Size(263, 13);
            this.lblTooltip.TabIndex = 10;
            this.lblTooltip.Text = "Select the races you would like to include in the mask.";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(68, 169);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(149, 169);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormRaceMask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 198);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblTooltip);
            this.Controls.Add(this.grpHorde);
            this.Controls.Add(this.grpAlliance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRaceMask";
            this.Text = "Race Mask Editor";
            this.grpAlliance.ResumeLayout(false);
            this.grpAlliance.PerformLayout();
            this.grpHorde.ResumeLayout(false);
            this.grpHorde.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkRace1;
        private System.Windows.Forms.CheckBox chkRace2;
        private System.Windows.Forms.CheckBox chkRace4;
        private System.Windows.Forms.CheckBox chkRace8;
        private System.Windows.Forms.CheckBox chkRace16;
        private System.Windows.Forms.CheckBox chkRace32;
        private System.Windows.Forms.CheckBox chkRace64;
        private System.Windows.Forms.CheckBox chkRace128;
        private System.Windows.Forms.GroupBox grpAlliance;
        private System.Windows.Forms.GroupBox grpHorde;
        private System.Windows.Forms.Label lblTooltip;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}