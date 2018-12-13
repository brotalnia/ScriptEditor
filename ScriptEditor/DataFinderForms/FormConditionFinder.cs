using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormConditionFinder : ScriptEditor.FormDataFinder
    {
        private bool dontUpdate = false;
        private bool editMode = false;

        private ComboboxPair[] ConditionTeam_ComboOptions =
        {
            new ComboboxPair("Horde", 67),
            new ComboboxPair("Alliance", 469)
        };

        private void ResetBaseControls()
        {
            cmbConditionType.SelectedIndex = -1;
            cmbConditionType.Enabled = false;
            txtConditionId.Text = "";
            txtConditionId.Enabled = false;
            chkConditionFlag1.Checked = false;
            chkConditionFlag1.Enabled = false;
            chkConditionFlag2.Checked = false;
            chkConditionFlag2.Enabled = false;
        }
        private void ResetAndHideConditionSpecificForms()
        {
            // CONDITION_NOT (-3)
            // CONDITION_OR (-2)
            // CONDITION_AND (-1)
            btnConditionNotCondition1.Text = "-NONE-";
            btnConditionNotCondition2.Text = "-NONE-";
            frmConditionNot.Visible = false;

            // CONDITION_AURA (1)
            // CONDITION_SPELL (17)
            btnAuraSpellId.Text = "-NONE-";
            txtAuraEffectIndex.Text = "";
            frmConditionAura.Visible = false;

            // CONDITION_ITEM (2)
            // CONDITION_ITEM_EQUIPPED (3)
            // CONDITION_ITEM_WITH_BANK (23)
            btnItemId.Text = "-NONE-";
            txtItemCount.Text = "";
            frmConditionItem.Visible = false;

            // CONDITION_AREAID (4)
            btnAreaId.Text = "-NONE-";
            frmConditionArea.Visible = false;

            // CONDITION_REPUTATION_RANK_MIN (5)
            btnReputationFactionId.Text = "-NONE-";
            cmbReputationRank.SelectedIndex = 0;
            frmConditionReputation.Visible = false;

            // CONDITION_TEAM (6)
            cmbTeamId.SelectedIndex = 0;
            frmConditionTeam.Visible = false;

            // CONDITION_SKILL (7)
            // CONDITION_SKILL_BELOW (29)
            cmbSkillId.SelectedIndex = 0;
            txtSkillLevel.Text = "";
            frmConditionSkill.Visible = false;

            // CONDITION_QUESTREWARDED (8)
            // CONDITION_QUESTTAKEN (9)
            // CONDITION_QUESTAVAILABLE (19)
            // CONDITION_QUEST_NONE (22)
            btnQuestId.Text = "-NONE-";
            cmbQuestState.SelectedIndex = 0;
            frmConditionQuest.Visible = false;

            // CONDITION_WAR_EFFORT_STAGE (11)
            // CONDITION_LEVEL (15)
            // CONDITION_SOURCE_ENTRY (16)
            txtWarEffortStage.Text = "";
            cmbWarEffortComparison.SelectedIndex = 0;
            frmConditionWarEffort.Visible = false;

            // CONDITION_ACTIVE_GAME_EVENT (12)
            btnGameEventId.Text = "-NONE-";
            frmConditionGameEvent.Visible = false;

            // CONDITION_RACE_CLASS (14)
            btnRaceMask.Text = "-NONE-";
            btnClassMask.Text = "-NONE-";
            frmConditionRaceClass.Visible = false;

            // CONDITION_INSTANCE_SCRIPT (18)
            txtInstanceScriptValue1.Text = "";
            txtInstanceScriptValue2.Text = "";
            frmConditionInstanceScript.Visible = false;

            // CONDITION_NEARBY_CREATURE (20)
            btnNearbyCreatureId.Text = "-NONE-";
            txtNearbyCreatureDistance.Text = "";
            frmConditionNearbyCreature.Visible = false;

            // CONDITION_NEARBY_GAMEOBJECT (21)
            btnNearbyObjectId.Text = "-NONE-";
            txtNearbyObjectDistance.Text = "";
            frmConditionNearbyObject.Visible = false;

            // CONDITION_WOW_PATCH (24)
            cmbContentPatch.SelectedIndex = 0;
            cmbContentPatchComparison.SelectedIndex = 0;
            frmConditionContentPatch.Visible = false;

            // CONDITION_ESCORT (25)
            chkEscortSourceDead.Checked = false;
            chkEscortTargetDead.Checked = false;
            txtEscortDistance.Text = "";
            frmConditionEscort.Visible = false;
        }

        private void ShowConditionSpecificForm(ConditionInfo selectedCondition)
        {
            if (!editMode)
                return;

            switch (selectedCondition.Type)
            {
                case -3: // CONDITION_NOT
                case -2: // CONDITION_OR
                case -1: // CONDITION_AND
                {
                    switch (selectedCondition.Type)
                    {
                        case -3: // CONDITION_NOT
                        {
                            lblConditionNotTooltip.Text = "Returns true if the specified condition is false. The referenced condition needs to have an entry Id that is lower than that of the current condition.";
                            lblConditionNotCondition1.Text = "Condition Id:";
                            lblConditionNotCondition2.Visible = false;
                            btnConditionNotCondition2.Visible = false;
                            break;
                        }
                        case -2: // CONDITION_OR
                        {
                            lblConditionNotTooltip.Text = "Returns true if either one of specified conditions is true. The referenced conditions need to have an entry Id that is lower than that of the current condition.";
                            lblConditionNotCondition1.Text = "Condition Id 1:";
                            lblConditionNotCondition2.Visible = true;
                            btnConditionNotCondition2.Visible = true;
                            break;
                        }
                        case -1: // CONDITION_AND
                        {
                            lblConditionNotTooltip.Text = "Returns true only if both of the specified conditions return true. The referenced conditions need to have an entry Id that is lower than that of the current condition.";
                            lblConditionNotCondition1.Text = "Condition Id 1:";
                            lblConditionNotCondition2.Visible = true;
                            btnConditionNotCondition2.Visible = true;
                            break;
                        }
                    }

                    lblConditionNotCondition1.Visible = true;
                    btnConditionNotCondition1.Visible = true;

                    uint conditionId1 = selectedCondition.Value1;
                    if (conditionId1 > 0)
                        btnConditionNotCondition1.Text = conditionId1.ToString() + " - " + GameData.FindConditionName(conditionId1);
                    uint conditionId2 = selectedCondition.Value2;
                    if (conditionId2 > 0)
                        btnConditionNotCondition2.Text = conditionId2.ToString() + " - " + GameData.FindConditionName(conditionId2);


                    frmConditionNot.Visible = true;
                    break;
                }
                case 0: // CONDITION_NONE
                case 10: // CONDITION_AD_COMMISSION_AURA
                {
                    switch (selectedCondition.Type)
                    {
                        case 0: // CONDITION_NONE
                        {
                            lblConditionNotTooltip.Text = "Always returns true. This condition has no additional parameters.";
                            break;
                        }
                        case 10: // CONDITION_AD_COMMISSION_AURA
                        {
                            lblConditionNotTooltip.Text = "Returns true if the target Player has an Argent Dawn commission aura.";
                            break;
                        }
                    }
                    lblConditionNotCondition1.Visible = false;
                    lblConditionNotCondition2.Visible = false;
                    btnConditionNotCondition1.Visible = false;
                    btnConditionNotCondition2.Visible = false;
                    frmConditionNot.Visible = true;
                    break;
                }
                case 1: // CONDITION_AURA
                case 17: // CONDITION_SPELL
                {
                    switch (selectedCondition.Type)
                    {
                        case 1: // CONDITION_AURA
                        {
                            lblConditionAuraTooltip.Text = "Returns true if the target Unit has an aura from the specified spell.";
                            lblAuraEffectIndex.Text = "Effect Index:";
                            break;
                        }
                        case 17: // CONDITION_SPELL
                        {
                            lblConditionAuraTooltip.Text = "Returns true if the target Player knows the specified spell.";
                            lblAuraEffectIndex.Text = "Reverse Result:";
                            break;
                        }
                    }
                    
                    uint spellId = selectedCondition.Value1;
                    if (spellId > 0)
                        btnAuraSpellId.Text = GameData.FindSpellName(spellId) + " (" + spellId.ToString() + ")";
                    txtAuraEffectIndex.Text = selectedCondition.Value2.ToString();
                    frmConditionAura.Visible = true;
                    break;
                }
                case 2: // CONDITION_ITEM
                case 3: // CONDITION_ITEM_EQUIPPED
                case 23: // CONDITION_ITEM_WITH_BANK
                {
                    switch (selectedCondition.Type)
                    {
                        case 2: // CONDITION_ITEM
                        {
                            lblConditionItemTooltip.Text = "Returns true if the target Player has a minimum count of the specified item. Does not check his bank.";
                            lblItemCount.Text = "Count:";
                            lblItemCount.Visible = true;
                            txtItemCount.Visible = true;
                            break;
                        }
                        case 3: // CONDITION_ITEM_EQUIPPED
                        {
                            lblConditionItemTooltip.Text = "Returns true if the target Player has equipped the specified item.";
                            lblItemCount.Visible = false;
                            txtItemCount.Visible = false;
                            break;
                        }
                        case 23: // CONDITION_ITEM_WITH_BANK
                        {
                            lblConditionItemTooltip.Text = "Returns true if the target Player has a minimum count of the specified item. Also checks his bank.";
                            lblItemCount.Text = "Count:";
                            lblItemCount.Visible = true;
                            txtItemCount.Visible = true;
                            break;
                        }
                    }
                    uint itemId = selectedCondition.Value1;
                    if (itemId > 0)
                        btnItemId.Text = GameData.FindItemName(itemId) + " (" + itemId.ToString() + ")";
                    txtItemCount.Text = selectedCondition.Value2.ToString();
                    frmConditionItem.Visible = true;
                    break;
                }
                case 4: // CONDITION_AREAID
                {
                    uint areaId = selectedCondition.Value1;
                    if (areaId > 0)
                        btnAreaId.Text = GameData.FindAreaName(areaId) + " (" + areaId.ToString() + ")";
                    frmConditionArea.Visible = true;
                    break;
                }
                case 5: // CONDITION_REPUTATION_RANK_MIN
                {
                    uint factionId = selectedCondition.Value1;
                    if (factionId > 0)
                        btnReputationFactionId.Text = GameData.FindFactionName(factionId) + " (" + factionId.ToString() + ")";
                    cmbReputationRank.SelectedIndex = (int)selectedCondition.Value2;
                    frmConditionReputation.Visible = true;
                    break;
                }
                case 6: // CONDITION_TEAM
                {
                    cmbTeamId.SelectedIndex = ComboboxPair.GetIndexFromComboboxPairValue(cmbTeamId, (int)selectedCondition.Value1);
                    frmConditionTeam.Visible = true;
                    break;
                }
                case 7: // CONDITION_SKILL
                case 29: // CONDITION_SKILL_BELOW
                {
                    switch (selectedCondition.Type)
                    {
                        case 7: // CONDITION_SKILL
                        {
                            lblConditionSkillTooltip.Text = "Returns true if the target Player has reached a minimum skill level.";
                            break;
                        }
                        case 29: // CONDITION_SKILL_BEL
                        {
                            lblConditionSkillTooltip.Text = "Returns true if the target Player knows the skill itself but his skill level is below the specified value.";
                            break;
                        }
                    }

                    cmbSkillId.SelectedIndex = ComboboxPair.GetIndexFromComboboxPairValue(cmbSkillId, (int)selectedCondition.Value1);
                    txtSkillLevel.Text = selectedCondition.Value2.ToString();
                    frmConditionSkill.Visible = true;
                    break;
                }
                case 8: // CONDITION_QUESTREWARDED
                case 9: // CONDITION_QUESTTAKEN
                case 19: // CONDITION_QUESTAVAILABLE
                case 22: // CONDITION_QUEST_NONE
                {
                    switch (selectedCondition.Type)
                    {
                        case 8: // CONDITION_QUESTREWARDED
                        {
                            lblConditionQuestTooltip.Text = "Returns true if the target Player has previously completed and turned in the specified quest.";
                            lblQuestState.Visible = false;
                            cmbQuestState.Visible = false;
                            break;
                        }
                        case 9: // CONDITION_QUESTTAKEN
                        {
                            lblConditionQuestTooltip.Text = "Returns true if the target Player currently has the specified quest in his quest log.";
                            lblQuestState.Visible = true;
                            cmbQuestState.Visible = true;
                            cmbQuestState.SelectedIndex = (int)selectedCondition.Value2;
                            break;
                        }
                        case 19: // CONDITION_QUESTAVAILABLE
                        {
                            lblConditionQuestTooltip.Text = "Returns true if the target Player fits the requirements for the specified quest.";
                            lblQuestState.Visible = false;
                            cmbQuestState.Visible = false;
                            break;
                        }
                        case 22: // CONDITION_QUEST_NONE
                        {
                            lblConditionQuestTooltip.Text = "Returns true if the target Player does not currently have the specified quest and has not previously completed it.";
                            lblQuestState.Visible = false;
                            cmbQuestState.Visible = false;
                            break;
                        }
                    }
                    uint questId = selectedCondition.Value1;
                    if (questId > 0)
                        btnQuestId.Text = GameData.FindQuestTitle(questId) + " (" + questId.ToString() + ")";
                    frmConditionQuest.Visible = true;
                    break;
                }
                case 11: // CONDITION_WAR_EFFORT_STAGE
                case 15: // CONDITION_LEVEL
                case 16: // CONDITION_SOURCE_ENTRY
                {
                    switch (selectedCondition.Type)
                    {
                        case 11: // CONDITION_WAR_EFFORT_STAGE
                        {
                            lblConditionWarEffortTooltip.Text = "Returns true if the War Effort event is at the specified stage.";
                            cmbWarEffortComparison.Visible = true;
                            lblWarEffortComparison.Visible = true;
                            lblWarEffortStage.Text = "Stage:";
                            break;
                        }
                        case 15: // CONDITION_LEVEL
                        {
                            lblConditionWarEffortTooltip.Text = "Returns true if the target Player fits the specified level requirement.";
                            cmbWarEffortComparison.Visible = true;
                            lblWarEffortComparison.Visible = true;
                            lblWarEffortStage.Text = "Level:";
                            break;
                        }
                        case 16: // CONDITION_SOURCE_ENTRY
                        {
                            lblConditionWarEffortTooltip.Text = "Returns true if the source WorldObject's entry Id matches the one specified.";
                            cmbWarEffortComparison.Visible = false;
                            lblWarEffortComparison.Visible = false;
                            lblWarEffortStage.Text = "Entry:";
                            break;
                        }
                    }
                    txtWarEffortStage.Text = selectedCondition.Value1.ToString();
                    cmbWarEffortComparison.SelectedIndex = (int)selectedCondition.Value2;
                    frmConditionWarEffort.Visible = true;
                    break;
                }
                case 12: // CONDITION_ACTIVE_GAME_EVENT
                {
                    uint eventId = selectedCondition.Value1;
                    if (eventId > 0)
                        btnGameEventId.Text = GameData.FindEventName(eventId) + " (" + eventId.ToString() + ")";
                    frmConditionGameEvent.Visible = true;
                    break;
                }
                case 14: // CONDITION_RACE_CLASS
                {
                    btnRaceMask.Text = GetRaceNamesFromMask(selectedCondition.Value1);
                    btnClassMask.Text = GetClassNamesFromMask(selectedCondition.Value2);
                    frmConditionRaceClass.Visible = true;
                    break;
                }
                case 18: // CONDITION_INSTANCE_SCRIPT
                {
                    txtInstanceScriptValue1.Text = selectedCondition.Value1.ToString();
                    txtInstanceScriptValue2.Text = selectedCondition.Value2.ToString();
                    frmConditionInstanceScript.Visible = true;
                    break;
                }
                case 20: // CONDITION_NEARBY_CREATURE
                {
                    uint creatureId = selectedCondition.Value1;
                    if (creatureId > 0)
                        btnNearbyCreatureId.Text = GameData.FindCreatureName(creatureId) + " (" + creatureId.ToString() + ")";
                    txtNearbyCreatureDistance.Text = selectedCondition.Value2.ToString();
                    frmConditionNearbyCreature.Visible = true;
                    break;
                }
                case 21: // CONDITION_NEARBY_GAMEOBJECT
                {
                    uint objectId = selectedCondition.Value1;
                    if (objectId > 0)
                        btnNearbyObjectId.Text = GameData.FindGameObjectName(objectId) + " (" + objectId.ToString() + ")";
                    txtNearbyObjectDistance.Text = selectedCondition.Value2.ToString();
                    frmConditionNearbyObject.Visible = true;
                    break;
                }
                case 24: // CONDITION_WOW_PATCH
                {
                    cmbContentPatch.SelectedIndex = (int)selectedCondition.Value1;
                    cmbContentPatchComparison.SelectedIndex = (int)selectedCondition.Value2;
                    frmConditionContentPatch.Visible = true;
                    break;
                }
                case 25: // CONDITION_ESCORT
                {
                    if ((selectedCondition.Value1 & 1) != 0)
                        chkEscortSourceDead.Checked = true;
                    if ((selectedCondition.Value1 & 2) != 0)
                        chkEscortTargetDead.Checked = true;
                    txtEscortDistance.Text = selectedCondition.Value2.ToString();
                    frmConditionEscort.Visible = true;
                    break;
                }
            }
        }

        public FormConditionFinder()
        {
            InitializeComponent();
            dontUpdate = true;
            lstData.Height = 305;
            cmbConditionType.DataSource = GameData.ConditionNamesList;
            txtConditionId.AutoSize = false;
            txtConditionId.Height = 21;
            cmbConditionType.SelectedIndex = -1;
            cmbTeamId.DataSource = ConditionTeam_ComboOptions;
            cmbSkillId.DataSource = GameData.SkillsList;
            dontUpdate = false;
        }

        protected override void AddAllData()
        {
            dontUpdate = true;
            ResetBaseControls();
            ResetAndHideConditionSpecificForms();
            dontUpdate = false;

            foreach (ConditionInfo condition in GameData.ConditionInfoList)
            {
                AddConditionToListView(condition);
            }
        }
        protected override void AddById(uint id)
        {
            dontUpdate = true;
            ResetBaseControls();
            ResetAndHideConditionSpecificForms();
            dontUpdate = false;

            foreach (ConditionInfo condition in GameData.ConditionInfoList)
            {
                if (condition.ID == id)
                    AddConditionToListView(condition);
            }
        }
        protected override void AddByIdRange(uint minId, uint maxId)
        {
            dontUpdate = true;
            ResetBaseControls();
            ResetAndHideConditionSpecificForms();
            dontUpdate = false;

            foreach (ConditionInfo condition in GameData.ConditionInfoList)
            {
                if ((condition.ID >= minId) && (condition.ID <= maxId))
                    AddConditionToListView(condition);
            }
        }
        private void AddConditionToListView(ConditionInfo condition)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = condition.ID.ToString();
            lvi.SubItems.Add(GameData.FindConditionTypeName(condition.Type));
            lvi.SubItems.Add(condition.Value1.ToString());
            lvi.SubItems.Add(condition.Value2.ToString());
            lvi.SubItems.Add(condition.Value3.ToString());
            lvi.SubItems.Add(condition.Value4.ToString());
            lvi.SubItems.Add(condition.Flags.ToString());
            lvi.Tag = condition;

            // Add this condition to the listview.
            lstData.Items.Add(lvi);
        }

        private void FormConditionFinder_ResizeEnd(object sender, EventArgs e)
        {
            lstData.Columns[1].Width = lstData.ClientSize.Width - lstData.Columns[0].Width - lstData.Columns[2].Width - lstData.Columns[3].Width - lstData.Columns[4].Width - lstData.Columns[5].Width - lstData.Columns[6].Width;
        }
        private void UpdateSelectedItem()
        {
            if (lstData.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstData.SelectedItems[0];

                // Get the associated ConditionInfo.
                ConditionInfo currentCondition = (ConditionInfo)currentItem.Tag;

                currentItem.Text = currentCondition.ID.ToString();
                currentItem.SubItems[1].Text = GameData.FindConditionTypeName(currentCondition.Type);
                currentItem.SubItems[2].Text = currentCondition.Value1.ToString();
                currentItem.SubItems[3].Text = currentCondition.Value2.ToString();
                currentItem.SubItems[4].Text = currentCondition.Value3.ToString();
                currentItem.SubItems[5].Text = currentCondition.Value4.ToString();
            }
        }

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstData.SelectedItems.Count == 0)
            {
                dontUpdate = true;
                ResetBaseControls();
                ResetAndHideConditionSpecificForms();
                dontUpdate = false;
                return;
            }

            dontUpdate = true;
            ListViewItem selectedItem = lstData.SelectedItems[0];
            ConditionInfo selectedCondition = (ConditionInfo)selectedItem.Tag;

            cmbConditionType.SelectedIndex = selectedCondition.Type + 3;
            cmbConditionType.Enabled = true;

            txtConditionId.Text = selectedCondition.ID.ToString();
            txtConditionId.Enabled = true;

            chkConditionFlag1.Enabled = true;
            chkConditionFlag2.Enabled = true;

            if ((selectedCondition.Flags & 1) != 0)
                chkConditionFlag1.Checked = true;
            if ((selectedCondition.Flags & 2) != 0)
                chkConditionFlag2.Checked = true;

            ShowConditionSpecificForm(selectedCondition);
            dontUpdate = false;
        }

        private void cmbConditionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstData.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstData.SelectedItems[0];

                // Get the associated ConditionInfo.
                ConditionInfo currentCondition = (ConditionInfo)currentItem.Tag;

                currentCondition.Type = cmbConditionType.SelectedIndex - 3;
                currentCondition.Value1 = 0;
                currentCondition.Value2 = 0;
                currentCondition.Value3 = 0;
                currentCondition.Value4 = 0;
                UpdateSelectedItem();

                dontUpdate = true;
                ResetAndHideConditionSpecificForms();
                ShowConditionSpecificForm(currentCondition);
                dontUpdate = false;
            }
        }

        // Generic function for setting script field to specified value;
        private void SetScriptFieldFromValue(float fieldvalue, string fieldname)
        {
            if (lstData.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstData.SelectedItems[0];

                // Get the associated ConditionInfo.
                ConditionInfo currentEvent = (ConditionInfo)currentItem.Tag;

                // Get the field we need to change.
                FieldInfo prop = typeof(ConditionInfo).GetField(fieldname, BindingFlags.Instance | BindingFlags.Public);

                // Updating the value in the field.
                prop.SetValue(currentEvent, Convert.ChangeType(fieldvalue, prop.FieldType));

                UpdateSelectedItem();
            }
        }
        // Generic function for setting field value from a textbox.
        private void SetScriptFieldFromTextbox(TextBox ctrl, string fieldname)
        {
            // Get the value from the textbox.
            float fieldValue;
            float.TryParse(ctrl.Text, out fieldValue);

            // Set the field value.
            SetScriptFieldFromValue(fieldValue, fieldname);
        }
        // Generic function for setting field value from a checkbox.
        private void SetScriptFieldFromCombobox(ComboBox cmbbox, string fieldname, bool usePairValue)
        {
            if (dontUpdate)
                return;

            // We can use either selected index or the pair value.
            int selectedValue = usePairValue ? (cmbbox.SelectedItem as ComboboxPair).Value : cmbbox.SelectedIndex;

            // Set the field value.
            SetScriptFieldFromValue(selectedValue, fieldname);
        }
        // Generic function for updating flags based on checkbox.
        private void SetScriptFlagsFromCheckbox(CheckBox chkbox, string fieldname, uint value)
        {
            if (dontUpdate)
                return;

            if (lstData.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstData.SelectedItems[0];

                // Get the associated ConditionInfo.
                ConditionInfo currentEvent = (ConditionInfo)currentItem.Tag;

                // Get the field we need to change.
                FieldInfo prop = typeof(ConditionInfo).GetField(fieldname, BindingFlags.Instance | BindingFlags.Public);

                // Get the old value in this field.
                uint currentValue = (uint)prop.GetValue(currentEvent);

                if (chkbox.Checked)
                    currentValue += value;
                else
                    currentValue -= value;

                prop.SetValue(currentEvent, Convert.ChangeType(currentValue, prop.FieldType));

                UpdateSelectedItem();
            }
        }
        // Generic function for setting a value from another form.
        private void SetScriptFieldFromDataFinderForm<TFinderForm>(Button btn, TextBox txtbox, NameFinder finder, string fieldname) where TFinderForm : FormDataFinder, new()
        {
            FormDataFinder frm = new TFinderForm();
            if (frm.ShowDialog(GetScriptFieldValue(fieldname)) == System.Windows.Forms.DialogResult.OK)
            {
                int returnId = frm.ReturnValue;

                if (returnId > 0)
                {
                    // If there is no textbox provided the text is shown on the button.
                    if (txtbox == null)
                        btn.Text = finder((uint)returnId) + " (" + returnId.ToString() + ")";
                    else
                    {
                        btn.Text = returnId.ToString();
                        txtbox.Text = finder((uint)returnId);
                    }
                }
                else if (returnId < 0)
                {
                    btn.Text = "-IGNORE-";
                }
                else
                {
                    btn.Text = "-NONE-";
                    if (txtbox != null)
                        txtbox.Text = "";
                }

                // Set the field value.
                SetScriptFieldFromValue(returnId, fieldname);
            }
        }
        // Generic function for getting int value in field.
        private int GetScriptFieldValue(string fieldname)
        {
            if (lstData.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstData.SelectedItems[0];

                // Get the associated ConditionInfo.
                ConditionInfo currentAction = (ConditionInfo)currentItem.Tag;

                // Get the field by name.
                FieldInfo prop = typeof(ConditionInfo).GetField(fieldname, BindingFlags.Instance | BindingFlags.Public);

                // Get the value in this field.
                int currentValue = (int)Convert.ChangeType(prop.GetValue(currentAction), typeof(int));

                return currentValue;
            }
            return 0;
        }
        private bool IsAvailableConditionId(uint conditionId)
        {
            bool ok = (conditionId > 0);
            foreach (ConditionInfo condition in GameData.ConditionInfoList)
            {
                if (condition.ID == conditionId)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
        private void txtConditionId_Leave(object sender, EventArgs e)
        {
            uint conditionId;
            if (uint.TryParse(txtConditionId.Text, out conditionId))
            {
                if (conditionId != GetScriptFieldValue("ID"))
                {
                    if (IsAvailableConditionId(conditionId))
                    {
                        if (lstData.SelectedItems.Count > 0)
                        {
                            ListViewItem currentItem = lstData.SelectedItems[0];
                            currentItem.Text = conditionId.ToString();
                            ConditionInfo currentCondition = (ConditionInfo)currentItem.Tag;
                            currentCondition.ID = conditionId;
                        }
                    }
                    else
                    {
                        txtConditionId.Text = GetScriptFieldValue("ID").ToString();
                        MessageBox.Show("A condition with that Id already exists.", "Invalid Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                txtConditionId.Text = GetScriptFieldValue("ID").ToString();
        }

        private void chkConditionFlag1_CheckedChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstData.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstData.SelectedItems[0];

                // Get the associated ConditionInfo.
                ConditionInfo currentCondition = (ConditionInfo)currentItem.Tag;

                // Get the old value in this field.
                uint currentValue = currentCondition.Flags;

                if (chkConditionFlag1.Checked)
                    currentValue += 1;
                else
                    currentValue -= 1;

                currentCondition.Flags = currentValue;
                currentItem.SubItems[6].Text = currentValue.ToString();
            }
        }

        private void chkConditionFlag2_CheckedChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstData.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstData.SelectedItems[0];

                // Get the associated ConditionInfo.
                ConditionInfo currentCondition = (ConditionInfo)currentItem.Tag;

                // Get the old value in this field.
                uint currentValue = currentCondition.Flags;

                if (chkConditionFlag2.Checked)
                    currentValue += 2;
                else
                    currentValue -= 2;

                currentCondition.Flags = currentValue;
                currentItem.SubItems[6].Text = currentValue.ToString();
            }
        }

        private void btnEditAdd_Click(object sender, EventArgs e)
        {
            if (!editMode)
            {
                editMode = true;
                lstData.Height = 123;
                txtConditionId.Visible = true;
                chkConditionFlag1.Visible = true;
                chkConditionFlag2.Visible = true;
                cmbConditionType.Visible = true;
                btnSave.Visible = true;
                btnSaveAll.Visible = true;
                btnDelete.Visible = true;
                btnEditAdd.Text = "Add";

                if (lstData.SelectedItems.Count > 0)
                {
                    // Get the selected item in the listview.
                    ListViewItem currentItem = lstData.SelectedItems[0];

                    // Get the associated ConditionInfo.
                    ConditionInfo currentCondition = (ConditionInfo)currentItem.Tag;

                    ShowConditionSpecificForm(currentCondition);
                }
            }
            else
            {
                string newId = "";
                DialogResult result_name = Helpers.ShowInputDialog(ref newId, "Condition Id");
                if ((result_name != DialogResult.OK) || (newId == ""))
                    return;

                uint conditionId;
                if (!uint.TryParse(newId, out conditionId) || !IsAvailableConditionId(conditionId))
                {
                    MessageBox.Show("A condition with that Id already exists.", "Invalid Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create new condition.
                ConditionInfo condition = new ConditionInfo(conditionId, 0, 0, 0, 0, 0, 0);
                GameData.ConditionInfoList.Add(condition);

                // Create new listview option.
                ListViewItem lvi = new ListViewItem();
                lvi.Text = newId;
                lvi.SubItems.Add(GameData.FindConditionTypeName(condition.Type));
                lvi.SubItems.Add(condition.Value1.ToString());
                lvi.SubItems.Add(condition.Value2.ToString());
                lvi.SubItems.Add(condition.Value3.ToString());
                lvi.SubItems.Add(condition.Value4.ToString());
                lvi.SubItems.Add(condition.Flags.ToString());
                lvi.Tag = condition;

                // Add this condition to the listview.
                lstData.Items.Add(lvi);

                // Select the new item.
                lstData.SelectedItems.Clear();
                lstData.FocusedItem = lvi;
                lvi.Selected = true;
                lstData.Select();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstData.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstData.SelectedItems[0];

                // Get the associated ConditionInfo.
                ConditionInfo currentCondition = (ConditionInfo)currentItem.Tag;

                // Remove the condition and listview item.
                GameData.ConditionInfoList.Remove(currentCondition);
                currentItem.Tag = null;
                currentItem.Remove();
            }
        }

        private string GenerateSaveQuery(ConditionInfo saveCondition)
        {
            ConditionInfo condition = GameData.OriginalConditionInfoList.Find(i => i.ID == saveCondition.ID);

            if (condition != null)
            {
                // Update existing condition.
                List<string> fields = new List<string>();
                if (saveCondition.Type != condition.Type)
                    fields.Add("`type`=" + saveCondition.Type.ToString());
                if (saveCondition.Value1 != condition.Value1)
                    fields.Add("`value1`=" + saveCondition.Value1.ToString());
                if (saveCondition.Value2 != condition.Value2)
                    fields.Add("`value2`=" + saveCondition.Value2.ToString());
                if (saveCondition.Value3 != condition.Value3)
                    fields.Add("`value3`=" + saveCondition.Value3.ToString());
                if (saveCondition.Value4 != condition.Value4)
                    fields.Add("`value4`=" + saveCondition.Value4.ToString());
                if (saveCondition.Flags != condition.Flags)
                    fields.Add("`flags`=" + saveCondition.Flags.ToString());

                if (fields.Count > 0)
                {
                    string query = "UPDATE `conditions` SET ";
                    for (int i = 0; i < fields.Count; i++)
                    {
                        if (i != 0)
                            query += ", ";
                        query += fields[i];
                    }
                    query += " WHERE `condition_entry`=" + saveCondition.ID.ToString() + ";\n";
                    return query;
                }

                // Nothing to update.
                return "";
            }
            // Insert a new condition.
            return "INSERT INTO `conditions` (`condition_entry`, `type`, `value1`, `value2`, `value3`, `value4`, `flags`) VALUES (" + saveCondition.ID.ToString() + ", " + saveCondition.Type.ToString() + ", " + saveCondition.Value1.ToString() + ", " + saveCondition.Value2.ToString() + ", " + saveCondition.Value3.ToString() + ", " + saveCondition.Value4.ToString() + ", " + saveCondition.Flags.ToString() + ");\n";
        }
        private void ShowDialogAndSave(string query)
        {
            if (Helpers.ShowSaveDialog(ref query) == DialogResult.OK)
            {
                MySqlConnection conn = new MySqlConnection(Program.connString);
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = query;
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Save Condition", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstData.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstData.SelectedItems[0];

                // Get the associated ConditionInfo.
                ConditionInfo currentCondition = (ConditionInfo)currentItem.Tag;

                string query = GenerateSaveQuery(currentCondition);
                if (query.Length == 0)
                {
                    if (MessageBox.Show("You have not made any changes!\nDo you want to generate a query for this condition anyway?", "Nothing to save", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        query = "REPLACE INTO `conditions` (`condition_entry`, `type`, `value1`, `value2`, `value3`, `value4`, `flags`) VALUES (" + currentCondition.ID.ToString() + ", " + currentCondition.Type.ToString() + ", " + currentCondition.Value1.ToString() + ", " + currentCondition.Value2.ToString() + ", " + currentCondition.Value3.ToString() + ", " + currentCondition.Value4.ToString() + ", " + currentCondition.Flags.ToString() + ");\n";
                    else
                        return;
                }

                ShowDialogAndSave(query);
            }
        }
        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            List<uint> deletedConditions = new List<uint>();
            foreach (ConditionInfo originalCondition in GameData.OriginalConditionInfoList)
            {
                if (GameData.ConditionInfoList.Find(i => i.ID == originalCondition.ID) == null)
                    deletedConditions.Add(originalCondition.ID);
            }

            string query = "";
            foreach (uint deletedId in deletedConditions)
            {
                query += "DELETE FROM `conditions` WHERE `condition_entry`=" + deletedId.ToString() + ";\n";
            }

            foreach (ConditionInfo condition in GameData.ConditionInfoList)
            {
                query += GenerateSaveQuery(condition);
            }

            if (query.Length == 0)
            {
                MessageBox.Show("You have not made any changes!", "Nothing to save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Helpers.ShowSaveDialog(ref query) == DialogResult.OK)
            {
                MySqlConnection conn = new MySqlConnection(Program.connString);
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = query;
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Save Condition", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }

        // CONDITION_NOT
        // CONDITION_OR
        // CONDITION_AND
        private void btnConditionNotCondition1_Click(object sender, EventArgs e)
        {
            FormConditionFinder frm = new FormConditionFinder();
            if (frm.ShowDialog(GetScriptFieldValue("Value1")) == System.Windows.Forms.DialogResult.OK)
            {
                int returnId = frm.ReturnValue;

                if (returnId > 0)
                    btnConditionNotCondition1.Text = returnId.ToString() + " - " + GameData.FindConditionName((uint)returnId);
                else
                    btnConditionNotCondition1.Text = "-NONE-";

                SetScriptFieldFromValue(returnId, "Value1");
            }
        }
        private void btnConditionNotCondition2_Click(object sender, EventArgs e)
        {
            FormConditionFinder frm = new FormConditionFinder();
            if (frm.ShowDialog(GetScriptFieldValue("Value2")) == System.Windows.Forms.DialogResult.OK)
            {
                int returnId = frm.ReturnValue;

                if (returnId > 0)
                    btnConditionNotCondition2.Text = returnId.ToString() + " - " + GameData.FindConditionName((uint)returnId);
                else
                    btnConditionNotCondition2.Text = "-NONE-";

                SetScriptFieldFromValue(returnId, "Value2");
            }
        }
        // CONDITION_AURA
        // CONDITION_SPELL
        private void btnAuraSpellId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormSpellFinder>(btnAuraSpellId, null, GameData.FindSpellName, "Value1");
        }
        private void txtAuraEffectIndex_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtAuraEffectIndex, "Value2");
        }
        // CONDITION_ITEM
        // CONDITION_ITEM_EQUIPPED
        // CONDITION_ITEM_WITH_BANK
        private void btnItemId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormItemFinder>(btnItemId, null, GameData.FindItemName, "Value1");
        }
        private void txtItemCount_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtItemCount, "Value2");
        }
        // CONDITION_AREAID
        private void btnAreaId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormAreaFinder>(btnAreaId, null, GameData.FindAreaName, "Value1");
        }
        // CONDITION_REPUTATION_RANK_MIN
        private void btnReputationFactionId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormFactionFinder>(btnReputationFactionId, null, GameData.FindFactionName, "Value1");
        }
        private void cmbReputationRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbReputationRank, "Value2", false);
        }
        // CONDITION_TEAM
        private void cmbTeamId_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbTeamId, "Value1", true);
        }
        // CONDITION_SKILL
        // CONDITION_SKILL_BELOW
        private void cmbSkillId_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSkillId, "Value1", true);
        }
        private void txtSkillLevel_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSkillLevel, "Value2");
        }
        // CONDITION_QUESTREWARDED
        // CONDITION_QUESTTAKEN
        // CONDITION_QUESTAVAILABLE
        // CONDITION_QUEST_NONE
        private void btnQuestId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormQuestFinder>(btnQuestId, null, GameData.FindQuestTitle, "Value1");
        }
        private void cmbQuestState_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbQuestState, "Value2", false);
        }
        // CONDITION_WAR_EFFORT_STAGE
        private void txtWarEffortStage_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtWarEffortStage, "Value1");
        }
        private void cmbWarEffortComparison_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbWarEffortComparison, "Value2", false);
        }
        // CONDITION_ACTIVE_GAME_EVENT
        private void btnGameEventId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormEventFinder>(btnGameEventId, null, GameData.FindEventName, "Value1");
        }
        // CONDITION_RACE_CLASS
        private string GetRaceNamesFromMask(uint mask)
        {
            List<string> races = new List<string>();
            if ((mask & 1) != 0)
                races.Add("Human");
            if ((mask & 2) != 0)
                races.Add("Orc");
            if ((mask & 4) != 0)
                races.Add("Dwarf");
            if ((mask & 8) != 0)
                races.Add("Night Elf");
            if ((mask & 16) != 0)
                races.Add("Undead");
            if ((mask & 32) != 0)
                races.Add("Tauren");
            if ((mask & 64) != 0)
                races.Add("Gnome");
            if ((mask & 128) != 0)
                races.Add("Troll");

            if (races.Count > 0)
            {
                string return_string = "";
                for (int i = 0; i < races.Count; i++)
                {
                    if (i != 0)
                        return_string += ", ";
                    return_string += races[i];
                }
                return return_string;
            }

            return "-NONE-";
        }
        private string GetClassNamesFromMask(uint mask)
        {
            List<string> classes = new List<string>();
            if ((mask & 1) != 0)
                classes.Add("Warrior");
            if ((mask & 2) != 0)
                classes.Add("Paladin");
            if ((mask & 4) != 0)
                classes.Add("Hunter");
            if ((mask & 8) != 0)
                classes.Add("Rogue");
            if ((mask & 16) != 0)
                classes.Add("Priest");
            if ((mask & 32) != 0)
                classes.Add("Shaman");
            if ((mask & 64) != 0)
                classes.Add("Mage");
            if ((mask & 128) != 0)
                classes.Add("Warlock");
            if ((mask & 256) != 0)
                classes.Add("Druid");

            if (classes.Count > 0)
            {
                string return_string = "";
                for (int i = 0; i < classes.Count; i++)
                {
                    if (i != 0)
                        return_string += ", ";
                    return_string += classes[i];
                }
                return return_string;
            }

            return "-NONE-";
        }
        private void btnRaceMask_Click(object sender, EventArgs e)
        {
            uint race_mask = (uint)GetScriptFieldValue("Value1");
            FormRaceMask formRaceMask = new FormRaceMask(race_mask);
            if (formRaceMask.ShowDialog() == DialogResult.OK)
            {
                SetScriptFieldFromValue(formRaceMask.ReturnValue, "Value1");
                btnRaceMask.Text = GetRaceNamesFromMask(formRaceMask.ReturnValue);
            }
        }
        private void btnClassMask_Click(object sender, EventArgs e)
        {
            uint class_mask = (uint)GetScriptFieldValue("Value2");
            FormClassMask formClassMask = new FormClassMask(class_mask);
            if (formClassMask.ShowDialog() == DialogResult.OK)
            {
                SetScriptFieldFromValue(formClassMask.ReturnValue, "Value2");
                btnClassMask.Text = GetClassNamesFromMask(formClassMask.ReturnValue);
            }
        }
        // CONDITION_INSTANCE_SCRIPT
        private void txtInstanceScriptValue1_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtInstanceScriptValue1, "Value1");
        }
        private void txtInstanceScriptValue2_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtInstanceScriptValue2, "Value2");
        }
        // CONDITION_NEARBY_CREATURE
        private void btnNearbyCreatureId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormCreatureFinder>(btnNearbyCreatureId, null, GameData.FindCreatureName, "Value1");
        }
        private void txtNearbyCreatureDistance_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtNearbyCreatureDistance, "Value2");
        }
        // CONDITION_NEARBY_GAMEOBJECT
        private void btnNearbyObjectId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<DataFinderForms.FormGameObjectFinder>(btnNearbyObjectId, null, GameData.FindGameObjectName, "Value1");
        }
        private void txtNearbyObjectDistance_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtNearbyObjectDistance, "Value2");
        }
        // CONDITION_WOW_PATCH
        private void cmbContentPatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbContentPatch, "Value1", false);
        }
        private void cmbContentPatchComparison_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbContentPatchComparison, "Value2", false);
        }
        // CONDITION_ESCORT
        private void chkEscortSourceDead_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkEscortSourceDead, "Value1", 1);
        }
        private void chkEscortTargetDead_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkEscortTargetDead, "Value1", 2);
        }
        private void txtEscortDistance_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtEscortDistance, "Value2");
        }
    }
}
