using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Reflection;

namespace ScriptEditor
{
    public partial class FormEventEditor : Form
    {
        // Save what we are currently working on.
        public uint currentCreatureId = 0;

        // Used to prevent control events triggering when resetting data.
        bool dontUpdate = false;

        // Stores script Ids used when the event list is loaded.
        List<uint> ScriptIdsList = new List<uint>();

        // Use the same form when viewing script.
        FormScriptEditor script_editor = null;

        // Event Type Names
        private string[] EventTypeNames =
        {
        "Timer In Combat",          // 0
        "Timer OOC",                // 1
        "HP",                       // 2
        "Mana",                     // 3
        "Aggro",                    // 4
        "Killed Player",            // 5
        "Death",                    // 6
        "Evade",                    // 7
        "Hit By Spell",             // 8
        "Target In Range",          // 9
        "Unit In LOS OOC",          // 10
        "Just Spawned",             // 11
        "Target HP",                // 12
        "Target Is Casting",        // 13
        "Friendly HP",              // 14
        "Friendly Is CC",           // 15
        "Friendly Missing Aura",    // 16
        "Summoned Unit",            // 17
        "Target Mana",              // 18
        "UNUSED",                   // 19
        "UNUSED",                   // 20
        "Reached Home",             // 21
        "Received Emote",           // 22
        "Has Aura",                 // 23
        "Target Has Aura",          // 24
        "Summoned Unit Died",       // 25
        "Summoned Unit Despawned",  // 26
        "Missing Aura",             // 27
        "Target Missing Aura",      // 28
        "Movement Inform",          // 29
        "Leave Combat",             // 30
        "Map Event Happened",       // 31
        "Group Member Died"         // 32
        };
        
        public FormEventEditor()
        {
            InitializeComponent();
        }

        private void FormEventEditor_Load(object sender, EventArgs e)
        {
            LoadControls();
        }

        private void FormEventEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((currentCreatureId != 0) && (MessageBox.Show("Are you sure you want to close the editor?\n\nChanges are not saved automatically. Make sure you've clicked the Save button first, or your changes will be lost.", "Exit Editor?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
            {
                e.Cancel = true;
            }
        }

        private void txtCreatureId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnFind_Click(this, new EventArgs());
                e.Handled = true;
            }
        }

        private void LoadControls()
        {
            dontUpdate = true;

            // Assign sorter to listview.
            lstEvents.ListViewItemSorter = new MixedListSorter();

            // Add options to Event Type combo box.
            cmbEventType.DataSource = EventTypeNames;
            cmbEventType.SelectedIndex = 0;

            // Add options to Received Emote combo box.
            cmbReceiveEmoteId.DataSource = GameData.TextEmotesList;
            cmbReceiveEmoteId.SelectedIndex = 0;

            // Add options to Movement Inform combo box.
            cmbMovementInformType.DataSource = GameData.MotionTypesFullList;

            // Fix size of textbox.
            txtMovementInformType.AutoSize = false;
            txtMovementInformType.Height = 21;

            dontUpdate = false;
        }

        private void ResetEditorForm()
        {
            dontUpdate = true;
            lstEvents.Items.Clear();
            ResetAndDisableGeneralForm();
            ResetAndHideEventSpecificForms();
            this.Text = "Event Editor";
            lblCurrentCreature.Text = "No event list loaded.";
            currentCreatureId = 0;
            dontUpdate = false;
        }

        private void ResetAndDisableGeneralForm()
        {
            dontUpdate = true;

            // Text Boxes.
            txtEventId.Text = "";
            txtScriptId1.Text = "";
            txtScriptId2.Text = "";
            txtScriptId3.Text = "";
            txtEventComment.Text = "";
            txtEventChance.Text = "";
            btnEventPhaseMask.Text = "-NONE-";

            // Combo Boxes.
            cmbEventType.SelectedIndex = 0;
            cmbEventType.Text = "";

            // Check Boxes.
            chkEventFlag1.Checked = false;
            chkEventFlag2.Checked = false;
            chkEventFlag4.Checked = false;

            // Buttons.
            btnEventCondition.Text = "-NONE-";

            if (Program.highlight)
            {
                lblScriptId1.BackColor = Color.FromKnownColor(KnownColor.Control);
                lblScriptId2.BackColor = Color.FromKnownColor(KnownColor.Control);
                lblScriptId3.BackColor = Color.FromKnownColor(KnownColor.Control);
                lblEventChance.BackColor = Color.FromKnownColor(KnownColor.Control);
                lblEventCondition.BackColor = Color.FromKnownColor(KnownColor.Control);
                lblEventPhaseMask.BackColor = Color.FromKnownColor(KnownColor.Control);
            }

            // Make the form disabled.
            grpGeneral.Enabled = false;

            dontUpdate = false;
        }

        private void ResetAndHideEventSpecificForms()
        {
            dontUpdate = true;

            // EVENT_T_TIMER (0)
            // EVENT_T_TIMER_OOC (1)
            // EVENT_T_HP (2)
            // EVENT_T_MANA (3)
            // EVENT_T_KILL (5)
            // EVENT_T_RANGE (9)
            // EVENT_T_SPAWNED (11)
            // EVENT_T_TARGET_HP (12)
            // EVENT_T_TARGET_CASTING (13)
            // EVENT_T_FRIENDLY_HP (14)
            // EVENT_T_FRIENDLY_IS_CC (15)
            // EVENT_T_TARGET_MANA (18)
            // EVENT_T_MAP_SCRIPT_EVENT
            txtTimerInitialMin.Text = "";
            txtTimerInitialMax.Text = "";
            txtTimerRepeatMin.Text = "";
            txtTimerRepeatMax.Text = "";
            frmEventTimerCombat.Visible = false;

            // EVENT_T_AGGRO (4)
            // EVENT_T_DEATH (6)
            // EVENT_T_EVADE (7)
            // EVENT_T_SPAWNED (11)
            // EVENT_T_REACHED_HOME (21)
            frmEventAggro.Visible = false;

            // EVENT_T_SPELLHIT (8)
            // EVENT_T_FRIENDLY_MISSING_BUFF (16)
            // EVENT_T_AURA (23)
            // EVENT_T_TARGET_AURA (24)
            // EVENT_T_MISSING_AURA (27)
            // EVENT_T_TARGET_MISSING_AURA (28(
            btnSpellHitSpellId.Text = "-NONE-";
            txtSpellHitSchoolMask.Text = "";
            txtSpellHitRepeatMin.Text = "";
            txtSpellHitRepeatMax.Text = "";
            frmEventSpellHit.Visible = false;

            // EVENT_T_OOC_LOS (10)
            cmbEnterLOSFaction.SelectedIndex = 0;
            txtEnterLOSDistance.Text = "";
            txtEnterLOSRepeatMin.Text = "";
            txtEnterLOSRepeatMax.Text = "";
            frmEventEnterLOS.Visible = false;

            // EVENT_T_SUMMONED_UNIT (17)
            // EVENT_T_SUMMONED_JUST_DIED (25)
            // EVENT_T_SUMMONED_JUST_DESPAWN (26)
            btnSummonedUnitId.Text = "-NONE-";
            txtSummonedUnitRepeatMin.Text = "";
            txtSummonedUnitRepeatMax.Text = "";
            frmEventSummonedUnit.Visible = false;

            // EVENT_T_RECEIVE_EMOTE (22)
            cmbReceiveEmoteId.SelectedIndex = 0;
            frmEventReceiveEmote.Visible = false;

            // EVENT_T_MOVEMENT_INFORM (29)
            cmbMovementInformType.SelectedIndex = 0;
            txtMovementInformPoint.Text = "";
            txtMovementInformRepeatMin.Text = "";
            txtMovementInformRepeatMax.Text = "";
            frmEventMovementInform.Visible = false;

            // EVENT_T_GROUP_MEMBER_DIED (32)
            btnGroupMemberDiedCreatureId.Text = "-NONE-";
            cmbGroupMemberDiedIsLeader.SelectedIndex = 0;
            frmEventGroupMemberDied.Visible = false;

            dontUpdate = false;
        }

        private void ShowEventSpecificForm(CreatureEvent selectedEvent)
        {
            dontUpdate = true;
            switch (selectedEvent.Type)
            {
                case 0: // EVENT_T_TIMER
                case 1: // EVENT_T_TIMER_OOC
                case 2: // EVENT_T_HP
                case 3: // EVENT_T_MANA
                case 5: // EVENT_T_KILL
                case 9: // EVENT_T_RANGE
                case 12: // EVENT_T_TARGET_HP
                case 13: // EVENT_T_TARGET_CASTING
                case 14: // EVENT_T_FRIENDLY_HP
                case 15: // EVENT_T_FRIENDLY_IS_CC
                case 18: // EVENT_T_TARGET_MANA
                case 31: // EVENT_T_MAP_SCRIPT_EVENT
                {
                    switch (selectedEvent.Type)
                    {
                        case 0: // EVENT_T_TIMER
                        {
                            lblEventTimerCombatTooltip.Text = "A timed event that expires after the specified amount of miliseconds have passed. Only while the creature is in combat.";
                            lblTimerInitialMin.Text = "Initial Min:";
                            lblTimerInitialMax.Text = "Initial Max:";
                            lblTimerRepeatMin.Visible = true;
                            lblTimerRepeatMax.Visible = true;
                            txtTimerRepeatMin.Visible = true;
                            txtTimerRepeatMax.Visible = true;
                            break;
                        }
                        case 1: // EVENT_T_TIMER_OOC
                        {
                            lblEventTimerCombatTooltip.Text = "A timed event that expires after the specified amount of miliseconds have passed. Only while the creature is out of combat.";
                            lblTimerInitialMin.Text = "Initial Min:";
                            lblTimerInitialMax.Text = "Initial Max:";
                            lblTimerRepeatMin.Visible = true;
                            lblTimerRepeatMax.Visible = true;
                            txtTimerRepeatMin.Visible = true;
                            txtTimerRepeatMax.Visible = true;
                            break;
                        }
                        case 2: // EVENT_T_HP
                        {
                            lblEventTimerCombatTooltip.Text = "Expires when the creature's health is between the specified percents. Only while the creature is in combat.";
                            lblTimerInitialMin.Text = "HP Max:";
                            lblTimerInitialMax.Text = "HP Min:";
                            lblTimerRepeatMin.Visible = true;
                            lblTimerRepeatMax.Visible = true;
                            txtTimerRepeatMin.Visible = true;
                            txtTimerRepeatMax.Visible = true;
                            break;
                        }
                        case 3: // EVENT_T_MANA
                        {
                            lblEventTimerCombatTooltip.Text = "Expires when the creature's mana is between the specified percents. Only while the creature is in combat.";
                            lblTimerInitialMin.Text = "Mana Max:";
                            lblTimerInitialMax.Text = "Mana Min:";
                            lblTimerRepeatMin.Visible = true;
                            lblTimerRepeatMax.Visible = true;
                            txtTimerRepeatMin.Visible = true;
                            txtTimerRepeatMax.Visible = true;
                            break;
                        }
                        case 5: // EVENT_T_KILL
                        {
                            lblEventTimerCombatTooltip.Text = "Expires upon killing a player. ";
                            lblTimerInitialMin.Text = "Repeat Min:";
                            lblTimerInitialMax.Text = "Repeat Max:";
                            lblTimerRepeatMin.Visible = false;
                            lblTimerRepeatMax.Visible = false;
                            txtTimerRepeatMin.Visible = false;
                            txtTimerRepeatMax.Visible = false;
                            break;
                        }
                        case 9: // EVENT_T_RANGE
                        {
                            lblEventTimerCombatTooltip.Text = "Expires when the distance in yards to the highest threat target is in the specified range.";
                            lblTimerInitialMin.Text = "Distance Min:";
                            lblTimerInitialMax.Text = "Distance Max:";
                            lblTimerRepeatMin.Visible = true;
                            lblTimerRepeatMax.Visible = true;
                            txtTimerRepeatMin.Visible = true;
                            txtTimerRepeatMax.Visible = true;
                            break;
                        }
                        case 12: // EVENT_T_TARGET_HP
                        {
                            lblEventTimerCombatTooltip.Text = "Expires when the current victim's health is between the specified percents.";
                            lblTimerInitialMin.Text = "HP Max:";
                            lblTimerInitialMax.Text = "HP Min:";
                            lblTimerRepeatMin.Visible = true;
                            lblTimerRepeatMax.Visible = true;
                            txtTimerRepeatMin.Visible = true;
                            txtTimerRepeatMax.Visible = true;
                            break;
                        }
                        case 13: // EVENT_T_TARGET_CASTING 
                        {
                            lblEventTimerCombatTooltip.Text = "Expires when the current victim is casting a spell. ";
                            lblTimerInitialMin.Text = "Repeat Min:";
                            lblTimerInitialMax.Text = "Repeat Max:";
                            lblTimerRepeatMin.Visible = false;
                            lblTimerRepeatMax.Visible = false;
                            txtTimerRepeatMin.Visible = false;
                            txtTimerRepeatMax.Visible = false;
                            break;
                        }
                        case 14: // EVENT_T_FRIENDLY_HP
                        {
                            lblEventTimerCombatTooltip.Text = "Expires when a nearby friendly unit is missing a specified amount of its total health. Only while the creature is in combat.";
                            lblTimerInitialMin.Text = "Missing HP:";
                            lblTimerInitialMax.Text = "Distance:";
                            lblTimerRepeatMin.Visible = true;
                            lblTimerRepeatMax.Visible = true;
                            txtTimerRepeatMin.Visible = true;
                            txtTimerRepeatMax.Visible = true;
                            break;
                        }
                        case 15: // EVENT_T_FRIENDLY_IS_CC
                        {
                            lblEventTimerCombatTooltip.Text = "Expires when a nearby friendly unit is crowd controlled. Only while the creature is in combat.";
                            lblTimerInitialMin.Text = "UNUSED:";
                            lblTimerInitialMax.Text = "Distance:";
                            lblTimerRepeatMin.Visible = true;
                            lblTimerRepeatMax.Visible = true;
                            txtTimerRepeatMin.Visible = true;
                            txtTimerRepeatMax.Visible = true;
                            break;
                        }
                        case 18: // EVENT_T_TARGET_MANA
                        {
                            lblEventTimerCombatTooltip.Text = "Expires when the current victim's mana is between the specified percents.";
                            lblTimerInitialMin.Text = "Mana Max:";
                            lblTimerInitialMax.Text = "Mana Min:";
                            lblTimerRepeatMin.Visible = true;
                            lblTimerRepeatMax.Visible = true;
                            txtTimerRepeatMin.Visible = true;
                            txtTimerRepeatMax.Visible = true;
                            break;
                        }
                        case 31: // EVENT_T_MAP_SCRIPT_EVENT
                        {
                            lblEventTimerCombatTooltip.Text = "Expires upon receiving a notification from a scripted map event.";
                            lblTimerInitialMin.Text = "Event Id:";
                            lblTimerInitialMax.Text = "Data:";
                            lblTimerRepeatMin.Visible = false;
                            lblTimerRepeatMax.Visible = false;
                            txtTimerRepeatMin.Visible = false;
                            txtTimerRepeatMax.Visible = false;
                            break;
                        }
                    }
                    txtTimerInitialMin.Text = selectedEvent.Param1.ToString();
                    lblTimerInitialMin.Location = new Point(txtTimerInitialMin.Location.X - lblTimerInitialMin.Size.Width - 4, lblTimerInitialMin.Location.Y);
                    txtTimerInitialMax.Text = selectedEvent.Param2.ToString();
                    lblTimerInitialMax.Location = new Point(txtTimerInitialMax.Location.X - lblTimerInitialMax.Size.Width - 4, lblTimerInitialMax.Location.Y);
                    txtTimerRepeatMin.Text = selectedEvent.Param3.ToString();
                    lblTimerRepeatMin.Location = new Point(txtTimerRepeatMin.Location.X - lblTimerRepeatMin.Size.Width - 4, lblTimerRepeatMin.Location.Y);
                    txtTimerRepeatMax.Text = selectedEvent.Param4.ToString();
                    lblTimerRepeatMax.Location = new Point(txtTimerRepeatMax.Location.X - lblTimerRepeatMax.Size.Width - 4, lblTimerRepeatMax.Location.Y);
                    frmEventTimerCombat.Visible = true;
                    break;
                }
                case 4: // EVENT_T_AGGRO
                case 6: // EVENT_T_DEATH
                case 7: // EVENT_T_EVADE
                case 11: // EVENT_T_SPAWNED
                case 21: // EVENT_T_REACHED_HOME
                case 30: // EVENT_T_LEAVE_COMBAT
                {
                    switch (selectedEvent.Type)
                    {
                        case 4: // EVENT_T_AGGRO
                        {
                            lblEventAggroTooltip.Text = "Expires upon initial aggro, does not repeat. This event has no additional parameters.";
                            break;
                        }
                        case 6: // EVENT_T_DEATH
                        {
                            lblEventAggroTooltip.Text = "Expires when the creature dies. This event has no additional parameters.";
                            break;
                        }
                        case 7: // EVENT_T_EVADE
                        {
                            lblEventAggroTooltip.Text = "Expires when the creature enters evade mode. Does not trigger for some types of pets. This event has no additional parameters.";
                            break;
                        }
                        case 11: // EVENT_T_SPAWNED
                        {
                            lblEventAggroTooltip.Text = "Expires every time the creature spawns. This event has no additional parameters.";
                            break;
                        }
                        case 21: // EVENT_T_REACHED_HOME
                        {
                            lblEventAggroTooltip.Text = "Expires when the creature reaches its home location after an evade. This event has no additional parameters.";
                            break;
                        }
                        case 30: // EVENT_T_LEAVE_COMBAT
                        {
                            lblEventAggroTooltip.Text = "Expires when the creature leaves combat. This event has no additional parameters.";
                            break;
                        }
                    }
                    frmEventAggro.Visible = true;
                    break;
                }
                case 8: // EVENT_T_SPELLHIT
                case 16: // EVENT_T_FRIENDLY_MISSING_BUFF
                case 23: // EVENT_T_AURA
                case 24: // EVENT_T_TARGET_AURA
                case 27: // EVENT_T_MISSING_AURA
                case 28: // EVENT_T_TARGET_MISSING_AURA
                {
                    uint spellId = (uint)selectedEvent.Param1;
                    if (spellId > 0)
                        btnSpellHitSpellId.Text = GameData.FindSpellName(spellId) + " (" + spellId.ToString() + ")";
                    switch (selectedEvent.Type)
                    {
                        case 8: // EVENT_T_SPELLHIT
                        {
                            lblEventSpellHitTooltip.Text = "Expires when the creature is hit by a spell. If a spell Id is set, it will only expire when hit by that spell. Same logic applies when a school mask is set.";
                            lblSpellHitSchoolMask.Text = "School Mask:";
                            break;
                        }
                        case 16: // EVENT_T_FRIENDLY_MISSING_BUFF
                        {
                            lblEventSpellHitTooltip.Text = "Expires when a nearby friendly unit is missing an aura given by the specified spell.";
                            lblSpellHitSchoolMask.Text = "Distance:";
                            break;
                        }
                        case 23: // EVENT_T_AURA
                        {
                            lblEventSpellHitTooltip.Text = "Expires when the creature has an aura given by the specified spell.";
                            lblSpellHitSchoolMask.Text = "Min Stacks:";
                            break;
                        }
                        case 24: // EVENT_T_TARGET_AURA
                        {
                            lblEventSpellHitTooltip.Text = "Expires when the current victim has an aura given by the specified spell.";
                            lblSpellHitSchoolMask.Text = "Min Stacks:";
                            break;
                        }
                        case 27: // EVENT_T_MISSING_AURA
                        {
                            lblEventSpellHitTooltip.Text = "Expires when the creature does not have the minimum number of stacks from the specified spell aura.";
                            lblSpellHitSchoolMask.Text = "Min Stacks:";
                            break;
                        }
                        case 28: // EVENT_T_TARGET_MISSING_AURA
                        {
                            lblEventSpellHitTooltip.Text = "Expires when the current victim does not have the minimum number of stacks from the specified spell aura.";
                            lblSpellHitSchoolMask.Text = "Min Stacks:";
                            break;
                        }
                    }
                    lblSpellHitSchoolMask.Location = new Point(txtSpellHitSchoolMask.Location.X - lblSpellHitSchoolMask.Size.Width - 4, lblSpellHitSchoolMask.Location.Y);
                    txtSpellHitSchoolMask.Text = selectedEvent.Param2.ToString();
                    txtSpellHitRepeatMin.Text = selectedEvent.Param3.ToString();
                    txtSpellHitRepeatMax.Text = selectedEvent.Param4.ToString();
                    frmEventSpellHit.Visible = true;
                    break;
                }
                case 10: // EVENT_T_OOC_LOS
                {
                    cmbEnterLOSFaction.SelectedIndex = selectedEvent.Param1;
                    txtEnterLOSDistance.Text = selectedEvent.Param2.ToString();
                    txtEnterLOSRepeatMin.Text = selectedEvent.Param3.ToString();
                    txtEnterLOSRepeatMax.Text = selectedEvent.Param4.ToString();
                    frmEventEnterLOS.Visible = true;
                    break;
                }
                case 17: // EVENT_T_SUMMONED_UNIT
                case 25: // EVENT_T_SUMMONED_JUST_DIED
                case 26: // EVENT_T_SUMMONED_JUST_DESPAWN
                {
                    uint creatureId = (uint)selectedEvent.Param1;
                    if (creatureId > 0)
                        btnSummonedUnitId.Text = GameData.FindCreatureName(creatureId) + " (" + creatureId.ToString() + ")";
                    switch (selectedEvent.Type)
                    {
                        case 17: // EVENT_T_SUMMONED_UNIT
                        {
                            lblEventSummonedUnitTooltip.Text = "Expires after summoning another creature with the given Id.";
                            break;
                        }
                        case 25: // EVENT_T_SUMMONED_JUST_DIED
                        {
                            lblEventSummonedUnitTooltip.Text = "Expires after a summoned creature with the given Id dies.";
                            break;
                        }
                        case 26: // EVENT_T_SUMMONED_JUST_DESPAWN
                        {
                            lblEventSummonedUnitTooltip.Text = "Expires after a summoned creature with the given Id despawns.";
                            break;
                        }
                    }
                    txtSummonedUnitRepeatMin.Text = selectedEvent.Param2.ToString();
                    txtSummonedUnitRepeatMax.Text = selectedEvent.Param3.ToString();
                    frmEventSummonedUnit.Visible = true;
                    break;
                }
                case 22: // EVENT_T_RECEIVE_EMOTE
                {
                    cmbReceiveEmoteId.SelectedIndex = GameData.FindIndexOfTextEmote((uint)selectedEvent.Param1);
                    frmEventReceiveEmote.Visible = true;
                    break;
                }
                case 29: // EVENT_T_MOVEMENT_INFORM
                {
                    txtMovementInformType.Text = selectedEvent.Param1.ToString();
                    cmbMovementInformType.SelectedIndex = GameData.FindIndexOfMotionTypeFull((uint)selectedEvent.Param1);
                    txtMovementInformPoint.Text = selectedEvent.Param2.ToString();
                    txtMovementInformRepeatMin.Text = selectedEvent.Param3.ToString();
                    txtMovementInformRepeatMax.Text = selectedEvent.Param4.ToString();
                    frmEventMovementInform.Visible = true;
                    break;
                }
                case 32: // EVENT_T_GROUP_MEMBER_DIED
                {
                    uint creatureId = (uint)selectedEvent.Param1;
                    if (creatureId > 0)
                        btnGroupMemberDiedCreatureId.Text = GameData.FindCreatureName(creatureId) + " (" + creatureId.ToString() + ")";
                    cmbGroupMemberDiedIsLeader.SelectedIndex = selectedEvent.Param2;
                    frmEventGroupMemberDied.Visible = true;
                    break;
                }
            }
            dontUpdate = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dontUpdate = true;

            uint creature_id = 0;

            // If no creature id just clear data.
            if ((txtCreatureId.Text.Length == 0) || (!uint.TryParse(txtCreatureId.Text, out creature_id)))
            {
                ResetEditorForm();
                return;
            }

            LoadEvents(creature_id);

            dontUpdate = false;
        }

        public void LoadEvents(uint creature_id)
        {
            dontUpdate = true;

            ResetEditorForm();
            ScriptIdsList.Clear();

            MySqlConnection conn = new MySqlConnection(Program.connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT id, creature_id, condition_id, event_type, event_inverse_phase_mask, event_chance, event_flags, event_param1, event_param2, event_param3, event_param4, action1_script, action2_script, action3_script, comment FROM creature_ai_events WHERE creature_id=" + creature_id.ToString() + " ORDER BY id";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem();

                    CreatureEvent creature_event = new CreatureEvent(reader.GetUInt32(0), reader.GetUInt32(1), reader.GetUInt32(2), reader.GetUInt32(3), reader.GetUInt32(4), reader.GetUInt32(5), reader.GetUInt32(6), reader.GetInt32(7), reader.GetInt32(8), reader.GetInt32(9), reader.GetInt32(10), reader.GetUInt32(11), reader.GetUInt32(12), reader.GetUInt32(13), reader[14].ToString());

                    // Add used script ids to the list, so we can know if any are unused later.
                    if (creature_event.ScriptId1 > 0)
                        ScriptIdsList.Add(creature_event.ScriptId1);
                    if (creature_event.ScriptId2 > 0)
                        ScriptIdsList.Add(creature_event.ScriptId2);
                    if (creature_event.ScriptId3 > 0)
                        ScriptIdsList.Add(creature_event.ScriptId3);

                    // We show only id, event type, and comment in the listview.
                    lvi.Text = creature_event.Id.ToString();
                    lvi.SubItems.Add(EventTypeNames[creature_event.Type]);
                    lvi.SubItems.Add(creature_event.Comment);

                    // Save the CreatureEvent to the Tag.
                    lvi.Tag = creature_event;

                    // Add it to the listview.
                    lstEvents.Items.Add(lvi);
                }
                reader.Close();

                currentCreatureId = creature_id;

                lblCurrentCreature.Text = "Editing events for creature " + creature_id.ToString() + ".";
                this.Text = "Event Editor (" + creature_id.ToString() + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();

            dontUpdate = false;
        }

        private void lstEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEvents.SelectedItems.Count == 0)
            {
                ResetAndDisableGeneralForm();
                ResetAndHideEventSpecificForms();
                return;
            }

            dontUpdate = true;
            ListViewItem selectedItem = lstEvents.SelectedItems[0];
            CreatureEvent selectedEvent = (CreatureEvent)selectedItem.Tag;

            // Text Boxes
            txtEventId.Text = selectedEvent.Id.ToString();
            txtEventChance.Text = selectedEvent.Chance.ToString();
            txtEventComment.Text = selectedEvent.Comment;
            txtScriptId1.Text = selectedEvent.ScriptId1.ToString();
            txtScriptId2.Text = selectedEvent.ScriptId2.ToString();
            txtScriptId3.Text = selectedEvent.ScriptId3.ToString();

            // Combo Boxes
            cmbEventType.SelectedIndex = (int)selectedEvent.Type;

            // Buttons
            if (selectedEvent.ConditionId > 0)
                btnEventCondition.Text = selectedEvent.ConditionId.ToString();
            if (selectedEvent.InversePhaseMask != 0)
                btnEventPhaseMask.Text = selectedEvent.InversePhaseMask.ToString();

            // Checkboxes
            chkEventFlag1.Checked = ((selectedEvent.Flags & 1) != 0);
            chkEventFlag2.Checked = ((selectedEvent.Flags & 2) != 0);
            chkEventFlag4.Checked = ((selectedEvent.Flags & 4) != 0);

            if (Program.highlight)
            {
                if (selectedEvent.ScriptId1 != 0)
                    lblScriptId1.BackColor = Color.FromKnownColor(KnownColor.Gold);
                if (selectedEvent.ScriptId2 != 0)
                    lblScriptId2.BackColor = Color.FromKnownColor(KnownColor.Gold);
                if (selectedEvent.ScriptId3 != 0)
                    lblScriptId3.BackColor = Color.FromKnownColor(KnownColor.Gold);
                if (selectedEvent.ConditionId != 0)
                    lblEventCondition.BackColor = Color.FromKnownColor(KnownColor.Gold);
                if (selectedEvent.Chance != 100)
                    lblEventChance.BackColor = Color.FromKnownColor(KnownColor.Gold);
                if (selectedEvent.InversePhaseMask != 0)
                    lblEventPhaseMask.BackColor = Color.FromKnownColor(KnownColor.Gold);
            }

            grpGeneral.Enabled = true;

            ShowEventSpecificForm(selectedEvent);

            dontUpdate = false;
        }

        private void btnEditScript1_Click(object sender, EventArgs e)
        {
            uint script_id = 0;
            uint.TryParse(txtScriptId1.Text, out script_id);
            if (script_id > 0)
            {
                if ((script_editor == null) || (script_editor.IsDisposed))
                {
                    script_editor = new FormScriptEditor();
                    script_editor.Show();
                }
                else
                    script_editor.Focus();

                script_editor.LoadScript(script_id, "creature_ai_scripts");
                script_editor.SelectFirstAction();
            }
        }

        private void btnEditScript2_Click(object sender, EventArgs e)
        {
            uint script_id = 0;
            uint.TryParse(txtScriptId2.Text, out script_id);
            if (script_id > 0)
            {
                if ((script_editor == null) || (script_editor.IsDisposed))
                {
                    script_editor = new FormScriptEditor();
                    script_editor.Show();
                }
                else
                    script_editor.Focus();

                script_editor.LoadScript(script_id, "creature_ai_scripts");
                script_editor.SelectFirstAction();
            }
        }

        private void btnEditScript3_Click(object sender, EventArgs e)
        {
            uint script_id = 0;
            uint.TryParse(txtScriptId3.Text, out script_id);
            if (script_id > 0)
            {
                if ((script_editor == null) || (script_editor.IsDisposed))
                {
                    script_editor = new FormScriptEditor();
                    script_editor.Show();
                }
                else
                    script_editor.Focus();

                script_editor.LoadScript(script_id, "creature_ai_scripts");
                script_editor.SelectFirstAction();
            }
        }

        private void btnViewRaw_Click(object sender, EventArgs e)
        {
            if (lstEvents.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstEvents.SelectedItems[0];

                // Get the associated CreatureEvent.
                CreatureEvent currentEvent = (CreatureEvent)currentItem.Tag;

                MessageBox.Show("Id: " + currentEvent.Id.ToString() + "\nCreatureId: " + currentEvent.CreatureId.ToString() + "\nType: " + currentEvent.Type.ToString() + "\nInversePhaseMask: " + currentEvent.InversePhaseMask.ToString() + "\nChance: " + currentEvent.Chance.ToString() + "\nFlags: " + currentEvent.Flags.ToString() + "\nParameter1: " + currentEvent.Param1.ToString() + "\nParameter2: " + currentEvent.Param2.ToString() + "\nParameter3: " + currentEvent.Param3.ToString() + "\nParameter4: " + currentEvent.Param4.ToString() + "\nScript1: " + currentEvent.ScriptId1.ToString() + "\nScript2: " + currentEvent.ScriptId2 + "\nScript3: " + currentEvent.ScriptId3.ToString() + "\nCondition: " + currentEvent.ConditionId.ToString(), "Raw Event Data");
            }
        }

        // Generic function for setting script field to specified value;
        private void SetScriptFieldFromValue(float fieldvalue, string fieldname)
        {
            if (lstEvents.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstEvents.SelectedItems[0];

                // Get the associated CreatureEvent.
                CreatureEvent currentEvent = (CreatureEvent)currentItem.Tag;

                // Get the field we need to change.
                FieldInfo prop = typeof(CreatureEvent).GetField(fieldname, BindingFlags.Instance | BindingFlags.Public);

                // Updating the value in the field.
                prop.SetValue(currentEvent, Convert.ChangeType(fieldvalue, prop.FieldType));
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

            if (lstEvents.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstEvents.SelectedItems[0];

                // Get the associated CreatureEvent.
                CreatureEvent currentEvent = (CreatureEvent)currentItem.Tag;

                // Get the field we need to change.
                FieldInfo prop = typeof(CreatureEvent).GetField(fieldname, BindingFlags.Instance | BindingFlags.Public);

                // Get the old value in this field.
                uint currentValue = (uint)prop.GetValue(currentEvent);

                if (chkbox.Checked)
                    currentValue += value;
                else
                    currentValue -= value;

                prop.SetValue(currentEvent, Convert.ChangeType(currentValue, prop.FieldType));
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
            if (lstEvents.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstEvents.SelectedItems[0];

                // Get the associated ScriptAction.
                CreatureEvent currentAction = (CreatureEvent)currentItem.Tag;

                // Get the field by name.
                FieldInfo prop = typeof(CreatureEvent).GetField(fieldname, BindingFlags.Instance | BindingFlags.Public);

                // Get the value in this field.
                int currentValue = (int)Convert.ChangeType(prop.GetValue(currentAction), typeof(int));

                return currentValue;
            }

            return 0;
        }
        private void txtEventId_Leave(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstEvents.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstEvents.SelectedItems[0];

                // Get the associated CreatureEvent.
                CreatureEvent currentEvent = (CreatureEvent)currentItem.Tag;

                uint eventid = 0;
                if (uint.TryParse(txtEventId.Text, out eventid))
                {
                    currentEvent.Id = eventid;
                    currentItem.SubItems[0].Text = eventid.ToString();
                    lstEvents.Sort();
                }
            }
        }

        private void cmbEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstEvents.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstEvents.SelectedItems[0];

                // Get the associated CreatureEvent.
                CreatureEvent currentEvent = (CreatureEvent)currentItem.Tag;

                // Updating event type.
                currentEvent.Type = (uint)cmbEventType.SelectedIndex;
                currentEvent.Param1 = 0;
                currentEvent.Param2 = 0;
                currentEvent.Param3 = 0;
                currentEvent.Param4 = 0;

                // Show the appropriate command specific form.
                ResetAndHideEventSpecificForms();
                ShowEventSpecificForm(currentEvent);

                // Update event type in listview.
                currentItem.SubItems[1].Text = EventTypeNames[cmbEventType.SelectedIndex];
            }
        }

        private void txtScriptId1_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtScriptId1, "ScriptId1");
        }

        private void txtScriptId2_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtScriptId2, "ScriptId2");
        }

        private void txtScriptId3_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtScriptId3, "ScriptId3");
        }

        private void txtEventComment_Leave(object sender, EventArgs e)
        {
            if (lstEvents.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstEvents.SelectedItems[0];

                // Get the associated CreatureEvent.
                CreatureEvent currentEvent = (CreatureEvent)currentItem.Tag;

                // Updating comment.
                currentEvent.Comment = txtEventComment.Text;

                // Update comment in listview.
                currentItem.SubItems[2].Text = txtEventComment.Text;
            }
        }

        private void chkEventFlag1_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkEventFlag1, "Flags", 1);
        }

        private void chkEventFlag2_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkEventFlag2, "Flags", 2);
        }

        private void chkEventFlag4_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkEventFlag4, "Flags", 4);
        }

        private void txtEventChance_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtEventChance, "Chance");
        }

        private void btnEventPhaseMask_Click(object sender, EventArgs e)
        {
            if (lstEvents.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstEvents.SelectedItems[0];

                // Get the associated CreatureEvent.
                CreatureEvent currentEvent = (CreatureEvent)currentItem.Tag;

                // Show the mask calculator fork.
                FormMaskCalculator frm = new FormMaskCalculator((uint)currentEvent.InversePhaseMask);
                frm.ShowDialog();
                uint returnPhase = frm.ReturnValue;

                if (returnPhase > 0)
                    btnEventPhaseMask.Text = returnPhase.ToString();
                else
                    btnEventPhaseMask.Text = "-NONE-";

                // Set the field value.
                currentEvent.InversePhaseMask = returnPhase;
            }
        }

        private void btnEventCondition_Click(object sender, EventArgs e)
        {
            FormConditionFinder frm = new FormConditionFinder();
            if (frm.ShowDialog(GetScriptFieldValue("ConditionId")) == System.Windows.Forms.DialogResult.OK)
            {
                int returnId = frm.ReturnValue;

                if (returnId > 0)
                    btnEventCondition.Text = returnId.ToString();
                else
                    btnEventCondition.Text = "-NONE-";

                SetScriptFieldFromValue(returnId, "ConditionId");
            }
        }

        private void lstEvents_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (lstEvents.ListViewItemSorter == null)
                return;

            // Sort the items when column is clicked.
            MixedListSorter s = (MixedListSorter)lstEvents.ListViewItemSorter;
            s.Column = e.Column;

            if (s.Order == System.Windows.Forms.SortOrder.Ascending)
                s.Order = System.Windows.Forms.SortOrder.Descending;
            else
                s.Order = System.Windows.Forms.SortOrder.Ascending;
            lstEvents.Sort();
        }

        private void btnEventAdd_Click(object sender, EventArgs e)
        {
            // First we find the highest id in the event list.
            uint max_id = 0;
            foreach (ListViewItem item in lstEvents.Items)
            {
                CreatureEvent creature_event = (CreatureEvent)item.Tag;

                if (creature_event.Id > max_id)
                    max_id = creature_event.Id;
            }

            max_id++;

            ListViewItem newItem = new ListViewItem();

            CreatureEvent newEvent= new CreatureEvent(max_id, currentCreatureId);

            // We show only id, event type, and comment in the listview.
            newItem.Text = newEvent.Id.ToString();
            newItem.SubItems.Add(EventTypeNames[newEvent.Type]);
            newItem.SubItems.Add(newEvent.Comment);

            // Save the CreatureEvent to the Tag.
            newItem.Tag = newEvent;

            // Add it to the listview.
            lstEvents.Items.Add(newItem);

            // Select the new item.
            lstEvents.FocusedItem = newItem;
            newItem.Selected = true;
            lstEvents.Select();
        }

        private void btnEventCopy_Click(object sender, EventArgs e)
        {
            if (lstEvents.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstEvents.SelectedItems[0];

                // Get the associated CreatureEvent.
                CreatureEvent currentEvent = (CreatureEvent)currentItem.Tag;

                // Create new item.
                ListViewItem newItem = new ListViewItem();

                // First we find the highest id in the event list.
                uint max_id = 0;
                foreach (ListViewItem item in lstEvents.Items)
                {
                    CreatureEvent creature_event = (CreatureEvent)item.Tag;

                    if (creature_event.Id > max_id)
                        max_id = creature_event.Id;
                }

                max_id++;

                // Copy values of selected action.
                CreatureEvent newEvent = new CreatureEvent(max_id, currentEvent.CreatureId, currentEvent.ConditionId, currentEvent.Type, currentEvent.InversePhaseMask, currentEvent.Chance, currentEvent.Flags, currentEvent.Param1, currentEvent.Param2, currentEvent.Param3, currentEvent.Param4, currentEvent.ScriptId1, currentEvent.ScriptId2, currentEvent.ScriptId3, currentEvent.Comment + " - Copy");

                // We show only id, event type, and comment in the listview.
                newItem.Text = newEvent.Id.ToString();
                newItem.SubItems.Add(EventTypeNames[newEvent.Type]);
                newItem.SubItems.Add(newEvent.Comment);

                // Save the CreatureEvent to the Tag.
                newItem.Tag = newEvent;

                // Add it to the listview.
                lstEvents.Items.Add(newItem);

                // Select the new item.
                lstEvents.FocusedItem = newItem;
                newItem.Selected = true;
                lstEvents.Select();
            }
        }

        private void btnEventDelete_Click(object sender, EventArgs e)
        {
            if (lstEvents.SelectedItems.Count > 0)
            {
                // Get the selected item.
                ListViewItem deleteItem = lstEvents.SelectedItems[0];

                // Delete the item from the listview.
                lstEvents.Items.Remove(deleteItem);
            }
        }
        // Generates SQL query based on creature events list.
        private string GenerateSaveQuery()
        {
            string unusedScripts = "";
            List<uint> usedScripts = new List<uint>();
            // Add all currently used ScriptIds to a list.
            foreach (ListViewItem item in lstEvents.Items)
            {
                CreatureEvent creature_event = (CreatureEvent)item.Tag;
                if (creature_event.ScriptId1 > 0)
                    usedScripts.Add(creature_event.ScriptId1);
                if (creature_event.ScriptId2 > 0)
                    usedScripts.Add(creature_event.ScriptId2);
                if (creature_event.ScriptId3 > 0)
                    usedScripts.Add(creature_event.ScriptId3);
            }
            // Check if all initially used scripts are still used.
            foreach (uint id in ScriptIdsList)
            {
                if (!usedScripts.Contains(id))
                {
                    if (unusedScripts != "")
                        unusedScripts += ", ";
                    unusedScripts += id.ToString();
                }
            }
            string query = "";
            if (unusedScripts != "")
            {
                query = "-- Removing unused script actions.\nDELETE FROM `creature_ai_scripts` WHERE `id` IN (" + unusedScripts + ");\n\n";
            }
            query += "-- Events list for " + GameData.FindCreatureName(currentCreatureId) + "\nDELETE FROM `creature_ai_events` WHERE `creature_id`=" + currentCreatureId.ToString() + ";\n";
            foreach (ListViewItem lvi in lstEvents.Items)
            {
                // Get the associated CreatureEvent.
                CreatureEvent currentEvent = (CreatureEvent)lvi.Tag;

                query += "INSERT INTO `creature_ai_events` (`id`, `creature_id`, `condition_id`, `event_type`, `event_inverse_phase_mask`, `event_chance`, `event_flags`, `event_param1`, `event_param2`, `event_param3`, `event_param4`, `action1_script`, `action2_script`, `action3_script`, `comment`) VALUES (" + currentEvent.Id.ToString() + ", " + currentEvent.CreatureId.ToString() + ", " + currentEvent.ConditionId.ToString() + ", " + currentEvent.Type.ToString() + ", " + currentEvent.InversePhaseMask.ToString() + ", " + currentEvent.Chance.ToString() + ", " + currentEvent.Flags.ToString() + ", " + currentEvent.Param1.ToString() + ", " + currentEvent.Param2.ToString() + ", " + currentEvent.Param3.ToString() + ", " + currentEvent.Param4.ToString() + ", " + currentEvent.ScriptId1.ToString() + ", " + currentEvent.ScriptId2.ToString() + ", " + currentEvent.ScriptId3.ToString() + ", '" + Helpers.MySQLEscape(currentEvent.Comment) + "');\n";
            }
            return query;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentCreatureId != 0)
            {
                string query = GenerateSaveQuery();
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
                        MessageBox.Show(ex.ToString(), "Save Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();
                }
            }
            else
                MessageBox.Show("You are not editing any specific creature!", "Save Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtTimerInitialMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtTimerInitialMin, "Param1");
        }

        private void txtTimerInitialMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtTimerInitialMax, "Param2");
        }

        private void txtTimerRepeatMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtTimerRepeatMin, "Param3");
        }

        private void txtTimerRepeatMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtTimerRepeatMax, "Param4");
        }

        private void btnSpellHitSpellId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormSpellFinder>(btnSpellHitSpellId, null, GameData.FindSpellName, "Param1");
        }

        private void txtSpellHitSchoolMask_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpellHitSchoolMask, "Param2");
        }

        private void txtSpellHitRepeatMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpellHitRepeatMin, "Param3");
        }

        private void txtSpellHitRepeatMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpellHitRepeatMax, "Param4");
        }

        private void cmbEnterLOSFaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbEnterLOSFaction, "Param1", false);
        }

        private void txtEnterLOSDistance_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtEnterLOSDistance, "Param2");
        }

        private void txtEnterLOSRepeatMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtEnterLOSRepeatMin, "Param3");
        }

        private void txtEnterLOSRepeatMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtEnterLOSRepeatMax, "Param4");
        }

        private void btnSummonedUnitId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormCreatureFinder>(btnSummonedUnitId, null, GameData.FindCreatureName, "Param1");
        }

        private void txtSummonedUnitRepeatMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSummonedUnitRepeatMin, "Param2");
        }

        private void txtSummonedUnitRepeatMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSummonedUnitRepeatMax, "Param3");
        }

        private void cmbReceiveEmoteId_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbReceiveEmoteId, "Param1", true);
        }

        private void cmbMovementInformType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            SetScriptFieldFromCombobox(cmbMovementInformType, "Param1", true);
            txtMovementInformType.Text = (cmbMovementInformType.SelectedItem as ComboboxPair).Value.ToString();
        }

        private void txtMovementInformType_Leave(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            uint motion_type;
            if (uint.TryParse(txtMovementInformType.Text, out motion_type) && (GameData.FindIndexOfMotionTypeFull(motion_type) != -1))
            {
                dontUpdate = true;
                cmbMovementInformType.SelectedIndex = GameData.FindIndexOfMotionTypeFull(motion_type);
                dontUpdate = false;
                SetScriptFieldFromValue(motion_type, "Param1");
            }
            else
            {
                dontUpdate = true;
                txtMovementInformType.Text = "0";
                cmbMovementInformType.SelectedIndex = 0;
                dontUpdate = false;
                SetScriptFieldFromValue(0, "Param1");
            }
        }

        private void txtMovementInformPoint_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtMovementInformPoint, "Param2");
        }

        private void txtMovementInformRepeatMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtMovementInformRepeatMin, "Param3");
        }

        private void txtMovementInformRepeatMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtMovementInformRepeatMax, "Param4");
        }

        private void btnGroupMemberDiedCreatureId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormCreatureFinder>(btnGroupMemberDiedCreatureId, null, GameData.FindCreatureName, "Param1");
        }

        private void cmbGroupMemberDiedIsLeader_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbGroupMemberDiedIsLeader, "Param2", false);
        }
    }
}
