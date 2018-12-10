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
            this.frmConditionNot = new System.Windows.Forms.Panel();
            this.btnConditionNotCondition2 = new System.Windows.Forms.Button();
            this.btnConditionNotCondition1 = new System.Windows.Forms.Button();
            this.lblConditionNotCondition2 = new System.Windows.Forms.Label();
            this.lblConditionNotCondition1 = new System.Windows.Forms.Label();
            this.lblConditionNotTooltip = new System.Windows.Forms.Label();
            this.cmbConditionType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.txtConditionId = new System.Windows.Forms.TextBox();
            this.chkConditionFlag1 = new System.Windows.Forms.CheckBox();
            this.chkConditionFlag2 = new System.Windows.Forms.CheckBox();
            this.lblNoSelection = new System.Windows.Forms.Label();
            this.frmConditionNot.SuspendLayout();
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
            this.lstData.Size = new System.Drawing.Size(650, 123);
            this.lstData.SelectedIndexChanged += new System.EventHandler(this.lstData_SelectedIndexChanged);
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
            // frmConditionNot
            // 
            this.frmConditionNot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmConditionNot.Controls.Add(this.btnConditionNotCondition2);
            this.frmConditionNot.Controls.Add(this.btnConditionNotCondition1);
            this.frmConditionNot.Controls.Add(this.lblConditionNotCondition2);
            this.frmConditionNot.Controls.Add(this.lblConditionNotCondition1);
            this.frmConditionNot.Controls.Add(this.lblConditionNotTooltip);
            this.frmConditionNot.Location = new System.Drawing.Point(12, 212);
            this.frmConditionNot.Name = "frmConditionNot";
            this.frmConditionNot.Size = new System.Drawing.Size(650, 150);
            this.frmConditionNot.TabIndex = 9;
            this.frmConditionNot.Visible = false;
            // 
            // btnConditionNotCondition2
            // 
            this.btnConditionNotCondition2.Location = new System.Drawing.Point(100, 101);
            this.btnConditionNotCondition2.Name = "btnConditionNotCondition2";
            this.btnConditionNotCondition2.Size = new System.Drawing.Size(536, 23);
            this.btnConditionNotCondition2.TabIndex = 4;
            this.btnConditionNotCondition2.Text = "-NONE-";
            this.btnConditionNotCondition2.UseVisualStyleBackColor = true;
            this.btnConditionNotCondition2.Click += new System.EventHandler(this.btnConditionNotCondition2_Click);
            // 
            // btnConditionNotCondition1
            // 
            this.btnConditionNotCondition1.Location = new System.Drawing.Point(100, 68);
            this.btnConditionNotCondition1.Name = "btnConditionNotCondition1";
            this.btnConditionNotCondition1.Size = new System.Drawing.Size(536, 23);
            this.btnConditionNotCondition1.TabIndex = 3;
            this.btnConditionNotCondition1.Text = "-NONE-";
            this.btnConditionNotCondition1.UseVisualStyleBackColor = true;
            this.btnConditionNotCondition1.Click += new System.EventHandler(this.btnConditionNotCondition1_Click);
            // 
            // lblConditionNotCondition2
            // 
            this.lblConditionNotCondition2.AutoSize = true;
            this.lblConditionNotCondition2.Location = new System.Drawing.Point(11, 106);
            this.lblConditionNotCondition2.Name = "lblConditionNotCondition2";
            this.lblConditionNotCondition2.Size = new System.Drawing.Size(75, 13);
            this.lblConditionNotCondition2.TabIndex = 2;
            this.lblConditionNotCondition2.Text = "Condition Id 2:";
            // 
            // lblConditionNotCondition1
            // 
            this.lblConditionNotCondition1.AutoSize = true;
            this.lblConditionNotCondition1.Location = new System.Drawing.Point(11, 73);
            this.lblConditionNotCondition1.Name = "lblConditionNotCondition1";
            this.lblConditionNotCondition1.Size = new System.Drawing.Size(75, 13);
            this.lblConditionNotCondition1.TabIndex = 1;
            this.lblConditionNotCondition1.Text = "Condition Id 1:";
            // 
            // lblConditionNotTooltip
            // 
            this.lblConditionNotTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConditionNotTooltip.Location = new System.Drawing.Point(12, 8);
            this.lblConditionNotTooltip.Name = "lblConditionNotTooltip";
            this.lblConditionNotTooltip.Size = new System.Drawing.Size(624, 42);
            this.lblConditionNotTooltip.TabIndex = 0;
            this.lblConditionNotTooltip.Text = "Returns true if the specified condition is false.";
            // 
            // cmbConditionType
            // 
            this.cmbConditionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConditionType.Enabled = false;
            this.cmbConditionType.FormattingEnabled = true;
            this.cmbConditionType.Location = new System.Drawing.Point(93, 184);
            this.cmbConditionType.Name = "cmbConditionType";
            this.cmbConditionType.Size = new System.Drawing.Size(203, 21);
            this.cmbConditionType.TabIndex = 10;
            this.cmbConditionType.Visible = false;
            this.cmbConditionType.SelectedIndexChanged += new System.EventHandler(this.cmbConditionType_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(505, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEditAdd
            // 
            this.btnEditAdd.Location = new System.Drawing.Point(12, 367);
            this.btnEditAdd.Name = "btnEditAdd";
            this.btnEditAdd.Size = new System.Drawing.Size(75, 23);
            this.btnEditAdd.TabIndex = 12;
            this.btnEditAdd.Text = "Edit";
            this.btnEditAdd.UseVisualStyleBackColor = true;
            this.btnEditAdd.Click += new System.EventHandler(this.btnEditAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 367);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(586, 184);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAll.TabIndex = 15;
            this.btnSaveAll.Text = "Save All";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Visible = false;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // txtConditionId
            // 
            this.txtConditionId.Enabled = false;
            this.txtConditionId.Location = new System.Drawing.Point(12, 184);
            this.txtConditionId.Name = "txtConditionId";
            this.txtConditionId.Size = new System.Drawing.Size(75, 20);
            this.txtConditionId.TabIndex = 16;
            this.txtConditionId.Visible = false;
            this.txtConditionId.Leave += new System.EventHandler(this.txtConditionId_Leave);
            // 
            // chkConditionFlag1
            // 
            this.chkConditionFlag1.AutoSize = true;
            this.chkConditionFlag1.Enabled = false;
            this.chkConditionFlag1.Location = new System.Drawing.Point(303, 187);
            this.chkConditionFlag1.Name = "chkConditionFlag1";
            this.chkConditionFlag1.Size = new System.Drawing.Size(99, 17);
            this.chkConditionFlag1.TabIndex = 17;
            this.chkConditionFlag1.Text = "Reverse Result";
            this.chkConditionFlag1.UseVisualStyleBackColor = true;
            this.chkConditionFlag1.Visible = false;
            this.chkConditionFlag1.CheckedChanged += new System.EventHandler(this.chkConditionFlag1_CheckedChanged);
            // 
            // chkConditionFlag2
            // 
            this.chkConditionFlag2.AutoSize = true;
            this.chkConditionFlag2.Enabled = false;
            this.chkConditionFlag2.Location = new System.Drawing.Point(408, 187);
            this.chkConditionFlag2.Name = "chkConditionFlag2";
            this.chkConditionFlag2.Size = new System.Drawing.Size(92, 17);
            this.chkConditionFlag2.TabIndex = 18;
            this.chkConditionFlag2.Text = "Swap Targets";
            this.chkConditionFlag2.UseVisualStyleBackColor = true;
            this.chkConditionFlag2.Visible = false;
            this.chkConditionFlag2.CheckedChanged += new System.EventHandler(this.chkConditionFlag2_CheckedChanged);
            // 
            // lblNoSelection
            // 
            this.lblNoSelection.AutoSize = true;
            this.lblNoSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSelection.Location = new System.Drawing.Point(246, 277);
            this.lblNoSelection.Name = "lblNoSelection";
            this.lblNoSelection.Size = new System.Drawing.Size(188, 20);
            this.lblNoSelection.TabIndex = 19;
            this.lblNoSelection.Text = "No Condition Selected";
            // 
            // FormConditionFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(674, 395);
            this.Controls.Add(this.chkConditionFlag2);
            this.Controls.Add(this.chkConditionFlag1);
            this.Controls.Add(this.txtConditionId);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbConditionType);
            this.Controls.Add(this.frmConditionNot);
            this.Controls.Add(this.lblNoSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormConditionFinder";
            this.Text = "Condition Finder";
            this.ResizeEnd += new System.EventHandler(this.FormConditionFinder_ResizeEnd);
            this.Controls.SetChildIndex(this.lblNoSelection, 0);
            this.Controls.SetChildIndex(this.lstData, 0);
            this.Controls.SetChildIndex(this.btnSelectNone, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.frmConditionNot, 0);
            this.Controls.SetChildIndex(this.cmbConditionType, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEditAdd, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSaveAll, 0);
            this.Controls.SetChildIndex(this.txtConditionId, 0);
            this.Controls.SetChildIndex(this.chkConditionFlag1, 0);
            this.Controls.SetChildIndex(this.chkConditionFlag2, 0);
            this.frmConditionNot.ResumeLayout(false);
            this.frmConditionNot.PerformLayout();
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
        private System.Windows.Forms.Panel frmConditionNot;
        private System.Windows.Forms.Button btnConditionNotCondition2;
        private System.Windows.Forms.Button btnConditionNotCondition1;
        private System.Windows.Forms.Label lblConditionNotCondition2;
        private System.Windows.Forms.Label lblConditionNotCondition1;
        private System.Windows.Forms.Label lblConditionNotTooltip;
        private System.Windows.Forms.ComboBox cmbConditionType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEditAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.TextBox txtConditionId;
        private System.Windows.Forms.CheckBox chkConditionFlag1;
        private System.Windows.Forms.CheckBox chkConditionFlag2;
        private System.Windows.Forms.Label lblNoSelection;
    }
}
