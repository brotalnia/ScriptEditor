namespace ScriptEditor
{
    partial class FormMaskCalculator
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
            this.lblPhaseMaskTooltip = new System.Windows.Forms.Label();
            this.txtPhasesList = new System.Windows.Forms.TextBox();
            this.txtPhase = new System.Windows.Forms.TextBox();
            this.lblPhase = new System.Windows.Forms.Label();
            this.btnPhaseAdd = new System.Windows.Forms.Button();
            this.btnPhaseRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPhaseMaskTooltip
            // 
            this.lblPhaseMaskTooltip.AutoSize = true;
            this.lblPhaseMaskTooltip.Location = new System.Drawing.Point(12, 14);
            this.lblPhaseMaskTooltip.Name = "lblPhaseMaskTooltip";
            this.lblPhaseMaskTooltip.Size = new System.Drawing.Size(232, 13);
            this.lblPhaseMaskTooltip.TabIndex = 0;
            this.lblPhaseMaskTooltip.Text = "List of phases in which the event will not trigger:";
            // 
            // txtPhasesList
            // 
            this.txtPhasesList.Location = new System.Drawing.Point(12, 30);
            this.txtPhasesList.Multiline = true;
            this.txtPhasesList.Name = "txtPhasesList";
            this.txtPhasesList.ReadOnly = true;
            this.txtPhasesList.Size = new System.Drawing.Size(247, 129);
            this.txtPhasesList.TabIndex = 1;
            // 
            // txtPhase
            // 
            this.txtPhase.Location = new System.Drawing.Point(54, 171);
            this.txtPhase.Name = "txtPhase";
            this.txtPhase.Size = new System.Drawing.Size(73, 20);
            this.txtPhase.TabIndex = 2;
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Location = new System.Drawing.Point(12, 174);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(40, 13);
            this.lblPhase.TabIndex = 3;
            this.lblPhase.Text = "Phase:";
            // 
            // btnPhaseAdd
            // 
            this.btnPhaseAdd.Location = new System.Drawing.Point(137, 169);
            this.btnPhaseAdd.Name = "btnPhaseAdd";
            this.btnPhaseAdd.Size = new System.Drawing.Size(58, 23);
            this.btnPhaseAdd.TabIndex = 4;
            this.btnPhaseAdd.Text = "Add";
            this.btnPhaseAdd.UseVisualStyleBackColor = true;
            this.btnPhaseAdd.Click += new System.EventHandler(this.btnPhaseAdd_Click);
            // 
            // btnPhaseRemove
            // 
            this.btnPhaseRemove.Location = new System.Drawing.Point(201, 169);
            this.btnPhaseRemove.Name = "btnPhaseRemove";
            this.btnPhaseRemove.Size = new System.Drawing.Size(58, 23);
            this.btnPhaseRemove.TabIndex = 5;
            this.btnPhaseRemove.Text = "Remove";
            this.btnPhaseRemove.UseVisualStyleBackColor = true;
            this.btnPhaseRemove.Click += new System.EventHandler(this.btnPhaseRemove_Click);
            // 
            // FormMaskCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 198);
            this.Controls.Add(this.btnPhaseRemove);
            this.Controls.Add(this.btnPhaseAdd);
            this.Controls.Add(this.lblPhase);
            this.Controls.Add(this.txtPhase);
            this.Controls.Add(this.txtPhasesList);
            this.Controls.Add(this.lblPhaseMaskTooltip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMaskCalculator";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inverse Phase Mask";
            this.Load += new System.EventHandler(this.FormMaskCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhaseMaskTooltip;
        private System.Windows.Forms.TextBox txtPhasesList;
        private System.Windows.Forms.TextBox txtPhase;
        private System.Windows.Forms.Label lblPhase;
        private System.Windows.Forms.Button btnPhaseAdd;
        private System.Windows.Forms.Button btnPhaseRemove;
    }
}