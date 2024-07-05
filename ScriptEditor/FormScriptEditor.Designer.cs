namespace ScriptEditor
{
    partial class FormScriptEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScriptEditor));
            this.lstActions = new System.Windows.Forms.ListView();
            this.columnDelay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCommand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblId = new System.Windows.Forms.Label();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtScriptId = new System.Windows.Forms.TextBox();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.txtCommandPriority = new System.Windows.Forms.TextBox();
            this.lblCommandCondition = new System.Windows.Forms.Label();
            this.btnCommandCondition = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtCommandComment = new System.Windows.Forms.TextBox();
            this.grpDataFlags = new System.Windows.Forms.GroupBox();
            this.chkSkipMissingTargets = new System.Windows.Forms.CheckBox();
            this.chkAbortScript = new System.Windows.Forms.CheckBox();
            this.chkTargetSelf = new System.Windows.Forms.CheckBox();
            this.chkSwapFinal = new System.Windows.Forms.CheckBox();
            this.chkSwapInitial = new System.Windows.Forms.CheckBox();
            this.grpBuddy = new System.Windows.Forms.GroupBox();
            this.btnTargetParam1 = new System.Windows.Forms.Button();
            this.lblTargetType = new System.Windows.Forms.Label();
            this.txtTargetParam1 = new System.Windows.Forms.TextBox();
            this.cmbTargetType = new System.Windows.Forms.ComboBox();
            this.lblTargetParam2 = new System.Windows.Forms.Label();
            this.txtTargetParam2 = new System.Windows.Forms.TextBox();
            this.lblTargetParam1 = new System.Windows.Forms.Label();
            this.txtCommandDelay = new System.Windows.Forms.TextBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblCommand = new System.Windows.Forms.Label();
            this.cmbCommandId = new System.Windows.Forms.ComboBox();
            this.frmCommandTalk = new System.Windows.Forms.Panel();
            this.lblTalkTextPreview = new System.Windows.Forms.Label();
            this.lblTalkBroadcastId = new System.Windows.Forms.Label();
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
            this.btnActionDelete = new System.Windows.Forms.Button();
            this.btnActionAdd = new System.Windows.Forms.Button();
            this.lblScriptId = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.frmCommandEmote = new System.Windows.Forms.Panel();
            this.cmbEmoteTargeted = new System.Windows.Forms.ComboBox();
            this.lblEmoteTargeted = new System.Windows.Forms.Label();
            this.cmbEmoteId4 = new System.Windows.Forms.ComboBox();
            this.lblEmoteId4 = new System.Windows.Forms.Label();
            this.cmbEmoteId3 = new System.Windows.Forms.ComboBox();
            this.lblEmoteId3 = new System.Windows.Forms.Label();
            this.cmbEmoteId2 = new System.Windows.Forms.ComboBox();
            this.lblEmoteId2 = new System.Windows.Forms.Label();
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
            this.lblMoveToPointId = new System.Windows.Forms.Label();
            this.txtMoveToPointId = new System.Windows.Forms.TextBox();
            this.chkMoveToFlagsPointMovement = new System.Windows.Forms.CheckBox();
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
            this.lblQuestCompleteGroup = new System.Windows.Forms.Label();
            this.cmbQuestCompleteGroup = new System.Windows.Forms.ComboBox();
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
            this.btnSummonCreatureScriptIdEdit = new System.Windows.Forms.Button();
            this.txtSummonCreatureScriptId = new System.Windows.Forms.TextBox();
            this.lblSummonCreatureDespawnType = new System.Windows.Forms.Label();
            this.cmbSummonCreatureDespawnType = new System.Windows.Forms.ComboBox();
            this.lblSummonCreatureO = new System.Windows.Forms.Label();
            this.lblSummonCreatureZ = new System.Windows.Forms.Label();
            this.lblSummonCreatureY = new System.Windows.Forms.Label();
            this.lblSummonCreatureX = new System.Windows.Forms.Label();
            this.txtSummonCreatureO = new System.Windows.Forms.TextBox();
            this.txtSummonCreatureZ = new System.Windows.Forms.TextBox();
            this.txtSummonCreatureY = new System.Windows.Forms.TextBox();
            this.txtSummonCreatureX = new System.Windows.Forms.TextBox();
            this.lblSummonCreatureUniqueRange = new System.Windows.Forms.Label();
            this.lblSummonCreatureUniqueLimit = new System.Windows.Forms.Label();
            this.txtSummonCreatureUniqueRange = new System.Windows.Forms.TextBox();
            this.txtSummonCreatureUniqueLimit = new System.Windows.Forms.TextBox();
            this.lblSummonCreatureAttackTarget = new System.Windows.Forms.Label();
            this.cmbSummonCreatureAttackTarget = new System.Windows.Forms.ComboBox();
            this.lblSummonCreatureScriptId = new System.Windows.Forms.Label();
            this.lblSummonCreatureDelay = new System.Windows.Forms.Label();
            this.txtSummonCreatureDelay = new System.Windows.Forms.TextBox();
            this.lblSummonCreatureId = new System.Windows.Forms.Label();
            this.grpSummonCreatureFlags = new System.Windows.Forms.GroupBox();
            this.chkSummonCreatureFlags16 = new System.Windows.Forms.CheckBox();
            this.chkSummonCreatureFlags1 = new System.Windows.Forms.CheckBox();
            this.chkSummonCreatureFlags8 = new System.Windows.Forms.CheckBox();
            this.chkSummonCreatureFlags4 = new System.Windows.Forms.CheckBox();
            this.chkSummonCreatureFlags2 = new System.Windows.Forms.CheckBox();
            this.btnSummonCreatureId = new System.Windows.Forms.Button();
            this.lblSummonCreatureTooltip = new System.Windows.Forms.Label();
            this.frmCommandDoor = new System.Windows.Forms.Panel();
            this.lblDoorResetDelay = new System.Windows.Forms.Label();
            this.lblDoorGuid = new System.Windows.Forms.Label();
            this.txtDoorResetDelay = new System.Windows.Forms.TextBox();
            this.txtDoorGuid = new System.Windows.Forms.TextBox();
            this.lblDoorTooltip = new System.Windows.Forms.Label();
            this.frmCommandRemoveAura = new System.Windows.Forms.Panel();
            this.grpAddAuraFlags = new System.Windows.Forms.GroupBox();
            this.chkAddAuraFlag8 = new System.Windows.Forms.CheckBox();
            this.chkAddAuraFlag4 = new System.Windows.Forms.CheckBox();
            this.chkAddAuraFlag2 = new System.Windows.Forms.CheckBox();
            this.chkAddAuraFlag1 = new System.Windows.Forms.CheckBox();
            this.btnRemoveAuraSpellId = new System.Windows.Forms.Button();
            this.lblRemoveAuraSpellId = new System.Windows.Forms.Label();
            this.lblRemoveAuraTooltip = new System.Windows.Forms.Label();
            this.frmCommandCastSpell = new System.Windows.Forms.Panel();
            this.grpCastSpellFlags = new System.Windows.Forms.GroupBox();
            this.chkCastSpellFlags128 = new System.Windows.Forms.CheckBox();
            this.chkCastSpellFlags64 = new System.Windows.Forms.CheckBox();
            this.chkCastSpellFlags32 = new System.Windows.Forms.CheckBox();
            this.chkCastSpellFlags16 = new System.Windows.Forms.CheckBox();
            this.chkCastSpellFlags4 = new System.Windows.Forms.CheckBox();
            this.chkCastSpellFlags1 = new System.Windows.Forms.CheckBox();
            this.chkCastSpellFlags2 = new System.Windows.Forms.CheckBox();
            this.btnCastSpellId = new System.Windows.Forms.Button();
            this.lblCastSpellId = new System.Windows.Forms.Label();
            this.lblCastSpellTooltip = new System.Windows.Forms.Label();
            this.frmCommandPlaySound = new System.Windows.Forms.Panel();
            this.btnPlaySoundId = new System.Windows.Forms.Button();
            this.grpPlaySoundFlags = new System.Windows.Forms.GroupBox();
            this.chkPlaySoundFlags4 = new System.Windows.Forms.CheckBox();
            this.chkPlaySoundFlags2 = new System.Windows.Forms.CheckBox();
            this.chkPlaySoundFlags1 = new System.Windows.Forms.CheckBox();
            this.lblPlaySoundId = new System.Windows.Forms.Label();
            this.lblPlaySoundTooltip = new System.Windows.Forms.Label();
            this.frmCommandCreateItem = new System.Windows.Forms.Panel();
            this.lblCreateItemAmount = new System.Windows.Forms.Label();
            this.txtCreateItemAmount = new System.Windows.Forms.TextBox();
            this.btnCreateItemId = new System.Windows.Forms.Button();
            this.lblCreateItemId = new System.Windows.Forms.Label();
            this.lblCreateItemTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetEquipment = new System.Windows.Forms.Panel();
            this.lblSetEquipmentRanged = new System.Windows.Forms.Label();
            this.lblSetEquipmentOffHand = new System.Windows.Forms.Label();
            this.lblSetEquipmentMainHand = new System.Windows.Forms.Label();
            this.btnSetEquipmentRanged = new System.Windows.Forms.Button();
            this.btnSetEquipmentOffHand = new System.Windows.Forms.Button();
            this.btnSetEquipmentMainHand = new System.Windows.Forms.Button();
            this.cmbSetEquipmentUseDefault = new System.Windows.Forms.ComboBox();
            this.lblSetEquipmentUseDefault = new System.Windows.Forms.Label();
            this.lblSetEquipmentTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetMovement = new System.Windows.Forms.Panel();
            this.cmbSetMovementClearMotionMaster = new System.Windows.Forms.ComboBox();
            this.lblSetMovementClearMotionMaster = new System.Windows.Forms.Label();
            this.lblSetMovementAngle = new System.Windows.Forms.Label();
            this.txtSetMovementAngle = new System.Windows.Forms.TextBox();
            this.txtSetMovementDistance = new System.Windows.Forms.TextBox();
            this.txtSetMovementIntParam = new System.Windows.Forms.TextBox();
            this.cmbSetMovementBoolParam = new System.Windows.Forms.ComboBox();
            this.lblSetMovementDistance = new System.Windows.Forms.Label();
            this.lblSetMovementIntParam = new System.Windows.Forms.Label();
            this.lblSetMovementBoolParam = new System.Windows.Forms.Label();
            this.cmbSetMovementType = new System.Windows.Forms.ComboBox();
            this.lblSetMovementType = new System.Windows.Forms.Label();
            this.lblSetMovementTooltip = new System.Windows.Forms.Label();
            this.frmCommandActiveObject = new System.Windows.Forms.Panel();
            this.cmbActiveObjectSetActive = new System.Windows.Forms.ComboBox();
            this.lblActiveObjectSetActive = new System.Windows.Forms.Label();
            this.lblActiveObjectTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetFaction = new System.Windows.Forms.Panel();
            this.btnSetFactionId = new System.Windows.Forms.Button();
            this.grpSetFactionFlags = new System.Windows.Forms.GroupBox();
            this.chkSetFactionFlag4 = new System.Windows.Forms.CheckBox();
            this.chkSetFactionFlag2 = new System.Windows.Forms.CheckBox();
            this.chkSetFactionFlag1 = new System.Windows.Forms.CheckBox();
            this.lblSetFactionId = new System.Windows.Forms.Label();
            this.lblSetFactionTooltip = new System.Windows.Forms.Label();
            this.frmCommandMorphOrMount = new System.Windows.Forms.Panel();
            this.cmbMorphOrMountPermanent = new System.Windows.Forms.ComboBox();
            this.lblMorphOrMountPermanent = new System.Windows.Forms.Label();
            this.cmbMorphOrMountType = new System.Windows.Forms.ComboBox();
            this.lblMorphOrMountId = new System.Windows.Forms.Label();
            this.lblMorphOrMountType = new System.Windows.Forms.Label();
            this.btnMorphOrMountId = new System.Windows.Forms.Button();
            this.lblMorphOrMountTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetRun = new System.Windows.Forms.Panel();
            this.cmbSetRunMode = new System.Windows.Forms.ComboBox();
            this.lblSetRunMode = new System.Windows.Forms.Label();
            this.lblSetRunTooltip = new System.Windows.Forms.Label();
            this.frmCommandModifyFlags = new System.Windows.Forms.Panel();
            this.btnModifyFlagsFlags = new System.Windows.Forms.Button();
            this.lblModifyFlagsFlags = new System.Windows.Forms.Label();
            this.cmbModifyFlagsMode = new System.Windows.Forms.ComboBox();
            this.lblModifyFlagsMode = new System.Windows.Forms.Label();
            this.cmbModifyFlagsFieldId = new System.Windows.Forms.ComboBox();
            this.lblModifyFlagsField = new System.Windows.Forms.Label();
            this.lblModifyFlagsTooltip = new System.Windows.Forms.Label();
            this.frmCommandInterruptCasts = new System.Windows.Forms.Panel();
            this.cmbInterruptCastsWithDelayed = new System.Windows.Forms.ComboBox();
            this.lblInterruptCastsSpellId = new System.Windows.Forms.Label();
            this.lblInterruptCastsWithDelayed = new System.Windows.Forms.Label();
            this.btnInterruptCastsSpellId = new System.Windows.Forms.Button();
            this.lblInterruptCastsTooltip = new System.Windows.Forms.Label();
            this.frmCommandUpdateEntry = new System.Windows.Forms.Panel();
            this.lblUpdateEntryCreatureId = new System.Windows.Forms.Label();
            this.btnUpdateEntryCreatureId = new System.Windows.Forms.Button();
            this.lblUpdateEntryTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetStandState = new System.Windows.Forms.Panel();
            this.cmbSetStandState = new System.Windows.Forms.ComboBox();
            this.lblSetStandState = new System.Windows.Forms.Label();
            this.lblSetStandStateTooltip = new System.Windows.Forms.Label();
            this.frmCommandModifyThreat = new System.Windows.Forms.Panel();
            this.lblModifyThreatPercent = new System.Windows.Forms.Label();
            this.txtModifyThreatPercent = new System.Windows.Forms.TextBox();
            this.cmbModifyThreatTarget = new System.Windows.Forms.ComboBox();
            this.lblModifyThreatTarget = new System.Windows.Forms.Label();
            this.lblModifyThreatTooltip = new System.Windows.Forms.Label();
            this.frmCommandSendTaxiPath = new System.Windows.Forms.Panel();
            this.lblSendTaxiPath = new System.Windows.Forms.Label();
            this.txtSendTaxiPath = new System.Windows.Forms.TextBox();
            this.btnSendTaxiPathId = new System.Windows.Forms.Button();
            this.lblSendTaxiPathId = new System.Windows.Forms.Label();
            this.lblSendTaxiPathTooltip = new System.Windows.Forms.Label();
            this.frmCommandTerminateScript = new System.Windows.Forms.Panel();
            this.lblTerminateScriptCondition = new System.Windows.Forms.Label();
            this.cmbTerminateScriptCondition = new System.Windows.Forms.ComboBox();
            this.lblTerminateScriptCreatureId = new System.Windows.Forms.Label();
            this.lblTerminateScriptSearchRadius = new System.Windows.Forms.Label();
            this.txtTerminateScriptSearchRadius = new System.Windows.Forms.TextBox();
            this.btnTerminateScriptCreatureId = new System.Windows.Forms.Button();
            this.lblTerminateScriptTooltip = new System.Windows.Forms.Label();
            this.frmCommandTerminateCondition = new System.Windows.Forms.Panel();
            this.btnTerminateConditionQuest = new System.Windows.Forms.Button();
            this.lblTerminateConditionRule = new System.Windows.Forms.Label();
            this.cmbTerminateConditionRule = new System.Windows.Forms.ComboBox();
            this.lblTerminateConditionId = new System.Windows.Forms.Label();
            this.lblTerminateConditionQuestId = new System.Windows.Forms.Label();
            this.btnTerminateConditionId = new System.Windows.Forms.Button();
            this.lblTerminateConditionTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetHomePosition = new System.Windows.Forms.Panel();
            this.lblSetHomePositionO = new System.Windows.Forms.Label();
            this.lblSetHomePositionZ = new System.Windows.Forms.Label();
            this.txtSetHomePositionO = new System.Windows.Forms.TextBox();
            this.txtSetHomePositionZ = new System.Windows.Forms.TextBox();
            this.lblSetHomePositionY = new System.Windows.Forms.Label();
            this.lblSetHomePositionX = new System.Windows.Forms.Label();
            this.txtSetHomePositionY = new System.Windows.Forms.TextBox();
            this.txtSetHomePositionX = new System.Windows.Forms.TextBox();
            this.cmbSetHomePositionMode = new System.Windows.Forms.ComboBox();
            this.lblSetHomePositionMode = new System.Windows.Forms.Label();
            this.lblSetHomePositionTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetFacing = new System.Windows.Forms.Panel();
            this.lblSetFacingOrientation = new System.Windows.Forms.Label();
            this.txtSetFacingOrientation = new System.Windows.Forms.TextBox();
            this.cmbSetFacingMode = new System.Windows.Forms.ComboBox();
            this.lblSetFacingMode = new System.Windows.Forms.Label();
            this.lblSetFacingTooltip = new System.Windows.Forms.Label();
            this.frmCommandMeetingStone = new System.Windows.Forms.Panel();
            this.btnMeetingStoneAreaId = new System.Windows.Forms.Button();
            this.lblMeetingStoneAreaId = new System.Windows.Forms.Label();
            this.lblMeetingStoneTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetData = new System.Windows.Forms.Panel();
            this.lblSetDataValue = new System.Windows.Forms.Label();
            this.txtSetDataValue = new System.Windows.Forms.TextBox();
            this.lblSetDataField = new System.Windows.Forms.Label();
            this.txtSetDataField = new System.Windows.Forms.TextBox();
            this.cmbSetDataMode = new System.Windows.Forms.ComboBox();
            this.lblSetDataMode = new System.Windows.Forms.Label();
            this.lblSetDataTooltip = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.frmCommandStartScript = new System.Windows.Forms.Panel();
            this.btnStartScriptEdit4 = new System.Windows.Forms.Button();
            this.btnStartScriptEdit3 = new System.Windows.Forms.Button();
            this.btnStartScriptEdit2 = new System.Windows.Forms.Button();
            this.btnStartScriptEdit1 = new System.Windows.Forms.Button();
            this.txtStartScriptChance4 = new System.Windows.Forms.TextBox();
            this.txtStartScriptId4 = new System.Windows.Forms.TextBox();
            this.txtStartScriptChance3 = new System.Windows.Forms.TextBox();
            this.txtStartScriptId3 = new System.Windows.Forms.TextBox();
            this.txtStartScriptChance2 = new System.Windows.Forms.TextBox();
            this.txtStartScriptId2 = new System.Windows.Forms.TextBox();
            this.txtStartScriptChance1 = new System.Windows.Forms.TextBox();
            this.txtStartScriptId1 = new System.Windows.Forms.TextBox();
            this.lblStartScriptChance = new System.Windows.Forms.Label();
            this.lblStartScriptId = new System.Windows.Forms.Label();
            this.lblStartScriptTooltip = new System.Windows.Forms.Label();
            this.lblNoAction = new System.Windows.Forms.Label();
            this.btnActionCopy = new System.Windows.Forms.Button();
            this.btnViewRaw = new System.Windows.Forms.Button();
            this.frmCommandSetPhase = new System.Windows.Forms.Panel();
            this.lblSetPhasePhase = new System.Windows.Forms.Label();
            this.lblSetPhaseMode = new System.Windows.Forms.Label();
            this.txtSetPhasePhase = new System.Windows.Forms.TextBox();
            this.cmbSetPhaseMode = new System.Windows.Forms.ComboBox();
            this.lblSetPhaseTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetRandomPhase = new System.Windows.Forms.Panel();
            this.lblSetRandomPhase4 = new System.Windows.Forms.Label();
            this.txtSetRandomPhase4 = new System.Windows.Forms.TextBox();
            this.lblSetRandomPhase3 = new System.Windows.Forms.Label();
            this.txtSetRandomPhase3 = new System.Windows.Forms.TextBox();
            this.txtSetRandomPhase1 = new System.Windows.Forms.TextBox();
            this.lblSetRandomPhase2 = new System.Windows.Forms.Label();
            this.lblSetRandomPhase1 = new System.Windows.Forms.Label();
            this.txtSetRandomPhase2 = new System.Windows.Forms.TextBox();
            this.lblSetRandomPhaseTooltip = new System.Windows.Forms.Label();
            this.frmCommandFlee = new System.Windows.Forms.Panel();
            this.cmbFleeMode = new System.Windows.Forms.ComboBox();
            this.lblFleeMode = new System.Windows.Forms.Label();
            this.lblFleeTooltip = new System.Windows.Forms.Label();
            this.frmCommandCallForHelp = new System.Windows.Forms.Panel();
            this.lblCallForHelpRadius = new System.Windows.Forms.Label();
            this.txtCallForHelpRadius = new System.Windows.Forms.TextBox();
            this.lblCallForHelpTooltip = new System.Windows.Forms.Label();
            this.frmCommandGameEvent = new System.Windows.Forms.Panel();
            this.cmbGameEventOverwrite = new System.Windows.Forms.ComboBox();
            this.lblGameEventOverwrite = new System.Windows.Forms.Label();
            this.cmbGameEventAction = new System.Windows.Forms.ComboBox();
            this.lblGameEventId = new System.Windows.Forms.Label();
            this.lblGameEventAction = new System.Windows.Forms.Label();
            this.btnGameEventId = new System.Windows.Forms.Button();
            this.lblCommandGameEventTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetSpellsList = new System.Windows.Forms.Panel();
            this.btnSetSpellsList4 = new System.Windows.Forms.Button();
            this.txtSetSpellsListChance4 = new System.Windows.Forms.TextBox();
            this.btnSetSpellsList3 = new System.Windows.Forms.Button();
            this.txtSetSpellsListChance3 = new System.Windows.Forms.TextBox();
            this.btnSetSpellsList2 = new System.Windows.Forms.Button();
            this.txtSetSpellsListChance2 = new System.Windows.Forms.TextBox();
            this.btnSetSpellsList1 = new System.Windows.Forms.Button();
            this.txtSetSpellsListChance1 = new System.Windows.Forms.TextBox();
            this.lblSetSpellsListChance = new System.Windows.Forms.Label();
            this.lblSetSpellsListId = new System.Windows.Forms.Label();
            this.lblSetSpellsListTooltip = new System.Windows.Forms.Label();
            this.frmCommandSpellCooldown = new System.Windows.Forms.Panel();
            this.lblSpellCooldownSeconds = new System.Windows.Forms.Label();
            this.txtSpellCooldownSeconds = new System.Windows.Forms.TextBox();
            this.btnSpellCooldownId = new System.Windows.Forms.Button();
            this.lblSpellCooldownId = new System.Windows.Forms.Label();
            this.lblSpellCooldownTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetReactState = new System.Windows.Forms.Panel();
            this.cmbSetReactState = new System.Windows.Forms.ComboBox();
            this.lblReactState = new System.Windows.Forms.Label();
            this.lblSetReactStateTooltip = new System.Windows.Forms.Label();
            this.frmCommandStartWaypoints = new System.Windows.Forms.Panel();
            this.txtStartWaypointsEntry = new System.Windows.Forms.TextBox();
            this.lblStartWaypointsEntry = new System.Windows.Forms.Label();
            this.txtStartWaypointsGuid = new System.Windows.Forms.TextBox();
            this.lblStartWaypointsGuid = new System.Windows.Forms.Label();
            this.txtStartWaypointsInitialDelay = new System.Windows.Forms.TextBox();
            this.lblStartWaypointsInitialDelay = new System.Windows.Forms.Label();
            this.txtStartWaypointsStartPoint = new System.Windows.Forms.TextBox();
            this.lblStartWaypointsStartPoint = new System.Windows.Forms.Label();
            this.cmbStartWaypointsRepeat = new System.Windows.Forms.ComboBox();
            this.lblStartWaypointsRepeat = new System.Windows.Forms.Label();
            this.cmbStartWaypointsSource = new System.Windows.Forms.ComboBox();
            this.lblStartWaypointsSource = new System.Windows.Forms.Label();
            this.lblStartWaypointsTooltip = new System.Windows.Forms.Label();
            this.frmCommandStartScriptedMapEvent = new System.Windows.Forms.Panel();
            this.btnStartScriptedMapEventFailureScriptEdit = new System.Windows.Forms.Button();
            this.btnStartScriptedMapEventSuccessScriptEdit = new System.Windows.Forms.Button();
            this.lblStartScriptedMapEventFailureScript = new System.Windows.Forms.Label();
            this.btnStartScriptedMapEventFailureCondition = new System.Windows.Forms.Button();
            this.txtStartScriptedMapEventFailureScript = new System.Windows.Forms.TextBox();
            this.lblStartScriptedMapEventFailureCondition = new System.Windows.Forms.Label();
            this.lblStartScriptedMapEventSuccessScript = new System.Windows.Forms.Label();
            this.btnStartScriptedMapEventSuccessCondition = new System.Windows.Forms.Button();
            this.txtStartScriptedMapEventTimeLimit = new System.Windows.Forms.TextBox();
            this.lblStartScriptedMapEventTimeLimit = new System.Windows.Forms.Label();
            this.txtStartScriptedMapEventId = new System.Windows.Forms.TextBox();
            this.lblStartScriptedMapEventId = new System.Windows.Forms.Label();
            this.txtStartScriptedMapEventSuccessScript = new System.Windows.Forms.TextBox();
            this.lblStartScriptedMapEventSuccessCondition = new System.Windows.Forms.Label();
            this.lblStartScriptedMapEventTooltip = new System.Windows.Forms.Label();
            this.frmCommandRemoveScriptedMapEventTarget = new System.Windows.Forms.Panel();
            this.txtRemoveScriptedMapEventTargetEventId = new System.Windows.Forms.TextBox();
            this.cmbRemoveScriptedMapEventTarget = new System.Windows.Forms.ComboBox();
            this.lblRemoveScriptedMapEventTarget = new System.Windows.Forms.Label();
            this.lblRemoveScriptedMapEventTargetCondition = new System.Windows.Forms.Label();
            this.lblRemoveScriptedMapEventTargetEventId = new System.Windows.Forms.Label();
            this.btnRemoveScriptedMapEventTargetCondition = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.frmCommandSetScriptedMapEventData = new System.Windows.Forms.Panel();
            this.txtSetScriptedMapEventData = new System.Windows.Forms.TextBox();
            this.lblSetScriptedMapEventData = new System.Windows.Forms.Label();
            this.txtSetScriptedMapEventDataIndex = new System.Windows.Forms.TextBox();
            this.txtSetScriptedMapEventDataEventId = new System.Windows.Forms.TextBox();
            this.cmbSetScriptedMapEventDataMode = new System.Windows.Forms.ComboBox();
            this.lblSetScriptedMapEventDataMode = new System.Windows.Forms.Label();
            this.lblSetScriptedMapEventDataIndex = new System.Windows.Forms.Label();
            this.lblSetScriptedMapEventDataEventId = new System.Windows.Forms.Label();
            this.lblSetScriptedMapEventDataTooltip = new System.Windows.Forms.Label();
            this.frmCommandSetDefaultMovement = new System.Windows.Forms.Panel();
            this.cmbSetDefaultMovementAlwaysReplace = new System.Windows.Forms.ComboBox();
            this.txtSetDefaultMovementParam1 = new System.Windows.Forms.TextBox();
            this.cmbSetDefaultMovementType = new System.Windows.Forms.ComboBox();
            this.lblSetDefaultMovementParam1 = new System.Windows.Forms.Label();
            this.lblSetDefaultMovementAlwaysReplace = new System.Windows.Forms.Label();
            this.lblSetDefaultMovementType = new System.Windows.Forms.Label();
            this.lblSetDefaultMovementTooltip = new System.Windows.Forms.Label();
            this.frmCommandStartScriptForAll = new System.Windows.Forms.Panel();
            this.btnStartScriptForAllEdit = new System.Windows.Forms.Button();
            this.btnStartScriptForAllObjectEntry = new System.Windows.Forms.Button();
            this.txtStartScriptForAllDistance = new System.Windows.Forms.TextBox();
            this.lblStartScriptForAllDistance = new System.Windows.Forms.Label();
            this.txtStartScriptForAllScriptId = new System.Windows.Forms.TextBox();
            this.cmbStartScriptForAllObjectType = new System.Windows.Forms.ComboBox();
            this.lblStartScriptForAllObjectEntry = new System.Windows.Forms.Label();
            this.lblStartScriptForAllObjectType = new System.Windows.Forms.Label();
            this.lblStartScriptForAllScriptId = new System.Windows.Forms.Label();
            this.lblStartScriptForAllTooltip = new System.Windows.Forms.Label();
            this.frmCommandUnknown = new System.Windows.Forms.Panel();
            this.txtUnknownCommandO = new System.Windows.Forms.TextBox();
            this.txtUnknownCommandZ = new System.Windows.Forms.TextBox();
            this.lblUnknownCommandO = new System.Windows.Forms.Label();
            this.lblUnknownCommandZ = new System.Windows.Forms.Label();
            this.txtUnknownCommandDataint4 = new System.Windows.Forms.TextBox();
            this.lblUnkownCommandDataint4 = new System.Windows.Forms.Label();
            this.txtUnknownCommandDataint2 = new System.Windows.Forms.TextBox();
            this.lblUnkownCommandDataint3 = new System.Windows.Forms.Label();
            this.txtUnknownCommandDataint3 = new System.Windows.Forms.TextBox();
            this.txtUnknownCommandDataint1 = new System.Windows.Forms.TextBox();
            this.lblUnknownCommandDatalong4 = new System.Windows.Forms.Label();
            this.lblUnknownCommandDatalong3 = new System.Windows.Forms.Label();
            this.txtUnknownCommandDatalong4 = new System.Windows.Forms.TextBox();
            this.lblUnknownCommandDataint2 = new System.Windows.Forms.Label();
            this.txtUnknownCommandDatalong2 = new System.Windows.Forms.TextBox();
            this.lblUnknownCommandDataint1 = new System.Windows.Forms.Label();
            this.txtUnknownCommandY = new System.Windows.Forms.TextBox();
            this.txtUnknownCommandX = new System.Windows.Forms.TextBox();
            this.lblUnknownCommandY = new System.Windows.Forms.Label();
            this.lblUnknownCommandX = new System.Windows.Forms.Label();
            this.txtUnknownCommandDatalong3 = new System.Windows.Forms.TextBox();
            this.txtUnknownCommandDatalong1 = new System.Windows.Forms.TextBox();
            this.lblUnknownCommandDatalong2 = new System.Windows.Forms.Label();
            this.lblUnknownCommandDatalong1 = new System.Windows.Forms.Label();
            this.lblUnknownCommandTooltip = new System.Windows.Forms.Label();
            this.frmCommandSummonObject = new System.Windows.Forms.Panel();
            this.lblSummonObjectRespawnTime = new System.Windows.Forms.Label();
            this.txtSummonObjectRespawnTime = new System.Windows.Forms.TextBox();
            this.btnSummonObjectId = new System.Windows.Forms.Button();
            this.lblSummonObjectO = new System.Windows.Forms.Label();
            this.lblSummonObjectZ = new System.Windows.Forms.Label();
            this.txtSummonObjectO = new System.Windows.Forms.TextBox();
            this.txtSummonObjectZ = new System.Windows.Forms.TextBox();
            this.lblSummonObjectY = new System.Windows.Forms.Label();
            this.lblSummonObjectX = new System.Windows.Forms.Label();
            this.txtSummonObjectY = new System.Windows.Forms.TextBox();
            this.txtSummonObjectX = new System.Windows.Forms.TextBox();
            this.lblSummonObjectId = new System.Windows.Forms.Label();
            this.lblSummonObjectTooltip = new System.Windows.Forms.Label();
            this.frmCommandJoinCreatureGroup = new System.Windows.Forms.Panel();
            this.joinCreatureGroupsFlagsGroupBox = new System.Windows.Forms.GroupBox();
            this.chkJoinCreatureGroup128 = new System.Windows.Forms.CheckBox();
            this.chkJoinCreatureGroup64 = new System.Windows.Forms.CheckBox();
            this.chkJoinCreatureGroup32 = new System.Windows.Forms.CheckBox();
            this.chkJoinCreatureGroup16 = new System.Windows.Forms.CheckBox();
            this.chkJoinCreatureGroup8 = new System.Windows.Forms.CheckBox();
            this.chkJoinCreatureGroup4 = new System.Windows.Forms.CheckBox();
            this.chkJoinCreatureGroup2 = new System.Windows.Forms.CheckBox();
            this.chkJoinCreatureGroup1 = new System.Windows.Forms.CheckBox();
            this.lblJoinCreatureGroupAngle = new System.Windows.Forms.Label();
            this.lblJoinCreatureGroupDistance = new System.Windows.Forms.Label();
            this.txtJoinCreatureGroupAngle = new System.Windows.Forms.TextBox();
            this.txtJoinCreatureGroupDistance = new System.Windows.Forms.TextBox();
            this.lblJoinCreatureGroupTooltip = new System.Windows.Forms.Label();
            this.frmCommandStartScriptOnZone = new System.Windows.Forms.Panel();
            this.btnStartScriptOnZoneScriptIdEdit = new System.Windows.Forms.Button();
            this.lblStartScriptOnZoneWithPets = new System.Windows.Forms.Label();
            this.cmbStartScriptOnZoneWithPets = new System.Windows.Forms.ComboBox();
            this.btnStartScriptOnZoneZoneId = new System.Windows.Forms.Button();
            this.lblStartScriptOnZoneZoneId = new System.Windows.Forms.Label();
            this.lblStartScriptOnZoneScriptId = new System.Windows.Forms.Label();
            this.txtStartScriptOnZoneScriptId = new System.Windows.Forms.TextBox();
            this.lblStartScriptOnZoneTooltip = new System.Windows.Forms.Label();
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
            this.grpAddAuraFlags.SuspendLayout();
            this.frmCommandCastSpell.SuspendLayout();
            this.grpCastSpellFlags.SuspendLayout();
            this.frmCommandPlaySound.SuspendLayout();
            this.grpPlaySoundFlags.SuspendLayout();
            this.frmCommandCreateItem.SuspendLayout();
            this.frmCommandSetEquipment.SuspendLayout();
            this.frmCommandSetMovement.SuspendLayout();
            this.frmCommandActiveObject.SuspendLayout();
            this.frmCommandSetFaction.SuspendLayout();
            this.grpSetFactionFlags.SuspendLayout();
            this.frmCommandMorphOrMount.SuspendLayout();
            this.frmCommandSetRun.SuspendLayout();
            this.frmCommandModifyFlags.SuspendLayout();
            this.frmCommandInterruptCasts.SuspendLayout();
            this.frmCommandUpdateEntry.SuspendLayout();
            this.frmCommandSetStandState.SuspendLayout();
            this.frmCommandModifyThreat.SuspendLayout();
            this.frmCommandSendTaxiPath.SuspendLayout();
            this.frmCommandTerminateScript.SuspendLayout();
            this.frmCommandTerminateCondition.SuspendLayout();
            this.frmCommandSetHomePosition.SuspendLayout();
            this.frmCommandSetFacing.SuspendLayout();
            this.frmCommandMeetingStone.SuspendLayout();
            this.frmCommandSetData.SuspendLayout();
            this.frmCommandStartScript.SuspendLayout();
            this.frmCommandSetPhase.SuspendLayout();
            this.frmCommandSetRandomPhase.SuspendLayout();
            this.frmCommandFlee.SuspendLayout();
            this.frmCommandCallForHelp.SuspendLayout();
            this.frmCommandGameEvent.SuspendLayout();
            this.frmCommandSetSpellsList.SuspendLayout();
            this.frmCommandSpellCooldown.SuspendLayout();
            this.frmCommandSetReactState.SuspendLayout();
            this.frmCommandStartWaypoints.SuspendLayout();
            this.frmCommandStartScriptedMapEvent.SuspendLayout();
            this.frmCommandRemoveScriptedMapEventTarget.SuspendLayout();
            this.frmCommandSetScriptedMapEventData.SuspendLayout();
            this.frmCommandSetDefaultMovement.SuspendLayout();
            this.frmCommandStartScriptForAll.SuspendLayout();
            this.frmCommandUnknown.SuspendLayout();
            this.frmCommandSummonObject.SuspendLayout();
            this.frmCommandJoinCreatureGroup.SuspendLayout();
            this.joinCreatureGroupsFlagsGroupBox.SuspendLayout();
            this.frmCommandStartScriptOnZone.SuspendLayout();
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
            this.lstActions.Location = new System.Drawing.Point(20, 64);
            this.lstActions.MultiSelect = false;
            this.lstActions.Name = "lstActions";
            this.lstActions.Size = new System.Drawing.Size(355, 520);
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
            this.lblId.Location = new System.Drawing.Point(19, 41);
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
            "creature_ai_scripts",
            "creature_movement_scripts",
            "creature_spells_scripts",
            "event_scripts",
            "gameobject_scripts",
            "generic_scripts",
            "gossip_scripts",
            "quest_end_scripts",
            "quest_start_scripts",
            "spell_scripts"});
            this.cmbTable.Location = new System.Drawing.Point(672, 24);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(154, 21);
            this.cmbTable.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(833, 22);
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
            this.txtScriptId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScriptId_KeyPress);
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.lblPriority);
            this.grpGeneral.Controls.Add(this.txtCommandPriority);
            this.grpGeneral.Controls.Add(this.lblCommandCondition);
            this.grpGeneral.Controls.Add(this.btnCommandCondition);
            this.grpGeneral.Controls.Add(this.lblComment);
            this.grpGeneral.Controls.Add(this.txtCommandComment);
            this.grpGeneral.Controls.Add(this.grpDataFlags);
            this.grpGeneral.Controls.Add(this.grpBuddy);
            this.grpGeneral.Controls.Add(this.txtCommandDelay);
            this.grpGeneral.Controls.Add(this.lblDelay);
            this.grpGeneral.Controls.Add(this.lblCommand);
            this.grpGeneral.Controls.Add(this.cmbCommandId);
            this.grpGeneral.Enabled = false;
            this.grpGeneral.Location = new System.Drawing.Point(410, 64);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(495, 182);
            this.grpGeneral.TabIndex = 5;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "Command Data";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(88, 26);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(41, 13);
            this.lblPriority.TabIndex = 16;
            this.lblPriority.Text = "Priority:";
            // 
            // txtCommandPriority
            // 
            this.txtCommandPriority.Location = new System.Drawing.Point(91, 42);
            this.txtCommandPriority.Name = "txtCommandPriority";
            this.txtCommandPriority.Size = new System.Drawing.Size(65, 20);
            this.txtCommandPriority.TabIndex = 15;
            this.txtCommandPriority.Leave += new System.EventHandler(this.txtCommandPriority_Leave);
            // 
            // lblCommandCondition
            // 
            this.lblCommandCondition.AutoSize = true;
            this.lblCommandCondition.Location = new System.Drawing.Point(22, 109);
            this.lblCommandCondition.Name = "lblCommandCondition";
            this.lblCommandCondition.Size = new System.Drawing.Size(54, 13);
            this.lblCommandCondition.TabIndex = 14;
            this.lblCommandCondition.Text = "Condition:";
            // 
            // btnCommandCondition
            // 
            this.btnCommandCondition.Location = new System.Drawing.Point(24, 125);
            this.btnCommandCondition.Name = "btnCommandCondition";
            this.btnCommandCondition.Size = new System.Drawing.Size(133, 21);
            this.btnCommandCondition.TabIndex = 13;
            this.btnCommandCondition.Text = "-NONE-";
            this.btnCommandCondition.UseVisualStyleBackColor = true;
            this.btnCommandCondition.Click += new System.EventHandler(this.btnCommandCondition_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(22, 158);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(54, 13);
            this.lblComment.TabIndex = 12;
            this.lblComment.Text = "Comment:";
            // 
            // txtCommandComment
            // 
            this.txtCommandComment.Location = new System.Drawing.Point(81, 155);
            this.txtCommandComment.Name = "txtCommandComment";
            this.txtCommandComment.Size = new System.Drawing.Size(392, 20);
            this.txtCommandComment.TabIndex = 11;
            this.txtCommandComment.Leave += new System.EventHandler(this.txtCommandComment_Leave);
            // 
            // grpDataFlags
            // 
            this.grpDataFlags.Controls.Add(this.chkSkipMissingTargets);
            this.grpDataFlags.Controls.Add(this.chkAbortScript);
            this.grpDataFlags.Controls.Add(this.chkTargetSelf);
            this.grpDataFlags.Controls.Add(this.chkSwapFinal);
            this.grpDataFlags.Controls.Add(this.chkSwapInitial);
            this.grpDataFlags.Location = new System.Drawing.Point(321, 19);
            this.grpDataFlags.Name = "grpDataFlags";
            this.grpDataFlags.Size = new System.Drawing.Size(152, 128);
            this.grpDataFlags.TabIndex = 10;
            this.grpDataFlags.TabStop = false;
            this.grpDataFlags.Text = "Data Flags";
            // 
            // chkSkipMissingTargets
            // 
            this.chkSkipMissingTargets.AutoSize = true;
            this.chkSkipMissingTargets.Location = new System.Drawing.Point(6, 103);
            this.chkSkipMissingTargets.Name = "chkSkipMissingTargets";
            this.chkSkipMissingTargets.Size = new System.Drawing.Size(124, 17);
            this.chkSkipMissingTargets.TabIndex = 4;
            this.chkSkipMissingTargets.Text = "Skip Missing Targets";
            this.chkSkipMissingTargets.UseVisualStyleBackColor = true;
            this.chkSkipMissingTargets.CheckedChanged += new System.EventHandler(this.chkSkipMissingTargets_CheckedChanged);
            // 
            // chkAbortScript
            // 
            this.chkAbortScript.AutoSize = true;
            this.chkAbortScript.Location = new System.Drawing.Point(6, 82);
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
            this.chkTargetSelf.Location = new System.Drawing.Point(6, 61);
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
            this.chkSwapFinal.Location = new System.Drawing.Point(6, 40);
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
            this.chkSwapInitial.Location = new System.Drawing.Point(6, 19);
            this.chkSwapInitial.Name = "chkSwapInitial";
            this.chkSwapInitial.Size = new System.Drawing.Size(119, 17);
            this.chkSwapInitial.TabIndex = 0;
            this.chkSwapInitial.Text = "Swap Initial Targets";
            this.chkSwapInitial.UseVisualStyleBackColor = true;
            this.chkSwapInitial.CheckedChanged += new System.EventHandler(this.chkSwapInitial_CheckedChanged);
            // 
            // grpBuddy
            // 
            this.grpBuddy.Controls.Add(this.btnTargetParam1);
            this.grpBuddy.Controls.Add(this.lblTargetType);
            this.grpBuddy.Controls.Add(this.txtTargetParam1);
            this.grpBuddy.Controls.Add(this.cmbTargetType);
            this.grpBuddy.Controls.Add(this.lblTargetParam2);
            this.grpBuddy.Controls.Add(this.txtTargetParam2);
            this.grpBuddy.Controls.Add(this.lblTargetParam1);
            this.grpBuddy.Location = new System.Drawing.Point(162, 19);
            this.grpBuddy.Name = "grpBuddy";
            this.grpBuddy.Size = new System.Drawing.Size(153, 128);
            this.grpBuddy.TabIndex = 9;
            this.grpBuddy.TabStop = false;
            this.grpBuddy.Text = "Target";
            // 
            // btnTargetParam1
            // 
            this.btnTargetParam1.Location = new System.Drawing.Point(64, 23);
            this.btnTargetParam1.Name = "btnTargetParam1";
            this.btnTargetParam1.Size = new System.Drawing.Size(83, 20);
            this.btnTargetParam1.TabIndex = 10;
            this.btnTargetParam1.Text = "-NONE-";
            this.btnTargetParam1.UseVisualStyleBackColor = true;
            this.btnTargetParam1.Click += new System.EventHandler(this.btnTargetParam1_Click);
            // 
            // lblTargetType
            // 
            this.lblTargetType.AutoSize = true;
            this.lblTargetType.Location = new System.Drawing.Point(22, 77);
            this.lblTargetType.Name = "lblTargetType";
            this.lblTargetType.Size = new System.Drawing.Size(107, 13);
            this.lblTargetType.TabIndex = 9;
            this.lblTargetType.Text = "Target for this action:";
            // 
            // txtTargetParam1
            // 
            this.txtTargetParam1.Location = new System.Drawing.Point(64, 23);
            this.txtTargetParam1.Name = "txtTargetParam1";
            this.txtTargetParam1.Size = new System.Drawing.Size(83, 20);
            this.txtTargetParam1.TabIndex = 4;
            this.txtTargetParam1.Leave += new System.EventHandler(this.txtTargetParam1_Leave);
            // 
            // cmbTargetType
            // 
            this.cmbTargetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetType.FormattingEnabled = true;
            this.cmbTargetType.Location = new System.Drawing.Point(9, 94);
            this.cmbTargetType.Name = "cmbTargetType";
            this.cmbTargetType.Size = new System.Drawing.Size(138, 21);
            this.cmbTargetType.TabIndex = 6;
            this.cmbTargetType.SelectedIndexChanged += new System.EventHandler(this.cmbTargetType_SelectedIndexChanged);
            // 
            // lblTargetParam2
            // 
            this.lblTargetParam2.AutoSize = true;
            this.lblTargetParam2.Location = new System.Drawing.Point(6, 49);
            this.lblTargetParam2.Name = "lblTargetParam2";
            this.lblTargetParam2.Size = new System.Drawing.Size(43, 13);
            this.lblTargetParam2.TabIndex = 8;
            this.lblTargetParam2.Text = "Radius:";
            // 
            // txtTargetParam2
            // 
            this.txtTargetParam2.Location = new System.Drawing.Point(64, 49);
            this.txtTargetParam2.Name = "txtTargetParam2";
            this.txtTargetParam2.Size = new System.Drawing.Size(83, 20);
            this.txtTargetParam2.TabIndex = 5;
            this.txtTargetParam2.Leave += new System.EventHandler(this.txtTargetParam2_Leave);
            // 
            // lblTargetParam1
            // 
            this.lblTargetParam1.AutoSize = true;
            this.lblTargetParam1.Location = new System.Drawing.Point(6, 26);
            this.lblTargetParam1.Name = "lblTargetParam1";
            this.lblTargetParam1.Size = new System.Drawing.Size(19, 13);
            this.lblTargetParam1.TabIndex = 7;
            this.lblTargetParam1.Text = "Id:";
            // 
            // txtCommandDelay
            // 
            this.txtCommandDelay.Location = new System.Drawing.Point(24, 42);
            this.txtCommandDelay.Name = "txtCommandDelay";
            this.txtCommandDelay.Size = new System.Drawing.Size(65, 20);
            this.txtCommandDelay.TabIndex = 3;
            this.txtCommandDelay.Leave += new System.EventHandler(this.txtCommandDelay_Leave);
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(21, 26);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(51, 13);
            this.lblDelay.TabIndex = 2;
            this.lblDelay.Text = "Delay (s):";
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(22, 67);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(57, 13);
            this.lblCommand.TabIndex = 1;
            this.lblCommand.Text = "Command:";
            // 
            // cmbCommandId
            // 
            this.cmbCommandId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommandId.FormattingEnabled = true;
            this.cmbCommandId.Location = new System.Drawing.Point(24, 83);
            this.cmbCommandId.Name = "cmbCommandId";
            this.cmbCommandId.Size = new System.Drawing.Size(132, 21);
            this.cmbCommandId.TabIndex = 0;
            this.cmbCommandId.SelectedIndexChanged += new System.EventHandler(this.cmbCommandId_SelectedIndexChanged);
            // 
            // frmCommandTalk
            // 
            this.frmCommandTalk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandTalk.Controls.Add(this.lblTalkTextPreview);
            this.frmCommandTalk.Controls.Add(this.lblTalkBroadcastId);
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
            this.frmCommandTalk.Location = new System.Drawing.Point(410, 252);
            this.frmCommandTalk.Name = "frmCommandTalk";
            this.frmCommandTalk.Size = new System.Drawing.Size(495, 332);
            this.frmCommandTalk.TabIndex = 6;
            this.frmCommandTalk.Visible = false;
            // 
            // lblTalkTextPreview
            // 
            this.lblTalkTextPreview.AutoSize = true;
            this.lblTalkTextPreview.Location = new System.Drawing.Point(153, 63);
            this.lblTalkTextPreview.Name = "lblTalkTextPreview";
            this.lblTalkTextPreview.Size = new System.Drawing.Size(72, 13);
            this.lblTalkTextPreview.TabIndex = 12;
            this.lblTalkTextPreview.Text = "Text Preview:";
            // 
            // lblTalkBroadcastId
            // 
            this.lblTalkBroadcastId.AutoSize = true;
            this.lblTalkBroadcastId.Location = new System.Drawing.Point(22, 63);
            this.lblTalkBroadcastId.Name = "lblTalkBroadcastId";
            this.lblTalkBroadcastId.Size = new System.Drawing.Size(96, 13);
            this.lblTalkBroadcastId.TabIndex = 11;
            this.lblTalkBroadcastId.Text = "Broadcast Text ID:";
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
            this.txtTalkText4.Location = new System.Drawing.Point(153, 173);
            this.txtTalkText4.Name = "txtTalkText4";
            this.txtTalkText4.ReadOnly = true;
            this.txtTalkText4.Size = new System.Drawing.Size(316, 20);
            this.txtTalkText4.TabIndex = 9;
            // 
            // txtTalkText3
            // 
            this.txtTalkText3.Location = new System.Drawing.Point(153, 144);
            this.txtTalkText3.Name = "txtTalkText3";
            this.txtTalkText3.ReadOnly = true;
            this.txtTalkText3.Size = new System.Drawing.Size(316, 20);
            this.txtTalkText3.TabIndex = 8;
            // 
            // txtTalkText2
            // 
            this.txtTalkText2.Location = new System.Drawing.Point(153, 115);
            this.txtTalkText2.Name = "txtTalkText2";
            this.txtTalkText2.ReadOnly = true;
            this.txtTalkText2.Size = new System.Drawing.Size(316, 20);
            this.txtTalkText2.TabIndex = 7;
            // 
            // txtTalkText1
            // 
            this.txtTalkText1.Location = new System.Drawing.Point(153, 86);
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
            // btnActionDelete
            // 
            this.btnActionDelete.Location = new System.Drawing.Point(182, 590);
            this.btnActionDelete.Name = "btnActionDelete";
            this.btnActionDelete.Size = new System.Drawing.Size(75, 23);
            this.btnActionDelete.TabIndex = 7;
            this.btnActionDelete.Text = "Delete";
            this.btnActionDelete.UseVisualStyleBackColor = true;
            this.btnActionDelete.Click += new System.EventHandler(this.btnActionDelete_Click);
            // 
            // btnActionAdd
            // 
            this.btnActionAdd.Location = new System.Drawing.Point(20, 590);
            this.btnActionAdd.Name = "btnActionAdd";
            this.btnActionAdd.Size = new System.Drawing.Size(75, 23);
            this.btnActionAdd.TabIndex = 8;
            this.btnActionAdd.Text = "Add";
            this.btnActionAdd.UseVisualStyleBackColor = true;
            this.btnActionAdd.Click += new System.EventHandler(this.btnActionAdd_Click);
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
            this.frmCommandEmote.Controls.Add(this.cmbEmoteTargeted);
            this.frmCommandEmote.Controls.Add(this.lblEmoteTargeted);
            this.frmCommandEmote.Controls.Add(this.cmbEmoteId4);
            this.frmCommandEmote.Controls.Add(this.lblEmoteId4);
            this.frmCommandEmote.Controls.Add(this.cmbEmoteId3);
            this.frmCommandEmote.Controls.Add(this.lblEmoteId3);
            this.frmCommandEmote.Controls.Add(this.cmbEmoteId2);
            this.frmCommandEmote.Controls.Add(this.lblEmoteId2);
            this.frmCommandEmote.Controls.Add(this.lblEmoteTooltip);
            this.frmCommandEmote.Controls.Add(this.cmbEmoteId);
            this.frmCommandEmote.Controls.Add(this.lblEmoteId);
            this.frmCommandEmote.Location = new System.Drawing.Point(410, 252);
            this.frmCommandEmote.Name = "frmCommandEmote";
            this.frmCommandEmote.Size = new System.Drawing.Size(495, 332);
            this.frmCommandEmote.TabIndex = 11;
            this.frmCommandEmote.Visible = false;
            // 
            // cmbEmoteTargeted
            // 
            this.cmbEmoteTargeted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmoteTargeted.FormattingEnabled = true;
            this.cmbEmoteTargeted.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbEmoteTargeted.Location = new System.Drawing.Point(99, 186);
            this.cmbEmoteTargeted.Name = "cmbEmoteTargeted";
            this.cmbEmoteTargeted.Size = new System.Drawing.Size(374, 21);
            this.cmbEmoteTargeted.TabIndex = 10;
            this.cmbEmoteTargeted.SelectedIndexChanged += new System.EventHandler(this.cmbEmoteTargeted_SelectedIndexChanged);
            // 
            // lblEmoteTargeted
            // 
            this.lblEmoteTargeted.AutoSize = true;
            this.lblEmoteTargeted.Location = new System.Drawing.Point(43, 189);
            this.lblEmoteTargeted.Name = "lblEmoteTargeted";
            this.lblEmoteTargeted.Size = new System.Drawing.Size(53, 13);
            this.lblEmoteTargeted.TabIndex = 9;
            this.lblEmoteTargeted.Text = "Targeted:";
            // 
            // cmbEmoteId4
            // 
            this.cmbEmoteId4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmoteId4.FormattingEnabled = true;
            this.cmbEmoteId4.Location = new System.Drawing.Point(99, 154);
            this.cmbEmoteId4.Name = "cmbEmoteId4";
            this.cmbEmoteId4.Size = new System.Drawing.Size(374, 21);
            this.cmbEmoteId4.TabIndex = 8;
            this.cmbEmoteId4.SelectedIndexChanged += new System.EventHandler(this.cmbEmoteId4_SelectedIndexChanged);
            // 
            // lblEmoteId4
            // 
            this.lblEmoteId4.AutoSize = true;
            this.lblEmoteId4.Location = new System.Drawing.Point(47, 157);
            this.lblEmoteId4.Name = "lblEmoteId4";
            this.lblEmoteId4.Size = new System.Drawing.Size(49, 13);
            this.lblEmoteId4.TabIndex = 7;
            this.lblEmoteId4.Text = "Emote 4:";
            // 
            // cmbEmoteId3
            // 
            this.cmbEmoteId3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmoteId3.FormattingEnabled = true;
            this.cmbEmoteId3.Location = new System.Drawing.Point(99, 122);
            this.cmbEmoteId3.Name = "cmbEmoteId3";
            this.cmbEmoteId3.Size = new System.Drawing.Size(374, 21);
            this.cmbEmoteId3.TabIndex = 6;
            this.cmbEmoteId3.SelectedIndexChanged += new System.EventHandler(this.cmbEmoteId3_SelectedIndexChanged);
            // 
            // lblEmoteId3
            // 
            this.lblEmoteId3.AutoSize = true;
            this.lblEmoteId3.Location = new System.Drawing.Point(47, 125);
            this.lblEmoteId3.Name = "lblEmoteId3";
            this.lblEmoteId3.Size = new System.Drawing.Size(49, 13);
            this.lblEmoteId3.TabIndex = 5;
            this.lblEmoteId3.Text = "Emote 3:";
            // 
            // cmbEmoteId2
            // 
            this.cmbEmoteId2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmoteId2.FormattingEnabled = true;
            this.cmbEmoteId2.Location = new System.Drawing.Point(99, 90);
            this.cmbEmoteId2.Name = "cmbEmoteId2";
            this.cmbEmoteId2.Size = new System.Drawing.Size(374, 21);
            this.cmbEmoteId2.TabIndex = 4;
            this.cmbEmoteId2.SelectedIndexChanged += new System.EventHandler(this.cmbEmoteId2_SelectedIndexChanged);
            // 
            // lblEmoteId2
            // 
            this.lblEmoteId2.AutoSize = true;
            this.lblEmoteId2.Location = new System.Drawing.Point(47, 93);
            this.lblEmoteId2.Name = "lblEmoteId2";
            this.lblEmoteId2.Size = new System.Drawing.Size(49, 13);
            this.lblEmoteId2.TabIndex = 3;
            this.lblEmoteId2.Text = "Emote 2:";
            // 
            // lblEmoteTooltip
            // 
            this.lblEmoteTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmoteTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblEmoteTooltip.Name = "lblEmoteTooltip";
            this.lblEmoteTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblEmoteTooltip.TabIndex = 2;
            this.lblEmoteTooltip.Text = "The source Unit performs the specified visual emote, or a random one of them if m" +
    "ultiple are provided.";
            // 
            // cmbEmoteId
            // 
            this.cmbEmoteId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmoteId.FormattingEnabled = true;
            this.cmbEmoteId.Location = new System.Drawing.Point(99, 58);
            this.cmbEmoteId.Name = "cmbEmoteId";
            this.cmbEmoteId.Size = new System.Drawing.Size(374, 21);
            this.cmbEmoteId.TabIndex = 1;
            this.cmbEmoteId.SelectedIndexChanged += new System.EventHandler(this.cmbEmoteId_SelectedIndexChanged);
            // 
            // lblEmoteId
            // 
            this.lblEmoteId.AutoSize = true;
            this.lblEmoteId.Location = new System.Drawing.Point(47, 61);
            this.lblEmoteId.Name = "lblEmoteId";
            this.lblEmoteId.Size = new System.Drawing.Size(49, 13);
            this.lblEmoteId.TabIndex = 0;
            this.lblEmoteId.Text = "Emote 1:";
            // 
            // frmCommandFieldSet
            // 
            this.frmCommandFieldSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandFieldSet.Controls.Add(this.lvlFieldSetValue);
            this.frmCommandFieldSet.Controls.Add(this.lblFieldSetField);
            this.frmCommandFieldSet.Controls.Add(this.txtFieldSetValue);
            this.frmCommandFieldSet.Controls.Add(this.cmbFieldSetFields);
            this.frmCommandFieldSet.Controls.Add(this.lblFieldSetTooltip);
            this.frmCommandFieldSet.Location = new System.Drawing.Point(410, 252);
            this.frmCommandFieldSet.Name = "frmCommandFieldSet";
            this.frmCommandFieldSet.Size = new System.Drawing.Size(495, 332);
            this.frmCommandFieldSet.TabIndex = 12;
            this.frmCommandFieldSet.Visible = false;
            // 
            // lvlFieldSetValue
            // 
            this.lvlFieldSetValue.AutoSize = true;
            this.lvlFieldSetValue.Location = new System.Drawing.Point(59, 93);
            this.lvlFieldSetValue.Name = "lvlFieldSetValue";
            this.lvlFieldSetValue.Size = new System.Drawing.Size(37, 13);
            this.lvlFieldSetValue.TabIndex = 4;
            this.lvlFieldSetValue.Text = "Value:";
            // 
            // lblFieldSetField
            // 
            this.lblFieldSetField.AutoSize = true;
            this.lblFieldSetField.Location = new System.Drawing.Point(64, 61);
            this.lblFieldSetField.Name = "lblFieldSetField";
            this.lblFieldSetField.Size = new System.Drawing.Size(32, 13);
            this.lblFieldSetField.TabIndex = 3;
            this.lblFieldSetField.Text = "Field:";
            // 
            // txtFieldSetValue
            // 
            this.txtFieldSetValue.Location = new System.Drawing.Point(99, 90);
            this.txtFieldSetValue.Name = "txtFieldSetValue";
            this.txtFieldSetValue.Size = new System.Drawing.Size(374, 20);
            this.txtFieldSetValue.TabIndex = 2;
            this.txtFieldSetValue.Leave += new System.EventHandler(this.txtFieldSetValue_Leave);
            // 
            // cmbFieldSetFields
            // 
            this.cmbFieldSetFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFieldSetFields.FormattingEnabled = true;
            this.cmbFieldSetFields.Location = new System.Drawing.Point(99, 58);
            this.cmbFieldSetFields.Name = "cmbFieldSetFields";
            this.cmbFieldSetFields.Size = new System.Drawing.Size(374, 21);
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
    " doing.";
            // 
            // frmCommandMoveTo
            // 
            this.frmCommandMoveTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandMoveTo.Controls.Add(this.lblMoveToPointId);
            this.frmCommandMoveTo.Controls.Add(this.txtMoveToPointId);
            this.frmCommandMoveTo.Controls.Add(this.chkMoveToFlagsPointMovement);
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
            this.frmCommandMoveTo.Location = new System.Drawing.Point(410, 252);
            this.frmCommandMoveTo.Name = "frmCommandMoveTo";
            this.frmCommandMoveTo.Size = new System.Drawing.Size(495, 332);
            this.frmCommandMoveTo.TabIndex = 13;
            this.frmCommandMoveTo.Visible = false;
            // 
            // lblMoveToPointId
            // 
            this.lblMoveToPointId.AutoSize = true;
            this.lblMoveToPointId.Location = new System.Drawing.Point(23, 146);
            this.lblMoveToPointId.Name = "lblMoveToPointId";
            this.lblMoveToPointId.Size = new System.Drawing.Size(46, 13);
            this.lblMoveToPointId.TabIndex = 17;
            this.lblMoveToPointId.Text = "Point Id:";
            // 
            // txtMoveToPointId
            // 
            this.txtMoveToPointId.Location = new System.Drawing.Point(20, 162);
            this.txtMoveToPointId.Name = "txtMoveToPointId";
            this.txtMoveToPointId.Size = new System.Drawing.Size(200, 20);
            this.txtMoveToPointId.TabIndex = 16;
            this.txtMoveToPointId.Leave += new System.EventHandler(this.txtMoveToPointId_Leave);
            // 
            // chkMoveToFlagsPointMovement
            // 
            this.chkMoveToFlagsPointMovement.AutoSize = true;
            this.chkMoveToFlagsPointMovement.Location = new System.Drawing.Point(20, 299);
            this.chkMoveToFlagsPointMovement.Name = "chkMoveToFlagsPointMovement";
            this.chkMoveToFlagsPointMovement.Size = new System.Drawing.Size(175, 17);
            this.chkMoveToFlagsPointMovement.TabIndex = 15;
            this.chkMoveToFlagsPointMovement.Text = "Use Point Movement Generator";
            this.chkMoveToFlagsPointMovement.UseVisualStyleBackColor = true;
            this.chkMoveToFlagsPointMovement.CheckedChanged += new System.EventHandler(this.chkMoveToFlagsPointMovement_CheckedChanged);
            // 
            // chkMoveToFlagsForce
            // 
            this.chkMoveToFlagsForce.AutoSize = true;
            this.chkMoveToFlagsForce.Location = new System.Drawing.Point(20, 276);
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
            this.lblMoveToO.Location = new System.Drawing.Point(131, 228);
            this.lblMoveToO.Name = "lblMoveToO";
            this.lblMoveToO.Size = new System.Drawing.Size(61, 13);
            this.lblMoveToO.TabIndex = 13;
            this.lblMoveToO.Text = "Orientation:";
            // 
            // lblMoveToZ
            // 
            this.lblMoveToZ.AutoSize = true;
            this.lblMoveToZ.Location = new System.Drawing.Point(23, 228);
            this.lblMoveToZ.Name = "lblMoveToZ";
            this.lblMoveToZ.Size = new System.Drawing.Size(70, 13);
            this.lblMoveToZ.TabIndex = 12;
            this.lblMoveToZ.Text = "Z coordinate:";
            // 
            // lblMoveToY
            // 
            this.lblMoveToY.AutoSize = true;
            this.lblMoveToY.Location = new System.Drawing.Point(132, 188);
            this.lblMoveToY.Name = "lblMoveToY";
            this.lblMoveToY.Size = new System.Drawing.Size(70, 13);
            this.lblMoveToY.TabIndex = 11;
            this.lblMoveToY.Text = "Y coordinate:";
            // 
            // lblMoveToX
            // 
            this.lblMoveToX.AutoSize = true;
            this.lblMoveToX.Location = new System.Drawing.Point(23, 188);
            this.lblMoveToX.Name = "lblMoveToX";
            this.lblMoveToX.Size = new System.Drawing.Size(70, 13);
            this.lblMoveToX.TabIndex = 10;
            this.lblMoveToX.Text = "X coordinate:";
            // 
            // txtMoveToO
            // 
            this.txtMoveToO.Location = new System.Drawing.Point(128, 245);
            this.txtMoveToO.Name = "txtMoveToO";
            this.txtMoveToO.Size = new System.Drawing.Size(92, 20);
            this.txtMoveToO.TabIndex = 9;
            this.txtMoveToO.Leave += new System.EventHandler(this.txtMoveToO_Leave);
            // 
            // txtMoveToZ
            // 
            this.txtMoveToZ.Location = new System.Drawing.Point(19, 245);
            this.txtMoveToZ.Name = "txtMoveToZ";
            this.txtMoveToZ.Size = new System.Drawing.Size(92, 20);
            this.txtMoveToZ.TabIndex = 8;
            this.txtMoveToZ.Leave += new System.EventHandler(this.txtMoveToZ_Leave);
            // 
            // txtMoveToY
            // 
            this.txtMoveToY.Location = new System.Drawing.Point(128, 205);
            this.txtMoveToY.Name = "txtMoveToY";
            this.txtMoveToY.Size = new System.Drawing.Size(92, 20);
            this.txtMoveToY.TabIndex = 7;
            this.txtMoveToY.Leave += new System.EventHandler(this.txtMoveToY_Leave);
            // 
            // txtMoveToX
            // 
            this.txtMoveToX.Location = new System.Drawing.Point(19, 205);
            this.txtMoveToX.Name = "txtMoveToX";
            this.txtMoveToX.Size = new System.Drawing.Size(92, 20);
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
            this.lblMoveToTime.Location = new System.Drawing.Point(23, 103);
            this.lblMoveToTime.Name = "lblMoveToTime";
            this.lblMoveToTime.Size = new System.Drawing.Size(55, 13);
            this.lblMoveToTime.TabIndex = 4;
            this.lblMoveToTime.Text = "Time (ms):";
            // 
            // txtMoveToTime
            // 
            this.txtMoveToTime.Location = new System.Drawing.Point(20, 119);
            this.txtMoveToTime.Name = "txtMoveToTime";
            this.txtMoveToTime.Size = new System.Drawing.Size(200, 20);
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
            this.cmbMoveToType.Size = new System.Drawing.Size(200, 21);
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
            this.frmCommandTeleport.Location = new System.Drawing.Point(410, 252);
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
            this.frmCommandQuestComplete.Controls.Add(this.lblQuestCompleteGroup);
            this.frmCommandQuestComplete.Controls.Add(this.cmbQuestCompleteGroup);
            this.frmCommandQuestComplete.Controls.Add(this.lblQuestCompleteId);
            this.frmCommandQuestComplete.Controls.Add(this.lblQuestCompleteDistance);
            this.frmCommandQuestComplete.Controls.Add(this.txtQuestCompleteDistance);
            this.frmCommandQuestComplete.Controls.Add(this.btnQuestCompleteId);
            this.frmCommandQuestComplete.Controls.Add(this.lblQuestCompleteTooltip);
            this.frmCommandQuestComplete.Location = new System.Drawing.Point(410, 252);
            this.frmCommandQuestComplete.Name = "frmCommandQuestComplete";
            this.frmCommandQuestComplete.Size = new System.Drawing.Size(495, 332);
            this.frmCommandQuestComplete.TabIndex = 15;
            this.frmCommandQuestComplete.Visible = false;
            // 
            // lblQuestCompleteGroup
            // 
            this.lblQuestCompleteGroup.AutoSize = true;
            this.lblQuestCompleteGroup.Location = new System.Drawing.Point(57, 125);
            this.lblQuestCompleteGroup.Name = "lblQuestCompleteGroup";
            this.lblQuestCompleteGroup.Size = new System.Drawing.Size(39, 13);
            this.lblQuestCompleteGroup.TabIndex = 6;
            this.lblQuestCompleteGroup.Text = "Group:";
            // 
            // cmbQuestCompleteGroup
            // 
            this.cmbQuestCompleteGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestCompleteGroup.FormattingEnabled = true;
            this.cmbQuestCompleteGroup.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbQuestCompleteGroup.Location = new System.Drawing.Point(99, 121);
            this.cmbQuestCompleteGroup.Name = "cmbQuestCompleteGroup";
            this.cmbQuestCompleteGroup.Size = new System.Drawing.Size(374, 21);
            this.cmbQuestCompleteGroup.TabIndex = 5;
            this.cmbQuestCompleteGroup.SelectedIndexChanged += new System.EventHandler(this.cmbQuestCompleteGroup_SelectedIndexChanged);
            // 
            // lblQuestCompleteId
            // 
            this.lblQuestCompleteId.AutoSize = true;
            this.lblQuestCompleteId.Location = new System.Drawing.Point(46, 61);
            this.lblQuestCompleteId.Name = "lblQuestCompleteId";
            this.lblQuestCompleteId.Size = new System.Drawing.Size(50, 13);
            this.lblQuestCompleteId.TabIndex = 4;
            this.lblQuestCompleteId.Text = "Quest Id:";
            // 
            // lblQuestCompleteDistance
            // 
            this.lblQuestCompleteDistance.AutoSize = true;
            this.lblQuestCompleteDistance.Location = new System.Drawing.Point(44, 93);
            this.lblQuestCompleteDistance.Name = "lblQuestCompleteDistance";
            this.lblQuestCompleteDistance.Size = new System.Drawing.Size(52, 13);
            this.lblQuestCompleteDistance.TabIndex = 3;
            this.lblQuestCompleteDistance.Text = "Distance:";
            // 
            // txtQuestCompleteDistance
            // 
            this.txtQuestCompleteDistance.Location = new System.Drawing.Point(99, 90);
            this.txtQuestCompleteDistance.Name = "txtQuestCompleteDistance";
            this.txtQuestCompleteDistance.Size = new System.Drawing.Size(374, 20);
            this.txtQuestCompleteDistance.TabIndex = 2;
            this.txtQuestCompleteDistance.Leave += new System.EventHandler(this.txtQuestCompleteDistance_Leave);
            // 
            // btnQuestCompleteId
            // 
            this.btnQuestCompleteId.Location = new System.Drawing.Point(99, 58);
            this.btnQuestCompleteId.Name = "btnQuestCompleteId";
            this.btnQuestCompleteId.Size = new System.Drawing.Size(374, 23);
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
            this.frmCommandKillCredit.Location = new System.Drawing.Point(410, 252);
            this.frmCommandKillCredit.Name = "frmCommandKillCredit";
            this.frmCommandKillCredit.Size = new System.Drawing.Size(495, 332);
            this.frmCommandKillCredit.TabIndex = 16;
            this.frmCommandKillCredit.Visible = false;
            // 
            // cmbKillCreditType
            // 
            this.cmbKillCreditType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKillCreditType.FormattingEnabled = true;
            this.cmbKillCreditType.Location = new System.Drawing.Point(99, 90);
            this.cmbKillCreditType.Name = "cmbKillCreditType";
            this.cmbKillCreditType.Size = new System.Drawing.Size(374, 21);
            this.cmbKillCreditType.TabIndex = 5;
            this.cmbKillCreditType.SelectedIndexChanged += new System.EventHandler(this.cmbKillCreditType_SelectedIndexChanged);
            // 
            // lblKillCreditCreatureId
            // 
            this.lblKillCreditCreatureId.AutoSize = true;
            this.lblKillCreditCreatureId.Location = new System.Drawing.Point(34, 61);
            this.lblKillCreditCreatureId.Name = "lblKillCreditCreatureId";
            this.lblKillCreditCreatureId.Size = new System.Drawing.Size(62, 13);
            this.lblKillCreditCreatureId.TabIndex = 4;
            this.lblKillCreditCreatureId.Text = "Creature Id:";
            // 
            // lblKillCreditType
            // 
            this.lblKillCreditType.AutoSize = true;
            this.lblKillCreditType.Location = new System.Drawing.Point(62, 93);
            this.lblKillCreditType.Name = "lblKillCreditType";
            this.lblKillCreditType.Size = new System.Drawing.Size(34, 13);
            this.lblKillCreditType.TabIndex = 3;
            this.lblKillCreditType.Text = "Type:";
            // 
            // btnKillCreditCreatureId
            // 
            this.btnKillCreditCreatureId.Location = new System.Drawing.Point(99, 58);
            this.btnKillCreditCreatureId.Name = "btnKillCreditCreatureId";
            this.btnKillCreditCreatureId.Size = new System.Drawing.Size(374, 23);
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
            this.lblKillCreditTooltip.Text = "Gives the target or source Player and his group credit for killing the specified " +
    "creature.";
            // 
            // frmCommandRespawnGameobject
            // 
            this.frmCommandRespawnGameobject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandRespawnGameobject.Controls.Add(this.lblRespawnGameobjectDelay);
            this.frmCommandRespawnGameobject.Controls.Add(this.lblRespawnGameobjectGuid);
            this.frmCommandRespawnGameobject.Controls.Add(this.txtRespawnGameobjectDelay);
            this.frmCommandRespawnGameobject.Controls.Add(this.txtRespawnGameobjectGuid);
            this.frmCommandRespawnGameobject.Controls.Add(this.lblRespawnGameobjectTooltip);
            this.frmCommandRespawnGameobject.Location = new System.Drawing.Point(410, 252);
            this.frmCommandRespawnGameobject.Name = "frmCommandRespawnGameobject";
            this.frmCommandRespawnGameobject.Size = new System.Drawing.Size(495, 332);
            this.frmCommandRespawnGameobject.TabIndex = 17;
            this.frmCommandRespawnGameobject.Visible = false;
            // 
            // lblRespawnGameobjectDelay
            // 
            this.lblRespawnGameobjectDelay.AutoSize = true;
            this.lblRespawnGameobjectDelay.Location = new System.Drawing.Point(59, 93);
            this.lblRespawnGameobjectDelay.Name = "lblRespawnGameobjectDelay";
            this.lblRespawnGameobjectDelay.Size = new System.Drawing.Size(37, 13);
            this.lblRespawnGameobjectDelay.TabIndex = 4;
            this.lblRespawnGameobjectDelay.Text = "Delay:";
            // 
            // lblRespawnGameobjectGuid
            // 
            this.lblRespawnGameobjectGuid.AutoSize = true;
            this.lblRespawnGameobjectGuid.Location = new System.Drawing.Point(59, 61);
            this.lblRespawnGameobjectGuid.Name = "lblRespawnGameobjectGuid";
            this.lblRespawnGameobjectGuid.Size = new System.Drawing.Size(37, 13);
            this.lblRespawnGameobjectGuid.TabIndex = 3;
            this.lblRespawnGameobjectGuid.Text = "GUID:";
            // 
            // txtRespawnGameobjectDelay
            // 
            this.txtRespawnGameobjectDelay.Location = new System.Drawing.Point(99, 90);
            this.txtRespawnGameobjectDelay.Name = "txtRespawnGameobjectDelay";
            this.txtRespawnGameobjectDelay.Size = new System.Drawing.Size(374, 20);
            this.txtRespawnGameobjectDelay.TabIndex = 2;
            this.txtRespawnGameobjectDelay.Leave += new System.EventHandler(this.txtRespawnGameobjectDelay_Leave);
            // 
            // txtRespawnGameobjectGuid
            // 
            this.txtRespawnGameobjectGuid.Location = new System.Drawing.Point(99, 58);
            this.txtRespawnGameobjectGuid.Name = "txtRespawnGameobjectGuid";
            this.txtRespawnGameobjectGuid.Size = new System.Drawing.Size(374, 20);
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
            this.lblRespawnGameobjectTooltip.Text = "Respawns the GameObject with the specified GUID, and then despawns it again when " +
    "the delay expires.";
            // 
            // frmCommandSummonCreature
            // 
            this.frmCommandSummonCreature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSummonCreature.Controls.Add(this.btnSummonCreatureScriptIdEdit);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureScriptId);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureDespawnType);
            this.frmCommandSummonCreature.Controls.Add(this.cmbSummonCreatureDespawnType);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureO);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureZ);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureY);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureX);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureO);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureZ);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureY);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureX);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureUniqueRange);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureUniqueLimit);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureUniqueRange);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureUniqueLimit);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureAttackTarget);
            this.frmCommandSummonCreature.Controls.Add(this.cmbSummonCreatureAttackTarget);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureScriptId);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureDelay);
            this.frmCommandSummonCreature.Controls.Add(this.txtSummonCreatureDelay);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureId);
            this.frmCommandSummonCreature.Controls.Add(this.grpSummonCreatureFlags);
            this.frmCommandSummonCreature.Controls.Add(this.btnSummonCreatureId);
            this.frmCommandSummonCreature.Controls.Add(this.lblSummonCreatureTooltip);
            this.frmCommandSummonCreature.Location = new System.Drawing.Point(410, 252);
            this.frmCommandSummonCreature.Name = "frmCommandSummonCreature";
            this.frmCommandSummonCreature.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSummonCreature.TabIndex = 18;
            this.frmCommandSummonCreature.Visible = false;
            // 
            // btnSummonCreatureScriptIdEdit
            // 
            this.btnSummonCreatureScriptIdEdit.Location = new System.Drawing.Point(429, 245);
            this.btnSummonCreatureScriptIdEdit.Name = "btnSummonCreatureScriptIdEdit";
            this.btnSummonCreatureScriptIdEdit.Size = new System.Drawing.Size(44, 22);
            this.btnSummonCreatureScriptIdEdit.TabIndex = 25;
            this.btnSummonCreatureScriptIdEdit.Text = "Edit";
            this.btnSummonCreatureScriptIdEdit.UseVisualStyleBackColor = true;
            this.btnSummonCreatureScriptIdEdit.Click += new System.EventHandler(this.btnSummonCreatureScriptIdEdit_Click);
            // 
            // txtSummonCreatureScriptId
            // 
            this.txtSummonCreatureScriptId.Location = new System.Drawing.Point(292, 246);
            this.txtSummonCreatureScriptId.Name = "txtSummonCreatureScriptId";
            this.txtSummonCreatureScriptId.Size = new System.Drawing.Size(131, 20);
            this.txtSummonCreatureScriptId.TabIndex = 24;
            this.txtSummonCreatureScriptId.Leave += new System.EventHandler(this.txtSummonCreatureScriptId_Leave);
            // 
            // lblSummonCreatureDespawnType
            // 
            this.lblSummonCreatureDespawnType.AutoSize = true;
            this.lblSummonCreatureDespawnType.Location = new System.Drawing.Point(47, 138);
            this.lblSummonCreatureDespawnType.Name = "lblSummonCreatureDespawnType";
            this.lblSummonCreatureDespawnType.Size = new System.Drawing.Size(78, 13);
            this.lblSummonCreatureDespawnType.TabIndex = 23;
            this.lblSummonCreatureDespawnType.Text = "Despawn type:";
            // 
            // cmbSummonCreatureDespawnType
            // 
            this.cmbSummonCreatureDespawnType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSummonCreatureDespawnType.FormattingEnabled = true;
            this.cmbSummonCreatureDespawnType.Location = new System.Drawing.Point(131, 134);
            this.cmbSummonCreatureDespawnType.Name = "cmbSummonCreatureDespawnType";
            this.cmbSummonCreatureDespawnType.Size = new System.Drawing.Size(143, 21);
            this.cmbSummonCreatureDespawnType.TabIndex = 22;
            this.cmbSummonCreatureDespawnType.SelectedIndexChanged += new System.EventHandler(this.cmbSummonCreatureDespawnType_SelectedIndexChanged);
            // 
            // lblSummonCreatureO
            // 
            this.lblSummonCreatureO.AutoSize = true;
            this.lblSummonCreatureO.Location = new System.Drawing.Point(64, 292);
            this.lblSummonCreatureO.Name = "lblSummonCreatureO";
            this.lblSummonCreatureO.Size = new System.Drawing.Size(61, 13);
            this.lblSummonCreatureO.TabIndex = 21;
            this.lblSummonCreatureO.Text = "Orientation:";
            // 
            // lblSummonCreatureZ
            // 
            this.lblSummonCreatureZ.AutoSize = true;
            this.lblSummonCreatureZ.Location = new System.Drawing.Point(55, 263);
            this.lblSummonCreatureZ.Name = "lblSummonCreatureZ";
            this.lblSummonCreatureZ.Size = new System.Drawing.Size(70, 13);
            this.lblSummonCreatureZ.TabIndex = 20;
            this.lblSummonCreatureZ.Text = "Z coordinate:";
            // 
            // lblSummonCreatureY
            // 
            this.lblSummonCreatureY.AutoSize = true;
            this.lblSummonCreatureY.Location = new System.Drawing.Point(55, 233);
            this.lblSummonCreatureY.Name = "lblSummonCreatureY";
            this.lblSummonCreatureY.Size = new System.Drawing.Size(70, 13);
            this.lblSummonCreatureY.TabIndex = 19;
            this.lblSummonCreatureY.Text = "Y coordinate:";
            // 
            // lblSummonCreatureX
            // 
            this.lblSummonCreatureX.AutoSize = true;
            this.lblSummonCreatureX.Location = new System.Drawing.Point(55, 201);
            this.lblSummonCreatureX.Name = "lblSummonCreatureX";
            this.lblSummonCreatureX.Size = new System.Drawing.Size(70, 13);
            this.lblSummonCreatureX.TabIndex = 18;
            this.lblSummonCreatureX.Text = "X coordinate:";
            // 
            // txtSummonCreatureO
            // 
            this.txtSummonCreatureO.Location = new System.Drawing.Point(131, 291);
            this.txtSummonCreatureO.Name = "txtSummonCreatureO";
            this.txtSummonCreatureO.Size = new System.Drawing.Size(143, 20);
            this.txtSummonCreatureO.TabIndex = 17;
            this.txtSummonCreatureO.Leave += new System.EventHandler(this.txtSummonCreatureO_Leave);
            // 
            // txtSummonCreatureZ
            // 
            this.txtSummonCreatureZ.Location = new System.Drawing.Point(132, 260);
            this.txtSummonCreatureZ.Name = "txtSummonCreatureZ";
            this.txtSummonCreatureZ.Size = new System.Drawing.Size(142, 20);
            this.txtSummonCreatureZ.TabIndex = 16;
            this.txtSummonCreatureZ.Leave += new System.EventHandler(this.txtSummonCreatureZ_Leave);
            // 
            // txtSummonCreatureY
            // 
            this.txtSummonCreatureY.Location = new System.Drawing.Point(131, 229);
            this.txtSummonCreatureY.Name = "txtSummonCreatureY";
            this.txtSummonCreatureY.Size = new System.Drawing.Size(143, 20);
            this.txtSummonCreatureY.TabIndex = 15;
            this.txtSummonCreatureY.Leave += new System.EventHandler(this.txtSummonCreatureY_Leave);
            // 
            // txtSummonCreatureX
            // 
            this.txtSummonCreatureX.Location = new System.Drawing.Point(131, 198);
            this.txtSummonCreatureX.Name = "txtSummonCreatureX";
            this.txtSummonCreatureX.Size = new System.Drawing.Size(143, 20);
            this.txtSummonCreatureX.TabIndex = 14;
            this.txtSummonCreatureX.Leave += new System.EventHandler(this.txtSummonCreatureX_Leave);
            // 
            // lblSummonCreatureUniqueRange
            // 
            this.lblSummonCreatureUniqueRange.AutoSize = true;
            this.lblSummonCreatureUniqueRange.Location = new System.Drawing.Point(389, 272);
            this.lblSummonCreatureUniqueRange.Name = "lblSummonCreatureUniqueRange";
            this.lblSummonCreatureUniqueRange.Size = new System.Drawing.Size(74, 13);
            this.lblSummonCreatureUniqueRange.TabIndex = 13;
            this.lblSummonCreatureUniqueRange.Text = "Unique range:";
            // 
            // lblSummonCreatureUniqueLimit
            // 
            this.lblSummonCreatureUniqueLimit.AutoSize = true;
            this.lblSummonCreatureUniqueLimit.Location = new System.Drawing.Point(293, 272);
            this.lblSummonCreatureUniqueLimit.Name = "lblSummonCreatureUniqueLimit";
            this.lblSummonCreatureUniqueLimit.Size = new System.Drawing.Size(64, 13);
            this.lblSummonCreatureUniqueLimit.TabIndex = 12;
            this.lblSummonCreatureUniqueLimit.Text = "Unique limit:";
            // 
            // txtSummonCreatureUniqueRange
            // 
            this.txtSummonCreatureUniqueRange.Location = new System.Drawing.Point(388, 291);
            this.txtSummonCreatureUniqueRange.Name = "txtSummonCreatureUniqueRange";
            this.txtSummonCreatureUniqueRange.Size = new System.Drawing.Size(85, 20);
            this.txtSummonCreatureUniqueRange.TabIndex = 11;
            this.txtSummonCreatureUniqueRange.Leave += new System.EventHandler(this.txtSummonCreatureUniqueRange_Leave);
            // 
            // txtSummonCreatureUniqueLimit
            // 
            this.txtSummonCreatureUniqueLimit.Location = new System.Drawing.Point(292, 291);
            this.txtSummonCreatureUniqueLimit.Name = "txtSummonCreatureUniqueLimit";
            this.txtSummonCreatureUniqueLimit.Size = new System.Drawing.Size(85, 20);
            this.txtSummonCreatureUniqueLimit.TabIndex = 10;
            this.txtSummonCreatureUniqueLimit.Leave += new System.EventHandler(this.txtSummonCreatureUniqueLimit_Leave);
            // 
            // lblSummonCreatureAttackTarget
            // 
            this.lblSummonCreatureAttackTarget.AutoSize = true;
            this.lblSummonCreatureAttackTarget.Location = new System.Drawing.Point(54, 169);
            this.lblSummonCreatureAttackTarget.Name = "lblSummonCreatureAttackTarget";
            this.lblSummonCreatureAttackTarget.Size = new System.Drawing.Size(71, 13);
            this.lblSummonCreatureAttackTarget.TabIndex = 9;
            this.lblSummonCreatureAttackTarget.Text = "Attack target:";
            // 
            // cmbSummonCreatureAttackTarget
            // 
            this.cmbSummonCreatureAttackTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSummonCreatureAttackTarget.FormattingEnabled = true;
            this.cmbSummonCreatureAttackTarget.Location = new System.Drawing.Point(131, 166);
            this.cmbSummonCreatureAttackTarget.Name = "cmbSummonCreatureAttackTarget";
            this.cmbSummonCreatureAttackTarget.Size = new System.Drawing.Size(143, 21);
            this.cmbSummonCreatureAttackTarget.TabIndex = 8;
            this.cmbSummonCreatureAttackTarget.SelectedIndexChanged += new System.EventHandler(this.cmbSummonCreatureAttackTarget_SelectedIndexChanged);
            // 
            // lblSummonCreatureScriptId
            // 
            this.lblSummonCreatureScriptId.AutoSize = true;
            this.lblSummonCreatureScriptId.Location = new System.Drawing.Point(293, 227);
            this.lblSummonCreatureScriptId.Name = "lblSummonCreatureScriptId";
            this.lblSummonCreatureScriptId.Size = new System.Drawing.Size(49, 13);
            this.lblSummonCreatureScriptId.TabIndex = 7;
            this.lblSummonCreatureScriptId.Text = "Script Id:";
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
            this.grpSummonCreatureFlags.Controls.Add(this.chkSummonCreatureFlags16);
            this.grpSummonCreatureFlags.Controls.Add(this.chkSummonCreatureFlags1);
            this.grpSummonCreatureFlags.Controls.Add(this.chkSummonCreatureFlags8);
            this.grpSummonCreatureFlags.Controls.Add(this.chkSummonCreatureFlags4);
            this.grpSummonCreatureFlags.Controls.Add(this.chkSummonCreatureFlags2);
            this.grpSummonCreatureFlags.Location = new System.Drawing.Point(292, 58);
            this.grpSummonCreatureFlags.Name = "grpSummonCreatureFlags";
            this.grpSummonCreatureFlags.Size = new System.Drawing.Size(181, 156);
            this.grpSummonCreatureFlags.TabIndex = 2;
            this.grpSummonCreatureFlags.TabStop = false;
            this.grpSummonCreatureFlags.Text = "Summon Flags";
            // 
            // chkSummonCreatureFlags16
            // 
            this.chkSummonCreatureFlags16.AutoSize = true;
            this.chkSummonCreatureFlags16.Location = new System.Drawing.Point(10, 124);
            this.chkSummonCreatureFlags16.Name = "chkSummonCreatureFlags16";
            this.chkSummonCreatureFlags16.Size = new System.Drawing.Size(74, 17);
            this.chkSummonCreatureFlags16.TabIndex = 4;
            this.chkSummonCreatureFlags16.Text = "Disable AI";
            this.chkSummonCreatureFlags16.UseVisualStyleBackColor = true;
            this.chkSummonCreatureFlags16.CheckStateChanged += new System.EventHandler(this.chkSummonCreatureFlags16_CheckStateChanged);
            // 
            // chkSummonCreatureFlags1
            // 
            this.chkSummonCreatureFlags1.AutoSize = true;
            this.chkSummonCreatureFlags1.Location = new System.Drawing.Point(10, 24);
            this.chkSummonCreatureFlags1.Name = "chkSummonCreatureFlags1";
            this.chkSummonCreatureFlags1.Size = new System.Drawing.Size(103, 17);
            this.chkSummonCreatureFlags1.TabIndex = 3;
            this.chkSummonCreatureFlags1.Text = "Runs By Default";
            this.chkSummonCreatureFlags1.UseVisualStyleBackColor = true;
            this.chkSummonCreatureFlags1.CheckedChanged += new System.EventHandler(this.chkSummonCreatureFlags1_CheckedChanged);
            // 
            // chkSummonCreatureFlags8
            // 
            this.chkSummonCreatureFlags8.AutoSize = true;
            this.chkSummonCreatureFlags8.Location = new System.Drawing.Point(10, 99);
            this.chkSummonCreatureFlags8.Name = "chkSummonCreatureFlags8";
            this.chkSummonCreatureFlags8.Size = new System.Drawing.Size(149, 17);
            this.chkSummonCreatureFlags8.TabIndex = 2;
            this.chkSummonCreatureFlags8.Text = "Unique Temporary Spawn";
            this.chkSummonCreatureFlags8.UseVisualStyleBackColor = true;
            this.chkSummonCreatureFlags8.CheckStateChanged += new System.EventHandler(this.chkSummonCreatureFlags8_CheckStateChanged);
            // 
            // chkSummonCreatureFlags4
            // 
            this.chkSummonCreatureFlags4.AutoSize = true;
            this.chkSummonCreatureFlags4.Location = new System.Drawing.Point(10, 74);
            this.chkSummonCreatureFlags4.Name = "chkSummonCreatureFlags4";
            this.chkSummonCreatureFlags4.Size = new System.Drawing.Size(96, 17);
            this.chkSummonCreatureFlags4.TabIndex = 1;
            this.chkSummonCreatureFlags4.Text = "Unique Spawn";
            this.chkSummonCreatureFlags4.UseVisualStyleBackColor = true;
            this.chkSummonCreatureFlags4.CheckedChanged += new System.EventHandler(this.chkSummonCreatureFlags4_CheckedChanged);
            // 
            // chkSummonCreatureFlags2
            // 
            this.chkSummonCreatureFlags2.AutoSize = true;
            this.chkSummonCreatureFlags2.Location = new System.Drawing.Point(10, 49);
            this.chkSummonCreatureFlags2.Name = "chkSummonCreatureFlags2";
            this.chkSummonCreatureFlags2.Size = new System.Drawing.Size(120, 17);
            this.chkSummonCreatureFlags2.TabIndex = 0;
            this.chkSummonCreatureFlags2.Text = "Make Active Object";
            this.chkSummonCreatureFlags2.UseVisualStyleBackColor = true;
            this.chkSummonCreatureFlags2.CheckedChanged += new System.EventHandler(this.chkSummonCreatureFlags2_CheckedChanged);
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
            this.frmCommandDoor.Location = new System.Drawing.Point(410, 252);
            this.frmCommandDoor.Name = "frmCommandDoor";
            this.frmCommandDoor.Size = new System.Drawing.Size(495, 332);
            this.frmCommandDoor.TabIndex = 19;
            this.frmCommandDoor.Visible = false;
            // 
            // lblDoorResetDelay
            // 
            this.lblDoorResetDelay.AutoSize = true;
            this.lblDoorResetDelay.Location = new System.Drawing.Point(59, 93);
            this.lblDoorResetDelay.Name = "lblDoorResetDelay";
            this.lblDoorResetDelay.Size = new System.Drawing.Size(37, 13);
            this.lblDoorResetDelay.TabIndex = 4;
            this.lblDoorResetDelay.Text = "Delay:";
            // 
            // lblDoorGuid
            // 
            this.lblDoorGuid.AutoSize = true;
            this.lblDoorGuid.Location = new System.Drawing.Point(59, 61);
            this.lblDoorGuid.Name = "lblDoorGuid";
            this.lblDoorGuid.Size = new System.Drawing.Size(37, 13);
            this.lblDoorGuid.TabIndex = 3;
            this.lblDoorGuid.Text = "GUID:";
            // 
            // txtDoorResetDelay
            // 
            this.txtDoorResetDelay.Location = new System.Drawing.Point(99, 90);
            this.txtDoorResetDelay.Name = "txtDoorResetDelay";
            this.txtDoorResetDelay.Size = new System.Drawing.Size(374, 20);
            this.txtDoorResetDelay.TabIndex = 2;
            this.txtDoorResetDelay.Leave += new System.EventHandler(this.txtDoorResetDelay_Leave);
            // 
            // txtDoorGuid
            // 
            this.txtDoorGuid.Location = new System.Drawing.Point(99, 58);
            this.txtDoorGuid.Name = "txtDoorGuid";
            this.txtDoorGuid.Size = new System.Drawing.Size(374, 20);
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
            this.frmCommandRemoveAura.Controls.Add(this.grpAddAuraFlags);
            this.frmCommandRemoveAura.Controls.Add(this.btnRemoveAuraSpellId);
            this.frmCommandRemoveAura.Controls.Add(this.lblRemoveAuraSpellId);
            this.frmCommandRemoveAura.Controls.Add(this.lblRemoveAuraTooltip);
            this.frmCommandRemoveAura.Location = new System.Drawing.Point(410, 252);
            this.frmCommandRemoveAura.Name = "frmCommandRemoveAura";
            this.frmCommandRemoveAura.Size = new System.Drawing.Size(495, 332);
            this.frmCommandRemoveAura.TabIndex = 20;
            this.frmCommandRemoveAura.Visible = false;
            // 
            // grpAddAuraFlags
            // 
            this.grpAddAuraFlags.Controls.Add(this.chkAddAuraFlag8);
            this.grpAddAuraFlags.Controls.Add(this.chkAddAuraFlag4);
            this.grpAddAuraFlags.Controls.Add(this.chkAddAuraFlag2);
            this.grpAddAuraFlags.Controls.Add(this.chkAddAuraFlag1);
            this.grpAddAuraFlags.Location = new System.Drawing.Point(26, 93);
            this.grpAddAuraFlags.Name = "grpAddAuraFlags";
            this.grpAddAuraFlags.Size = new System.Drawing.Size(447, 50);
            this.grpAddAuraFlags.TabIndex = 3;
            this.grpAddAuraFlags.TabStop = false;
            this.grpAddAuraFlags.Text = "Add Aura Flags";
            // 
            // chkAddAuraFlag8
            // 
            this.chkAddAuraFlag8.AutoSize = true;
            this.chkAddAuraFlag8.Location = new System.Drawing.Point(234, 23);
            this.chkAddAuraFlag8.Name = "chkAddAuraFlag8";
            this.chkAddAuraFlag8.Size = new System.Drawing.Size(77, 17);
            this.chkAddAuraFlag8.TabIndex = 3;
            this.chkAddAuraFlag8.Text = "Permanent";
            this.chkAddAuraFlag8.UseVisualStyleBackColor = true;
            this.chkAddAuraFlag8.CheckedChanged += new System.EventHandler(this.chkAddAuraFlag8_CheckedChanged);
            // 
            // chkAddAuraFlag4
            // 
            this.chkAddAuraFlag4.AutoSize = true;
            this.chkAddAuraFlag4.Location = new System.Drawing.Point(161, 23);
            this.chkAddAuraFlag4.Name = "chkAddAuraFlag4";
            this.chkAddAuraFlag4.Size = new System.Drawing.Size(63, 17);
            this.chkAddAuraFlag4.TabIndex = 2;
            this.chkAddAuraFlag4.Text = "Passive";
            this.chkAddAuraFlag4.UseVisualStyleBackColor = true;
            this.chkAddAuraFlag4.CheckedChanged += new System.EventHandler(this.chkAddAuraFlag4_CheckedChanged);
            // 
            // chkAddAuraFlag2
            // 
            this.chkAddAuraFlag2.AutoSize = true;
            this.chkAddAuraFlag2.Location = new System.Drawing.Point(82, 23);
            this.chkAddAuraFlag2.Name = "chkAddAuraFlag2";
            this.chkAddAuraFlag2.Size = new System.Drawing.Size(69, 17);
            this.chkAddAuraFlag2.TabIndex = 1;
            this.chkAddAuraFlag2.Text = "Negative";
            this.chkAddAuraFlag2.UseVisualStyleBackColor = true;
            this.chkAddAuraFlag2.CheckedChanged += new System.EventHandler(this.chkAddAuraFlag2_CheckedChanged);
            // 
            // chkAddAuraFlag1
            // 
            this.chkAddAuraFlag1.AutoSize = true;
            this.chkAddAuraFlag1.Location = new System.Drawing.Point(9, 23);
            this.chkAddAuraFlag1.Name = "chkAddAuraFlag1";
            this.chkAddAuraFlag1.Size = new System.Drawing.Size(63, 17);
            this.chkAddAuraFlag1.TabIndex = 0;
            this.chkAddAuraFlag1.Text = "Positive";
            this.chkAddAuraFlag1.UseVisualStyleBackColor = true;
            this.chkAddAuraFlag1.CheckedChanged += new System.EventHandler(this.chkAddAuraFlag1_CheckedChanged);
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
            this.frmCommandCastSpell.Location = new System.Drawing.Point(410, 252);
            this.frmCommandCastSpell.Name = "frmCommandCastSpell";
            this.frmCommandCastSpell.Size = new System.Drawing.Size(495, 332);
            this.frmCommandCastSpell.TabIndex = 21;
            this.frmCommandCastSpell.Visible = false;
            // 
            // grpCastSpellFlags
            // 
            this.grpCastSpellFlags.Controls.Add(this.chkCastSpellFlags128);
            this.grpCastSpellFlags.Controls.Add(this.chkCastSpellFlags64);
            this.grpCastSpellFlags.Controls.Add(this.chkCastSpellFlags32);
            this.grpCastSpellFlags.Controls.Add(this.chkCastSpellFlags16);
            this.grpCastSpellFlags.Controls.Add(this.chkCastSpellFlags4);
            this.grpCastSpellFlags.Controls.Add(this.chkCastSpellFlags1);
            this.grpCastSpellFlags.Controls.Add(this.chkCastSpellFlags2);
            this.grpCastSpellFlags.Location = new System.Drawing.Point(26, 88);
            this.grpCastSpellFlags.Name = "grpCastSpellFlags";
            this.grpCastSpellFlags.Size = new System.Drawing.Size(447, 77);
            this.grpCastSpellFlags.TabIndex = 3;
            this.grpCastSpellFlags.TabStop = false;
            this.grpCastSpellFlags.Text = "Cast Flags";
            // 
            // chkCastSpellFlags128
            // 
            this.chkCastSpellFlags128.AutoSize = true;
            this.chkCastSpellFlags128.Location = new System.Drawing.Point(243, 48);
            this.chkCastSpellFlags128.Name = "chkCastSpellFlags128";
            this.chkCastSpellFlags128.Size = new System.Drawing.Size(87, 17);
            this.chkCastSpellFlags128.TabIndex = 6;
            this.chkCastSpellFlags128.Text = "Not In Melee";
            this.chkCastSpellFlags128.UseVisualStyleBackColor = true;
            this.chkCastSpellFlags128.CheckedChanged += new System.EventHandler(this.chkCastSpellFlags128_CheckedChanged);
            // 
            // chkCastSpellFlags64
            // 
            this.chkCastSpellFlags64.AutoSize = true;
            this.chkCastSpellFlags64.Location = new System.Drawing.Point(146, 48);
            this.chkCastSpellFlags64.Name = "chkCastSpellFlags64";
            this.chkCastSpellFlags64.Size = new System.Drawing.Size(91, 17);
            this.chkCastSpellFlags64.TabIndex = 5;
            this.chkCastSpellFlags64.Text = "Only In Melee";
            this.chkCastSpellFlags64.UseVisualStyleBackColor = true;
            this.chkCastSpellFlags64.CheckedChanged += new System.EventHandler(this.chkCastSpellFlags64_CheckedChanged);
            // 
            // chkCastSpellFlags32
            // 
            this.chkCastSpellFlags32.AutoSize = true;
            this.chkCastSpellFlags32.Location = new System.Drawing.Point(10, 48);
            this.chkCastSpellFlags32.Name = "chkCastSpellFlags32";
            this.chkCastSpellFlags32.Size = new System.Drawing.Size(130, 17);
            this.chkCastSpellFlags32.TabIndex = 4;
            this.chkCastSpellFlags32.Text = "Only If Not Have Aura";
            this.chkCastSpellFlags32.UseVisualStyleBackColor = true;
            this.chkCastSpellFlags32.CheckedChanged += new System.EventHandler(this.chkCastSpellFlags32_CheckedChanged);
            // 
            // chkCastSpellFlags16
            // 
            this.chkCastSpellFlags16.AutoSize = true;
            this.chkCastSpellFlags16.Location = new System.Drawing.Point(259, 21);
            this.chkCastSpellFlags16.Name = "chkCastSpellFlags16";
            this.chkCastSpellFlags16.Size = new System.Drawing.Size(121, 17);
            this.chkCastSpellFlags16.TabIndex = 3;
            this.chkCastSpellFlags16.Text = "Target Unreachable";
            this.chkCastSpellFlags16.UseVisualStyleBackColor = true;
            this.chkCastSpellFlags16.CheckedChanged += new System.EventHandler(this.chkCastSpellFlags16_CheckedChanged);
            // 
            // chkCastSpellFlags4
            // 
            this.chkCastSpellFlags4.AutoSize = true;
            this.chkCastSpellFlags4.Location = new System.Drawing.Point(200, 21);
            this.chkCastSpellFlags4.Name = "chkCastSpellFlags4";
            this.chkCastSpellFlags4.Size = new System.Drawing.Size(53, 17);
            this.chkCastSpellFlags4.TabIndex = 2;
            this.chkCastSpellFlags4.Text = "Force";
            this.chkCastSpellFlags4.UseVisualStyleBackColor = true;
            this.chkCastSpellFlags4.CheckedChanged += new System.EventHandler(this.chkCastSpellFlags4_CheckedChanged);
            // 
            // chkCastSpellFlags1
            // 
            this.chkCastSpellFlags1.AutoSize = true;
            this.chkCastSpellFlags1.Location = new System.Drawing.Point(85, 21);
            this.chkCastSpellFlags1.Name = "chkCastSpellFlags1";
            this.chkCastSpellFlags1.Size = new System.Drawing.Size(109, 17);
            this.chkCastSpellFlags1.TabIndex = 1;
            this.chkCastSpellFlags1.Text = "Interrupt Previous";
            this.chkCastSpellFlags1.UseVisualStyleBackColor = true;
            this.chkCastSpellFlags1.CheckedChanged += new System.EventHandler(this.chkCastSpellFlags1_CheckedChanged);
            // 
            // chkCastSpellFlags2
            // 
            this.chkCastSpellFlags2.AutoSize = true;
            this.chkCastSpellFlags2.Location = new System.Drawing.Point(10, 21);
            this.chkCastSpellFlags2.Name = "chkCastSpellFlags2";
            this.chkCastSpellFlags2.Size = new System.Drawing.Size(71, 17);
            this.chkCastSpellFlags2.TabIndex = 0;
            this.chkCastSpellFlags2.Text = "Triggered";
            this.chkCastSpellFlags2.UseVisualStyleBackColor = true;
            this.chkCastSpellFlags2.CheckedChanged += new System.EventHandler(this.chkCastSpellFlags2_CheckedChanged);
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
            this.frmCommandPlaySound.Controls.Add(this.btnPlaySoundId);
            this.frmCommandPlaySound.Controls.Add(this.grpPlaySoundFlags);
            this.frmCommandPlaySound.Controls.Add(this.lblPlaySoundId);
            this.frmCommandPlaySound.Controls.Add(this.lblPlaySoundTooltip);
            this.frmCommandPlaySound.Location = new System.Drawing.Point(410, 252);
            this.frmCommandPlaySound.Name = "frmCommandPlaySound";
            this.frmCommandPlaySound.Size = new System.Drawing.Size(495, 332);
            this.frmCommandPlaySound.TabIndex = 22;
            this.frmCommandPlaySound.Visible = false;
            // 
            // btnPlaySoundId
            // 
            this.btnPlaySoundId.Location = new System.Drawing.Point(83, 58);
            this.btnPlaySoundId.Name = "btnPlaySoundId";
            this.btnPlaySoundId.Size = new System.Drawing.Size(390, 23);
            this.btnPlaySoundId.TabIndex = 4;
            this.btnPlaySoundId.Text = "-NONE-";
            this.btnPlaySoundId.UseVisualStyleBackColor = true;
            this.btnPlaySoundId.Click += new System.EventHandler(this.btnPlaySoundId_Click);
            // 
            // grpPlaySoundFlags
            // 
            this.grpPlaySoundFlags.Controls.Add(this.chkPlaySoundFlags4);
            this.grpPlaySoundFlags.Controls.Add(this.chkPlaySoundFlags2);
            this.grpPlaySoundFlags.Controls.Add(this.chkPlaySoundFlags1);
            this.grpPlaySoundFlags.Location = new System.Drawing.Point(26, 88);
            this.grpPlaySoundFlags.Name = "grpPlaySoundFlags";
            this.grpPlaySoundFlags.Size = new System.Drawing.Size(447, 48);
            this.grpPlaySoundFlags.TabIndex = 3;
            this.grpPlaySoundFlags.TabStop = false;
            this.grpPlaySoundFlags.Text = "Flags";
            // 
            // chkPlaySoundFlags4
            // 
            this.chkPlaySoundFlags4.AutoSize = true;
            this.chkPlaySoundFlags4.Location = new System.Drawing.Point(244, 21);
            this.chkPlaySoundFlags4.Name = "chkPlaySoundFlags4";
            this.chkPlaySoundFlags4.Size = new System.Drawing.Size(93, 17);
            this.chkPlaySoundFlags4.TabIndex = 2;
            this.chkPlaySoundFlags4.Text = "To All In Zone";
            this.chkPlaySoundFlags4.UseVisualStyleBackColor = true;
            this.chkPlaySoundFlags4.CheckedChanged += new System.EventHandler(this.chkPlaySoundFlags4_CheckedChanged);
            // 
            // chkPlaySoundFlags2
            // 
            this.chkPlaySoundFlags2.AutoSize = true;
            this.chkPlaySoundFlags2.Location = new System.Drawing.Point(114, 21);
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
            this.chkPlaySoundFlags1.Location = new System.Drawing.Point(10, 21);
            this.chkPlaySoundFlags1.Name = "chkPlaySoundFlags1";
            this.chkPlaySoundFlags1.Size = new System.Drawing.Size(97, 17);
            this.chkPlaySoundFlags1.TabIndex = 0;
            this.chkPlaySoundFlags1.Text = "Only To Target";
            this.chkPlaySoundFlags1.UseVisualStyleBackColor = true;
            this.chkPlaySoundFlags1.CheckedChanged += new System.EventHandler(this.chkPlaySoundFlags1_CheckedChanged);
            // 
            // lblPlaySoundId
            // 
            this.lblPlaySoundId.AutoSize = true;
            this.lblPlaySoundId.Location = new System.Drawing.Point(25, 61);
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
            this.frmCommandCreateItem.Location = new System.Drawing.Point(410, 252);
            this.frmCommandCreateItem.Name = "frmCommandCreateItem";
            this.frmCommandCreateItem.Size = new System.Drawing.Size(495, 332);
            this.frmCommandCreateItem.TabIndex = 23;
            this.frmCommandCreateItem.Visible = false;
            // 
            // lblCreateItemAmount
            // 
            this.lblCreateItemAmount.AutoSize = true;
            this.lblCreateItemAmount.Location = new System.Drawing.Point(50, 93);
            this.lblCreateItemAmount.Name = "lblCreateItemAmount";
            this.lblCreateItemAmount.Size = new System.Drawing.Size(46, 13);
            this.lblCreateItemAmount.TabIndex = 4;
            this.lblCreateItemAmount.Text = "Amount:";
            // 
            // txtCreateItemAmount
            // 
            this.txtCreateItemAmount.Location = new System.Drawing.Point(99, 90);
            this.txtCreateItemAmount.Name = "txtCreateItemAmount";
            this.txtCreateItemAmount.Size = new System.Drawing.Size(374, 20);
            this.txtCreateItemAmount.TabIndex = 3;
            this.txtCreateItemAmount.Leave += new System.EventHandler(this.txtCreateItemAmount_Leave);
            // 
            // btnCreateItemId
            // 
            this.btnCreateItemId.Location = new System.Drawing.Point(99, 58);
            this.btnCreateItemId.Name = "btnCreateItemId";
            this.btnCreateItemId.Size = new System.Drawing.Size(374, 23);
            this.btnCreateItemId.TabIndex = 2;
            this.btnCreateItemId.Text = "-NONE-";
            this.btnCreateItemId.UseVisualStyleBackColor = true;
            this.btnCreateItemId.Click += new System.EventHandler(this.btnCreateItemId_Click);
            // 
            // lblCreateItemId
            // 
            this.lblCreateItemId.AutoSize = true;
            this.lblCreateItemId.Location = new System.Drawing.Point(54, 61);
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
            // frmCommandSetEquipment
            // 
            this.frmCommandSetEquipment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetEquipment.Controls.Add(this.lblSetEquipmentRanged);
            this.frmCommandSetEquipment.Controls.Add(this.lblSetEquipmentOffHand);
            this.frmCommandSetEquipment.Controls.Add(this.lblSetEquipmentMainHand);
            this.frmCommandSetEquipment.Controls.Add(this.btnSetEquipmentRanged);
            this.frmCommandSetEquipment.Controls.Add(this.btnSetEquipmentOffHand);
            this.frmCommandSetEquipment.Controls.Add(this.btnSetEquipmentMainHand);
            this.frmCommandSetEquipment.Controls.Add(this.cmbSetEquipmentUseDefault);
            this.frmCommandSetEquipment.Controls.Add(this.lblSetEquipmentUseDefault);
            this.frmCommandSetEquipment.Controls.Add(this.lblSetEquipmentTooltip);
            this.frmCommandSetEquipment.Location = new System.Drawing.Point(410, 252);
            this.frmCommandSetEquipment.Name = "frmCommandSetEquipment";
            this.frmCommandSetEquipment.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetEquipment.TabIndex = 25;
            this.frmCommandSetEquipment.Visible = false;
            // 
            // lblSetEquipmentRanged
            // 
            this.lblSetEquipmentRanged.AutoSize = true;
            this.lblSetEquipmentRanged.Location = new System.Drawing.Point(47, 157);
            this.lblSetEquipmentRanged.Name = "lblSetEquipmentRanged";
            this.lblSetEquipmentRanged.Size = new System.Drawing.Size(48, 13);
            this.lblSetEquipmentRanged.TabIndex = 8;
            this.lblSetEquipmentRanged.Text = "Ranged:";
            // 
            // lblSetEquipmentOffHand
            // 
            this.lblSetEquipmentOffHand.AutoSize = true;
            this.lblSetEquipmentOffHand.Location = new System.Drawing.Point(42, 125);
            this.lblSetEquipmentOffHand.Name = "lblSetEquipmentOffHand";
            this.lblSetEquipmentOffHand.Size = new System.Drawing.Size(53, 13);
            this.lblSetEquipmentOffHand.TabIndex = 7;
            this.lblSetEquipmentOffHand.Text = "Off Hand:";
            // 
            // lblSetEquipmentMainHand
            // 
            this.lblSetEquipmentMainHand.AutoSize = true;
            this.lblSetEquipmentMainHand.Location = new System.Drawing.Point(33, 93);
            this.lblSetEquipmentMainHand.Name = "lblSetEquipmentMainHand";
            this.lblSetEquipmentMainHand.Size = new System.Drawing.Size(62, 13);
            this.lblSetEquipmentMainHand.TabIndex = 6;
            this.lblSetEquipmentMainHand.Text = "Main Hand:";
            // 
            // btnSetEquipmentRanged
            // 
            this.btnSetEquipmentRanged.Location = new System.Drawing.Point(99, 152);
            this.btnSetEquipmentRanged.Name = "btnSetEquipmentRanged";
            this.btnSetEquipmentRanged.Size = new System.Drawing.Size(374, 23);
            this.btnSetEquipmentRanged.TabIndex = 5;
            this.btnSetEquipmentRanged.Text = "-NONE-";
            this.btnSetEquipmentRanged.UseVisualStyleBackColor = true;
            this.btnSetEquipmentRanged.Click += new System.EventHandler(this.btnSetEquipmentRanged_Click);
            // 
            // btnSetEquipmentOffHand
            // 
            this.btnSetEquipmentOffHand.Location = new System.Drawing.Point(99, 120);
            this.btnSetEquipmentOffHand.Name = "btnSetEquipmentOffHand";
            this.btnSetEquipmentOffHand.Size = new System.Drawing.Size(374, 23);
            this.btnSetEquipmentOffHand.TabIndex = 4;
            this.btnSetEquipmentOffHand.Text = "-NONE-";
            this.btnSetEquipmentOffHand.UseVisualStyleBackColor = true;
            this.btnSetEquipmentOffHand.Click += new System.EventHandler(this.btnSetEquipmentOffHand_Click);
            // 
            // btnSetEquipmentMainHand
            // 
            this.btnSetEquipmentMainHand.Location = new System.Drawing.Point(99, 88);
            this.btnSetEquipmentMainHand.Name = "btnSetEquipmentMainHand";
            this.btnSetEquipmentMainHand.Size = new System.Drawing.Size(374, 23);
            this.btnSetEquipmentMainHand.TabIndex = 3;
            this.btnSetEquipmentMainHand.Text = "-NONE-";
            this.btnSetEquipmentMainHand.UseVisualStyleBackColor = true;
            this.btnSetEquipmentMainHand.Click += new System.EventHandler(this.btnSetEquipmentMainHand_Click);
            // 
            // cmbSetEquipmentUseDefault
            // 
            this.cmbSetEquipmentUseDefault.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetEquipmentUseDefault.FormattingEnabled = true;
            this.cmbSetEquipmentUseDefault.Items.AddRange(new object[] {
            "Specified Items",
            "Default Equipment"});
            this.cmbSetEquipmentUseDefault.Location = new System.Drawing.Point(99, 58);
            this.cmbSetEquipmentUseDefault.Name = "cmbSetEquipmentUseDefault";
            this.cmbSetEquipmentUseDefault.Size = new System.Drawing.Size(374, 21);
            this.cmbSetEquipmentUseDefault.TabIndex = 2;
            this.cmbSetEquipmentUseDefault.SelectedIndexChanged += new System.EventHandler(this.cmbSetEquipmentUseDefault_SelectedIndexChanged);
            // 
            // lblSetEquipmentUseDefault
            // 
            this.lblSetEquipmentUseDefault.AutoSize = true;
            this.lblSetEquipmentUseDefault.Location = new System.Drawing.Point(60, 61);
            this.lblSetEquipmentUseDefault.Name = "lblSetEquipmentUseDefault";
            this.lblSetEquipmentUseDefault.Size = new System.Drawing.Size(35, 13);
            this.lblSetEquipmentUseDefault.TabIndex = 1;
            this.lblSetEquipmentUseDefault.Text = "Items:";
            // 
            // lblSetEquipmentTooltip
            // 
            this.lblSetEquipmentTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetEquipmentTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetEquipmentTooltip.Name = "lblSetEquipmentTooltip";
            this.lblSetEquipmentTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetEquipmentTooltip.TabIndex = 0;
            this.lblSetEquipmentTooltip.Text = "Changes the equipped item in the specified slot. This is purely visual.";
            // 
            // frmCommandSetMovement
            // 
            this.frmCommandSetMovement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetMovement.Controls.Add(this.cmbSetMovementClearMotionMaster);
            this.frmCommandSetMovement.Controls.Add(this.lblSetMovementClearMotionMaster);
            this.frmCommandSetMovement.Controls.Add(this.lblSetMovementAngle);
            this.frmCommandSetMovement.Controls.Add(this.txtSetMovementAngle);
            this.frmCommandSetMovement.Controls.Add(this.txtSetMovementDistance);
            this.frmCommandSetMovement.Controls.Add(this.txtSetMovementIntParam);
            this.frmCommandSetMovement.Controls.Add(this.cmbSetMovementBoolParam);
            this.frmCommandSetMovement.Controls.Add(this.lblSetMovementDistance);
            this.frmCommandSetMovement.Controls.Add(this.lblSetMovementIntParam);
            this.frmCommandSetMovement.Controls.Add(this.lblSetMovementBoolParam);
            this.frmCommandSetMovement.Controls.Add(this.cmbSetMovementType);
            this.frmCommandSetMovement.Controls.Add(this.lblSetMovementType);
            this.frmCommandSetMovement.Controls.Add(this.lblSetMovementTooltip);
            this.frmCommandSetMovement.Location = new System.Drawing.Point(410, 252);
            this.frmCommandSetMovement.Name = "frmCommandSetMovement";
            this.frmCommandSetMovement.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetMovement.TabIndex = 26;
            this.frmCommandSetMovement.Visible = false;
            // 
            // cmbSetMovementClearMotionMaster
            // 
            this.cmbSetMovementClearMotionMaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetMovementClearMotionMaster.FormattingEnabled = true;
            this.cmbSetMovementClearMotionMaster.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbSetMovementClearMotionMaster.Location = new System.Drawing.Point(99, 89);
            this.cmbSetMovementClearMotionMaster.Name = "cmbSetMovementClearMotionMaster";
            this.cmbSetMovementClearMotionMaster.Size = new System.Drawing.Size(374, 21);
            this.cmbSetMovementClearMotionMaster.TabIndex = 16;
            this.cmbSetMovementClearMotionMaster.SelectedIndexChanged += new System.EventHandler(this.cmbSetMovementClearMotionMaster_SelectedIndexChanged);
            // 
            // lblSetMovementClearMotionMaster
            // 
            this.lblSetMovementClearMotionMaster.AutoSize = true;
            this.lblSetMovementClearMotionMaster.Location = new System.Drawing.Point(40, 92);
            this.lblSetMovementClearMotionMaster.Name = "lblSetMovementClearMotionMaster";
            this.lblSetMovementClearMotionMaster.Size = new System.Drawing.Size(55, 13);
            this.lblSetMovementClearMotionMaster.TabIndex = 15;
            this.lblSetMovementClearMotionMaster.Text = "Clear MM:";
            // 
            // lblSetMovementAngle
            // 
            this.lblSetMovementAngle.AutoSize = true;
            this.lblSetMovementAngle.Location = new System.Drawing.Point(58, 213);
            this.lblSetMovementAngle.Name = "lblSetMovementAngle";
            this.lblSetMovementAngle.Size = new System.Drawing.Size(37, 13);
            this.lblSetMovementAngle.TabIndex = 13;
            this.lblSetMovementAngle.Text = "Angle:";
            // 
            // txtSetMovementAngle
            // 
            this.txtSetMovementAngle.Location = new System.Drawing.Point(99, 211);
            this.txtSetMovementAngle.Name = "txtSetMovementAngle";
            this.txtSetMovementAngle.Size = new System.Drawing.Size(374, 20);
            this.txtSetMovementAngle.TabIndex = 12;
            this.txtSetMovementAngle.Leave += new System.EventHandler(this.txtSetMovementAngle_Leave);
            // 
            // txtSetMovementDistance
            // 
            this.txtSetMovementDistance.Location = new System.Drawing.Point(99, 181);
            this.txtSetMovementDistance.Name = "txtSetMovementDistance";
            this.txtSetMovementDistance.Size = new System.Drawing.Size(374, 20);
            this.txtSetMovementDistance.TabIndex = 11;
            this.txtSetMovementDistance.Leave += new System.EventHandler(this.txtSetMovementDistance_Leave);
            // 
            // txtSetMovementIntParam
            // 
            this.txtSetMovementIntParam.Location = new System.Drawing.Point(99, 151);
            this.txtSetMovementIntParam.Name = "txtSetMovementIntParam";
            this.txtSetMovementIntParam.Size = new System.Drawing.Size(374, 20);
            this.txtSetMovementIntParam.TabIndex = 10;
            this.txtSetMovementIntParam.Leave += new System.EventHandler(this.txtSetMovementIntParam_Leave);
            // 
            // cmbSetMovementBoolParam
            // 
            this.cmbSetMovementBoolParam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetMovementBoolParam.FormattingEnabled = true;
            this.cmbSetMovementBoolParam.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbSetMovementBoolParam.Location = new System.Drawing.Point(99, 120);
            this.cmbSetMovementBoolParam.Name = "cmbSetMovementBoolParam";
            this.cmbSetMovementBoolParam.Size = new System.Drawing.Size(374, 21);
            this.cmbSetMovementBoolParam.TabIndex = 9;
            this.cmbSetMovementBoolParam.SelectedIndexChanged += new System.EventHandler(this.cmbSetMovementBoolParam_SelectedIndexChanged);
            // 
            // lblSetMovementDistance
            // 
            this.lblSetMovementDistance.AutoSize = true;
            this.lblSetMovementDistance.Location = new System.Drawing.Point(43, 183);
            this.lblSetMovementDistance.Name = "lblSetMovementDistance";
            this.lblSetMovementDistance.Size = new System.Drawing.Size(52, 13);
            this.lblSetMovementDistance.TabIndex = 8;
            this.lblSetMovementDistance.Text = "Distance:";
            // 
            // lblSetMovementIntParam
            // 
            this.lblSetMovementIntParam.AutoSize = true;
            this.lblSetMovementIntParam.Location = new System.Drawing.Point(40, 153);
            this.lblSetMovementIntParam.Name = "lblSetMovementIntParam";
            this.lblSetMovementIntParam.Size = new System.Drawing.Size(55, 13);
            this.lblSetMovementIntParam.TabIndex = 7;
            this.lblSetMovementIntParam.Text = "Int Param:";
            // 
            // lblSetMovementBoolParam
            // 
            this.lblSetMovementBoolParam.AutoSize = true;
            this.lblSetMovementBoolParam.Location = new System.Drawing.Point(31, 123);
            this.lblSetMovementBoolParam.Name = "lblSetMovementBoolParam";
            this.lblSetMovementBoolParam.Size = new System.Drawing.Size(64, 13);
            this.lblSetMovementBoolParam.TabIndex = 6;
            this.lblSetMovementBoolParam.Text = "Bool Param:";
            // 
            // cmbSetMovementType
            // 
            this.cmbSetMovementType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetMovementType.FormattingEnabled = true;
            this.cmbSetMovementType.Items.AddRange(new object[] {
            "Specified Items",
            "Default Equipment"});
            this.cmbSetMovementType.Location = new System.Drawing.Point(99, 58);
            this.cmbSetMovementType.Name = "cmbSetMovementType";
            this.cmbSetMovementType.Size = new System.Drawing.Size(374, 21);
            this.cmbSetMovementType.TabIndex = 2;
            this.cmbSetMovementType.SelectedIndexChanged += new System.EventHandler(this.cmbSetMovementType_SelectedIndexChanged);
            // 
            // lblSetMovementType
            // 
            this.lblSetMovementType.AutoSize = true;
            this.lblSetMovementType.Location = new System.Drawing.Point(26, 61);
            this.lblSetMovementType.Name = "lblSetMovementType";
            this.lblSetMovementType.Size = new System.Drawing.Size(69, 13);
            this.lblSetMovementType.TabIndex = 1;
            this.lblSetMovementType.Text = "Motion Type:";
            // 
            // lblSetMovementTooltip
            // 
            this.lblSetMovementTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetMovementTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetMovementTooltip.Name = "lblSetMovementTooltip";
            this.lblSetMovementTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetMovementTooltip.TabIndex = 0;
            this.lblSetMovementTooltip.Text = "Changes the current movement type used by the source Creature.";
            // 
            // frmCommandActiveObject
            // 
            this.frmCommandActiveObject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandActiveObject.Controls.Add(this.cmbActiveObjectSetActive);
            this.frmCommandActiveObject.Controls.Add(this.lblActiveObjectSetActive);
            this.frmCommandActiveObject.Controls.Add(this.lblActiveObjectTooltip);
            this.frmCommandActiveObject.Location = new System.Drawing.Point(410, 252);
            this.frmCommandActiveObject.Name = "frmCommandActiveObject";
            this.frmCommandActiveObject.Size = new System.Drawing.Size(495, 332);
            this.frmCommandActiveObject.TabIndex = 27;
            this.frmCommandActiveObject.Visible = false;
            // 
            // cmbActiveObjectSetActive
            // 
            this.cmbActiveObjectSetActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActiveObjectSetActive.FormattingEnabled = true;
            this.cmbActiveObjectSetActive.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.cmbActiveObjectSetActive.Location = new System.Drawing.Point(99, 58);
            this.cmbActiveObjectSetActive.Name = "cmbActiveObjectSetActive";
            this.cmbActiveObjectSetActive.Size = new System.Drawing.Size(374, 21);
            this.cmbActiveObjectSetActive.TabIndex = 2;
            this.cmbActiveObjectSetActive.SelectedIndexChanged += new System.EventHandler(this.cmbActiveObjectSetActive_SelectedIndexChanged);
            // 
            // lblActiveObjectSetActive
            // 
            this.lblActiveObjectSetActive.AutoSize = true;
            this.lblActiveObjectSetActive.Location = new System.Drawing.Point(58, 61);
            this.lblActiveObjectSetActive.Name = "lblActiveObjectSetActive";
            this.lblActiveObjectSetActive.Size = new System.Drawing.Size(35, 13);
            this.lblActiveObjectSetActive.TabIndex = 1;
            this.lblActiveObjectSetActive.Text = "State:";
            // 
            // lblActiveObjectTooltip
            // 
            this.lblActiveObjectTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblActiveObjectTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblActiveObjectTooltip.Name = "lblActiveObjectTooltip";
            this.lblActiveObjectTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblActiveObjectTooltip.TabIndex = 0;
            this.lblActiveObjectTooltip.Text = "Makes the source WorldObject into an Active Object. That means its always updated" +
    ", even if there are no players around.";
            // 
            // frmCommandSetFaction
            // 
            this.frmCommandSetFaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetFaction.Controls.Add(this.btnSetFactionId);
            this.frmCommandSetFaction.Controls.Add(this.grpSetFactionFlags);
            this.frmCommandSetFaction.Controls.Add(this.lblSetFactionId);
            this.frmCommandSetFaction.Controls.Add(this.lblSetFactionTooltip);
            this.frmCommandSetFaction.Location = new System.Drawing.Point(410, 252);
            this.frmCommandSetFaction.Name = "frmCommandSetFaction";
            this.frmCommandSetFaction.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetFaction.TabIndex = 28;
            this.frmCommandSetFaction.Visible = false;
            // 
            // btnSetFactionId
            // 
            this.btnSetFactionId.Location = new System.Drawing.Point(83, 57);
            this.btnSetFactionId.Name = "btnSetFactionId";
            this.btnSetFactionId.Size = new System.Drawing.Size(390, 23);
            this.btnSetFactionId.TabIndex = 5;
            this.btnSetFactionId.Text = "-NONE-";
            this.btnSetFactionId.UseVisualStyleBackColor = true;
            this.btnSetFactionId.Click += new System.EventHandler(this.btnSetFactionId_Click);
            // 
            // grpSetFactionFlags
            // 
            this.grpSetFactionFlags.Controls.Add(this.chkSetFactionFlag4);
            this.grpSetFactionFlags.Controls.Add(this.chkSetFactionFlag2);
            this.grpSetFactionFlags.Controls.Add(this.chkSetFactionFlag1);
            this.grpSetFactionFlags.Location = new System.Drawing.Point(26, 88);
            this.grpSetFactionFlags.Name = "grpSetFactionFlags";
            this.grpSetFactionFlags.Size = new System.Drawing.Size(447, 48);
            this.grpSetFactionFlags.TabIndex = 3;
            this.grpSetFactionFlags.TabStop = false;
            this.grpSetFactionFlags.Text = "Restore Faction On";
            // 
            // chkSetFactionFlag4
            // 
            this.chkSetFactionFlag4.AutoSize = true;
            this.chkSetFactionFlag4.Location = new System.Drawing.Point(186, 21);
            this.chkSetFactionFlag4.Name = "chkSetFactionFlag4";
            this.chkSetFactionFlag4.Size = new System.Drawing.Size(101, 17);
            this.chkSetFactionFlag4.TabIndex = 2;
            this.chkSetFactionFlag4.Text = "Reached Home";
            this.chkSetFactionFlag4.UseVisualStyleBackColor = true;
            this.chkSetFactionFlag4.CheckedChanged += new System.EventHandler(this.chkSetFactionFlag4_CheckedChanged);
            // 
            // chkSetFactionFlag2
            // 
            this.chkSetFactionFlag2.AutoSize = true;
            this.chkSetFactionFlag2.Location = new System.Drawing.Point(90, 21);
            this.chkSetFactionFlag2.Name = "chkSetFactionFlag2";
            this.chkSetFactionFlag2.Size = new System.Drawing.Size(87, 17);
            this.chkSetFactionFlag2.TabIndex = 1;
            this.chkSetFactionFlag2.Text = "Combat Stop";
            this.chkSetFactionFlag2.UseVisualStyleBackColor = true;
            this.chkSetFactionFlag2.CheckedChanged += new System.EventHandler(this.chkSetFactionFlag2_CheckedChanged);
            // 
            // chkSetFactionFlag1
            // 
            this.chkSetFactionFlag1.AutoSize = true;
            this.chkSetFactionFlag1.Location = new System.Drawing.Point(10, 21);
            this.chkSetFactionFlag1.Name = "chkSetFactionFlag1";
            this.chkSetFactionFlag1.Size = new System.Drawing.Size(71, 17);
            this.chkSetFactionFlag1.TabIndex = 0;
            this.chkSetFactionFlag1.Text = "Respawn";
            this.chkSetFactionFlag1.UseVisualStyleBackColor = true;
            this.chkSetFactionFlag1.CheckedChanged += new System.EventHandler(this.chkSetFactionFlag1_CheckedChanged);
            // 
            // lblSetFactionId
            // 
            this.lblSetFactionId.AutoSize = true;
            this.lblSetFactionId.Location = new System.Drawing.Point(24, 61);
            this.lblSetFactionId.Name = "lblSetFactionId";
            this.lblSetFactionId.Size = new System.Drawing.Size(57, 13);
            this.lblSetFactionId.TabIndex = 1;
            this.lblSetFactionId.Text = "Faction Id:";
            // 
            // lblSetFactionTooltip
            // 
            this.lblSetFactionTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetFactionTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetFactionTooltip.Name = "lblSetFactionTooltip";
            this.lblSetFactionTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetFactionTooltip.TabIndex = 0;
            this.lblSetFactionTooltip.Text = "Temporarily changes the source Creature\'s faction to the one specified. Set flags" +
    " to specify when the original faction will be restored.";
            // 
            // frmCommandMorphOrMount
            // 
            this.frmCommandMorphOrMount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandMorphOrMount.Controls.Add(this.cmbMorphOrMountPermanent);
            this.frmCommandMorphOrMount.Controls.Add(this.lblMorphOrMountPermanent);
            this.frmCommandMorphOrMount.Controls.Add(this.cmbMorphOrMountType);
            this.frmCommandMorphOrMount.Controls.Add(this.lblMorphOrMountId);
            this.frmCommandMorphOrMount.Controls.Add(this.lblMorphOrMountType);
            this.frmCommandMorphOrMount.Controls.Add(this.btnMorphOrMountId);
            this.frmCommandMorphOrMount.Controls.Add(this.lblMorphOrMountTooltip);
            this.frmCommandMorphOrMount.Location = new System.Drawing.Point(410, 252);
            this.frmCommandMorphOrMount.Name = "frmCommandMorphOrMount";
            this.frmCommandMorphOrMount.Size = new System.Drawing.Size(495, 332);
            this.frmCommandMorphOrMount.TabIndex = 29;
            this.frmCommandMorphOrMount.Visible = false;
            // 
            // cmbMorphOrMountPermanent
            // 
            this.cmbMorphOrMountPermanent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMorphOrMountPermanent.FormattingEnabled = true;
            this.cmbMorphOrMountPermanent.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbMorphOrMountPermanent.Location = new System.Drawing.Point(99, 120);
            this.cmbMorphOrMountPermanent.Name = "cmbMorphOrMountPermanent";
            this.cmbMorphOrMountPermanent.Size = new System.Drawing.Size(374, 21);
            this.cmbMorphOrMountPermanent.TabIndex = 7;
            this.cmbMorphOrMountPermanent.SelectedIndexChanged += new System.EventHandler(this.cmbMorphOrMountPermanent_SelectedIndexChanged);
            // 
            // lblMorphOrMountPermanent
            // 
            this.lblMorphOrMountPermanent.AutoSize = true;
            this.lblMorphOrMountPermanent.Location = new System.Drawing.Point(35, 123);
            this.lblMorphOrMountPermanent.Name = "lblMorphOrMountPermanent";
            this.lblMorphOrMountPermanent.Size = new System.Drawing.Size(61, 13);
            this.lblMorphOrMountPermanent.TabIndex = 6;
            this.lblMorphOrMountPermanent.Text = "Permanent:";
            // 
            // cmbMorphOrMountType
            // 
            this.cmbMorphOrMountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMorphOrMountType.FormattingEnabled = true;
            this.cmbMorphOrMountType.Items.AddRange(new object[] {
            "Creature Id",
            "Display Id"});
            this.cmbMorphOrMountType.Location = new System.Drawing.Point(99, 90);
            this.cmbMorphOrMountType.Name = "cmbMorphOrMountType";
            this.cmbMorphOrMountType.Size = new System.Drawing.Size(374, 21);
            this.cmbMorphOrMountType.TabIndex = 5;
            this.cmbMorphOrMountType.SelectedIndexChanged += new System.EventHandler(this.cmbMorphOrMountType_SelectedIndexChanged);
            // 
            // lblMorphOrMountId
            // 
            this.lblMorphOrMountId.AutoSize = true;
            this.lblMorphOrMountId.Location = new System.Drawing.Point(77, 61);
            this.lblMorphOrMountId.Name = "lblMorphOrMountId";
            this.lblMorphOrMountId.Size = new System.Drawing.Size(19, 13);
            this.lblMorphOrMountId.TabIndex = 4;
            this.lblMorphOrMountId.Text = "Id:";
            // 
            // lblMorphOrMountType
            // 
            this.lblMorphOrMountType.AutoSize = true;
            this.lblMorphOrMountType.Location = new System.Drawing.Point(62, 93);
            this.lblMorphOrMountType.Name = "lblMorphOrMountType";
            this.lblMorphOrMountType.Size = new System.Drawing.Size(34, 13);
            this.lblMorphOrMountType.TabIndex = 3;
            this.lblMorphOrMountType.Text = "Type:";
            // 
            // btnMorphOrMountId
            // 
            this.btnMorphOrMountId.Location = new System.Drawing.Point(99, 58);
            this.btnMorphOrMountId.Name = "btnMorphOrMountId";
            this.btnMorphOrMountId.Size = new System.Drawing.Size(374, 23);
            this.btnMorphOrMountId.TabIndex = 1;
            this.btnMorphOrMountId.Text = "-NONE-";
            this.btnMorphOrMountId.UseVisualStyleBackColor = true;
            this.btnMorphOrMountId.Click += new System.EventHandler(this.btnMorphOrMountId_Click);
            // 
            // lblMorphOrMountTooltip
            // 
            this.lblMorphOrMountTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMorphOrMountTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblMorphOrMountTooltip.Name = "lblMorphOrMountTooltip";
            this.lblMorphOrMountTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblMorphOrMountTooltip.TabIndex = 0;
            this.lblMorphOrMountTooltip.Text = "Changes the Creature source\'s current display id.";
            // 
            // frmCommandSetRun
            // 
            this.frmCommandSetRun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetRun.Controls.Add(this.cmbSetRunMode);
            this.frmCommandSetRun.Controls.Add(this.lblSetRunMode);
            this.frmCommandSetRun.Controls.Add(this.lblSetRunTooltip);
            this.frmCommandSetRun.Location = new System.Drawing.Point(410, 252);
            this.frmCommandSetRun.Name = "frmCommandSetRun";
            this.frmCommandSetRun.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetRun.TabIndex = 30;
            this.frmCommandSetRun.Visible = false;
            // 
            // cmbSetRunMode
            // 
            this.cmbSetRunMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetRunMode.FormattingEnabled = true;
            this.cmbSetRunMode.Items.AddRange(new object[] {
            "Walking",
            "Running"});
            this.cmbSetRunMode.Location = new System.Drawing.Point(99, 58);
            this.cmbSetRunMode.Name = "cmbSetRunMode";
            this.cmbSetRunMode.Size = new System.Drawing.Size(374, 21);
            this.cmbSetRunMode.TabIndex = 2;
            this.cmbSetRunMode.SelectedIndexChanged += new System.EventHandler(this.cmbSetRunMode_SelectedIndexChanged);
            // 
            // lblSetRunMode
            // 
            this.lblSetRunMode.AutoSize = true;
            this.lblSetRunMode.Location = new System.Drawing.Point(31, 61);
            this.lblSetRunMode.Name = "lblSetRunMode";
            this.lblSetRunMode.Size = new System.Drawing.Size(65, 13);
            this.lblSetRunMode.TabIndex = 1;
            this.lblSetRunMode.Text = "Walk Mode:";
            // 
            // lblSetRunTooltip
            // 
            this.lblSetRunTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetRunTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetRunTooltip.Name = "lblSetRunTooltip";
            this.lblSetRunTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetRunTooltip.TabIndex = 0;
            this.lblSetRunTooltip.Text = "Changes the source Creature\'s walk mode.";
            // 
            // frmCommandModifyFlags
            // 
            this.frmCommandModifyFlags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandModifyFlags.Controls.Add(this.btnModifyFlagsFlags);
            this.frmCommandModifyFlags.Controls.Add(this.lblModifyFlagsFlags);
            this.frmCommandModifyFlags.Controls.Add(this.cmbModifyFlagsMode);
            this.frmCommandModifyFlags.Controls.Add(this.lblModifyFlagsMode);
            this.frmCommandModifyFlags.Controls.Add(this.cmbModifyFlagsFieldId);
            this.frmCommandModifyFlags.Controls.Add(this.lblModifyFlagsField);
            this.frmCommandModifyFlags.Controls.Add(this.lblModifyFlagsTooltip);
            this.frmCommandModifyFlags.Location = new System.Drawing.Point(410, 252);
            this.frmCommandModifyFlags.Name = "frmCommandModifyFlags";
            this.frmCommandModifyFlags.Size = new System.Drawing.Size(495, 332);
            this.frmCommandModifyFlags.TabIndex = 31;
            this.frmCommandModifyFlags.Visible = false;
            // 
            // btnModifyFlagsFlags
            // 
            this.btnModifyFlagsFlags.Location = new System.Drawing.Point(72, 87);
            this.btnModifyFlagsFlags.Name = "btnModifyFlagsFlags";
            this.btnModifyFlagsFlags.Size = new System.Drawing.Size(401, 23);
            this.btnModifyFlagsFlags.TabIndex = 7;
            this.btnModifyFlagsFlags.Text = "-NONE-";
            this.btnModifyFlagsFlags.UseVisualStyleBackColor = true;
            this.btnModifyFlagsFlags.Click += new System.EventHandler(this.btnModifyFlagsFlags_Click);
            // 
            // lblModifyFlagsFlags
            // 
            this.lblModifyFlagsFlags.AutoSize = true;
            this.lblModifyFlagsFlags.Location = new System.Drawing.Point(35, 90);
            this.lblModifyFlagsFlags.Name = "lblModifyFlagsFlags";
            this.lblModifyFlagsFlags.Size = new System.Drawing.Size(35, 13);
            this.lblModifyFlagsFlags.TabIndex = 6;
            this.lblModifyFlagsFlags.Text = "Flags:";
            // 
            // cmbModifyFlagsMode
            // 
            this.cmbModifyFlagsMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModifyFlagsMode.FormattingEnabled = true;
            this.cmbModifyFlagsMode.Items.AddRange(new object[] {
            "Toggle Flags",
            "Add Flags",
            "Remove Flags"});
            this.cmbModifyFlagsMode.Location = new System.Drawing.Point(303, 55);
            this.cmbModifyFlagsMode.Name = "cmbModifyFlagsMode";
            this.cmbModifyFlagsMode.Size = new System.Drawing.Size(169, 21);
            this.cmbModifyFlagsMode.TabIndex = 4;
            this.cmbModifyFlagsMode.SelectedIndexChanged += new System.EventHandler(this.cmbModifyFlagsMode_SelectedIndexChanged);
            // 
            // lblModifyFlagsMode
            // 
            this.lblModifyFlagsMode.AutoSize = true;
            this.lblModifyFlagsMode.Location = new System.Drawing.Point(262, 58);
            this.lblModifyFlagsMode.Name = "lblModifyFlagsMode";
            this.lblModifyFlagsMode.Size = new System.Drawing.Size(37, 13);
            this.lblModifyFlagsMode.TabIndex = 3;
            this.lblModifyFlagsMode.Text = "Mode:";
            // 
            // cmbModifyFlagsFieldId
            // 
            this.cmbModifyFlagsFieldId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModifyFlagsFieldId.FormattingEnabled = true;
            this.cmbModifyFlagsFieldId.Location = new System.Drawing.Point(72, 55);
            this.cmbModifyFlagsFieldId.Name = "cmbModifyFlagsFieldId";
            this.cmbModifyFlagsFieldId.Size = new System.Drawing.Size(184, 21);
            this.cmbModifyFlagsFieldId.TabIndex = 2;
            this.cmbModifyFlagsFieldId.SelectedIndexChanged += new System.EventHandler(this.cmbModifyFlagsFieldId_SelectedIndexChanged);
            // 
            // lblModifyFlagsField
            // 
            this.lblModifyFlagsField.AutoSize = true;
            this.lblModifyFlagsField.Location = new System.Drawing.Point(26, 58);
            this.lblModifyFlagsField.Name = "lblModifyFlagsField";
            this.lblModifyFlagsField.Size = new System.Drawing.Size(44, 13);
            this.lblModifyFlagsField.TabIndex = 1;
            this.lblModifyFlagsField.Text = "Field Id:";
            // 
            // lblModifyFlagsTooltip
            // 
            this.lblModifyFlagsTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblModifyFlagsTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblModifyFlagsTooltip.Name = "lblModifyFlagsTooltip";
            this.lblModifyFlagsTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblModifyFlagsTooltip.TabIndex = 0;
            this.lblModifyFlagsTooltip.Text = "Toggles on the specified flags on the chosen field. Can be used on any object, bu" +
    "t the fields are different based on the type.";
            // 
            // frmCommandInterruptCasts
            // 
            this.frmCommandInterruptCasts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandInterruptCasts.Controls.Add(this.cmbInterruptCastsWithDelayed);
            this.frmCommandInterruptCasts.Controls.Add(this.lblInterruptCastsSpellId);
            this.frmCommandInterruptCasts.Controls.Add(this.lblInterruptCastsWithDelayed);
            this.frmCommandInterruptCasts.Controls.Add(this.btnInterruptCastsSpellId);
            this.frmCommandInterruptCasts.Controls.Add(this.lblInterruptCastsTooltip);
            this.frmCommandInterruptCasts.Location = new System.Drawing.Point(410, 252);
            this.frmCommandInterruptCasts.Name = "frmCommandInterruptCasts";
            this.frmCommandInterruptCasts.Size = new System.Drawing.Size(495, 332);
            this.frmCommandInterruptCasts.TabIndex = 32;
            this.frmCommandInterruptCasts.Visible = false;
            // 
            // cmbInterruptCastsWithDelayed
            // 
            this.cmbInterruptCastsWithDelayed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInterruptCastsWithDelayed.FormattingEnabled = true;
            this.cmbInterruptCastsWithDelayed.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbInterruptCastsWithDelayed.Location = new System.Drawing.Point(99, 90);
            this.cmbInterruptCastsWithDelayed.Name = "cmbInterruptCastsWithDelayed";
            this.cmbInterruptCastsWithDelayed.Size = new System.Drawing.Size(374, 21);
            this.cmbInterruptCastsWithDelayed.TabIndex = 5;
            this.cmbInterruptCastsWithDelayed.SelectedIndexChanged += new System.EventHandler(this.cmbInterruptCastsWithDelayed_SelectedIndexChanged);
            // 
            // lblInterruptCastsSpellId
            // 
            this.lblInterruptCastsSpellId.AutoSize = true;
            this.lblInterruptCastsSpellId.Location = new System.Drawing.Point(51, 61);
            this.lblInterruptCastsSpellId.Name = "lblInterruptCastsSpellId";
            this.lblInterruptCastsSpellId.Size = new System.Drawing.Size(45, 13);
            this.lblInterruptCastsSpellId.TabIndex = 4;
            this.lblInterruptCastsSpellId.Text = "Spell Id:";
            // 
            // lblInterruptCastsWithDelayed
            // 
            this.lblInterruptCastsWithDelayed.AutoSize = true;
            this.lblInterruptCastsWithDelayed.Location = new System.Drawing.Point(24, 93);
            this.lblInterruptCastsWithDelayed.Name = "lblInterruptCastsWithDelayed";
            this.lblInterruptCastsWithDelayed.Size = new System.Drawing.Size(72, 13);
            this.lblInterruptCastsWithDelayed.TabIndex = 3;
            this.lblInterruptCastsWithDelayed.Text = "With delayed:";
            // 
            // btnInterruptCastsSpellId
            // 
            this.btnInterruptCastsSpellId.Location = new System.Drawing.Point(99, 58);
            this.btnInterruptCastsSpellId.Name = "btnInterruptCastsSpellId";
            this.btnInterruptCastsSpellId.Size = new System.Drawing.Size(374, 23);
            this.btnInterruptCastsSpellId.TabIndex = 1;
            this.btnInterruptCastsSpellId.Text = "-NONE-";
            this.btnInterruptCastsSpellId.UseVisualStyleBackColor = true;
            this.btnInterruptCastsSpellId.Click += new System.EventHandler(this.btnInterruptCastsSpellId_Click);
            // 
            // lblInterruptCastsTooltip
            // 
            this.lblInterruptCastsTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInterruptCastsTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblInterruptCastsTooltip.Name = "lblInterruptCastsTooltip";
            this.lblInterruptCastsTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblInterruptCastsTooltip.TabIndex = 0;
            this.lblInterruptCastsTooltip.Text = "Interrupts the current spell cast. If a spell Id is provided, only that spell wil" +
    "l be interrupted.";
            // 
            // frmCommandUpdateEntry
            // 
            this.frmCommandUpdateEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandUpdateEntry.Controls.Add(this.lblUpdateEntryCreatureId);
            this.frmCommandUpdateEntry.Controls.Add(this.btnUpdateEntryCreatureId);
            this.frmCommandUpdateEntry.Controls.Add(this.lblUpdateEntryTooltip);
            this.frmCommandUpdateEntry.Location = new System.Drawing.Point(410, 252);
            this.frmCommandUpdateEntry.Name = "frmCommandUpdateEntry";
            this.frmCommandUpdateEntry.Size = new System.Drawing.Size(495, 332);
            this.frmCommandUpdateEntry.TabIndex = 33;
            this.frmCommandUpdateEntry.Visible = false;
            // 
            // lblUpdateEntryCreatureId
            // 
            this.lblUpdateEntryCreatureId.AutoSize = true;
            this.lblUpdateEntryCreatureId.Location = new System.Drawing.Point(34, 61);
            this.lblUpdateEntryCreatureId.Name = "lblUpdateEntryCreatureId";
            this.lblUpdateEntryCreatureId.Size = new System.Drawing.Size(62, 13);
            this.lblUpdateEntryCreatureId.TabIndex = 4;
            this.lblUpdateEntryCreatureId.Text = "Creature Id:";
            // 
            // btnUpdateEntryCreatureId
            // 
            this.btnUpdateEntryCreatureId.Location = new System.Drawing.Point(99, 58);
            this.btnUpdateEntryCreatureId.Name = "btnUpdateEntryCreatureId";
            this.btnUpdateEntryCreatureId.Size = new System.Drawing.Size(374, 23);
            this.btnUpdateEntryCreatureId.TabIndex = 1;
            this.btnUpdateEntryCreatureId.Text = "-NONE-";
            this.btnUpdateEntryCreatureId.UseVisualStyleBackColor = true;
            this.btnUpdateEntryCreatureId.Click += new System.EventHandler(this.btnUpdateEntryCreatureId_Click);
            // 
            // lblUpdateEntryTooltip
            // 
            this.lblUpdateEntryTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUpdateEntryTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblUpdateEntryTooltip.Name = "lblUpdateEntryTooltip";
            this.lblUpdateEntryTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblUpdateEntryTooltip.TabIndex = 0;
            this.lblUpdateEntryTooltip.Text = "Temporarily changes the source Creature\'s entry, but preserves the same AI. The t" +
    "eam setting determines which display Id will be used if there is a different one" +
    " for each faction.";
            // 
            // frmCommandSetStandState
            // 
            this.frmCommandSetStandState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetStandState.Controls.Add(this.cmbSetStandState);
            this.frmCommandSetStandState.Controls.Add(this.lblSetStandState);
            this.frmCommandSetStandState.Controls.Add(this.lblSetStandStateTooltip);
            this.frmCommandSetStandState.Location = new System.Drawing.Point(410, 252);
            this.frmCommandSetStandState.Name = "frmCommandSetStandState";
            this.frmCommandSetStandState.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetStandState.TabIndex = 34;
            this.frmCommandSetStandState.Visible = false;
            // 
            // cmbSetStandState
            // 
            this.cmbSetStandState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetStandState.FormattingEnabled = true;
            this.cmbSetStandState.Items.AddRange(new object[] {
            "UNIT_STAND_STATE_STAND",
            "UNIT_STAND_STATE_SIT",
            "UNIT_STAND_STATE_SIT_CHAIR",
            "UNIT_STAND_STATE_SLEEP",
            "UNIT_STAND_STATE_SIT_LOW_CHAIR",
            "UNIT_STAND_STATE_SIT_MEDIUM_CHAIR",
            "UNIT_STAND_STATE_SIT_HIGH_CHAIR",
            "UNIT_STAND_STATE_DEAD",
            "UNIT_STAND_STATE_KNEEL"});
            this.cmbSetStandState.Location = new System.Drawing.Point(99, 58);
            this.cmbSetStandState.Name = "cmbSetStandState";
            this.cmbSetStandState.Size = new System.Drawing.Size(374, 21);
            this.cmbSetStandState.TabIndex = 2;
            this.cmbSetStandState.SelectedIndexChanged += new System.EventHandler(this.cmbSetStandState_SelectedIndexChanged);
            // 
            // lblSetStandState
            // 
            this.lblSetStandState.AutoSize = true;
            this.lblSetStandState.Location = new System.Drawing.Point(31, 61);
            this.lblSetStandState.Name = "lblSetStandState";
            this.lblSetStandState.Size = new System.Drawing.Size(66, 13);
            this.lblSetStandState.TabIndex = 1;
            this.lblSetStandState.Text = "Stand State:";
            // 
            // lblSetStandStateTooltip
            // 
            this.lblSetStandStateTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetStandStateTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetStandStateTooltip.Name = "lblSetStandStateTooltip";
            this.lblSetStandStateTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetStandStateTooltip.TabIndex = 0;
            this.lblSetStandStateTooltip.Text = "Changes the source Unit\'s current stand state.";
            // 
            // frmCommandModifyThreat
            // 
            this.frmCommandModifyThreat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandModifyThreat.Controls.Add(this.lblModifyThreatPercent);
            this.frmCommandModifyThreat.Controls.Add(this.txtModifyThreatPercent);
            this.frmCommandModifyThreat.Controls.Add(this.cmbModifyThreatTarget);
            this.frmCommandModifyThreat.Controls.Add(this.lblModifyThreatTarget);
            this.frmCommandModifyThreat.Controls.Add(this.lblModifyThreatTooltip);
            this.frmCommandModifyThreat.Location = new System.Drawing.Point(410, 252);
            this.frmCommandModifyThreat.Name = "frmCommandModifyThreat";
            this.frmCommandModifyThreat.Size = new System.Drawing.Size(495, 332);
            this.frmCommandModifyThreat.TabIndex = 35;
            this.frmCommandModifyThreat.Visible = false;
            // 
            // lblModifyThreatPercent
            // 
            this.lblModifyThreatPercent.AutoSize = true;
            this.lblModifyThreatPercent.Location = new System.Drawing.Point(47, 90);
            this.lblModifyThreatPercent.Name = "lblModifyThreatPercent";
            this.lblModifyThreatPercent.Size = new System.Drawing.Size(47, 13);
            this.lblModifyThreatPercent.TabIndex = 4;
            this.lblModifyThreatPercent.Text = "Percent:";
            // 
            // txtModifyThreatPercent
            // 
            this.txtModifyThreatPercent.Location = new System.Drawing.Point(99, 88);
            this.txtModifyThreatPercent.Name = "txtModifyThreatPercent";
            this.txtModifyThreatPercent.Size = new System.Drawing.Size(374, 20);
            this.txtModifyThreatPercent.TabIndex = 3;
            this.txtModifyThreatPercent.Leave += new System.EventHandler(this.txtModifyThreatPercent_Leave);
            // 
            // cmbModifyThreatTarget
            // 
            this.cmbModifyThreatTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModifyThreatTarget.FormattingEnabled = true;
            this.cmbModifyThreatTarget.Items.AddRange(new object[] {
            "Provided Target",
            "Current Victim",
            "Second on Threat",
            "Last on Threat",
            "Random Attacker",
            "Random Not Top",
            "All Attackers"});
            this.cmbModifyThreatTarget.Location = new System.Drawing.Point(99, 58);
            this.cmbModifyThreatTarget.Name = "cmbModifyThreatTarget";
            this.cmbModifyThreatTarget.Size = new System.Drawing.Size(374, 21);
            this.cmbModifyThreatTarget.TabIndex = 2;
            this.cmbModifyThreatTarget.SelectedIndexChanged += new System.EventHandler(this.cmbModifyThreatTarget_SelectedIndexChanged);
            // 
            // lblModifyThreatTarget
            // 
            this.lblModifyThreatTarget.AutoSize = true;
            this.lblModifyThreatTarget.Location = new System.Drawing.Point(53, 61);
            this.lblModifyThreatTarget.Name = "lblModifyThreatTarget";
            this.lblModifyThreatTarget.Size = new System.Drawing.Size(41, 13);
            this.lblModifyThreatTarget.TabIndex = 1;
            this.lblModifyThreatTarget.Text = "Target:";
            // 
            // lblModifyThreatTooltip
            // 
            this.lblModifyThreatTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblModifyThreatTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblModifyThreatTooltip.Name = "lblModifyThreatTooltip";
            this.lblModifyThreatTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblModifyThreatTooltip.TabIndex = 0;
            this.lblModifyThreatTooltip.Text = "Modifies threat for the selected targets by the specified percent.";
            // 
            // frmCommandSendTaxiPath
            // 
            this.frmCommandSendTaxiPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSendTaxiPath.Controls.Add(this.lblSendTaxiPath);
            this.frmCommandSendTaxiPath.Controls.Add(this.txtSendTaxiPath);
            this.frmCommandSendTaxiPath.Controls.Add(this.btnSendTaxiPathId);
            this.frmCommandSendTaxiPath.Controls.Add(this.lblSendTaxiPathId);
            this.frmCommandSendTaxiPath.Controls.Add(this.lblSendTaxiPathTooltip);
            this.frmCommandSendTaxiPath.Location = new System.Drawing.Point(410, 252);
            this.frmCommandSendTaxiPath.Name = "frmCommandSendTaxiPath";
            this.frmCommandSendTaxiPath.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSendTaxiPath.TabIndex = 36;
            this.frmCommandSendTaxiPath.Visible = false;
            // 
            // lblSendTaxiPath
            // 
            this.lblSendTaxiPath.AutoSize = true;
            this.lblSendTaxiPath.Location = new System.Drawing.Point(158, 54);
            this.lblSendTaxiPath.Name = "lblSendTaxiPath";
            this.lblSendTaxiPath.Size = new System.Drawing.Size(32, 13);
            this.lblSendTaxiPath.TabIndex = 4;
            this.lblSendTaxiPath.Text = "Path:";
            // 
            // txtSendTaxiPath
            // 
            this.txtSendTaxiPath.Location = new System.Drawing.Point(153, 73);
            this.txtSendTaxiPath.Name = "txtSendTaxiPath";
            this.txtSendTaxiPath.ReadOnly = true;
            this.txtSendTaxiPath.Size = new System.Drawing.Size(320, 20);
            this.txtSendTaxiPath.TabIndex = 3;
            // 
            // btnSendTaxiPathId
            // 
            this.btnSendTaxiPathId.Location = new System.Drawing.Point(22, 71);
            this.btnSendTaxiPathId.Name = "btnSendTaxiPathId";
            this.btnSendTaxiPathId.Size = new System.Drawing.Size(122, 23);
            this.btnSendTaxiPathId.TabIndex = 2;
            this.btnSendTaxiPathId.Text = "-NONE-";
            this.btnSendTaxiPathId.UseVisualStyleBackColor = true;
            this.btnSendTaxiPathId.Click += new System.EventHandler(this.btnSendTaxiPathId_Click);
            // 
            // lblSendTaxiPathId
            // 
            this.lblSendTaxiPathId.AutoSize = true;
            this.lblSendTaxiPathId.Location = new System.Drawing.Point(28, 54);
            this.lblSendTaxiPathId.Name = "lblSendTaxiPathId";
            this.lblSendTaxiPathId.Size = new System.Drawing.Size(19, 13);
            this.lblSendTaxiPathId.TabIndex = 1;
            this.lblSendTaxiPathId.Text = "Id:";
            // 
            // lblSendTaxiPathTooltip
            // 
            this.lblSendTaxiPathTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSendTaxiPathTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSendTaxiPathTooltip.Name = "lblSendTaxiPathTooltip";
            this.lblSendTaxiPathTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSendTaxiPathTooltip.TabIndex = 0;
            this.lblSendTaxiPathTooltip.Text = "Sends the target or source Player on the specified taxi path.";
            // 
            // frmCommandTerminateScript
            // 
            this.frmCommandTerminateScript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandTerminateScript.Controls.Add(this.lblTerminateScriptCondition);
            this.frmCommandTerminateScript.Controls.Add(this.cmbTerminateScriptCondition);
            this.frmCommandTerminateScript.Controls.Add(this.lblTerminateScriptCreatureId);
            this.frmCommandTerminateScript.Controls.Add(this.lblTerminateScriptSearchRadius);
            this.frmCommandTerminateScript.Controls.Add(this.txtTerminateScriptSearchRadius);
            this.frmCommandTerminateScript.Controls.Add(this.btnTerminateScriptCreatureId);
            this.frmCommandTerminateScript.Controls.Add(this.lblTerminateScriptTooltip);
            this.frmCommandTerminateScript.Location = new System.Drawing.Point(410, 252);
            this.frmCommandTerminateScript.Name = "frmCommandTerminateScript";
            this.frmCommandTerminateScript.Size = new System.Drawing.Size(495, 332);
            this.frmCommandTerminateScript.TabIndex = 37;
            this.frmCommandTerminateScript.Visible = false;
            // 
            // lblTerminateScriptCondition
            // 
            this.lblTerminateScriptCondition.AutoSize = true;
            this.lblTerminateScriptCondition.Location = new System.Drawing.Point(60, 134);
            this.lblTerminateScriptCondition.Name = "lblTerminateScriptCondition";
            this.lblTerminateScriptCondition.Size = new System.Drawing.Size(54, 13);
            this.lblTerminateScriptCondition.TabIndex = 6;
            this.lblTerminateScriptCondition.Text = "Condition:";
            // 
            // cmbTerminateScriptCondition
            // 
            this.cmbTerminateScriptCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerminateScriptCondition.FormattingEnabled = true;
            this.cmbTerminateScriptCondition.Items.AddRange(new object[] {
            "Creature Not Found",
            "Creature Is Found"});
            this.cmbTerminateScriptCondition.Location = new System.Drawing.Point(118, 131);
            this.cmbTerminateScriptCondition.Name = "cmbTerminateScriptCondition";
            this.cmbTerminateScriptCondition.Size = new System.Drawing.Size(355, 21);
            this.cmbTerminateScriptCondition.TabIndex = 5;
            this.cmbTerminateScriptCondition.SelectedIndexChanged += new System.EventHandler(this.cmbTerminateScriptCondition_SelectedIndexChanged);
            // 
            // lblTerminateScriptCreatureId
            // 
            this.lblTerminateScriptCreatureId.AutoSize = true;
            this.lblTerminateScriptCreatureId.Location = new System.Drawing.Point(52, 71);
            this.lblTerminateScriptCreatureId.Name = "lblTerminateScriptCreatureId";
            this.lblTerminateScriptCreatureId.Size = new System.Drawing.Size(62, 13);
            this.lblTerminateScriptCreatureId.TabIndex = 4;
            this.lblTerminateScriptCreatureId.Text = "Creature Id:";
            // 
            // lblTerminateScriptSearchRadius
            // 
            this.lblTerminateScriptSearchRadius.AutoSize = true;
            this.lblTerminateScriptSearchRadius.Location = new System.Drawing.Point(34, 102);
            this.lblTerminateScriptSearchRadius.Name = "lblTerminateScriptSearchRadius";
            this.lblTerminateScriptSearchRadius.Size = new System.Drawing.Size(80, 13);
            this.lblTerminateScriptSearchRadius.TabIndex = 3;
            this.lblTerminateScriptSearchRadius.Text = "Search Radius:";
            // 
            // txtTerminateScriptSearchRadius
            // 
            this.txtTerminateScriptSearchRadius.Location = new System.Drawing.Point(118, 100);
            this.txtTerminateScriptSearchRadius.Name = "txtTerminateScriptSearchRadius";
            this.txtTerminateScriptSearchRadius.Size = new System.Drawing.Size(355, 20);
            this.txtTerminateScriptSearchRadius.TabIndex = 2;
            this.txtTerminateScriptSearchRadius.Leave += new System.EventHandler(this.txtTerminateScriptSearchRadius_Leave);
            // 
            // btnTerminateScriptCreatureId
            // 
            this.btnTerminateScriptCreatureId.Location = new System.Drawing.Point(118, 66);
            this.btnTerminateScriptCreatureId.Name = "btnTerminateScriptCreatureId";
            this.btnTerminateScriptCreatureId.Size = new System.Drawing.Size(355, 23);
            this.btnTerminateScriptCreatureId.TabIndex = 1;
            this.btnTerminateScriptCreatureId.Text = "-NONE-";
            this.btnTerminateScriptCreatureId.UseVisualStyleBackColor = true;
            this.btnTerminateScriptCreatureId.Click += new System.EventHandler(this.btnTerminateScriptCreatureId_Click);
            // 
            // lblTerminateScriptTooltip
            // 
            this.lblTerminateScriptTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTerminateScriptTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblTerminateScriptTooltip.Name = "lblTerminateScriptTooltip";
            this.lblTerminateScriptTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblTerminateScriptTooltip.TabIndex = 0;
            this.lblTerminateScriptTooltip.Text = "Terminates further execution of the same script if a Creature with the provided I" +
    "d is not found within the specified range.";
            // 
            // frmCommandTerminateCondition
            // 
            this.frmCommandTerminateCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandTerminateCondition.Controls.Add(this.btnTerminateConditionQuest);
            this.frmCommandTerminateCondition.Controls.Add(this.lblTerminateConditionRule);
            this.frmCommandTerminateCondition.Controls.Add(this.cmbTerminateConditionRule);
            this.frmCommandTerminateCondition.Controls.Add(this.lblTerminateConditionId);
            this.frmCommandTerminateCondition.Controls.Add(this.lblTerminateConditionQuestId);
            this.frmCommandTerminateCondition.Controls.Add(this.btnTerminateConditionId);
            this.frmCommandTerminateCondition.Controls.Add(this.lblTerminateConditionTooltip);
            this.frmCommandTerminateCondition.Location = new System.Drawing.Point(410, 252);
            this.frmCommandTerminateCondition.Name = "frmCommandTerminateCondition";
            this.frmCommandTerminateCondition.Size = new System.Drawing.Size(495, 332);
            this.frmCommandTerminateCondition.TabIndex = 38;
            this.frmCommandTerminateCondition.Visible = false;
            // 
            // btnTerminateConditionQuest
            // 
            this.btnTerminateConditionQuest.Location = new System.Drawing.Point(118, 100);
            this.btnTerminateConditionQuest.Name = "btnTerminateConditionQuest";
            this.btnTerminateConditionQuest.Size = new System.Drawing.Size(355, 23);
            this.btnTerminateConditionQuest.TabIndex = 7;
            this.btnTerminateConditionQuest.Text = "-NONE-";
            this.btnTerminateConditionQuest.UseVisualStyleBackColor = true;
            this.btnTerminateConditionQuest.Click += new System.EventHandler(this.btnTerminateConditionQuest_Click);
            // 
            // lblTerminateConditionRule
            // 
            this.lblTerminateConditionRule.AutoSize = true;
            this.lblTerminateConditionRule.Location = new System.Drawing.Point(82, 134);
            this.lblTerminateConditionRule.Name = "lblTerminateConditionRule";
            this.lblTerminateConditionRule.Size = new System.Drawing.Size(32, 13);
            this.lblTerminateConditionRule.TabIndex = 6;
            this.lblTerminateConditionRule.Text = "Rule:";
            // 
            // cmbTerminateConditionRule
            // 
            this.cmbTerminateConditionRule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerminateConditionRule.FormattingEnabled = true;
            this.cmbTerminateConditionRule.Items.AddRange(new object[] {
            "Terminate when True",
            "Terminate when False"});
            this.cmbTerminateConditionRule.Location = new System.Drawing.Point(118, 131);
            this.cmbTerminateConditionRule.Name = "cmbTerminateConditionRule";
            this.cmbTerminateConditionRule.Size = new System.Drawing.Size(355, 21);
            this.cmbTerminateConditionRule.TabIndex = 5;
            this.cmbTerminateConditionRule.SelectedIndexChanged += new System.EventHandler(this.cmbTerminateConditionRule_SelectedIndexChanged);
            // 
            // lblTerminateConditionId
            // 
            this.lblTerminateConditionId.AutoSize = true;
            this.lblTerminateConditionId.Location = new System.Drawing.Point(48, 71);
            this.lblTerminateConditionId.Name = "lblTerminateConditionId";
            this.lblTerminateConditionId.Size = new System.Drawing.Size(66, 13);
            this.lblTerminateConditionId.TabIndex = 4;
            this.lblTerminateConditionId.Text = "Condition Id:";
            // 
            // lblTerminateConditionQuestId
            // 
            this.lblTerminateConditionQuestId.AutoSize = true;
            this.lblTerminateConditionQuestId.Location = new System.Drawing.Point(64, 102);
            this.lblTerminateConditionQuestId.Name = "lblTerminateConditionQuestId";
            this.lblTerminateConditionQuestId.Size = new System.Drawing.Size(50, 13);
            this.lblTerminateConditionQuestId.TabIndex = 3;
            this.lblTerminateConditionQuestId.Text = "Quest Id:";
            // 
            // btnTerminateConditionId
            // 
            this.btnTerminateConditionId.Location = new System.Drawing.Point(118, 66);
            this.btnTerminateConditionId.Name = "btnTerminateConditionId";
            this.btnTerminateConditionId.Size = new System.Drawing.Size(355, 23);
            this.btnTerminateConditionId.TabIndex = 1;
            this.btnTerminateConditionId.Text = "-NONE-";
            this.btnTerminateConditionId.UseVisualStyleBackColor = true;
            this.btnTerminateConditionId.Click += new System.EventHandler(this.btnTerminateConditionId_Click);
            // 
            // lblTerminateConditionTooltip
            // 
            this.lblTerminateConditionTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTerminateConditionTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblTerminateConditionTooltip.Name = "lblTerminateConditionTooltip";
            this.lblTerminateConditionTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblTerminateConditionTooltip.TabIndex = 0;
            this.lblTerminateConditionTooltip.Text = "Terminates further execution of the same script if the specified condition is sat" +
    "isfied. If a quest Id is provided, the quest gets marked as failed for the invol" +
    "ved players.";
            // 
            // frmCommandSetHomePosition
            // 
            this.frmCommandSetHomePosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetHomePosition.Controls.Add(this.lblSetHomePositionO);
            this.frmCommandSetHomePosition.Controls.Add(this.lblSetHomePositionZ);
            this.frmCommandSetHomePosition.Controls.Add(this.txtSetHomePositionO);
            this.frmCommandSetHomePosition.Controls.Add(this.txtSetHomePositionZ);
            this.frmCommandSetHomePosition.Controls.Add(this.lblSetHomePositionY);
            this.frmCommandSetHomePosition.Controls.Add(this.lblSetHomePositionX);
            this.frmCommandSetHomePosition.Controls.Add(this.txtSetHomePositionY);
            this.frmCommandSetHomePosition.Controls.Add(this.txtSetHomePositionX);
            this.frmCommandSetHomePosition.Controls.Add(this.cmbSetHomePositionMode);
            this.frmCommandSetHomePosition.Controls.Add(this.lblSetHomePositionMode);
            this.frmCommandSetHomePosition.Controls.Add(this.lblSetHomePositionTooltip);
            this.frmCommandSetHomePosition.Location = new System.Drawing.Point(410, 252);
            this.frmCommandSetHomePosition.Name = "frmCommandSetHomePosition";
            this.frmCommandSetHomePosition.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetHomePosition.TabIndex = 39;
            this.frmCommandSetHomePosition.Visible = false;
            // 
            // lblSetHomePositionO
            // 
            this.lblSetHomePositionO.AutoSize = true;
            this.lblSetHomePositionO.Location = new System.Drawing.Point(264, 124);
            this.lblSetHomePositionO.Name = "lblSetHomePositionO";
            this.lblSetHomePositionO.Size = new System.Drawing.Size(61, 13);
            this.lblSetHomePositionO.TabIndex = 10;
            this.lblSetHomePositionO.Text = "Orientation:";
            // 
            // lblSetHomePositionZ
            // 
            this.lblSetHomePositionZ.AutoSize = true;
            this.lblSetHomePositionZ.Location = new System.Drawing.Point(26, 124);
            this.lblSetHomePositionZ.Name = "lblSetHomePositionZ";
            this.lblSetHomePositionZ.Size = new System.Drawing.Size(70, 13);
            this.lblSetHomePositionZ.TabIndex = 9;
            this.lblSetHomePositionZ.Text = "Z coordinate:";
            // 
            // txtSetHomePositionO
            // 
            this.txtSetHomePositionO.Location = new System.Drawing.Point(328, 121);
            this.txtSetHomePositionO.Name = "txtSetHomePositionO";
            this.txtSetHomePositionO.Size = new System.Drawing.Size(145, 20);
            this.txtSetHomePositionO.TabIndex = 8;
            this.txtSetHomePositionO.Leave += new System.EventHandler(this.txtSetHomePositionO_Leave);
            // 
            // txtSetHomePositionZ
            // 
            this.txtSetHomePositionZ.Location = new System.Drawing.Point(99, 121);
            this.txtSetHomePositionZ.Name = "txtSetHomePositionZ";
            this.txtSetHomePositionZ.Size = new System.Drawing.Size(145, 20);
            this.txtSetHomePositionZ.TabIndex = 7;
            this.txtSetHomePositionZ.Leave += new System.EventHandler(this.txtSetHomePositionZ_Leave);
            // 
            // lblSetHomePositionY
            // 
            this.lblSetHomePositionY.AutoSize = true;
            this.lblSetHomePositionY.Location = new System.Drawing.Point(255, 93);
            this.lblSetHomePositionY.Name = "lblSetHomePositionY";
            this.lblSetHomePositionY.Size = new System.Drawing.Size(70, 13);
            this.lblSetHomePositionY.TabIndex = 6;
            this.lblSetHomePositionY.Text = "Y coordinate:";
            // 
            // lblSetHomePositionX
            // 
            this.lblSetHomePositionX.AutoSize = true;
            this.lblSetHomePositionX.Location = new System.Drawing.Point(26, 93);
            this.lblSetHomePositionX.Name = "lblSetHomePositionX";
            this.lblSetHomePositionX.Size = new System.Drawing.Size(70, 13);
            this.lblSetHomePositionX.TabIndex = 5;
            this.lblSetHomePositionX.Text = "X coordinate:";
            // 
            // txtSetHomePositionY
            // 
            this.txtSetHomePositionY.Location = new System.Drawing.Point(328, 90);
            this.txtSetHomePositionY.Name = "txtSetHomePositionY";
            this.txtSetHomePositionY.Size = new System.Drawing.Size(145, 20);
            this.txtSetHomePositionY.TabIndex = 4;
            this.txtSetHomePositionY.Leave += new System.EventHandler(this.txtSetHomePositionY_Leave);
            // 
            // txtSetHomePositionX
            // 
            this.txtSetHomePositionX.Location = new System.Drawing.Point(99, 90);
            this.txtSetHomePositionX.Name = "txtSetHomePositionX";
            this.txtSetHomePositionX.Size = new System.Drawing.Size(145, 20);
            this.txtSetHomePositionX.TabIndex = 3;
            this.txtSetHomePositionX.Leave += new System.EventHandler(this.txtSetHomePositionX_Leave);
            // 
            // cmbSetHomePositionMode
            // 
            this.cmbSetHomePositionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetHomePositionMode.FormattingEnabled = true;
            this.cmbSetHomePositionMode.Items.AddRange(new object[] {
            "Provided coordinates",
            "Current position",
            "Reset to default"});
            this.cmbSetHomePositionMode.Location = new System.Drawing.Point(99, 58);
            this.cmbSetHomePositionMode.Name = "cmbSetHomePositionMode";
            this.cmbSetHomePositionMode.Size = new System.Drawing.Size(374, 21);
            this.cmbSetHomePositionMode.TabIndex = 2;
            this.cmbSetHomePositionMode.SelectedIndexChanged += new System.EventHandler(this.cmbSetHomePositionMode_SelectedIndexChanged);
            // 
            // lblSetHomePositionMode
            // 
            this.lblSetHomePositionMode.AutoSize = true;
            this.lblSetHomePositionMode.Location = new System.Drawing.Point(59, 61);
            this.lblSetHomePositionMode.Name = "lblSetHomePositionMode";
            this.lblSetHomePositionMode.Size = new System.Drawing.Size(37, 13);
            this.lblSetHomePositionMode.TabIndex = 1;
            this.lblSetHomePositionMode.Text = "Mode:";
            // 
            // lblSetHomePositionTooltip
            // 
            this.lblSetHomePositionTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetHomePositionTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetHomePositionTooltip.Name = "lblSetHomePositionTooltip";
            this.lblSetHomePositionTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetHomePositionTooltip.TabIndex = 0;
            this.lblSetHomePositionTooltip.Text = "Sets the source Creature\'s home position to the specified coordinates.";
            // 
            // frmCommandSetFacing
            // 
            this.frmCommandSetFacing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetFacing.Controls.Add(this.lblSetFacingOrientation);
            this.frmCommandSetFacing.Controls.Add(this.txtSetFacingOrientation);
            this.frmCommandSetFacing.Controls.Add(this.cmbSetFacingMode);
            this.frmCommandSetFacing.Controls.Add(this.lblSetFacingMode);
            this.frmCommandSetFacing.Controls.Add(this.lblSetFacingTooltip);
            this.frmCommandSetFacing.Location = new System.Drawing.Point(410, 252);
            this.frmCommandSetFacing.Name = "frmCommandSetFacing";
            this.frmCommandSetFacing.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetFacing.TabIndex = 40;
            this.frmCommandSetFacing.Visible = false;
            // 
            // lblSetFacingOrientation
            // 
            this.lblSetFacingOrientation.AutoSize = true;
            this.lblSetFacingOrientation.Location = new System.Drawing.Point(35, 93);
            this.lblSetFacingOrientation.Name = "lblSetFacingOrientation";
            this.lblSetFacingOrientation.Size = new System.Drawing.Size(61, 13);
            this.lblSetFacingOrientation.TabIndex = 5;
            this.lblSetFacingOrientation.Text = "Orientation:";
            // 
            // txtSetFacingOrientation
            // 
            this.txtSetFacingOrientation.Location = new System.Drawing.Point(99, 90);
            this.txtSetFacingOrientation.Name = "txtSetFacingOrientation";
            this.txtSetFacingOrientation.Size = new System.Drawing.Size(374, 20);
            this.txtSetFacingOrientation.TabIndex = 3;
            this.txtSetFacingOrientation.Leave += new System.EventHandler(this.txtSetFacingOrientation_Leave);
            // 
            // cmbSetFacingMode
            // 
            this.cmbSetFacingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetFacingMode.FormattingEnabled = true;
            this.cmbSetFacingMode.Items.AddRange(new object[] {
            "Face provided target",
            "Use orientation value"});
            this.cmbSetFacingMode.Location = new System.Drawing.Point(99, 58);
            this.cmbSetFacingMode.Name = "cmbSetFacingMode";
            this.cmbSetFacingMode.Size = new System.Drawing.Size(374, 21);
            this.cmbSetFacingMode.TabIndex = 2;
            this.cmbSetFacingMode.SelectedIndexChanged += new System.EventHandler(this.cmbSetFacingMode_SelectedIndexChanged);
            // 
            // lblSetFacingMode
            // 
            this.lblSetFacingMode.AutoSize = true;
            this.lblSetFacingMode.Location = new System.Drawing.Point(59, 61);
            this.lblSetFacingMode.Name = "lblSetFacingMode";
            this.lblSetFacingMode.Size = new System.Drawing.Size(37, 13);
            this.lblSetFacingMode.TabIndex = 1;
            this.lblSetFacingMode.Text = "Mode:";
            // 
            // lblSetFacingTooltip
            // 
            this.lblSetFacingTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetFacingTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetFacingTooltip.Name = "lblSetFacingTooltip";
            this.lblSetFacingTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetFacingTooltip.TabIndex = 0;
            this.lblSetFacingTooltip.Text = "Changes the source Unit\'s orientation to either the specified value, or to face t" +
    "he target WorldObject.";
            // 
            // frmCommandMeetingStone
            // 
            this.frmCommandMeetingStone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandMeetingStone.Controls.Add(this.btnMeetingStoneAreaId);
            this.frmCommandMeetingStone.Controls.Add(this.lblMeetingStoneAreaId);
            this.frmCommandMeetingStone.Controls.Add(this.lblMeetingStoneTooltip);
            this.frmCommandMeetingStone.Location = new System.Drawing.Point(410, 252);
            this.frmCommandMeetingStone.Name = "frmCommandMeetingStone";
            this.frmCommandMeetingStone.Size = new System.Drawing.Size(495, 332);
            this.frmCommandMeetingStone.TabIndex = 41;
            this.frmCommandMeetingStone.Visible = false;
            // 
            // btnMeetingStoneAreaId
            // 
            this.btnMeetingStoneAreaId.Location = new System.Drawing.Point(69, 57);
            this.btnMeetingStoneAreaId.Name = "btnMeetingStoneAreaId";
            this.btnMeetingStoneAreaId.Size = new System.Drawing.Size(404, 23);
            this.btnMeetingStoneAreaId.TabIndex = 2;
            this.btnMeetingStoneAreaId.Text = "-NONE-";
            this.btnMeetingStoneAreaId.UseVisualStyleBackColor = true;
            this.btnMeetingStoneAreaId.Click += new System.EventHandler(this.btnMeetingStoneAreaId_Click);
            // 
            // lblMeetingStoneAreaId
            // 
            this.lblMeetingStoneAreaId.AutoSize = true;
            this.lblMeetingStoneAreaId.Location = new System.Drawing.Point(23, 61);
            this.lblMeetingStoneAreaId.Name = "lblMeetingStoneAreaId";
            this.lblMeetingStoneAreaId.Size = new System.Drawing.Size(44, 13);
            this.lblMeetingStoneAreaId.TabIndex = 1;
            this.lblMeetingStoneAreaId.Text = "Area Id:";
            // 
            // lblMeetingStoneTooltip
            // 
            this.lblMeetingStoneTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMeetingStoneTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblMeetingStoneTooltip.Name = "lblMeetingStoneTooltip";
            this.lblMeetingStoneTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblMeetingStoneTooltip.TabIndex = 0;
            this.lblMeetingStoneTooltip.Text = "The target or source Player gets put into a queue for the chosen dungeon.";
            // 
            // frmCommandSetData
            // 
            this.frmCommandSetData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetData.Controls.Add(this.lblSetDataValue);
            this.frmCommandSetData.Controls.Add(this.txtSetDataValue);
            this.frmCommandSetData.Controls.Add(this.lblSetDataField);
            this.frmCommandSetData.Controls.Add(this.txtSetDataField);
            this.frmCommandSetData.Controls.Add(this.cmbSetDataMode);
            this.frmCommandSetData.Controls.Add(this.lblSetDataMode);
            this.frmCommandSetData.Controls.Add(this.lblSetDataTooltip);
            this.frmCommandSetData.Location = new System.Drawing.Point(410, 252);
            this.frmCommandSetData.Name = "frmCommandSetData";
            this.frmCommandSetData.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetData.TabIndex = 42;
            this.frmCommandSetData.Visible = false;
            // 
            // lblSetDataValue
            // 
            this.lblSetDataValue.AutoSize = true;
            this.lblSetDataValue.Location = new System.Drawing.Point(63, 124);
            this.lblSetDataValue.Name = "lblSetDataValue";
            this.lblSetDataValue.Size = new System.Drawing.Size(33, 13);
            this.lblSetDataValue.TabIndex = 7;
            this.lblSetDataValue.Text = "Data:";
            // 
            // txtSetDataValue
            // 
            this.txtSetDataValue.Location = new System.Drawing.Point(99, 121);
            this.txtSetDataValue.Name = "txtSetDataValue";
            this.txtSetDataValue.Size = new System.Drawing.Size(374, 20);
            this.txtSetDataValue.TabIndex = 6;
            this.txtSetDataValue.Leave += new System.EventHandler(this.txtSetDataValue_Leave);
            // 
            // lblSetDataField
            // 
            this.lblSetDataField.AutoSize = true;
            this.lblSetDataField.Location = new System.Drawing.Point(64, 93);
            this.lblSetDataField.Name = "lblSetDataField";
            this.lblSetDataField.Size = new System.Drawing.Size(32, 13);
            this.lblSetDataField.TabIndex = 5;
            this.lblSetDataField.Text = "Field:";
            // 
            // txtSetDataField
            // 
            this.txtSetDataField.Location = new System.Drawing.Point(99, 90);
            this.txtSetDataField.Name = "txtSetDataField";
            this.txtSetDataField.Size = new System.Drawing.Size(374, 20);
            this.txtSetDataField.TabIndex = 3;
            this.txtSetDataField.Leave += new System.EventHandler(this.txtSetDataField_Leave);
            // 
            // cmbSetDataMode
            // 
            this.cmbSetDataMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetDataMode.FormattingEnabled = true;
            this.cmbSetDataMode.Items.AddRange(new object[] {
            "Raw Value",
            "Increment Current Value",
            "Decrement Current Value"});
            this.cmbSetDataMode.Location = new System.Drawing.Point(99, 58);
            this.cmbSetDataMode.Name = "cmbSetDataMode";
            this.cmbSetDataMode.Size = new System.Drawing.Size(374, 21);
            this.cmbSetDataMode.TabIndex = 2;
            this.cmbSetDataMode.SelectedIndexChanged += new System.EventHandler(this.cmbSetDataMode_SelectedIndexChanged);
            // 
            // lblSetDataMode
            // 
            this.lblSetDataMode.AutoSize = true;
            this.lblSetDataMode.Location = new System.Drawing.Point(59, 61);
            this.lblSetDataMode.Name = "lblSetDataMode";
            this.lblSetDataMode.Size = new System.Drawing.Size(37, 13);
            this.lblSetDataMode.TabIndex = 1;
            this.lblSetDataMode.Text = "Mode:";
            // 
            // lblSetDataTooltip
            // 
            this.lblSetDataTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetDataTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetDataTooltip.Name = "lblSetDataTooltip";
            this.lblSetDataTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetDataTooltip.TabIndex = 0;
            this.lblSetDataTooltip.Text = "Saves data to the instance script of the map.";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(830, 590);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmCommandStartScript
            // 
            this.frmCommandStartScript.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandStartScript.Controls.Add(this.btnStartScriptEdit4);
            this.frmCommandStartScript.Controls.Add(this.btnStartScriptEdit3);
            this.frmCommandStartScript.Controls.Add(this.btnStartScriptEdit2);
            this.frmCommandStartScript.Controls.Add(this.btnStartScriptEdit1);
            this.frmCommandStartScript.Controls.Add(this.txtStartScriptChance4);
            this.frmCommandStartScript.Controls.Add(this.txtStartScriptId4);
            this.frmCommandStartScript.Controls.Add(this.txtStartScriptChance3);
            this.frmCommandStartScript.Controls.Add(this.txtStartScriptId3);
            this.frmCommandStartScript.Controls.Add(this.txtStartScriptChance2);
            this.frmCommandStartScript.Controls.Add(this.txtStartScriptId2);
            this.frmCommandStartScript.Controls.Add(this.txtStartScriptChance1);
            this.frmCommandStartScript.Controls.Add(this.txtStartScriptId1);
            this.frmCommandStartScript.Controls.Add(this.lblStartScriptChance);
            this.frmCommandStartScript.Controls.Add(this.lblStartScriptId);
            this.frmCommandStartScript.Controls.Add(this.lblStartScriptTooltip);
            this.frmCommandStartScript.Location = new System.Drawing.Point(410, 252);
            this.frmCommandStartScript.Name = "frmCommandStartScript";
            this.frmCommandStartScript.Size = new System.Drawing.Size(495, 332);
            this.frmCommandStartScript.TabIndex = 44;
            this.frmCommandStartScript.Visible = false;
            // 
            // btnStartScriptEdit4
            // 
            this.btnStartScriptEdit4.Location = new System.Drawing.Point(428, 172);
            this.btnStartScriptEdit4.Name = "btnStartScriptEdit4";
            this.btnStartScriptEdit4.Size = new System.Drawing.Size(44, 22);
            this.btnStartScriptEdit4.TabIndex = 24;
            this.btnStartScriptEdit4.Text = "Edit";
            this.btnStartScriptEdit4.UseVisualStyleBackColor = true;
            this.btnStartScriptEdit4.Click += new System.EventHandler(this.btnStartScriptEdit4_Click);
            // 
            // btnStartScriptEdit3
            // 
            this.btnStartScriptEdit3.Location = new System.Drawing.Point(428, 143);
            this.btnStartScriptEdit3.Name = "btnStartScriptEdit3";
            this.btnStartScriptEdit3.Size = new System.Drawing.Size(44, 22);
            this.btnStartScriptEdit3.TabIndex = 23;
            this.btnStartScriptEdit3.Text = "Edit";
            this.btnStartScriptEdit3.UseVisualStyleBackColor = true;
            this.btnStartScriptEdit3.Click += new System.EventHandler(this.btnStartScriptEdit3_Click);
            // 
            // btnStartScriptEdit2
            // 
            this.btnStartScriptEdit2.Location = new System.Drawing.Point(428, 114);
            this.btnStartScriptEdit2.Name = "btnStartScriptEdit2";
            this.btnStartScriptEdit2.Size = new System.Drawing.Size(44, 22);
            this.btnStartScriptEdit2.TabIndex = 22;
            this.btnStartScriptEdit2.Text = "Edit";
            this.btnStartScriptEdit2.UseVisualStyleBackColor = true;
            this.btnStartScriptEdit2.Click += new System.EventHandler(this.btnStartScriptEdit2_Click);
            // 
            // btnStartScriptEdit1
            // 
            this.btnStartScriptEdit1.Location = new System.Drawing.Point(429, 85);
            this.btnStartScriptEdit1.Name = "btnStartScriptEdit1";
            this.btnStartScriptEdit1.Size = new System.Drawing.Size(44, 22);
            this.btnStartScriptEdit1.TabIndex = 21;
            this.btnStartScriptEdit1.Text = "Edit";
            this.btnStartScriptEdit1.UseVisualStyleBackColor = true;
            this.btnStartScriptEdit1.Click += new System.EventHandler(this.btnStartScriptEdit1_Click);
            // 
            // txtStartScriptChance4
            // 
            this.txtStartScriptChance4.Location = new System.Drawing.Point(225, 172);
            this.txtStartScriptChance4.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtStartScriptChance4.Name = "txtStartScriptChance4";
            this.txtStartScriptChance4.Size = new System.Drawing.Size(190, 20);
            this.txtStartScriptChance4.TabIndex = 20;
            this.txtStartScriptChance4.Leave += new System.EventHandler(this.txtStartScriptChance4_Leave);
            // 
            // txtStartScriptId4
            // 
            this.txtStartScriptId4.Location = new System.Drawing.Point(19, 172);
            this.txtStartScriptId4.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtStartScriptId4.Name = "txtStartScriptId4";
            this.txtStartScriptId4.Size = new System.Drawing.Size(191, 20);
            this.txtStartScriptId4.TabIndex = 19;
            this.txtStartScriptId4.Leave += new System.EventHandler(this.txtStartScriptId4_Leave);
            // 
            // txtStartScriptChance3
            // 
            this.txtStartScriptChance3.Location = new System.Drawing.Point(225, 143);
            this.txtStartScriptChance3.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtStartScriptChance3.Name = "txtStartScriptChance3";
            this.txtStartScriptChance3.Size = new System.Drawing.Size(190, 20);
            this.txtStartScriptChance3.TabIndex = 18;
            this.txtStartScriptChance3.Leave += new System.EventHandler(this.txtStartScriptChance3_Leave);
            // 
            // txtStartScriptId3
            // 
            this.txtStartScriptId3.Location = new System.Drawing.Point(19, 143);
            this.txtStartScriptId3.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtStartScriptId3.Name = "txtStartScriptId3";
            this.txtStartScriptId3.Size = new System.Drawing.Size(191, 20);
            this.txtStartScriptId3.TabIndex = 17;
            this.txtStartScriptId3.Leave += new System.EventHandler(this.txtStartScriptId3_Leave);
            // 
            // txtStartScriptChance2
            // 
            this.txtStartScriptChance2.Location = new System.Drawing.Point(225, 114);
            this.txtStartScriptChance2.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtStartScriptChance2.Name = "txtStartScriptChance2";
            this.txtStartScriptChance2.Size = new System.Drawing.Size(190, 20);
            this.txtStartScriptChance2.TabIndex = 16;
            this.txtStartScriptChance2.Leave += new System.EventHandler(this.txtStartScriptChance2_Leave);
            // 
            // txtStartScriptId2
            // 
            this.txtStartScriptId2.Location = new System.Drawing.Point(19, 114);
            this.txtStartScriptId2.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtStartScriptId2.Name = "txtStartScriptId2";
            this.txtStartScriptId2.Size = new System.Drawing.Size(191, 20);
            this.txtStartScriptId2.TabIndex = 15;
            this.txtStartScriptId2.Leave += new System.EventHandler(this.txtStartScriptId2_Leave);
            // 
            // txtStartScriptChance1
            // 
            this.txtStartScriptChance1.Location = new System.Drawing.Point(225, 85);
            this.txtStartScriptChance1.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtStartScriptChance1.Name = "txtStartScriptChance1";
            this.txtStartScriptChance1.Size = new System.Drawing.Size(190, 20);
            this.txtStartScriptChance1.TabIndex = 14;
            this.txtStartScriptChance1.Leave += new System.EventHandler(this.txtStartScriptChance1_Leave);
            // 
            // txtStartScriptId1
            // 
            this.txtStartScriptId1.Location = new System.Drawing.Point(19, 85);
            this.txtStartScriptId1.MinimumSize = new System.Drawing.Size(4, 22);
            this.txtStartScriptId1.Name = "txtStartScriptId1";
            this.txtStartScriptId1.Size = new System.Drawing.Size(191, 20);
            this.txtStartScriptId1.TabIndex = 13;
            this.txtStartScriptId1.Leave += new System.EventHandler(this.txtStartScriptId1_Leave);
            // 
            // lblStartScriptChance
            // 
            this.lblStartScriptChance.AutoSize = true;
            this.lblStartScriptChance.Location = new System.Drawing.Point(228, 63);
            this.lblStartScriptChance.Name = "lblStartScriptChance";
            this.lblStartScriptChance.Size = new System.Drawing.Size(86, 13);
            this.lblStartScriptChance.TabIndex = 12;
            this.lblStartScriptChance.Text = "Percent chance:";
            // 
            // lblStartScriptId
            // 
            this.lblStartScriptId.AutoSize = true;
            this.lblStartScriptId.Location = new System.Drawing.Point(22, 63);
            this.lblStartScriptId.Name = "lblStartScriptId";
            this.lblStartScriptId.Size = new System.Drawing.Size(91, 13);
            this.lblStartScriptId.TabIndex = 11;
            this.lblStartScriptId.Text = "Generic Script ID:";
            // 
            // lblStartScriptTooltip
            // 
            this.lblStartScriptTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStartScriptTooltip.Location = new System.Drawing.Point(19, 10);
            this.lblStartScriptTooltip.Name = "lblStartScriptTooltip";
            this.lblStartScriptTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblStartScriptTooltip.TabIndex = 10;
            this.lblStartScriptTooltip.Text = "Starts one of the specified generic script Ids. Chosen script is determined by a " +
    "random chance roll. Total chance must not exceed 100%.";
            // 
            // lblNoAction
            // 
            this.lblNoAction.AutoSize = true;
            this.lblNoAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAction.Location = new System.Drawing.Point(575, 408);
            this.lblNoAction.Name = "lblNoAction";
            this.lblNoAction.Size = new System.Drawing.Size(163, 20);
            this.lblNoAction.TabIndex = 46;
            this.lblNoAction.Text = "No Action Selected";
            // 
            // btnActionCopy
            // 
            this.btnActionCopy.Location = new System.Drawing.Point(101, 590);
            this.btnActionCopy.Name = "btnActionCopy";
            this.btnActionCopy.Size = new System.Drawing.Size(75, 23);
            this.btnActionCopy.TabIndex = 47;
            this.btnActionCopy.Text = "Copy";
            this.btnActionCopy.UseVisualStyleBackColor = true;
            this.btnActionCopy.Click += new System.EventHandler(this.btnActionCopy_Click);
            // 
            // btnViewRaw
            // 
            this.btnViewRaw.Location = new System.Drawing.Point(751, 590);
            this.btnViewRaw.Name = "btnViewRaw";
            this.btnViewRaw.Size = new System.Drawing.Size(75, 23);
            this.btnViewRaw.TabIndex = 48;
            this.btnViewRaw.Text = "View Raw";
            this.btnViewRaw.UseVisualStyleBackColor = true;
            this.btnViewRaw.Click += new System.EventHandler(this.btnViewRaw_Click);
            // 
            // frmCommandSetPhase
            // 
            this.frmCommandSetPhase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetPhase.Controls.Add(this.lblSetPhasePhase);
            this.frmCommandSetPhase.Controls.Add(this.lblSetPhaseMode);
            this.frmCommandSetPhase.Controls.Add(this.txtSetPhasePhase);
            this.frmCommandSetPhase.Controls.Add(this.cmbSetPhaseMode);
            this.frmCommandSetPhase.Controls.Add(this.lblSetPhaseTooltip);
            this.frmCommandSetPhase.Location = new System.Drawing.Point(410, 252);
            this.frmCommandSetPhase.Name = "frmCommandSetPhase";
            this.frmCommandSetPhase.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetPhase.TabIndex = 49;
            this.frmCommandSetPhase.Visible = false;
            // 
            // lblSetPhasePhase
            // 
            this.lblSetPhasePhase.AutoSize = true;
            this.lblSetPhasePhase.Location = new System.Drawing.Point(56, 93);
            this.lblSetPhasePhase.Name = "lblSetPhasePhase";
            this.lblSetPhasePhase.Size = new System.Drawing.Size(40, 13);
            this.lblSetPhasePhase.TabIndex = 4;
            this.lblSetPhasePhase.Text = "Phase:";
            // 
            // lblSetPhaseMode
            // 
            this.lblSetPhaseMode.AutoSize = true;
            this.lblSetPhaseMode.Location = new System.Drawing.Point(58, 61);
            this.lblSetPhaseMode.Name = "lblSetPhaseMode";
            this.lblSetPhaseMode.Size = new System.Drawing.Size(37, 13);
            this.lblSetPhaseMode.TabIndex = 3;
            this.lblSetPhaseMode.Text = "Mode:";
            // 
            // txtSetPhasePhase
            // 
            this.txtSetPhasePhase.Location = new System.Drawing.Point(99, 90);
            this.txtSetPhasePhase.Name = "txtSetPhasePhase";
            this.txtSetPhasePhase.Size = new System.Drawing.Size(374, 20);
            this.txtSetPhasePhase.TabIndex = 2;
            this.txtSetPhasePhase.Leave += new System.EventHandler(this.txtSetPhasePhase_Leave);
            // 
            // cmbSetPhaseMode
            // 
            this.cmbSetPhaseMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetPhaseMode.FormattingEnabled = true;
            this.cmbSetPhaseMode.Location = new System.Drawing.Point(99, 58);
            this.cmbSetPhaseMode.Name = "cmbSetPhaseMode";
            this.cmbSetPhaseMode.Size = new System.Drawing.Size(374, 21);
            this.cmbSetPhaseMode.TabIndex = 1;
            this.cmbSetPhaseMode.SelectedIndexChanged += new System.EventHandler(this.cmbSetPhaseMode_SelectedIndexChanged);
            // 
            // lblSetPhaseTooltip
            // 
            this.lblSetPhaseTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetPhaseTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetPhaseTooltip.Name = "lblSetPhaseTooltip";
            this.lblSetPhaseTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetPhaseTooltip.TabIndex = 0;
            this.lblSetPhaseTooltip.Text = "Changes the current AI phase of the source Creature. Can only be used on creature" +
    "s with EventAI.";
            // 
            // frmCommandSetRandomPhase
            // 
            this.frmCommandSetRandomPhase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetRandomPhase.Controls.Add(this.lblSetRandomPhase4);
            this.frmCommandSetRandomPhase.Controls.Add(this.txtSetRandomPhase4);
            this.frmCommandSetRandomPhase.Controls.Add(this.lblSetRandomPhase3);
            this.frmCommandSetRandomPhase.Controls.Add(this.txtSetRandomPhase3);
            this.frmCommandSetRandomPhase.Controls.Add(this.txtSetRandomPhase1);
            this.frmCommandSetRandomPhase.Controls.Add(this.lblSetRandomPhase2);
            this.frmCommandSetRandomPhase.Controls.Add(this.lblSetRandomPhase1);
            this.frmCommandSetRandomPhase.Controls.Add(this.txtSetRandomPhase2);
            this.frmCommandSetRandomPhase.Controls.Add(this.lblSetRandomPhaseTooltip);
            this.frmCommandSetRandomPhase.Location = new System.Drawing.Point(410, 252);
            this.frmCommandSetRandomPhase.Name = "frmCommandSetRandomPhase";
            this.frmCommandSetRandomPhase.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetRandomPhase.TabIndex = 50;
            this.frmCommandSetRandomPhase.Visible = false;
            // 
            // lblSetRandomPhase4
            // 
            this.lblSetRandomPhase4.AutoSize = true;
            this.lblSetRandomPhase4.Location = new System.Drawing.Point(46, 160);
            this.lblSetRandomPhase4.Name = "lblSetRandomPhase4";
            this.lblSetRandomPhase4.Size = new System.Drawing.Size(49, 13);
            this.lblSetRandomPhase4.TabIndex = 9;
            this.lblSetRandomPhase4.Text = "Phase 4:";
            // 
            // txtSetRandomPhase4
            // 
            this.txtSetRandomPhase4.Location = new System.Drawing.Point(99, 157);
            this.txtSetRandomPhase4.Name = "txtSetRandomPhase4";
            this.txtSetRandomPhase4.Size = new System.Drawing.Size(374, 20);
            this.txtSetRandomPhase4.TabIndex = 8;
            this.txtSetRandomPhase4.Leave += new System.EventHandler(this.txtSetRandomPhase4_Leave);
            // 
            // lblSetRandomPhase3
            // 
            this.lblSetRandomPhase3.AutoSize = true;
            this.lblSetRandomPhase3.Location = new System.Drawing.Point(46, 127);
            this.lblSetRandomPhase3.Name = "lblSetRandomPhase3";
            this.lblSetRandomPhase3.Size = new System.Drawing.Size(49, 13);
            this.lblSetRandomPhase3.TabIndex = 7;
            this.lblSetRandomPhase3.Text = "Phase 3:";
            // 
            // txtSetRandomPhase3
            // 
            this.txtSetRandomPhase3.Location = new System.Drawing.Point(99, 124);
            this.txtSetRandomPhase3.Name = "txtSetRandomPhase3";
            this.txtSetRandomPhase3.Size = new System.Drawing.Size(374, 20);
            this.txtSetRandomPhase3.TabIndex = 6;
            this.txtSetRandomPhase3.Leave += new System.EventHandler(this.txtSetRandomPhase3_Leave);
            // 
            // txtSetRandomPhase1
            // 
            this.txtSetRandomPhase1.Location = new System.Drawing.Point(99, 58);
            this.txtSetRandomPhase1.Name = "txtSetRandomPhase1";
            this.txtSetRandomPhase1.Size = new System.Drawing.Size(374, 20);
            this.txtSetRandomPhase1.TabIndex = 5;
            this.txtSetRandomPhase1.Leave += new System.EventHandler(this.txtSetRandomPhase1_Leave);
            // 
            // lblSetRandomPhase2
            // 
            this.lblSetRandomPhase2.AutoSize = true;
            this.lblSetRandomPhase2.Location = new System.Drawing.Point(46, 94);
            this.lblSetRandomPhase2.Name = "lblSetRandomPhase2";
            this.lblSetRandomPhase2.Size = new System.Drawing.Size(49, 13);
            this.lblSetRandomPhase2.TabIndex = 4;
            this.lblSetRandomPhase2.Text = "Phase 2:";
            // 
            // lblSetRandomPhase1
            // 
            this.lblSetRandomPhase1.AutoSize = true;
            this.lblSetRandomPhase1.Location = new System.Drawing.Point(46, 61);
            this.lblSetRandomPhase1.Name = "lblSetRandomPhase1";
            this.lblSetRandomPhase1.Size = new System.Drawing.Size(49, 13);
            this.lblSetRandomPhase1.TabIndex = 3;
            this.lblSetRandomPhase1.Text = "Phase 1:";
            // 
            // txtSetRandomPhase2
            // 
            this.txtSetRandomPhase2.Location = new System.Drawing.Point(99, 91);
            this.txtSetRandomPhase2.Name = "txtSetRandomPhase2";
            this.txtSetRandomPhase2.Size = new System.Drawing.Size(374, 20);
            this.txtSetRandomPhase2.TabIndex = 2;
            this.txtSetRandomPhase2.Leave += new System.EventHandler(this.txtSetRandomPhase2_Leave);
            // 
            // lblSetRandomPhaseTooltip
            // 
            this.lblSetRandomPhaseTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetRandomPhaseTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetRandomPhaseTooltip.Name = "lblSetRandomPhaseTooltip";
            this.lblSetRandomPhaseTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetRandomPhaseTooltip.TabIndex = 0;
            this.lblSetRandomPhaseTooltip.Text = "Randomly chooses one of the provided values and sets the Creature\'s AI phase to i" +
    "t. Can only be used on creatures with EventAI.";
            // 
            // frmCommandFlee
            // 
            this.frmCommandFlee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandFlee.Controls.Add(this.cmbFleeMode);
            this.frmCommandFlee.Controls.Add(this.lblFleeMode);
            this.frmCommandFlee.Controls.Add(this.lblFleeTooltip);
            this.frmCommandFlee.Location = new System.Drawing.Point(410, 252);
            this.frmCommandFlee.Name = "frmCommandFlee";
            this.frmCommandFlee.Size = new System.Drawing.Size(495, 332);
            this.frmCommandFlee.TabIndex = 51;
            this.frmCommandFlee.Visible = false;
            // 
            // cmbFleeMode
            // 
            this.cmbFleeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFleeMode.FormattingEnabled = true;
            this.cmbFleeMode.Location = new System.Drawing.Point(99, 58);
            this.cmbFleeMode.Name = "cmbFleeMode";
            this.cmbFleeMode.Size = new System.Drawing.Size(374, 21);
            this.cmbFleeMode.TabIndex = 2;
            this.cmbFleeMode.SelectedIndexChanged += new System.EventHandler(this.cmbFleeMode_SelectedIndexChanged);
            // 
            // lblFleeMode
            // 
            this.lblFleeMode.AutoSize = true;
            this.lblFleeMode.Location = new System.Drawing.Point(58, 61);
            this.lblFleeMode.Name = "lblFleeMode";
            this.lblFleeMode.Size = new System.Drawing.Size(37, 13);
            this.lblFleeMode.TabIndex = 1;
            this.lblFleeMode.Text = "Mode:";
            // 
            // lblFleeTooltip
            // 
            this.lblFleeTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFleeTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblFleeTooltip.Name = "lblFleeTooltip";
            this.lblFleeTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblFleeTooltip.TabIndex = 0;
            this.lblFleeTooltip.Text = "The source Creature attempts to flee from the attacker.";
            // 
            // frmCommandCallForHelp
            // 
            this.frmCommandCallForHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandCallForHelp.Controls.Add(this.lblCallForHelpRadius);
            this.frmCommandCallForHelp.Controls.Add(this.txtCallForHelpRadius);
            this.frmCommandCallForHelp.Controls.Add(this.lblCallForHelpTooltip);
            this.frmCommandCallForHelp.Location = new System.Drawing.Point(410, 252);
            this.frmCommandCallForHelp.Name = "frmCommandCallForHelp";
            this.frmCommandCallForHelp.Size = new System.Drawing.Size(495, 332);
            this.frmCommandCallForHelp.TabIndex = 52;
            this.frmCommandCallForHelp.Visible = false;
            // 
            // lblCallForHelpRadius
            // 
            this.lblCallForHelpRadius.AutoSize = true;
            this.lblCallForHelpRadius.Location = new System.Drawing.Point(52, 61);
            this.lblCallForHelpRadius.Name = "lblCallForHelpRadius";
            this.lblCallForHelpRadius.Size = new System.Drawing.Size(43, 13);
            this.lblCallForHelpRadius.TabIndex = 2;
            this.lblCallForHelpRadius.Text = "Radius:";
            // 
            // txtCallForHelpRadius
            // 
            this.txtCallForHelpRadius.Location = new System.Drawing.Point(99, 58);
            this.txtCallForHelpRadius.Name = "txtCallForHelpRadius";
            this.txtCallForHelpRadius.Size = new System.Drawing.Size(374, 20);
            this.txtCallForHelpRadius.TabIndex = 1;
            this.txtCallForHelpRadius.Leave += new System.EventHandler(this.txtCallForHelpRadius_Leave);
            // 
            // lblCallForHelpTooltip
            // 
            this.lblCallForHelpTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCallForHelpTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblCallForHelpTooltip.Name = "lblCallForHelpTooltip";
            this.lblCallForHelpTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblCallForHelpTooltip.TabIndex = 0;
            this.lblCallForHelpTooltip.Text = "Calls any friendly creatures in the specified radius to attack the source Creatur" +
    "e\'s target.";
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
            this.frmCommandGameEvent.Location = new System.Drawing.Point(410, 252);
            this.frmCommandGameEvent.Name = "frmCommandGameEvent";
            this.frmCommandGameEvent.Size = new System.Drawing.Size(495, 332);
            this.frmCommandGameEvent.TabIndex = 53;
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
            this.cmbGameEventOverwrite.SelectedIndexChanged += new System.EventHandler(this.cmbGameEventOverwrite_SelectedIndexChanged);
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
            this.cmbGameEventAction.SelectedIndexChanged += new System.EventHandler(this.cmbGameEventAction_SelectedIndexChanged);
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
            this.btnGameEventId.Click += new System.EventHandler(this.btnGameEventId_Click);
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
            // frmCommandSetSpellsList
            // 
            this.frmCommandSetSpellsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetSpellsList.Controls.Add(this.btnSetSpellsList4);
            this.frmCommandSetSpellsList.Controls.Add(this.txtSetSpellsListChance4);
            this.frmCommandSetSpellsList.Controls.Add(this.btnSetSpellsList3);
            this.frmCommandSetSpellsList.Controls.Add(this.txtSetSpellsListChance3);
            this.frmCommandSetSpellsList.Controls.Add(this.btnSetSpellsList2);
            this.frmCommandSetSpellsList.Controls.Add(this.txtSetSpellsListChance2);
            this.frmCommandSetSpellsList.Controls.Add(this.btnSetSpellsList1);
            this.frmCommandSetSpellsList.Controls.Add(this.txtSetSpellsListChance1);
            this.frmCommandSetSpellsList.Controls.Add(this.lblSetSpellsListChance);
            this.frmCommandSetSpellsList.Controls.Add(this.lblSetSpellsListId);
            this.frmCommandSetSpellsList.Controls.Add(this.lblSetSpellsListTooltip);
            this.frmCommandSetSpellsList.Location = new System.Drawing.Point(410, 252);
            this.frmCommandSetSpellsList.Name = "frmCommandSetSpellsList";
            this.frmCommandSetSpellsList.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetSpellsList.TabIndex = 54;
            this.frmCommandSetSpellsList.Visible = false;
            // 
            // btnSetSpellsList4
            // 
            this.btnSetSpellsList4.Location = new System.Drawing.Point(19, 181);
            this.btnSetSpellsList4.Name = "btnSetSpellsList4";
            this.btnSetSpellsList4.Size = new System.Drawing.Size(334, 23);
            this.btnSetSpellsList4.TabIndex = 31;
            this.btnSetSpellsList4.Text = "-NONE-";
            this.btnSetSpellsList4.UseVisualStyleBackColor = true;
            this.btnSetSpellsList4.Click += new System.EventHandler(this.btnSetSpellsTemplate4_Click);
            // 
            // txtSetSpellsListChance4
            // 
            this.txtSetSpellsListChance4.Location = new System.Drawing.Point(359, 182);
            this.txtSetSpellsListChance4.Name = "txtSetSpellsListChance4";
            this.txtSetSpellsListChance4.Size = new System.Drawing.Size(114, 20);
            this.txtSetSpellsListChance4.TabIndex = 30;
            this.txtSetSpellsListChance4.Leave += new System.EventHandler(this.txtSetSpellsTemplateChance4_Leave);
            // 
            // btnSetSpellsList3
            // 
            this.btnSetSpellsList3.Location = new System.Drawing.Point(19, 149);
            this.btnSetSpellsList3.Name = "btnSetSpellsList3";
            this.btnSetSpellsList3.Size = new System.Drawing.Size(334, 23);
            this.btnSetSpellsList3.TabIndex = 29;
            this.btnSetSpellsList3.Text = "-NONE-";
            this.btnSetSpellsList3.UseVisualStyleBackColor = true;
            this.btnSetSpellsList3.Click += new System.EventHandler(this.btnSetSpellsTemplate3_Click);
            // 
            // txtSetSpellsListChance3
            // 
            this.txtSetSpellsListChance3.Location = new System.Drawing.Point(359, 150);
            this.txtSetSpellsListChance3.Name = "txtSetSpellsListChance3";
            this.txtSetSpellsListChance3.Size = new System.Drawing.Size(114, 20);
            this.txtSetSpellsListChance3.TabIndex = 28;
            this.txtSetSpellsListChance3.Leave += new System.EventHandler(this.txtSetSpellsTemplateChance3_Leave);
            // 
            // btnSetSpellsList2
            // 
            this.btnSetSpellsList2.Location = new System.Drawing.Point(19, 117);
            this.btnSetSpellsList2.Name = "btnSetSpellsList2";
            this.btnSetSpellsList2.Size = new System.Drawing.Size(334, 23);
            this.btnSetSpellsList2.TabIndex = 27;
            this.btnSetSpellsList2.Text = "-NONE-";
            this.btnSetSpellsList2.UseVisualStyleBackColor = true;
            this.btnSetSpellsList2.Click += new System.EventHandler(this.btnSetSpellsTemplate2_Click);
            // 
            // txtSetSpellsListChance2
            // 
            this.txtSetSpellsListChance2.Location = new System.Drawing.Point(359, 118);
            this.txtSetSpellsListChance2.Name = "txtSetSpellsListChance2";
            this.txtSetSpellsListChance2.Size = new System.Drawing.Size(114, 20);
            this.txtSetSpellsListChance2.TabIndex = 26;
            this.txtSetSpellsListChance2.Leave += new System.EventHandler(this.txtSetSpellsTemplateChance2_Leave);
            // 
            // btnSetSpellsList1
            // 
            this.btnSetSpellsList1.Location = new System.Drawing.Point(19, 85);
            this.btnSetSpellsList1.Name = "btnSetSpellsList1";
            this.btnSetSpellsList1.Size = new System.Drawing.Size(334, 23);
            this.btnSetSpellsList1.TabIndex = 25;
            this.btnSetSpellsList1.Text = "-NONE-";
            this.btnSetSpellsList1.UseVisualStyleBackColor = true;
            this.btnSetSpellsList1.Click += new System.EventHandler(this.btnSetSpellsTemplate1_Click);
            // 
            // txtSetSpellsListChance1
            // 
            this.txtSetSpellsListChance1.Location = new System.Drawing.Point(359, 86);
            this.txtSetSpellsListChance1.Name = "txtSetSpellsListChance1";
            this.txtSetSpellsListChance1.Size = new System.Drawing.Size(114, 20);
            this.txtSetSpellsListChance1.TabIndex = 14;
            this.txtSetSpellsListChance1.Leave += new System.EventHandler(this.txtSetSpellsTemplateChance1_Leave);
            // 
            // lblSetSpellsListChance
            // 
            this.lblSetSpellsListChance.AutoSize = true;
            this.lblSetSpellsListChance.Location = new System.Drawing.Point(364, 63);
            this.lblSetSpellsListChance.Name = "lblSetSpellsListChance";
            this.lblSetSpellsListChance.Size = new System.Drawing.Size(86, 13);
            this.lblSetSpellsListChance.TabIndex = 12;
            this.lblSetSpellsListChance.Text = "Percent chance:";
            // 
            // lblSetSpellsListId
            // 
            this.lblSetSpellsListId.AutoSize = true;
            this.lblSetSpellsListId.Location = new System.Drawing.Point(22, 63);
            this.lblSetSpellsListId.Name = "lblSetSpellsListId";
            this.lblSetSpellsListId.Size = new System.Drawing.Size(71, 13);
            this.lblSetSpellsListId.TabIndex = 11;
            this.lblSetSpellsListId.Text = "Spells List ID:";
            // 
            // lblSetSpellsListTooltip
            // 
            this.lblSetSpellsListTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetSpellsListTooltip.Location = new System.Drawing.Point(19, 10);
            this.lblSetSpellsListTooltip.Name = "lblSetSpellsListTooltip";
            this.lblSetSpellsListTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetSpellsListTooltip.TabIndex = 10;
            this.lblSetSpellsListTooltip.Text = "Sets the source Creature\'s current spells list.";
            // 
            // frmCommandSpellCooldown
            // 
            this.frmCommandSpellCooldown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSpellCooldown.Controls.Add(this.lblSpellCooldownSeconds);
            this.frmCommandSpellCooldown.Controls.Add(this.txtSpellCooldownSeconds);
            this.frmCommandSpellCooldown.Controls.Add(this.btnSpellCooldownId);
            this.frmCommandSpellCooldown.Controls.Add(this.lblSpellCooldownId);
            this.frmCommandSpellCooldown.Controls.Add(this.lblSpellCooldownTooltip);
            this.frmCommandSpellCooldown.Location = new System.Drawing.Point(410, 252);
            this.frmCommandSpellCooldown.Name = "frmCommandSpellCooldown";
            this.frmCommandSpellCooldown.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSpellCooldown.TabIndex = 55;
            this.frmCommandSpellCooldown.Visible = false;
            // 
            // lblSpellCooldownSeconds
            // 
            this.lblSpellCooldownSeconds.AutoSize = true;
            this.lblSpellCooldownSeconds.Location = new System.Drawing.Point(44, 93);
            this.lblSpellCooldownSeconds.Name = "lblSpellCooldownSeconds";
            this.lblSpellCooldownSeconds.Size = new System.Drawing.Size(52, 13);
            this.lblSpellCooldownSeconds.TabIndex = 4;
            this.lblSpellCooldownSeconds.Text = "Seconds:";
            // 
            // txtSpellCooldownSeconds
            // 
            this.txtSpellCooldownSeconds.Location = new System.Drawing.Point(99, 90);
            this.txtSpellCooldownSeconds.Name = "txtSpellCooldownSeconds";
            this.txtSpellCooldownSeconds.Size = new System.Drawing.Size(374, 20);
            this.txtSpellCooldownSeconds.TabIndex = 3;
            this.txtSpellCooldownSeconds.Leave += new System.EventHandler(this.txtSpellCooldownSeconds_Leave);
            // 
            // btnSpellCooldownId
            // 
            this.btnSpellCooldownId.Location = new System.Drawing.Point(99, 58);
            this.btnSpellCooldownId.Name = "btnSpellCooldownId";
            this.btnSpellCooldownId.Size = new System.Drawing.Size(374, 23);
            this.btnSpellCooldownId.TabIndex = 2;
            this.btnSpellCooldownId.Text = "-NONE-";
            this.btnSpellCooldownId.UseVisualStyleBackColor = true;
            this.btnSpellCooldownId.Click += new System.EventHandler(this.btnSpellCooldownId_Click);
            // 
            // lblSpellCooldownId
            // 
            this.lblSpellCooldownId.AutoSize = true;
            this.lblSpellCooldownId.Location = new System.Drawing.Point(51, 61);
            this.lblSpellCooldownId.Name = "lblSpellCooldownId";
            this.lblSpellCooldownId.Size = new System.Drawing.Size(45, 13);
            this.lblSpellCooldownId.TabIndex = 1;
            this.lblSpellCooldownId.Text = "Spell Id:";
            // 
            // lblSpellCooldownTooltip
            // 
            this.lblSpellCooldownTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSpellCooldownTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSpellCooldownTooltip.Name = "lblSpellCooldownTooltip";
            this.lblSpellCooldownTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSpellCooldownTooltip.TabIndex = 0;
            this.lblSpellCooldownTooltip.Text = "Adds a spell cooldown lasting a specified amount of time to the source Unit.";
            // 
            // frmCommandSetReactState
            // 
            this.frmCommandSetReactState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetReactState.Controls.Add(this.cmbSetReactState);
            this.frmCommandSetReactState.Controls.Add(this.lblReactState);
            this.frmCommandSetReactState.Controls.Add(this.lblSetReactStateTooltip);
            this.frmCommandSetReactState.Location = new System.Drawing.Point(410, 252);
            this.frmCommandSetReactState.Name = "frmCommandSetReactState";
            this.frmCommandSetReactState.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetReactState.TabIndex = 56;
            this.frmCommandSetReactState.Visible = false;
            // 
            // cmbSetReactState
            // 
            this.cmbSetReactState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetReactState.FormattingEnabled = true;
            this.cmbSetReactState.Items.AddRange(new object[] {
            "REACT_PASSIVE",
            "REACT_DEFENSIVE",
            "REACT_AGGRESSIVE"});
            this.cmbSetReactState.Location = new System.Drawing.Point(99, 58);
            this.cmbSetReactState.Name = "cmbSetReactState";
            this.cmbSetReactState.Size = new System.Drawing.Size(374, 21);
            this.cmbSetReactState.TabIndex = 2;
            this.cmbSetReactState.SelectedIndexChanged += new System.EventHandler(this.cmbSetReactState_SelectedIndexChanged);
            // 
            // lblReactState
            // 
            this.lblReactState.AutoSize = true;
            this.lblReactState.Location = new System.Drawing.Point(29, 61);
            this.lblReactState.Name = "lblReactState";
            this.lblReactState.Size = new System.Drawing.Size(67, 13);
            this.lblReactState.TabIndex = 1;
            this.lblReactState.Text = "React State:";
            // 
            // lblSetReactStateTooltip
            // 
            this.lblSetReactStateTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetReactStateTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetReactStateTooltip.Name = "lblSetReactStateTooltip";
            this.lblSetReactStateTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetReactStateTooltip.TabIndex = 0;
            this.lblSetReactStateTooltip.Text = "Changes the source Creature\'s current react state.";
            // 
            // frmCommandStartWaypoints
            // 
            this.frmCommandStartWaypoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandStartWaypoints.Controls.Add(this.txtStartWaypointsEntry);
            this.frmCommandStartWaypoints.Controls.Add(this.lblStartWaypointsEntry);
            this.frmCommandStartWaypoints.Controls.Add(this.txtStartWaypointsGuid);
            this.frmCommandStartWaypoints.Controls.Add(this.lblStartWaypointsGuid);
            this.frmCommandStartWaypoints.Controls.Add(this.txtStartWaypointsInitialDelay);
            this.frmCommandStartWaypoints.Controls.Add(this.lblStartWaypointsInitialDelay);
            this.frmCommandStartWaypoints.Controls.Add(this.txtStartWaypointsStartPoint);
            this.frmCommandStartWaypoints.Controls.Add(this.lblStartWaypointsStartPoint);
            this.frmCommandStartWaypoints.Controls.Add(this.cmbStartWaypointsRepeat);
            this.frmCommandStartWaypoints.Controls.Add(this.lblStartWaypointsRepeat);
            this.frmCommandStartWaypoints.Controls.Add(this.cmbStartWaypointsSource);
            this.frmCommandStartWaypoints.Controls.Add(this.lblStartWaypointsSource);
            this.frmCommandStartWaypoints.Controls.Add(this.lblStartWaypointsTooltip);
            this.frmCommandStartWaypoints.Location = new System.Drawing.Point(410, 252);
            this.frmCommandStartWaypoints.Name = "frmCommandStartWaypoints";
            this.frmCommandStartWaypoints.Size = new System.Drawing.Size(495, 332);
            this.frmCommandStartWaypoints.TabIndex = 57;
            this.frmCommandStartWaypoints.Visible = false;
            // 
            // txtStartWaypointsEntry
            // 
            this.txtStartWaypointsEntry.Location = new System.Drawing.Point(99, 205);
            this.txtStartWaypointsEntry.Name = "txtStartWaypointsEntry";
            this.txtStartWaypointsEntry.Size = new System.Drawing.Size(374, 20);
            this.txtStartWaypointsEntry.TabIndex = 13;
            this.txtStartWaypointsEntry.Leave += new System.EventHandler(this.txtStartWaypointsEntry_Leave);
            // 
            // lblStartWaypointsEntry
            // 
            this.lblStartWaypointsEntry.AutoSize = true;
            this.lblStartWaypointsEntry.Location = new System.Drawing.Point(62, 208);
            this.lblStartWaypointsEntry.Name = "lblStartWaypointsEntry";
            this.lblStartWaypointsEntry.Size = new System.Drawing.Size(34, 13);
            this.lblStartWaypointsEntry.TabIndex = 12;
            this.lblStartWaypointsEntry.Text = "Entry:";
            // 
            // txtStartWaypointsGuid
            // 
            this.txtStartWaypointsGuid.Location = new System.Drawing.Point(99, 176);
            this.txtStartWaypointsGuid.Name = "txtStartWaypointsGuid";
            this.txtStartWaypointsGuid.Size = new System.Drawing.Size(374, 20);
            this.txtStartWaypointsGuid.TabIndex = 11;
            this.txtStartWaypointsGuid.Leave += new System.EventHandler(this.txtStartWaypointsGuid_Leave);
            // 
            // lblStartWaypointsGuid
            // 
            this.lblStartWaypointsGuid.AutoSize = true;
            this.lblStartWaypointsGuid.Location = new System.Drawing.Point(64, 179);
            this.lblStartWaypointsGuid.Name = "lblStartWaypointsGuid";
            this.lblStartWaypointsGuid.Size = new System.Drawing.Size(32, 13);
            this.lblStartWaypointsGuid.TabIndex = 10;
            this.lblStartWaypointsGuid.Text = "Guid:";
            // 
            // txtStartWaypointsInitialDelay
            // 
            this.txtStartWaypointsInitialDelay.Location = new System.Drawing.Point(99, 147);
            this.txtStartWaypointsInitialDelay.Name = "txtStartWaypointsInitialDelay";
            this.txtStartWaypointsInitialDelay.Size = new System.Drawing.Size(374, 20);
            this.txtStartWaypointsInitialDelay.TabIndex = 9;
            this.txtStartWaypointsInitialDelay.Leave += new System.EventHandler(this.txtStartWaypointsInitialDelay_Leave);
            // 
            // lblStartWaypointsInitialDelay
            // 
            this.lblStartWaypointsInitialDelay.AutoSize = true;
            this.lblStartWaypointsInitialDelay.Location = new System.Drawing.Point(32, 150);
            this.lblStartWaypointsInitialDelay.Name = "lblStartWaypointsInitialDelay";
            this.lblStartWaypointsInitialDelay.Size = new System.Drawing.Size(64, 13);
            this.lblStartWaypointsInitialDelay.TabIndex = 8;
            this.lblStartWaypointsInitialDelay.Text = "Initial Delay:";
            // 
            // txtStartWaypointsStartPoint
            // 
            this.txtStartWaypointsStartPoint.Location = new System.Drawing.Point(99, 118);
            this.txtStartWaypointsStartPoint.Name = "txtStartWaypointsStartPoint";
            this.txtStartWaypointsStartPoint.Size = new System.Drawing.Size(374, 20);
            this.txtStartWaypointsStartPoint.TabIndex = 7;
            this.txtStartWaypointsStartPoint.Leave += new System.EventHandler(this.txtStartWaypointsStartPoint_Leave);
            // 
            // lblStartWaypointsStartPoint
            // 
            this.lblStartWaypointsStartPoint.AutoSize = true;
            this.lblStartWaypointsStartPoint.Location = new System.Drawing.Point(37, 121);
            this.lblStartWaypointsStartPoint.Name = "lblStartWaypointsStartPoint";
            this.lblStartWaypointsStartPoint.Size = new System.Drawing.Size(59, 13);
            this.lblStartWaypointsStartPoint.TabIndex = 5;
            this.lblStartWaypointsStartPoint.Text = "Start Point:";
            // 
            // cmbStartWaypointsRepeat
            // 
            this.cmbStartWaypointsRepeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartWaypointsRepeat.FormattingEnabled = true;
            this.cmbStartWaypointsRepeat.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbStartWaypointsRepeat.Location = new System.Drawing.Point(99, 88);
            this.cmbStartWaypointsRepeat.Name = "cmbStartWaypointsRepeat";
            this.cmbStartWaypointsRepeat.Size = new System.Drawing.Size(374, 21);
            this.cmbStartWaypointsRepeat.TabIndex = 4;
            this.cmbStartWaypointsRepeat.SelectedIndexChanged += new System.EventHandler(this.cmbStartWaypointsRepeat_SelectedIndexChanged);
            // 
            // lblStartWaypointsRepeat
            // 
            this.lblStartWaypointsRepeat.AutoSize = true;
            this.lblStartWaypointsRepeat.Location = new System.Drawing.Point(51, 91);
            this.lblStartWaypointsRepeat.Name = "lblStartWaypointsRepeat";
            this.lblStartWaypointsRepeat.Size = new System.Drawing.Size(45, 13);
            this.lblStartWaypointsRepeat.TabIndex = 3;
            this.lblStartWaypointsRepeat.Text = "Repeat:";
            // 
            // cmbStartWaypointsSource
            // 
            this.cmbStartWaypointsSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartWaypointsSource.FormattingEnabled = true;
            this.cmbStartWaypointsSource.Items.AddRange(new object[] {
            "(Decide Automatically)",
            "PATH_FROM_GUID",
            "PATH_FROM_ENTRY",
            "PATH_FROM_SPECIAL"});
            this.cmbStartWaypointsSource.Location = new System.Drawing.Point(99, 58);
            this.cmbStartWaypointsSource.Name = "cmbStartWaypointsSource";
            this.cmbStartWaypointsSource.Size = new System.Drawing.Size(374, 21);
            this.cmbStartWaypointsSource.TabIndex = 2;
            this.cmbStartWaypointsSource.SelectedIndexChanged += new System.EventHandler(this.cmbStartWaypointsSource_SelectedIndexChanged);
            // 
            // lblStartWaypointsSource
            // 
            this.lblStartWaypointsSource.AutoSize = true;
            this.lblStartWaypointsSource.Location = new System.Drawing.Point(52, 61);
            this.lblStartWaypointsSource.Name = "lblStartWaypointsSource";
            this.lblStartWaypointsSource.Size = new System.Drawing.Size(44, 13);
            this.lblStartWaypointsSource.TabIndex = 1;
            this.lblStartWaypointsSource.Text = "Source:";
            // 
            // lblStartWaypointsTooltip
            // 
            this.lblStartWaypointsTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStartWaypointsTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblStartWaypointsTooltip.Name = "lblStartWaypointsTooltip";
            this.lblStartWaypointsTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblStartWaypointsTooltip.TabIndex = 0;
            this.lblStartWaypointsTooltip.Text = "The source Creature begins waypoint movement. Guid and Entry can be overriden to " +
    "take waypoints from another npc.";
            // 
            // frmCommandStartScriptedMapEvent
            // 
            this.frmCommandStartScriptedMapEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandStartScriptedMapEvent.Controls.Add(this.btnStartScriptedMapEventFailureScriptEdit);
            this.frmCommandStartScriptedMapEvent.Controls.Add(this.btnStartScriptedMapEventSuccessScriptEdit);
            this.frmCommandStartScriptedMapEvent.Controls.Add(this.lblStartScriptedMapEventFailureScript);
            this.frmCommandStartScriptedMapEvent.Controls.Add(this.btnStartScriptedMapEventFailureCondition);
            this.frmCommandStartScriptedMapEvent.Controls.Add(this.txtStartScriptedMapEventFailureScript);
            this.frmCommandStartScriptedMapEvent.Controls.Add(this.lblStartScriptedMapEventFailureCondition);
            this.frmCommandStartScriptedMapEvent.Controls.Add(this.lblStartScriptedMapEventSuccessScript);
            this.frmCommandStartScriptedMapEvent.Controls.Add(this.btnStartScriptedMapEventSuccessCondition);
            this.frmCommandStartScriptedMapEvent.Controls.Add(this.txtStartScriptedMapEventTimeLimit);
            this.frmCommandStartScriptedMapEvent.Controls.Add(this.lblStartScriptedMapEventTimeLimit);
            this.frmCommandStartScriptedMapEvent.Controls.Add(this.txtStartScriptedMapEventId);
            this.frmCommandStartScriptedMapEvent.Controls.Add(this.lblStartScriptedMapEventId);
            this.frmCommandStartScriptedMapEvent.Controls.Add(this.txtStartScriptedMapEventSuccessScript);
            this.frmCommandStartScriptedMapEvent.Controls.Add(this.lblStartScriptedMapEventSuccessCondition);
            this.frmCommandStartScriptedMapEvent.Controls.Add(this.lblStartScriptedMapEventTooltip);
            this.frmCommandStartScriptedMapEvent.Location = new System.Drawing.Point(410, 252);
            this.frmCommandStartScriptedMapEvent.Name = "frmCommandStartScriptedMapEvent";
            this.frmCommandStartScriptedMapEvent.Size = new System.Drawing.Size(495, 332);
            this.frmCommandStartScriptedMapEvent.TabIndex = 58;
            this.frmCommandStartScriptedMapEvent.Visible = false;
            // 
            // btnStartScriptedMapEventFailureScriptEdit
            // 
            this.btnStartScriptedMapEventFailureScriptEdit.Location = new System.Drawing.Point(430, 117);
            this.btnStartScriptedMapEventFailureScriptEdit.Name = "btnStartScriptedMapEventFailureScriptEdit";
            this.btnStartScriptedMapEventFailureScriptEdit.Size = new System.Drawing.Size(41, 21);
            this.btnStartScriptedMapEventFailureScriptEdit.TabIndex = 21;
            this.btnStartScriptedMapEventFailureScriptEdit.Text = "Edit";
            this.btnStartScriptedMapEventFailureScriptEdit.UseVisualStyleBackColor = true;
            this.btnStartScriptedMapEventFailureScriptEdit.Click += new System.EventHandler(this.btnStartScriptedMapEventFailureScriptEdit_Click);
            // 
            // btnStartScriptedMapEventSuccessScriptEdit
            // 
            this.btnStartScriptedMapEventSuccessScriptEdit.Location = new System.Drawing.Point(430, 73);
            this.btnStartScriptedMapEventSuccessScriptEdit.Name = "btnStartScriptedMapEventSuccessScriptEdit";
            this.btnStartScriptedMapEventSuccessScriptEdit.Size = new System.Drawing.Size(41, 21);
            this.btnStartScriptedMapEventSuccessScriptEdit.TabIndex = 20;
            this.btnStartScriptedMapEventSuccessScriptEdit.Text = "Edit";
            this.btnStartScriptedMapEventSuccessScriptEdit.UseVisualStyleBackColor = true;
            this.btnStartScriptedMapEventSuccessScriptEdit.Click += new System.EventHandler(this.btnStartScriptedMapEventSuccessScriptEdit_Click);
            // 
            // lblStartScriptedMapEventFailureScript
            // 
            this.lblStartScriptedMapEventFailureScript.AutoSize = true;
            this.lblStartScriptedMapEventFailureScript.Location = new System.Drawing.Point(232, 101);
            this.lblStartScriptedMapEventFailureScript.Name = "lblStartScriptedMapEventFailureScript";
            this.lblStartScriptedMapEventFailureScript.Size = new System.Drawing.Size(71, 13);
            this.lblStartScriptedMapEventFailureScript.TabIndex = 19;
            this.lblStartScriptedMapEventFailureScript.Text = "Failure Script:";
            // 
            // btnStartScriptedMapEventFailureCondition
            // 
            this.btnStartScriptedMapEventFailureCondition.Location = new System.Drawing.Point(24, 117);
            this.btnStartScriptedMapEventFailureCondition.Name = "btnStartScriptedMapEventFailureCondition";
            this.btnStartScriptedMapEventFailureCondition.Size = new System.Drawing.Size(195, 21);
            this.btnStartScriptedMapEventFailureCondition.TabIndex = 18;
            this.btnStartScriptedMapEventFailureCondition.Text = "-NONE-";
            this.btnStartScriptedMapEventFailureCondition.UseVisualStyleBackColor = true;
            this.btnStartScriptedMapEventFailureCondition.Click += new System.EventHandler(this.btnStartScriptedMapEventFailureCondition_Click);
            // 
            // txtStartScriptedMapEventFailureScript
            // 
            this.txtStartScriptedMapEventFailureScript.Location = new System.Drawing.Point(229, 118);
            this.txtStartScriptedMapEventFailureScript.Name = "txtStartScriptedMapEventFailureScript";
            this.txtStartScriptedMapEventFailureScript.Size = new System.Drawing.Size(195, 20);
            this.txtStartScriptedMapEventFailureScript.TabIndex = 17;
            this.txtStartScriptedMapEventFailureScript.Leave += new System.EventHandler(this.txtStartScriptedMapEventFailureScript_Leave);
            // 
            // lblStartScriptedMapEventFailureCondition
            // 
            this.lblStartScriptedMapEventFailureCondition.AutoSize = true;
            this.lblStartScriptedMapEventFailureCondition.Location = new System.Drawing.Point(27, 100);
            this.lblStartScriptedMapEventFailureCondition.Name = "lblStartScriptedMapEventFailureCondition";
            this.lblStartScriptedMapEventFailureCondition.Size = new System.Drawing.Size(88, 13);
            this.lblStartScriptedMapEventFailureCondition.TabIndex = 16;
            this.lblStartScriptedMapEventFailureCondition.Text = "Failure Condition:";
            // 
            // lblStartScriptedMapEventSuccessScript
            // 
            this.lblStartScriptedMapEventSuccessScript.AutoSize = true;
            this.lblStartScriptedMapEventSuccessScript.Location = new System.Drawing.Point(232, 57);
            this.lblStartScriptedMapEventSuccessScript.Name = "lblStartScriptedMapEventSuccessScript";
            this.lblStartScriptedMapEventSuccessScript.Size = new System.Drawing.Size(81, 13);
            this.lblStartScriptedMapEventSuccessScript.TabIndex = 15;
            this.lblStartScriptedMapEventSuccessScript.Text = "Success Script:";
            // 
            // btnStartScriptedMapEventSuccessCondition
            // 
            this.btnStartScriptedMapEventSuccessCondition.Location = new System.Drawing.Point(24, 73);
            this.btnStartScriptedMapEventSuccessCondition.Name = "btnStartScriptedMapEventSuccessCondition";
            this.btnStartScriptedMapEventSuccessCondition.Size = new System.Drawing.Size(195, 21);
            this.btnStartScriptedMapEventSuccessCondition.TabIndex = 14;
            this.btnStartScriptedMapEventSuccessCondition.Text = "-NONE-";
            this.btnStartScriptedMapEventSuccessCondition.UseVisualStyleBackColor = true;
            this.btnStartScriptedMapEventSuccessCondition.Click += new System.EventHandler(this.btnStartScriptedMapEventSuccessCondition_Click);
            // 
            // txtStartScriptedMapEventTimeLimit
            // 
            this.txtStartScriptedMapEventTimeLimit.Location = new System.Drawing.Point(99, 181);
            this.txtStartScriptedMapEventTimeLimit.Name = "txtStartScriptedMapEventTimeLimit";
            this.txtStartScriptedMapEventTimeLimit.Size = new System.Drawing.Size(374, 20);
            this.txtStartScriptedMapEventTimeLimit.TabIndex = 11;
            this.txtStartScriptedMapEventTimeLimit.Leave += new System.EventHandler(this.txtStartScriptedMapEventTimeLimit_Leave);
            // 
            // lblStartScriptedMapEventTimeLimit
            // 
            this.lblStartScriptedMapEventTimeLimit.AutoSize = true;
            this.lblStartScriptedMapEventTimeLimit.Location = new System.Drawing.Point(39, 184);
            this.lblStartScriptedMapEventTimeLimit.Name = "lblStartScriptedMapEventTimeLimit";
            this.lblStartScriptedMapEventTimeLimit.Size = new System.Drawing.Size(57, 13);
            this.lblStartScriptedMapEventTimeLimit.TabIndex = 10;
            this.lblStartScriptedMapEventTimeLimit.Text = "Time Limit:";
            // 
            // txtStartScriptedMapEventId
            // 
            this.txtStartScriptedMapEventId.Location = new System.Drawing.Point(99, 152);
            this.txtStartScriptedMapEventId.Name = "txtStartScriptedMapEventId";
            this.txtStartScriptedMapEventId.Size = new System.Drawing.Size(374, 20);
            this.txtStartScriptedMapEventId.TabIndex = 9;
            this.txtStartScriptedMapEventId.Leave += new System.EventHandler(this.txtStartScriptedMapEventId_Leave);
            // 
            // lblStartScriptedMapEventId
            // 
            this.lblStartScriptedMapEventId.AutoSize = true;
            this.lblStartScriptedMapEventId.Location = new System.Drawing.Point(46, 155);
            this.lblStartScriptedMapEventId.Name = "lblStartScriptedMapEventId";
            this.lblStartScriptedMapEventId.Size = new System.Drawing.Size(50, 13);
            this.lblStartScriptedMapEventId.TabIndex = 8;
            this.lblStartScriptedMapEventId.Text = "Event Id:";
            // 
            // txtStartScriptedMapEventSuccessScript
            // 
            this.txtStartScriptedMapEventSuccessScript.Location = new System.Drawing.Point(229, 74);
            this.txtStartScriptedMapEventSuccessScript.Name = "txtStartScriptedMapEventSuccessScript";
            this.txtStartScriptedMapEventSuccessScript.Size = new System.Drawing.Size(195, 20);
            this.txtStartScriptedMapEventSuccessScript.TabIndex = 7;
            this.txtStartScriptedMapEventSuccessScript.Leave += new System.EventHandler(this.txtStartScriptedMapEventSuccessScript_Leave);
            // 
            // lblStartScriptedMapEventSuccessCondition
            // 
            this.lblStartScriptedMapEventSuccessCondition.AutoSize = true;
            this.lblStartScriptedMapEventSuccessCondition.Location = new System.Drawing.Point(27, 56);
            this.lblStartScriptedMapEventSuccessCondition.Name = "lblStartScriptedMapEventSuccessCondition";
            this.lblStartScriptedMapEventSuccessCondition.Size = new System.Drawing.Size(98, 13);
            this.lblStartScriptedMapEventSuccessCondition.TabIndex = 5;
            this.lblStartScriptedMapEventSuccessCondition.Text = "Success Condition:";
            // 
            // lblStartScriptedMapEventTooltip
            // 
            this.lblStartScriptedMapEventTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStartScriptedMapEventTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblStartScriptedMapEventTooltip.Name = "lblStartScriptedMapEventTooltip";
            this.lblStartScriptedMapEventTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblStartScriptedMapEventTooltip.TabIndex = 0;
            this.lblStartScriptedMapEventTooltip.Text = "Starts a scripted map event with the given Id, targets, conditions and scripts.";
            // 
            // frmCommandRemoveScriptedMapEventTarget
            // 
            this.frmCommandRemoveScriptedMapEventTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandRemoveScriptedMapEventTarget.Controls.Add(this.txtRemoveScriptedMapEventTargetEventId);
            this.frmCommandRemoveScriptedMapEventTarget.Controls.Add(this.cmbRemoveScriptedMapEventTarget);
            this.frmCommandRemoveScriptedMapEventTarget.Controls.Add(this.lblRemoveScriptedMapEventTarget);
            this.frmCommandRemoveScriptedMapEventTarget.Controls.Add(this.lblRemoveScriptedMapEventTargetCondition);
            this.frmCommandRemoveScriptedMapEventTarget.Controls.Add(this.lblRemoveScriptedMapEventTargetEventId);
            this.frmCommandRemoveScriptedMapEventTarget.Controls.Add(this.btnRemoveScriptedMapEventTargetCondition);
            this.frmCommandRemoveScriptedMapEventTarget.Controls.Add(this.label5);
            this.frmCommandRemoveScriptedMapEventTarget.Location = new System.Drawing.Point(410, 252);
            this.frmCommandRemoveScriptedMapEventTarget.Name = "frmCommandRemoveScriptedMapEventTarget";
            this.frmCommandRemoveScriptedMapEventTarget.Size = new System.Drawing.Size(495, 332);
            this.frmCommandRemoveScriptedMapEventTarget.TabIndex = 59;
            this.frmCommandRemoveScriptedMapEventTarget.Visible = false;
            // 
            // txtRemoveScriptedMapEventTargetEventId
            // 
            this.txtRemoveScriptedMapEventTargetEventId.Location = new System.Drawing.Point(99, 58);
            this.txtRemoveScriptedMapEventTargetEventId.Name = "txtRemoveScriptedMapEventTargetEventId";
            this.txtRemoveScriptedMapEventTargetEventId.Size = new System.Drawing.Size(374, 20);
            this.txtRemoveScriptedMapEventTargetEventId.TabIndex = 8;
            this.txtRemoveScriptedMapEventTargetEventId.Leave += new System.EventHandler(this.txtRemoveScriptedMapEventTargetEventId_Leave);
            // 
            // cmbRemoveScriptedMapEventTarget
            // 
            this.cmbRemoveScriptedMapEventTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRemoveScriptedMapEventTarget.FormattingEnabled = true;
            this.cmbRemoveScriptedMapEventTarget.Items.AddRange(new object[] {
            "Self",
            "One Matching Condition",
            "All Matching Condition",
            "All Targets"});
            this.cmbRemoveScriptedMapEventTarget.Location = new System.Drawing.Point(99, 120);
            this.cmbRemoveScriptedMapEventTarget.Name = "cmbRemoveScriptedMapEventTarget";
            this.cmbRemoveScriptedMapEventTarget.Size = new System.Drawing.Size(374, 21);
            this.cmbRemoveScriptedMapEventTarget.TabIndex = 7;
            this.cmbRemoveScriptedMapEventTarget.SelectedIndexChanged += new System.EventHandler(this.cmbRemoveScriptedMapEventTarget_SelectedIndexChanged);
            // 
            // lblRemoveScriptedMapEventTarget
            // 
            this.lblRemoveScriptedMapEventTarget.AutoSize = true;
            this.lblRemoveScriptedMapEventTarget.Location = new System.Drawing.Point(55, 123);
            this.lblRemoveScriptedMapEventTarget.Name = "lblRemoveScriptedMapEventTarget";
            this.lblRemoveScriptedMapEventTarget.Size = new System.Drawing.Size(41, 13);
            this.lblRemoveScriptedMapEventTarget.TabIndex = 6;
            this.lblRemoveScriptedMapEventTarget.Text = "Target:";
            // 
            // lblRemoveScriptedMapEventTargetCondition
            // 
            this.lblRemoveScriptedMapEventTargetCondition.AutoSize = true;
            this.lblRemoveScriptedMapEventTargetCondition.Location = new System.Drawing.Point(30, 93);
            this.lblRemoveScriptedMapEventTargetCondition.Name = "lblRemoveScriptedMapEventTargetCondition";
            this.lblRemoveScriptedMapEventTargetCondition.Size = new System.Drawing.Size(66, 13);
            this.lblRemoveScriptedMapEventTargetCondition.TabIndex = 4;
            this.lblRemoveScriptedMapEventTargetCondition.Text = "Condition Id:";
            // 
            // lblRemoveScriptedMapEventTargetEventId
            // 
            this.lblRemoveScriptedMapEventTargetEventId.AutoSize = true;
            this.lblRemoveScriptedMapEventTargetEventId.Location = new System.Drawing.Point(46, 61);
            this.lblRemoveScriptedMapEventTargetEventId.Name = "lblRemoveScriptedMapEventTargetEventId";
            this.lblRemoveScriptedMapEventTargetEventId.Size = new System.Drawing.Size(50, 13);
            this.lblRemoveScriptedMapEventTargetEventId.TabIndex = 3;
            this.lblRemoveScriptedMapEventTargetEventId.Text = "Event Id:";
            // 
            // btnRemoveScriptedMapEventTargetCondition
            // 
            this.btnRemoveScriptedMapEventTargetCondition.Location = new System.Drawing.Point(99, 90);
            this.btnRemoveScriptedMapEventTargetCondition.Name = "btnRemoveScriptedMapEventTargetCondition";
            this.btnRemoveScriptedMapEventTargetCondition.Size = new System.Drawing.Size(374, 23);
            this.btnRemoveScriptedMapEventTargetCondition.TabIndex = 1;
            this.btnRemoveScriptedMapEventTargetCondition.Text = "-NONE-";
            this.btnRemoveScriptedMapEventTargetCondition.UseVisualStyleBackColor = true;
            this.btnRemoveScriptedMapEventTargetCondition.Click += new System.EventHandler(this.btnRemoveScriptedMapEventTargetCondition_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(20, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(453, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Removes an additional WorldObject target from the scripted map event with the giv" +
    "en Id.";
            // 
            // frmCommandSetScriptedMapEventData
            // 
            this.frmCommandSetScriptedMapEventData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetScriptedMapEventData.Controls.Add(this.txtSetScriptedMapEventData);
            this.frmCommandSetScriptedMapEventData.Controls.Add(this.lblSetScriptedMapEventData);
            this.frmCommandSetScriptedMapEventData.Controls.Add(this.txtSetScriptedMapEventDataIndex);
            this.frmCommandSetScriptedMapEventData.Controls.Add(this.txtSetScriptedMapEventDataEventId);
            this.frmCommandSetScriptedMapEventData.Controls.Add(this.cmbSetScriptedMapEventDataMode);
            this.frmCommandSetScriptedMapEventData.Controls.Add(this.lblSetScriptedMapEventDataMode);
            this.frmCommandSetScriptedMapEventData.Controls.Add(this.lblSetScriptedMapEventDataIndex);
            this.frmCommandSetScriptedMapEventData.Controls.Add(this.lblSetScriptedMapEventDataEventId);
            this.frmCommandSetScriptedMapEventData.Controls.Add(this.lblSetScriptedMapEventDataTooltip);
            this.frmCommandSetScriptedMapEventData.Location = new System.Drawing.Point(410, 252);
            this.frmCommandSetScriptedMapEventData.Name = "frmCommandSetScriptedMapEventData";
            this.frmCommandSetScriptedMapEventData.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetScriptedMapEventData.TabIndex = 60;
            this.frmCommandSetScriptedMapEventData.Visible = false;
            // 
            // txtSetScriptedMapEventData
            // 
            this.txtSetScriptedMapEventData.Location = new System.Drawing.Point(99, 155);
            this.txtSetScriptedMapEventData.Name = "txtSetScriptedMapEventData";
            this.txtSetScriptedMapEventData.Size = new System.Drawing.Size(374, 20);
            this.txtSetScriptedMapEventData.TabIndex = 11;
            this.txtSetScriptedMapEventData.Leave += new System.EventHandler(this.txtSetScriptedMapEventData_Leave);
            // 
            // lblSetScriptedMapEventData
            // 
            this.lblSetScriptedMapEventData.AutoSize = true;
            this.lblSetScriptedMapEventData.Location = new System.Drawing.Point(62, 158);
            this.lblSetScriptedMapEventData.Name = "lblSetScriptedMapEventData";
            this.lblSetScriptedMapEventData.Size = new System.Drawing.Size(33, 13);
            this.lblSetScriptedMapEventData.TabIndex = 10;
            this.lblSetScriptedMapEventData.Text = "Data:";
            // 
            // txtSetScriptedMapEventDataIndex
            // 
            this.txtSetScriptedMapEventDataIndex.Location = new System.Drawing.Point(99, 90);
            this.txtSetScriptedMapEventDataIndex.Name = "txtSetScriptedMapEventDataIndex";
            this.txtSetScriptedMapEventDataIndex.Size = new System.Drawing.Size(374, 20);
            this.txtSetScriptedMapEventDataIndex.TabIndex = 9;
            this.txtSetScriptedMapEventDataIndex.Leave += new System.EventHandler(this.txtSetScriptedMapEventDataIndex_Leave);
            // 
            // txtSetScriptedMapEventDataEventId
            // 
            this.txtSetScriptedMapEventDataEventId.Location = new System.Drawing.Point(99, 58);
            this.txtSetScriptedMapEventDataEventId.Name = "txtSetScriptedMapEventDataEventId";
            this.txtSetScriptedMapEventDataEventId.Size = new System.Drawing.Size(374, 20);
            this.txtSetScriptedMapEventDataEventId.TabIndex = 8;
            this.txtSetScriptedMapEventDataEventId.Leave += new System.EventHandler(this.txtSetScriptedMapEventDataEventId_Leave);
            // 
            // cmbSetScriptedMapEventDataMode
            // 
            this.cmbSetScriptedMapEventDataMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetScriptedMapEventDataMode.FormattingEnabled = true;
            this.cmbSetScriptedMapEventDataMode.Items.AddRange(new object[] {
            "Save Raw Value",
            "Increment Existing Data",
            "Decrement Existing Data"});
            this.cmbSetScriptedMapEventDataMode.Location = new System.Drawing.Point(99, 122);
            this.cmbSetScriptedMapEventDataMode.Name = "cmbSetScriptedMapEventDataMode";
            this.cmbSetScriptedMapEventDataMode.Size = new System.Drawing.Size(374, 21);
            this.cmbSetScriptedMapEventDataMode.TabIndex = 7;
            this.cmbSetScriptedMapEventDataMode.SelectedIndexChanged += new System.EventHandler(this.cmbSetScriptedMapEventDataMode_SelectedIndexChanged);
            // 
            // lblSetScriptedMapEventDataMode
            // 
            this.lblSetScriptedMapEventDataMode.AutoSize = true;
            this.lblSetScriptedMapEventDataMode.Location = new System.Drawing.Point(58, 125);
            this.lblSetScriptedMapEventDataMode.Name = "lblSetScriptedMapEventDataMode";
            this.lblSetScriptedMapEventDataMode.Size = new System.Drawing.Size(37, 13);
            this.lblSetScriptedMapEventDataMode.TabIndex = 6;
            this.lblSetScriptedMapEventDataMode.Text = "Mode:";
            // 
            // lblSetScriptedMapEventDataIndex
            // 
            this.lblSetScriptedMapEventDataIndex.AutoSize = true;
            this.lblSetScriptedMapEventDataIndex.Location = new System.Drawing.Point(59, 93);
            this.lblSetScriptedMapEventDataIndex.Name = "lblSetScriptedMapEventDataIndex";
            this.lblSetScriptedMapEventDataIndex.Size = new System.Drawing.Size(36, 13);
            this.lblSetScriptedMapEventDataIndex.TabIndex = 4;
            this.lblSetScriptedMapEventDataIndex.Text = "Index:";
            // 
            // lblSetScriptedMapEventDataEventId
            // 
            this.lblSetScriptedMapEventDataEventId.AutoSize = true;
            this.lblSetScriptedMapEventDataEventId.Location = new System.Drawing.Point(45, 61);
            this.lblSetScriptedMapEventDataEventId.Name = "lblSetScriptedMapEventDataEventId";
            this.lblSetScriptedMapEventDataEventId.Size = new System.Drawing.Size(50, 13);
            this.lblSetScriptedMapEventDataEventId.TabIndex = 3;
            this.lblSetScriptedMapEventDataEventId.Text = "Event Id:";
            // 
            // lblSetScriptedMapEventDataTooltip
            // 
            this.lblSetScriptedMapEventDataTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetScriptedMapEventDataTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetScriptedMapEventDataTooltip.Name = "lblSetScriptedMapEventDataTooltip";
            this.lblSetScriptedMapEventDataTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetScriptedMapEventDataTooltip.TabIndex = 0;
            this.lblSetScriptedMapEventDataTooltip.Text = "Saves data to a scripted map event.";
            // 
            // frmCommandSetDefaultMovement
            // 
            this.frmCommandSetDefaultMovement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSetDefaultMovement.Controls.Add(this.cmbSetDefaultMovementAlwaysReplace);
            this.frmCommandSetDefaultMovement.Controls.Add(this.txtSetDefaultMovementParam1);
            this.frmCommandSetDefaultMovement.Controls.Add(this.cmbSetDefaultMovementType);
            this.frmCommandSetDefaultMovement.Controls.Add(this.lblSetDefaultMovementParam1);
            this.frmCommandSetDefaultMovement.Controls.Add(this.lblSetDefaultMovementAlwaysReplace);
            this.frmCommandSetDefaultMovement.Controls.Add(this.lblSetDefaultMovementType);
            this.frmCommandSetDefaultMovement.Controls.Add(this.lblSetDefaultMovementTooltip);
            this.frmCommandSetDefaultMovement.Location = new System.Drawing.Point(410, 252);
            this.frmCommandSetDefaultMovement.Name = "frmCommandSetDefaultMovement";
            this.frmCommandSetDefaultMovement.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSetDefaultMovement.TabIndex = 61;
            this.frmCommandSetDefaultMovement.Visible = false;
            // 
            // cmbSetDefaultMovementAlwaysReplace
            // 
            this.cmbSetDefaultMovementAlwaysReplace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetDefaultMovementAlwaysReplace.FormattingEnabled = true;
            this.cmbSetDefaultMovementAlwaysReplace.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbSetDefaultMovementAlwaysReplace.Location = new System.Drawing.Point(99, 90);
            this.cmbSetDefaultMovementAlwaysReplace.Name = "cmbSetDefaultMovementAlwaysReplace";
            this.cmbSetDefaultMovementAlwaysReplace.Size = new System.Drawing.Size(374, 21);
            this.cmbSetDefaultMovementAlwaysReplace.TabIndex = 12;
            this.cmbSetDefaultMovementAlwaysReplace.SelectedIndexChanged += new System.EventHandler(this.cmbSetDefaultMovementAlwaysReplace_SelectedIndexChanged);
            // 
            // txtSetDefaultMovementParam1
            // 
            this.txtSetDefaultMovementParam1.Location = new System.Drawing.Point(99, 122);
            this.txtSetDefaultMovementParam1.Name = "txtSetDefaultMovementParam1";
            this.txtSetDefaultMovementParam1.Size = new System.Drawing.Size(374, 20);
            this.txtSetDefaultMovementParam1.TabIndex = 11;
            this.txtSetDefaultMovementParam1.Leave += new System.EventHandler(this.txtSetDefaultMovementParam1_Leave);
            // 
            // cmbSetDefaultMovementType
            // 
            this.cmbSetDefaultMovementType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetDefaultMovementType.FormattingEnabled = true;
            this.cmbSetDefaultMovementType.Items.AddRange(new object[] {
            "Idle Movement",
            "Random Movement",
            "Waypoint Movement"});
            this.cmbSetDefaultMovementType.Location = new System.Drawing.Point(99, 58);
            this.cmbSetDefaultMovementType.Name = "cmbSetDefaultMovementType";
            this.cmbSetDefaultMovementType.Size = new System.Drawing.Size(374, 21);
            this.cmbSetDefaultMovementType.TabIndex = 7;
            this.cmbSetDefaultMovementType.SelectedIndexChanged += new System.EventHandler(this.cmbSetDefaultMovementType_SelectedIndexChanged);
            // 
            // lblSetDefaultMovementParam1
            // 
            this.lblSetDefaultMovementParam1.AutoSize = true;
            this.lblSetDefaultMovementParam1.Location = new System.Drawing.Point(46, 124);
            this.lblSetDefaultMovementParam1.Name = "lblSetDefaultMovementParam1";
            this.lblSetDefaultMovementParam1.Size = new System.Drawing.Size(49, 13);
            this.lblSetDefaultMovementParam1.TabIndex = 6;
            this.lblSetDefaultMovementParam1.Text = "Param 1:";
            // 
            // lblSetDefaultMovementAlwaysReplace
            // 
            this.lblSetDefaultMovementAlwaysReplace.AutoSize = true;
            this.lblSetDefaultMovementAlwaysReplace.Location = new System.Drawing.Point(45, 93);
            this.lblSetDefaultMovementAlwaysReplace.Name = "lblSetDefaultMovementAlwaysReplace";
            this.lblSetDefaultMovementAlwaysReplace.Size = new System.Drawing.Size(50, 13);
            this.lblSetDefaultMovementAlwaysReplace.TabIndex = 4;
            this.lblSetDefaultMovementAlwaysReplace.Text = "Replace:";
            // 
            // lblSetDefaultMovementType
            // 
            this.lblSetDefaultMovementType.AutoSize = true;
            this.lblSetDefaultMovementType.Location = new System.Drawing.Point(26, 61);
            this.lblSetDefaultMovementType.Name = "lblSetDefaultMovementType";
            this.lblSetDefaultMovementType.Size = new System.Drawing.Size(69, 13);
            this.lblSetDefaultMovementType.TabIndex = 3;
            this.lblSetDefaultMovementType.Text = "Motion Type:";
            // 
            // lblSetDefaultMovementTooltip
            // 
            this.lblSetDefaultMovementTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetDefaultMovementTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSetDefaultMovementTooltip.Name = "lblSetDefaultMovementTooltip";
            this.lblSetDefaultMovementTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSetDefaultMovementTooltip.TabIndex = 0;
            this.lblSetDefaultMovementTooltip.Text = "Changes the source Creature\'s default out of combat movement type.";
            // 
            // frmCommandStartScriptForAll
            // 
            this.frmCommandStartScriptForAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandStartScriptForAll.Controls.Add(this.btnStartScriptForAllEdit);
            this.frmCommandStartScriptForAll.Controls.Add(this.btnStartScriptForAllObjectEntry);
            this.frmCommandStartScriptForAll.Controls.Add(this.txtStartScriptForAllDistance);
            this.frmCommandStartScriptForAll.Controls.Add(this.lblStartScriptForAllDistance);
            this.frmCommandStartScriptForAll.Controls.Add(this.txtStartScriptForAllScriptId);
            this.frmCommandStartScriptForAll.Controls.Add(this.cmbStartScriptForAllObjectType);
            this.frmCommandStartScriptForAll.Controls.Add(this.lblStartScriptForAllObjectEntry);
            this.frmCommandStartScriptForAll.Controls.Add(this.lblStartScriptForAllObjectType);
            this.frmCommandStartScriptForAll.Controls.Add(this.lblStartScriptForAllScriptId);
            this.frmCommandStartScriptForAll.Controls.Add(this.lblStartScriptForAllTooltip);
            this.frmCommandStartScriptForAll.Location = new System.Drawing.Point(410, 252);
            this.frmCommandStartScriptForAll.Name = "frmCommandStartScriptForAll";
            this.frmCommandStartScriptForAll.Size = new System.Drawing.Size(495, 332);
            this.frmCommandStartScriptForAll.TabIndex = 62;
            this.frmCommandStartScriptForAll.Visible = false;
            // 
            // btnStartScriptForAllEdit
            // 
            this.btnStartScriptForAllEdit.Location = new System.Drawing.Point(429, 58);
            this.btnStartScriptForAllEdit.Name = "btnStartScriptForAllEdit";
            this.btnStartScriptForAllEdit.Size = new System.Drawing.Size(44, 22);
            this.btnStartScriptForAllEdit.TabIndex = 17;
            this.btnStartScriptForAllEdit.Text = "Edit";
            this.btnStartScriptForAllEdit.UseVisualStyleBackColor = true;
            this.btnStartScriptForAllEdit.Click += new System.EventHandler(this.btnStartScriptForAllEdit_Click);
            // 
            // btnStartScriptForAllObjectEntry
            // 
            this.btnStartScriptForAllObjectEntry.Location = new System.Drawing.Point(99, 121);
            this.btnStartScriptForAllObjectEntry.Name = "btnStartScriptForAllObjectEntry";
            this.btnStartScriptForAllObjectEntry.Size = new System.Drawing.Size(374, 23);
            this.btnStartScriptForAllObjectEntry.TabIndex = 16;
            this.btnStartScriptForAllObjectEntry.Text = "-NONE-";
            this.btnStartScriptForAllObjectEntry.UseVisualStyleBackColor = true;
            this.btnStartScriptForAllObjectEntry.Click += new System.EventHandler(this.btnStartScriptForAllObjectEntry_Click);
            // 
            // txtStartScriptForAllDistance
            // 
            this.txtStartScriptForAllDistance.Location = new System.Drawing.Point(99, 153);
            this.txtStartScriptForAllDistance.Name = "txtStartScriptForAllDistance";
            this.txtStartScriptForAllDistance.Size = new System.Drawing.Size(374, 20);
            this.txtStartScriptForAllDistance.TabIndex = 15;
            this.txtStartScriptForAllDistance.Leave += new System.EventHandler(this.txtStartScriptForAllDistance_Leave);
            // 
            // lblStartScriptForAllDistance
            // 
            this.lblStartScriptForAllDistance.AutoSize = true;
            this.lblStartScriptForAllDistance.Location = new System.Drawing.Point(43, 155);
            this.lblStartScriptForAllDistance.Name = "lblStartScriptForAllDistance";
            this.lblStartScriptForAllDistance.Size = new System.Drawing.Size(52, 13);
            this.lblStartScriptForAllDistance.TabIndex = 14;
            this.lblStartScriptForAllDistance.Text = "Distance:";
            // 
            // txtStartScriptForAllScriptId
            // 
            this.txtStartScriptForAllScriptId.Location = new System.Drawing.Point(99, 59);
            this.txtStartScriptForAllScriptId.Name = "txtStartScriptForAllScriptId";
            this.txtStartScriptForAllScriptId.Size = new System.Drawing.Size(316, 20);
            this.txtStartScriptForAllScriptId.TabIndex = 13;
            this.txtStartScriptForAllScriptId.Leave += new System.EventHandler(this.txtStartScriptForAllScriptId_Leave);
            // 
            // cmbStartScriptForAllObjectType
            // 
            this.cmbStartScriptForAllObjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartScriptForAllObjectType.FormattingEnabled = true;
            this.cmbStartScriptForAllObjectType.Items.AddRange(new object[] {
            "Gameobject",
            "Unit",
            "Creature",
            "Player"});
            this.cmbStartScriptForAllObjectType.Location = new System.Drawing.Point(99, 90);
            this.cmbStartScriptForAllObjectType.Name = "cmbStartScriptForAllObjectType";
            this.cmbStartScriptForAllObjectType.Size = new System.Drawing.Size(374, 21);
            this.cmbStartScriptForAllObjectType.TabIndex = 12;
            this.cmbStartScriptForAllObjectType.SelectedIndexChanged += new System.EventHandler(this.cmbStartScriptForAllObjectType_SelectedIndexChanged);
            // 
            // lblStartScriptForAllObjectEntry
            // 
            this.lblStartScriptForAllObjectEntry.AutoSize = true;
            this.lblStartScriptForAllObjectEntry.Location = new System.Drawing.Point(61, 124);
            this.lblStartScriptForAllObjectEntry.Name = "lblStartScriptForAllObjectEntry";
            this.lblStartScriptForAllObjectEntry.Size = new System.Drawing.Size(34, 13);
            this.lblStartScriptForAllObjectEntry.TabIndex = 6;
            this.lblStartScriptForAllObjectEntry.Text = "Entry:";
            // 
            // lblStartScriptForAllObjectType
            // 
            this.lblStartScriptForAllObjectType.AutoSize = true;
            this.lblStartScriptForAllObjectType.Location = new System.Drawing.Point(61, 93);
            this.lblStartScriptForAllObjectType.Name = "lblStartScriptForAllObjectType";
            this.lblStartScriptForAllObjectType.Size = new System.Drawing.Size(34, 13);
            this.lblStartScriptForAllObjectType.TabIndex = 4;
            this.lblStartScriptForAllObjectType.Text = "Type:";
            // 
            // lblStartScriptForAllScriptId
            // 
            this.lblStartScriptForAllScriptId.AutoSize = true;
            this.lblStartScriptForAllScriptId.Location = new System.Drawing.Point(46, 61);
            this.lblStartScriptForAllScriptId.Name = "lblStartScriptForAllScriptId";
            this.lblStartScriptForAllScriptId.Size = new System.Drawing.Size(49, 13);
            this.lblStartScriptForAllScriptId.TabIndex = 3;
            this.lblStartScriptForAllScriptId.Text = "Script Id:";
            // 
            // lblStartScriptForAllTooltip
            // 
            this.lblStartScriptForAllTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStartScriptForAllTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblStartScriptForAllTooltip.Name = "lblStartScriptForAllTooltip";
            this.lblStartScriptForAllTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblStartScriptForAllTooltip.TabIndex = 0;
            this.lblStartScriptForAllTooltip.Text = "Starts an event script with the given Id for all nearby objects. The object entry" +
    " is not required.";
            // 
            // frmCommandUnknown
            // 
            this.frmCommandUnknown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandUnknown.Controls.Add(this.txtUnknownCommandO);
            this.frmCommandUnknown.Controls.Add(this.txtUnknownCommandZ);
            this.frmCommandUnknown.Controls.Add(this.lblUnknownCommandO);
            this.frmCommandUnknown.Controls.Add(this.lblUnknownCommandZ);
            this.frmCommandUnknown.Controls.Add(this.txtUnknownCommandDataint4);
            this.frmCommandUnknown.Controls.Add(this.lblUnkownCommandDataint4);
            this.frmCommandUnknown.Controls.Add(this.txtUnknownCommandDataint2);
            this.frmCommandUnknown.Controls.Add(this.lblUnkownCommandDataint3);
            this.frmCommandUnknown.Controls.Add(this.txtUnknownCommandDataint3);
            this.frmCommandUnknown.Controls.Add(this.txtUnknownCommandDataint1);
            this.frmCommandUnknown.Controls.Add(this.lblUnknownCommandDatalong4);
            this.frmCommandUnknown.Controls.Add(this.lblUnknownCommandDatalong3);
            this.frmCommandUnknown.Controls.Add(this.txtUnknownCommandDatalong4);
            this.frmCommandUnknown.Controls.Add(this.lblUnknownCommandDataint2);
            this.frmCommandUnknown.Controls.Add(this.txtUnknownCommandDatalong2);
            this.frmCommandUnknown.Controls.Add(this.lblUnknownCommandDataint1);
            this.frmCommandUnknown.Controls.Add(this.txtUnknownCommandY);
            this.frmCommandUnknown.Controls.Add(this.txtUnknownCommandX);
            this.frmCommandUnknown.Controls.Add(this.lblUnknownCommandY);
            this.frmCommandUnknown.Controls.Add(this.lblUnknownCommandX);
            this.frmCommandUnknown.Controls.Add(this.txtUnknownCommandDatalong3);
            this.frmCommandUnknown.Controls.Add(this.txtUnknownCommandDatalong1);
            this.frmCommandUnknown.Controls.Add(this.lblUnknownCommandDatalong2);
            this.frmCommandUnknown.Controls.Add(this.lblUnknownCommandDatalong1);
            this.frmCommandUnknown.Controls.Add(this.lblUnknownCommandTooltip);
            this.frmCommandUnknown.Location = new System.Drawing.Point(410, 252);
            this.frmCommandUnknown.Name = "frmCommandUnknown";
            this.frmCommandUnknown.Size = new System.Drawing.Size(495, 332);
            this.frmCommandUnknown.TabIndex = 63;
            this.frmCommandUnknown.Visible = false;
            // 
            // txtUnknownCommandO
            // 
            this.txtUnknownCommandO.Location = new System.Drawing.Point(99, 276);
            this.txtUnknownCommandO.Name = "txtUnknownCommandO";
            this.txtUnknownCommandO.Size = new System.Drawing.Size(374, 20);
            this.txtUnknownCommandO.TabIndex = 36;
            this.txtUnknownCommandO.Leave += new System.EventHandler(this.txtUnknownCommandO_Leave);
            // 
            // txtUnknownCommandZ
            // 
            this.txtUnknownCommandZ.Location = new System.Drawing.Point(99, 245);
            this.txtUnknownCommandZ.Name = "txtUnknownCommandZ";
            this.txtUnknownCommandZ.Size = new System.Drawing.Size(374, 20);
            this.txtUnknownCommandZ.TabIndex = 35;
            this.txtUnknownCommandZ.Leave += new System.EventHandler(this.txtUnknownCommandZ_Leave);
            // 
            // lblUnknownCommandO
            // 
            this.lblUnknownCommandO.AutoSize = true;
            this.lblUnknownCommandO.Location = new System.Drawing.Point(37, 279);
            this.lblUnknownCommandO.Name = "lblUnknownCommandO";
            this.lblUnknownCommandO.Size = new System.Drawing.Size(58, 13);
            this.lblUnknownCommandO.TabIndex = 34;
            this.lblUnknownCommandO.Text = "Position O:";
            // 
            // lblUnknownCommandZ
            // 
            this.lblUnknownCommandZ.AutoSize = true;
            this.lblUnknownCommandZ.Location = new System.Drawing.Point(38, 247);
            this.lblUnknownCommandZ.Name = "lblUnknownCommandZ";
            this.lblUnknownCommandZ.Size = new System.Drawing.Size(57, 13);
            this.lblUnknownCommandZ.TabIndex = 33;
            this.lblUnknownCommandZ.Text = "Position Z:";
            // 
            // txtUnknownCommandDataint4
            // 
            this.txtUnknownCommandDataint4.Location = new System.Drawing.Point(323, 152);
            this.txtUnknownCommandDataint4.Name = "txtUnknownCommandDataint4";
            this.txtUnknownCommandDataint4.Size = new System.Drawing.Size(150, 20);
            this.txtUnknownCommandDataint4.TabIndex = 32;
            this.txtUnknownCommandDataint4.Leave += new System.EventHandler(this.txtUnknownCommandDataint4_Leave);
            // 
            // lblUnkownCommandDataint4
            // 
            this.lblUnkownCommandDataint4.AutoSize = true;
            this.lblUnkownCommandDataint4.Location = new System.Drawing.Point(266, 155);
            this.lblUnkownCommandDataint4.Name = "lblUnkownCommandDataint4";
            this.lblUnkownCommandDataint4.Size = new System.Drawing.Size(53, 13);
            this.lblUnkownCommandDataint4.TabIndex = 31;
            this.lblUnkownCommandDataint4.Text = "Dataint 4:";
            // 
            // txtUnknownCommandDataint2
            // 
            this.txtUnknownCommandDataint2.Location = new System.Drawing.Point(323, 90);
            this.txtUnknownCommandDataint2.Name = "txtUnknownCommandDataint2";
            this.txtUnknownCommandDataint2.Size = new System.Drawing.Size(150, 20);
            this.txtUnknownCommandDataint2.TabIndex = 30;
            this.txtUnknownCommandDataint2.Leave += new System.EventHandler(this.txtUnknownCommandDataint2_Leave);
            // 
            // lblUnkownCommandDataint3
            // 
            this.lblUnkownCommandDataint3.AutoSize = true;
            this.lblUnkownCommandDataint3.Location = new System.Drawing.Point(266, 123);
            this.lblUnkownCommandDataint3.Name = "lblUnkownCommandDataint3";
            this.lblUnkownCommandDataint3.Size = new System.Drawing.Size(53, 13);
            this.lblUnkownCommandDataint3.TabIndex = 29;
            this.lblUnkownCommandDataint3.Text = "Dataint 3:";
            // 
            // txtUnknownCommandDataint3
            // 
            this.txtUnknownCommandDataint3.Location = new System.Drawing.Point(323, 121);
            this.txtUnknownCommandDataint3.Name = "txtUnknownCommandDataint3";
            this.txtUnknownCommandDataint3.Size = new System.Drawing.Size(150, 20);
            this.txtUnknownCommandDataint3.TabIndex = 28;
            this.txtUnknownCommandDataint3.Leave += new System.EventHandler(this.txtUnknownCommandDataint3_Leave);
            // 
            // txtUnknownCommandDataint1
            // 
            this.txtUnknownCommandDataint1.Location = new System.Drawing.Point(323, 59);
            this.txtUnknownCommandDataint1.Name = "txtUnknownCommandDataint1";
            this.txtUnknownCommandDataint1.Size = new System.Drawing.Size(150, 20);
            this.txtUnknownCommandDataint1.TabIndex = 27;
            this.txtUnknownCommandDataint1.Leave += new System.EventHandler(this.txtUnknownCommandDataint1_Leave);
            // 
            // lblUnknownCommandDatalong4
            // 
            this.lblUnknownCommandDatalong4.AutoSize = true;
            this.lblUnknownCommandDatalong4.Location = new System.Drawing.Point(33, 155);
            this.lblUnknownCommandDatalong4.Name = "lblUnknownCommandDatalong4";
            this.lblUnknownCommandDatalong4.Size = new System.Drawing.Size(62, 13);
            this.lblUnknownCommandDatalong4.TabIndex = 26;
            this.lblUnknownCommandDatalong4.Text = "Datalong 4:";
            // 
            // lblUnknownCommandDatalong3
            // 
            this.lblUnknownCommandDatalong3.AutoSize = true;
            this.lblUnknownCommandDatalong3.Location = new System.Drawing.Point(33, 123);
            this.lblUnknownCommandDatalong3.Name = "lblUnknownCommandDatalong3";
            this.lblUnknownCommandDatalong3.Size = new System.Drawing.Size(62, 13);
            this.lblUnknownCommandDatalong3.TabIndex = 25;
            this.lblUnknownCommandDatalong3.Text = "Datalong 3:";
            // 
            // txtUnknownCommandDatalong4
            // 
            this.txtUnknownCommandDatalong4.Location = new System.Drawing.Point(99, 152);
            this.txtUnknownCommandDatalong4.Name = "txtUnknownCommandDatalong4";
            this.txtUnknownCommandDatalong4.Size = new System.Drawing.Size(150, 20);
            this.txtUnknownCommandDatalong4.TabIndex = 24;
            this.txtUnknownCommandDatalong4.Leave += new System.EventHandler(this.txtUnknownCommandDatalong4_Leave);
            // 
            // lblUnknownCommandDataint2
            // 
            this.lblUnknownCommandDataint2.AutoSize = true;
            this.lblUnknownCommandDataint2.Location = new System.Drawing.Point(266, 93);
            this.lblUnknownCommandDataint2.Name = "lblUnknownCommandDataint2";
            this.lblUnknownCommandDataint2.Size = new System.Drawing.Size(53, 13);
            this.lblUnknownCommandDataint2.TabIndex = 23;
            this.lblUnknownCommandDataint2.Text = "Dataint 2:";
            // 
            // txtUnknownCommandDatalong2
            // 
            this.txtUnknownCommandDatalong2.Location = new System.Drawing.Point(99, 90);
            this.txtUnknownCommandDatalong2.Name = "txtUnknownCommandDatalong2";
            this.txtUnknownCommandDatalong2.Size = new System.Drawing.Size(150, 20);
            this.txtUnknownCommandDatalong2.TabIndex = 22;
            this.txtUnknownCommandDatalong2.Leave += new System.EventHandler(this.txtUnknownCommandDatalong2_Leave);
            // 
            // lblUnknownCommandDataint1
            // 
            this.lblUnknownCommandDataint1.AutoSize = true;
            this.lblUnknownCommandDataint1.Location = new System.Drawing.Point(266, 61);
            this.lblUnknownCommandDataint1.Name = "lblUnknownCommandDataint1";
            this.lblUnknownCommandDataint1.Size = new System.Drawing.Size(53, 13);
            this.lblUnknownCommandDataint1.TabIndex = 21;
            this.lblUnknownCommandDataint1.Text = "Dataint 1:";
            // 
            // txtUnknownCommandY
            // 
            this.txtUnknownCommandY.Location = new System.Drawing.Point(99, 214);
            this.txtUnknownCommandY.Name = "txtUnknownCommandY";
            this.txtUnknownCommandY.Size = new System.Drawing.Size(374, 20);
            this.txtUnknownCommandY.TabIndex = 20;
            this.txtUnknownCommandY.Leave += new System.EventHandler(this.txtUnknownCommandY_Leave);
            // 
            // txtUnknownCommandX
            // 
            this.txtUnknownCommandX.Location = new System.Drawing.Point(99, 183);
            this.txtUnknownCommandX.Name = "txtUnknownCommandX";
            this.txtUnknownCommandX.Size = new System.Drawing.Size(374, 20);
            this.txtUnknownCommandX.TabIndex = 19;
            this.txtUnknownCommandX.Leave += new System.EventHandler(this.txtUnknownCommandX_Leave);
            // 
            // lblUnknownCommandY
            // 
            this.lblUnknownCommandY.AutoSize = true;
            this.lblUnknownCommandY.Location = new System.Drawing.Point(38, 217);
            this.lblUnknownCommandY.Name = "lblUnknownCommandY";
            this.lblUnknownCommandY.Size = new System.Drawing.Size(57, 13);
            this.lblUnknownCommandY.TabIndex = 18;
            this.lblUnknownCommandY.Text = "Position Y:";
            // 
            // lblUnknownCommandX
            // 
            this.lblUnknownCommandX.AutoSize = true;
            this.lblUnknownCommandX.Location = new System.Drawing.Point(38, 185);
            this.lblUnknownCommandX.Name = "lblUnknownCommandX";
            this.lblUnknownCommandX.Size = new System.Drawing.Size(57, 13);
            this.lblUnknownCommandX.TabIndex = 17;
            this.lblUnknownCommandX.Text = "Position X:";
            // 
            // txtUnknownCommandDatalong3
            // 
            this.txtUnknownCommandDatalong3.Location = new System.Drawing.Point(99, 121);
            this.txtUnknownCommandDatalong3.Name = "txtUnknownCommandDatalong3";
            this.txtUnknownCommandDatalong3.Size = new System.Drawing.Size(150, 20);
            this.txtUnknownCommandDatalong3.TabIndex = 15;
            this.txtUnknownCommandDatalong3.Leave += new System.EventHandler(this.txtUnknownCommandDatalong3_Leave);
            // 
            // txtUnknownCommandDatalong1
            // 
            this.txtUnknownCommandDatalong1.Location = new System.Drawing.Point(99, 59);
            this.txtUnknownCommandDatalong1.Name = "txtUnknownCommandDatalong1";
            this.txtUnknownCommandDatalong1.Size = new System.Drawing.Size(150, 20);
            this.txtUnknownCommandDatalong1.TabIndex = 13;
            this.txtUnknownCommandDatalong1.Leave += new System.EventHandler(this.txtUnknownCommandDatalong1_Leave);
            // 
            // lblUnknownCommandDatalong2
            // 
            this.lblUnknownCommandDatalong2.AutoSize = true;
            this.lblUnknownCommandDatalong2.Location = new System.Drawing.Point(33, 93);
            this.lblUnknownCommandDatalong2.Name = "lblUnknownCommandDatalong2";
            this.lblUnknownCommandDatalong2.Size = new System.Drawing.Size(62, 13);
            this.lblUnknownCommandDatalong2.TabIndex = 4;
            this.lblUnknownCommandDatalong2.Text = "Datalong 2:";
            // 
            // lblUnknownCommandDatalong1
            // 
            this.lblUnknownCommandDatalong1.AutoSize = true;
            this.lblUnknownCommandDatalong1.Location = new System.Drawing.Point(33, 61);
            this.lblUnknownCommandDatalong1.Name = "lblUnknownCommandDatalong1";
            this.lblUnknownCommandDatalong1.Size = new System.Drawing.Size(62, 13);
            this.lblUnknownCommandDatalong1.TabIndex = 3;
            this.lblUnknownCommandDatalong1.Text = "Datalong 1:";
            // 
            // lblUnknownCommandTooltip
            // 
            this.lblUnknownCommandTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUnknownCommandTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblUnknownCommandTooltip.Name = "lblUnknownCommandTooltip";
            this.lblUnknownCommandTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblUnknownCommandTooltip.TabIndex = 0;
            this.lblUnknownCommandTooltip.Text = "This command is not currently supported by the script editor.";
            // 
            // frmCommandSummonObject
            // 
            this.frmCommandSummonObject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandSummonObject.Controls.Add(this.lblSummonObjectRespawnTime);
            this.frmCommandSummonObject.Controls.Add(this.txtSummonObjectRespawnTime);
            this.frmCommandSummonObject.Controls.Add(this.btnSummonObjectId);
            this.frmCommandSummonObject.Controls.Add(this.lblSummonObjectO);
            this.frmCommandSummonObject.Controls.Add(this.lblSummonObjectZ);
            this.frmCommandSummonObject.Controls.Add(this.txtSummonObjectO);
            this.frmCommandSummonObject.Controls.Add(this.txtSummonObjectZ);
            this.frmCommandSummonObject.Controls.Add(this.lblSummonObjectY);
            this.frmCommandSummonObject.Controls.Add(this.lblSummonObjectX);
            this.frmCommandSummonObject.Controls.Add(this.txtSummonObjectY);
            this.frmCommandSummonObject.Controls.Add(this.txtSummonObjectX);
            this.frmCommandSummonObject.Controls.Add(this.lblSummonObjectId);
            this.frmCommandSummonObject.Controls.Add(this.lblSummonObjectTooltip);
            this.frmCommandSummonObject.Location = new System.Drawing.Point(410, 252);
            this.frmCommandSummonObject.Name = "frmCommandSummonObject";
            this.frmCommandSummonObject.Size = new System.Drawing.Size(495, 332);
            this.frmCommandSummonObject.TabIndex = 64;
            this.frmCommandSummonObject.Visible = false;
            // 
            // lblSummonObjectRespawnTime
            // 
            this.lblSummonObjectRespawnTime.AutoSize = true;
            this.lblSummonObjectRespawnTime.Location = new System.Drawing.Point(41, 96);
            this.lblSummonObjectRespawnTime.Name = "lblSummonObjectRespawnTime";
            this.lblSummonObjectRespawnTime.Size = new System.Drawing.Size(55, 13);
            this.lblSummonObjectRespawnTime.TabIndex = 13;
            this.lblSummonObjectRespawnTime.Text = "Respawn:";
            // 
            // txtSummonObjectRespawnTime
            // 
            this.txtSummonObjectRespawnTime.Location = new System.Drawing.Point(99, 92);
            this.txtSummonObjectRespawnTime.Name = "txtSummonObjectRespawnTime";
            this.txtSummonObjectRespawnTime.Size = new System.Drawing.Size(374, 20);
            this.txtSummonObjectRespawnTime.TabIndex = 12;
            this.txtSummonObjectRespawnTime.Leave += new System.EventHandler(this.txtSummonObjectRespawnTime_Leave);
            // 
            // btnSummonObjectId
            // 
            this.btnSummonObjectId.Location = new System.Drawing.Point(99, 58);
            this.btnSummonObjectId.Name = "btnSummonObjectId";
            this.btnSummonObjectId.Size = new System.Drawing.Size(374, 23);
            this.btnSummonObjectId.TabIndex = 11;
            this.btnSummonObjectId.Text = "-NONE-";
            this.btnSummonObjectId.UseVisualStyleBackColor = true;
            this.btnSummonObjectId.Click += new System.EventHandler(this.btnSummonObjectId_Click);
            // 
            // lblSummonObjectO
            // 
            this.lblSummonObjectO.AutoSize = true;
            this.lblSummonObjectO.Location = new System.Drawing.Point(264, 157);
            this.lblSummonObjectO.Name = "lblSummonObjectO";
            this.lblSummonObjectO.Size = new System.Drawing.Size(61, 13);
            this.lblSummonObjectO.TabIndex = 10;
            this.lblSummonObjectO.Text = "Orientation:";
            // 
            // lblSummonObjectZ
            // 
            this.lblSummonObjectZ.AutoSize = true;
            this.lblSummonObjectZ.Location = new System.Drawing.Point(26, 157);
            this.lblSummonObjectZ.Name = "lblSummonObjectZ";
            this.lblSummonObjectZ.Size = new System.Drawing.Size(70, 13);
            this.lblSummonObjectZ.TabIndex = 9;
            this.lblSummonObjectZ.Text = "Z coordinate:";
            // 
            // txtSummonObjectO
            // 
            this.txtSummonObjectO.Location = new System.Drawing.Point(328, 154);
            this.txtSummonObjectO.Name = "txtSummonObjectO";
            this.txtSummonObjectO.Size = new System.Drawing.Size(145, 20);
            this.txtSummonObjectO.TabIndex = 8;
            this.txtSummonObjectO.Leave += new System.EventHandler(this.txtSummonObjectO_Leave);
            // 
            // txtSummonObjectZ
            // 
            this.txtSummonObjectZ.Location = new System.Drawing.Point(99, 154);
            this.txtSummonObjectZ.Name = "txtSummonObjectZ";
            this.txtSummonObjectZ.Size = new System.Drawing.Size(145, 20);
            this.txtSummonObjectZ.TabIndex = 7;
            this.txtSummonObjectZ.Leave += new System.EventHandler(this.txtSummonObjectZ_Leave);
            // 
            // lblSummonObjectY
            // 
            this.lblSummonObjectY.AutoSize = true;
            this.lblSummonObjectY.Location = new System.Drawing.Point(255, 126);
            this.lblSummonObjectY.Name = "lblSummonObjectY";
            this.lblSummonObjectY.Size = new System.Drawing.Size(70, 13);
            this.lblSummonObjectY.TabIndex = 6;
            this.lblSummonObjectY.Text = "Y coordinate:";
            // 
            // lblSummonObjectX
            // 
            this.lblSummonObjectX.AutoSize = true;
            this.lblSummonObjectX.Location = new System.Drawing.Point(26, 126);
            this.lblSummonObjectX.Name = "lblSummonObjectX";
            this.lblSummonObjectX.Size = new System.Drawing.Size(70, 13);
            this.lblSummonObjectX.TabIndex = 5;
            this.lblSummonObjectX.Text = "X coordinate:";
            // 
            // txtSummonObjectY
            // 
            this.txtSummonObjectY.Location = new System.Drawing.Point(328, 123);
            this.txtSummonObjectY.Name = "txtSummonObjectY";
            this.txtSummonObjectY.Size = new System.Drawing.Size(145, 20);
            this.txtSummonObjectY.TabIndex = 4;
            this.txtSummonObjectY.Leave += new System.EventHandler(this.txtSummonObjectY_Leave);
            // 
            // txtSummonObjectX
            // 
            this.txtSummonObjectX.Location = new System.Drawing.Point(99, 123);
            this.txtSummonObjectX.Name = "txtSummonObjectX";
            this.txtSummonObjectX.Size = new System.Drawing.Size(145, 20);
            this.txtSummonObjectX.TabIndex = 3;
            this.txtSummonObjectX.Leave += new System.EventHandler(this.txtSummonObjectX_Leave);
            // 
            // lblSummonObjectId
            // 
            this.lblSummonObjectId.AutoSize = true;
            this.lblSummonObjectId.Location = new System.Drawing.Point(43, 61);
            this.lblSummonObjectId.Name = "lblSummonObjectId";
            this.lblSummonObjectId.Size = new System.Drawing.Size(53, 13);
            this.lblSummonObjectId.TabIndex = 1;
            this.lblSummonObjectId.Text = "Object Id:";
            // 
            // lblSummonObjectTooltip
            // 
            this.lblSummonObjectTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSummonObjectTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblSummonObjectTooltip.Name = "lblSummonObjectTooltip";
            this.lblSummonObjectTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblSummonObjectTooltip.TabIndex = 0;
            this.lblSummonObjectTooltip.Text = "Summons a GameObject at the specified position.";
            // 
            // frmCommandJoinCreatureGroup
            // 
            this.frmCommandJoinCreatureGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandJoinCreatureGroup.Controls.Add(this.joinCreatureGroupsFlagsGroupBox);
            this.frmCommandJoinCreatureGroup.Controls.Add(this.lblJoinCreatureGroupAngle);
            this.frmCommandJoinCreatureGroup.Controls.Add(this.lblJoinCreatureGroupDistance);
            this.frmCommandJoinCreatureGroup.Controls.Add(this.txtJoinCreatureGroupAngle);
            this.frmCommandJoinCreatureGroup.Controls.Add(this.txtJoinCreatureGroupDistance);
            this.frmCommandJoinCreatureGroup.Controls.Add(this.lblJoinCreatureGroupTooltip);
            this.frmCommandJoinCreatureGroup.Location = new System.Drawing.Point(410, 252);
            this.frmCommandJoinCreatureGroup.Name = "frmCommandJoinCreatureGroup";
            this.frmCommandJoinCreatureGroup.Size = new System.Drawing.Size(495, 332);
            this.frmCommandJoinCreatureGroup.TabIndex = 65;
            this.frmCommandJoinCreatureGroup.Visible = false;
            // 
            // joinCreatureGroupsFlagsGroupBox
            // 
            this.joinCreatureGroupsFlagsGroupBox.Controls.Add(this.chkJoinCreatureGroup128);
            this.joinCreatureGroupsFlagsGroupBox.Controls.Add(this.chkJoinCreatureGroup64);
            this.joinCreatureGroupsFlagsGroupBox.Controls.Add(this.chkJoinCreatureGroup32);
            this.joinCreatureGroupsFlagsGroupBox.Controls.Add(this.chkJoinCreatureGroup16);
            this.joinCreatureGroupsFlagsGroupBox.Controls.Add(this.chkJoinCreatureGroup8);
            this.joinCreatureGroupsFlagsGroupBox.Controls.Add(this.chkJoinCreatureGroup4);
            this.joinCreatureGroupsFlagsGroupBox.Controls.Add(this.chkJoinCreatureGroup2);
            this.joinCreatureGroupsFlagsGroupBox.Controls.Add(this.chkJoinCreatureGroup1);
            this.joinCreatureGroupsFlagsGroupBox.Location = new System.Drawing.Point(99, 120);
            this.joinCreatureGroupsFlagsGroupBox.Name = "joinCreatureGroupsFlagsGroupBox";
            this.joinCreatureGroupsFlagsGroupBox.Size = new System.Drawing.Size(374, 121);
            this.joinCreatureGroupsFlagsGroupBox.TabIndex = 5;
            this.joinCreatureGroupsFlagsGroupBox.TabStop = false;
            this.joinCreatureGroupsFlagsGroupBox.Text = "Group Flags";
            // 
            // chkJoinCreatureGroup128
            // 
            this.chkJoinCreatureGroup128.AutoSize = true;
            this.chkJoinCreatureGroup128.Location = new System.Drawing.Point(182, 92);
            this.chkJoinCreatureGroup128.Name = "chkJoinCreatureGroup128";
            this.chkJoinCreatureGroup128.Size = new System.Drawing.Size(162, 17);
            this.chkJoinCreatureGroup128.TabIndex = 7;
            this.chkJoinCreatureGroup128.Text = "Inform Members on Any Died";
            this.chkJoinCreatureGroup128.UseVisualStyleBackColor = true;
            this.chkJoinCreatureGroup128.CheckedChanged += new System.EventHandler(this.chkJoinCreatureGroup128_CheckedChanged);
            // 
            // chkJoinCreatureGroup64
            // 
            this.chkJoinCreatureGroup64.AutoSize = true;
            this.chkJoinCreatureGroup64.Location = new System.Drawing.Point(10, 91);
            this.chkJoinCreatureGroup64.Name = "chkJoinCreatureGroup64";
            this.chkJoinCreatureGroup64.Size = new System.Drawing.Size(172, 17);
            this.chkJoinCreatureGroup64.TabIndex = 6;
            this.chkJoinCreatureGroup64.Text = "Inform Leader on Member Died";
            this.chkJoinCreatureGroup64.UseVisualStyleBackColor = true;
            this.chkJoinCreatureGroup64.CheckedChanged += new System.EventHandler(this.chkJoinCreatureGroup64_CheckedChanged);
            // 
            // chkJoinCreatureGroup32
            // 
            this.chkJoinCreatureGroup32.AutoSize = true;
            this.chkJoinCreatureGroup32.Location = new System.Drawing.Point(182, 69);
            this.chkJoinCreatureGroup32.Name = "chkJoinCreatureGroup32";
            this.chkJoinCreatureGroup32.Size = new System.Drawing.Size(141, 17);
            this.chkJoinCreatureGroup32.TabIndex = 5;
            this.chkJoinCreatureGroup32.Text = "Respawn on Any Evade";
            this.chkJoinCreatureGroup32.UseVisualStyleBackColor = true;
            this.chkJoinCreatureGroup32.CheckedChanged += new System.EventHandler(this.chkJoinCreatureGroup32_CheckedChanged);
            // 
            // chkJoinCreatureGroup16
            // 
            this.chkJoinCreatureGroup16.AutoSize = true;
            this.chkJoinCreatureGroup16.Location = new System.Drawing.Point(10, 69);
            this.chkJoinCreatureGroup16.Name = "chkJoinCreatureGroup16";
            this.chkJoinCreatureGroup16.Size = new System.Drawing.Size(155, 17);
            this.chkJoinCreatureGroup16.TabIndex = 4;
            this.chkJoinCreatureGroup16.Text = "Respawn on Master Evade";
            this.chkJoinCreatureGroup16.UseVisualStyleBackColor = true;
            this.chkJoinCreatureGroup16.CheckedChanged += new System.EventHandler(this.chkJoinCreatureGroup16_CheckedChanged);
            // 
            // chkJoinCreatureGroup8
            // 
            this.chkJoinCreatureGroup8.AutoSize = true;
            this.chkJoinCreatureGroup8.Location = new System.Drawing.Point(10, 47);
            this.chkJoinCreatureGroup8.Name = "chkJoinCreatureGroup8";
            this.chkJoinCreatureGroup8.Size = new System.Drawing.Size(117, 17);
            this.chkJoinCreatureGroup8.TabIndex = 3;
            this.chkJoinCreatureGroup8.Text = "Respawn Together";
            this.chkJoinCreatureGroup8.UseVisualStyleBackColor = true;
            this.chkJoinCreatureGroup8.CheckedChanged += new System.EventHandler(this.chkJoinCreatureGroup8_CheckedChanged);
            // 
            // chkJoinCreatureGroup4
            // 
            this.chkJoinCreatureGroup4.AutoSize = true;
            this.chkJoinCreatureGroup4.Location = new System.Drawing.Point(242, 25);
            this.chkJoinCreatureGroup4.Name = "chkJoinCreatureGroup4";
            this.chkJoinCreatureGroup4.Size = new System.Drawing.Size(103, 17);
            this.chkJoinCreatureGroup4.TabIndex = 2;
            this.chkJoinCreatureGroup4.Text = "Evade Together";
            this.chkJoinCreatureGroup4.UseVisualStyleBackColor = true;
            this.chkJoinCreatureGroup4.CheckedChanged += new System.EventHandler(this.chkJoinCreatureGroup4_CheckedChanged);
            // 
            // chkJoinCreatureGroup2
            // 
            this.chkJoinCreatureGroup2.AutoSize = true;
            this.chkJoinCreatureGroup2.Location = new System.Drawing.Point(127, 25);
            this.chkJoinCreatureGroup2.Name = "chkJoinCreatureGroup2";
            this.chkJoinCreatureGroup2.Size = new System.Drawing.Size(100, 17);
            this.chkJoinCreatureGroup2.TabIndex = 1;
            this.chkJoinCreatureGroup2.Text = "Aggro Together";
            this.chkJoinCreatureGroup2.UseVisualStyleBackColor = true;
            this.chkJoinCreatureGroup2.CheckedChanged += new System.EventHandler(this.chkJoinCreatureGroup2_CheckedChanged);
            // 
            // chkJoinCreatureGroup1
            // 
            this.chkJoinCreatureGroup1.AutoSize = true;
            this.chkJoinCreatureGroup1.Location = new System.Drawing.Point(10, 25);
            this.chkJoinCreatureGroup1.Name = "chkJoinCreatureGroup1";
            this.chkJoinCreatureGroup1.Size = new System.Drawing.Size(102, 17);
            this.chkJoinCreatureGroup1.TabIndex = 0;
            this.chkJoinCreatureGroup1.Text = "Formation Move";
            this.chkJoinCreatureGroup1.UseVisualStyleBackColor = true;
            this.chkJoinCreatureGroup1.CheckedChanged += new System.EventHandler(this.chkJoinCreatureGroup1_CheckedChanged);
            // 
            // lblJoinCreatureGroupAngle
            // 
            this.lblJoinCreatureGroupAngle.AutoSize = true;
            this.lblJoinCreatureGroupAngle.Location = new System.Drawing.Point(59, 93);
            this.lblJoinCreatureGroupAngle.Name = "lblJoinCreatureGroupAngle";
            this.lblJoinCreatureGroupAngle.Size = new System.Drawing.Size(37, 13);
            this.lblJoinCreatureGroupAngle.TabIndex = 4;
            this.lblJoinCreatureGroupAngle.Text = "Angle:";
            // 
            // lblJoinCreatureGroupDistance
            // 
            this.lblJoinCreatureGroupDistance.AutoSize = true;
            this.lblJoinCreatureGroupDistance.Location = new System.Drawing.Point(44, 61);
            this.lblJoinCreatureGroupDistance.Name = "lblJoinCreatureGroupDistance";
            this.lblJoinCreatureGroupDistance.Size = new System.Drawing.Size(52, 13);
            this.lblJoinCreatureGroupDistance.TabIndex = 3;
            this.lblJoinCreatureGroupDistance.Text = "Distance:";
            // 
            // txtJoinCreatureGroupAngle
            // 
            this.txtJoinCreatureGroupAngle.Location = new System.Drawing.Point(99, 90);
            this.txtJoinCreatureGroupAngle.Name = "txtJoinCreatureGroupAngle";
            this.txtJoinCreatureGroupAngle.Size = new System.Drawing.Size(374, 20);
            this.txtJoinCreatureGroupAngle.TabIndex = 2;
            this.txtJoinCreatureGroupAngle.Leave += new System.EventHandler(this.txtJoinCreatureGroupAngle_Leave);
            // 
            // txtJoinCreatureGroupDistance
            // 
            this.txtJoinCreatureGroupDistance.Location = new System.Drawing.Point(99, 58);
            this.txtJoinCreatureGroupDistance.Name = "txtJoinCreatureGroupDistance";
            this.txtJoinCreatureGroupDistance.Size = new System.Drawing.Size(374, 20);
            this.txtJoinCreatureGroupDistance.TabIndex = 1;
            this.txtJoinCreatureGroupDistance.Leave += new System.EventHandler(this.txtJoinCreatureGroupDistance_Leave);
            // 
            // lblJoinCreatureGroupTooltip
            // 
            this.lblJoinCreatureGroupTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblJoinCreatureGroupTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblJoinCreatureGroupTooltip.Name = "lblJoinCreatureGroupTooltip";
            this.lblJoinCreatureGroupTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblJoinCreatureGroupTooltip.TabIndex = 0;
            this.lblJoinCreatureGroupTooltip.Text = "The source Creature joins the target Creature\'s group. If the target is not in a " +
    "group, then a new group is created with the target as leader.";
            // 
            // frmCommandStartScriptOnZone
            // 
            this.frmCommandStartScriptOnZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmCommandStartScriptOnZone.Controls.Add(this.btnStartScriptOnZoneScriptIdEdit);
            this.frmCommandStartScriptOnZone.Controls.Add(this.lblStartScriptOnZoneWithPets);
            this.frmCommandStartScriptOnZone.Controls.Add(this.cmbStartScriptOnZoneWithPets);
            this.frmCommandStartScriptOnZone.Controls.Add(this.btnStartScriptOnZoneZoneId);
            this.frmCommandStartScriptOnZone.Controls.Add(this.lblStartScriptOnZoneZoneId);
            this.frmCommandStartScriptOnZone.Controls.Add(this.lblStartScriptOnZoneScriptId);
            this.frmCommandStartScriptOnZone.Controls.Add(this.txtStartScriptOnZoneScriptId);
            this.frmCommandStartScriptOnZone.Controls.Add(this.lblStartScriptOnZoneTooltip);
            this.frmCommandStartScriptOnZone.Location = new System.Drawing.Point(410, 252);
            this.frmCommandStartScriptOnZone.Name = "frmCommandStartScriptOnZone";
            this.frmCommandStartScriptOnZone.Size = new System.Drawing.Size(495, 332);
            this.frmCommandStartScriptOnZone.TabIndex = 66;
            this.frmCommandStartScriptOnZone.Visible = false;
            // 
            // btnStartScriptOnZoneScriptIdEdit
            // 
            this.btnStartScriptOnZoneScriptIdEdit.Location = new System.Drawing.Point(429, 57);
            this.btnStartScriptOnZoneScriptIdEdit.Name = "btnStartScriptOnZoneScriptIdEdit";
            this.btnStartScriptOnZoneScriptIdEdit.Size = new System.Drawing.Size(44, 22);
            this.btnStartScriptOnZoneScriptIdEdit.TabIndex = 9;
            this.btnStartScriptOnZoneScriptIdEdit.Text = "Edit";
            this.btnStartScriptOnZoneScriptIdEdit.UseVisualStyleBackColor = true;
            this.btnStartScriptOnZoneScriptIdEdit.Click += new System.EventHandler(this.btnStartScriptOnZoneScriptIdEdit_Click);
            // 
            // lblStartScriptOnZoneWithPets
            // 
            this.lblStartScriptOnZoneWithPets.AutoSize = true;
            this.lblStartScriptOnZoneWithPets.Location = new System.Drawing.Point(40, 125);
            this.lblStartScriptOnZoneWithPets.Name = "lblStartScriptOnZoneWithPets";
            this.lblStartScriptOnZoneWithPets.Size = new System.Drawing.Size(56, 13);
            this.lblStartScriptOnZoneWithPets.TabIndex = 8;
            this.lblStartScriptOnZoneWithPets.Text = "With Pets:";
            // 
            // cmbStartScriptOnZoneWithPets
            // 
            this.cmbStartScriptOnZoneWithPets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartScriptOnZoneWithPets.FormattingEnabled = true;
            this.cmbStartScriptOnZoneWithPets.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cmbStartScriptOnZoneWithPets.Location = new System.Drawing.Point(99, 122);
            this.cmbStartScriptOnZoneWithPets.Name = "cmbStartScriptOnZoneWithPets";
            this.cmbStartScriptOnZoneWithPets.Size = new System.Drawing.Size(374, 21);
            this.cmbStartScriptOnZoneWithPets.TabIndex = 7;
            this.cmbStartScriptOnZoneWithPets.SelectedIndexChanged += new System.EventHandler(this.cmbStartScriptOnZoneWithPets_SelectedIndexChanged);
            // 
            // btnStartScriptOnZoneZoneId
            // 
            this.btnStartScriptOnZoneZoneId.Location = new System.Drawing.Point(99, 90);
            this.btnStartScriptOnZoneZoneId.Name = "btnStartScriptOnZoneZoneId";
            this.btnStartScriptOnZoneZoneId.Size = new System.Drawing.Size(374, 23);
            this.btnStartScriptOnZoneZoneId.TabIndex = 6;
            this.btnStartScriptOnZoneZoneId.Text = "-NONE-";
            this.btnStartScriptOnZoneZoneId.UseVisualStyleBackColor = true;
            this.btnStartScriptOnZoneZoneId.Click += new System.EventHandler(this.btnStartScriptOnZoneZoneId_Click);
            // 
            // lblStartScriptOnZoneZoneId
            // 
            this.lblStartScriptOnZoneZoneId.AutoSize = true;
            this.lblStartScriptOnZoneZoneId.Location = new System.Drawing.Point(49, 93);
            this.lblStartScriptOnZoneZoneId.Name = "lblStartScriptOnZoneZoneId";
            this.lblStartScriptOnZoneZoneId.Size = new System.Drawing.Size(47, 13);
            this.lblStartScriptOnZoneZoneId.TabIndex = 4;
            this.lblStartScriptOnZoneZoneId.Text = "Zone Id:";
            // 
            // lblStartScriptOnZoneScriptId
            // 
            this.lblStartScriptOnZoneScriptId.AutoSize = true;
            this.lblStartScriptOnZoneScriptId.Location = new System.Drawing.Point(47, 61);
            this.lblStartScriptOnZoneScriptId.Name = "lblStartScriptOnZoneScriptId";
            this.lblStartScriptOnZoneScriptId.Size = new System.Drawing.Size(49, 13);
            this.lblStartScriptOnZoneScriptId.TabIndex = 3;
            this.lblStartScriptOnZoneScriptId.Text = "Script Id:";
            // 
            // txtStartScriptOnZoneScriptId
            // 
            this.txtStartScriptOnZoneScriptId.Location = new System.Drawing.Point(99, 58);
            this.txtStartScriptOnZoneScriptId.Name = "txtStartScriptOnZoneScriptId";
            this.txtStartScriptOnZoneScriptId.Size = new System.Drawing.Size(323, 20);
            this.txtStartScriptOnZoneScriptId.TabIndex = 1;
            this.txtStartScriptOnZoneScriptId.Leave += new System.EventHandler(this.txtStartScriptOnZoneScriptId_Leave);
            // 
            // lblStartScriptOnZoneTooltip
            // 
            this.lblStartScriptOnZoneTooltip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStartScriptOnZoneTooltip.Location = new System.Drawing.Point(20, 10);
            this.lblStartScriptOnZoneTooltip.Name = "lblStartScriptOnZoneTooltip";
            this.lblStartScriptOnZoneTooltip.Size = new System.Drawing.Size(453, 32);
            this.lblStartScriptOnZoneTooltip.TabIndex = 0;
            this.lblStartScriptOnZoneTooltip.Text = "Starts a generic script on all Players in the zone, and optionally their Pets.";
            // 
            // FormScriptEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 620);
            this.Controls.Add(this.frmCommandStartScriptOnZone);
            this.Controls.Add(this.frmCommandJoinCreatureGroup);
            this.Controls.Add(this.frmCommandSummonObject);
            this.Controls.Add(this.frmCommandUnknown);
            this.Controls.Add(this.frmCommandStartScriptForAll);
            this.Controls.Add(this.frmCommandSetDefaultMovement);
            this.Controls.Add(this.frmCommandSetScriptedMapEventData);
            this.Controls.Add(this.frmCommandRemoveScriptedMapEventTarget);
            this.Controls.Add(this.frmCommandStartScriptedMapEvent);
            this.Controls.Add(this.frmCommandStartWaypoints);
            this.Controls.Add(this.frmCommandSetReactState);
            this.Controls.Add(this.frmCommandSpellCooldown);
            this.Controls.Add(this.frmCommandSetSpellsList);
            this.Controls.Add(this.frmCommandGameEvent);
            this.Controls.Add(this.frmCommandCallForHelp);
            this.Controls.Add(this.frmCommandFlee);
            this.Controls.Add(this.frmCommandSetRandomPhase);
            this.Controls.Add(this.frmCommandSetPhase);
            this.Controls.Add(this.btnViewRaw);
            this.Controls.Add(this.btnActionCopy);
            this.Controls.Add(this.frmCommandStartScript);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.frmCommandSetData);
            this.Controls.Add(this.frmCommandMeetingStone);
            this.Controls.Add(this.frmCommandSetFacing);
            this.Controls.Add(this.frmCommandSetHomePosition);
            this.Controls.Add(this.frmCommandTerminateCondition);
            this.Controls.Add(this.frmCommandTerminateScript);
            this.Controls.Add(this.frmCommandSendTaxiPath);
            this.Controls.Add(this.frmCommandModifyThreat);
            this.Controls.Add(this.frmCommandSetStandState);
            this.Controls.Add(this.frmCommandUpdateEntry);
            this.Controls.Add(this.frmCommandInterruptCasts);
            this.Controls.Add(this.frmCommandModifyFlags);
            this.Controls.Add(this.frmCommandSetRun);
            this.Controls.Add(this.frmCommandMorphOrMount);
            this.Controls.Add(this.frmCommandSetFaction);
            this.Controls.Add(this.frmCommandActiveObject);
            this.Controls.Add(this.frmCommandSetMovement);
            this.Controls.Add(this.frmCommandSetEquipment);
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
            this.Controls.Add(this.btnActionAdd);
            this.Controls.Add(this.btnActionDelete);
            this.Controls.Add(this.frmCommandTalk);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.txtScriptId);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lstActions);
            this.Controls.Add(this.lblNoAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormScriptEditor";
            this.Text = "Script Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormScriptEditor_FormClosing);
            this.Load += new System.EventHandler(this.FormScriptEditor_Load);
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
            this.grpAddAuraFlags.ResumeLayout(false);
            this.grpAddAuraFlags.PerformLayout();
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
            this.frmCommandSetEquipment.ResumeLayout(false);
            this.frmCommandSetEquipment.PerformLayout();
            this.frmCommandSetMovement.ResumeLayout(false);
            this.frmCommandSetMovement.PerformLayout();
            this.frmCommandActiveObject.ResumeLayout(false);
            this.frmCommandActiveObject.PerformLayout();
            this.frmCommandSetFaction.ResumeLayout(false);
            this.frmCommandSetFaction.PerformLayout();
            this.grpSetFactionFlags.ResumeLayout(false);
            this.grpSetFactionFlags.PerformLayout();
            this.frmCommandMorphOrMount.ResumeLayout(false);
            this.frmCommandMorphOrMount.PerformLayout();
            this.frmCommandSetRun.ResumeLayout(false);
            this.frmCommandSetRun.PerformLayout();
            this.frmCommandModifyFlags.ResumeLayout(false);
            this.frmCommandModifyFlags.PerformLayout();
            this.frmCommandInterruptCasts.ResumeLayout(false);
            this.frmCommandInterruptCasts.PerformLayout();
            this.frmCommandUpdateEntry.ResumeLayout(false);
            this.frmCommandUpdateEntry.PerformLayout();
            this.frmCommandSetStandState.ResumeLayout(false);
            this.frmCommandSetStandState.PerformLayout();
            this.frmCommandModifyThreat.ResumeLayout(false);
            this.frmCommandModifyThreat.PerformLayout();
            this.frmCommandSendTaxiPath.ResumeLayout(false);
            this.frmCommandSendTaxiPath.PerformLayout();
            this.frmCommandTerminateScript.ResumeLayout(false);
            this.frmCommandTerminateScript.PerformLayout();
            this.frmCommandTerminateCondition.ResumeLayout(false);
            this.frmCommandTerminateCondition.PerformLayout();
            this.frmCommandSetHomePosition.ResumeLayout(false);
            this.frmCommandSetHomePosition.PerformLayout();
            this.frmCommandSetFacing.ResumeLayout(false);
            this.frmCommandSetFacing.PerformLayout();
            this.frmCommandMeetingStone.ResumeLayout(false);
            this.frmCommandMeetingStone.PerformLayout();
            this.frmCommandSetData.ResumeLayout(false);
            this.frmCommandSetData.PerformLayout();
            this.frmCommandStartScript.ResumeLayout(false);
            this.frmCommandStartScript.PerformLayout();
            this.frmCommandSetPhase.ResumeLayout(false);
            this.frmCommandSetPhase.PerformLayout();
            this.frmCommandSetRandomPhase.ResumeLayout(false);
            this.frmCommandSetRandomPhase.PerformLayout();
            this.frmCommandFlee.ResumeLayout(false);
            this.frmCommandFlee.PerformLayout();
            this.frmCommandCallForHelp.ResumeLayout(false);
            this.frmCommandCallForHelp.PerformLayout();
            this.frmCommandGameEvent.ResumeLayout(false);
            this.frmCommandGameEvent.PerformLayout();
            this.frmCommandSetSpellsList.ResumeLayout(false);
            this.frmCommandSetSpellsList.PerformLayout();
            this.frmCommandSpellCooldown.ResumeLayout(false);
            this.frmCommandSpellCooldown.PerformLayout();
            this.frmCommandSetReactState.ResumeLayout(false);
            this.frmCommandSetReactState.PerformLayout();
            this.frmCommandStartWaypoints.ResumeLayout(false);
            this.frmCommandStartWaypoints.PerformLayout();
            this.frmCommandStartScriptedMapEvent.ResumeLayout(false);
            this.frmCommandStartScriptedMapEvent.PerformLayout();
            this.frmCommandRemoveScriptedMapEventTarget.ResumeLayout(false);
            this.frmCommandRemoveScriptedMapEventTarget.PerformLayout();
            this.frmCommandSetScriptedMapEventData.ResumeLayout(false);
            this.frmCommandSetScriptedMapEventData.PerformLayout();
            this.frmCommandSetDefaultMovement.ResumeLayout(false);
            this.frmCommandSetDefaultMovement.PerformLayout();
            this.frmCommandStartScriptForAll.ResumeLayout(false);
            this.frmCommandStartScriptForAll.PerformLayout();
            this.frmCommandUnknown.ResumeLayout(false);
            this.frmCommandUnknown.PerformLayout();
            this.frmCommandSummonObject.ResumeLayout(false);
            this.frmCommandSummonObject.PerformLayout();
            this.frmCommandJoinCreatureGroup.ResumeLayout(false);
            this.frmCommandJoinCreatureGroup.PerformLayout();
            this.joinCreatureGroupsFlagsGroupBox.ResumeLayout(false);
            this.joinCreatureGroupsFlagsGroupBox.PerformLayout();
            this.frmCommandStartScriptOnZone.ResumeLayout(false);
            this.frmCommandStartScriptOnZone.PerformLayout();
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
        private System.Windows.Forms.TextBox txtTargetParam1;
        private System.Windows.Forms.Label lblTargetParam2;
        private System.Windows.Forms.Label lblTargetParam1;
        private System.Windows.Forms.ComboBox cmbTargetType;
        private System.Windows.Forms.TextBox txtTargetParam2;
        private System.Windows.Forms.GroupBox grpDataFlags;
        private System.Windows.Forms.CheckBox chkAbortScript;
        private System.Windows.Forms.CheckBox chkTargetSelf;
        private System.Windows.Forms.CheckBox chkSwapFinal;
        private System.Windows.Forms.CheckBox chkSwapInitial;
        private System.Windows.Forms.Label lblTargetType;
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
        private System.Windows.Forms.Button btnActionDelete;
        private System.Windows.Forms.Button btnActionAdd;
        private System.Windows.Forms.Label lblScriptId;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblTalkTextPreview;
        private System.Windows.Forms.Label lblTalkBroadcastId;
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
        private System.Windows.Forms.CheckBox chkSummonCreatureFlags8;
        private System.Windows.Forms.CheckBox chkSummonCreatureFlags4;
        private System.Windows.Forms.CheckBox chkSummonCreatureFlags2;
        private System.Windows.Forms.Button btnSummonCreatureId;
        private System.Windows.Forms.Label lblSummonCreatureTooltip;
        private System.Windows.Forms.Label lblSummonCreatureDelay;
        private System.Windows.Forms.TextBox txtSummonCreatureDelay;
        private System.Windows.Forms.TextBox txtSummonCreatureY;
        private System.Windows.Forms.TextBox txtSummonCreatureX;
        private System.Windows.Forms.Label lblSummonCreatureUniqueRange;
        private System.Windows.Forms.Label lblSummonCreatureUniqueLimit;
        private System.Windows.Forms.TextBox txtSummonCreatureUniqueRange;
        private System.Windows.Forms.TextBox txtSummonCreatureUniqueLimit;
        private System.Windows.Forms.Label lblSummonCreatureAttackTarget;
        private System.Windows.Forms.ComboBox cmbSummonCreatureAttackTarget;
        private System.Windows.Forms.Label lblSummonCreatureScriptId;
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
        private System.Windows.Forms.CheckBox chkCastSpellFlags1;
        private System.Windows.Forms.CheckBox chkCastSpellFlags2;
        private System.Windows.Forms.Button btnCastSpellId;
        private System.Windows.Forms.Label lblCastSpellId;
        private System.Windows.Forms.Label lblCastSpellTooltip;
        private System.Windows.Forms.Panel frmCommandPlaySound;
        private System.Windows.Forms.GroupBox grpPlaySoundFlags;
        private System.Windows.Forms.CheckBox chkPlaySoundFlags2;
        private System.Windows.Forms.CheckBox chkPlaySoundFlags1;
        private System.Windows.Forms.Label lblPlaySoundId;
        private System.Windows.Forms.Label lblPlaySoundTooltip;
        private System.Windows.Forms.Panel frmCommandCreateItem;
        private System.Windows.Forms.Label lblCreateItemAmount;
        private System.Windows.Forms.TextBox txtCreateItemAmount;
        private System.Windows.Forms.Button btnCreateItemId;
        private System.Windows.Forms.Label lblCreateItemId;
        private System.Windows.Forms.Label lblCreateItemTooltip;
        private System.Windows.Forms.Panel frmCommandSetEquipment;
        private System.Windows.Forms.Label lblSetEquipmentTooltip;
        private System.Windows.Forms.Label lblSetEquipmentRanged;
        private System.Windows.Forms.Label lblSetEquipmentOffHand;
        private System.Windows.Forms.Label lblSetEquipmentMainHand;
        private System.Windows.Forms.Button btnSetEquipmentRanged;
        private System.Windows.Forms.Button btnSetEquipmentOffHand;
        private System.Windows.Forms.Button btnSetEquipmentMainHand;
        private System.Windows.Forms.ComboBox cmbSetEquipmentUseDefault;
        private System.Windows.Forms.Label lblSetEquipmentUseDefault;
        private System.Windows.Forms.Panel frmCommandSetMovement;
        private System.Windows.Forms.Label lblSetMovementAngle;
        private System.Windows.Forms.TextBox txtSetMovementAngle;
        private System.Windows.Forms.TextBox txtSetMovementDistance;
        private System.Windows.Forms.TextBox txtSetMovementIntParam;
        private System.Windows.Forms.ComboBox cmbSetMovementBoolParam;
        private System.Windows.Forms.Label lblSetMovementDistance;
        private System.Windows.Forms.Label lblSetMovementIntParam;
        private System.Windows.Forms.Label lblSetMovementBoolParam;
        private System.Windows.Forms.ComboBox cmbSetMovementType;
        private System.Windows.Forms.Label lblSetMovementType;
        private System.Windows.Forms.Label lblSetMovementTooltip;
        private System.Windows.Forms.Panel frmCommandActiveObject;
        private System.Windows.Forms.ComboBox cmbActiveObjectSetActive;
        private System.Windows.Forms.Label lblActiveObjectSetActive;
        private System.Windows.Forms.Label lblActiveObjectTooltip;
        private System.Windows.Forms.Panel frmCommandSetFaction;
        private System.Windows.Forms.GroupBox grpSetFactionFlags;
        private System.Windows.Forms.CheckBox chkSetFactionFlag4;
        private System.Windows.Forms.CheckBox chkSetFactionFlag2;
        private System.Windows.Forms.CheckBox chkSetFactionFlag1;
        private System.Windows.Forms.Label lblSetFactionId;
        private System.Windows.Forms.Label lblSetFactionTooltip;
        private System.Windows.Forms.Panel frmCommandMorphOrMount;
        private System.Windows.Forms.ComboBox cmbMorphOrMountType;
        private System.Windows.Forms.Label lblMorphOrMountId;
        private System.Windows.Forms.Label lblMorphOrMountType;
        private System.Windows.Forms.Button btnMorphOrMountId;
        private System.Windows.Forms.Label lblMorphOrMountTooltip;
        private System.Windows.Forms.Panel frmCommandSetRun;
        private System.Windows.Forms.ComboBox cmbSetRunMode;
        private System.Windows.Forms.Label lblSetRunMode;
        private System.Windows.Forms.Label lblSetRunTooltip;
        private System.Windows.Forms.Panel frmCommandModifyFlags;
        private System.Windows.Forms.Label lblModifyFlagsTooltip;
        private System.Windows.Forms.Label lblModifyFlagsField;
        private System.Windows.Forms.ComboBox cmbModifyFlagsMode;
        private System.Windows.Forms.Label lblModifyFlagsMode;
        private System.Windows.Forms.ComboBox cmbModifyFlagsFieldId;
        private System.Windows.Forms.Panel frmCommandInterruptCasts;
        private System.Windows.Forms.ComboBox cmbInterruptCastsWithDelayed;
        private System.Windows.Forms.Label lblInterruptCastsSpellId;
        private System.Windows.Forms.Label lblInterruptCastsWithDelayed;
        private System.Windows.Forms.Button btnInterruptCastsSpellId;
        private System.Windows.Forms.Label lblInterruptCastsTooltip;
        private System.Windows.Forms.Panel frmCommandUpdateEntry;
        private System.Windows.Forms.Label lblUpdateEntryCreatureId;
        private System.Windows.Forms.Button btnUpdateEntryCreatureId;
        private System.Windows.Forms.Label lblUpdateEntryTooltip;
        private System.Windows.Forms.Panel frmCommandSetStandState;
        private System.Windows.Forms.ComboBox cmbSetStandState;
        private System.Windows.Forms.Label lblSetStandState;
        private System.Windows.Forms.Label lblSetStandStateTooltip;
        private System.Windows.Forms.Panel frmCommandModifyThreat;
        private System.Windows.Forms.Label lblModifyThreatPercent;
        private System.Windows.Forms.TextBox txtModifyThreatPercent;
        private System.Windows.Forms.ComboBox cmbModifyThreatTarget;
        private System.Windows.Forms.Label lblModifyThreatTarget;
        private System.Windows.Forms.Label lblModifyThreatTooltip;
        private System.Windows.Forms.Panel frmCommandSendTaxiPath;
        private System.Windows.Forms.Label lblSendTaxiPathId;
        private System.Windows.Forms.Label lblSendTaxiPathTooltip;
        private System.Windows.Forms.Label lblSendTaxiPath;
        private System.Windows.Forms.TextBox txtSendTaxiPath;
        private System.Windows.Forms.Button btnSendTaxiPathId;
        private System.Windows.Forms.Panel frmCommandTerminateScript;
        private System.Windows.Forms.Label lblTerminateScriptCondition;
        private System.Windows.Forms.ComboBox cmbTerminateScriptCondition;
        private System.Windows.Forms.Label lblTerminateScriptCreatureId;
        private System.Windows.Forms.Label lblTerminateScriptSearchRadius;
        private System.Windows.Forms.TextBox txtTerminateScriptSearchRadius;
        private System.Windows.Forms.Button btnTerminateScriptCreatureId;
        private System.Windows.Forms.Label lblTerminateScriptTooltip;
        private System.Windows.Forms.Panel frmCommandTerminateCondition;
        private System.Windows.Forms.Button btnTerminateConditionQuest;
        private System.Windows.Forms.Label lblTerminateConditionRule;
        private System.Windows.Forms.ComboBox cmbTerminateConditionRule;
        private System.Windows.Forms.Label lblTerminateConditionId;
        private System.Windows.Forms.Label lblTerminateConditionQuestId;
        private System.Windows.Forms.Button btnTerminateConditionId;
        private System.Windows.Forms.Label lblTerminateConditionTooltip;
        private System.Windows.Forms.Panel frmCommandSetHomePosition;
        private System.Windows.Forms.TextBox txtSetHomePositionY;
        private System.Windows.Forms.TextBox txtSetHomePositionX;
        private System.Windows.Forms.ComboBox cmbSetHomePositionMode;
        private System.Windows.Forms.Label lblSetHomePositionMode;
        private System.Windows.Forms.Label lblSetHomePositionTooltip;
        private System.Windows.Forms.Label lblSetHomePositionO;
        private System.Windows.Forms.Label lblSetHomePositionZ;
        private System.Windows.Forms.TextBox txtSetHomePositionO;
        private System.Windows.Forms.TextBox txtSetHomePositionZ;
        private System.Windows.Forms.Label lblSetHomePositionY;
        private System.Windows.Forms.Label lblSetHomePositionX;
        private System.Windows.Forms.Panel frmCommandSetFacing;
        private System.Windows.Forms.Label lblSetFacingOrientation;
        private System.Windows.Forms.TextBox txtSetFacingOrientation;
        private System.Windows.Forms.ComboBox cmbSetFacingMode;
        private System.Windows.Forms.Label lblSetFacingMode;
        private System.Windows.Forms.Label lblSetFacingTooltip;
        private System.Windows.Forms.Panel frmCommandMeetingStone;
        private System.Windows.Forms.Button btnMeetingStoneAreaId;
        private System.Windows.Forms.Label lblMeetingStoneAreaId;
        private System.Windows.Forms.Label lblMeetingStoneTooltip;
        private System.Windows.Forms.Panel frmCommandSetData;
        private System.Windows.Forms.Label lblSetDataField;
        private System.Windows.Forms.TextBox txtSetDataField;
        private System.Windows.Forms.ComboBox cmbSetDataMode;
        private System.Windows.Forms.Label lblSetDataMode;
        private System.Windows.Forms.Label lblSetDataTooltip;
        private System.Windows.Forms.Label lblSetDataValue;
        private System.Windows.Forms.TextBox txtSetDataValue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCommandCondition;
        private System.Windows.Forms.Label lblCommandCondition;
        private System.Windows.Forms.Button btnPlaySoundId;
        private System.Windows.Forms.Button btnSetFactionId;
        private System.Windows.Forms.Panel frmCommandStartScript;
        private System.Windows.Forms.TextBox txtStartScriptChance4;
        private System.Windows.Forms.TextBox txtStartScriptId4;
        private System.Windows.Forms.TextBox txtStartScriptChance3;
        private System.Windows.Forms.TextBox txtStartScriptId3;
        private System.Windows.Forms.TextBox txtStartScriptChance2;
        private System.Windows.Forms.TextBox txtStartScriptId2;
        private System.Windows.Forms.TextBox txtStartScriptChance1;
        private System.Windows.Forms.TextBox txtStartScriptId1;
        private System.Windows.Forms.Label lblStartScriptChance;
        private System.Windows.Forms.Label lblStartScriptId;
        private System.Windows.Forms.Label lblStartScriptTooltip;
        private System.Windows.Forms.Button btnStartScriptEdit4;
        private System.Windows.Forms.Button btnStartScriptEdit3;
        private System.Windows.Forms.Button btnStartScriptEdit2;
        private System.Windows.Forms.Button btnStartScriptEdit1;
        private System.Windows.Forms.Label lblNoAction;
        private System.Windows.Forms.CheckBox chkMoveToFlagsPointMovement;
        private System.Windows.Forms.Button btnActionCopy;
        private System.Windows.Forms.CheckBox chkSummonCreatureFlags1;
        private System.Windows.Forms.Label lblSummonCreatureDespawnType;
        private System.Windows.Forms.ComboBox cmbSummonCreatureDespawnType;
        private System.Windows.Forms.Button btnViewRaw;
        private System.Windows.Forms.Panel frmCommandSetPhase;
        private System.Windows.Forms.Label lblSetPhasePhase;
        private System.Windows.Forms.Label lblSetPhaseMode;
        private System.Windows.Forms.TextBox txtSetPhasePhase;
        private System.Windows.Forms.ComboBox cmbSetPhaseMode;
        private System.Windows.Forms.Label lblSetPhaseTooltip;
        private System.Windows.Forms.Panel frmCommandSetRandomPhase;
        private System.Windows.Forms.Label lblSetRandomPhase4;
        private System.Windows.Forms.TextBox txtSetRandomPhase4;
        private System.Windows.Forms.Label lblSetRandomPhase3;
        private System.Windows.Forms.TextBox txtSetRandomPhase3;
        private System.Windows.Forms.TextBox txtSetRandomPhase1;
        private System.Windows.Forms.Label lblSetRandomPhase2;
        private System.Windows.Forms.Label lblSetRandomPhase1;
        private System.Windows.Forms.TextBox txtSetRandomPhase2;
        private System.Windows.Forms.Label lblSetRandomPhaseTooltip;
        private System.Windows.Forms.Panel frmCommandFlee;
        private System.Windows.Forms.ComboBox cmbFleeMode;
        private System.Windows.Forms.Label lblFleeMode;
        private System.Windows.Forms.Label lblFleeTooltip;
        private System.Windows.Forms.Panel frmCommandCallForHelp;
        private System.Windows.Forms.Label lblCallForHelpRadius;
        private System.Windows.Forms.TextBox txtCallForHelpRadius;
        private System.Windows.Forms.Label lblCallForHelpTooltip;
        private System.Windows.Forms.Panel frmCommandGameEvent;
        private System.Windows.Forms.ComboBox cmbGameEventAction;
        private System.Windows.Forms.Label lblGameEventId;
        private System.Windows.Forms.Label lblGameEventAction;
        private System.Windows.Forms.Button btnGameEventId;
        private System.Windows.Forms.Label lblCommandGameEventTooltip;
        private System.Windows.Forms.ComboBox cmbGameEventOverwrite;
        private System.Windows.Forms.Label lblGameEventOverwrite;
        private System.Windows.Forms.CheckBox chkCastSpellFlags4;
        private System.Windows.Forms.CheckBox chkCastSpellFlags32;
        private System.Windows.Forms.CheckBox chkCastSpellFlags16;
        private System.Windows.Forms.Panel frmCommandSetSpellsList;
        private System.Windows.Forms.Button btnSetSpellsList4;
        private System.Windows.Forms.TextBox txtSetSpellsListChance4;
        private System.Windows.Forms.Button btnSetSpellsList3;
        private System.Windows.Forms.TextBox txtSetSpellsListChance3;
        private System.Windows.Forms.Button btnSetSpellsList2;
        private System.Windows.Forms.TextBox txtSetSpellsListChance2;
        private System.Windows.Forms.Button btnSetSpellsList1;
        private System.Windows.Forms.TextBox txtSetSpellsListChance1;
        private System.Windows.Forms.Label lblSetSpellsListChance;
        private System.Windows.Forms.Label lblSetSpellsListId;
        private System.Windows.Forms.Label lblSetSpellsListTooltip;
        private System.Windows.Forms.CheckBox chkCastSpellFlags128;
        private System.Windows.Forms.CheckBox chkCastSpellFlags64;
        private System.Windows.Forms.Panel frmCommandSpellCooldown;
        private System.Windows.Forms.Label lblSpellCooldownSeconds;
        private System.Windows.Forms.TextBox txtSpellCooldownSeconds;
        private System.Windows.Forms.Button btnSpellCooldownId;
        private System.Windows.Forms.Label lblSpellCooldownId;
        private System.Windows.Forms.Label lblSpellCooldownTooltip;
        private System.Windows.Forms.Panel frmCommandSetReactState;
        private System.Windows.Forms.ComboBox cmbSetReactState;
        private System.Windows.Forms.Label lblReactState;
        private System.Windows.Forms.Label lblSetReactStateTooltip;
        private System.Windows.Forms.Panel frmCommandStartWaypoints;
        private System.Windows.Forms.TextBox txtStartWaypointsEntry;
        private System.Windows.Forms.Label lblStartWaypointsEntry;
        private System.Windows.Forms.TextBox txtStartWaypointsGuid;
        private System.Windows.Forms.Label lblStartWaypointsGuid;
        private System.Windows.Forms.TextBox txtStartWaypointsInitialDelay;
        private System.Windows.Forms.Label lblStartWaypointsInitialDelay;
        private System.Windows.Forms.TextBox txtStartWaypointsStartPoint;
        private System.Windows.Forms.Label lblStartWaypointsStartPoint;
        private System.Windows.Forms.ComboBox cmbStartWaypointsRepeat;
        private System.Windows.Forms.Label lblStartWaypointsRepeat;
        private System.Windows.Forms.ComboBox cmbStartWaypointsSource;
        private System.Windows.Forms.Label lblStartWaypointsSource;
        private System.Windows.Forms.Label lblStartWaypointsTooltip;
        private System.Windows.Forms.Label lblMoveToPointId;
        private System.Windows.Forms.TextBox txtMoveToPointId;
        private System.Windows.Forms.Panel frmCommandStartScriptedMapEvent;
        private System.Windows.Forms.Button btnStartScriptedMapEventFailureScriptEdit;
        private System.Windows.Forms.Button btnStartScriptedMapEventSuccessScriptEdit;
        private System.Windows.Forms.Label lblStartScriptedMapEventFailureScript;
        private System.Windows.Forms.Button btnStartScriptedMapEventFailureCondition;
        private System.Windows.Forms.TextBox txtStartScriptedMapEventFailureScript;
        private System.Windows.Forms.Label lblStartScriptedMapEventFailureCondition;
        private System.Windows.Forms.Label lblStartScriptedMapEventSuccessScript;
        private System.Windows.Forms.Button btnStartScriptedMapEventSuccessCondition;
        private System.Windows.Forms.TextBox txtStartScriptedMapEventTimeLimit;
        private System.Windows.Forms.Label lblStartScriptedMapEventTimeLimit;
        private System.Windows.Forms.TextBox txtStartScriptedMapEventId;
        private System.Windows.Forms.Label lblStartScriptedMapEventId;
        private System.Windows.Forms.TextBox txtStartScriptedMapEventSuccessScript;
        private System.Windows.Forms.Label lblStartScriptedMapEventSuccessCondition;
        private System.Windows.Forms.Label lblStartScriptedMapEventTooltip;
        private System.Windows.Forms.Panel frmCommandRemoveScriptedMapEventTarget;
        private System.Windows.Forms.ComboBox cmbRemoveScriptedMapEventTarget;
        private System.Windows.Forms.Label lblRemoveScriptedMapEventTarget;
        private System.Windows.Forms.Label lblRemoveScriptedMapEventTargetCondition;
        private System.Windows.Forms.Label lblRemoveScriptedMapEventTargetEventId;
        private System.Windows.Forms.Button btnRemoveScriptedMapEventTargetCondition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemoveScriptedMapEventTargetEventId;
        private System.Windows.Forms.Panel frmCommandSetScriptedMapEventData;
        private System.Windows.Forms.TextBox txtSetScriptedMapEventData;
        private System.Windows.Forms.Label lblSetScriptedMapEventData;
        private System.Windows.Forms.TextBox txtSetScriptedMapEventDataIndex;
        private System.Windows.Forms.TextBox txtSetScriptedMapEventDataEventId;
        private System.Windows.Forms.ComboBox cmbSetScriptedMapEventDataMode;
        private System.Windows.Forms.Label lblSetScriptedMapEventDataMode;
        private System.Windows.Forms.Label lblSetScriptedMapEventDataIndex;
        private System.Windows.Forms.Label lblSetScriptedMapEventDataEventId;
        private System.Windows.Forms.Label lblSetScriptedMapEventDataTooltip;
        private System.Windows.Forms.ComboBox cmbSetMovementClearMotionMaster;
        private System.Windows.Forms.Label lblSetMovementClearMotionMaster;
        private System.Windows.Forms.Panel frmCommandSetDefaultMovement;
        private System.Windows.Forms.ComboBox cmbSetDefaultMovementAlwaysReplace;
        private System.Windows.Forms.TextBox txtSetDefaultMovementParam1;
        private System.Windows.Forms.ComboBox cmbSetDefaultMovementType;
        private System.Windows.Forms.Label lblSetDefaultMovementParam1;
        private System.Windows.Forms.Label lblSetDefaultMovementAlwaysReplace;
        private System.Windows.Forms.Label lblSetDefaultMovementType;
        private System.Windows.Forms.Label lblSetDefaultMovementTooltip;
        private System.Windows.Forms.TextBox txtSummonCreatureScriptId;
        private System.Windows.Forms.Button btnSummonCreatureScriptIdEdit;
        private System.Windows.Forms.Panel frmCommandStartScriptForAll;
        private System.Windows.Forms.Button btnStartScriptForAllObjectEntry;
        private System.Windows.Forms.TextBox txtStartScriptForAllDistance;
        private System.Windows.Forms.Label lblStartScriptForAllDistance;
        private System.Windows.Forms.TextBox txtStartScriptForAllScriptId;
        private System.Windows.Forms.ComboBox cmbStartScriptForAllObjectType;
        private System.Windows.Forms.Label lblStartScriptForAllObjectEntry;
        private System.Windows.Forms.Label lblStartScriptForAllObjectType;
        private System.Windows.Forms.Label lblStartScriptForAllScriptId;
        private System.Windows.Forms.Label lblStartScriptForAllTooltip;
        private System.Windows.Forms.Panel frmCommandUnknown;
        private System.Windows.Forms.TextBox txtUnknownCommandDatalong4;
        private System.Windows.Forms.Label lblUnknownCommandDataint2;
        private System.Windows.Forms.TextBox txtUnknownCommandDatalong2;
        private System.Windows.Forms.Label lblUnknownCommandDataint1;
        private System.Windows.Forms.TextBox txtUnknownCommandY;
        private System.Windows.Forms.TextBox txtUnknownCommandX;
        private System.Windows.Forms.Label lblUnknownCommandY;
        private System.Windows.Forms.Label lblUnknownCommandX;
        private System.Windows.Forms.TextBox txtUnknownCommandDatalong3;
        private System.Windows.Forms.TextBox txtUnknownCommandDatalong1;
        private System.Windows.Forms.Label lblUnknownCommandDatalong2;
        private System.Windows.Forms.Label lblUnknownCommandDatalong1;
        private System.Windows.Forms.Label lblUnknownCommandTooltip;
        private System.Windows.Forms.TextBox txtUnknownCommandDataint4;
        private System.Windows.Forms.Label lblUnkownCommandDataint4;
        private System.Windows.Forms.TextBox txtUnknownCommandDataint2;
        private System.Windows.Forms.Label lblUnkownCommandDataint3;
        private System.Windows.Forms.TextBox txtUnknownCommandDataint3;
        private System.Windows.Forms.TextBox txtUnknownCommandDataint1;
        private System.Windows.Forms.Label lblUnknownCommandDatalong4;
        private System.Windows.Forms.Label lblUnknownCommandDatalong3;
        private System.Windows.Forms.TextBox txtUnknownCommandO;
        private System.Windows.Forms.TextBox txtUnknownCommandZ;
        private System.Windows.Forms.Label lblUnknownCommandO;
        private System.Windows.Forms.Label lblUnknownCommandZ;
        private System.Windows.Forms.Label lblQuestCompleteGroup;
        private System.Windows.Forms.ComboBox cmbQuestCompleteGroup;
        private System.Windows.Forms.ComboBox cmbMorphOrMountPermanent;
        private System.Windows.Forms.Label lblMorphOrMountPermanent;
        private System.Windows.Forms.GroupBox grpAddAuraFlags;
        private System.Windows.Forms.CheckBox chkAddAuraFlag1;
        private System.Windows.Forms.CheckBox chkAddAuraFlag2;
        private System.Windows.Forms.CheckBox chkAddAuraFlag8;
        private System.Windows.Forms.CheckBox chkAddAuraFlag4;
        private System.Windows.Forms.Panel frmCommandSummonObject;
        private System.Windows.Forms.Label lblSummonObjectRespawnTime;
        private System.Windows.Forms.TextBox txtSummonObjectRespawnTime;
        private System.Windows.Forms.Button btnSummonObjectId;
        private System.Windows.Forms.Label lblSummonObjectO;
        private System.Windows.Forms.Label lblSummonObjectZ;
        private System.Windows.Forms.TextBox txtSummonObjectO;
        private System.Windows.Forms.TextBox txtSummonObjectZ;
        private System.Windows.Forms.Label lblSummonObjectY;
        private System.Windows.Forms.Label lblSummonObjectX;
        private System.Windows.Forms.TextBox txtSummonObjectY;
        private System.Windows.Forms.TextBox txtSummonObjectX;
        private System.Windows.Forms.Label lblSummonObjectId;
        private System.Windows.Forms.Label lblSummonObjectTooltip;
        private System.Windows.Forms.Panel frmCommandJoinCreatureGroup;
        private System.Windows.Forms.GroupBox joinCreatureGroupsFlagsGroupBox;
        private System.Windows.Forms.CheckBox chkJoinCreatureGroup128;
        private System.Windows.Forms.CheckBox chkJoinCreatureGroup64;
        private System.Windows.Forms.CheckBox chkJoinCreatureGroup32;
        private System.Windows.Forms.CheckBox chkJoinCreatureGroup16;
        private System.Windows.Forms.CheckBox chkJoinCreatureGroup8;
        private System.Windows.Forms.CheckBox chkJoinCreatureGroup4;
        private System.Windows.Forms.CheckBox chkJoinCreatureGroup2;
        private System.Windows.Forms.CheckBox chkJoinCreatureGroup1;
        private System.Windows.Forms.Label lblJoinCreatureGroupAngle;
        private System.Windows.Forms.Label lblJoinCreatureGroupDistance;
        private System.Windows.Forms.TextBox txtJoinCreatureGroupAngle;
        private System.Windows.Forms.TextBox txtJoinCreatureGroupDistance;
        private System.Windows.Forms.Label lblJoinCreatureGroupTooltip;
        private System.Windows.Forms.CheckBox chkSummonCreatureFlags16;
        private System.Windows.Forms.ComboBox cmbEmoteId4;
        private System.Windows.Forms.Label lblEmoteId4;
        private System.Windows.Forms.ComboBox cmbEmoteId3;
        private System.Windows.Forms.Label lblEmoteId3;
        private System.Windows.Forms.ComboBox cmbEmoteId2;
        private System.Windows.Forms.Label lblEmoteId2;
        private System.Windows.Forms.Button btnTargetParam1;
        private System.Windows.Forms.ComboBox cmbEmoteTargeted;
        private System.Windows.Forms.Label lblEmoteTargeted;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.TextBox txtCommandPriority;
        private System.Windows.Forms.Button btnModifyFlagsFlags;
        private System.Windows.Forms.Label lblModifyFlagsFlags;
        private System.Windows.Forms.CheckBox chkSkipMissingTargets;
        private System.Windows.Forms.Button btnStartScriptForAllEdit;
        private System.Windows.Forms.CheckBox chkPlaySoundFlags4;
        private System.Windows.Forms.Panel frmCommandStartScriptOnZone;
        private System.Windows.Forms.Button btnStartScriptOnZoneScriptIdEdit;
        private System.Windows.Forms.Label lblStartScriptOnZoneWithPets;
        private System.Windows.Forms.ComboBox cmbStartScriptOnZoneWithPets;
        private System.Windows.Forms.Button btnStartScriptOnZoneZoneId;
        private System.Windows.Forms.Label lblStartScriptOnZoneZoneId;
        private System.Windows.Forms.Label lblStartScriptOnZoneScriptId;
        private System.Windows.Forms.TextBox txtStartScriptOnZoneScriptId;
        private System.Windows.Forms.Label lblStartScriptOnZoneTooltip;
    }
}

