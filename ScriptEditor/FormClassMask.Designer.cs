namespace ScriptEditor
{
    partial class FormClassMask
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
            this.lblTooltip = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkClass1 = new System.Windows.Forms.CheckBox();
            this.chkClass2 = new System.Windows.Forms.CheckBox();
            this.chkClass4 = new System.Windows.Forms.CheckBox();
            this.chkClass8 = new System.Windows.Forms.CheckBox();
            this.chkClass128 = new System.Windows.Forms.CheckBox();
            this.chkClass64 = new System.Windows.Forms.CheckBox();
            this.chkClass32 = new System.Windows.Forms.CheckBox();
            this.chkClass16 = new System.Windows.Forms.CheckBox();
            this.chkClass256 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblTooltip
            // 
            this.lblTooltip.AutoSize = true;
            this.lblTooltip.Location = new System.Drawing.Point(12, 9);
            this.lblTooltip.Name = "lblTooltip";
            this.lblTooltip.Size = new System.Drawing.Size(272, 13);
            this.lblTooltip.TabIndex = 10;
            this.lblTooltip.Text = "Select the classes you would like to include in the mask.";
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
            // chkClass1
            // 
            this.chkClass1.AutoSize = true;
            this.chkClass1.Location = new System.Drawing.Point(15, 38);
            this.chkClass1.Name = "chkClass1";
            this.chkClass1.Size = new System.Drawing.Size(60, 17);
            this.chkClass1.TabIndex = 13;
            this.chkClass1.Text = "Warrior";
            this.chkClass1.UseVisualStyleBackColor = true;
            this.chkClass1.CheckedChanged += new System.EventHandler(this.chkClass1_CheckedChanged);
            // 
            // chkClass2
            // 
            this.chkClass2.AutoSize = true;
            this.chkClass2.Location = new System.Drawing.Point(81, 38);
            this.chkClass2.Name = "chkClass2";
            this.chkClass2.Size = new System.Drawing.Size(61, 17);
            this.chkClass2.TabIndex = 14;
            this.chkClass2.Text = "Paladin";
            this.chkClass2.UseVisualStyleBackColor = true;
            this.chkClass2.CheckedChanged += new System.EventHandler(this.chkClass2_CheckedChanged);
            // 
            // chkClass4
            // 
            this.chkClass4.AutoSize = true;
            this.chkClass4.Location = new System.Drawing.Point(147, 38);
            this.chkClass4.Name = "chkClass4";
            this.chkClass4.Size = new System.Drawing.Size(58, 17);
            this.chkClass4.TabIndex = 15;
            this.chkClass4.Text = "Hunter";
            this.chkClass4.UseVisualStyleBackColor = true;
            this.chkClass4.CheckedChanged += new System.EventHandler(this.chkClass4_CheckedChanged);
            // 
            // chkClass8
            // 
            this.chkClass8.AutoSize = true;
            this.chkClass8.Location = new System.Drawing.Point(213, 38);
            this.chkClass8.Name = "chkClass8";
            this.chkClass8.Size = new System.Drawing.Size(58, 17);
            this.chkClass8.TabIndex = 16;
            this.chkClass8.Text = "Rogue";
            this.chkClass8.UseVisualStyleBackColor = true;
            this.chkClass8.CheckedChanged += new System.EventHandler(this.chkClass8_CheckedChanged);
            // 
            // chkClass128
            // 
            this.chkClass128.AutoSize = true;
            this.chkClass128.Location = new System.Drawing.Point(213, 73);
            this.chkClass128.Name = "chkClass128";
            this.chkClass128.Size = new System.Drawing.Size(66, 17);
            this.chkClass128.TabIndex = 20;
            this.chkClass128.Text = "Warlock";
            this.chkClass128.UseVisualStyleBackColor = true;
            this.chkClass128.CheckedChanged += new System.EventHandler(this.chkClass128_CheckedChanged);
            // 
            // chkClass64
            // 
            this.chkClass64.AutoSize = true;
            this.chkClass64.Location = new System.Drawing.Point(147, 73);
            this.chkClass64.Name = "chkClass64";
            this.chkClass64.Size = new System.Drawing.Size(53, 17);
            this.chkClass64.TabIndex = 19;
            this.chkClass64.Text = "Mage";
            this.chkClass64.UseVisualStyleBackColor = true;
            this.chkClass64.CheckedChanged += new System.EventHandler(this.chkClass64_CheckedChanged);
            // 
            // chkClass32
            // 
            this.chkClass32.AutoSize = true;
            this.chkClass32.Location = new System.Drawing.Point(81, 73);
            this.chkClass32.Name = "chkClass32";
            this.chkClass32.Size = new System.Drawing.Size(65, 17);
            this.chkClass32.TabIndex = 18;
            this.chkClass32.Text = "Shaman";
            this.chkClass32.UseVisualStyleBackColor = true;
            this.chkClass32.CheckedChanged += new System.EventHandler(this.chkClass32_CheckedChanged);
            // 
            // chkClass16
            // 
            this.chkClass16.AutoSize = true;
            this.chkClass16.Location = new System.Drawing.Point(15, 73);
            this.chkClass16.Name = "chkClass16";
            this.chkClass16.Size = new System.Drawing.Size(52, 17);
            this.chkClass16.TabIndex = 17;
            this.chkClass16.Text = "Priest";
            this.chkClass16.UseVisualStyleBackColor = true;
            this.chkClass16.CheckedChanged += new System.EventHandler(this.chkClass16_CheckedChanged);
            // 
            // chkClass256
            // 
            this.chkClass256.AutoSize = true;
            this.chkClass256.Location = new System.Drawing.Point(117, 108);
            this.chkClass256.Name = "chkClass256";
            this.chkClass256.Size = new System.Drawing.Size(51, 17);
            this.chkClass256.TabIndex = 21;
            this.chkClass256.Text = "Druid";
            this.chkClass256.UseVisualStyleBackColor = true;
            this.chkClass256.CheckedChanged += new System.EventHandler(this.chkClass256_CheckedChanged);
            // 
            // FormClassMask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 198);
            this.ControlBox = false;
            this.Controls.Add(this.chkClass256);
            this.Controls.Add(this.chkClass128);
            this.Controls.Add(this.chkClass64);
            this.Controls.Add(this.chkClass32);
            this.Controls.Add(this.chkClass16);
            this.Controls.Add(this.chkClass8);
            this.Controls.Add(this.chkClass4);
            this.Controls.Add(this.chkClass2);
            this.Controls.Add(this.chkClass1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblTooltip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClassMask";
            this.Text = "Class Mask Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTooltip;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkClass1;
        private System.Windows.Forms.CheckBox chkClass2;
        private System.Windows.Forms.CheckBox chkClass4;
        private System.Windows.Forms.CheckBox chkClass8;
        private System.Windows.Forms.CheckBox chkClass128;
        private System.Windows.Forms.CheckBox chkClass64;
        private System.Windows.Forms.CheckBox chkClass32;
        private System.Windows.Forms.CheckBox chkClass16;
        private System.Windows.Forms.CheckBox chkClass256;
    }
}