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
            this.grpTeleportOptions = new System.Windows.Forms.GroupBox();
            this.chkTeleportOptions32 = new System.Windows.Forms.CheckBox();
            this.chkTeleportOptions16 = new System.Windows.Forms.CheckBox();
            this.chkTeleportOptions8 = new System.Windows.Forms.CheckBox();
            this.chkTeleportOptions4 = new System.Windows.Forms.CheckBox();
            this.chkTeleportOptions2 = new System.Windows.Forms.CheckBox();
            this.chkTeleportOptions1 = new System.Windows.Forms.CheckBox();
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
            this.frmCommandQuestComplete = new System.Windows.Forms.Panel();
            this.lblQuestCompleteId = new System.Windows.Forms.Label();
            this.lblQuestCompleteDistance = new System.Windows.Forms.Label();
            this.txtQuestCompleteDistance = new System.Windows.Forms.TextBox();
            this.btnQuestCompleteId = new System.Windows.Forms.Button();
            this.lblQuestCompleteTooltip = new System.Windows.Forms.Label();
            this.frmCommandKillCredit = new System.Windows.Forms.Panel();
            this.cmbKillCreditType = new System.Windows.Forms.ComboBox();
            this.lblKillCreditCreatureId = new System.Windows.Forms.Label();
            this.lblKillCreditType = new System.Windows.Forms.Label();
            this.btnKillCreditCreatureId = new System.Windows.Forms.Button();
            this.lblKillCreditTooltip = new System.Windows.Forms.Label();
            this.frmCommandRespawnGameobject = new System.Windows.Forms.Panel();
            this.lblRespawnGameobjectDelay = new System.Windows.Forms.Label();
            this.lblRespawnGameobjectGuid = new System.Windows.Forms.Label();
            this.txtRespawnGameobjectDelay = new System.Windows.Forms.TextBox();
            this.txtRespawnGameobjectGuid = new System.Windows.Forms.TextBox();
            this.lblRespawnGameobjectTooltip = new System.Windows.Forms.Label();
            this.frmCommandSummonCreature = new System.Windows.Forms.Panel();
            this.lblSummonCreatureO = new System.Windows.Forms.Label();
            this.lblSummonCreatureZ = new System.Windows.Forms.Label();
            this.lblSummonCreatureY = new System.Windows.Forms.Label();
            this.lblSummonCreatureX = new System.Windows.Forms.Label();
            this.txtSummonCreatureO = new System.Windows.Forms.TextBox();
            this.txtSummonCreatureZ = new System.Windows.Forms.TextBox();
            this.txtSummonCreatureY = new System.Windows.Forms.TextBox();
            this.txtSummonCreatureX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSummonCreatureUniqueLimit = new System.Windows.Forms.Label();
            this.txtSummonCreatureUniqueRange = new System.Windows.Forms.TextBox();
            this.txtSummonCreatureUniqueLimit = new System.Windows.Forms.TextBox();
            this.lblSummonCreatureSetRun = new System.Windows.Forms.Label();
            this.cmbSummonCreatureSetRun = new System.Windows.Forms.ComboBox();
            this.lblSummonCreatureFacingOptions = new System.Windows.Forms.Label();
            this.cmbSummonCreatureFacingOptions = new System.Windows.Forms.ComboBox();
            this.lblSummonCreatureDelay = new System.Windows.Forms.Label();
            this.txtSummonCreatureDelay = new System.Windows.Forms.TextBox();
            this.lblSummonCreatureId = new System.Windows.Forms.Label();
            this.grpSummonCreatureFlags = new System.Windows.Forms.GroupBox();
            this.chkSummonCreatureFlags64 = new System.Windows.Forms.CheckBox();
            this.chkSummonCreatureFlags32 = new System.Windows.Forms.CheckBox();
            this.chkSummonCreatureFlags16 = new System.Windows.Forms.CheckBox();
            this.btnSummonCreatureId = new System.Windows.Forms.Button();
            this.lblSummonCreatureTooltip = new System.Windows.Forms.Label();
            this.frmCommandDoor = new System.Windows.Forms.Panel();
            this.lblDoorResetDelay = new System.Windows.Forms.Label();
            this.lblDoorGuid = new System.Windows.Forms.Label();
            this.txtDoorResetDelay = new System.Windows.Forms.TextBox();
            this.txtDoorGuid = new System.Windows.Forms.TextBox();
            this.lblDoorTooltip = new System.Windows.Forms.Label();
            this.frmCommandRemoveAura = new System.Windows.Forms.Panel();
            this.btnRemoveAuraSpellId = new System.Windows.Forms.Button();
            this.lblRemoveAuraSpellId = new System.Windows.Forms.Label();
            this.lblRemoveAuraTooltip = new System.Windows.Forms.Label();
            this.frmCommandCastSpell = new System.Windows.Forms.Panel();
            this.grpCastSpellFlags = new System.Windows.Forms.GroupBox();
            this.chkCastSpellFlags2 = new System.Windows.Forms.CheckBox();
            this.chkCastSpellFlags1 = new System.Windows.Forms.CheckBox();
            this.btnCastSpellId = new System.Windows.Forms.Button();
            this.lblCastSpellId = new System.Windows.Forms.Label();
            this.lblCastSpellTooltip = new System.Windows.Forms.Label();
            this.frmCommandPlaySound = new System.Windows.Forms.Panel();
            this.grpPlaySoundFlags = new System.Windows.Forms.GroupBox();
            this.chkPlaySoundFlags2 = new System.Windows.Forms.CheckBox();
            this.chkPlaySoundFlags1 = new System.Windows.Forms.CheckBox();
            this.txtPlaySoundId = new System.Windows.Forms.TextBox();
            this.lblPlaySoundId = new System.Windows.Forms.Label();
            this.lblPlaySoundTooltip = new System.Windows.Forms.Label();
            this.frmCommandCreateItem = new System.Windows.Forms.Panel();
            this.lblCreateItemAmount = new System.Windows.Forms.Label();
            this.txtCreateItemAmount = new System.Windows.Forms.TextBox();
            this.btnCreateItemId = new System.Windows.Forms.Button();
            this.lblCreateItemId = new System.Windows.Forms.Label();
            this.lblCreateItemTooltip = new System.Windows.Forms.Label();
            this.frmCommandDespawnCreature = new System.Windows.Forms.Panel();
            this.lblDespawnCreatureTooltip = new System.Windows.Forms.Label();
            this.txtDespawnCreatureDelay = new System.Windows.Forms.TextBox();
            this.lblDespawnCreatureDelay = new System.Windows.Forms.Label();
            this.grpGeneral.SuspendLayout();
            this.grpDataFlags.SuspendLayout();
            this.grpBuddy.SuspendLayout();
            this.frmCommandTalk.SuspendLayout();
            this.frmCommandEmote.SuspendLayout();
            this.frmCommandFieldSet.SuspendLayout();
            this.frmCommandMoveTo.SuspendLayout();
            this.grpMoveToOptions.SuspendLayout();
            this.frmCommandTeleport.SuspendLayout();
            this.grpTeleportOptions.SuspendLayout();
            this.frmCommandQuestComplete.SuspendLayout();
            this.frmCommandKillCredit.SuspendLayout();
            this.frmCommandRespawnGameobject.SuspendLayout();
            this.frmCommandSummonCreature.SuspendLayout();
            this.grpSummonCreatureFlags.SuspendLayout();
            this.frmCommandDoor.SuspendLayout();
            this.frmCommandRemoveAura.SuspendLayout();
            this.frmCommandCastSpell.SuspendLayout();
            this.grpCastSpellFlags.SuspendLayout();
            this.frmCommandPlaySound.SuspendLayout();
            this.grpPlaySoundFlags.SuspendLayout();
            this.frmCommandCreateItem.SuspendLayout();
            this.frmCommandDespawnCreature.SuspendLayout();
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
            this.columnComment.Width = 235;
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
            this.frmCommandTeleport.Controls.Add(this.grpTeleportOptions);
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
            // grpTeleportOptions
            // 
            this.grpTeleportOptions.Controls.Add(this.chkTeleportOptions32);
            this.grpTeleportOptions.Controls.Add(this.chkTeleportOptions16);
            this.grpTeleportOptions.Controls.Add(this.chkTeleportOptions8);
            this.grpTeleportOptions.Controls.Add(this.chkTeleportOptions4);
            this.grpTeleportOptions.Controls.Add(this.chkTeleportOptions2);
            this.grpTeleportOptions.Controls.Add(this.chkTeleportOptions1);
            this.grpTeleportOptions.Location = new System.Drawing.Point(273, 61);
            this.grpTeleportOptions.Name = "grpTeleportOptions";
            this.grpTeleportOptions.Size = new System.Drawing.Size(200, 171);
            this.grpTeleportOptions.TabIndex = 12;
            this.grpTeleportOptions.TabStop = false;
            this.grpTeleportOptions.Text = "Teleport Options";
            // 
            // chkTeleportOptions32
            // 
            this.chkTeleportOptions32.AutoSize = true;
            this.chkTeleportOptions32.Location = new System.Drawing.Point(10, 140);
            this.chkTeleportOptions32.Name = "chkTeleportOptions32";
            this.chkTeleportOptions32.Size = new System.Drawing.Size(142, 17);
            this.chkTeleportOptions32.TabIndex = 5;
            this.chkTeleportOptions32.Text = "FORCE_MAP_CHANGE";
            this.chkTeleportOptions32.UseVisualStyleBackColor = true;
            this.chkTeleportOptions32.CheckedChanged += new System.EventHandler(this.chkTeleportOptions32_CheckedChanged);
            // 
            // chkTeleportOptions16
            // 
            this.chkTeleportOptions16.AutoSize = true;
            this.chkTeleportOptions16.Location = new System.Drawing.Point(10, 117);
            this.chkTeleportOptions16.Name = "chkTeleportOptions16";
            this.chkTeleportOptions16.Size = new System.Drawing.Size(87, 17);
            this.chkTeleportOptions16.TabIndex = 4;
            this.chkTeleportOptions16.Text = "FOR_SPELL";
            this.chkTeleportOptions16.UseVisualStyleBackColor = true;
            this.chkTeleportOptions16.CheckedChanged += new System.EventHandler(this.chkTeleportOptions16_CheckedChanged);
            // 
            // chkTeleportOptions8
            // 
            this.chkTeleportOptions8.AutoSize = true;
            this.chkTeleportOptions8.Location = new System.Drawing.Point(10, 94);
            this.chkTeleportOptions8.Name = "chkTeleportOptions8";
            this.chkTeleportOptions8.Size = new System.Drawing.Size(147, 17);
            this.chkTeleportOptions8.TabIndex = 3;
            this.chkTeleportOptions8.Text = "NOT_UNSUMMON_PET";
            this.chkTeleportOptions8.UseVisualStyleBackColor = true;
            this.chkTeleportOptions8.CheckedChanged += new System.EventHandler(this.chkTeleportOptions8_CheckedChanged);
            // 
            // chkTeleportOptions4
            // 
            this.chkTeleportOptions4.AutoSize = true;
            this.chkTeleportOptions4.Location = new System.Drawing.Point(10, 71);
            this.chkTeleportOptions4.Name = "chkTeleportOptions4";
            this.chkTeleportOptions4.Size = new System.Drawing.Size(140, 17);
            this.chkTeleportOptions4.TabIndex = 2;
            this.chkTeleportOptions4.Text = "NOT_LEAVE_COMBAT";
            this.chkTeleportOptions4.UseVisualStyleBackColor = true;
            this.chkTeleportOptions4.CheckedChanged += new System.EventHandler(this.chkTeleportOptions4_CheckedChanged);
            // 
            // chkTeleportOptions2
            // 
            this.chkTeleportOptions2.AutoSize = true;
            this.chkTeleportOptions2.Location = new System.Drawing.Point(10, 48);
            this.chkTeleportOptions2.Name = "chkTeleportOptions2";
            this.chkTeleportOptions2.Size = new System.Drawing.Size(162, 17);
            this.chkTeleportOptions2.TabIndex = 1;
            this.chkTeleportOptions2.Text = "NOT_LEAVE_TRANSPORT";
            this.chkTeleportOptions2.UseVisualStyleBackColor = true;
            this.chkTeleportOptions2.CheckedChanged += new System.EventHandler(this.chkTeleportOptions2_CheckedChanged);
            // 
            // chkTeleportOptions1
            // 
            this.chkTeleportOptions1.AutoSize = true;
            this.chkTeleportOptions1.Location = new System.Drawing.Point(10, 25);
            this.chkTeleportOptions1.Name = "chkTeleportOptions1";
            this.chkTeleportOptions1.Size = new System.Drawing.Size(81, 17);
            this.chkTeleportOptions1.TabIndex = 0;
            this.chkTeleportOptions1.Text = "GM_MODE";
            this.chkTeleportOptions1.UseVisualStyleBackColor = true;
            this.chkTeleportOptions1.CheckedChanged += new System.EventHandler(this.chkTeleportOptions1_CheckedChanged);
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
            // frmCommandQuestComplete
            // 
            this.frmCommandQuestComplete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandQuestComplete.Controls.Add(this.lblQuestCompleteId);
            this.frmCommandQuestComplete.Controls.Add(this.lblQuestCompleteDistance);
            this.frmCommandQuestComplete.Controls.Add(this.txtQuestCompleteDistance);
            this.frmCommandQuestComplete.Controls.Add(this.btnQuestCompleteId);
            this.frmCommandQuestComplete.Controls.Add(this.lblQuestCompleteTooltip);
            this.frmCommandQuestComplete.Location = new System.Drawing.Point(409, 239);
            this.frmCommandQuestComplete.Name = "frmCommandQuestComplete";
            this.frmCommandQuestComplete.Size = new System.Drawing.Size(495, 332);
            this.frmCommandQuestComplete.TabIndex = 15;
            this.frmCommandQuestComplete.Visible = false;
            // 
            // lblQuestCompleteId
            // 
            this.lblQuestCompleteId.AutoSize = true;
            this.lblQuestCompleteId.Location = new System.Drawing.Point(64, 71);
            this.lblQuestCompleteId.Name = "lblQuestCompleteId";
            this.lblQuestCompleteId.Size = new System.Drawing.Size(50, 13);
            this.lblQuestCompleteId.TabIndex = 4;
            this.lblQuestCompleteId.Text = "Quest Id:";
            // 
            // lblQuestCompleteDistance
            // 
            this.lblQuestCompleteDistance.AutoSize = true;
            this.lblQuestCompleteDistance.Location = new System.Drawing.Point(15, 103);
            this.lblQuestCompleteDistance.Name = "lblQuestCompleteDistance";
            this.lblQuestCompleteDistance.Size = new System.Drawing.Size(99, 13);
            this.lblQuestCompleteDistance.TabIndex = 3;
            this.lblQuestCompleteDistance.Text = "Maximum Distance:";
            // 
            // txtQuestCompleteDistance
            // 
            this.txtQuestCompleteDistance.Location = new System.Drawing.Point(118, 100);
            this.txtQuestCompleteDistance.Name = "txtQuestCompleteDistance";
            this.txtQuestCompleteDistance.Size = new System.Drawing.Size(355, 20);
            this.txtQuestCompleteDistance.TabIndex = 2;
            this.txtQuestCompleteDistance.Leave += new System.EventHandler(this.txtQuestCompleteDistance_Leave);
            // 
            // btnQuestCompleteId
            // 
            this.btnQuestCompleteId.Location = new System.Drawing.Point(118, 66);
            this.btnQuestCompleteId.Name = "btnQuestCompleteId";
            this.btnQuestCompleteId.Size = new System.Drawing.Size(355, 23);
            this.btnQuestCompleteId.TabIndex = 1;
            this.btnQuestCompleteId.Text = "-NONE-";
            this.btnQuestCompleteId.UseVisualStyleBackColor = true;
            this.btnQuestCompleteId.Click += new System.EventHandler(this.btnQuestCompleteId_Click);
            // 
            // lblQuestCompleteTooltip
            // 
            this.lblQuestCompleteTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuestCompleteTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblQuestCompleteTooltip.Name = "lblQuestCompleteTooltip";
            this.lblQuestCompleteTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblQuestCompleteTooltip.TabIndex = 0;
            this.lblQuestCompleteTooltip.Text = "Completes the specified quest for the player. If a maximum distance is provided, " +
    "but the player is out of range, the quest will be marked as failed instead.";
            // 
            // frmCommandKillCredit
            // 
            this.frmCommandKillCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandKillCredit.Controls.Add(this.cmbKillCreditType);
            this.frmCommandKillCredit.Controls.Add(this.lblKillCreditCreatureId);
            this.frmCommandKillCredit.Controls.Add(this.lblKillCreditType);
            this.frmCommandKillCredit.Controls.Add(this.btnKillCreditCreatureId);
            this.frmCommandKillCredit.Controls.Add(this.lblKillCreditTooltip);
            this.frmCommandKillCredit.Location = new System.Drawing.Point(409, 239);
            this.frmCommandKillCredit.Name = "frmCommandKillCredit";
            this.frmCommandKillCredit.Size = new System.Drawing.Size(495, 332);
            this.frmCommandKillCredit.TabIndex = 16;
            this.frmCommandKillCredit.Visible = false;
            // 
            // cmbKillCreditType
            // 
            this.cmbKillCreditType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKillCreditType.FormattingEnabled = true;
            this.cmbKillCreditType.Location = new System.Drawing.Point(118, 100);
            this.cmbKillCreditType.Name = "cmbKillCreditType";
            this.cmbKillCreditType.Size = new System.Drawing.Size(355, 21);
            this.cmbKillCreditType.TabIndex = 5;
            this.cmbKillCreditType.SelectedIndexChanged += new System.EventHandler(this.cmbKillCreditType_SelectedIndexChanged);
            // 
            // lblKillCreditCreatureId
            // 
            this.lblKillCreditCreatureId.AutoSize = true;
            this.lblKillCreditCreatureId.Location = new System.Drawing.Point(52, 71);
            this.lblKillCreditCreatureId.Name = "lblKillCreditCreatureId";
            this.lblKillCreditCreatureId.Size = new System.Drawing.Size(62, 13);
            this.lblKillCreditCreatureId.TabIndex = 4;
            this.lblKillCreditCreatureId.Text = "Creature Id:";
            // 
            // lblKillCreditType
            // 
            this.lblKillCreditType.AutoSize = true;
            this.lblKillCreditType.Location = new System.Drawing.Point(80, 103);
            this.lblKillCreditType.Name = "lblKillCreditType";
            this.lblKillCreditType.Size = new System.Drawing.Size(34, 13);
            this.lblKillCreditType.TabIndex = 3;
            this.lblKillCreditType.Text = "Type:";
            // 
            // btnKillCreditCreatureId
            // 
            this.btnKillCreditCreatureId.Location = new System.Drawing.Point(118, 66);
            this.btnKillCreditCreatureId.Name = "btnKillCreditCreatureId";
            this.btnKillCreditCreatureId.Size = new System.Drawing.Size(355, 23);
            this.btnKillCreditCreatureId.TabIndex = 1;
            this.btnKillCreditCreatureId.Text = "-NONE-";
            this.btnKillCreditCreatureId.UseVisualStyleBackColor = true;
            this.btnKillCreditCreatureId.Click += new System.EventHandler(this.btnKillCreditCreatureId_Click);
            // 
            // lblKillCreditTooltip
            // 
            this.lblKillCreditTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKillCreditTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblKillCreditTooltip.Name = "lblKillCreditTooltip";
            this.lblKillCreditTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblKillCreditTooltip.TabIndex = 0;
            this.lblKillCreditTooltip.Text = "Gives the player or his group credit for killing the specified creature.";
            // 
            // frmCommandRespawnGameobject
            // 
            this.frmCommandRespawnGameobject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandRespawnGameobject.Controls.Add(this.lblRespawnGameobjectDelay);
            this.frmCommandRespawnGameobject.Controls.Add(this.lblRespawnGameobjectGuid);
            this.frmCommandRespawnGameobject.Controls.Add(this.txtRespawnGameobjectDelay);
            this.frmCommandRespawnGameobject.Controls.Add(this.txtRespawnGameobjectGuid);
            this.frmCommandRespawnGameobject.Controls.Add(this.lblRespawnGameobjectTooltip);
            this.frmCommandRespawnGameobject.Location = new System.Drawing.Point(409, 239);
            this.frmCommandRespawnGameobject.Name = "frmCommandRespawnGameobject";
            this.frmCommandRespawnGameobject.Size = new System.Drawing.Size(495, 332);
            this.frmCommandRespawnGameobject.TabIndex = 17;
            this.frmCommandRespawnGameobject.Visible = false;
            // 
            // lblRespawnGameobjectDelay
            // 
            this.lblRespawnGameobjectDelay.AutoSize = true;
            this.lblRespawnGameobjectDelay.Location = new System.Drawing.Point(19, 98);
            this.lblRespawnGameobjectDelay.Name = "lblRespawnGameobjectDelay";
            this.lblRespawnGameobjectDelay.Size = new System.Drawing.Size(85, 13);
            this.lblRespawnGameobjectDelay.TabIndex = 4;
            this.lblRespawnGameobjectDelay.Text = "Despawn Delay:";
            // 
            // lblRespawnGameobjectGuid
            // 
            this.lblRespawnGameobjectGuid.AutoSize = true;
            this.lblRespawnGameobjectGuid.Location = new System.Drawing.Point(67, 68);
            this.lblRespawnGameobjectGuid.Name = "lblRespawnGameobjectGuid";
            this.lblRespawnGameobjectGuid.Size = new System.Drawing.Size(37, 13);
            this.lblRespawnGameobjectGuid.TabIndex = 3;
            this.lblRespawnGameobjectGuid.Text = "GUID:";
            // 
            // txtRespawnGameobjectDelay
            // 
            this.txtRespawnGameobjectDelay.Location = new System.Drawing.Point(107, 95);
            this.txtRespawnGameobjectDelay.Name = "txtRespawnGameobjectDelay";
            this.txtRespawnGameobjectDelay.Size = new System.Drawing.Size(100, 20);
            this.txtRespawnGameobjectDelay.TabIndex = 2;
            this.txtRespawnGameobjectDelay.Leave += new System.EventHandler(this.txtRespawnGameobjectDelay_Leave);
            // 
            // txtRespawnGameobjectGuid
            // 
            this.txtRespawnGameobjectGuid.Location = new System.Drawing.Point(107, 65);
            this.txtRespawnGameobjectGuid.Name = "txtRespawnGameobjectGuid";
            this.txtRespawnGameobjectGuid.Size = new System.Drawing.Size(100, 20);
            this.txtRespawnGameobjectGuid.TabIndex = 1;
            this.txtRespawnGameobjectGuid.Leave += new System.EventHandler(this.txtRespawnGameobjectGuid_Leave);
            // 
            // lblRespawnGameobjectTooltip
            // 
            this.lblRespawnGameobjectTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRespawnGameobjectTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblRespawnGameobjectTooltip.Name = "lblRespawnGameobjectTooltip";
            this.lblRespawnGameobjectTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblRespawnGameobjectTooltip.TabIndex = 0;
            this.lblRespawnGameobjectTooltip.Text = "Respawns the gameobject with the specified GUID, and then despawns it again when " +
    "the delay expires.";
            // 
            // frmCommandSummonCreature
            // 
            this.frmCommandSummonCreature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureO);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureZ);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureY);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureX);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureO);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureZ);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureY);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureX);
            this.frmCommandSummonCreature.Controls.Add(this.label4);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureUniqueLimit);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureUniqueRange);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureUniqueLimit);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureSetRun);
            this.frmCommandSummonCreature.Controls.Add(this.cmbSummonCreatureSetRun);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureFacingOptions);
            this.frmCommandSummonCreature.Controls.Add(this.cmbSummonCreatureFacingOptions);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureDelay);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureDelay);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureId);
            this.frmCommandSummonCreature.Controls.Add(this.grpSummonCreatureFlags);
            this.frmCommandSummonCreature.Controls.Add(this.btnSummonCreatureId);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureTooltip);
            this.frmCommandSummonCreature.Location = new System.Drawing.Point(409, 239);
            this.frmCommandSummonCreature.Name = "frmCommandSummonCreature";
            this.frmCommandSummonCreature.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSummonCreature.TabIndex = 18;
            this.frmCommandSummonCreature.Visible = false;
            // 
            // lblSummonCreatureO
            // 
            this.lblSummonCreatureO.AutoSize = true;
            this.lblSummonCreatureO.Location = new System.Drawing.Point(64, 286);
            this.lblSummonCreatureO.Name = "lblSummonCreatureO";
            this.lblSummonCreatureO.Size = new System.Drawing.Size(61, 13);
            this.lblSummonCreatureO.TabIndex = 21;
            this.lblSummonCreatureO.Text = "Orientation:";
            // 
            // lblSummonCreatureZ
            // 
            this.lblSummonCreatureZ.AutoSize = true;
            this.lblSummonCreatureZ.Location = new System.Drawing.Point(55, 257);
            this.lblSummonCreatureZ.Name = "lblSummonCreatureZ";
            this.lblSummonCreatureZ.Size = new System.Drawing.Size(70, 13);
            this.lblSummonCreatureZ.TabIndex = 20;
            this.lblSummonCreatureZ.Text = "Z coordinate:";
            // 
            // lblSummonCreatureY
            // 
            this.lblSummonCreatureY.AutoSize = true;
            this.lblSummonCreatureY.Location = new System.Drawing.Point(55, 229);
            this.lblSummonCreatureY.Name = "lblSummonCreatureY";
            this.lblSummonCreatureY.Size = new System.Drawing.Size(70, 13);
            this.lblSummonCreatureY.TabIndex = 19;
            this.lblSummonCreatureY.Text = "Y coordinate:";
            // 
            // lblSummonCreatureX
            // 
            this.lblSummonCreatureX.AutoSize = true;
            this.lblSummonCreatureX.Location = new System.Drawing.Point(55, 197);
            this.lblSummonCreatureX.Name = "lblSummonCreatureX";
            this.lblSummonCreatureX.Size = new System.Drawing.Size(70, 13);
            this.lblSummonCreatureX.TabIndex = 18;
            this.lblSummonCreatureX.Text = "X coordinate:";
            // 
            // txtSummonCreatureO
            // 
            this.txtSummonCreatureO.Location = new System.Drawing.Point(131, 285);
            this.txtSummonCreatureO.Name = "txtSummonCreatureO";
            this.txtSummonCreatureO.Size = new System.Drawing.Size(143, 20);
            this.txtSummonCreatureO.TabIndex = 17;
            this.txtSummonCreatureO.Leave += new System.EventHandler(this.txtSummonCreatureO_Leave);
            // 
            // txtSummonCreatureZ
            // 
            this.txtSummonCreatureZ.Location = new System.Drawing.Point(132, 254);
            this.txtSummonCreatureZ.Name = "txtSummonCreatureZ";
            this.txtSummonCreatureZ.Size = new System.Drawing.Size(142, 20);
            this.txtSummonCreatureZ.TabIndex = 16;
            this.txtSummonCreatureZ.Leave += new System.EventHandler(this.txtSummonCreatureZ_Leave);
            // 
            // txtSummonCreatureY
            // 
            this.txtSummonCreatureY.Location = new System.Drawing.Point(131, 225);
            this.txtSummonCreatureY.Name = "txtSummonCreatureY";
            this.txtSummonCreatureY.Size = new System.Drawing.Size(143, 20);
            this.txtSummonCreatureY.TabIndex = 15;
            this.txtSummonCreatureY.Leave += new System.EventHandler(this.txtSummonCreatureY_Leave);
            // 
            // txtSummonCreatureX
            // 
            this.txtSummonCreatureX.Location = new System.Drawing.Point(131, 194);
            this.txtSummonCreatureX.Name = "txtSummonCreatureX";
            this.txtSummonCreatureX.Size = new System.Drawing.Size(143, 20);
            this.txtSummonCreatureX.TabIndex = 14;
            this.txtSummonCreatureX.Leave += new System.EventHandler(this.txtSummonCreatureX_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Unique range:";
            // 
            // lblSummonCreatureUniqueLimit
            // 
            this.lblSummonCreatureUniqueLimit.AutoSize = true;
            this.lblSummonCreatureUniqueLimit.Location = new System.Drawing.Point(293, 181);
            this.lblSummonCreatureUniqueLimit.Name = "lblSummonCreatureUniqueLimit";
            this.lblSummonCreatureUniqueLimit.Size = new System.Drawing.Size(64, 13);
            this.lblSummonCreatureUniqueLimit.TabIndex = 12;
            this.lblSummonCreatureUniqueLimit.Text = "Unique limit:";
            // 
            // txtSummonCreatureUniqueRange
            // 
            this.txtSummonCreatureUniqueRange.Location = new System.Drawing.Point(387, 200);
            this.txtSummonCreatureUniqueRange.Name = "txtSummonCreatureUniqueRange";
            this.txtSummonCreatureUniqueRange.Size = new System.Drawing.Size(85, 20);
            this.txtSummonCreatureUniqueRange.TabIndex = 11;
            this.txtSummonCreatureUniqueRange.Leave += new System.EventHandler(this.txtSummonCreatureUniqueRange_Leave);
            // 
            // txtSummonCreatureUniqueLimit
            // 
            this.txtSummonCreatureUniqueLimit.Location = new System.Drawing.Point(292, 200);
            this.txtSummonCreatureUniqueLimit.Name = "txtSummonCreatureUniqueLimit";
            this.txtSummonCreatureUniqueLimit.Size = new System.Drawing.Size(85, 20);
            this.txtSummonCreatureUniqueLimit.TabIndex = 10;
            this.txtSummonCreatureUniqueLimit.Leave += new System.EventHandler(this.txtSummonCreatureUniqueLimit_Leave);
            // 
            // lblSummonCreatureSetRun
            // 
            this.lblSummonCreatureSetRun.AutoSize = true;
            this.lblSummonCreatureSetRun.Location = new System.Drawing.Point(41, 167);
            this.lblSummonCreatureSetRun.Name = "lblSummonCreatureSetRun";
            this.lblSummonCreatureSetRun.Size = new System.Drawing.Size(84, 13);
            this.lblSummonCreatureSetRun.TabIndex = 9;
            this.lblSummonCreatureSetRun.Text = "Runs by default:";
            // 
            // cmbSummonCreatureSetRun
            // 
            this.cmbSummonCreatureSetRun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSummonCreatureSetRun.FormattingEnabled = true;
            this.cmbSummonCreatureSetRun.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbSummonCreatureSetRun.Location = new System.Drawing.Point(131, 164);
            this.cmbSummonCreatureSetRun.Name = "cmbSummonCreatureSetRun";
            this.cmbSummonCreatureSetRun.Size = new System.Drawing.Size(143, 21);
            this.cmbSummonCreatureSetRun.TabIndex = 8;
            this.cmbSummonCreatureSetRun.SelectedIndexChanged += new System.EventHandler(this.cmbSummonCreatureSetRun_SelectedIndexChanged);
            // 
            // lblSummonCreatureFacingOptions
            // 
            this.lblSummonCreatureFacingOptions.AutoSize = true;
            this.lblSummonCreatureFacingOptions.Location = new System.Drawing.Point(46, 136);
            this.lblSummonCreatureFacingOptions.Name = "lblSummonCreatureFacingOptions";
            this.lblSummonCreatureFacingOptions.Size = new System.Drawing.Size(79, 13);
            this.lblSummonCreatureFacingOptions.TabIndex = 7;
            this.lblSummonCreatureFacingOptions.Text = "Facing options:";
            // 
            // cmbSummonCreatureFacingOptions
            // 
            this.cmbSummonCreatureFacingOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSummonCreatureFacingOptions.FormattingEnabled = true;
            this.cmbSummonCreatureFacingOptions.Items.AddRange(new object[] {
            "Provided Orientation",
            "Face Summoner",
            "Face Target"});
            this.cmbSummonCreatureFacingOptions.Location = new System.Drawing.Point(131, 133);
            this.cmbSummonCreatureFacingOptions.Name = "cmbSummonCreatureFacingOptions";
            this.cmbSummonCreatureFacingOptions.Size = new System.Drawing.Size(143, 21);
            this.cmbSummonCreatureFacingOptions.TabIndex = 6;
            this.cmbSummonCreatureFacingOptions.SelectedIndexChanged += new System.EventHandler(this.cmbSummonCreatureFacingOptions_SelectedIndexChanged);
            // 
            // lblSummonCreatureDelay
            // 
            this.lblSummonCreatureDelay.AutoSize = true;
            this.lblSummonCreatureDelay.Location = new System.Drawing.Point(20, 106);
            this.lblSummonCreatureDelay.Name = "lblSummonCreatureDelay";
            this.lblSummonCreatureDelay.Size = new System.Drawing.Size(105, 13);
            this.lblSummonCreatureDelay.TabIndex = 5;
            this.lblSummonCreatureDelay.Text = "Despawn delay (ms):";
            // 
            // txtSummonCreatureDelay
            // 
            this.txtSummonCreatureDelay.Location = new System.Drawing.Point(131, 103);
            this.txtSummonCreatureDelay.Name = "txtSummonCreatureDelay";
            this.txtSummonCreatureDelay.Size = new System.Drawing.Size(143, 20);
            this.txtSummonCreatureDelay.TabIndex = 4;
            this.txtSummonCreatureDelay.Leave += new System.EventHandler(this.txtSummonCreatureDelay_Leave);
            // 
            // lblSummonCreatureId
            // 
            this.lblSummonCreatureId.AutoSize = true;
            this.lblSummonCreatureId.Location = new System.Drawing.Point(20, 72);
            this.lblSummonCreatureId.Name = "lblSummonCreatureId";
            this.lblSummonCreatureId.Size = new System.Drawing.Size(62, 13);
            this.lblSummonCreatureId.TabIndex = 3;
            this.lblSummonCreatureId.Text = "Creature Id:";
            // 
            // grpSummonCreatureFlags
            // 
            this.grpSummonCreatureFlags.Controls.Add(this.chkSummonCreatureFlags64);
            this.grpSummonCreatureFlags.Controls.Add(this.chkSummonCreatureFlags32);
            this.grpSummonCreatureFlags.Controls.Add(this.chkSummonCreatureFlags16);
            this.grpSummonCreatureFlags.Location = new System.Drawing.Point(292, 58);
            this.grpSummonCreatureFlags.Name = "grpSummonCreatureFlags";
            this.grpSummonCreatureFlags.Size = new System.Drawing.Size(181, 114);
            this.grpSummonCreatureFlags.TabIndex = 2;
            this.grpSummonCreatureFlags.TabStop = false;
            this.grpSummonCreatureFlags.Text = "Summon Flags";
            // 
            // chkSummonCreatureFlags64
            // 
            this.chkSummonCreatureFlags64.AutoSize = true;
            this.chkSummonCreatureFlags64.Location = new System.Drawing.Point(10, 80);
            this.chkSummonCreatureFlags64.Name = "chkSummonCreatureFlags64";
            this.chkSummonCreatureFlags64.Size = new System.Drawing.Size(149, 17);
            this.chkSummonCreatureFlags64.TabIndex = 2;
            this.chkSummonCreatureFlags64.Text = "Unique Temporary Spawn";
            this.chkSummonCreatureFlags64.UseVisualStyleBackColor = true;
            this.chkSummonCreatureFlags64.CheckStateChanged += new System.EventHandler(this.chkSummonCreatureFlags64_CheckStateChanged);
            // 
            // chkSummonCreatureFlags32
            // 
            this.chkSummonCreatureFlags32.AutoSize = true;
            this.chkSummonCreatureFlags32.Location = new System.Drawing.Point(10, 54);
            this.chkSummonCreatureFlags32.Name = "chkSummonCreatureFlags32";
            this.chkSummonCreatureFlags32.Size = new System.Drawing.Size(96, 17);
            this.chkSummonCreatureFlags32.TabIndex = 1;
            this.chkSummonCreatureFlags32.Text = "Unique Spawn";
            this.chkSummonCreatureFlags32.UseVisualStyleBackColor = true;
            this.chkSummonCreatureFlags32.CheckedChanged += new System.EventHandler(this.chkSummonCreatureFlags32_CheckedChanged);
            // 
            // chkSummonCreatureFlags16
            // 
            this.chkSummonCreatureFlags16.AutoSize = true;
            this.chkSummonCreatureFlags16.Location = new System.Drawing.Point(11, 28);
            this.chkSummonCreatureFlags16.Name = "chkSummonCreatureFlags16";
            this.chkSummonCreatureFlags16.Size = new System.Drawing.Size(120, 17);
            this.chkSummonCreatureFlags16.TabIndex = 0;
            this.chkSummonCreatureFlags16.Text = "Make Active Object";
            this.chkSummonCreatureFlags16.UseVisualStyleBackColor = true;
            this.chkSummonCreatureFlags16.CheckedChanged += new System.EventHandler(this.chkSummonCreatureFlags16_CheckedChanged);
            // 
            // btnSummonCreatureId
            // 
            this.btnSummonCreatureId.Location = new System.Drawing.Point(83, 67);
            this.btnSummonCreatureId.Name = "btnSummonCreatureId";
            this.btnSummonCreatureId.Size = new System.Drawing.Size(191, 23);
            this.btnSummonCreatureId.TabIndex = 1;
            this.btnSummonCreatureId.Text = "-NONE-";
            this.btnSummonCreatureId.UseVisualStyleBackColor = true;
            this.btnSummonCreatureId.Click += new System.EventHandler(this.btnSummonCreatureId_Click);
            // 
            // lblSummonCreatureTooltip
            // 
            this.lblSummonCreatureTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSummonCreatureTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSummonCreatureTooltip.Name = "lblSummonCreatureTooltip";
            this.lblSummonCreatureTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSummonCreatureTooltip.TabIndex = 0;
            this.lblSummonCreatureTooltip.Text = "Temporarily summons a creature at the given coordinates. It despawns after the sp" +
    "ecified delay.";
            // 
            // frmCommandDoor
            // 
            this.frmCommandDoor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandDoor.Controls.Add(this.lblDoorResetDelay);
            this.frmCommandDoor.Controls.Add(this.lblDoorGuid);
            this.frmCommandDoor.Controls.Add(this.txtDoorResetDelay);
            this.frmCommandDoor.Controls.Add(this.txtDoorGuid);
            this.frmCommandDoor.Controls.Add(this.lblDoorTooltip);
            this.frmCommandDoor.Location = new System.Drawing.Point(409, 239);
            this.frmCommandDoor.Name = "frmCommandDoor";
            this.frmCommandDoor.Size = new System.Drawing.Size(495, 332);
            this.frmCommandDoor.TabIndex = 19;
            this.frmCommandDoor.Visible = false;
            // 
            // lblDoorResetDelay
            // 
            this.lblDoorResetDelay.AutoSize = true;
            this.lblDoorResetDelay.Location = new System.Drawing.Point(32, 96);
            this.lblDoorResetDelay.Name = "lblDoorResetDelay";
            this.lblDoorResetDelay.Size = new System.Drawing.Size(68, 13);
            this.lblDoorResetDelay.TabIndex = 4;
            this.lblDoorResetDelay.Text = "Reset Delay:";
            // 
            // lblDoorGuid
            // 
            this.lblDoorGuid.AutoSize = true;
            this.lblDoorGuid.Location = new System.Drawing.Point(37, 67);
            this.lblDoorGuid.Name = "lblDoorGuid";
            this.lblDoorGuid.Size = new System.Drawing.Size(63, 13);
            this.lblDoorGuid.TabIndex = 3;
            this.lblDoorGuid.Text = "Door GUID:";
            // 
            // txtDoorResetDelay
            // 
            this.txtDoorResetDelay.Location = new System.Drawing.Point(101, 93);
            this.txtDoorResetDelay.Name = "txtDoorResetDelay";
            this.txtDoorResetDelay.Size = new System.Drawing.Size(121, 20);
            this.txtDoorResetDelay.TabIndex = 2;
            this.txtDoorResetDelay.Leave += new System.EventHandler(this.txtDoorResetDelay_Leave);
            // 
            // txtDoorGuid
            // 
            this.txtDoorGuid.Location = new System.Drawing.Point(101, 64);
            this.txtDoorGuid.Name = "txtDoorGuid";
            this.txtDoorGuid.Size = new System.Drawing.Size(121, 20);
            this.txtDoorGuid.TabIndex = 1;
            this.txtDoorGuid.Leave += new System.EventHandler(this.txtDoorGuid_Leave);
            // 
            // lblDoorTooltip
            // 
            this.lblDoorTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDoorTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblDoorTooltip.Name = "lblDoorTooltip";
            this.lblDoorTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblDoorTooltip.TabIndex = 0;
            this.lblDoorTooltip.Text = "Opens the specified door GameObject, then resets it back to its original state af" +
    "ter the delay expires. If the provided target is a button, it gets toggled as we" +
    "ll.";
            // 
            // frmCommandRemoveAura
            // 
            this.frmCommandRemoveAura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandRemoveAura.Controls.Add(this.btnRemoveAuraSpellId);
            this.frmCommandRemoveAura.Controls.Add(this.lblRemoveAuraSpellId);
            this.frmCommandRemoveAura.Controls.Add(this.lblRemoveAuraTooltip);
            this.frmCommandRemoveAura.Location = new System.Drawing.Point(409, 239);
            this.frmCommandRemoveAura.Name = "frmCommandRemoveAura";
            this.frmCommandRemoveAura.Size = new System.Drawing.Size(495, 332);
            this.frmCommandRemoveAura.TabIndex = 20;
            this.frmCommandRemoveAura.Visible = false;
            // 
            // btnRemoveAuraSpellId
            // 
            this.btnRemoveAuraSpellId.Location = new System.Drawing.Point(69, 57);
            this.btnRemoveAuraSpellId.Name = "btnRemoveAuraSpellId";
            this.btnRemoveAuraSpellId.Size = new System.Drawing.Size(404, 23);
            this.btnRemoveAuraSpellId.TabIndex = 2;
            this.btnRemoveAuraSpellId.Text = "-NONE-";
            this.btnRemoveAuraSpellId.UseVisualStyleBackColor = true;
            this.btnRemoveAuraSpellId.Click += new System.EventHandler(this.btnRemoveAuraSpellId_Click);
            // 
            // lblRemoveAuraSpellId
            // 
            this.lblRemoveAuraSpellId.AutoSize = true;
            this.lblRemoveAuraSpellId.Location = new System.Drawing.Point(23, 61);
            this.lblRemoveAuraSpellId.Name = "lblRemoveAuraSpellId";
            this.lblRemoveAuraSpellId.Size = new System.Drawing.Size(45, 13);
            this.lblRemoveAuraSpellId.TabIndex = 1;
            this.lblRemoveAuraSpellId.Text = "Spell Id:";
            // 
            // lblRemoveAuraTooltip
            // 
            this.lblRemoveAuraTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRemoveAuraTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblRemoveAuraTooltip.Name = "lblRemoveAuraTooltip";
            this.lblRemoveAuraTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblRemoveAuraTooltip.TabIndex = 0;
            this.lblRemoveAuraTooltip.Text = "Removes any auras from the source Unit caused by the specified spell.";
            // 
            // frmCommandCastSpell
            // 
            this.frmCommandCastSpell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandCastSpell.Controls.Add(this.grpCastSpellFlags);
            this.frmCommandCastSpell.Controls.Add(this.btnCastSpellId);
            this.frmCommandCastSpell.Controls.Add(this.lblCastSpellId);
            this.frmCommandCastSpell.Controls.Add(this.lblCastSpellTooltip);
            this.frmCommandCastSpell.Location = new System.Drawing.Point(409, 239);
            this.frmCommandCastSpell.Name = "frmCommandCastSpell";
            this.frmCommandCastSpell.Size = new System.Drawing.Size(495, 332);
            this.frmCommandCastSpell.TabIndex = 21;
            this.frmCommandCastSpell.Visible = false;
            // 
            // grpCastSpellFlags
            // 
            this.grpCastSpellFlags.Controls.Add(this.chkCastSpellFlags2);
            this.grpCastSpellFlags.Controls.Add(this.chkCastSpellFlags1);
            this.grpCastSpellFlags.Location = new System.Drawing.Point(26, 88);
            this.grpCastSpellFlags.Name = "grpCastSpellFlags";
            this.grpCastSpellFlags.Size = new System.Drawing.Size(447, 48);
            this.grpCastSpellFlags.TabIndex = 3;
            this.grpCastSpellFlags.TabStop = false;
            this.grpCastSpellFlags.Text = "Cast Flags";
            // 
            // chkCastSpellFlags2
            // 
            this.chkCastSpellFlags2.AutoSize = true;
            this.chkCastSpellFlags2.Location = new System.Drawing.Point(85, 21);
            this.chkCastSpellFlags2.Name = "chkCastSpellFlags2";
            this.chkCastSpellFlags2.Size = new System.Drawing.Size(109, 17);
            this.chkCastSpellFlags2.TabIndex = 1;
            this.chkCastSpellFlags2.Text = "Interrupt Previous";
            this.chkCastSpellFlags2.UseVisualStyleBackColor = true;
            this.chkCastSpellFlags2.CheckedChanged += new System.EventHandler(this.chkCastSpellFlags2_CheckedChanged);
            // 
            // chkCastSpellFlags1
            // 
            this.chkCastSpellFlags1.AutoSize = true;
            this.chkCastSpellFlags1.Location = new System.Drawing.Point(10, 21);
            this.chkCastSpellFlags1.Name = "chkCastSpellFlags1";
            this.chkCastSpellFlags1.Size = new System.Drawing.Size(71, 17);
            this.chkCastSpellFlags1.TabIndex = 0;
            this.chkCastSpellFlags1.Text = "Triggered";
            this.chkCastSpellFlags1.UseVisualStyleBackColor = true;
            this.chkCastSpellFlags1.CheckedChanged += new System.EventHandler(this.chkCastSpellFlags1_CheckedChanged);
            // 
            // btnCastSpellId
            // 
            this.btnCastSpellId.Location = new System.Drawing.Point(69, 57);
            this.btnCastSpellId.Name = "btnCastSpellId";
            this.btnCastSpellId.Size = new System.Drawing.Size(404, 23);
            this.btnCastSpellId.TabIndex = 2;
            this.btnCastSpellId.Text = "-NONE-";
            this.btnCastSpellId.UseVisualStyleBackColor = true;
            this.btnCastSpellId.Click += new System.EventHandler(this.btnCastSpellId_Click);
            // 
            // lblCastSpellId
            // 
            this.lblCastSpellId.AutoSize = true;
            this.lblCastSpellId.Location = new System.Drawing.Point(23, 61);
            this.lblCastSpellId.Name = "lblCastSpellId";
            this.lblCastSpellId.Size = new System.Drawing.Size(45, 13);
            this.lblCastSpellId.TabIndex = 1;
            this.lblCastSpellId.Text = "Spell Id:";
            // 
            // lblCastSpellTooltip
            // 
            this.lblCastSpellTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCastSpellTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblCastSpellTooltip.Name = "lblCastSpellTooltip";
            this.lblCastSpellTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblCastSpellTooltip.TabIndex = 0;
            this.lblCastSpellTooltip.Text = "The source Unit casts the specified spell on the Unit target.";
            // 
            // frmCommandPlaySound
            // 
            this.frmCommandPlaySound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandPlaySound.Controls.Add(this.grpPlaySoundFlags);
            this.frmCommandPlaySound.Controls.Add(this.txtPlaySoundId);
            this.frmCommandPlaySound.Controls.Add(this.lblPlaySoundId);
            this.frmCommandPlaySound.Controls.Add(this.lblPlaySoundTooltip);
            this.frmCommandPlaySound.Location = new System.Drawing.Point(409, 239);
            this.frmCommandPlaySound.Name = "frmCommandPlaySound";
            this.frmCommandPlaySound.Size = new System.Drawing.Size(495, 332);
            this.frmCommandPlaySound.TabIndex = 22;
            this.frmCommandPlaySound.Visible = false;
            // 
            // grpPlaySoundFlags
            // 
            this.grpPlaySoundFlags.Controls.Add(this.chkPlaySoundFlags2);
            this.grpPlaySoundFlags.Controls.Add(this.chkPlaySoundFlags1);
            this.grpPlaySoundFlags.Location = new System.Drawing.Point(26, 83);
            this.grpPlaySoundFlags.Name = "grpPlaySoundFlags";
            this.grpPlaySoundFlags.Size = new System.Drawing.Size(181, 83);
            this.grpPlaySoundFlags.TabIndex = 3;
            this.grpPlaySoundFlags.TabStop = false;
            this.grpPlaySoundFlags.Text = "Flags";
            // 
            // chkPlaySoundFlags2
            // 
            this.chkPlaySoundFlags2.AutoSize = true;
            this.chkPlaySoundFlags2.Location = new System.Drawing.Point(9, 52);
            this.chkPlaySoundFlags2.Name = "chkPlaySoundFlags2";
            this.chkPlaySoundFlags2.Size = new System.Drawing.Size(124, 17);
            this.chkPlaySoundFlags2.TabIndex = 1;
            this.chkPlaySoundFlags2.Text = "Distance Dependent";
            this.chkPlaySoundFlags2.UseVisualStyleBackColor = true;
            this.chkPlaySoundFlags2.CheckedChanged += new System.EventHandler(this.chkPlaySoundFlags2_CheckedChanged);
            // 
            // chkPlaySoundFlags1
            // 
            this.chkPlaySoundFlags1.AutoSize = true;
            this.chkPlaySoundFlags1.Location = new System.Drawing.Point(9, 26);
            this.chkPlaySoundFlags1.Name = "chkPlaySoundFlags1";
            this.chkPlaySoundFlags1.Size = new System.Drawing.Size(97, 17);
            this.chkPlaySoundFlags1.TabIndex = 0;
            this.chkPlaySoundFlags1.Text = "Only To Target";
            this.chkPlaySoundFlags1.UseVisualStyleBackColor = true;
            this.chkPlaySoundFlags1.CheckedChanged += new System.EventHandler(this.chkPlaySoundFlags1_CheckedChanged);
            // 
            // txtPlaySoundId
            // 
            this.txtPlaySoundId.Location = new System.Drawing.Point(78, 52);
            this.txtPlaySoundId.Name = "txtPlaySoundId";
            this.txtPlaySoundId.Size = new System.Drawing.Size(129, 20);
            this.txtPlaySoundId.TabIndex = 2;
            this.txtPlaySoundId.Leave += new System.EventHandler(this.txtPlaySoundId_Leave);
            // 
            // lblPlaySoundId
            // 
            this.lblPlaySoundId.AutoSize = true;
            this.lblPlaySoundId.Location = new System.Drawing.Point(25, 55);
            this.lblPlaySoundId.Name = "lblPlaySoundId";
            this.lblPlaySoundId.Size = new System.Drawing.Size(53, 13);
            this.lblPlaySoundId.TabIndex = 1;
            this.lblPlaySoundId.Text = "Sound Id:";
            // 
            // lblPlaySoundTooltip
            // 
            this.lblPlaySoundTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlaySoundTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblPlaySoundTooltip.Name = "lblPlaySoundTooltip";
            this.lblPlaySoundTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblPlaySoundTooltip.TabIndex = 0;
            this.lblPlaySoundTooltip.Text = "Plays the specified sound entry.";
            // 
            // frmCommandCreateItem
            // 
            this.frmCommandCreateItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandCreateItem.Controls.Add(this.lblCreateItemAmount);
            this.frmCommandCreateItem.Controls.Add(this.txtCreateItemAmount);
            this.frmCommandCreateItem.Controls.Add(this.btnCreateItemId);
            this.frmCommandCreateItem.Controls.Add(this.lblCreateItemId);
            this.frmCommandCreateItem.Controls.Add(this.lblCreateItemTooltip);
            this.frmCommandCreateItem.Location = new System.Drawing.Point(409, 239);
            this.frmCommandCreateItem.Name = "frmCommandCreateItem";
            this.frmCommandCreateItem.Size = new System.Drawing.Size(495, 332);
            this.frmCommandCreateItem.TabIndex = 23;
            this.frmCommandCreateItem.Visible = false;
            // 
            // lblCreateItemAmount
            // 
            this.lblCreateItemAmount.AutoSize = true;
            this.lblCreateItemAmount.Location = new System.Drawing.Point(68, 102);
            this.lblCreateItemAmount.Name = "lblCreateItemAmount";
            this.lblCreateItemAmount.Size = new System.Drawing.Size(46, 13);
            this.lblCreateItemAmount.TabIndex = 4;
            this.lblCreateItemAmount.Text = "Amount:";
            // 
            // txtCreateItemAmount
            // 
            this.txtCreateItemAmount.Location = new System.Drawing.Point(118, 100);
            this.txtCreateItemAmount.Name = "txtCreateItemAmount";
            this.txtCreateItemAmount.Size = new System.Drawing.Size(355, 20);
            this.txtCreateItemAmount.TabIndex = 3;
            this.txtCreateItemAmount.Leave += new System.EventHandler(this.txtCreateItemAmount_Leave);
            // 
            // btnCreateItemId
            // 
            this.btnCreateItemId.Location = new System.Drawing.Point(118, 66);
            this.btnCreateItemId.Name = "btnCreateItemId";
            this.btnCreateItemId.Size = new System.Drawing.Size(355, 23);
            this.btnCreateItemId.TabIndex = 2;
            this.btnCreateItemId.Text = "-NONE-";
            this.btnCreateItemId.UseVisualStyleBackColor = true;
            this.btnCreateItemId.Click += new System.EventHandler(this.btnCreateItemId_Click);
            // 
            // lblCreateItemId
            // 
            this.lblCreateItemId.AutoSize = true;
            this.lblCreateItemId.Location = new System.Drawing.Point(72, 71);
            this.lblCreateItemId.Name = "lblCreateItemId";
            this.lblCreateItemId.Size = new System.Drawing.Size(42, 13);
            this.lblCreateItemId.TabIndex = 1;
            this.lblCreateItemId.Text = "Item Id:";
            // 
            // lblCreateItemTooltip
            // 
            this.lblCreateItemTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCreateItemTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblCreateItemTooltip.Name = "lblCreateItemTooltip";
            this.lblCreateItemTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblCreateItemTooltip.TabIndex = 0;
            this.lblCreateItemTooltip.Text = "Adds the specified item to the target Player\'s inventory.";
            // 
            // frmCommandDespawnCreature
            // 
            this.frmCommandDespawnCreature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandDespawnCreature.Controls.Add(this.lblDespawnCreatureDelay);
            this.frmCommandDespawnCreature.Controls.Add(this.txtDespawnCreatureDelay);
            this.frmCommandDespawnCreature.Controls.Add(this.lblDespawnCreatureTooltip);
            this.frmCommandDespawnCreature.Location = new System.Drawing.Point(409, 239);
            this.frmCommandDespawnCreature.Name = "frmCommandDespawnCreature";
            this.frmCommandDespawnCreature.Size = new System.Drawing.Size(495, 332);
            this.frmCommandDespawnCreature.TabIndex = 24;
            this.frmCommandDespawnCreature.Visible = false;
            // 
            // lblDespawnCreatureTooltip
            // 
            this.lblDespawnCreatureTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDespawnCreatureTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblDespawnCreatureTooltip.Name = "lblDespawnCreatureTooltip";
            this.lblDespawnCreatureTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblDespawnCreatureTooltip.TabIndex = 0;
            this.lblDespawnCreatureTooltip.Text = "Despawns the source Creature after the specified delay.";
            // 
            // txtDespawnCreatureDelay
            // 
            this.txtDespawnCreatureDelay.Location = new System.Drawing.Point(93, 62);
            this.txtDespawnCreatureDelay.Name = "txtDespawnCreatureDelay";
            this.txtDespawnCreatureDelay.Size = new System.Drawing.Size(150, 20);
            this.txtDespawnCreatureDelay.TabIndex = 1;
            this.txtDespawnCreatureDelay.Leave += new System.EventHandler(this.txtDespawnCreatureDelay_Leave);
            // 
            // lblDespawnCreatureDelay
            // 
            this.lblDespawnCreatureDelay.AutoSize = true;
            this.lblDespawnCreatureDelay.Location = new System.Drawing.Point(31, 65);
            this.lblDespawnCreatureDelay.Name = "lblDespawnCreatureDelay";
            this.lblDespawnCreatureDelay.Size = new System.Drawing.Size(59, 13);
            this.lblDespawnCreatureDelay.TabIndex = 2;
            this.lblDespawnCreatureDelay.Text = "Delay (ms):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 610);
            this.Controls.Add(this.frmCommandDespawnCreature);
            this.Controls.Add(this.frmCommandCreateItem);
            this.Controls.Add(this.frmCommandPlaySound);
            this.Controls.Add(this.frmCommandCastSpell);
            this.Controls.Add(this.frmCommandRemoveAura);
            this.Controls.Add(this.frmCommandDoor);
            this.Controls.Add(this.frmCommandSummonCreature);
            this.Controls.Add(this.frmCommandRespawnGameobject);
            this.Controls.Add(this.frmCommandKillCredit);
            this.Controls.Add(this.frmCommandQuestComplete);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
            this.grpTeleportOptions.ResumeLayout(false);
            this.grpTeleportOptions.PerformLayout();
            this.frmCommandQuestComplete.ResumeLayout(false);
            this.frmCommandQuestComplete.PerformLayout();
            this.frmCommandKillCredit.ResumeLayout(false);
            this.frmCommandKillCredit.PerformLayout();
            this.frmCommandRespawnGameobject.ResumeLayout(false);
            this.frmCommandRespawnGameobject.PerformLayout();
            this.frmCommandSummonCreature.ResumeLayout(false);
            this.frmCommandSummonCreature.PerformLayout();
            this.grpSummonCreatureFlags.ResumeLayout(false);
            this.grpSummonCreatureFlags.PerformLayout();
            this.frmCommandDoor.ResumeLayout(false);
            this.frmCommandDoor.PerformLayout();
            this.frmCommandRemoveAura.ResumeLayout(false);
            this.frmCommandRemoveAura.PerformLayout();
            this.frmCommandCastSpell.ResumeLayout(false);
            this.frmCommandCastSpell.PerformLayout();
            this.grpCastSpellFlags.ResumeLayout(false);
            this.grpCastSpellFlags.PerformLayout();
            this.frmCommandPlaySound.ResumeLayout(false);
            this.frmCommandPlaySound.PerformLayout();
            this.grpPlaySoundFlags.ResumeLayout(false);
            this.grpPlaySoundFlags.PerformLayout();
            this.frmCommandCreateItem.ResumeLayout(false);
            this.frmCommandCreateItem.PerformLayout();
            this.frmCommandDespawnCreature.ResumeLayout(false);
            this.frmCommandDespawnCreature.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpTeleportOptions;
        private System.Windows.Forms.CheckBox chkTeleportOptions32;
        private System.Windows.Forms.CheckBox chkTeleportOptions16;
        private System.Windows.Forms.CheckBox chkTeleportOptions8;
        private System.Windows.Forms.CheckBox chkTeleportOptions4;
        private System.Windows.Forms.CheckBox chkTeleportOptions2;
        private System.Windows.Forms.CheckBox chkTeleportOptions1;
        private System.Windows.Forms.Panel frmCommandQuestComplete;
        private System.Windows.Forms.Label lblQuestCompleteId;
        private System.Windows.Forms.Label lblQuestCompleteDistance;
        private System.Windows.Forms.TextBox txtQuestCompleteDistance;
        private System.Windows.Forms.Button btnQuestCompleteId;
        private System.Windows.Forms.Label lblQuestCompleteTooltip;
        private System.Windows.Forms.Panel frmCommandKillCredit;
        private System.Windows.Forms.ComboBox cmbKillCreditType;
        private System.Windows.Forms.Label lblKillCreditCreatureId;
        private System.Windows.Forms.Label lblKillCreditType;
        private System.Windows.Forms.Button btnKillCreditCreatureId;
        private System.Windows.Forms.Label lblKillCreditTooltip;
        private System.Windows.Forms.Panel frmCommandRespawnGameobject;
        private System.Windows.Forms.Label lblRespawnGameobjectDelay;
        private System.Windows.Forms.Label lblRespawnGameobjectGuid;
        private System.Windows.Forms.TextBox txtRespawnGameobjectDelay;
        private System.Windows.Forms.TextBox txtRespawnGameobjectGuid;
        private System.Windows.Forms.Label lblRespawnGameobjectTooltip;
        private System.Windows.Forms.Panel frmCommandSummonCreature;
        private System.Windows.Forms.Label lblSummonCreatureId;
        private System.Windows.Forms.GroupBox grpSummonCreatureFlags;
        private System.Windows.Forms.CheckBox chkSummonCreatureFlags64;
        private System.Windows.Forms.CheckBox chkSummonCreatureFlags32;
        private System.Windows.Forms.CheckBox chkSummonCreatureFlags16;
        private System.Windows.Forms.Button btnSummonCreatureId;
        private System.Windows.Forms.Label lblSummonCreatureTooltip;
        private System.Windows.Forms.Label lblSummonCreatureDelay;
        private System.Windows.Forms.TextBox txtSummonCreatureDelay;
        private System.Windows.Forms.TextBox txtSummonCreatureY;
        private System.Windows.Forms.TextBox txtSummonCreatureX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSummonCreatureUniqueLimit;
        private System.Windows.Forms.TextBox txtSummonCreatureUniqueRange;
        private System.Windows.Forms.TextBox txtSummonCreatureUniqueLimit;
        private System.Windows.Forms.Label lblSummonCreatureSetRun;
        private System.Windows.Forms.ComboBox cmbSummonCreatureSetRun;
        private System.Windows.Forms.Label lblSummonCreatureFacingOptions;
        private System.Windows.Forms.ComboBox cmbSummonCreatureFacingOptions;
        private System.Windows.Forms.Label lblSummonCreatureO;
        private System.Windows.Forms.Label lblSummonCreatureZ;
        private System.Windows.Forms.Label lblSummonCreatureY;
        private System.Windows.Forms.Label lblSummonCreatureX;
        private System.Windows.Forms.TextBox txtSummonCreatureO;
        private System.Windows.Forms.TextBox txtSummonCreatureZ;
        private System.Windows.Forms.Panel frmCommandDoor;
        private System.Windows.Forms.Label lblDoorResetDelay;
        private System.Windows.Forms.Label lblDoorGuid;
        private System.Windows.Forms.TextBox txtDoorResetDelay;
        private System.Windows.Forms.TextBox txtDoorGuid;
        private System.Windows.Forms.Label lblDoorTooltip;
        private System.Windows.Forms.Panel frmCommandRemoveAura;
        private System.Windows.Forms.Button btnRemoveAuraSpellId;
        private System.Windows.Forms.Label lblRemoveAuraSpellId;
        private System.Windows.Forms.Label lblRemoveAuraTooltip;
        private System.Windows.Forms.Panel frmCommandCastSpell;
        private System.Windows.Forms.GroupBox grpCastSpellFlags;
        private System.Windows.Forms.CheckBox chkCastSpellFlags2;
        private System.Windows.Forms.CheckBox chkCastSpellFlags1;
        private System.Windows.Forms.Button btnCastSpellId;
        private System.Windows.Forms.Label lblCastSpellId;
        private System.Windows.Forms.Label lblCastSpellTooltip;
        private System.Windows.Forms.Panel frmCommandPlaySound;
        private System.Windows.Forms.GroupBox grpPlaySoundFlags;
        private System.Windows.Forms.CheckBox chkPlaySoundFlags2;
        private System.Windows.Forms.CheckBox chkPlaySoundFlags1;
        private System.Windows.Forms.TextBox txtPlaySoundId;
        private System.Windows.Forms.Label lblPlaySoundId;
        private System.Windows.Forms.Label lblPlaySoundTooltip;
        private System.Windows.Forms.Panel frmCommandCreateItem;
        private System.Windows.Forms.Label lblCreateItemAmount;
        private System.Windows.Forms.TextBox txtCreateItemAmount;
        private System.Windows.Forms.Button btnCreateItemId;
        private System.Windows.Forms.Label lblCreateItemId;
        private System.Windows.Forms.Label lblCreateItemTooltip;
        private System.Windows.Forms.Panel frmCommandDespawnCreature;
        private System.Windows.Forms.Label lblDespawnCreatureDelay;
        private System.Windows.Forms.TextBox txtDespawnCreatureDelay;
        private System.Windows.Forms.Label lblDespawnCreatureTooltip;
    }
}

