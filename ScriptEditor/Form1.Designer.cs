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
            this.lstActions = new System.Windows.Forms.ListView();
            this.columnDelay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCommand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblId = new System.Windows.Forms.Label();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtScriptId = new System.Windows.Forms.TextBox();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtCommandComment = new System.Windows.Forms.TextBox();
            this.grpDataFlags = new System.Windows.Forms.GroupBox();
            this.chkAbortScript = new System.Windows.Forms.CheckBox();
            this.chkTargetSelf = new System.Windows.Forms.CheckBox();
            this.chkSwapFinal = new System.Windows.Forms.CheckBox();
            this.chkSwapInitial = new System.Windows.Forms.CheckBox();
            this.grpBuddy = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuddyId = new System.Windows.Forms.TextBox();
            this.cmbBuddyType = new System.Windows.Forms.ComboBox();
            this.lblBuddyRadius = new System.Windows.Forms.Label();
            this.txtBuddyRadius = new System.Windows.Forms.TextBox();
            this.lblBuddyId = new System.Windows.Forms.Label();
            this.txtCommandDelay = new System.Windows.Forms.TextBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblCommand = new System.Windows.Forms.Label();
            this.cmbCommandId = new System.Windows.Forms.ComboBox();
            this.frmCommandTalk = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTalkTooltip = new System.Windows.Forms.Label();
            this.txtTalkText4 = new System.Windows.Forms.TextBox();
            this.txtTalkText3 = new System.Windows.Forms.TextBox();
            this.txtTalkText2 = new System.Windows.Forms.TextBox();
            this.txtTalkText1 = new System.Windows.Forms.TextBox();
            this.btnTalkText4 = new System.Windows.Forms.Button();
            this.btnTalkText3 = new System.Windows.Forms.Button();
            this.btnTalkText2 = new System.Windows.Forms.Button();
            this.btnTalkText1 = new System.Windows.Forms.Button();
            this.cmbTalkChatType = new System.Windows.Forms.ComboBox();
            this.lblTalkChatType = new System.Windows.Forms.Label();
            this.btnActionRemove = new System.Windows.Forms.Button();
            this.btnActionNew = new System.Windows.Forms.Button();
            this.lblScriptId = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.frmCommandEmote = new System.Windows.Forms.Panel();
            this.lblEmoteTooltip = new System.Windows.Forms.Label();
            this.cmbEmoteId = new System.Windows.Forms.ComboBox();
            this.lblEmoteId = new System.Windows.Forms.Label();
            this.frmCommandFieldSet = new System.Windows.Forms.Panel();
            this.lvlFieldSetValue = new System.Windows.Forms.Label();
            this.lblFieldSetField = new System.Windows.Forms.Label();
            this.txtFieldSetValue = new System.Windows.Forms.TextBox();
            this.cmbFieldSetFields = new System.Windows.Forms.ComboBox();
            this.lblFieldSetTooltip = new System.Windows.Forms.Label();
            this.frmCommandMoveTo = new System.Windows.Forms.Panel();
            this.chkMoveToFlagsForce = new System.Windows.Forms.CheckBox();
            this.lblMoveToO = new System.Windows.Forms.Label();
            this.lblMoveToZ = new System.Windows.Forms.Label();
            this.lblMoveToY = new System.Windows.Forms.Label();
            this.lblMoveToX = new System.Windows.Forms.Label();
            this.txtMoveToO = new System.Windows.Forms.TextBox();
            this.txtMoveToZ = new System.Windows.Forms.TextBox();
            this.txtMoveToY = new System.Windows.Forms.TextBox();
            this.txtMoveToX = new System.Windows.Forms.TextBox();
            this.grpMoveToOptions = new System.Windows.Forms.GroupBox();
            this.chkMoveOptions256 = new System.Windows.Forms.CheckBox();
            this.chkMoveOptions128 = new System.Windows.Forms.CheckBox();
            this.chkMoveOptions64 = new System.Windows.Forms.CheckBox();
            this.chkMoveOptions32 = new System.Windows.Forms.CheckBox();
            this.chkMoveOptions16 = new System.Windows.Forms.CheckBox();
            this.chkMoveOptions8 = new System.Windows.Forms.CheckBox();
            this.chkMoveOptions4 = new System.Windows.Forms.CheckBox();
            this.chkMoveOptions2 = new System.Windows.Forms.CheckBox();
            this.chkMoveOptions1 = new System.Windows.Forms.CheckBox();
            this.lblMoveToTime = new System.Windows.Forms.Label();
            this.txtMoveToTime = new System.Windows.Forms.TextBox();
            this.lblMoveToType = new System.Windows.Forms.Label();
            this.cmbMoveToType = new System.Windows.Forms.ComboBox();
            this.lblMoveToTooltip = new System.Windows.Forms.Label();
            this.frmCommandTeleport = new System.Windows.Forms.Panel();
            this.lblTeleportO = new System.Windows.Forms.Label();
            this.lblTeleportZ = new System.Windows.Forms.Label();
            this.lblTeleportY = new System.Windows.Forms.Label();
            this.lblTeleportX = new System.Windows.Forms.Label();
            this.lblTeleportMapId = new System.Windows.Forms.Label();
            this.txtTeleportO = new System.Windows.Forms.TextBox();
            this.cmbTeleportMap = new System.Windows.Forms.ComboBox();
            this.txtTeleportZ = new System.Windows.Forms.TextBox();
            this.txtTeleportY = new System.Windows.Forms.TextBox();
            this.txtTeleportX = new System.Windows.Forms.TextBox();
            this.lblTeleportTooltip = new System.Windows.Forms.Label();
            this.grpGeneral.SuspendLayout();
            this.grpDataFlags.SuspendLayout();
            this.grpBuddy.SuspendLayout();
            this.frmCommandTalk.SuspendLayout();
            this.frmCommandEmote.SuspendLayout();
            this.frmCommandFieldSet.SuspendLayout();
            this.frmCommandMoveTo.SuspendLayout();
            this.grpMoveToOptions.SuspendLayout();
            this.frmCommandTeleport.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstActions
            // 
            this.lstActions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDelay,
            this.columnCommand,
            this.columnComment});
            this.lstActions.FullRowSelect = true;
            this.lstActions.GridLines = true;
            this.lstActions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstActions.HideSelection = false;
            this.lstActions.Location = new System.Drawing.Point(23, 62);
            this.lstActions.Name = "lstActions";
            this.lstActions.Size = new System.Drawing.Size(350, 510);
            this.lstActions.TabIndex = 0;
            this.lstActions.UseCompatibleStateImageBehavior = false;
            this.lstActions.View = System.Windows.Forms.View.Details;
            this.lstActions.SelectedIndexChanged += new System.EventHandler(this.lstActions_SelectedIndexChanged);
            // 
            // columnDelay
            // 
            this.columnDelay.Text = "Delay";
            this.columnDelay.Width = 50;
            // 
            // columnCommand
            // 
            this.columnCommand.Text = "Command";
            // 
            // columnComment
            // 
            this.columnComment.Text = "Comment";
            this.columnComment.Width = 240;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(87, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "No script loaded.";
            // 
            // cmbTable
            // 
            this.cmbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Items.AddRange(new object[] {
            "event_scripts",
            "gossip_scripts",
            "gameobject_scripts",
            "spell_scripts",
            "quest_start_scripts",
            "quest_end_scripts",
            "creature_movement_scripts",
            "creature_spells_scripts"});
            this.cmbTable.Location = new System.Drawing.Point(672, 24);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(154, 21);
            this.cmbTable.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(832, 22);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(72, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtScriptId
            // 
            this.txtScriptId.Location = new System.Drawing.Point(590, 25);
            this.txtScriptId.Name = "txtScriptId";
            this.txtScriptId.Size = new System.Drawing.Size(76, 20);
            this.txtScriptId.TabIndex = 4;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.lblComment);
            this.grpGeneral.Controls.Add(this.txtCommandComment);
            this.grpGeneral.Controls.Add(this.grpDataFlags);
            this.grpGeneral.Controls.Add(this.grpBuddy);
            this.grpGeneral.Controls.Add(this.txtCommandDelay);
            this.grpGeneral.Controls.Add(this.lblDelay);
            this.grpGeneral.Controls.Add(this.lblCommand);
            this.grpGeneral.Controls.Add(this.cmbCommandId);
            this.grpGeneral.Enabled = false;
            this.grpGeneral.Location = new System.Drawing.Point(409, 62);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(496, 171);
            this.grpGeneral.TabIndex = 5;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "Command Data";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(24, 125);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(54, 13);
            this.lblComment.TabIndex = 12;
            this.lblComment.Text = "Comment:";
            // 
            // txtCommandComment
            // 
            this.txtCommandComment.Location = new System.Drawing.Point(23, 144);
            this.txtCommandComment.Name = "txtCommandComment";
            this.txtCommandComment.Size = new System.Drawing.Size(450, 20);
            this.txtCommandComment.TabIndex = 11;
            this.txtCommandComment.Leave += new System.EventHandler(this.txtCommandComment_Leave);
            // 
            // grpDataFlags
            // 
            this.grpDataFlags.Controls.Add(this.chkAbortScript);
            this.grpDataFlags.Controls.Add(this.chkTargetSelf);
            this.grpDataFlags.Controls.Add(this.chkSwapFinal);
            this.grpDataFlags.Controls.Add(this.chkSwapInitial);
            this.grpDataFlags.Location = new System.Drawing.Point(321, 19);
            this.grpDataFlags.Name = "grpDataFlags";
            this.grpDataFlags.Size = new System.Drawing.Size(152, 119);
            this.grpDataFlags.TabIndex = 10;
            this.grpDataFlags.TabStop = false;
            this.grpDataFlags.Text = "Data Flags";
            // 
            // chkAbortScript
            // 
            this.chkAbortScript.AutoSize = true;
            this.chkAbortScript.Location = new System.Drawing.Point(6, 90);
            this.chkAbortScript.Name = "chkAbortScript";
            this.chkAbortScript.Size = new System.Drawing.Size(132, 17);
            this.chkAbortScript.TabIndex = 3;
            this.chkAbortScript.Text = "Abort Script On Failure";
            this.chkAbortScript.UseVisualStyleBackColor = true;
            this.chkAbortScript.CheckedChanged += new System.EventHandler(this.chkAbortScript_CheckedChanged);
            // 
            // chkTargetSelf
            // 
            this.chkTargetSelf.AutoSize = true;
            this.chkTargetSelf.Location = new System.Drawing.Point(6, 69);
            this.chkTargetSelf.Name = "chkTargetSelf";
            this.chkTargetSelf.Size = new System.Drawing.Size(78, 17);
            this.chkTargetSelf.TabIndex = 2;
            this.chkTargetSelf.Text = "Target Self";
            this.chkTargetSelf.UseVisualStyleBackColor = true;
            this.chkTargetSelf.CheckedChanged += new System.EventHandler(this.chkTargetSelf_CheckedChanged);
            // 
            // chkSwapFinal
            // 
            this.chkSwapFinal.AutoSize = true;
            this.chkSwapFinal.Location = new System.Drawing.Point(6, 48);
            this.chkSwapFinal.Name = "chkSwapFinal";
            this.chkSwapFinal.Size = new System.Drawing.Size(117, 17);
            this.chkSwapFinal.TabIndex = 1;
            this.chkSwapFinal.Text = "Swap Final Targets";
            this.chkSwapFinal.UseVisualStyleBackColor = true;
            this.chkSwapFinal.CheckedChanged += new System.EventHandler(this.chkSwapFinal_CheckedChanged);
            // 
            // chkSwapInitial
            // 
            this.chkSwapInitial.AutoSize = true;
            this.chkSwapInitial.Location = new System.Drawing.Point(6, 26);
            this.chkSwapInitial.Name = "chkSwapInitial";
            this.chkSwapInitial.Size = new System.Drawing.Size(119, 17);
            this.chkSwapInitial.TabIndex = 0;
            this.chkSwapInitial.Text = "Swap Initial Targets";
            this.chkSwapInitial.UseVisualStyleBackColor = true;
            this.chkSwapInitial.CheckedChanged += new System.EventHandler(this.chkSwapInitial_CheckedChanged);
            // 
            // grpBuddy
            // 
            this.grpBuddy.Controls.Add(this.label1);
            this.grpBuddy.Controls.Add(this.txtBuddyId);
            this.grpBuddy.Controls.Add(this.cmbBuddyType);
            this.grpBuddy.Controls.Add(this.lblBuddyRadius);
            this.grpBuddy.Controls.Add(this.txtBuddyRadius);
            this.grpBuddy.Controls.Add(this.lblBuddyId);
            this.grpBuddy.Location = new System.Drawing.Point(162, 19);
            this.grpBuddy.Name = "grpBuddy";
            this.grpBuddy.Size = new System.Drawing.Size(153, 118);
            this.grpBuddy.TabIndex = 9;
            this.grpBuddy.TabStop = false;
            this.grpBuddy.Text = "Buddy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "What does the Id mean?";
            // 
            // txtBuddyId
            // 
            this.txtBuddyId.Location = new System.Drawing.Point(55, 23);
            this.txtBuddyId.Name = "txtBuddyId";
            this.txtBuddyId.Size = new System.Drawing.Size(92, 20);
            this.txtBuddyId.TabIndex = 4;
            this.txtBuddyId.Leave += new System.EventHandler(this.txtBuddyId_Leave);
            // 
            // cmbBuddyType
            // 
            this.cmbBuddyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuddyType.FormattingEnabled = true;
            this.cmbBuddyType.Location = new System.Drawing.Point(9, 86);
            this.cmbBuddyType.Name = "cmbBuddyType";
            this.cmbBuddyType.Size = new System.Drawing.Size(138, 21);
            this.cmbBuddyType.TabIndex = 6;
            this.cmbBuddyType.SelectedIndexChanged += new System.EventHandler(this.cmbBuddyType_SelectedIndexChanged);
            // 
            // lblBuddyRadius
            // 
            this.lblBuddyRadius.AutoSize = true;
            this.lblBuddyRadius.Location = new System.Drawing.Point(6, 46);
            this.lblBuddyRadius.Name = "lblBuddyRadius";
            this.lblBuddyRadius.Size = new System.Drawing.Size(43, 13);
            this.lblBuddyRadius.TabIndex = 8;
            this.lblBuddyRadius.Text = "Radius:";
            // 
            // txtBuddyRadius
            // 
            this.txtBuddyRadius.Location = new System.Drawing.Point(55, 46);
            this.txtBuddyRadius.Name = "txtBuddyRadius";
            this.txtBuddyRadius.Size = new System.Drawing.Size(92, 20);
            this.txtBuddyRadius.TabIndex = 5;
            this.txtBuddyRadius.Leave += new System.EventHandler(this.txtBuddyRadius_Leave);
            // 
            // lblBuddyId
            // 
            this.lblBuddyId.AutoSize = true;
            this.lblBuddyId.Location = new System.Drawing.Point(6, 26);
            this.lblBuddyId.Name = "lblBuddyId";
            this.lblBuddyId.Size = new System.Drawing.Size(19, 13);
            this.lblBuddyId.TabIndex = 7;
            this.lblBuddyId.Text = "Id:";
            // 
            // txtCommandDelay
            // 
            this.txtCommandDelay.Location = new System.Drawing.Point(24, 46);
            this.txtCommandDelay.Name = "txtCommandDelay";
            this.txtCommandDelay.Size = new System.Drawing.Size(132, 20);
            this.txtCommandDelay.TabIndex = 3;
            this.txtCommandDelay.Leave += new System.EventHandler(this.txtCommandDelay_Leave);
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(20, 30);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(51, 13);
            this.lblDelay.TabIndex = 2;
            this.lblDelay.Text = "Delay (s):";
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(21, 72);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(57, 13);
            this.lblCommand.TabIndex = 1;
            this.lblCommand.Text = "Command:";
            // 
            // cmbCommandId
            // 
            this.cmbCommandId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommandId.FormattingEnabled = true;
            this.cmbCommandId.Location = new System.Drawing.Point(23, 88);
            this.cmbCommandId.Name = "cmbCommandId";
            this.cmbCommandId.Size = new System.Drawing.Size(133, 21);
            this.cmbCommandId.TabIndex = 0;
            this.cmbCommandId.SelectedIndexChanged += new System.EventHandler(this.cmbCommandId_SelectedIndexChanged);
            // 
            // frmCommandTalk
            // 
            this.frmCommandTalk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandTalk.Controls.Add(this.label3);
            this.frmCommandTalk.Controls.Add(this.label2);
            this.frmCommandTalk.Controls.Add(this.lblTalkTooltip);
            this.frmCommandTalk.Controls.Add(this.txtTalkText4);
            this.frmCommandTalk.Controls.Add(this.txtTalkText3);
            this.frmCommandTalk.Controls.Add(this.txtTalkText2);
            this.frmCommandTalk.Controls.Add(this.txtTalkText1);
            this.frmCommandTalk.Controls.Add(this.btnTalkText4);
            this.frmCommandTalk.Controls.Add(this.btnTalkText3);
            this.frmCommandTalk.Controls.Add(this.btnTalkText2);
            this.frmCommandTalk.Controls.Add(this.btnTalkText1);
            this.frmCommandTalk.Controls.Add(this.cmbTalkChatType);
            this.frmCommandTalk.Controls.Add(this.lblTalkChatType);
            this.frmCommandTalk.Location = new System.Drawing.Point(409, 239);
            this.frmCommandTalk.Name = "frmCommandTalk";
            this.frmCommandTalk.Size = new System.Drawing.Size(495, 332);
            this.frmCommandTalk.TabIndex = 6;
            this.frmCommandTalk.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Text Preview:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Broadcast Text ID:";
            // 
            // lblTalkTooltip
            // 
            this.lblTalkTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTalkTooltip.Location = new System.Drawing.Point(19, 10);
            this.lblTalkTooltip.Name = "lblTalkTooltip";
            this.lblTalkTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblTalkTooltip.TabIndex = 10;
            this.lblTalkTooltip.Text = "The source says the specified text. Can be used by any WorldObject, including Gam" +
    "eObjects. If you specify multiple text ids, a random one will be chosen.";
            // 
            // txtTalkText4
            // 
            this.txtTalkText4.Location = new System.Drawing.Point(153, 175);
            this.txtTalkText4.Name = "txtTalkText4";
            this.txtTalkText4.ReadOnly = true;
            this.txtTalkText4.Size = new System.Drawing.Size(316, 20);
            this.txtTalkText4.TabIndex = 9;
            // 
            // txtTalkText3
            // 
            this.txtTalkText3.Location = new System.Drawing.Point(153, 146);
            this.txtTalkText3.Name = "txtTalkText3";
            this.txtTalkText3.ReadOnly = true;
            this.txtTalkText3.Size = new System.Drawing.Size(316, 20);
            this.txtTalkText3.TabIndex = 8;
            // 
            // txtTalkText2
            // 
            this.txtTalkText2.Location = new System.Drawing.Point(153, 117);
            this.txtTalkText2.Name = "txtTalkText2";
            this.txtTalkText2.ReadOnly = true;
            this.txtTalkText2.Size = new System.Drawing.Size(316, 20);
            this.txtTalkText2.TabIndex = 7;
            // 
            // txtTalkText1
            // 
            this.txtTalkText1.Location = new System.Drawing.Point(153, 88);
            this.txtTalkText1.Name = "txtTalkText1";
            this.txtTalkText1.ReadOnly = true;
            this.txtTalkText1.Size = new System.Drawing.Size(316, 20);
            this.txtTalkText1.TabIndex = 6;
            // 
            // btnTalkText4
            // 
            this.btnTalkText4.Location = new System.Drawing.Point(19, 172);
            this.btnTalkText4.Name = "btnTalkText4";
            this.btnTalkText4.Size = new System.Drawing.Size(122, 23);
            this.btnTalkText4.TabIndex = 5;
            this.btnTalkText4.Text = "-NONE-";
            this.btnTalkText4.UseVisualStyleBackColor = true;
            this.btnTalkText4.Click += new System.EventHandler(this.btnTalkText4_Click);
            // 
            // btnTalkText3
            // 
            this.btnTalkText3.Location = new System.Drawing.Point(19, 143);
            this.btnTalkText3.Name = "btnTalkText3";
            this.btnTalkText3.Size = new System.Drawing.Size(122, 23);
            this.btnTalkText3.TabIndex = 4;
            this.btnTalkText3.Text = "-NONE-";
            this.btnTalkText3.UseVisualStyleBackColor = true;
            this.btnTalkText3.Click += new System.EventHandler(this.btnTalkText3_Click);
            // 
            // btnTalkText2
            // 
            this.btnTalkText2.Location = new System.Drawing.Point(19, 114);
            this.btnTalkText2.Name = "btnTalkText2";
            this.btnTalkText2.Size = new System.Drawing.Size(122, 23);
            this.btnTalkText2.TabIndex = 3;
            this.btnTalkText2.Text = "-NONE-";
            this.btnTalkText2.UseVisualStyleBackColor = true;
            this.btnTalkText2.Click += new System.EventHandler(this.btnTalkText2_Click);
            // 
            // btnTalkText1
            // 
            this.btnTalkText1.Location = new System.Drawing.Point(19, 85);
            this.btnTalkText1.Name = "btnTalkText1";
            this.btnTalkText1.Size = new System.Drawing.Size(122, 23);
            this.btnTalkText1.TabIndex = 2;
            this.btnTalkText1.Text = "-NONE-";
            this.btnTalkText1.UseVisualStyleBackColor = true;
            this.btnTalkText1.Click += new System.EventHandler(this.btnTalkText1_Click);
            // 
            // cmbTalkChatType
            // 
            this.cmbTalkChatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTalkChatType.FormattingEnabled = true;
            this.cmbTalkChatType.Location = new System.Drawing.Point(153, 201);
            this.cmbTalkChatType.Name = "cmbTalkChatType";
            this.cmbTalkChatType.Size = new System.Drawing.Size(121, 21);
            this.cmbTalkChatType.TabIndex = 1;
            this.cmbTalkChatType.SelectedIndexChanged += new System.EventHandler(this.cmbTalkChatType_SelectedIndexChanged);
            // 
            // lblTalkChatType
            // 
            this.lblTalkChatType.AutoSize = true;
            this.lblTalkChatType.Location = new System.Drawing.Point(39, 209);
            this.lblTalkChatType.Name = "lblTalkChatType";
            this.lblTalkChatType.Size = new System.Drawing.Size(102, 13);
            this.lblTalkChatType.TabIndex = 0;
            this.lblTalkChatType.Text = "Chat Type Override:";
            // 
            // btnActionRemove
            // 
            this.btnActionRemove.Location = new System.Drawing.Point(298, 578);
            this.btnActionRemove.Name = "btnActionRemove";
            this.btnActionRemove.Size = new System.Drawing.Size(75, 23);
            this.btnActionRemove.TabIndex = 7;
            this.btnActionRemove.Text = "Remove";
            this.btnActionRemove.UseVisualStyleBackColor = true;
            this.btnActionRemove.Click += new System.EventHandler(this.btnActionRemove_Click);
            // 
            // btnActionNew
            // 
            this.btnActionNew.Location = new System.Drawing.Point(217, 578);
            this.btnActionNew.Name = "btnActionNew";
            this.btnActionNew.Size = new System.Drawing.Size(75, 23);
            this.btnActionNew.TabIndex = 8;
            this.btnActionNew.Text = "New";
            this.btnActionNew.UseVisualStyleBackColor = true;
            this.btnActionNew.Click += new System.EventHandler(this.btnActionNew_Click);
            // 
            // lblScriptId
            // 
            this.lblScriptId.AutoSize = true;
            this.lblScriptId.Location = new System.Drawing.Point(587, 9);
            this.lblScriptId.Name = "lblScriptId";
            this.lblScriptId.Size = new System.Drawing.Size(19, 13);
            this.lblScriptId.TabIndex = 9;
            this.lblScriptId.Text = "Id:";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(669, 9);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(37, 13);
            this.lblTable.TabIndex = 10;
            this.lblTable.Text = "Table:";
            // 
            // frmCommandEmote
            // 
            this.frmCommandEmote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandEmote.Controls.Add(this.lblEmoteTooltip);
            this.frmCommandEmote.Controls.Add(this.cmbEmoteId);
            this.frmCommandEmote.Controls.Add(this.lblEmoteId);
            this.frmCommandEmote.Location = new System.Drawing.Point(409, 239);
            this.frmCommandEmote.Name = "frmCommandEmote";
            this.frmCommandEmote.Size = new System.Drawing.Size(495, 332);
            this.frmCommandEmote.TabIndex = 11;
            this.frmCommandEmote.Visible = false;
            // 
            // lblEmoteTooltip
            // 
            this.lblEmoteTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmoteTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblEmoteTooltip.Name = "lblEmoteTooltip";
            this.lblEmoteTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblEmoteTooltip.TabIndex = 2;
            this.lblEmoteTooltip.Text = "The source performs the specified visual emote. Can only be used by Units.";
            // 
            // cmbEmoteId
            // 
            this.cmbEmoteId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmoteId.FormattingEnabled = true;
            this.cmbEmoteId.Location = new System.Drawing.Point(75, 56);
            this.cmbEmoteId.Name = "cmbEmoteId";
            this.cmbEmoteId.Size = new System.Drawing.Size(239, 21);
            this.cmbEmoteId.TabIndex = 1;
            this.cmbEmoteId.SelectedIndexChanged += new System.EventHandler(this.cmbEmoteId_SelectedIndexChanged);
            // 
            // lblEmoteId
            // 
            this.lblEmoteId.AutoSize = true;
            this.lblEmoteId.Location = new System.Drawing.Point(20, 59);
            this.lblEmoteId.Name = "lblEmoteId";
            this.lblEmoteId.Size = new System.Drawing.Size(52, 13);
            this.lblEmoteId.TabIndex = 0;
            this.lblEmoteId.Text = "Emote Id:";
            // 
            // frmCommandFieldSet
            // 
            this.frmCommandFieldSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandFieldSet.Controls.Add(this.lvlFieldSetValue);
            this.frmCommandFieldSet.Controls.Add(this.lblFieldSetField);
            this.frmCommandFieldSet.Controls.Add(this.txtFieldSetValue);
            this.frmCommandFieldSet.Controls.Add(this.cmbFieldSetFields);
            this.frmCommandFieldSet.Controls.Add(this.lblFieldSetTooltip);
            this.frmCommandFieldSet.Location = new System.Drawing.Point(409, 239);
            this.frmCommandFieldSet.Name = "frmCommandFieldSet";
            this.frmCommandFieldSet.Size = new System.Drawing.Size(495, 332);
            this.frmCommandFieldSet.TabIndex = 12;
            this.frmCommandFieldSet.Visible = false;
            // 
            // lvlFieldSetValue
            // 
            this.lvlFieldSetValue.AutoSize = true;
            this.lvlFieldSetValue.Location = new System.Drawing.Point(104, 107);
            this.lvlFieldSetValue.Name = "lvlFieldSetValue";
            this.lvlFieldSetValue.Size = new System.Drawing.Size(37, 13);
            this.lvlFieldSetValue.TabIndex = 4;
            this.lvlFieldSetValue.Text = "Value:";
            // 
            // lblFieldSetField
            // 
            this.lblFieldSetField.AutoSize = true;
            this.lblFieldSetField.Location = new System.Drawing.Point(71, 64);
            this.lblFieldSetField.Name = "lblFieldSetField";
            this.lblFieldSetField.Size = new System.Drawing.Size(70, 13);
            this.lblFieldSetField.TabIndex = 3;
            this.lblFieldSetField.Text = "Update Field:";
            // 
            // txtFieldSetValue
            // 
            this.txtFieldSetValue.Location = new System.Drawing.Point(153, 104);
            this.txtFieldSetValue.Name = "txtFieldSetValue";
            this.txtFieldSetValue.Size = new System.Drawing.Size(316, 20);
            this.txtFieldSetValue.TabIndex = 2;
            this.txtFieldSetValue.Leave += new System.EventHandler(this.txtFieldSetValue_Leave);
            // 
            // cmbFieldSetFields
            // 
            this.cmbFieldSetFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFieldSetFields.FormattingEnabled = true;
            this.cmbFieldSetFields.Location = new System.Drawing.Point(153, 61);
            this.cmbFieldSetFields.Name = "cmbFieldSetFields";
            this.cmbFieldSetFields.Size = new System.Drawing.Size(320, 21);
            this.cmbFieldSetFields.TabIndex = 1;
            this.cmbFieldSetFields.SelectedIndexChanged += new System.EventHandler(this.cmbFieldSetFields_SelectedIndexChanged);
            // 
            // lblFieldSetTooltip
            // 
            this.lblFieldSetTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFieldSetTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblFieldSetTooltip.Name = "lblFieldSetTooltip";
            this.lblFieldSetTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblFieldSetTooltip.TabIndex = 0;
            this.lblFieldSetTooltip.Text = "Sets the chosen update field to the value specified. Can be used on any object, b" +
    "ut the fields are different based on the type. Only use if you know what you are" +
    " doing.\r\n";
            // 
            // frmCommandMoveTo
            // 
            this.frmCommandMoveTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandMoveTo.Controls.Add(this.chkMoveToFlagsForce);
            this.frmCommandMoveTo.Controls.Add(this.lblMoveToO);
            this.frmCommandMoveTo.Controls.Add(this.lblMoveToZ);
            this.frmCommandMoveTo.Controls.Add(this.lblMoveToY);
            this.frmCommandMoveTo.Controls.Add(this.lblMoveToX);
            this.frmCommandMoveTo.Controls.Add(this.txtMoveToO);
            this.frmCommandMoveTo.Controls.Add(this.txtMoveToZ);
            this.frmCommandMoveTo.Controls.Add(this.txtMoveToY);
            this.frmCommandMoveTo.Controls.Add(this.txtMoveToX);
            this.frmCommandMoveTo.Controls.Add(this.grpMoveToOptions);
            this.frmCommandMoveTo.Controls.Add(this.lblMoveToTime);
            this.frmCommandMoveTo.Controls.Add(this.txtMoveToTime);
            this.frmCommandMoveTo.Controls.Add(this.lblMoveToType);
            this.frmCommandMoveTo.Controls.Add(this.cmbMoveToType);
            this.frmCommandMoveTo.Controls.Add(this.lblMoveToTooltip);
            this.frmCommandMoveTo.Location = new System.Drawing.Point(409, 239);
            this.frmCommandMoveTo.Name = "frmCommandMoveTo";
            this.frmCommandMoveTo.Size = new System.Drawing.Size(495, 332);
            this.frmCommandMoveTo.TabIndex = 13;
            this.frmCommandMoveTo.Visible = false;
            // 
            // chkMoveToFlagsForce
            // 
            this.chkMoveToFlagsForce.AutoSize = true;
            this.chkMoveToFlagsForce.Location = new System.Drawing.Point(20, 248);
            this.chkMoveToFlagsForce.Name = "chkMoveToFlagsForce";
            this.chkMoveToFlagsForce.Size = new System.Drawing.Size(106, 17);
            this.chkMoveToFlagsForce.TabIndex = 14;
            this.chkMoveToFlagsForce.Text = "Force Movement";
            this.chkMoveToFlagsForce.UseVisualStyleBackColor = true;
            this.chkMoveToFlagsForce.CheckedChanged += new System.EventHandler(this.chkMoveToFlagsForce_CheckedChanged);
            // 
            // lblMoveToO
            // 
            this.lblMoveToO.AutoSize = true;
            this.lblMoveToO.Location = new System.Drawing.Point(110, 196);
            this.lblMoveToO.Name = "lblMoveToO";
            this.lblMoveToO.Size = new System.Drawing.Size(61, 13);
            this.lblMoveToO.TabIndex = 13;
            this.lblMoveToO.Text = "Orientation:";
            // 
            // lblMoveToZ
            // 
            this.lblMoveToZ.AutoSize = true;
            this.lblMoveToZ.Location = new System.Drawing.Point(23, 195);
            this.lblMoveToZ.Name = "lblMoveToZ";
            this.lblMoveToZ.Size = new System.Drawing.Size(70, 13);
            this.lblMoveToZ.TabIndex = 12;
            this.lblMoveToZ.Text = "Z coordinate:";
            // 
            // lblMoveToY
            // 
            this.lblMoveToY.AutoSize = true;
            this.lblMoveToY.Location = new System.Drawing.Point(110, 153);
            this.lblMoveToY.Name = "lblMoveToY";
            this.lblMoveToY.Size = new System.Drawing.Size(70, 13);
            this.lblMoveToY.TabIndex = 11;
            this.lblMoveToY.Text = "Y coordinate:";
            // 
            // lblMoveToX
            // 
            this.lblMoveToX.AutoSize = true;
            this.lblMoveToX.Location = new System.Drawing.Point(23, 153);
            this.lblMoveToX.Name = "lblMoveToX";
            this.lblMoveToX.Size = new System.Drawing.Size(70, 13);
            this.lblMoveToX.TabIndex = 10;
            this.lblMoveToX.Text = "X coordinate:";
            // 
            // txtMoveToO
            // 
            this.txtMoveToO.Location = new System.Drawing.Point(107, 212);
            this.txtMoveToO.Name = "txtMoveToO";
            this.txtMoveToO.Size = new System.Drawing.Size(79, 20);
            this.txtMoveToO.TabIndex = 9;
            this.txtMoveToO.Leave += new System.EventHandler(this.txtMoveToO_Leave);
            // 
            // txtMoveToZ
            // 
            this.txtMoveToZ.Location = new System.Drawing.Point(19, 212);
            this.txtMoveToZ.Name = "txtMoveToZ";
            this.txtMoveToZ.Size = new System.Drawing.Size(79, 20);
            this.txtMoveToZ.TabIndex = 8;
            this.txtMoveToZ.Leave += new System.EventHandler(this.txtMoveToZ_Leave);
            // 
            // txtMoveToY
            // 
            this.txtMoveToY.Location = new System.Drawing.Point(107, 172);
            this.txtMoveToY.Name = "txtMoveToY";
            this.txtMoveToY.Size = new System.Drawing.Size(79, 20);
            this.txtMoveToY.TabIndex = 7;
            this.txtMoveToY.Leave += new System.EventHandler(this.txtMoveToY_Leave);
            // 
            // txtMoveToX
            // 
            this.txtMoveToX.Location = new System.Drawing.Point(19, 172);
            this.txtMoveToX.Name = "txtMoveToX";
            this.txtMoveToX.Size = new System.Drawing.Size(79, 20);
            this.txtMoveToX.TabIndex = 6;
            this.txtMoveToX.Leave += new System.EventHandler(this.txtMoveToX_Leave);
            // 
            // grpMoveToOptions
            // 
            this.grpMoveToOptions.Controls.Add(this.chkMoveOptions256);
            this.grpMoveToOptions.Controls.Add(this.chkMoveOptions128);
            this.grpMoveToOptions.Controls.Add(this.chkMoveOptions64);
            this.grpMoveToOptions.Controls.Add(this.chkMoveOptions32);
            this.grpMoveToOptions.Controls.Add(this.chkMoveOptions16);
            this.grpMoveToOptions.Controls.Add(this.chkMoveOptions8);
            this.grpMoveToOptions.Controls.Add(this.chkMoveOptions4);
            this.grpMoveToOptions.Controls.Add(this.chkMoveOptions2);
            this.grpMoveToOptions.Controls.Add(this.chkMoveOptions1);
            this.grpMoveToOptions.Location = new System.Drawing.Point(249, 58);
            this.grpMoveToOptions.Name = "grpMoveToOptions";
            this.grpMoveToOptions.Size = new System.Drawing.Size(224, 254);
            this.grpMoveToOptions.TabIndex = 5;
            this.grpMoveToOptions.TabStop = false;
            this.grpMoveToOptions.Text = "Move Options";
            // 
            // chkMoveOptions256
            // 
            this.chkMoveOptions256.AutoSize = true;
            this.chkMoveOptions256.Location = new System.Drawing.Point(8, 227);
            this.chkMoveOptions256.Name = "chkMoveOptions256";
            this.chkMoveOptions256.Size = new System.Drawing.Size(153, 17);
            this.chkMoveOptions256.TabIndex = 8;
            this.chkMoveOptions256.Text = "MOVE_STRAIGHT_PATH";
            this.chkMoveOptions256.UseVisualStyleBackColor = true;
            this.chkMoveOptions256.CheckedChanged += new System.EventHandler(this.chkMoveOptions256_CheckedChanged);
            // 
            // chkMoveOptions128
            // 
            this.chkMoveOptions128.AutoSize = true;
            this.chkMoveOptions128.Location = new System.Drawing.Point(8, 202);
            this.chkMoveOptions128.Name = "chkMoveOptions128";
            this.chkMoveOptions128.Size = new System.Drawing.Size(202, 17);
            this.chkMoveOptions128.TabIndex = 7;
            this.chkMoveOptions128.Text = "MOVE_EXCLUDE_STEEP_SLOPES";
            this.chkMoveOptions128.UseVisualStyleBackColor = true;
            this.chkMoveOptions128.CheckedChanged += new System.EventHandler(this.chkMoveOptions128_CheckedChanged);
            // 
            // chkMoveOptions64
            // 
            this.chkMoveOptions64.AutoSize = true;
            this.chkMoveOptions64.Location = new System.Drawing.Point(8, 177);
            this.chkMoveOptions64.Name = "chkMoveOptions64";
            this.chkMoveOptions64.Size = new System.Drawing.Size(178, 17);
            this.chkMoveOptions64.TabIndex = 6;
            this.chkMoveOptions64.Text = "MOVE_FORCE_DESTINATION";
            this.chkMoveOptions64.UseVisualStyleBackColor = true;
            this.chkMoveOptions64.CheckedChanged += new System.EventHandler(this.chkMoveOptions64_CheckedChanged);
            // 
            // chkMoveOptions32
            // 
            this.chkMoveOptions32.AutoSize = true;
            this.chkMoveOptions32.Location = new System.Drawing.Point(8, 152);
            this.chkMoveOptions32.Name = "chkMoveOptions32";
            this.chkMoveOptions32.Size = new System.Drawing.Size(107, 17);
            this.chkMoveOptions32.TabIndex = 5;
            this.chkMoveOptions32.Text = "MOVE_FALLING";
            this.chkMoveOptions32.UseVisualStyleBackColor = true;
            this.chkMoveOptions32.CheckedChanged += new System.EventHandler(this.chkMoveOptions32_CheckedChanged);
            // 
            // chkMoveOptions16
            // 
            this.chkMoveOptions16.AutoSize = true;
            this.chkMoveOptions16.Location = new System.Drawing.Point(8, 127);
            this.chkMoveOptions16.Name = "chkMoveOptions16";
            this.chkMoveOptions16.Size = new System.Drawing.Size(100, 17);
            this.chkMoveOptions16.TabIndex = 4;
            this.chkMoveOptions16.Text = "MOVE_CYCLIC";
            this.chkMoveOptions16.UseVisualStyleBackColor = true;
            this.chkMoveOptions16.CheckedChanged += new System.EventHandler(this.chkMoveOptions16_CheckedChanged);
            // 
            // chkMoveOptions8
            // 
            this.chkMoveOptions8.AutoSize = true;
            this.chkMoveOptions8.Location = new System.Drawing.Point(8, 102);
            this.chkMoveOptions8.Name = "chkMoveOptions8";
            this.chkMoveOptions8.Size = new System.Drawing.Size(120, 17);
            this.chkMoveOptions8.TabIndex = 3;
            this.chkMoveOptions8.Text = "MOVE_FLY_MODE";
            this.chkMoveOptions8.UseVisualStyleBackColor = true;
            this.chkMoveOptions8.CheckedChanged += new System.EventHandler(this.chkMoveOptions8_CheckedChanged);
            // 
            // chkMoveOptions4
            // 
            this.chkMoveOptions4.AutoSize = true;
            this.chkMoveOptions4.Location = new System.Drawing.Point(8, 77);
            this.chkMoveOptions4.Name = "chkMoveOptions4";
            this.chkMoveOptions4.Size = new System.Drawing.Size(125, 17);
            this.chkMoveOptions4.TabIndex = 2;
            this.chkMoveOptions4.Text = "MOVE_RUN_MODE";
            this.chkMoveOptions4.UseVisualStyleBackColor = true;
            this.chkMoveOptions4.CheckedChanged += new System.EventHandler(this.chkMoveOptions4_CheckedChanged);
            // 
            // chkMoveOptions2
            // 
            this.chkMoveOptions2.AutoSize = true;
            this.chkMoveOptions2.Location = new System.Drawing.Point(8, 52);
            this.chkMoveOptions2.Name = "chkMoveOptions2";
            this.chkMoveOptions2.Size = new System.Drawing.Size(132, 17);
            this.chkMoveOptions2.TabIndex = 1;
            this.chkMoveOptions2.Text = "MOVE_WALK_MODE";
            this.chkMoveOptions2.UseVisualStyleBackColor = true;
            this.chkMoveOptions2.CheckedChanged += new System.EventHandler(this.chkMoveOptions2_CheckedChanged);
            // 
            // chkMoveOptions1
            // 
            this.chkMoveOptions1.AutoSize = true;
            this.chkMoveOptions1.Location = new System.Drawing.Point(8, 27);
            this.chkMoveOptions1.Name = "chkMoveOptions1";
            this.chkMoveOptions1.Size = new System.Drawing.Size(136, 17);
            this.chkMoveOptions1.TabIndex = 0;
            this.chkMoveOptions1.Text = "MOVE_PATHFINDING";
            this.chkMoveOptions1.UseVisualStyleBackColor = true;
            this.chkMoveOptions1.CheckedChanged += new System.EventHandler(this.chkMoveOptions1_CheckedChanged);
            // 
            // lblMoveToTime
            // 
            this.lblMoveToTime.AutoSize = true;
            this.lblMoveToTime.Location = new System.Drawing.Point(23, 107);
            this.lblMoveToTime.Name = "lblMoveToTime";
            this.lblMoveToTime.Size = new System.Drawing.Size(55, 13);
            this.lblMoveToTime.TabIndex = 4;
            this.lblMoveToTime.Text = "Time (ms):";
            // 
            // txtMoveToTime
            // 
            this.txtMoveToTime.Location = new System.Drawing.Point(20, 123);
            this.txtMoveToTime.Name = "txtMoveToTime";
            this.txtMoveToTime.Size = new System.Drawing.Size(166, 20);
            this.txtMoveToTime.TabIndex = 3;
            this.txtMoveToTime.Leave += new System.EventHandler(this.txtMoveToTime_Leave);
            // 
            // lblMoveToType
            // 
            this.lblMoveToType.AutoSize = true;
            this.lblMoveToType.Location = new System.Drawing.Point(23, 58);
            this.lblMoveToType.Name = "lblMoveToType";
            this.lblMoveToType.Size = new System.Drawing.Size(93, 13);
            this.lblMoveToType.TabIndex = 2;
            this.lblMoveToType.Text = "Coordinates Type:";
            // 
            // cmbMoveToType
            // 
            this.cmbMoveToType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoveToType.FormattingEnabled = true;
            this.cmbMoveToType.Location = new System.Drawing.Point(20, 75);
            this.cmbMoveToType.Name = "cmbMoveToType";
            this.cmbMoveToType.Size = new System.Drawing.Size(166, 21);
            this.cmbMoveToType.TabIndex = 1;
            this.cmbMoveToType.SelectedIndexChanged += new System.EventHandler(this.cmbMoveToType_SelectedIndexChanged);
            // 
            // lblMoveToTooltip
            // 
            this.lblMoveToTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMoveToTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblMoveToTooltip.Name = "lblMoveToTooltip";
            this.lblMoveToTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblMoveToTooltip.TabIndex = 0;
            this.lblMoveToTooltip.Text = "The source unit moves to a specified location. Change the coordinates type if you" +
    " want it to move to the position of another WorldObject instead of an absolute m" +
    "ap coordinate.";
            // 
            // frmCommandTeleport
            // 
            this.frmCommandTeleport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandTeleport.Controls.Add(this.lblTeleportO);
            this.frmCommandTeleport.Controls.Add(this.lblTeleportZ);
            this.frmCommandTeleport.Controls.Add(this.lblTeleportY);
            this.frmCommandTeleport.Controls.Add(this.lblTeleportX);
            this.frmCommandTeleport.Controls.Add(this.lblTeleportMapId);
            this.frmCommandTeleport.Controls.Add(this.txtTeleportO);
            this.frmCommandTeleport.Controls.Add(this.cmbTeleportMap);
            this.frmCommandTeleport.Controls.Add(this.txtTeleportZ);
            this.frmCommandTeleport.Controls.Add(this.txtTeleportY);
            this.frmCommandTeleport.Controls.Add(this.txtTeleportX);
            this.frmCommandTeleport.Controls.Add(this.lblTeleportTooltip);
            this.frmCommandTeleport.Location = new System.Drawing.Point(409, 239);
            this.frmCommandTeleport.Name = "frmCommandTeleport";
            this.frmCommandTeleport.Size = new System.Drawing.Size(495, 332);
            this.frmCommandTeleport.TabIndex = 14;
            this.frmCommandTeleport.Visible = false;
            // 
            // lblTeleportO
            // 
            this.lblTeleportO.AutoSize = true;
            this.lblTeleportO.Location = new System.Drawing.Point(37, 211);
            this.lblTeleportO.Name = "lblTeleportO";
            this.lblTeleportO.Size = new System.Drawing.Size(61, 13);
            this.lblTeleportO.TabIndex = 11;
            this.lblTeleportO.Text = "Orientation:";
            // 
            // lblTeleportZ
            // 
            this.lblTeleportZ.AutoSize = true;
            this.lblTeleportZ.Location = new System.Drawing.Point(28, 175);
            this.lblTeleportZ.Name = "lblTeleportZ";
            this.lblTeleportZ.Size = new System.Drawing.Size(70, 13);
            this.lblTeleportZ.TabIndex = 10;
            this.lblTeleportZ.Text = "Z coordinate:";
            // 
            // lblTeleportY
            // 
            this.lblTeleportY.AutoSize = true;
            this.lblTeleportY.Location = new System.Drawing.Point(28, 139);
            this.lblTeleportY.Name = "lblTeleportY";
            this.lblTeleportY.Size = new System.Drawing.Size(70, 13);
            this.lblTeleportY.TabIndex = 9;
            this.lblTeleportY.Text = "Y coordinate:";
            // 
            // lblTeleportX
            // 
            this.lblTeleportX.AutoSize = true;
            this.lblTeleportX.Location = new System.Drawing.Point(28, 104);
            this.lblTeleportX.Name = "lblTeleportX";
            this.lblTeleportX.Size = new System.Drawing.Size(70, 13);
            this.lblTeleportX.TabIndex = 8;
            this.lblTeleportX.Text = "X coordinate:";
            // 
            // lblTeleportMapId
            // 
            this.lblTeleportMapId.AutoSize = true;
            this.lblTeleportMapId.Location = new System.Drawing.Point(55, 71);
            this.lblTeleportMapId.Name = "lblTeleportMapId";
            this.lblTeleportMapId.Size = new System.Drawing.Size(43, 13);
            this.lblTeleportMapId.TabIndex = 7;
            this.lblTeleportMapId.Text = "Map Id:";
            // 
            // txtTeleportO
            // 
            this.txtTeleportO.Location = new System.Drawing.Point(101, 208);
            this.txtTeleportO.Name = "txtTeleportO";
            this.txtTeleportO.Size = new System.Drawing.Size(142, 20);
            this.txtTeleportO.TabIndex = 6;
            this.txtTeleportO.Leave += new System.EventHandler(this.txtTeleportO_Leave);
            // 
            // cmbTeleportMap
            // 
            this.cmbTeleportMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeleportMap.FormattingEnabled = true;
            this.cmbTeleportMap.Location = new System.Drawing.Point(101, 64);
            this.cmbTeleportMap.Name = "cmbTeleportMap";
            this.cmbTeleportMap.Size = new System.Drawing.Size(142, 21);
            this.cmbTeleportMap.TabIndex = 5;
            this.cmbTeleportMap.SelectedIndexChanged += new System.EventHandler(this.cmbTeleportMap_SelectedIndexChanged);
            // 
            // txtTeleportZ
            // 
            this.txtTeleportZ.Location = new System.Drawing.Point(101, 172);
            this.txtTeleportZ.Name = "txtTeleportZ";
            this.txtTeleportZ.Size = new System.Drawing.Size(142, 20);
            this.txtTeleportZ.TabIndex = 4;
            this.txtTeleportZ.Leave += new System.EventHandler(this.txtTeleportZ_Leave);
            // 
            // txtTeleportY
            // 
            this.txtTeleportY.Location = new System.Drawing.Point(101, 136);
            this.txtTeleportY.Name = "txtTeleportY";
            this.txtTeleportY.Size = new System.Drawing.Size(142, 20);
            this.txtTeleportY.TabIndex = 3;
            this.txtTeleportY.Leave += new System.EventHandler(this.txtTeleportY_Leave);
            // 
            // txtTeleportX
            // 
            this.txtTeleportX.Location = new System.Drawing.Point(101, 100);
            this.txtTeleportX.Name = "txtTeleportX";
            this.txtTeleportX.Size = new System.Drawing.Size(142, 20);
            this.txtTeleportX.TabIndex = 2;
            this.txtTeleportX.Leave += new System.EventHandler(this.txtTeleportX_Leave);
            // 
            // lblTeleportTooltip
            // 
            this.lblTeleportTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTeleportTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblTeleportTooltip.Name = "lblTeleportTooltip";
            this.lblTeleportTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblTeleportTooltip.TabIndex = 0;
            this.lblTeleportTooltip.Text = "Teleports the source unit to the specified coordinates. Creatures can only be tel" +
    "eported on the same map.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 608);
            this.Controls.Add(this.frmCommandTeleport);
            this.Controls.Add(this.frmCommandMoveTo);
            this.Controls.Add(this.frmCommandFieldSet);
            this.Controls.Add(this.frmCommandEmote);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.lblScriptId);
            this.Controls.Add(this.btnActionNew);
            this.Controls.Add(this.btnActionRemove);
            this.Controls.Add(this.frmCommandTalk);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.txtScriptId);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lstActions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Script Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpDataFlags.ResumeLayout(false);
            this.grpDataFlags.PerformLayout();
            this.grpBuddy.ResumeLayout(false);
            this.grpBuddy.PerformLayout();
            this.frmCommandTalk.ResumeLayout(false);
            this.frmCommandTalk.PerformLayout();
            this.frmCommandEmote.ResumeLayout(false);
            this.frmCommandEmote.PerformLayout();
            this.frmCommandFieldSet.ResumeLayout(false);
            this.frmCommandFieldSet.PerformLayout();
            this.frmCommandMoveTo.ResumeLayout(false);
            this.frmCommandMoveTo.PerformLayout();
            this.grpMoveToOptions.ResumeLayout(false);
            this.grpMoveToOptions.PerformLayout();
            this.frmCommandTeleport.ResumeLayout(false);
            this.frmCommandTeleport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstActions;
        private System.Windows.Forms.ColumnHeader columnDelay;
        private System.Windows.Forms.ColumnHeader columnCommand;
        private System.Windows.Forms.ColumnHeader columnComment;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtScriptId;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.ComboBox cmbCommandId;
        private System.Windows.Forms.TextBox txtCommandDelay;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.GroupBox grpBuddy;
        private System.Windows.Forms.TextBox txtBuddyId;
        private System.Windows.Forms.Label lblBuddyRadius;
        private System.Windows.Forms.Label lblBuddyId;
        private System.Windows.Forms.ComboBox cmbBuddyType;
        private System.Windows.Forms.TextBox txtBuddyRadius;
        private System.Windows.Forms.GroupBox grpDataFlags;
        private System.Windows.Forms.CheckBox chkAbortScript;
        private System.Windows.Forms.CheckBox chkTargetSelf;
        private System.Windows.Forms.CheckBox chkSwapFinal;
        private System.Windows.Forms.CheckBox chkSwapInitial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel frmCommandTalk;
        private System.Windows.Forms.ComboBox cmbTalkChatType;
        private System.Windows.Forms.Label lblTalkChatType;
        private System.Windows.Forms.TextBox txtTalkText4;
        private System.Windows.Forms.TextBox txtTalkText3;
        private System.Windows.Forms.TextBox txtTalkText2;
        private System.Windows.Forms.TextBox txtTalkText1;
        private System.Windows.Forms.Button btnTalkText4;
        private System.Windows.Forms.Button btnTalkText3;
        private System.Windows.Forms.Button btnTalkText2;
        private System.Windows.Forms.Button btnTalkText1;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtCommandComment;
        private System.Windows.Forms.Button btnActionRemove;
        private System.Windows.Forms.Button btnActionNew;
        private System.Windows.Forms.Label lblScriptId;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTalkTooltip;
        private System.Windows.Forms.Panel frmCommandEmote;
        private System.Windows.Forms.ComboBox cmbEmoteId;
        private System.Windows.Forms.Label lblEmoteId;
        private System.Windows.Forms.Label lblEmoteTooltip;
        private System.Windows.Forms.Panel frmCommandFieldSet;
        private System.Windows.Forms.ComboBox cmbFieldSetFields;
        private System.Windows.Forms.Label lblFieldSetTooltip;
        private System.Windows.Forms.Label lvlFieldSetValue;
        private System.Windows.Forms.Label lblFieldSetField;
        private System.Windows.Forms.TextBox txtFieldSetValue;
        private System.Windows.Forms.Panel frmCommandMoveTo;
        private System.Windows.Forms.CheckBox chkMoveToFlagsForce;
        private System.Windows.Forms.Label lblMoveToO;
        private System.Windows.Forms.Label lblMoveToZ;
        private System.Windows.Forms.Label lblMoveToY;
        private System.Windows.Forms.Label lblMoveToX;
        private System.Windows.Forms.TextBox txtMoveToO;
        private System.Windows.Forms.TextBox txtMoveToZ;
        private System.Windows.Forms.TextBox txtMoveToY;
        private System.Windows.Forms.TextBox txtMoveToX;
        private System.Windows.Forms.GroupBox grpMoveToOptions;
        private System.Windows.Forms.CheckBox chkMoveOptions256;
        private System.Windows.Forms.CheckBox chkMoveOptions128;
        private System.Windows.Forms.CheckBox chkMoveOptions64;
        private System.Windows.Forms.CheckBox chkMoveOptions32;
        private System.Windows.Forms.CheckBox chkMoveOptions16;
        private System.Windows.Forms.CheckBox chkMoveOptions8;
        private System.Windows.Forms.CheckBox chkMoveOptions4;
        private System.Windows.Forms.CheckBox chkMoveOptions2;
        private System.Windows.Forms.CheckBox chkMoveOptions1;
        private System.Windows.Forms.Label lblMoveToTime;
        private System.Windows.Forms.TextBox txtMoveToTime;
        private System.Windows.Forms.Label lblMoveToType;
        private System.Windows.Forms.ComboBox cmbMoveToType;
        private System.Windows.Forms.Label lblMoveToTooltip;
        private System.Windows.Forms.Panel frmCommandTeleport;
        private System.Windows.Forms.ComboBox cmbTeleportMap;
        private System.Windows.Forms.TextBox txtTeleportZ;
        private System.Windows.Forms.TextBox txtTeleportY;
        private System.Windows.Forms.TextBox txtTeleportX;
        private System.Windows.Forms.Label lblTeleportTooltip;
        private System.Windows.Forms.TextBox txtTeleportO;
        private System.Windows.Forms.Label lblTeleportO;
        private System.Windows.Forms.Label lblTeleportZ;
        private System.Windows.Forms.Label lblTeleportY;
        private System.Windows.Forms.Label lblTeleportX;
        private System.Windows.Forms.Label lblTeleportMapId;
    }
}

