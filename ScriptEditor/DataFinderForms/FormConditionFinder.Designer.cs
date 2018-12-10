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
            this.frmConditionAura = new System.Windows.Forms.Panel();
            this.txtAuraEffectIndex = new System.Windows.Forms.TextBox();
            this.btnAuraSpellId = new System.Windows.Forms.Button();
            this.lblAuraEffectIndex = new System.Windows.Forms.Label();
            this.lblAuraSpellId = new System.Windows.Forms.Label();
            this.lblConditionAuraTooltip = new System.Windows.Forms.Label();
            this.frmConditionItem = new System.Windows.Forms.Panel();
            this.txtItemCount = new System.Windows.Forms.TextBox();
            this.btnItemId = new System.Windows.Forms.Button();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.lblItemId = new System.Windows.Forms.Label();
            this.lblConditionItemTooltip = new System.Windows.Forms.Label();
            this.frmConditionArea = new System.Windows.Forms.Panel();
            this.btnAreaId = new System.Windows.Forms.Button();
            this.lblAreaId = new System.Windows.Forms.Label();
            this.lblConditionAreaTooltip = new System.Windows.Forms.Label();
            this.frmConditionReputation = new System.Windows.Forms.Panel();
            this.cmbReputationRank = new System.Windows.Forms.ComboBox();
            this.btnReputationFactionId = new System.Windows.Forms.Button();
            this.lblReputationRank = new System.Windows.Forms.Label();
            this.lblReputationFactionId = new System.Windows.Forms.Label();
            this.lblConditionReputationTooltip = new System.Windows.Forms.Label();
            this.frmConditionTeam = new System.Windows.Forms.Panel();
            this.cmbTeamId = new System.Windows.Forms.ComboBox();
            this.lblTeamId = new System.Windows.Forms.Label();
            this.lblConditionTeamTooltip = new System.Windows.Forms.Label();
            this.frmConditionNot.SuspendLayout();
            this.frmConditionAura.SuspendLayout();
            this.frmConditionItem.SuspendLayout();
            this.frmConditionArea.SuspendLayout();
            this.frmConditionReputation.SuspendLayout();
            this.frmConditionTeam.SuspendLayout();
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
            // frmConditionAura
            // 
            this.frmConditionAura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmConditionAura.Controls.Add(this.txtAuraEffectIndex);
            this.frmConditionAura.Controls.Add(this.btnAuraSpellId);
            this.frmConditionAura.Controls.Add(this.lblAuraEffectIndex);
            this.frmConditionAura.Controls.Add(this.lblAuraSpellId);
            this.frmConditionAura.Controls.Add(this.lblConditionAuraTooltip);
            this.frmConditionAura.Location = new System.Drawing.Point(12, 212);
            this.frmConditionAura.Name = "frmConditionAura";
            this.frmConditionAura.Size = new System.Drawing.Size(650, 150);
            this.frmConditionAura.TabIndex = 20;
            this.frmConditionAura.Visible = false;
            // 
            // txtAuraEffectIndex
            // 
            this.txtAuraEffectIndex.Location = new System.Drawing.Point(100, 101);
            this.txtAuraEffectIndex.Name = "txtAuraEffectIndex";
            this.txtAuraEffectIndex.Size = new System.Drawing.Size(536, 20);
            this.txtAuraEffectIndex.TabIndex = 5;
            this.txtAuraEffectIndex.Leave += new System.EventHandler(this.txtAuraEffectIndex_Leave);
            // 
            // btnAuraSpellId
            // 
            this.btnAuraSpellId.Location = new System.Drawing.Point(100, 68);
            this.btnAuraSpellId.Name = "btnAuraSpellId";
            this.btnAuraSpellId.Size = new System.Drawing.Size(536, 23);
            this.btnAuraSpellId.TabIndex = 3;
            this.btnAuraSpellId.Text = "-NONE-";
            this.btnAuraSpellId.UseVisualStyleBackColor = true;
            this.btnAuraSpellId.Click += new System.EventHandler(this.btnAuraSpellId_Click);
            // 
            // lblAuraEffectIndex
            // 
            this.lblAuraEffectIndex.AutoSize = true;
            this.lblAuraEffectIndex.Location = new System.Drawing.Point(11, 106);
            this.lblAuraEffectIndex.Name = "lblAuraEffectIndex";
            this.lblAuraEffectIndex.Size = new System.Drawing.Size(67, 13);
            this.lblAuraEffectIndex.TabIndex = 2;
            this.lblAuraEffectIndex.Text = "Effect Index:";
            // 
            // lblAuraSpellId
            // 
            this.lblAuraSpellId.AutoSize = true;
            this.lblAuraSpellId.Location = new System.Drawing.Point(11, 73);
            this.lblAuraSpellId.Name = "lblAuraSpellId";
            this.lblAuraSpellId.Size = new System.Drawing.Size(45, 13);
            this.lblAuraSpellId.TabIndex = 1;
            this.lblAuraSpellId.Text = "Spell Id:";
            // 
            // lblConditionAuraTooltip
            // 
            this.lblConditionAuraTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConditionAuraTooltip.Location = new System.Drawing.Point(12, 8);
            this.lblConditionAuraTooltip.Name = "lblConditionAuraTooltip";
            this.lblConditionAuraTooltip.Size = new System.Drawing.Size(624, 42);
            this.lblConditionAuraTooltip.TabIndex = 0;
            this.lblConditionAuraTooltip.Text = "Returns true if the target Unit has an aura from the specified spell Id.";
            // 
            // frmConditionItem
            // 
            this.frmConditionItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmConditionItem.Controls.Add(this.txtItemCount);
            this.frmConditionItem.Controls.Add(this.btnItemId);
            this.frmConditionItem.Controls.Add(this.lblItemCount);
            this.frmConditionItem.Controls.Add(this.lblItemId);
            this.frmConditionItem.Controls.Add(this.lblConditionItemTooltip);
            this.frmConditionItem.Location = new System.Drawing.Point(12, 212);
            this.frmConditionItem.Name = "frmConditionItem";
            this.frmConditionItem.Size = new System.Drawing.Size(650, 150);
            this.frmConditionItem.TabIndex = 21;
            this.frmConditionItem.Visible = false;
            // 
            // txtItemCount
            // 
            this.txtItemCount.Location = new System.Drawing.Point(100, 101);
            this.txtItemCount.Name = "txtItemCount";
            this.txtItemCount.Size = new System.Drawing.Size(536, 20);
            this.txtItemCount.TabIndex = 5;
            this.txtItemCount.Leave += new System.EventHandler(this.txtItemCount_Leave);
            // 
            // btnItemId
            // 
            this.btnItemId.Location = new System.Drawing.Point(100, 68);
            this.btnItemId.Name = "btnItemId";
            this.btnItemId.Size = new System.Drawing.Size(536, 23);
            this.btnItemId.TabIndex = 3;
            this.btnItemId.Text = "-NONE-";
            this.btnItemId.UseVisualStyleBackColor = true;
            this.btnItemId.Click += new System.EventHandler(this.btnItemId_Click);
            // 
            // lblItemCount
            // 
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Location = new System.Drawing.Point(11, 106);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(38, 13);
            this.lblItemCount.TabIndex = 2;
            this.lblItemCount.Text = "Count:";
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Location = new System.Drawing.Point(11, 73);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(42, 13);
            this.lblItemId.TabIndex = 1;
            this.lblItemId.Text = "Item Id:";
            // 
            // lblConditionItemTooltip
            // 
            this.lblConditionItemTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConditionItemTooltip.Location = new System.Drawing.Point(12, 8);
            this.lblConditionItemTooltip.Name = "lblConditionItemTooltip";
            this.lblConditionItemTooltip.Size = new System.Drawing.Size(624, 42);
            this.lblConditionItemTooltip.TabIndex = 0;
            this.lblConditionItemTooltip.Text = "Returns true if the target Player has a minimum count of the specified item.";
            // 
            // frmConditionArea
            // 
            this.frmConditionArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmConditionArea.Controls.Add(this.btnAreaId);
            this.frmConditionArea.Controls.Add(this.lblAreaId);
            this.frmConditionArea.Controls.Add(this.lblConditionAreaTooltip);
            this.frmConditionArea.Location = new System.Drawing.Point(12, 212);
            this.frmConditionArea.Name = "frmConditionArea";
            this.frmConditionArea.Size = new System.Drawing.Size(650, 150);
            this.frmConditionArea.TabIndex = 22;
            this.frmConditionArea.Visible = false;
            // 
            // btnAreaId
            // 
            this.btnAreaId.Location = new System.Drawing.Point(100, 68);
            this.btnAreaId.Name = "btnAreaId";
            this.btnAreaId.Size = new System.Drawing.Size(536, 23);
            this.btnAreaId.TabIndex = 3;
            this.btnAreaId.Text = "-NONE-";
            this.btnAreaId.UseVisualStyleBackColor = true;
            this.btnAreaId.Click += new System.EventHandler(this.btnAreaId_Click);
            // 
            // lblAreaId
            // 
            this.lblAreaId.AutoSize = true;
            this.lblAreaId.Location = new System.Drawing.Point(11, 73);
            this.lblAreaId.Name = "lblAreaId";
            this.lblAreaId.Size = new System.Drawing.Size(44, 13);
            this.lblAreaId.TabIndex = 1;
            this.lblAreaId.Text = "Area Id:";
            // 
            // lblConditionAreaTooltip
            // 
            this.lblConditionAreaTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConditionAreaTooltip.Location = new System.Drawing.Point(12, 8);
            this.lblConditionAreaTooltip.Name = "lblConditionAreaTooltip";
            this.lblConditionAreaTooltip.Size = new System.Drawing.Size(624, 42);
            this.lblConditionAreaTooltip.TabIndex = 0;
            this.lblConditionAreaTooltip.Text = "Returns true if the source or target WorldObject is within the specified area or " +
    "zone.";
            // 
            // frmConditionReputation
            // 
            this.frmConditionReputation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmConditionReputation.Controls.Add(this.cmbReputationRank);
            this.frmConditionReputation.Controls.Add(this.btnReputationFactionId);
            this.frmConditionReputation.Controls.Add(this.lblReputationRank);
            this.frmConditionReputation.Controls.Add(this.lblReputationFactionId);
            this.frmConditionReputation.Controls.Add(this.lblConditionReputationTooltip);
            this.frmConditionReputation.Location = new System.Drawing.Point(12, 212);
            this.frmConditionReputation.Name = "frmConditionReputation";
            this.frmConditionReputation.Size = new System.Drawing.Size(650, 150);
            this.frmConditionReputation.TabIndex = 23;
            this.frmConditionReputation.Visible = false;
            // 
            // cmbReputationRank
            // 
            this.cmbReputationRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReputationRank.FormattingEnabled = true;
            this.cmbReputationRank.Items.AddRange(new object[] {
            "Hated",
            "Hostile",
            "Unfriendly",
            "Neutral",
            "Friendly",
            "Honored",
            "Revered",
            "Exalted"});
            this.cmbReputationRank.Location = new System.Drawing.Point(100, 101);
            this.cmbReputationRank.Name = "cmbReputationRank";
            this.cmbReputationRank.Size = new System.Drawing.Size(536, 21);
            this.cmbReputationRank.TabIndex = 6;
            this.cmbReputationRank.SelectedIndexChanged += new System.EventHandler(this.cmbReputationRank_SelectedIndexChanged);
            // 
            // btnReputationFactionId
            // 
            this.btnReputationFactionId.Location = new System.Drawing.Point(100, 68);
            this.btnReputationFactionId.Name = "btnReputationFactionId";
            this.btnReputationFactionId.Size = new System.Drawing.Size(536, 23);
            this.btnReputationFactionId.TabIndex = 3;
            this.btnReputationFactionId.Text = "-NONE-";
            this.btnReputationFactionId.UseVisualStyleBackColor = true;
            this.btnReputationFactionId.Click += new System.EventHandler(this.btnReputationFactionId_Click);
            // 
            // lblReputationRank
            // 
            this.lblReputationRank.AutoSize = true;
            this.lblReputationRank.Location = new System.Drawing.Point(11, 106);
            this.lblReputationRank.Name = "lblReputationRank";
            this.lblReputationRank.Size = new System.Drawing.Size(36, 13);
            this.lblReputationRank.TabIndex = 2;
            this.lblReputationRank.Text = "Rank:";
            // 
            // lblReputationFactionId
            // 
            this.lblReputationFactionId.AutoSize = true;
            this.lblReputationFactionId.Location = new System.Drawing.Point(11, 73);
            this.lblReputationFactionId.Name = "lblReputationFactionId";
            this.lblReputationFactionId.Size = new System.Drawing.Size(57, 13);
            this.lblReputationFactionId.TabIndex = 1;
            this.lblReputationFactionId.Text = "Faction Id:";
            // 
            // lblConditionReputationTooltip
            // 
            this.lblConditionReputationTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConditionReputationTooltip.Location = new System.Drawing.Point(12, 8);
            this.lblConditionReputationTooltip.Name = "lblConditionReputationTooltip";
            this.lblConditionReputationTooltip.Size = new System.Drawing.Size(624, 42);
            this.lblConditionReputationTooltip.TabIndex = 0;
            this.lblConditionReputationTooltip.Text = "Returns true if the target Player has reached a minimum reputation level with the" +
    " specified faction.";
            // 
            // frmConditionTeam
            // 
            this.frmConditionTeam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmConditionTeam.Controls.Add(this.cmbTeamId);
            this.frmConditionTeam.Controls.Add(this.lblTeamId);
            this.frmConditionTeam.Controls.Add(this.lblConditionTeamTooltip);
            this.frmConditionTeam.Location = new System.Drawing.Point(12, 212);
            this.frmConditionTeam.Name = "frmConditionTeam";
            this.frmConditionTeam.Size = new System.Drawing.Size(650, 150);
            this.frmConditionTeam.TabIndex = 24;
            this.frmConditionTeam.Visible = false;
            // 
            // cmbTeamId
            // 
            this.cmbTeamId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeamId.FormattingEnabled = true;
            this.cmbTeamId.Location = new System.Drawing.Point(100, 68);
            this.cmbTeamId.Name = "cmbTeamId";
            this.cmbTeamId.Size = new System.Drawing.Size(536, 21);
            this.cmbTeamId.TabIndex = 6;
            this.cmbTeamId.SelectedIndexChanged += new System.EventHandler(this.cmbTeamId_SelectedIndexChanged);
            // 
            // lblTeamId
            // 
            this.lblTeamId.AutoSize = true;
            this.lblTeamId.Location = new System.Drawing.Point(11, 73);
            this.lblTeamId.Name = "lblTeamId";
            this.lblTeamId.Size = new System.Drawing.Size(37, 13);
            this.lblTeamId.TabIndex = 1;
            this.lblTeamId.Text = "Team:";
            // 
            // lblConditionTeamTooltip
            // 
            this.lblConditionTeamTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConditionTeamTooltip.Location = new System.Drawing.Point(12, 8);
            this.lblConditionTeamTooltip.Name = "lblConditionTeamTooltip";
            this.lblConditionTeamTooltip.Size = new System.Drawing.Size(624, 42);
            this.lblConditionTeamTooltip.TabIndex = 0;
            this.lblConditionTeamTooltip.Text = "Returns true if the target Player is a member of the specified team.";
            // 
            // FormConditionFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(674, 395);
            this.Controls.Add(this.frmConditionTeam);
            this.Controls.Add(this.frmConditionReputation);
            this.Controls.Add(this.frmConditionArea);
            this.Controls.Add(this.frmConditionItem);
            this.Controls.Add(this.frmConditionAura);
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
            this.Controls.SetChildIndex(this.frmConditionNot, 0);
            this.Controls.SetChildIndex(this.cmbConditionType, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnEditAdd, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSaveAll, 0);
            this.Controls.SetChildIndex(this.txtConditionId, 0);
            this.Controls.SetChildIndex(this.chkConditionFlag1, 0);
            this.Controls.SetChildIndex(this.chkConditionFlag2, 0);
            this.Controls.SetChildIndex(this.frmConditionAura, 0);
            this.Controls.SetChildIndex(this.frmConditionItem, 0);
            this.Controls.SetChildIndex(this.frmConditionArea, 0);
            this.Controls.SetChildIndex(this.lstData, 0);
            this.Controls.SetChildIndex(this.btnSelectNone, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.frmConditionReputation, 0);
            this.Controls.SetChildIndex(this.frmConditionTeam, 0);
            this.frmConditionNot.ResumeLayout(false);
            this.frmConditionNot.PerformLayout();
            this.frmConditionAura.ResumeLayout(false);
            this.frmConditionAura.PerformLayout();
            this.frmConditionItem.ResumeLayout(false);
            this.frmConditionItem.PerformLayout();
            this.frmConditionArea.ResumeLayout(false);
            this.frmConditionArea.PerformLayout();
            this.frmConditionReputation.ResumeLayout(false);
            this.frmConditionReputation.PerformLayout();
            this.frmConditionTeam.ResumeLayout(false);
            this.frmConditionTeam.PerformLayout();
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
        private System.Windows.Forms.Panel frmConditionAura;
        private System.Windows.Forms.TextBox txtAuraEffectIndex;
        private System.Windows.Forms.Button btnAuraSpellId;
        private System.Windows.Forms.Label lblAuraEffectIndex;
        private System.Windows.Forms.Label lblAuraSpellId;
        private System.Windows.Forms.Label lblConditionAuraTooltip;
        private System.Windows.Forms.Panel frmConditionItem;
        private System.Windows.Forms.TextBox txtItemCount;
        private System.Windows.Forms.Button btnItemId;
        private System.Windows.Forms.Label lblItemCount;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.Label lblConditionItemTooltip;
        private System.Windows.Forms.Panel frmConditionArea;
        private System.Windows.Forms.Button btnAreaId;
        private System.Windows.Forms.Label lblAreaId;
        private System.Windows.Forms.Label lblConditionAreaTooltip;
        private System.Windows.Forms.Panel frmConditionReputation;
        private System.Windows.Forms.ComboBox cmbReputationRank;
        private System.Windows.Forms.Button btnReputationFactionId;
        private System.Windows.Forms.Label lblReputationRank;
        private System.Windows.Forms.Label lblReputationFactionId;
        private System.Windows.Forms.Label lblConditionReputationTooltip;
        private System.Windows.Forms.Panel frmConditionTeam;
        private System.Windows.Forms.ComboBox cmbTeamId;
        private System.Windows.Forms.Label lblTeamId;
        private System.Windows.Forms.Label lblConditionTeamTooltip;
    }
}
