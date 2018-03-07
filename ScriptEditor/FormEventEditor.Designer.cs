namespace ScriptEditor
{
    partial class FormEventEditor
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
            this.lstEvents = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCreatureId = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblCreatureId = new System.Windows.Forms.Label();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.lblEventComment = new System.Windows.Forms.Label();
            this.txtEventComment = new System.Windows.Forms.TextBox();
            this.lblScriptId3 = new System.Windows.Forms.Label();
            this.lblScriptId2 = new System.Windows.Forms.Label();
            this.lblScriptId1 = new System.Windows.Forms.Label();
            this.grpEventFlags = new System.Windows.Forms.GroupBox();
            this.chkEventFlag4 = new System.Windows.Forms.CheckBox();
            this.chkEventFlag2 = new System.Windows.Forms.CheckBox();
            this.chkEventFlag1 = new System.Windows.Forms.CheckBox();
            this.btnEditScript3 = new System.Windows.Forms.Button();
            this.btnEditScript2 = new System.Windows.Forms.Button();
            this.btnEditScript1 = new System.Windows.Forms.Button();
            this.txtScriptId3 = new System.Windows.Forms.TextBox();
            this.txtScriptId2 = new System.Windows.Forms.TextBox();
            this.txtScriptId1 = new System.Windows.Forms.TextBox();
            this.lblEventCondition = new System.Windows.Forms.Label();
            this.btnEventCondition = new System.Windows.Forms.Button();
            this.lblEventPhaseMask = new System.Windows.Forms.Label();
            this.txtEventPhaseMask = new System.Windows.Forms.TextBox();
            this.lblEventChance = new System.Windows.Forms.Label();
            this.txtEventChance = new System.Windows.Forms.TextBox();
            this.cmbEventType = new System.Windows.Forms.ComboBox();
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblEventId = new System.Windows.Forms.Label();
            this.txtEventId = new System.Windows.Forms.TextBox();
            this.frmCommandGameEvent = new System.Windows.Forms.Panel();
            this.cmbGameEventOverwrite = new System.Windows.Forms.ComboBox();
            this.lblGameEventOverwrite = new System.Windows.Forms.Label();
            this.cmbGameEventAction = new System.Windows.Forms.ComboBox();
            this.lblGameEventId = new System.Windows.Forms.Label();
            this.lblGameEventAction = new System.Windows.Forms.Label();
            this.btnGameEventId = new System.Windows.Forms.Button();
            this.lblCommandGameEventTooltip = new System.Windows.Forms.Label();
            this.lblCurrentCreature = new System.Windows.Forms.Label();
            this.btnEventCopy = new System.Windows.Forms.Button();
            this.btnEventNew = new System.Windows.Forms.Button();
            this.btnEventRemove = new System.Windows.Forms.Button();
            this.btnViewRaw = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpGeneral.SuspendLayout();
            this.grpEventFlags.SuspendLayout();
            this.frmCommandGameEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEvents
            // 
            this.lstEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnType,
            this.columnComment});
            this.lstEvents.FullRowSelect = true;
            this.lstEvents.GridLines = true;
            this.lstEvents.Location = new System.Drawing.Point(12, 54);
            this.lstEvents.MultiSelect = false;
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(390, 513);
            this.lstEvents.TabIndex = 0;
            this.lstEvents.UseCompatibleStateImageBehavior = false;
            this.lstEvents.View = System.Windows.Forms.View.Details;
            this.lstEvents.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstEvents_ColumnClick);
            this.lstEvents.SelectedIndexChanged += new System.EventHandler(this.lstEvents_SelectedIndexChanged);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            this.columnType.Width = 100;
            // 
            // columnComment
            // 
            this.columnComment.Text = "Comment";
            this.columnComment.Width = 225;
            // 
            // txtCreatureId
            // 
            this.txtCreatureId.Location = new System.Drawing.Point(665, 27);
            this.txtCreatureId.Name = "txtCreatureId";
            this.txtCreatureId.Size = new System.Drawing.Size(190, 20);
            this.txtCreatureId.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(861, 25);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblCreatureId
            // 
            this.lblCreatureId.AutoSize = true;
            this.lblCreatureId.Location = new System.Drawing.Point(598, 31);
            this.lblCreatureId.Name = "lblCreatureId";
            this.lblCreatureId.Size = new System.Drawing.Size(62, 13);
            this.lblCreatureId.TabIndex = 3;
            this.lblCreatureId.Text = "Creature Id:";
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.lblEventComment);
            this.grpGeneral.Controls.Add(this.txtEventComment);
            this.grpGeneral.Controls.Add(this.lblScriptId3);
            this.grpGeneral.Controls.Add(this.lblScriptId2);
            this.grpGeneral.Controls.Add(this.lblScriptId1);
            this.grpGeneral.Controls.Add(this.grpEventFlags);
            this.grpGeneral.Controls.Add(this.btnEditScript3);
            this.grpGeneral.Controls.Add(this.btnEditScript2);
            this.grpGeneral.Controls.Add(this.btnEditScript1);
            this.grpGeneral.Controls.Add(this.txtScriptId3);
            this.grpGeneral.Controls.Add(this.txtScriptId2);
            this.grpGeneral.Controls.Add(this.txtScriptId1);
            this.grpGeneral.Controls.Add(this.lblEventCondition);
            this.grpGeneral.Controls.Add(this.btnEventCondition);
            this.grpGeneral.Controls.Add(this.lblEventPhaseMask);
            this.grpGeneral.Controls.Add(this.txtEventPhaseMask);
            this.grpGeneral.Controls.Add(this.lblEventChance);
            this.grpGeneral.Controls.Add(this.txtEventChance);
            this.grpGeneral.Controls.Add(this.cmbEventType);
            this.grpGeneral.Controls.Add(this.lblEventType);
            this.grpGeneral.Controls.Add(this.lblEventId);
            this.grpGeneral.Controls.Add(this.txtEventId);
            this.grpGeneral.Location = new System.Drawing.Point(437, 54);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(495, 228);
            this.grpGeneral.TabIndex = 4;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General Settings";
            // 
            // lblEventComment
            // 
            this.lblEventComment.AutoSize = true;
            this.lblEventComment.Location = new System.Drawing.Point(20, 197);
            this.lblEventComment.Name = "lblEventComment";
            this.lblEventComment.Size = new System.Drawing.Size(54, 13);
            this.lblEventComment.TabIndex = 34;
            this.lblEventComment.Text = "Comment:";
            // 
            // txtEventComment
            // 
            this.txtEventComment.Location = new System.Drawing.Point(92, 194);
            this.txtEventComment.Name = "txtEventComment";
            this.txtEventComment.Size = new System.Drawing.Size(381, 20);
            this.txtEventComment.TabIndex = 33;
            this.txtEventComment.Leave += new System.EventHandler(this.txtEventComment_Leave);
            // 
            // lblScriptId3
            // 
            this.lblScriptId3.AutoSize = true;
            this.lblScriptId3.Location = new System.Drawing.Point(20, 165);
            this.lblScriptId3.Name = "lblScriptId3";
            this.lblScriptId3.Size = new System.Drawing.Size(46, 13);
            this.lblScriptId3.TabIndex = 32;
            this.lblScriptId3.Text = "Script 3:";
            // 
            // lblScriptId2
            // 
            this.lblScriptId2.AutoSize = true;
            this.lblScriptId2.Location = new System.Drawing.Point(20, 132);
            this.lblScriptId2.Name = "lblScriptId2";
            this.lblScriptId2.Size = new System.Drawing.Size(46, 13);
            this.lblScriptId2.TabIndex = 31;
            this.lblScriptId2.Text = "Script 2:";
            // 
            // lblScriptId1
            // 
            this.lblScriptId1.AutoSize = true;
            this.lblScriptId1.Location = new System.Drawing.Point(20, 97);
            this.lblScriptId1.Name = "lblScriptId1";
            this.lblScriptId1.Size = new System.Drawing.Size(46, 13);
            this.lblScriptId1.TabIndex = 30;
            this.lblScriptId1.Text = "Script 1:";
            // 
            // grpEventFlags
            // 
            this.grpEventFlags.Controls.Add(this.chkEventFlag4);
            this.grpEventFlags.Controls.Add(this.chkEventFlag2);
            this.grpEventFlags.Controls.Add(this.chkEventFlag1);
            this.grpEventFlags.Location = new System.Drawing.Point(259, 19);
            this.grpEventFlags.Name = "grpEventFlags";
            this.grpEventFlags.Size = new System.Drawing.Size(214, 71);
            this.grpEventFlags.TabIndex = 10;
            this.grpEventFlags.TabStop = false;
            this.grpEventFlags.Text = "Event Flags";
            // 
            // chkEventFlag4
            // 
            this.chkEventFlag4.AutoSize = true;
            this.chkEventFlag4.Location = new System.Drawing.Point(116, 20);
            this.chkEventFlag4.Name = "chkEventFlag4";
            this.chkEventFlag4.Size = new System.Drawing.Size(82, 17);
            this.chkEventFlag4.TabIndex = 2;
            this.chkEventFlag4.Text = "Debug Only";
            this.chkEventFlag4.UseVisualStyleBackColor = true;
            this.chkEventFlag4.CheckedChanged += new System.EventHandler(this.chkEventFlag4_CheckedChanged);
            // 
            // chkEventFlag2
            // 
            this.chkEventFlag2.AutoSize = true;
            this.chkEventFlag2.Location = new System.Drawing.Point(6, 43);
            this.chkEventFlag2.Name = "chkEventFlag2";
            this.chkEventFlag2.Size = new System.Drawing.Size(140, 17);
            this.chkEventFlag2.TabIndex = 1;
            this.chkEventFlag2.Text = "Chooses Random Script";
            this.chkEventFlag2.UseVisualStyleBackColor = true;
            this.chkEventFlag2.CheckedChanged += new System.EventHandler(this.chkEventFlag2_CheckedChanged);
            // 
            // chkEventFlag1
            // 
            this.chkEventFlag1.AutoSize = true;
            this.chkEventFlag1.Location = new System.Drawing.Point(6, 20);
            this.chkEventFlag1.Name = "chkEventFlag1";
            this.chkEventFlag1.Size = new System.Drawing.Size(81, 17);
            this.chkEventFlag1.TabIndex = 0;
            this.chkEventFlag1.Text = "Repeatable";
            this.chkEventFlag1.UseVisualStyleBackColor = true;
            this.chkEventFlag1.CheckedChanged += new System.EventHandler(this.chkEventFlag1_CheckedChanged);
            // 
            // btnEditScript3
            // 
            this.btnEditScript3.Location = new System.Drawing.Point(191, 158);
            this.btnEditScript3.Name = "btnEditScript3";
            this.btnEditScript3.Size = new System.Drawing.Size(44, 22);
            this.btnEditScript3.TabIndex = 29;
            this.btnEditScript3.Text = "Edit";
            this.btnEditScript3.UseVisualStyleBackColor = true;
            // 
            // btnEditScript2
            // 
            this.btnEditScript2.Location = new System.Drawing.Point(191, 125);
            this.btnEditScript2.Name = "btnEditScript2";
            this.btnEditScript2.Size = new System.Drawing.Size(44, 22);
            this.btnEditScript2.TabIndex = 28;
            this.btnEditScript2.Text = "Edit";
            this.btnEditScript2.UseVisualStyleBackColor = true;
            // 
            // btnEditScript1
            // 
            this.btnEditScript1.Location = new System.Drawing.Point(192, 92);
            this.btnEditScript1.Name = "btnEditScript1";
            this.btnEditScript1.Size = new System.Drawing.Size(44, 22);
            this.btnEditScript1.TabIndex = 27;
            this.btnEditScript1.Text = "Edit";
            this.btnEditScript1.UseVisualStyleBackColor = true;
            // 
            // txtScriptId3
            // 
            this.txtScriptId3.Location = new System.Drawing.Point(92, 158);
            this.txtScriptId3.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtScriptId3.Name = "txtScriptId3";
            this.txtScriptId3.Size = new System.Drawing.Size(90, 20);
            this.txtScriptId3.TabIndex = 26;
            this.txtScriptId3.Leave += new System.EventHandler(this.txtScriptId3_Leave);
            // 
            // txtScriptId2
            // 
            this.txtScriptId2.Location = new System.Drawing.Point(92, 125);
            this.txtScriptId2.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtScriptId2.Name = "txtScriptId2";
            this.txtScriptId2.Size = new System.Drawing.Size(90, 20);
            this.txtScriptId2.TabIndex = 25;
            this.txtScriptId2.Leave += new System.EventHandler(this.txtScriptId2_Leave);
            // 
            // txtScriptId1
            // 
            this.txtScriptId1.Location = new System.Drawing.Point(92, 92);
            this.txtScriptId1.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtScriptId1.Name = "txtScriptId1";
            this.txtScriptId1.Size = new System.Drawing.Size(90, 20);
            this.txtScriptId1.TabIndex = 24;
            this.txtScriptId1.Leave += new System.EventHandler(this.txtScriptId1_Leave);
            // 
            // lblEventCondition
            // 
            this.lblEventCondition.AutoSize = true;
            this.lblEventCondition.Location = new System.Drawing.Point(256, 163);
            this.lblEventCondition.Name = "lblEventCondition";
            this.lblEventCondition.Size = new System.Drawing.Size(54, 13);
            this.lblEventCondition.TabIndex = 9;
            this.lblEventCondition.Text = "Condition:";
            // 
            // btnEventCondition
            // 
            this.btnEventCondition.Location = new System.Drawing.Point(328, 158);
            this.btnEventCondition.Name = "btnEventCondition";
            this.btnEventCondition.Size = new System.Drawing.Size(145, 23);
            this.btnEventCondition.TabIndex = 8;
            this.btnEventCondition.Text = "-NONE-";
            this.btnEventCondition.UseVisualStyleBackColor = true;
            this.btnEventCondition.Click += new System.EventHandler(this.btnEventCondition_Click);
            // 
            // lblEventPhaseMask
            // 
            this.lblEventPhaseMask.AutoSize = true;
            this.lblEventPhaseMask.Location = new System.Drawing.Point(256, 131);
            this.lblEventPhaseMask.Name = "lblEventPhaseMask";
            this.lblEventPhaseMask.Size = new System.Drawing.Size(69, 13);
            this.lblEventPhaseMask.TabIndex = 7;
            this.lblEventPhaseMask.Text = "Phase Mask:";
            // 
            // txtEventPhaseMask
            // 
            this.txtEventPhaseMask.Location = new System.Drawing.Point(328, 128);
            this.txtEventPhaseMask.Name = "txtEventPhaseMask";
            this.txtEventPhaseMask.Size = new System.Drawing.Size(145, 20);
            this.txtEventPhaseMask.TabIndex = 6;
            this.txtEventPhaseMask.Leave += new System.EventHandler(this.txtEventPhaseMask_Leave);
            // 
            // lblEventChance
            // 
            this.lblEventChance.AutoSize = true;
            this.lblEventChance.Location = new System.Drawing.Point(256, 100);
            this.lblEventChance.Name = "lblEventChance";
            this.lblEventChance.Size = new System.Drawing.Size(47, 13);
            this.lblEventChance.TabIndex = 5;
            this.lblEventChance.Text = "Chance:";
            // 
            // txtEventChance
            // 
            this.txtEventChance.Location = new System.Drawing.Point(328, 97);
            this.txtEventChance.Name = "txtEventChance";
            this.txtEventChance.Size = new System.Drawing.Size(145, 20);
            this.txtEventChance.TabIndex = 4;
            this.txtEventChance.Leave += new System.EventHandler(this.txtEventChance_Leave);
            // 
            // cmbEventType
            // 
            this.cmbEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventType.FormattingEnabled = true;
            this.cmbEventType.Location = new System.Drawing.Point(92, 60);
            this.cmbEventType.Name = "cmbEventType";
            this.cmbEventType.Size = new System.Drawing.Size(145, 21);
            this.cmbEventType.TabIndex = 3;
            this.cmbEventType.SelectedIndexChanged += new System.EventHandler(this.cmbEventType_SelectedIndexChanged);
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(20, 63);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(34, 13);
            this.lblEventType.TabIndex = 2;
            this.lblEventType.Text = "Type:";
            // 
            // lblEventId
            // 
            this.lblEventId.AutoSize = true;
            this.lblEventId.Location = new System.Drawing.Point(20, 32);
            this.lblEventId.Name = "lblEventId";
            this.lblEventId.Size = new System.Drawing.Size(19, 13);
            this.lblEventId.TabIndex = 1;
            this.lblEventId.Text = "Id:";
            // 
            // txtEventId
            // 
            this.txtEventId.Location = new System.Drawing.Point(92, 29);
            this.txtEventId.Name = "txtEventId";
            this.txtEventId.Size = new System.Drawing.Size(145, 20);
            this.txtEventId.TabIndex = 0;
            this.txtEventId.Leave += new System.EventHandler(this.txtEventId_Leave);
            // 
            // frmCommandGameEvent
            // 
            this.frmCommandGameEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandGameEvent.Controls.Add(this.cmbGameEventOverwrite);
            this.frmCommandGameEvent.Controls.Add(this.lblGameEventOverwrite);
            this.frmCommandGameEvent.Controls.Add(this.cmbGameEventAction);
            this.frmCommandGameEvent.Controls.Add(this.lblGameEventId);
            this.frmCommandGameEvent.Controls.Add(this.lblGameEventAction);
            this.frmCommandGameEvent.Controls.Add(this.btnGameEventId);
            this.frmCommandGameEvent.Controls.Add(this.lblCommandGameEventTooltip);
            this.frmCommandGameEvent.Location = new System.Drawing.Point(437, 288);
            this.frmCommandGameEvent.Name = "frmCommandGameEvent";
            this.frmCommandGameEvent.Size = new System.Drawing.Size(495, 279);
            this.frmCommandGameEvent.TabIndex = 54;
            this.frmCommandGameEvent.Visible = false;
            // 
            // cmbGameEventOverwrite
            // 
            this.cmbGameEventOverwrite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGameEventOverwrite.FormattingEnabled = true;
            this.cmbGameEventOverwrite.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbGameEventOverwrite.Location = new System.Drawing.Point(99, 120);
            this.cmbGameEventOverwrite.Name = "cmbGameEventOverwrite";
            this.cmbGameEventOverwrite.Size = new System.Drawing.Size(374, 21);
            this.cmbGameEventOverwrite.TabIndex = 7;
            // 
            // lblGameEventOverwrite
            // 
            this.lblGameEventOverwrite.AutoSize = true;
            this.lblGameEventOverwrite.Location = new System.Drawing.Point(41, 123);
            this.lblGameEventOverwrite.Name = "lblGameEventOverwrite";
            this.lblGameEventOverwrite.Size = new System.Drawing.Size(55, 13);
            this.lblGameEventOverwrite.TabIndex = 6;
            this.lblGameEventOverwrite.Text = "Overwrite:";
            // 
            // cmbGameEventAction
            // 
            this.cmbGameEventAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGameEventAction.FormattingEnabled = true;
            this.cmbGameEventAction.Items.AddRange(new object[] {
            "Stop",
            "Start"});
            this.cmbGameEventAction.Location = new System.Drawing.Point(99, 90);
            this.cmbGameEventAction.Name = "cmbGameEventAction";
            this.cmbGameEventAction.Size = new System.Drawing.Size(374, 21);
            this.cmbGameEventAction.TabIndex = 5;
            // 
            // lblGameEventId
            // 
            this.lblGameEventId.AutoSize = true;
            this.lblGameEventId.Location = new System.Drawing.Point(46, 61);
            this.lblGameEventId.Name = "lblGameEventId";
            this.lblGameEventId.Size = new System.Drawing.Size(50, 13);
            this.lblGameEventId.TabIndex = 4;
            this.lblGameEventId.Text = "Event Id:";
            // 
            // lblGameEventAction
            // 
            this.lblGameEventAction.AutoSize = true;
            this.lblGameEventAction.Location = new System.Drawing.Point(56, 93);
            this.lblGameEventAction.Name = "lblGameEventAction";
            this.lblGameEventAction.Size = new System.Drawing.Size(40, 13);
            this.lblGameEventAction.TabIndex = 3;
            this.lblGameEventAction.Text = "Action:";
            // 
            // btnGameEventId
            // 
            this.btnGameEventId.Location = new System.Drawing.Point(99, 58);
            this.btnGameEventId.Name = "btnGameEventId";
            this.btnGameEventId.Size = new System.Drawing.Size(374, 23);
            this.btnGameEventId.TabIndex = 1;
            this.btnGameEventId.Text = "-NONE-";
            this.btnGameEventId.UseVisualStyleBackColor = true;
            // 
            // lblCommandGameEventTooltip
            // 
            this.lblCommandGameEventTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCommandGameEventTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblCommandGameEventTooltip.Name = "lblCommandGameEventTooltip";
            this.lblCommandGameEventTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblCommandGameEventTooltip.TabIndex = 0;
            this.lblCommandGameEventTooltip.Text = "Starts or stops the chosen game event.";
            // 
            // lblCurrentCreature
            // 
            this.lblCurrentCreature.AutoSize = true;
            this.lblCurrentCreature.Location = new System.Drawing.Point(12, 31);
            this.lblCurrentCreature.Name = "lblCurrentCreature";
            this.lblCurrentCreature.Size = new System.Drawing.Size(104, 13);
            this.lblCurrentCreature.TabIndex = 55;
            this.lblCurrentCreature.Text = "No event list loaded.";
            // 
            // btnEventCopy
            // 
            this.btnEventCopy.Location = new System.Drawing.Point(245, 573);
            this.btnEventCopy.Name = "btnEventCopy";
            this.btnEventCopy.Size = new System.Drawing.Size(75, 23);
            this.btnEventCopy.TabIndex = 58;
            this.btnEventCopy.Text = "Copy";
            this.btnEventCopy.UseVisualStyleBackColor = true;
            this.btnEventCopy.Click += new System.EventHandler(this.btnEventCopy_Click);
            // 
            // btnEventNew
            // 
            this.btnEventNew.Location = new System.Drawing.Point(164, 573);
            this.btnEventNew.Name = "btnEventNew";
            this.btnEventNew.Size = new System.Drawing.Size(75, 23);
            this.btnEventNew.TabIndex = 57;
            this.btnEventNew.Text = "New";
            this.btnEventNew.UseVisualStyleBackColor = true;
            this.btnEventNew.Click += new System.EventHandler(this.btnEventNew_Click);
            // 
            // btnEventRemove
            // 
            this.btnEventRemove.Location = new System.Drawing.Point(326, 573);
            this.btnEventRemove.Name = "btnEventRemove";
            this.btnEventRemove.Size = new System.Drawing.Size(75, 23);
            this.btnEventRemove.TabIndex = 56;
            this.btnEventRemove.Text = "Remove";
            this.btnEventRemove.UseVisualStyleBackColor = true;
            this.btnEventRemove.Click += new System.EventHandler(this.btnEventRemove_Click);
            // 
            // btnViewRaw
            // 
            this.btnViewRaw.Location = new System.Drawing.Point(777, 573);
            this.btnViewRaw.Name = "btnViewRaw";
            this.btnViewRaw.Size = new System.Drawing.Size(75, 23);
            this.btnViewRaw.TabIndex = 60;
            this.btnViewRaw.Text = "View Raw";
            this.btnViewRaw.UseVisualStyleBackColor = true;
            this.btnViewRaw.Click += new System.EventHandler(this.btnViewRaw_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(857, 573);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // FormEventEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 625);
            this.Controls.Add(this.btnViewRaw);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEventCopy);
            this.Controls.Add(this.btnEventNew);
            this.Controls.Add(this.btnEventRemove);
            this.Controls.Add(this.lblCurrentCreature);
            this.Controls.Add(this.frmCommandGameEvent);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.lblCreatureId);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtCreatureId);
            this.Controls.Add(this.lstEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEventEditor";
            this.Text = "Event Editor";
            this.Load += new System.EventHandler(this.FormEventEditor_Load);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpEventFlags.ResumeLayout(false);
            this.grpEventFlags.PerformLayout();
            this.frmCommandGameEvent.ResumeLayout(false);
            this.frmCommandGameEvent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstEvents;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnComment;
        private System.Windows.Forms.TextBox txtCreatureId;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblCreatureId;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.Label lblEventId;
        private System.Windows.Forms.TextBox txtEventId;
        private System.Windows.Forms.Button btnEventCondition;
        private System.Windows.Forms.Label lblEventPhaseMask;
        private System.Windows.Forms.TextBox txtEventPhaseMask;
        private System.Windows.Forms.Label lblEventChance;
        private System.Windows.Forms.TextBox txtEventChance;
        private System.Windows.Forms.ComboBox cmbEventType;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.Label lblEventCondition;
        private System.Windows.Forms.GroupBox grpEventFlags;
        private System.Windows.Forms.Button btnEditScript3;
        private System.Windows.Forms.Button btnEditScript2;
        private System.Windows.Forms.Button btnEditScript1;
        private System.Windows.Forms.TextBox txtScriptId3;
        private System.Windows.Forms.TextBox txtScriptId2;
        private System.Windows.Forms.TextBox txtScriptId1;
        private System.Windows.Forms.Label lblEventComment;
        private System.Windows.Forms.TextBox txtEventComment;
        private System.Windows.Forms.Label lblScriptId3;
        private System.Windows.Forms.Label lblScriptId2;
        private System.Windows.Forms.Label lblScriptId1;
        private System.Windows.Forms.CheckBox chkEventFlag1;
        private System.Windows.Forms.CheckBox chkEventFlag4;
        private System.Windows.Forms.CheckBox chkEventFlag2;
        private System.Windows.Forms.Panel frmCommandGameEvent;
        private System.Windows.Forms.ComboBox cmbGameEventOverwrite;
        private System.Windows.Forms.Label lblGameEventOverwrite;
        private System.Windows.Forms.ComboBox cmbGameEventAction;
        private System.Windows.Forms.Label lblGameEventId;
        private System.Windows.Forms.Label lblGameEventAction;
        private System.Windows.Forms.Button btnGameEventId;
        private System.Windows.Forms.Label lblCommandGameEventTooltip;
        private System.Windows.Forms.Label lblCurrentCreature;
        private System.Windows.Forms.Button btnEventCopy;
        private System.Windows.Forms.Button btnEventNew;
        private System.Windows.Forms.Button btnEventRemove;
        private System.Windows.Forms.Button btnViewRaw;
        private System.Windows.Forms.Button btnSave;
    }
}