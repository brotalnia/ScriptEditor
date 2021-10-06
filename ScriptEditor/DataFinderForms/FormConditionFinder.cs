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
        private List<Panel> conditionFormsList = new List<Panel>();
        private List<Label> conditionTooltipsList = new List<Label>();
        private void AddControlsToLists()
        {
            conditionFormsList.Clear();
            conditionFormsList.Add(frmConditionNot);
            conditionFormsList.Add(frmConditionAnd);
            conditionFormsList.Add(frmConditionNot);
            conditionFormsList.Add(frmConditionAura);
            conditionFormsList.Add(frmConditionItem);
            conditionFormsList.Add(frmConditionArea);
            conditionFormsList.Add(frmConditionReputation);
            conditionFormsList.Add(frmConditionTeam);
            conditionFormsList.Add(frmConditionSkill);
            conditionFormsList.Add(frmConditionQuest);
            conditionFormsList.Add(frmConditionWarEffort);
            conditionFormsList.Add(frmConditionGameEvent);
            conditionFormsList.Add(frmConditionRaceClass);
            conditionFormsList.Add(frmConditionInstanceScript);
            conditionFormsList.Add(frmConditionNearbyCreature);
            conditionFormsList.Add(frmConditionNearbyObject);
            conditionFormsList.Add(frmConditionContentPatch);
            conditionFormsList.Add(frmConditionEscort);
            conditionFormsList.Add(frmConditionInstanceData);
            conditionFormsList.Add(frmConditionMapEventData);
            conditionFormsList.Add(frmConditionMapEventTargets);
            conditionFormsList.Add(frmConditionDbGuid);
            conditionFormsList.Add(frmConditionLocalTime);
            conditionFormsList.Add(frmConditionUnknown);
            conditionTooltipsList.Clear();
            conditionTooltipsList.Add(lblConditionNotTooltip);
            conditionTooltipsList.Add(lblConditionAndTooltip);
            conditionTooltipsList.Add(lblConditionAuraTooltip);
            conditionTooltipsList.Add(lblConditionItemTooltip);
            conditionTooltipsList.Add(lblConditionAreaTooltip);
            conditionTooltipsList.Add(lblConditionReputationTooltip);
            conditionTooltipsList.Add(lblConditionTeamTooltip);
            conditionTooltipsList.Add(lblConditionSkillTooltip);
            conditionTooltipsList.Add(lblConditionQuestTooltip);
            conditionTooltipsList.Add(lblConditionWarEffortTooltip);
            conditionTooltipsList.Add(lblConditionGameEventTooltip);
            conditionTooltipsList.Add(lblConditionRaceClassTooltip);
            conditionTooltipsList.Add(lblConditionInstanceScriptTooltip);
            conditionTooltipsList.Add(lblConditionNearbyCreatureTooltip);
            conditionTooltipsList.Add(lblConditionNearbyObjectTooltip);
            conditionTooltipsList.Add(lblConditionContentPatchTooltip);
            conditionTooltipsList.Add(lblConditionEscortTooltip);
            conditionTooltipsList.Add(lblConditionInstanceDataTooltip);
            conditionTooltipsList.Add(lblConditionMapEventDataTooltip);
            conditionTooltipsList.Add(lblConditionMapEventTargetsTooltip);
            conditionTooltipsList.Add(lblConditionDbGuidTooltip);
            conditionTooltipsList.Add(lblConditionLocalTimeTooltip);
            conditionTooltipsList.Add(lblConditionUnknownTooltip);
        }
        private ComboboxPair[] ConditionTeam_ComboOptions =
        {
            new ComboboxPair("Horde", 67),
            new ComboboxPair("Alliance", 469)
        };

        private ComboboxPair[] ConditionGender_ComboOptions =
        {
            new ComboboxPair("Male", 0),
            new ComboboxPair("Female", 1),
            new ComboboxPair("None", 2)
        };

        private ComboboxPair[] ConditionObjectGoState_ComboOptions =
        {
            new ComboboxPair("Active", 0),
            new ComboboxPair("Ready", 1),
            new ComboboxPair("Alternative", 2),
        };

        private ComboboxPair[] ConditionObjectLootState_ComboOptions =
        {
            new ComboboxPair("Not Ready", 0),
            new ComboboxPair("Ready", 1),
            new ComboboxPair("Activated", 2),
            new ComboboxPair("Just Deactivated", 3),
        };

        private ComboboxPair[] ConditionIsPlayer_ComboOptions =
        {
            new ComboboxPair("Only Real Players", 0),
            new ComboboxPair("Including Player Pets", 1)
        };

        public void ShowStandalone()
        {
            this.ControlBox = true;
            this.MinimizeBox = true;
            this.ShowIcon = true;
            this.Text = "Condition Editor";
            this.ShowInTaskbar = true;
            btnEditAdd_Click(null, null);
            this.Show();
        }

        private string GetComparisonOperatorName(int value)
        {
            switch (value)
            {
                case 0: // ==
                    return "Equal To";
                case 1: // >= 
                    return "Equal Or Greater Than";
                case 2: // <=
                    return "Equal Or Less Than";
            }
            return "";
        }

        private string DescribeCondition(ConditionInfo condition, bool targetsSwapped)
        {
            string description = condition.ID + ": ";
            if ((condition.Flags & 1) != 0) // reverse result
                description += " Not (";
            if ((condition.Flags & 2) != 0) // swap targets
                targetsSwapped = !targetsSwapped;
            string sourceName = targetsSwapped ? "Target" : "Source";
            string targetName = targetsSwapped ? "Source" : "Target";
            switch (condition.Type)
            {
                case -3: // Not
                {
                    description += "Not (";
                    ConditionInfo reference = GameData.FindConditionWithId((uint)condition.Value1);
                    if (reference != null)
                        description += DescribeCondition(reference, targetsSwapped);
                    else
                        description += "Invalid Condition " + condition.Value1;
                    description += ")";
                    break;
                }
                case -2: // Or
                {
                    description += "(";
                    ConditionInfo reference1 = GameData.FindConditionWithId((uint)condition.Value1);
                    if (reference1 != null)
                        description += DescribeCondition(reference1, targetsSwapped);
                    else
                        description += "Invalid Condition " + condition.Value1;
                    description += ") Or (";
                    ConditionInfo reference2 = GameData.FindConditionWithId((uint)condition.Value2);
                    if (reference2 != null)
                        description += DescribeCondition(reference2, targetsSwapped);
                    else
                        description += "Invalid Condition " + condition.Value2;
                    description += ")";
                    if (condition.Value3 != 0)
                    {
                        description += " Or (";
                        ConditionInfo reference3 = GameData.FindConditionWithId((uint)condition.Value3);
                        if (reference3 != null)
                            description += DescribeCondition(reference3, targetsSwapped);
                        else
                            description += "Invalid Condition " + condition.Value3;
                        description += ")";
                    }
                    if (condition.Value4 != 0)
                    {
                        description += " Or (";
                        ConditionInfo reference4 = GameData.FindConditionWithId((uint)condition.Value4);
                        if (reference4 != null)
                            description += DescribeCondition(reference4, targetsSwapped);
                        else
                            description += "Invalid Condition " + condition.Value4;
                        description += ")";
                    }
                    break;
                }
                case -1: // And
                {
                    description += "(";
                    ConditionInfo reference1 = GameData.FindConditionWithId((uint)condition.Value1);
                    if (reference1 != null)
                        description += DescribeCondition(reference1, targetsSwapped);
                    else
                        description += condition.Value1 + ": Invalid Condition";
                    description += ") And (";
                    ConditionInfo reference2 = GameData.FindConditionWithId((uint)condition.Value2);
                    if (reference2 != null)
                        description += DescribeCondition(reference2, targetsSwapped);
                    else
                        description += condition.Value2 + ": Invalid Condition";
                    description += ")";
                    if (condition.Value3 != 0)
                    {
                        description += " And (";
                        ConditionInfo reference3 = GameData.FindConditionWithId((uint)condition.Value3);
                        if (reference3 != null)
                            description += DescribeCondition(reference3, targetsSwapped);
                        else
                            description += condition.Value3 + ": Invalid Condition";
                        description += ")";
                    }
                    if (condition.Value4 != 0)
                    {
                        description += " And (";
                        ConditionInfo reference4 = GameData.FindConditionWithId((uint)condition.Value4);
                        if (reference4 != null)
                            description += DescribeCondition(reference4, targetsSwapped);
                        else
                            description += condition.Value4 + ": Invalid Condition";
                        description += ")";
                    }
                    break;
                }
                case 0: // None
                {
                    description += "Always True";
                    break;
                }
                case 1: // Aura
                {
                    description += targetName + " Has Aura " + condition.Value1 + " Index " + condition.Value2;
                    break;
                }
                case 2: // Item
                {
                    description += targetName + " Has " + condition.Value2 + " Stacks Of Item " + condition.Value1 + " In Inventory";
                    break;
                }
                case 3: // Item Equipped
                {
                    description += targetName + " Has Equpped Item " + condition.Value1;
                    break;
                }
                case 4: // Area Id
                {
                    description += sourceName + " or " + targetName + " Is In Zone or Area " + condition.Value1;
                    break;
                }
                case 5: // Reputation Rank Min
                {
                    description += targetName + " Is " + GameData.FindReputationRankName((uint)condition.Value2) + " Or Better With Faction " + condition.Value1;
                    break;
                }
                case 6: // Team
                {
                    description += targetName + " Is Team " + GameData.FindTeamName((uint)condition.Value1);
                    break;
                }
                case 7: // Skill
                {
                    description += targetName + " Has " + condition.Value2 + " Points In Skill " + condition.Value1;
                    break;
                }
                case 8: // Quest Rewarded
                {
                    description += targetName + " Has Done Quest " + condition.Value1;
                    break;
                }
                case 9: // Quest Taken
                {
                    string status = "";
                    if (condition.Value2 == 1) // Incomplete
                        status = "Incomplete ";
                    else if (condition.Value2 == 2) // Complete
                        status = "Complete ";
                    description += targetName + " Has " + status + "Quest " + condition.Value1 + " In Log";
                    break;
                }
                case 10: // AD Commission Aura
                {
                    description += targetName + " Has Argent Dawn Commission";
                    break;
                }
                case 11: // War Effort Stage
                {
                    description += "War Effort Stage Is " + GetComparisonOperatorName(condition.Value2) + " " + condition.Value1;
                    break;
                }
                case 12: // Active Game Event
                {
                    description += "Game Event " + condition.Value1 + " Is Active";
                    break;
                }
                case 13: // Can't Path To Victim
                {
                    description += sourceName + " Can't Path To Victim";
                    break;
                }
                case 14: // Race Class
                {
                    description += targetName + " ";
                    if (condition.Value1 == 0 && condition.Value2 == 0)
                        description += "Is Any Race or Class";
                    else
                    {
                        if (condition.Value1 != 0)
                        {
                            description += "Is Race (" + GameData.GetRaceNamesFromMask((uint)condition.Value1) + ")";
                            if (condition.Value2 != 0)
                                description += " And ";
                        }
                        if (condition.Value2 != 0)
                        {
                            description += "Is Class (" + GameData.GetClassNamesFromMask((uint)condition.Value2) + ")";
                        }
                    }
                    break;
                }
                case 15: // Level
                {
                    description += targetName + "'s Level Is " + GetComparisonOperatorName(condition.Value2) + " " + condition.Value1;
                    break;
                }
                case 16: // Source Entry
                {
                    description += sourceName + "'s Entry Is " + condition.Value1;
                    if (condition.Value2 != 0)
                        description += " Or " + condition.Value2;
                    if (condition.Value3 != 0)
                        description += " Or " + condition.Value3;
                    if (condition.Value4 != 0)
                        description += " Or " + condition.Value4;
                    break;
                }
                case 17: // Spell
                {
                    description += targetName + " Knows Spell " + condition.Value1;
                    break;
                }
                case 18: // Instance Script
                {
                    description += "Hardcoded Condition " + condition.Value2 + " For Map " + condition.Value1;
                    break;
                }
                case 19: // Quest Available
                {
                    description += targetName + " Can Accept Quest " + condition.Value1;
                    break;
                }
                case 20: // Nearby Creature
                {
                    description += "Creature " + condition.Value1 + " Is " + (condition.Value3 == 0 ? "Alive" : "Dead") + " Within " + condition.Value2 + " Yards Of The " + targetName;
                    if (condition.Value4 != 0)
                        description += " But It's Not The " + targetName;
                    break;
                }
                case 21: // Nearby GameObject
                {
                    description += "GameObject " + condition.Value1 + " Is Within " + condition.Value2 + " Yards Of The " + targetName;
                    break;
                }
                case 22: // Quest None
                {
                    description += targetName + " Has Not Accepted or Completed Quest " + condition.Value1;
                    break;
                }
                case 23: // Item With Bank
                {
                    description += targetName + " Has " + condition.Value2 + " Stacks of Item " + condition.Value1 + " In Inventory Or Bank";
                    break;
                }
                case 24: // WoW Patch
                {
                    description += "Content Patch Is " + GetComparisonOperatorName(condition.Value2) + " 1." + (condition.Value1 + 2);
                    break;
                }
                case 25: // Escort
                {
                    string tmp = "";
                    if ((condition.Value1 & 1) != 0) // CF_ESCORT_SOURCE_DEAD
                    {
                        tmp += sourceName + " Is Dead";
                    }
                    if ((condition.Value1 & 2) != 0) // CF_ESCORT_TARGET_DEAD
                    {
                        if (!String.IsNullOrEmpty(tmp))
                            tmp += " Or ";
                        tmp += targetName + " Is Dead";
                    }
                    if (condition.Value2 != 0)
                    {
                        if (!String.IsNullOrEmpty(tmp))
                            tmp += " Or ";
                        tmp += sourceName + " Is Not Within " + condition.Value2 + " Yards Of " + targetName;
                    }
                    description += tmp;
                    break;
                }
                case 26: // Active Holiday
                {
                    description += "Holiday " + condition.Value1 + " Is Active";
                    break;
                }
                case 27: // Gender
                {
                    description += targetName + " Is Gender " + GameData.FindGenderName((uint)condition.Value1);
                    break;
                }
                case 28: // Is Player
                {
                    description += targetName + " Is Player";
                    if (condition.Value1 != 0)
                        description += " Or Player Controlled";
                    break;
                }
                case 29: // Skill Below
                {
                    description += targetName + " Has Less Than " + condition.Value2 + " Points In Skill " + condition.Value1;
                    break;
                }
                case 30: // Reputation Rank Max
                {
                    description += targetName + " Is " + GameData.FindReputationRankName((uint)condition.Value2) + " Or Worse With Faction " + condition.Value1;
                    break;
                }
                case 31: // Has Flag
                {
                    description += sourceName + " Has Flag " + condition.Value2 + " In Field " + condition.Value1;
                    break;
                }
                case 32: // Last Waypoint
                {
                    description += sourceName + "'s Last Reached Waypoint Is " + GetComparisonOperatorName(condition.Value2) + " " + condition.Value1;
                    break;
                }
                case 33: // Map Id
                {
                    description += "Current Map Id Is " + condition.Value1;
                    break;
                }
                case 34: // Instance Data
                {
                    description += "Stored Value In Index " + condition.Value1 + " From Instance Script Is " + GetComparisonOperatorName(condition.Value3) + " " + condition.Value2;
                    break;
                }
                case 35: // Map Event Data
                {
                    description += "Stored Value In Index " + condition.Value2 + " From Scripted Map Event " + condition.Value1 + " Is " + GetComparisonOperatorName(condition.Value4) + " " + condition.Value3;
                    break;
                }
                case 36: // Map Event Active
                {
                    description += "Scripted Map Event " + condition.Value1 + " Is Active";
                    break;
                }
                case 37: // Line Of Sight
                {
                    description += "Targets Are In Line Of Sight";
                    break;
                }
                case 38: // Distance To Target
                {
                    description += "Distance Between Targets Is " + GetComparisonOperatorName(condition.Value2) + " " + condition.Value1 + " Yards";
                    break;
                }
                case 39: // Is Moving
                {
                    description += targetName + " Is Moving";
                    break;
                }
                case 40: // Has Pet
                {
                    description += targetName + " Has A Pet";
                    break;
                }
                case 41: // Health Percent
                {
                    description += targetName + "'s Health Is " + GetComparisonOperatorName(condition.Value2) + " " + condition.Value1 + " Percent";
                    break;
                }
                case 42: // Mana Percent
                {
                    description += targetName + "'s Mana Is " + GetComparisonOperatorName(condition.Value2) + " " + condition.Value1 + " Percent";
                    break;
                }
                case 43: // Is In Combat
                {
                    description += targetName + " Is In Combat";
                    break;
                }
                case 44: // Is Hostile To
                {
                    description += targetName + " Is Hostile To " +  sourceName;
                    break;
                }
                case 45: // Is In Group
                {
                    description += targetName + " Is In Group";
                    break;
                }
                case 46: // Is Alive
                {
                    description += targetName + " Is Alive";
                    break;
                }
                case 47: // Map Event Targets
                {
                    description += "Extra Targets Of Scripted Map Event " + condition.Value1 + " Satisfy Condition (";
                    ConditionInfo reference = GameData.FindConditionWithId((uint)condition.Value2);
                    if (reference != null)
                        description += DescribeCondition(reference, targetsSwapped);
                    else
                        description += condition.Value2 + ": Invalid Condition";
                    description += ")";
                    break;
                }
                case 48: // Object Is Spawned
                {
                    description += targetName + " GameObject Is Spawned";
                    break;
                }
                case 49: // Object Loot State
                {
                    description += targetName + " GameObject's Loot State Is " + GameData.FindLootStateName((uint)condition.Value1);
                    break;
                }
                case 50: // Object Fit Condition
                {
                    description += "GameObject With Guid " + condition.Value1 + " Satisfies Condition (";
                    ConditionInfo reference = GameData.FindConditionWithId((uint)condition.Value2);
                    if (reference != null)
                        description += DescribeCondition(reference, targetsSwapped);
                    else
                        description += condition.Value2 + ": Invalid Condition";
                    description += ")";
                    break;
                }
                case 51: // PVP Rank
                {
                    description += targetName + "'s PvP Rank Is " + GetComparisonOperatorName(condition.Value2) + " " + condition.Value1;
                    break;
                }
                case 52: // DB Guid
                {
                    description += sourceName + "'s Guid Is " + condition.Value1;
                    if (condition.Value2 != 0)
                        description += " Or " + condition.Value2;
                    if (condition.Value3 != 0)
                        description += " Or " + condition.Value3;
                    if (condition.Value4 != 0)
                        description += " Or " + condition.Value4;
                    break;
                }
                case 53: // Local Time
                {
                    description += "Current Time Is Between " + condition.Value1 + ":" + condition.Value2 + " And " + condition.Value3 + ":" + condition.Value4;
                    break;
                }
                case 54: // Distance To Position
                {
                    description += targetName + " Is Within " + condition.Value4 + " Yards Of X " + condition.Value1 + " Y " + condition.Value2 + " Z " + condition.Value3;
                    break;
                }
                case 55: // Object GO State
                {
                    description += targetName + " GameObject's GO State Is " + GameData.FindGOStateName((uint)condition.Value1);
                    break;
                }
            }

            return description + (((condition.Flags & 1) != 0) ? ")" : "");
        }

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
            btnConditionNotCondition1.Text = "-NONE-";
            frmConditionNot.Visible = false;

            // CONDITION_OR (-2)
            // CONDITION_AND (-1)
            btnConditionAndCondition1.Text = "-NONE-";
            btnConditionAndCondition2.Text = "-NONE-";
            btnConditionAndCondition3.Text = "-NONE-";
            btnConditionAndCondition4.Text = "-NONE-";
            frmConditionAnd.Visible = false;

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
            // CONDITION_TARGET_GENDER (27)
            // CONDITION_MAP_ID (33)
            // CONDITION_OBJECT_LOOT_STATE (49)
            // CONDITION_OBJECT_GO_STATE (55)
            cmbTeamId.SelectedIndex = 0;
            frmConditionTeam.Visible = false;

            // CONDITION_SKILL (7)
            // CONDITION_SKILL_BELOW (29)
            // CONDITION_HAS_FLAG (31)
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
            // CONDITION_LAST_WAYPOINT (32)
            // CONDITION_MAP_EVENT_ACTIVE (36)
            // CONDITION_DISTANCE (38)
            // CONDITION_HEALTH_PERCENT (41)
            // CONDITION_MANA_PERCENT (42)
            // CONDITION_PVP_RANK (51)
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
            cmbNearbyCreatureDead.SelectedIndex = 0;
            cmbNearbyCreatureNotSelf.SelectedIndex = 0;
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

            // CONDITION_INSTANCE_DATA (34)
            txtInstanceDataIndex.Text = "";
            txtInstanceDataValue.Text = "";
            cmbInstanceDataComparison.SelectedIndex = 0;
            frmConditionInstanceData.Visible = false;

            // CONDITION_MAP_EVENT_DATA (35)
            txtMapEventDataEventId.Text = "";
            txtMapEventDataIndex.Text = "";
            txtMapEventDataValue.Text = "";
            cmbMapEventDataComparison.SelectedIndex = 0;
            frmConditionMapEventData.Visible = false;

            // CONDITION_MAP_EVENT_TARGETS (47)
            // CONDITION_OBJECT_FIT_CONDITION (50)
            txtMapEventTargetsEventId.Text = "";
            btnMapEventTargetsConditionId.Text = "-NONE-";
            frmConditionMapEventTargets.Visible = false;

            // CONDITION_SOURCE_ENTRY (16)
            // CONDITION_DB_GUID (52)
            // CONDITION_DISTANCE_TO_POSITION (54)
            txtConditionDbGuid1.Text = "";
            txtConditionDbGuid2.Text = "";
            txtConditionDbGuid3.Text = "";
            txtConditionDbGuid4.Text = "";
            frmConditionDbGuid.Visible = false;

            // CONDITION_LOCAL_TIME (53)
            txtLocalTimeStartHour.Text = "";
            txtLocalTimeStartMinutes.Text = "";
            txtLocalTimeEndHour.Text = "";
            txtLocalTimeEndMinutes.Text = "";
            frmConditionLocalTime.Visible = false;

            // Unknown Condition Id
            txtUnknownValue1.Text = "";
            txtUnknownValue2.Text = "";
            txtUnknownValue3.Text = "";
            txtUnknownValue4.Text = "";
            frmConditionUnknown.Visible = false;
        }

        private void ShowConditionSpecificForm(ConditionInfo selectedCondition)
        {
            if (!editMode)
                return;

            switch (selectedCondition.Type)
            {
                case -3: // CONDITION_NOT
                {
                    lblConditionNotTooltip.Text = "Returns true if the specified condition is false. The referenced condition needs to have an entry Id that is lower than that of the current condition.";
                    lblConditionNotCondition.Text = "Condition Id:";
                    lblConditionNotCondition.Visible = true;
                    btnConditionNotCondition1.Visible = true;
                    int conditionId1 = selectedCondition.Value1;
                    if (conditionId1 > 0)
                        btnConditionNotCondition1.Text = conditionId1.ToString() + " - " + GameData.FindConditionName((uint)conditionId1);
                    frmConditionNot.Visible = true;
                    break;
                }
                case -2: // CONDITION_OR
                case -1: // CONDITION_AND
                {
                    switch (selectedCondition.Type)
                    {
                        case -2: // CONDITION_OR
                        {
                            lblConditionAndTooltip.Text = "Returns true if any of specified conditions are true. The referenced conditions need to have an entry Id that is lower than that of the current condition.";
                            break;
                        }
                        case -1: // CONDITION_AND
                        {
                            lblConditionAndTooltip.Text = "Returns true only if all of the specified conditions return true. The referenced conditions need to have an entry Id that is lower than that of the current condition.";
                            break;
                        }
                    }

                    int conditionId1 = selectedCondition.Value1;
                    if (conditionId1 > 0)
                        btnConditionAndCondition1.Text = conditionId1.ToString() + " - " + GameData.FindConditionName((uint)conditionId1);
                    int conditionId2 = selectedCondition.Value2;
                    if (conditionId2 > 0)
                        btnConditionAndCondition2.Text = conditionId2.ToString() + " - " + GameData.FindConditionName((uint)conditionId2);
                    int conditionId3 = selectedCondition.Value3;
                    if (conditionId3 > 0)
                        btnConditionAndCondition3.Text = conditionId3.ToString() + " - " + GameData.FindConditionName((uint)conditionId3);
                    int conditionId4 = selectedCondition.Value4;
                    if (conditionId4 > 0)
                        btnConditionAndCondition4.Text = conditionId4.ToString() + " - " + GameData.FindConditionName((uint)conditionId4);

                    frmConditionAnd.Visible = true;
                    break;
                }
                case 0: // CONDITION_NONE
                case 10: // CONDITION_AD_COMMISSION_AURA
                case 13: // CONDITION_CANT_PATH_TO_VICTIM
                case 37: // CONDITION_LINE_OF_SIGHT
                case 39: // CONDITION_IS_MOVING
                case 40: // CONDITION_HAS_PET
                case 43: // CONDITION_IS_IN_COMBAT
                case 44: // CONDITION_IS_HOSTILE_TO
                case 45: // CONDITION_IS_IN_GROUP
                case 46: // CONDITION_IS_ALIVE
                case 48: // CONDITION_OBJECT_IS_SPAWNED
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
                            lblConditionNotTooltip.Text = "Returns true if the target Player has an Argent Dawn commission aura. This condition has no additional parameters.";
                            break;
                        }
                        case 13: // CONDITION_CANT_PATH_TO_VICTIM
                        {
                            lblConditionNotTooltip.Text = "Returns true if the source Unit cannot find a path to its victim. This condition has no additional parameters.";
                            break;
                        }
                        case 37: // CONDITION_LINE_OF_SIGHT
                        {
                            lblConditionNotTooltip.Text = "Returns true if the source and target WorldObjects are within line of sight of each other. This condition has no additional parameters.";
                            break;
                        }
                        case 39: // CONDITION_IS_MOVING
                        {
                            lblConditionNotTooltip.Text = "Returns true if the target WorldObject is currently moving. This condition has no additional parameters.";
                            break;
                        }
                        case 40: // CONDITION_HAS_PET
                        {
                            lblConditionNotTooltip.Text = "Returns true if the target Unit has a pet. This condition has no additional parameters.";
                            break;
                        }
                        case 43: // CONDITION_IS_IN_COMBAT
                        {
                            lblConditionNotTooltip.Text = "Returns true if the target Unit is in combat. This condition has no additional parameters.";
                            break;
                        }
                        case 44: // CONDITION_IS_HOSTILE_TO
                        {
                            lblConditionNotTooltip.Text = "Returns true if the source and target Units are hostile to each other. This condition has no additional parameters.";
                            break;
                        }
                        case 45: // CONDITION_IS_IN_GROUP
                        {
                            lblConditionNotTooltip.Text = "Returns true if the target Player is currently in a group. This condition has no additional parameters.";
                            break;
                        }
                        case 46: // CONDITION_IS_ALIVE
                        {
                            lblConditionNotTooltip.Text = "Returns true if the target Unit is alive. This condition has no additional parameters.";
                            break;
                        }
                        case 48: // CONDITION_OBJECT_IS_SPAWNED
                        {
                            lblConditionNotTooltip.Text = "Returns true if the target GameObject is currently spawned. This condition has no additional parameters.";
                            break;
                        }
                    }
                    lblConditionNotCondition.Visible = false;
                    btnConditionNotCondition1.Visible = false;
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
                    
                    int spellId = selectedCondition.Value1;
                    if (spellId > 0)
                        btnAuraSpellId.Text = GameData.FindSpellName((uint)spellId) + " (" + spellId.ToString() + ")";
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
                    int itemId = selectedCondition.Value1;
                    if (itemId > 0)
                        btnItemId.Text = GameData.FindItemName((uint)itemId) + " (" + itemId.ToString() + ")";
                    txtItemCount.Text = selectedCondition.Value2.ToString();
                    frmConditionItem.Visible = true;
                    break;
                }
                case 4: // CONDITION_AREAID
                {
                    int areaId = selectedCondition.Value1;
                    if (areaId > 0)
                        btnAreaId.Text = GameData.FindAreaName((uint)areaId) + " (" + areaId.ToString() + ")";
                    frmConditionArea.Visible = true;
                    break;
                }
                case 5: // CONDITION_REPUTATION_RANK_MIN
                case 30: // CONDITION_REPUTATION_RANK_MAX
                {
                    switch (selectedCondition.Type)
                    {
                        case 5: // CONDITION_REPUTATION_RANK_MIN
                        {
                            lblConditionReputationTooltip.Text = "Returns true if the target Player has reached a minimum reputation level with the specified faction.";
                            break;
                        }
                        case 30: // CONDITION_REPUTATION_RANK_MAX
                        {
                            lblConditionReputationTooltip.Text = "Returns true if the target Player's reputiation is equal or below the specified level.";
                            break;
                        }
                    }
                    
                    int factionId = selectedCondition.Value1;
                    if (factionId > 0)
                        btnReputationFactionId.Text = GameData.FindFactionName((uint)factionId) + " (" + factionId.ToString() + ")";
                    cmbReputationRank.SelectedIndex = (int)selectedCondition.Value2;
                    frmConditionReputation.Visible = true;
                    break;
                }
                case 6: // CONDITION_TEAM
                case 27: // CONDITION_TARGET_GENDER
                case 28: // CONDITION_IS_PLAYER
                case 33: // CONDITION_MAP_ID
                case 49: // CONDITION_OBJECT_LOOT_STATE
                case 55: // CONDITION_OBJECT_GO_STATE
                {
                    switch (selectedCondition.Type)
                    {
                        case 6: // CONDITION_TEAM
                        {
                            lblConditionTeamTooltip.Text = "Returns true if the target Player is a member of the specified team.";
                            lblTeamId.Text = "Team:";
                            cmbTeamId.DataSource = ConditionTeam_ComboOptions; ;
                            break;
                        }
                        case 27: // CONDITION_TARGET_GENDER
                        {
                            lblConditionTeamTooltip.Text = "Returns true if the target Unit is of the specified gender.";
                            lblTeamId.Text = "Gender:";
                            cmbTeamId.DataSource = ConditionGender_ComboOptions; ;
                            break;
                        }
                        case 28: // CONDITION_IS_PLAYER
                        {
                            lblConditionTeamTooltip.Text = "Returns true if the target WorldObject is a Player.";
                            lblTeamId.Text = "Criteria:";
                            cmbTeamId.DataSource = ConditionIsPlayer_ComboOptions; ;
                            break;
                        }
                        case 33: // CONDITION_MAP_ID
                        {
                            lblConditionTeamTooltip.Text = "Returns true if the current map Id matches the one specified.";
                            lblTeamId.Text = "Map Id:";
                            cmbTeamId.DataSource = GameData.MapsList;
                            break;
                        }
                        case 49: // CONDITION_OBJECT_LOOT_STATE
                        {
                            lblConditionTeamTooltip.Text = "Returns true if the target GameObject's loot state matches the one specified.";
                            lblTeamId.Text = "Loot State:";
                            cmbTeamId.DataSource = ConditionObjectLootState_ComboOptions;
                            break;
                        }
                        case 55: // CONDITION_OBJECT_GO_STATE
                        {
                            lblConditionTeamTooltip.Text = "Returns true if the target GameObject's GO state matches the one specified.";
                            lblTeamId.Text = "GO State:";
                            cmbTeamId.DataSource = ConditionObjectGoState_ComboOptions;
                            break;
                        }
                    }
                    cmbTeamId.SelectedIndex = ComboboxPair.GetIndexFromComboboxPairValue(cmbTeamId, (int)selectedCondition.Value1);
                    frmConditionTeam.Visible = true;
                    break;
                }
                case 7: // CONDITION_SKILL
                case 29: // CONDITION_SKILL_BELOW
                case 31: // CONDITION_HAS_FLAG
                {
                    switch (selectedCondition.Type)
                    {
                        case 7: // CONDITION_SKILL
                        {
                            lblConditionSkillTooltip.Text = "Returns true if the target Player has reached a minimum skill level.";
                            cmbSkillId.DataSource = GameData.SkillsList;
                            lblSkillId.Text = "Skill Id:";
                            lblSkillLevel.Text = "Skill Level:";
                            break;
                        }
                        case 29: // CONDITION_SKILL_BEL
                        {
                            lblConditionSkillTooltip.Text = "Returns true if the target Player knows the skill itself but his skill level is below the specified value.";
                            cmbSkillId.DataSource = GameData.SkillsList;
                            lblSkillId.Text = "Skill Id:";
                            lblSkillLevel.Text = "Skill Level:";
                            break;
                        }
                        case 31: // CONDITION_HAS_FLAG
                        {
                            lblConditionSkillTooltip.Text = "Returns true if the source WorldObject has the specified flag.";
                            cmbSkillId.DataSource = GameData.FlagFieldsList;
                            lblSkillId.Text = "Field:";
                            lblSkillLevel.Text = "Flag:";
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
                    int questId = selectedCondition.Value1;
                    if (questId > 0)
                        btnQuestId.Text = GameData.FindQuestTitle((uint)questId) + " (" + questId.ToString() + ")";
                    frmConditionQuest.Visible = true;
                    break;
                }
                case 11: // CONDITION_WAR_EFFORT_STAGE
                case 15: // CONDITION_LEVEL
                case 26: // CONDITION_ACTIVE_HOLIDAY
                case 32: // CONDITION_LAST_WAYPOINT
                case 36: // CONDITION_MAP_EVENT_ACTIVE
                case 38: // CONDITION_DISTANCE
                case 41: // CONDITION_HEALTH_PERCENT
                case 42: // CONDITION_MANA_PERCENT
                case 51: // CONDITION_PVP_RANK
                {
                    switch (selectedCondition.Type)
                    {
                        case 11: // CONDITION_WAR_EFFORT_STAGE
                        {
                            lblConditionWarEffortTooltip.Text = "Returns true if the War Effort event is at the specified stage.";
                            cmbWarEffortComparison.Visible = true;
                            cmbWarEffortComparison.SelectedIndex = (int)selectedCondition.Value2;
                            lblWarEffortComparison.Visible = true;
                            lblWarEffortStage.Text = "Stage:";
                            break;
                        }
                        case 15: // CONDITION_LEVEL
                        {
                            lblConditionWarEffortTooltip.Text = "Returns true if the target Player fits the specified level requirement.";
                            cmbWarEffortComparison.Visible = true;
                            cmbWarEffortComparison.SelectedIndex = (int)selectedCondition.Value2;
                            lblWarEffortComparison.Visible = true;
                            lblWarEffortStage.Text = "Level:";
                            break;
                        }
                        case 26: // CONDITION_ACTIVE_HOLIDAY
                        {
                            lblConditionWarEffortTooltip.Text = "Returns true if the specified holiday is currently active.";
                            cmbWarEffortComparison.Visible = false;
                            lblWarEffortComparison.Visible = false;
                            lblWarEffortStage.Text = "Holiday Id:";
                            break;
                        }
                        case 32: // CONDITION_LAST_WAYPOINT
                        {
                            lblConditionWarEffortTooltip.Text = "Returns true if the source Creature's last reached waypoint matches the one specified.";
                            cmbWarEffortComparison.Visible = true;
                            cmbWarEffortComparison.SelectedIndex = (int)selectedCondition.Value2;
                            lblWarEffortComparison.Visible = true;
                            lblWarEffortStage.Text = "Waypoint:";
                            break;
                        }
                        case 36: // CONDITION_MAP_EVENT_ACTIVE
                        {
                            lblConditionWarEffortTooltip.Text = "Returns true if a scripted map event with the specified Id is currently running.";
                            cmbWarEffortComparison.Visible = false;
                            lblWarEffortComparison.Visible = false;
                            lblWarEffortStage.Text = "Event Id:";
                            break;
                        }
                        case 38: // CONDITION_DISTANCE
                        {
                            lblConditionWarEffortTooltip.Text = "Returns true if the source and target WorldObjects are within a specified distance of each other.";
                            cmbWarEffortComparison.Visible = true;
                            cmbWarEffortComparison.SelectedIndex = (int)selectedCondition.Value2;
                            lblWarEffortComparison.Visible = true;
                            lblWarEffortStage.Text = "Distance:";
                            break;
                        }
                        case 41: // CONDITION_HEALTH_PERCENT
                        {
                            lblConditionWarEffortTooltip.Text = "Returns true if the target Unit's remaining health percent matches the specified criteria.";
                            cmbWarEffortComparison.Visible = true;
                            cmbWarEffortComparison.SelectedIndex = (int)selectedCondition.Value2;
                            lblWarEffortComparison.Visible = true;
                            lblWarEffortStage.Text = "Health:";
                            break;
                        }
                        case 42: // CONDITION_MANA_PERCENT
                        {
                            lblConditionWarEffortTooltip.Text = "Returns true if the target Unit's remaining mana percent matches the specified criteria.";
                            cmbWarEffortComparison.Visible = true;
                            cmbWarEffortComparison.SelectedIndex = (int)selectedCondition.Value2;
                            lblWarEffortComparison.Visible = true;
                            lblWarEffortStage.Text = "Mana:";
                            break;
                        }
                        case 51: // CONDITION_PVP_RANK
                        {
                            lblConditionWarEffortTooltip.Text = "Returns true if the target Player's honor rank matches the specified criteria.";
                            cmbWarEffortComparison.Visible = true;
                            cmbWarEffortComparison.SelectedIndex = (int)selectedCondition.Value2;
                            lblWarEffortComparison.Visible = true;
                            lblWarEffortStage.Text = "Rank:";
                            break;
                        }
                    }
                    txtWarEffortStage.Text = selectedCondition.Value1.ToString();
                    frmConditionWarEffort.Visible = true;
                    break;
                }
                case 12: // CONDITION_ACTIVE_GAME_EVENT
                {
                    int eventId = selectedCondition.Value1;
                    if (eventId > 0)
                        btnGameEventId.Text = GameData.FindEventName((uint)eventId) + " (" + eventId.ToString() + ")";
                    frmConditionGameEvent.Visible = true;
                    break;
                }
                case 14: // CONDITION_RACE_CLASS
                {
                    btnRaceMask.Text = GameData.GetRaceNamesFromMask((uint)selectedCondition.Value1);
                    btnClassMask.Text = GameData.GetClassNamesFromMask((uint)selectedCondition.Value2);
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
                    int creatureId = selectedCondition.Value1;
                    if (creatureId > 0)
                        btnNearbyCreatureId.Text = GameData.FindCreatureName((uint)creatureId) + " (" + creatureId.ToString() + ")";
                    txtNearbyCreatureDistance.Text = selectedCondition.Value2.ToString();
                    cmbNearbyCreatureDead.SelectedIndex = (int)selectedCondition.Value3;
                    cmbNearbyCreatureNotSelf.SelectedIndex = (int)selectedCondition.Value4;
                    frmConditionNearbyCreature.Visible = true;
                    break;
                }
                case 21: // CONDITION_NEARBY_GAMEOBJECT
                {
                    int objectId = selectedCondition.Value1;
                    if (objectId > 0)
                        btnNearbyObjectId.Text = GameData.FindGameObjectName((uint)objectId) + " (" + objectId.ToString() + ")";
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
                case 34: // CONDITION_INSTANCE_DATA
                {
                    txtInstanceDataIndex.Text = selectedCondition.Value1.ToString();
                    txtInstanceDataValue.Text = selectedCondition.Value2.ToString();
                    cmbInstanceDataComparison.SelectedIndex = (int)selectedCondition.Value3;
                    frmConditionInstanceData.Visible = true;
                    break;
                }
                case 35: // CONDITION_MAP_EVENT_DATA
                {
                    txtMapEventDataEventId.Text = selectedCondition.Value1.ToString();
                    txtMapEventDataIndex.Text = selectedCondition.Value2.ToString();
                    txtMapEventDataValue.Text = selectedCondition.Value3.ToString();
                    cmbMapEventDataComparison.SelectedIndex = (int)selectedCondition.Value4;
                    frmConditionMapEventData.Visible = true;
                    break;
                }
                case 47: // CONDITION_MAP_EVENT_TARGETS
                case 50: // CONDITION_OBJECT_FIT_CONDITION
                {
                    switch (selectedCondition.Type)
                    {
                        case 47: // CONDITION_MAP_EVENT_TARGETS
                        {
                            lblConditionMapEventTargetsTooltip.Text = "Returns true if all of the extra targets part of the scripted map event satisfy the specified condition.";
                            lblMapEventTargetsEventId.Text = "Event Id:";
                            break;
                        }
                        case 50: // CONDITION_OBJECT_FIT_CONDITION
                        {
                            lblConditionMapEventTargetsTooltip.Text = "Returns true if the GameObject whose guid has been provided satisfies the specified condition";
                            lblMapEventTargetsEventId.Text = "GUID:";
                            break;
                        }
                    }
                    txtMapEventTargetsEventId.Text = selectedCondition.Value1.ToString();
                    int conditionId = selectedCondition.Value2;
                    if (conditionId > 0)
                        btnMapEventTargetsConditionId.Text = conditionId.ToString() + " - " + GameData.FindConditionName((uint)conditionId);
                    frmConditionMapEventTargets.Visible = true;
                    break;
                }
                case 16: // CONDITION_SOURCE_ENTRY
                case 52: // CONDITION_DB_GUID
                case 54: // CONDITION_DISTANCE_TO_POSITION
                {
                    switch (selectedCondition.Type)
                    {
                        case 16: // CONDITION_SOURCE_ENTRY
                        {
                            lblConditionDbGuidTooltip.Text = "Returns true if the source object\'s entry matches any of the ones specified.";
                            lblConditionDbGuid1.Text = "Entry 1:";
                            lblConditionDbGuid2.Text = "Entry 2:";
                            lblConditionDbGuid3.Text = "Entry 3:";
                            lblConditionDbGuid4.Text = "Entry 4:";

                            break;
                        }
                        case 52: // CONDITION_DB_GUID
                        {
                            lblConditionDbGuidTooltip.Text = "Returns true if the source object\'s database guid matches any of the ones specified.";
                            lblConditionDbGuid1.Text = "GUID 1:";
                            lblConditionDbGuid2.Text = "GUID 2:";
                            lblConditionDbGuid3.Text = "GUID 3:";
                            lblConditionDbGuid4.Text = "GUID 4:";

                            break;
                        }
                        case 54: // CONDITION_DISTANCE_TO_POSITION
                        {
                            lblConditionDbGuidTooltip.Text = "Returns true if the target object is within a given distance of the coordinates.";
                            lblConditionDbGuid1.Text = "X:";
                            lblConditionDbGuid2.Text = "Y:";
                            lblConditionDbGuid3.Text = "Z:";
                            lblConditionDbGuid4.Text = "Distance:";
                            break;
                        }
                    }

                    txtConditionDbGuid1.Text = selectedCondition.Value1.ToString();
                    txtConditionDbGuid2.Text = selectedCondition.Value2.ToString();
                    txtConditionDbGuid3.Text = selectedCondition.Value3.ToString();
                    txtConditionDbGuid4.Text = selectedCondition.Value4.ToString();
                    frmConditionDbGuid.Visible = true;
                    break;
                }
                case 53: // CONDITION_LOCAL_TIME
                {
                    txtLocalTimeStartHour.Text = selectedCondition.Value1.ToString();
                    txtLocalTimeStartMinutes.Text = selectedCondition.Value2.ToString();
                    txtLocalTimeEndHour.Text = selectedCondition.Value3.ToString();
                    txtLocalTimeEndMinutes.Text = selectedCondition.Value4.ToString();
                    frmConditionLocalTime.Visible = true;
                    break;
                }
                default:
                {
                    txtUnknownValue1.Text = selectedCondition.Value1.ToString();
                    txtUnknownValue2.Text = selectedCondition.Value2.ToString();
                    txtUnknownValue3.Text = selectedCondition.Value3.ToString();
                    txtUnknownValue4.Text = selectedCondition.Value4.ToString();
                    frmConditionUnknown.Visible = true;
                    break;
                }
            }
        }

        public FormConditionFinder()
        {
            InitializeComponent();
            AddControlsToLists();
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

            lstData.Columns[6].Width = 75;

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

            lstData.Columns[6].Width = 75;

            foreach (ConditionInfo condition in GameData.ConditionInfoList)
            {
                if ((condition.ID >= minId) && (condition.ID <= maxId))
                    AddConditionToListView(condition);
            }
        }
        protected override void AddByText(string searchText)
        {
            dontUpdate = true;
            ResetBaseControls();
            ResetAndHideConditionSpecificForms();
            dontUpdate = false;

            lstData.Columns[6].Width = 75;

            foreach (ConditionInfo condition in GameData.ConditionInfoList)
            {
                if (GameData.FindConditionTypeName(condition.Type).ToUpper().Contains(searchText))
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
            if (editMode)
            {
                foreach(Panel frm in conditionFormsList)
                {
                    frm.Width = this.Size.Width - 32;
                    frm.Location = new Point(frm.Location.X, this.Size.Height - 217);
                }
                foreach (Label lbl in conditionTooltipsList)
                {
                    lbl.Width = lbl.Parent.Size.Width - lbl.Location.X - 14;
                }
                
                lblNoSelection.Location = new Point(frmConditionUnknown.Location.X + (frmConditionUnknown.Size.Width / 2) - (lblNoSelection.Size.Width / 2), frmConditionUnknown.Location.Y + (frmConditionUnknown.Size.Height / 2) - (lblNoSelection.Size.Height / 2));

                txtConditionId.Location = new Point(txtConditionId.Location.X, frmConditionUnknown.Location.Y - 28);
                cmbConditionType.Location = new Point(cmbConditionType.Location.X, frmConditionUnknown.Location.Y - 28);
                cmbConditionType.Width = this.Size.Width - 479;
                chkConditionFlag1.Location = new Point(cmbConditionType.Location.X + cmbConditionType.Size.Width + 7, cmbConditionType.Location.Y + 3);
                chkConditionFlag2.Location = new Point(chkConditionFlag1.Location.X + chkConditionFlag1.Size.Width + 6, cmbConditionType.Location.Y + 3);
                btnSaveAll.Location = new Point(this.Size.Width - btnSaveAll.Size.Width - 20, frmConditionUnknown.Location.Y - 28);
                btnSave.Location = new Point(btnSaveAll.Location.X - 81, frmConditionUnknown.Location.Y - 28);

                lstData.Width = this.Size.Width - 32;
                lstData.Height = this.Size.Height - lstData.Location.Y - 5 - (this.Size.Height - txtConditionId.Location.Y);
                btnCancel.Location = new Point(this.Size.Width - btnCancel.Size.Width - 20, frmConditionUnknown.Location.Y + frmConditionUnknown.Size.Height + 5);
                btnSelect.Location = new Point(btnCancel.Location.X - btnSelect.Size.Width - 6, btnCancel.Location.Y);
                btnSelectNone.Location = new Point(btnSelect.Location.X - btnSelectNone.Size.Width - 6, btnCancel.Location.Y);
                btnEditAdd.Location = new Point(btnEditAdd.Location.X, btnCancel.Location.Y);
                btnDelete.Location = new Point(btnDelete.Location.X, btnCancel.Location.Y);
                btnDescribe.Location = new Point(btnDescribe.Location.X, btnCancel.Location.Y);
                btnSearch.Location = new Point(lstData.Size.Width + lstData.Location.X - btnSearch.Size.Width, btnSearch.Location.Y);
                txtSearch.Width = btnSearch.Location.X - txtSearch.Location.X - 7;
                btnSelectUnchanged.Location = new Point(btnSelectNone.Location.X - btnSelectUnchanged.Size.Width - 6, btnCancel.Location.Y);
            }
            else
            {
                btnEditAdd.Location = new Point(btnEditAdd.Location.X, lstData.Location.Y + lstData.Height + 6);
                btnDelete.Location = new Point(btnDelete.Location.X, lstData.Location.Y + lstData.Height + 6);
                btnDescribe.Location = new Point(btnDescribe.Location.X, lstData.Location.Y + lstData.Height + 6);
            }

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

            int conditionIndex = -1;
            foreach (var item in cmbConditionType.Items)
            {
                ComboboxPair conditionTypePair = item as ComboboxPair;
                if (conditionTypePair.Value == selectedCondition.Type)
                {
                    conditionIndex = cmbConditionType.Items.IndexOf(item);
                    break;
                }
            }

            cmbConditionType.SelectedIndex = conditionIndex;
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

                ComboboxPair selectedType = cmbConditionType.SelectedItem as ComboboxPair;
                currentCondition.Type = selectedType.Value;
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
                FormConditionFinder_ResizeEnd(null, null);

                txtConditionId.Visible = true;
                chkConditionFlag1.Visible = true;
                chkConditionFlag2.Visible = true;
                cmbConditionType.Visible = true;
                btnSave.Visible = true;
                btnSaveAll.Visible = true;
                btnDelete.Visible = true;
                btnDescribe.Visible = true;
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


        private void btnDescribe_Click(object sender, EventArgs e)
        {
            if (lstData.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstData.SelectedItems[0];

                // Get the associated ConditionInfo.
                ConditionInfo currentCondition = (ConditionInfo)currentItem.Tag;

                // Show condition description and copy it to clipboard.
                string description = DescribeCondition(currentCondition, false);
                Clipboard.SetText(description);
                MessageBox.Show(description, "Condition Description");
            }
        }

        private string GenerateSaveQuery(ConditionInfo saveCondition)
        {
            ConditionInfo condition = GameData.OriginalConditionInfoList.Find(i => i.ID == saveCondition.ID);
            string description = "-- " + DescribeCondition(saveCondition, false) + "\n";
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
                    string query = description + "UPDATE `conditions` SET ";
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
            return description + "INSERT INTO `conditions` (`condition_entry`, `type`, `value1`, `value2`, `value3`, `value4`, `flags`) VALUES (" + saveCondition.ID.ToString() + ", " + saveCondition.Type.ToString() + ", " + saveCondition.Value1.ToString() + ", " + saveCondition.Value2.ToString() + ", " + saveCondition.Value3.ToString() + ", " + saveCondition.Value4.ToString() + ", " + saveCondition.Flags.ToString() + ");\n";
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
        // CONDITION_OR
        // CONDITION_AND
        private void btnConditionAndCondition1_Click(object sender, EventArgs e)
        {
            FormConditionFinder frm = new FormConditionFinder();
            if (frm.ShowDialog(GetScriptFieldValue("Value1")) == System.Windows.Forms.DialogResult.OK)
            {
                int returnId = frm.ReturnValue;

                if (returnId > 0)
                    btnConditionAndCondition1.Text = returnId.ToString() + " - " + GameData.FindConditionName((uint)returnId);
                else
                    btnConditionAndCondition1.Text = "-NONE-";

                SetScriptFieldFromValue(returnId, "Value1");
            }
        }
        private void btnConditionAndCondition2_Click(object sender, EventArgs e)
        {
            FormConditionFinder frm = new FormConditionFinder();
            if (frm.ShowDialog(GetScriptFieldValue("Value2")) == System.Windows.Forms.DialogResult.OK)
            {
                int returnId = frm.ReturnValue;

                if (returnId > 0)
                    btnConditionAndCondition2.Text = returnId.ToString() + " - " + GameData.FindConditionName((uint)returnId);
                else
                    btnConditionAndCondition2.Text = "-NONE-";

                SetScriptFieldFromValue(returnId, "Value2");
            }
        }
        private void btnConditionAndCondition3_Click(object sender, EventArgs e)
        {
            FormConditionFinder frm = new FormConditionFinder();
            if (frm.ShowDialog(GetScriptFieldValue("Value3")) == System.Windows.Forms.DialogResult.OK)
            {
                int returnId = frm.ReturnValue;

                if (returnId > 0)
                    btnConditionAndCondition3.Text = returnId.ToString() + " - " + GameData.FindConditionName((uint)returnId);
                else
                    btnConditionAndCondition3.Text = "-NONE-";

                SetScriptFieldFromValue(returnId, "Value3");
            }
        }
        private void btnConditionAndCondition4_Click(object sender, EventArgs e)
        {
            FormConditionFinder frm = new FormConditionFinder();
            if (frm.ShowDialog(GetScriptFieldValue("Value4")) == System.Windows.Forms.DialogResult.OK)
            {
                int returnId = frm.ReturnValue;

                if (returnId > 0)
                    btnConditionAndCondition4.Text = returnId.ToString() + " - " + GameData.FindConditionName((uint)returnId);
                else
                    btnConditionAndCondition4.Text = "-NONE-";

                SetScriptFieldFromValue(returnId, "Value4");
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
        private void btnRaceMask_Click(object sender, EventArgs e)
        {
            uint race_mask = (uint)GetScriptFieldValue("Value1");
            FormRaceMask formRaceMask = new FormRaceMask(race_mask);
            if (formRaceMask.ShowDialog() == DialogResult.OK)
            {
                SetScriptFieldFromValue(formRaceMask.ReturnValue, "Value1");
                btnRaceMask.Text = GameData.GetRaceNamesFromMask(formRaceMask.ReturnValue);
            }
        }
        private void btnClassMask_Click(object sender, EventArgs e)
        {
            uint class_mask = (uint)GetScriptFieldValue("Value2");
            FormClassMask formClassMask = new FormClassMask(class_mask);
            if (formClassMask.ShowDialog() == DialogResult.OK)
            {
                SetScriptFieldFromValue(formClassMask.ReturnValue, "Value2");
                btnClassMask.Text = GameData.GetClassNamesFromMask(formClassMask.ReturnValue);
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
        private void cmbNearbyCreatureDead_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbNearbyCreatureDead, "Value3", false);
        }
        private void cmbNearbyCreatureNotSelf_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbNearbyCreatureNotSelf, "Value4", false);
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
        // CONDITION_INSTANCE_DATA
        private void txtInstanceDataIndex_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtInstanceDataIndex, "Value1");
        }
        private void txtInstanceDataValue_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtInstanceDataValue, "Value2");
        }
        private void cmbInstanceDataComparison_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbInstanceDataComparison, "Value3", false);
        }
        // CONDITION_MAP_EVENT_DATA
        private void txtMapEventDataEventId_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtMapEventDataEventId, "Value1");
        }
        private void txtMapEventDataIndex_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtMapEventDataIndex, "Value2");
        }
        private void txtMapEventDataValue_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtMapEventDataValue, "Value3");
        }
        private void cmbMapEventDataComparison_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbMapEventDataComparison, "Value4", false);
        }
        // CONDITION_MAP_EVENT_TARGETS
        private void txtMapEventTargetsEventId_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtMapEventTargetsEventId, "Value1");
        }
        private void btnMapEventTargetsConditionId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormConditionFinder>(btnMapEventTargetsConditionId, null, GameData.FindConditionName, "Value2");
        }
        // CONDITION_DB_GUID
        private void txtConditionDbGuid1_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtConditionDbGuid1, "Value1");
        }
        private void txtConditionDbGuid2_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtConditionDbGuid2, "Value2");
        }
        private void txtConditionDbGuid3_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtConditionDbGuid3, "Value3");
        }
        private void txtConditionDbGuid4_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtConditionDbGuid4, "Value4");
        }
        // CONDITION_LOCAL_TIME
        private void txtLocalTimeStartHour_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtLocalTimeStartHour, "Value1");
        }
        private void txtLocalTimeStartMinutes_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtLocalTimeStartMinutes, "Value2");
        }
        private void txtLocalTimeEndHour_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtLocalTimeEndHour, "Value3");
        }
        private void txtLocalTimeEndMinutes_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtLocalTimeEndMinutes, "Value4");
        }
        // Unknown Condition Id
        private void txtUnknownValue1_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtUnknownValue1, "Value1");
        }
        private void txtUnknownValue2_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtUnknownValue2, "Value2");
        }
        private void txtUnknownValue3_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtUnknownValue3, "Value3");
        }
        private void txtUnknownValue4_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtUnknownValue4, "Value4");
        }
    }
}
