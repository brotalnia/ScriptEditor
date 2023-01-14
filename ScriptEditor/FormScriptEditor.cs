using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Reflection;
using System.Text.RegularExpressions;
using ScriptEditor.DataFinderForms;

namespace ScriptEditor
{

    // Used to get the name of quests, creatures, etc.
    public delegate string NameFinder(uint id);

    public partial class FormScriptEditor : Form
    {
        // Save what we are currently working on.
        public uint currentScriptId = 0;
        public string currentScriptTable = "";

        // Used to prevent control events triggering when resetting data.
        bool dontUpdate = false;

        // Command Type Names
        private string[] CommandTypeNames =
        {
        "Talk",                     // 0
        "Emote",                    // 1
        "Field Set",                // 2
        "Move",                     // 3
        "Modify Flags",             // 4
        "Interrupt Casts",          // 5
        "Teleport",                 // 6
        "Complete Quest",           // 7
        "Kill Credit",              // 8
        "Respawn GameObject",       // 9
        "Summon Creature",          // 10
        "Open Door",                // 11
        "Close Door",               // 12
        "Activate GameObject",      // 13
        "Remove Aura",              // 14
        "Cast Spell",               // 15
        "Play Sound",               // 16
        "Create Item",              // 17
        "Despawn Creature",         // 18
        "Set Equipment",            // 19
        "Set Movement Type",        // 20
        "Make Active Object",       // 21
        "Set Faction",              // 22
        "Morph",                    // 23
        "Mount",                    // 24
        "Toggle Run or Walk",       // 25
        "Start Attack",             // 26
        "Update Entry",             // 27
        "Set Stand State",          // 28
        "Modify Threat",            // 29
        "Start Taxi Path",          // 30
        "Terminate Script",         // 31
        "Terminate Condition",      // 32
        "Enter Evade Mode",         // 33
        "Set Home Position",        // 34
        "Set Orientation",          // 35
        "MeetingStone Queue",       // 36
        "Set Data",                 // 37
        "Set Data 64",              // 38
        "Start Script",             // 39
        "Remove Item",              // 40
        "Remove Object",            // 41
        "Set Melee Attack",         // 42
        "Set Combat Movement",      // 43
        "Set Phase",                // 44
        "Set Phase Random",         // 45
        "Set Phase Range",          // 46
        "Flee",                     // 47
        "Deal Damage",              // 48
        "Combat Pulse",             // 49
        "Call For Help",            // 50
        "Set Sheath State",         // 51
        "Set Invincibility HP",     // 52
        "Start Game Event",         // 53
        "Set Server Variable",      // 54
        "Set Spells List",          // 55
        "Remove Guardians",         // 56
        "Add Spell Cooldown",       // 57
        "Remove Spell Cooldown",    // 58
        "Set React State",          // 59
        "Start Waypoints",          // 60
        "Start Map Event",          // 61
        "End Map Event",            // 62
        "Add Map Event Target",     // 63
        "Remove Map Event Target",  // 64
        "Set Map Event Data",       // 65
        "Send Map Event",           // 66
        "Set Default Movement",     // 67
        "Start Script For All",     // 68
        "Edit Map Event",           // 69
        "Fail Quest",               // 70
        "Respawn Creature",         // 71
        "Assist Unit",              // 72
        "Combat Stop",              // 73
        "Add Aura",                 // 74
        "Add Threat",               // 75
        "Summon Object",            // 76
        "Set Fly",                  // 77
        "Join Creature Group",      // 78
        "Leave Creature Group",     // 79
        "Set GO State",             // 80
        "Despawn GameObject",       // 81
        "Load GameObject",          // 82
        "Quest Credit",             // 83
        "Set Gossip Menu",          // 84
        "Send AI Event",            // 85
        "Set PvP",                  // 86
        "Reset Door or Button",     // 87
        "Set Command State",        // 88
        "Play Custom Anim",         // 89
        "Start Script on Group",    // 90
        };

        // Options for combo boxes.
        public string[] CommandSetData_ComboOptions = { "Save Raw Value", "Increment Existing Data", "Decrement Existing Data" };
        public string[] CommandSetData64_ComboOptions = { "Save Raw Value", "Save Own GUID"};
        public string[] CommandSetPhase_ComboOptions = { "Change To Specified Value", "Increment Current Phase", "Decrement Current Phase" };
        public string[] CommandDealDamage_ComboOptions = { "Raw Value", "Percent of Total Health" };
        public string[] CommandFlee_ComboOptions = { "Random Direction", "Seek Assistance" };
        public string[] CommandCombatPulse_ComboOptions = { "False", "True" };
        public string[] CommandSetSheathState_ComboOptions = { "Unarmed", "Melee", "Ranged" };
        public string[] CommandSendScriptedMapEvent_ComboOptions = { "Main Targets Only", "Additional Targets Only", "All Targets" };
        public string[] CommandSetGOState_ComboOptions = { "Active", "Ready", "Active Alternative" };
        public string[] CommandSetCommandState_ComboOptions = { "Stay", "Follow", "Attack", "Dismiss" };
        public string[] CommandPlayCustomAnim_ComboOptions = { "Anim 0", "Anim 1", "Anim 2", "Anim 3" };

        public FormScriptEditor()
        {
            InitializeComponent();
        }

        private void FormScriptEditor_Load(object sender, EventArgs e)
        {
            LoadControls();
        }

        private void FormScriptEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((currentScriptId != 0) && (MessageBox.Show("Are you sure you want to close the editor?\n\nScript changes are not saved automatically. Make sure you've clicked the Save button first, or your changes will be lost.", "Exit Editor?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
            {
                e.Cancel = true;
            }
        }

        private void LoadControls()
        {
            dontUpdate = true;

            // Assign sorter to listview.
            lstActions.ListViewItemSorter = new ActionSorter();

            // Add options to Commands combo box.
            cmbCommandId.DataSource = CommandTypeNames;
            cmbCommandId.SelectedIndex = 0;

            // Add option to Target Type combo box.
            cmbTargetType.Items.Add(new ComboboxPair("Provided Target", 0));
            cmbTargetType.Items.Add(new ComboboxPair("Current Victim", 1));
            cmbTargetType.Items.Add(new ComboboxPair("Second on Threat", 2));
            cmbTargetType.Items.Add(new ComboboxPair("Last on Threat", 3));
            cmbTargetType.Items.Add(new ComboboxPair("Random Attacker", 4));
            cmbTargetType.Items.Add(new ComboboxPair("Random Not Top", 5));
            cmbTargetType.Items.Add(new ComboboxPair("Owner or Source", 6));
            cmbTargetType.Items.Add(new ComboboxPair("Owner of Source", 7));
            cmbTargetType.Items.Add(new ComboboxPair("Creature Entry", 8));
            cmbTargetType.Items.Add(new ComboboxPair("Creature GUID", 9));
            cmbTargetType.Items.Add(new ComboboxPair("Creature Instance Data", 10));
            cmbTargetType.Items.Add(new ComboboxPair("Gameobject Entry", 11));
            cmbTargetType.Items.Add(new ComboboxPair("Gameobject GUID", 12));
            cmbTargetType.Items.Add(new ComboboxPair("Gameobject Instance Data", 13));
            cmbTargetType.Items.Add(new ComboboxPair("Nearby Friendly", 14));
            cmbTargetType.Items.Add(new ComboboxPair("Injured Friendly", 15));
            cmbTargetType.Items.Add(new ComboboxPair("Injured Not Self", 16));
            cmbTargetType.Items.Add(new ComboboxPair("Friendly Missing Buff", 17));
            cmbTargetType.Items.Add(new ComboboxPair("Missing Buff Not Self", 18));
            cmbTargetType.Items.Add(new ComboboxPair("Friendly CC-ed", 19));
            cmbTargetType.Items.Add(new ComboboxPair("Map Event Source", 20));
            cmbTargetType.Items.Add(new ComboboxPair("Map Event Target", 21));
            cmbTargetType.Items.Add(new ComboboxPair("Map Event Additional", 22));
            cmbTargetType.Items.Add(new ComboboxPair("Nearest Player", 23));
            cmbTargetType.Items.Add(new ComboboxPair("Nearest Hostile Player", 24));
            cmbTargetType.Items.Add(new ComboboxPair("Nearest Friendly Player", 25));
            cmbTargetType.Items.Add(new ComboboxPair("Random Creature", 26));
            cmbTargetType.Items.Add(new ComboboxPair("Random Gameobject", 27));
            cmbTargetType.SelectedIndex = 0;

            // Add chat types to combo box.
            cmbTalkChatType.Items.Add(new ComboboxPair("-NONE-", 0));
            cmbTalkChatType.Items.Add(new ComboboxPair("Yell", 1));
            cmbTalkChatType.Items.Add(new ComboboxPair("Text Emote", 2));
            cmbTalkChatType.Items.Add(new ComboboxPair("Zone Emote", 3));
            cmbTalkChatType.Items.Add(new ComboboxPair("Whisper", 4));
            cmbTalkChatType.Items.Add(new ComboboxPair("Boss Whisper", 5));
            cmbTalkChatType.Items.Add(new ComboboxPair("Zone Yell", 6));
            cmbTalkChatType.SelectedIndex = 0;

            // Assign emotes list to combo box.
            cmbEmoteId.BindingContext = new BindingContext();
            cmbEmoteId.DataSource = GameData.EmotesList;
            cmbEmoteId2.BindingContext = new BindingContext();
            cmbEmoteId2.DataSource = GameData.EmotesList;
            cmbEmoteId3.BindingContext = new BindingContext();
            cmbEmoteId3.DataSource = GameData.EmotesList;
            cmbEmoteId4.BindingContext = new BindingContext();
            cmbEmoteId4.DataSource = GameData.EmotesList;

            // Assign fields list to combo box.
            cmbFieldSetFields.DataSource = GameData.FlagFieldsList;

            // Assign maps list to combo box.
            cmbTeleportMap.DataSource = GameData.MapsList;

            // Add options to Move To Coordinates Type combo box.
            cmbMoveToType.Items.Add(new ComboboxPair("Normal coordinates", 0));
            cmbMoveToType.Items.Add(new ComboboxPair("Relative to target", 1));
            cmbMoveToType.Items.Add(new ComboboxPair("Distance from target", 2));
            cmbMoveToType.Items.Add(new ComboboxPair("Random point around coordinates", 2));

            // Add options to Kill Credit Type combo box.
            cmbKillCreditType.Items.Add(new ComboboxPair("Personal credit", 0));
            cmbKillCreditType.Items.Add(new ComboboxPair("Group credit", 1));

            // Add options to Summon Creature Attack Target combo box.
            cmbSummonCreatureAttackTarget.Items.Add(new ComboboxPair("None", -1));
            cmbSummonCreatureAttackTarget.Items.Add(new ComboboxPair("Provided Target", 0));
            cmbSummonCreatureAttackTarget.Items.Add(new ComboboxPair("Current Victim", 1));
            cmbSummonCreatureAttackTarget.Items.Add(new ComboboxPair("Second on Threat", 2));
            cmbSummonCreatureAttackTarget.Items.Add(new ComboboxPair("Last on Threat", 3));
            cmbSummonCreatureAttackTarget.Items.Add(new ComboboxPair("Random Attacker", 4));
            cmbSummonCreatureAttackTarget.Items.Add(new ComboboxPair("Random Not Top", 5));
            cmbSummonCreatureAttackTarget.Items.Add(new ComboboxPair("Owner or Self", 6));
            cmbSummonCreatureAttackTarget.Items.Add(new ComboboxPair("Owner", 7));

            // Add options to Summon Creature Despawn Type combo box.
            cmbSummonCreatureDespawnType.Items.Add(new ComboboxPair("Timer OOC or Disappear", 1));
            cmbSummonCreatureDespawnType.Items.Add(new ComboboxPair("Timer OOC or Death", 2));
            cmbSummonCreatureDespawnType.Items.Add(new ComboboxPair("Timer", 3));
            cmbSummonCreatureDespawnType.Items.Add(new ComboboxPair("Timer OOC", 4));
            cmbSummonCreatureDespawnType.Items.Add(new ComboboxPair("On Death", 5));
            cmbSummonCreatureDespawnType.Items.Add(new ComboboxPair("Timer after Death", 6));
            cmbSummonCreatureDespawnType.Items.Add(new ComboboxPair("On Corpse Despawn", 7));
            cmbSummonCreatureDespawnType.Items.Add(new ComboboxPair("Manual", 8));
            cmbSummonCreatureDespawnType.Items.Add(new ComboboxPair("Timer or Disappear", 9));
            cmbSummonCreatureDespawnType.Items.Add(new ComboboxPair("Timer or Death", 10));

            // Assign options to Set Phase combo box.
            cmbSetPhaseMode.DataSource = CommandSetPhase_ComboOptions;

            // Assign options to Flee combo box.
            cmbFleeMode.DataSource = CommandFlee_ComboOptions;

            // Assign motion types list to combo box.
            cmbSetMovementType.DataSource = GameData.MotionTypesList;

            // Assign update fields to combo box.
            cmbFieldSetFields.DataSource = GameData.UpdateFieldsList;

            // Assign flag fields to combo box.
            cmbModifyFlagsFieldId.DataSource = GameData.FlagFieldsList;

            // Setting default selection for combo boxes.
            cmbSummonCreatureAttackTarget.SelectedIndex = 0;
            cmbTable.SelectedIndex = 0;
            cmbSetMovementType.SelectedIndex = 0;

            //Add tooltips to controls.
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.SetToolTip(this.chkSwapInitial, "Swaps the original source and target, before buddy is checked.");
            toolTip1.SetToolTip(this.chkSwapFinal, "Swaps the final source and target, after buddy is assigned.");
            toolTip1.SetToolTip(this.chkTargetSelf, "Replaces the final target with the final source.");
            toolTip1.SetToolTip(this.chkAbortScript, "Terminates the whole script if the command fails.");
            toolTip1.SetToolTip(this.chkSkipMissingTargets, "Command is skipped if source or target is not found, without printing an error.");
            toolTip1.SetToolTip(this.lblDelay, "Delay in seconds before the command runs.");
            toolTip1.SetToolTip(this.lblPriority, "Defines the order of execution of commands with the same delay. Lower priority runs first.");
            toolTip1.SetToolTip(this.lblCommandCondition, "Command will only be executed if the specified condition is satisfied. Checked after targets are assigned.");
            toolTip1.SetToolTip(this.lblComment, "Script Name: Source Name - Command Name");
            toolTip1.SetToolTip(this.lblTargetType, "Allows you to replace the original target that's provided to the script.\r\nBe aware that it's the source that executes the action, while target is only used as an additional argument for some commands.\r\nFor example if you use the Cast Spell command, its the source that will cast the spell at the target.\r\nTo make another object perform the action, use the flag to swap the source and target.");

            //MessageBox.Show((cmbCommandId.SelectedItem as ComboboxPair).Value.ToString());
            dontUpdate = false;
        }

        // Generates SQL query based on script actions list.
        private string GenerateScriptQuery()
        {
            string query = "DELETE FROM `" + currentScriptTable + "` WHERE `id`=" + currentScriptId.ToString() + ";\n";
            query += "INSERT INTO `" + currentScriptTable + "` (`id`, `delay`, `priority`, `command`, `datalong`, `datalong2`, `datalong3`, `datalong4`, `target_param1`, `target_param2`, `target_type`, `data_flags`, `dataint`, `dataint2`, `dataint3`, `dataint4`, `x`, `y`, `z`, `o`, `condition_id`, `comments`) VALUES\n";
            for (int i = 0; i < lstActions.Items.Count; i++)
            {
                // Get the associated ScriptAction.
                ListViewItem lvi = lstActions.Items[i];
                ScriptAction currentAction = (ScriptAction)lvi.Tag;

                if (i > 0)
                    query += ",\n";
                query += "(" + currentAction.Id.ToString() + ", " + currentAction.Delay.ToString() + ", " + currentAction.Priority.ToString() + ", " + currentAction.Command.ToString() + ", " + currentAction.Datalong.ToString() + ", " + currentAction.Datalong2.ToString() + ", " + currentAction.Datalong3.ToString() + ", " + currentAction.Datalong4.ToString() + ", " + currentAction.TargetParam1.ToString() + ", " + currentAction.TargetParam2.ToString() + ", " + currentAction.TargetType.ToString() + ", " + currentAction.DataFlags.ToString() + ", " + currentAction.Dataint.ToString() + ", " + currentAction.Dataint2.ToString() + ", " + currentAction.Dataint3.ToString() + ", " + currentAction.Dataint4.ToString() + ", " + currentAction.X.ToString().Replace(',', '.') + ", " + currentAction.Y.ToString().Replace(',', '.') + ", " + currentAction.Z.ToString().Replace(',', '.') + ", " + currentAction.O.ToString().Replace(',', '.') + ", " + currentAction.ConditionId.ToString() + ", '" + Helpers.MySQLEscape(currentAction.Comments) + "')";
            }
            return query + ";\n";
        }

        private void ResetEditorForm()
        {
            dontUpdate = true;
            lstActions.Items.Clear();
            ResetAndDisableGeneralForm();
            ResetAndHideCommandSpecificForms();
            this.Text = "Script Editor";
            lblId.Text = "No script loaded.";
            currentScriptId = 0;
            currentScriptTable = "";
            dontUpdate = false;
        }
        private void txtScriptId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnFind_Click(this, new EventArgs());
                e.Handled = true;
            }
        }
        private void btnViewRaw_Click(object sender, EventArgs e)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                MessageBox.Show("Id: " + currentAction.Id.ToString() + "\nDelay: " + currentAction.Delay.ToString() + "\nCommand: " + currentAction.Command.ToString() + "\nDatalong: " + currentAction.Datalong.ToString() + "\nDatalong2: " + currentAction.Datalong2.ToString() + "\nDatalong3: " + currentAction.Datalong3.ToString() + "\nDatalong4: " + currentAction.Datalong4.ToString() + "\nTargetParam1: " + currentAction.TargetParam1.ToString() + "\nTargetParam2: " + currentAction.TargetParam2.ToString() + "\nTargetType: " + currentAction.TargetType.ToString() + "\nDataFlags: " + currentAction.DataFlags.ToString() + "\nDataint: " + currentAction.Dataint.ToString() + "\nDataint2: " + currentAction.Dataint2.ToString() + "\nDataint3: " + currentAction.Dataint3.ToString() + "\nDataint4: " + currentAction.Dataint4.ToString() + "\nX: " + currentAction.X.ToString() + "\nY: " + currentAction.Y.ToString() + "\nZ: " + currentAction.Z.ToString() + "\nO: " + currentAction.O.ToString() + "\nCondition: " + currentAction.ConditionId.ToString(), "Raw Script Data");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dontUpdate = true;

            uint script_id = 0;

            // If no script id just clear data.
            if ((txtScriptId.Text.Length == 0) || (!uint.TryParse(txtScriptId.Text, out script_id)))
            {
                ResetEditorForm();
                return;
            }

            LoadScript(script_id, cmbTable.Text);

            dontUpdate = false;
        }

        public void LoadScript(uint script_id, string table_name)
        {
            dontUpdate = true;

            ResetEditorForm();

            MySqlConnection conn = new MySqlConnection(Program.connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT id, delay, priority, command, datalong, datalong2, datalong3, datalong4, target_param1, target_param2, target_type, data_flags, dataint, dataint2, dataint3, dataint4, x, y, z, o, condition_id, comments FROM " + table_name + " WHERE id=" + script_id.ToString() + " ORDER BY delay, priority";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem();

                    ScriptAction action = new ScriptAction(reader.GetUInt32(0), reader.GetUInt32(1), reader.GetUInt32(2), reader.GetUInt32(3), reader.GetUInt32(4), reader.GetUInt32(5), reader.GetUInt32(6), reader.GetUInt32(7), reader.GetUInt32(8), reader.GetUInt32(9), reader.GetUInt32(10), reader.GetUInt32(11), reader.GetInt32(12), reader.GetInt32(13), reader.GetInt32(14), reader.GetInt32(15), reader.GetFloat(16), reader.GetFloat(17), reader.GetFloat(18), reader.GetFloat(19), reader.GetUInt32(20), reader[21].ToString());

                    // We show only delay, command id and comment in the listview.
                    lvi.Text = action.Delay.ToString();
                    lvi.SubItems.Add(action.Command.ToString());
                    lvi.SubItems.Add(action.Comments);

                    // Save the ScriptAction to the Tag.
                    lvi.Tag = action;

                    // Add it to the listview.
                    lstActions.Items.Add(lvi);
                }
                reader.Close();

                currentScriptId = script_id;
                currentScriptTable = table_name;

                lblId.Text = "Editing script " + script_id.ToString() + " from " + table_name + ".";
                this.Text = "Script Editor (" + script_id.ToString() + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();

            dontUpdate = false;
        }

        public void SelectFirstAction()
        {
            if (lstActions.Items.Count > 0)
                lstActions.Items[0].Selected = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentScriptId != 0)
            {
                string query = GenerateScriptQuery();
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
                        MessageBox.Show(ex.ToString(), "Save Script", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();
                }
            }
            else
                MessageBox.Show("You are not editing a script, cannot save to unknown table.", "Save Script", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnActionDelete_Click(object sender, EventArgs e)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item.
                ListViewItem deleteItem = lstActions.SelectedItems[0];

                // Delete the item from the listview.
                lstActions.Items.Remove(deleteItem);
            }
        }

        private void ResetAndDisableGeneralForm()
        {
            dontUpdate = true;

            // Text Boxes.
            txtCommandDelay.Text = "";
            txtCommandPriority.Text = "";
            txtCommandComment.Text = "";
            txtTargetParam1.Text = "";
            txtTargetParam2.Text = "";
            btnTargetParam1.Text = "-NONE-";
            btnTargetParam1.Visible = false;
            
            // Combo Boxes.
            cmbTargetType.SelectedIndex = 0;
            cmbTargetType.Text = "";
            cmbCommandId.SelectedIndex = 0;
            cmbCommandId.Text = "";

            // Check Boxes.
            chkSkipMissingTargets.Checked = false;
            chkAbortScript.Checked = false;
            chkSwapFinal.Checked = false;
            chkSwapInitial.Checked = false;
            chkTargetSelf.Checked = false;

            // Buttons.
            btnCommandCondition.Text = "-NONE-";

            if (Program.highlight)
            {
                lblDelay.BackColor = Color.FromKnownColor(KnownColor.Control);
                lblTargetParam1.BackColor = Color.FromKnownColor(KnownColor.Control);
                lblTargetParam2.BackColor = Color.FromKnownColor(KnownColor.Control);
                lblTargetType.BackColor = Color.FromKnownColor(KnownColor.Control);
                lblCommandCondition.BackColor = Color.FromKnownColor(KnownColor.Control);
            }

            // Make the form disabled.
            grpGeneral.Enabled = false;

            dontUpdate = false;
        }
        private void ResetAndHideCommandSpecificForms()
        {
            dontUpdate = true;

            // Unsupported command
            frmCommandUnknown.Visible = false;
            txtUnknownCommandDatalong1.Text = "";
            txtUnknownCommandDatalong2.Text = "";
            txtUnknownCommandDatalong3.Text = "";
            txtUnknownCommandDatalong4.Text = "";
            txtUnknownCommandDataint1.Text = "";
            txtUnknownCommandDataint2.Text = "";
            txtUnknownCommandDataint3.Text = "";
            txtUnknownCommandDataint4.Text = "";
            txtUnknownCommandX.Text = "";
            txtUnknownCommandY.Text = "";
            txtUnknownCommandZ.Text = "";
            txtUnknownCommandO.Text = "";

            // Talk (0)
            frmCommandTalk.Visible = false;
            btnTalkText1.Text = "-NONE-";
            btnTalkText2.Text = "-NONE-";
            btnTalkText3.Text = "-NONE-";
            btnTalkText4.Text = "-NONE-";
            txtTalkText1.Text = "";
            txtTalkText2.Text = "";
            txtTalkText3.Text = "";
            txtTalkText4.Text = "";
            cmbTalkChatType.SelectedIndex = 0;

            // Emote (1)
            frmCommandEmote.Visible = false;
            cmbEmoteId.SelectedIndex = 0;
            cmbEmoteId2.SelectedIndex = 0;
            cmbEmoteId3.SelectedIndex = 0;
            cmbEmoteId4.SelectedIndex = 0;
            cmbEmoteTargeted.SelectedIndex = 0;

            // Field Set (2)
            cmbFieldSetFields.SelectedIndex = 0;
            txtFieldSetValue.Text = "";
            frmCommandFieldSet.Visible = false;

            // Move To (3)
            cmbMoveToType.SelectedIndex = 0;
            txtMoveToTime.Text = "";
            txtMoveToX.Text = "";
            txtMoveToY.Text = "";
            txtMoveToY.Enabled = true;
            txtMoveToZ.Text = "";
            txtMoveToZ.Enabled = true;
            txtMoveToO.Text = "";
            txtMoveToO.Enabled = true;
            grpMoveToOptions.Enabled = true;
            chkMoveOptions1.Checked = false;
            chkMoveOptions2.Checked = false;
            chkMoveOptions4.Checked = false;
            chkMoveOptions8.Checked = false;
            chkMoveOptions16.Checked = false;
            chkMoveOptions32.Checked = false;
            chkMoveOptions64.Checked = false;
            chkMoveOptions128.Checked = false;
            chkMoveOptions256.Checked = false;
            chkMoveToFlagsForce.Checked = false;
            chkMoveToFlagsPointMovement.Checked = false;
            txtMoveToPointId.Text = "";
            txtMoveToPointId.Enabled = false;
            frmCommandMoveTo.Visible = false;

            // Modify Flags (4)
            cmbModifyFlagsFieldId.SelectedIndex = 0;
            cmbModifyFlagsMode.SelectedIndex = 0;
            btnModifyFlagsFlags.Text = "-NONE-";
            frmCommandModifyFlags.Visible = false;

            // Interrupt Casts (5)
            btnInterruptCastsSpellId.Text = "-NONE-";
            cmbInterruptCastsWithDelayed.SelectedIndex = 0;
            frmCommandInterruptCasts.Visible = false;

            // Teleport (6)
            txtTeleportX.Text = "";
            txtTeleportY.Text = "";
            txtTeleportZ.Text = "";
            txtTeleportO.Text = "";
            cmbTeleportMap.SelectedIndex = 0;
            chkTeleportOptions1.Checked = false;
            chkTeleportOptions2.Checked = false;
            chkTeleportOptions4.Checked = false;
            chkTeleportOptions8.Checked = false;
            chkTeleportOptions16.Checked = false;
            chkTeleportOptions32.Checked = false;
            frmCommandTeleport.Visible = false;

            // Quest Complete (7)
            btnQuestCompleteId.Text = "-NONE-";
            txtQuestCompleteDistance.Text = "";
            cmbQuestCompleteGroup.SelectedIndex = 0;
            frmCommandQuestComplete.Visible = false;

            // Kill Credit (8)
            btnKillCreditCreatureId.Text = "-NONE-";
            cmbKillCreditType.SelectedIndex = 0;
            frmCommandKillCredit.Visible = false;

            // Respawn GameObject (9)
            // Despawn GameObject (81)
            // Load GameObject (82)
            txtRespawnGameobjectDelay.Text = "";
            txtRespawnGameobjectGuid.Text = "";
            frmCommandRespawnGameobject.Visible = false;

            // Summon Creature (10)
            btnSummonCreatureId.Text = "-NONE-";
            txtSummonCreatureDelay.Text = "";
            txtSummonCreatureUniqueLimit.Text = "";
            txtSummonCreatureUniqueRange.Text = "";
            txtSummonCreatureX.Text = "";
            txtSummonCreatureY.Text = "";
            txtSummonCreatureZ.Text = "";
            txtSummonCreatureO.Text = "";
            cmbSummonCreatureAttackTarget.SelectedIndex = 0;
            txtSummonCreatureScriptId.Text = "";
            cmbSummonCreatureDespawnType.SelectedIndex = 0;
            chkSummonCreatureFlags1.Checked = false;
            chkSummonCreatureFlags2.Checked = false;
            chkSummonCreatureFlags4.Checked = false;
            chkSummonCreatureFlags8.Checked = false;
            chkSummonCreatureFlags16.Checked = false;
            frmCommandSummonCreature.Visible = false;

            // Open Door (11)
            // Close Door (12)
            // Activate GameObject (13)
            // Reset Door or Button (87)
            txtDoorGuid.Text = "";
            txtDoorResetDelay.Text = "";
            frmCommandDoor.Visible = false;

            // Remove Aura (14)
            // Add Aura (74)
            btnRemoveAuraSpellId.Text = "-NONE-";
            chkAddAuraFlag1.Checked = false;
            chkAddAuraFlag2.Checked = false;
            chkAddAuraFlag4.Checked = false;
            chkAddAuraFlag8.Checked = false;
            frmCommandRemoveAura.Visible = false;

            // Cast Spell (15)
            btnCastSpellId.Text = "-NONE-";
            chkCastSpellFlags1.Checked = false;
            chkCastSpellFlags2.Checked = false;
            chkCastSpellFlags4.Checked = false;
            chkCastSpellFlags16.Checked = false;
            chkCastSpellFlags32.Checked = false;
            chkCastSpellFlags64.Checked = false;
            chkCastSpellFlags128.Checked = false;
            frmCommandCastSpell.Visible = false;

            // Play Sound (16)
            btnPlaySoundId.Text = "-NONE-";
            chkPlaySoundFlags1.Checked = false;
            chkPlaySoundFlags2.Checked = false;
            chkPlaySoundFlags4.Checked = false;
            frmCommandPlaySound.Visible = false;

            // Create Item and Remove Item (17, 40)
            btnCreateItemId.Text = "-NONE-";
            txtCreateItemAmount.Text = "";
            frmCommandCreateItem.Visible = false;

            // Set Equipment (19)
            btnSetEquipmentMainHand.Text = "-NONE-";
            btnSetEquipmentOffHand.Text = "-NONE-";
            btnSetEquipmentRanged.Text = "-NONE-";
            cmbSetEquipmentUseDefault.SelectedIndex = 0;
            frmCommandSetEquipment.Visible = false;

            // Set Movement (20)
            cmbSetMovementType.SelectedIndex = 0;
            cmbSetMovementBoolParam.SelectedIndex = 0;
            cmbSetMovementClearMotionMaster.SelectedIndex = 0;
            cmbSetMovementClearMotionMaster.Enabled = false;
            cmbSetMovementBoolParam.Enabled = false;
            lblSetMovementBoolParam.Text = "Bool Param:";
            txtSetMovementIntParam.Enabled = false;
            txtSetMovementIntParam.Text = "";
            lblSetMovementIntParam.Text = "Int Param:";
            txtSetMovementDistance.Enabled = false;
            txtSetMovementDistance.Text = "";
            txtSetMovementAngle.Enabled = false;
            txtSetMovementAngle.Text = "";
            lblSetMovementBoolParam.Location = new Point(cmbSetMovementBoolParam.Location.X - lblSetMovementBoolParam.Size.Width - 4, lblSetMovementBoolParam.Location.Y);
            lblSetMovementIntParam.Location = new Point(txtSetMovementIntParam.Location.X - lblSetMovementIntParam.Size.Width - 4, lblSetMovementIntParam.Location.Y);
            frmCommandSetMovement.Visible = false;

            // Set Active Object (21)
            // Set Melee Attack (42)
            // Set Combat Movement (43)
            cmbActiveObjectSetActive.SelectedIndex = 0;
            frmCommandActiveObject.Visible = false;

            // Set Faction (22)
            btnSetFactionId.Text = "-NONE-";
            chkSetFactionFlag1.Checked = false;
            chkSetFactionFlag2.Checked = false;
            chkSetFactionFlag4.Checked = false;
            frmCommandSetFaction.Visible = false;

            // Morph (23) and Mount (24)
            btnMorphOrMountId.Text = "-NONE-";
            cmbMorphOrMountType.SelectedIndex = 0;
            cmbMorphOrMountPermanent.SelectedIndex = 0;
            frmCommandMorphOrMount.Visible = false;

            // Set Run (25)
            cmbSetRunMode.SelectedIndex = 0;
            frmCommandSetRun.Visible = false;

            // Update Entry (27)
            // Remove Guardians (56)
            btnUpdateEntryCreatureId.Text = "-NONE-";
            frmCommandUpdateEntry.Visible = false;

            // Set Stand State (28)
            cmbSetStandState.SelectedIndex = 0;
            frmCommandSetStandState.Visible = false;

            // Modify Threat (29)
            cmbModifyThreatTarget.SelectedIndex = 0;
            txtModifyThreatPercent.Text = "";
            frmCommandModifyThreat.Visible = false;

            // Send Taxi Path (30)
            btnSendTaxiPathId.Text = "-NONE-";
            txtSendTaxiPath.Text = "";
            frmCommandSendTaxiPath.Visible = false;

            // Terminate Script (31)
            btnTerminateScriptCreatureId.Text = "-NONE-";
            txtTerminateScriptSearchRadius.Text = "";
            cmbTerminateScriptCondition.SelectedIndex = 0;
            frmCommandTerminateScript.Visible = false;

            // Terminate Condition (32)
            btnTerminateConditionId.Text = "-NONE-";
            btnTerminateConditionQuest.Text = "-NONE-";
            cmbTerminateConditionRule.SelectedIndex = 0;
            frmCommandTerminateCondition.Visible = false;

            // Set Home Position (34)
            cmbSetHomePositionMode.SelectedIndex = 0;
            txtSetHomePositionX.Text = "";
            txtSetHomePositionY.Text = "";
            txtSetHomePositionZ.Text = "";
            txtSetHomePositionO.Text = "";
            frmCommandSetHomePosition.Visible = false;

            // Set Facing (35)
            txtSetFacingOrientation.Text = "";
            cmbSetFacingMode.SelectedIndex = 0;
            frmCommandSetFacing.Visible = false;

            // Meeting Stone (36)
            btnMeetingStoneAreaId.Text = "-NONE-";
            frmCommandMeetingStone.Visible = false;

            // Set Data (37 and 38)
            cmbSetDataMode.SelectedIndex = 0;
            txtSetDataField.Text = "";
            txtSetDataValue.Text = "";
            frmCommandSetData.Visible = false;

            // Start Script (39)
            // Start Script on Group (90)
            txtStartScriptId1.Text = "";
            txtStartScriptId2.Text = "";
            txtStartScriptId3.Text = "";
            txtStartScriptId4.Text = "";
            txtStartScriptChance1.Text = "";
            txtStartScriptChance2.Text = "";
            txtStartScriptChance3.Text = "";
            txtStartScriptChance4.Text = "";
            frmCommandStartScript.Visible = false;

            // Set AI Phase (44)
            // Deal Damage (48)
            // Set Invincibility HP (52)
            // End Scripted Map Event (62)
            txtSetPhasePhase.Text = "";
            cmbSetPhaseMode.SelectedIndex = 0;
            frmCommandSetPhase.Visible = false;

            // Despawn Creature (18)
            // Set Random AI Phase (45)
            // Set Range AI Phase (46)
            // Set Server Variable (54)
            // Set Gossip Menu (84)
            // Send AI Event (85)
            txtSetRandomPhase1.Text = "";
            txtSetRandomPhase2.Text = "";
            txtSetRandomPhase3.Text = "";
            txtSetRandomPhase4.Text = "";
            frmCommandSetRandomPhase.Visible = false;

            // Flee (47)
            // Combat Pulse (49)
            // Set Sheath State (51)
            // Respawn Creature (71)
            // Set GO State (80)
            // Set Command State (88)
            cmbFleeMode.SelectedIndex = 0;
            frmCommandFlee.Visible = false;

            // Call for Help (50)
            txtCallForHelpRadius.Text = "";
            frmCommandCallForHelp.Visible = false;

            // Start Game Event (53)
            btnGameEventId.Text = "-NONE-";
            cmbGameEventAction.SelectedIndex = 0;
            cmbGameEventOverwrite.SelectedIndex = 0;
            frmCommandGameEvent.Visible = false;

            // Set Creature Spells Template (55)
            btnSetSpellsList1.Text = "-NONE-";
            btnSetSpellsList2.Text = "-NONE-";
            btnSetSpellsList3.Text = "-NONE-";
            btnSetSpellsList4.Text = "-NONE-";
            txtSetSpellsListChance1.Text = "";
            txtSetSpellsListChance2.Text = "";
            txtSetSpellsListChance3.Text = "";
            txtSetSpellsListChance4.Text = "";
            frmCommandSetSpellsList.Visible = false;

            // Add Spell Cooldown (57)
            // Remove Spell Cooldown (58)
            btnSpellCooldownId.Text = "-NONE-";
            txtSpellCooldownSeconds.Text = "";
            frmCommandSpellCooldown.Visible = false;

            // Set React State (59)
            cmbSetReactState.SelectedIndex = 0;
            frmCommandSetReactState.Visible = false;

            // Start Waypoints (60)
            cmbStartWaypointsRepeat.SelectedIndex = 0;
            cmbStartWaypointsSource.SelectedIndex = 0;
            txtStartWaypointsStartPoint.Text = "";
            txtStartWaypointsInitialDelay.Text = "";
            txtStartWaypointsGuid.Text = "";
            txtStartWaypointsEntry.Text = "";
            frmCommandStartWaypoints.Visible = false;

            // Start Scripted Map Event (61)
            // Add Scripted Map Event Target (63)
            txtStartScriptedMapEventFailureScript.Text = "";
            txtStartScriptedMapEventSuccessScript.Text = "";
            txtStartScriptedMapEventId.Text = "";
            txtStartScriptedMapEventTimeLimit.Text = "";
            btnStartScriptedMapEventFailureCondition.Text = "-NONE-";
            btnStartScriptedMapEventSuccessCondition.Text = "-NONE-";
            frmCommandStartScriptedMapEvent.Visible = false;

            // Remove Scripted Map Event Target (64)
            btnRemoveScriptedMapEventTargetCondition.Text = "-NONE-";
            txtRemoveScriptedMapEventTargetEventId.Text = "";
            cmbRemoveScriptedMapEventTarget.SelectedIndex = 0;
            frmCommandRemoveScriptedMapEventTarget.Visible = false;

            // Set Scripted Map Event Data (65)
            // Send Scripted Map Event (66)
            // Edit Scripted Map Event (69)
            txtSetScriptedMapEventData.Text = "";
            txtSetScriptedMapEventDataEventId.Text = "";
            txtSetScriptedMapEventDataIndex.Text = "";
            cmbSetScriptedMapEventDataMode.SelectedIndex = 0;
            frmCommandSetScriptedMapEventData.Visible = false;

            // Set Default Movement (67)
            cmbSetDefaultMovementType.SelectedIndex = 0;
            cmbSetDefaultMovementAlwaysReplace.SelectedIndex = 0;
            txtSetDefaultMovementParam1.Text = "";
            frmCommandSetDefaultMovement.Visible = false;

            // Start Script For All (68)
            txtStartScriptForAllScriptId.Text = "";
            cmbStartScriptForAllObjectType.SelectedIndex = 0;
            btnStartScriptForAllObjectEntry.Text = "-NONE-";
            txtStartScriptForAllDistance.Text = "";
            frmCommandStartScriptForAll.Visible = false;

            // Summon Object (76)
            btnSummonObjectId.Text = "-NONE-";
            txtSummonObjectRespawnTime.Text = "";
            txtSummonObjectX.Text = "";
            txtSummonObjectY.Text = "";
            txtSummonObjectZ.Text = "";
            txtSummonObjectO.Text = "";
            frmCommandSummonObject.Visible = false;

            // Join Creature Group (78)
            txtJoinCreatureGroupDistance.Text = "";
            txtJoinCreatureGroupAngle.Text = "";
            chkJoinCreatureGroup1.Checked = false;
            chkJoinCreatureGroup2.Checked = false;
            chkJoinCreatureGroup4.Checked = false;
            chkJoinCreatureGroup8.Checked = false;
            chkJoinCreatureGroup16.Checked = false;
            chkJoinCreatureGroup32.Checked = false;
            chkJoinCreatureGroup64.Checked = false;
            chkJoinCreatureGroup128.Checked = false;
            frmCommandJoinCreatureGroup.Visible = false;

            dontUpdate = false;
        }
        private void ShowCommandSpecificForm(ScriptAction selectedAction)
        {
            dontUpdate = true;
            switch (selectedAction.Command)
            {
                case 0: // Talk
                {
                    cmbTalkChatType.SelectedIndex = (int)selectedAction.Datalong;
                    uint textId1 = (uint)selectedAction.Dataint;
                    uint textId2 = (uint)selectedAction.Dataint2;
                    uint textId3 = (uint)selectedAction.Dataint3;
                    uint textId4 = (uint)selectedAction.Dataint4;
                    if (textId1 > 0)
                    {
                        txtTalkText1.Text = GameData.FindTextWithId(textId1);
                        btnTalkText1.Text = textId1.ToString();
                    }
                    else
                    {
                        txtTalkText1.Text = "";
                        btnTalkText1.Text = "-NONE-";
                    }
                    if (textId2 > 0)
                    {
                        txtTalkText2.Text = GameData.FindTextWithId(textId2);
                        btnTalkText2.Text = textId2.ToString();
                    }
                    else
                    {
                        txtTalkText2.Text = "";
                        btnTalkText2.Text = "-NONE-";
                    }
                    if (textId3 > 0)
                    {
                        txtTalkText3.Text = GameData.FindTextWithId(textId3);
                        btnTalkText3.Text = textId3.ToString();
                    }
                    else
                    {
                        txtTalkText3.Text = "";
                        btnTalkText3.Text = "-NONE-";
                    }
                    if (textId4 > 0)
                    {
                        txtTalkText4.Text = GameData.FindTextWithId(textId4);
                        btnTalkText4.Text = textId4.ToString();
                    }
                    else
                    {
                        txtTalkText4.Text = "";
                        btnTalkText4.Text = "-NONE-";
                    }
                    frmCommandTalk.Visible = true;
                    break;
                }
                case 1: // Emote
                {
                    cmbEmoteId.SelectedIndex = GameData.FindIndexOfEmote(selectedAction.Datalong);
                    cmbEmoteId2.SelectedIndex = GameData.FindIndexOfEmote(selectedAction.Datalong2);
                    cmbEmoteId3.SelectedIndex = GameData.FindIndexOfEmote(selectedAction.Datalong3);
                    cmbEmoteId4.SelectedIndex = GameData.FindIndexOfEmote(selectedAction.Datalong4);
                    cmbEmoteTargeted.SelectedIndex = selectedAction.Dataint;
                    frmCommandEmote.Visible = true;
                    break;
                }
                case 2: // Field Set
                {
                    txtFieldSetValue.Text = selectedAction.Datalong2.ToString();
                    cmbFieldSetFields.SelectedIndex = GameData.FindIndexOfUpdateField(selectedAction.Datalong);
                    frmCommandFieldSet.Visible = true;
                    break;
                }
                case 3: // Move To
                {
                    cmbMoveToType.SelectedIndex = (int)selectedAction.Datalong;
                    OnMoveCommandTypeChanged(selectedAction, selectedAction.Datalong);
                    txtMoveToTime.Text = selectedAction.Datalong2.ToString();

                    // coordinates
                    txtMoveToX.Text = selectedAction.X.ToString();
                    txtMoveToY.Text = selectedAction.Y.ToString();
                    txtMoveToZ.Text = selectedAction.Z.ToString();
                    txtMoveToO.Text = selectedAction.O.ToString();

                    // movement options
                    if ((selectedAction.Datalong3 & 1) != 0)
                        chkMoveOptions1.Checked = true;
                    if ((selectedAction.Datalong3 & 2) != 0)
                        chkMoveOptions2.Checked = true;
                    if ((selectedAction.Datalong3 & 4) != 0)
                        chkMoveOptions4.Checked = true;
                    if ((selectedAction.Datalong3 & 8) != 0)
                        chkMoveOptions8.Checked = true;
                    if ((selectedAction.Datalong3 & 16) != 0)
                        chkMoveOptions16.Checked = true;
                    if ((selectedAction.Datalong3 & 32) != 0)
                        chkMoveOptions32.Checked = true;
                    if ((selectedAction.Datalong3 & 64) != 0)
                        chkMoveOptions64.Checked = true;
                    if ((selectedAction.Datalong3 & 128) != 0)
                        chkMoveOptions128.Checked = true;
                    if ((selectedAction.Datalong3 & 256) != 0)
                        chkMoveOptions256.Checked = true;

                    // Force Movement Flag
                    if ((selectedAction.Datalong4 & 1) != 0)
                        chkMoveToFlagsForce.Checked = true;

                    // Use Point Movement Flag
                    if ((selectedAction.Datalong4 & 2) != 0)
                    {
                        txtMoveToPointId.Text = selectedAction.Dataint.ToString();
                        txtMoveToPointId.Enabled = true;
                        chkMoveToFlagsPointMovement.Checked = true;
                    }
                    else
                    {
                        txtMoveToPointId.Enabled = false;
                    }

                    frmCommandMoveTo.Visible = true;
                    break;
                }
                case 4: // Modify Flags
                {
                    cmbModifyFlagsFieldId.SelectedIndex = GameData.FindIndexOfFlagsField(selectedAction.Datalong);
                    cmbModifyFlagsMode.SelectedIndex = (int)selectedAction.Datalong3;
                    List<Tuple<string, uint>> valuesList = GetValuesListFromModifyFlagsComboBox();
                    if (valuesList != null && selectedAction.Datalong2 != 0)
                        btnModifyFlagsFlags.Text = Helpers.GetStringFromFlags(selectedAction.Datalong2, valuesList);
                    frmCommandModifyFlags.Visible = true;
                    break;
                }
                case 5: // Interrupt Casts
                {
                    uint spellId = selectedAction.Datalong2;
                    if (spellId > 0)
                        btnInterruptCastsSpellId.Text = GameData.FindSpellName(spellId) + " (" + spellId.ToString() + ")";
                    cmbInterruptCastsWithDelayed.SelectedIndex = (int)selectedAction.Datalong;
                    frmCommandInterruptCasts.Visible = true;
                    break;
                }
                case 6: // Teleport
                {
                    txtTeleportX.Text = selectedAction.X.ToString();
                    txtTeleportY.Text = selectedAction.Y.ToString();
                    txtTeleportZ.Text = selectedAction.Z.ToString();
                    txtTeleportO.Text = selectedAction.O.ToString();
                    cmbTeleportMap.SelectedIndex = GameData.FindIndexOfMap(selectedAction.Datalong);
                    if ((selectedAction.Datalong2 & 1) != 0)
                        chkTeleportOptions1.Checked = true;
                    if ((selectedAction.Datalong2 & 2) != 0)
                        chkTeleportOptions2.Checked = true;
                    if ((selectedAction.Datalong2 & 4) != 0)
                        chkTeleportOptions4.Checked = true;
                    if ((selectedAction.Datalong2 & 8) != 0)
                        chkTeleportOptions8.Checked = true;
                    if ((selectedAction.Datalong2 & 16) != 0)
                        chkTeleportOptions16.Checked = true;
                    if ((selectedAction.Datalong2 & 32) != 0)
                        chkTeleportOptions32.Checked = true;
                    frmCommandTeleport.Visible = true;
                    break;
                }
                case 7: // Complete Quest
                case 70: // Fail Quest
                {
                    uint questId = selectedAction.Datalong;
                    if (questId > 0)
                        btnQuestCompleteId.Text = GameData.FindQuestTitle(questId) + " (" + questId.ToString() + ")";
                    switch (selectedAction.Command)
                    {
                        case 7: // Complete Quest
                        {
                            lblQuestCompleteTooltip.Text = "Completes the specified quest for the target or source Player. If a maximum distance is provided, but the player is out of range, the quest will be marked as failed instead.";
                            txtQuestCompleteDistance.Text = selectedAction.Datalong2.ToString();
                            lblQuestCompleteDistance.Visible = true;
                            txtQuestCompleteDistance.Visible = true;
                            cmbQuestCompleteGroup.SelectedIndex = (int)selectedAction.Datalong3;
                            cmbQuestCompleteGroup.Visible = true;
                            lblQuestCompleteGroup.Visible = true;
                            break;
                        }
                        case 70: // Fail Quest
                        {
                            lblQuestCompleteTooltip.Text = "Fails the specified quest for the target or source Player and his group.";
                            txtQuestCompleteDistance.Visible = false;
                            lblQuestCompleteDistance.Visible = false;
                            lblQuestCompleteGroup.Visible = false;
                            cmbQuestCompleteGroup.Visible = false;
                            break;
                        }
                    }
                    frmCommandQuestComplete.Visible = true;
                    break;
                }
                case 8: // Kill Credit
                {
                    uint creatureId = selectedAction.Datalong;
                    if (creatureId > 0)
                        btnKillCreditCreatureId.Text = GameData.FindCreatureName(creatureId) + " (" + creatureId.ToString() + ")";
                    cmbKillCreditType.SelectedIndex = (int)selectedAction.Datalong2;
                    frmCommandKillCredit.Visible = true;
                    break;
                }
                case 9: // Respawn GameObject
                case 81: // Despawn GameObject
                case 82: // Load GameObject
                {
                    switch (selectedAction.Command)
                    {
                        case 9: // Respawn GameObject
                        {
                            lblRespawnGameobjectTooltip.Text = "Respawns the GameObject with the specified GUID, and then despawns it again when the delay expires.";
                            txtRespawnGameobjectDelay.Visible = true;
                            lblRespawnGameobjectDelay.Visible = true;
                            break;
                        }
                        case 81: // Despawn GameObject
                        {
                            lblRespawnGameobjectTooltip.Text = "Despawns the GameObject with the specified GUID, and then respawns it again when the delay expires.";
                            txtRespawnGameobjectDelay.Visible = true;
                            lblRespawnGameobjectDelay.Visible = true;
                            break;
                        }
                        case 82: // Load GameObject
                        {
                            lblRespawnGameobjectTooltip.Text = "Adds the GameObject spawn with the specified GUID to the current map. Not to be confused with command 9 which spawns a GameObject that is already loaded.";
                            txtRespawnGameobjectDelay.Visible = false;
                            lblRespawnGameobjectDelay.Visible = false;
                            break;
                        }
                    }
                    txtRespawnGameobjectDelay.Text = selectedAction.Datalong2.ToString();
                    txtRespawnGameobjectGuid.Text = selectedAction.Datalong.ToString();
                    frmCommandRespawnGameobject.Visible = true;
                    break;
                }
                case 10: // Summon Creature
                {
                    uint creatureId = selectedAction.Datalong;
                    if (creatureId > 0)
                        btnSummonCreatureId.Text = GameData.FindCreatureName(creatureId) + " (" + creatureId.ToString() + ")";
                    txtSummonCreatureDelay.Text = selectedAction.Datalong2.ToString();
                    txtSummonCreatureUniqueLimit.Text = selectedAction.Datalong3.ToString();
                    txtSummonCreatureUniqueRange.Text = selectedAction.Datalong4.ToString();
                    txtSummonCreatureX.Text = selectedAction.X.ToString();
                    txtSummonCreatureY.Text = selectedAction.Y.ToString();
                    txtSummonCreatureZ.Text = selectedAction.Z.ToString();
                    txtSummonCreatureO.Text = selectedAction.O.ToString();
                    cmbSummonCreatureAttackTarget.SelectedIndex = ComboboxPair.GetIndexFromComboboxPairValue(cmbSummonCreatureAttackTarget, selectedAction.Dataint3);
                    cmbSummonCreatureDespawnType.SelectedIndex = ComboboxPair.GetIndexFromComboboxPairValue(cmbSummonCreatureDespawnType, selectedAction.Dataint4);
                    txtSummonCreatureScriptId.Text = selectedAction.Dataint2.ToString();

                    if ((selectedAction.Dataint & 1) != 0)
                        chkSummonCreatureFlags1.Checked = true;
                    if ((selectedAction.Dataint & 2) != 0)
                        chkSummonCreatureFlags2.Checked = true;
                    if ((selectedAction.Dataint & 4) != 0)
                        chkSummonCreatureFlags4.Checked = true;
                    if ((selectedAction.Dataint & 8) != 0)
                        chkSummonCreatureFlags8.Checked = true;
                    if (!chkSummonCreatureFlags4.Checked && !chkSummonCreatureFlags8.Checked)
                    {
                        txtSummonCreatureUniqueLimit.Enabled = false;
                        txtSummonCreatureUniqueRange.Enabled = false;
                    }
                    if ((selectedAction.Dataint & 16) != 0)
                        chkSummonCreatureFlags16.Checked = true;
                    frmCommandSummonCreature.Visible = true;
                    break;
                }
                case 11: // Open Door
                case 12: // Close Door
                {
                    txtDoorGuid.Text = selectedAction.Datalong.ToString();
                    txtDoorResetDelay.Text = selectedAction.Datalong2.ToString();
                    txtDoorGuid.Visible = true;
                    txtDoorResetDelay.Visible = true;
                    lblDoorGuid.Visible = true;
                    lblDoorResetDelay.Visible = true;
                    if (selectedAction.Command == 11)
                        lblDoorTooltip.Text = "Opens the specified door GameObject, then resets it back to its original state after the delay expires. If the provided target is a button, it gets toggled as well.";
                    else
                        lblDoorTooltip.Text = "Closes the specified door GameObject, then resets it back to its original state after the delay expires. If the provided target is a button, it gets toggled as well.";
                    frmCommandDoor.Visible = true;
                    break;
                }
                // These commands have no parameters, using the same form.
                case 13: // Activate object
                case 26: // Start Attack
                case 33: // Enter Evade Mode
                case 41: // Remove Object
                case 72: // Assist Unit
                case 73: // Combat Stop
                case 75: // Add Threat
                case 79: // Leave Creature Group
                case 83: // Quest Credit
                case 87: // Reset Door or Button
                {
                    txtDoorGuid.Visible = false;
                    txtDoorResetDelay.Visible = false;
                    lblDoorGuid.Visible = false;
                    lblDoorResetDelay.Visible = false;
                    switch (selectedAction.Command)
                    {
                        case 13:
                        {
                            lblDoorTooltip.Text = "The source GameObject is used by the provided Unit target. This command has no additional parameters.";
                            break;
                        }
                        case 26:
                        {
                            lblDoorTooltip.Text = "The source Creature begins attacking the target Unit. This command has no additional parameters.";
                            break;
                        }
                        case 33:
                        {
                            lblDoorTooltip.Text = "The source Creature enters evade mode, leaving combat and returning to it's home location. This command has no additional parameters.";
                            break;
                        }
                        case 41:
                        {
                            lblDoorTooltip.Text = "The source GameObject has its loot state changed to deactivated and is permanently removed from the map. It will not respawn again. This command has no additional parameters.";
                            break;
                        }
                        case 72:
                        {
                            lblDoorTooltip.Text = "The source Creature begins attacking the target Unit's attacker, but only if it does not already have a victim. This command has no additional parameters.";
                            break;
                        }
                        case 73:
                        {
                            lblDoorTooltip.Text = "The source Creature leaves combat without entering evade mode. This command has no additional parameters.";
                            break;
                        }
                        case 75:
                        {
                            lblDoorTooltip.Text = "The target Unit is added to the source Creature's threat list. This command has no additional parameters.";
                            break;
                        }
                        case 79:
                        {
                            lblDoorTooltip.Text = "The source Creature leaves its current group. If it is the leader of the group, then the group is disbanded. This command has no additional parameters.";
                            break;
                        }
                        case 83:
                        {
                            lblDoorTooltip.Text = "Gives the target or source Player quest credit for killing or using the target Object. This command has no additional parameters.";
                            break;
                        }
                        case 87:
                        {
                            lblDoorTooltip.Text = "Resets the state of the source GameObject. Only intended for doors and buttons. This command has no additional parameters.";
                            break;
                        }
                    }
                    frmCommandDoor.Visible = true;
                    break;
                }
                case 14: // Remove Aura
                case 74: // Add Aura
                {
                    uint spellId = selectedAction.Datalong;
                    if (spellId > 0)
                        btnRemoveAuraSpellId.Text = GameData.FindSpellName(spellId) + " (" + spellId.ToString() + ")";

                    switch (selectedAction.Command)
                    {
                        case 14: // Remove Aura
                        {
                            lblRemoveAuraTooltip.Text = "Removes any auras from the source Unit caused by the specified spell.";
                            grpAddAuraFlags.Visible = false;
                            break;
                        }
                        case 74: // Add Aura
                        {
                            lblRemoveAuraTooltip.Text = "Directly adds any auras applied by the specified spell to the source Unit.";
                            grpAddAuraFlags.Visible = true;
                            if ((selectedAction.Datalong2 & 1) != 0)
                                chkAddAuraFlag1.Checked = true;
                            if ((selectedAction.Datalong2 & 2) != 0)
                                chkAddAuraFlag2.Checked = true;
                            if ((selectedAction.Datalong2 & 4) != 0)
                                chkAddAuraFlag4.Checked = true;
                            if ((selectedAction.Datalong2 & 8) != 0)
                                chkAddAuraFlag8.Checked = true;
                            break;
                        }
                    }

                    frmCommandRemoveAura.Visible = true;
                    break;
                }
                case 15: // Cast Spell
                {
                    uint spellId = selectedAction.Datalong;
                    if (spellId > 0)
                        btnCastSpellId.Text = GameData.FindSpellName(spellId) + " (" + spellId.ToString() + ")";
                    if ((selectedAction.Datalong2 & 1) != 0)
                        chkCastSpellFlags1.Checked = true;
                    if ((selectedAction.Datalong2 & 2) != 0)
                        chkCastSpellFlags2.Checked = true;
                    if ((selectedAction.Datalong2 & 4) != 0)
                        chkCastSpellFlags4.Checked = true;
                    if ((selectedAction.Datalong2 & 16) != 0)
                        chkCastSpellFlags16.Checked = true;
                    if ((selectedAction.Datalong2 & 32) != 0)
                        chkCastSpellFlags32.Checked = true;
                    if ((selectedAction.Datalong2 & 64) != 0)
                        chkCastSpellFlags64.Checked = true;
                    if ((selectedAction.Datalong2 & 128) != 0)
                        chkCastSpellFlags128.Checked = true;
                    frmCommandCastSpell.Visible = true;
                    break;
                }
                case 16: // Play Sound
                {
                    uint soundId = selectedAction.Datalong;
                    if (soundId > 0)
                        btnPlaySoundId.Text = GameData.FindSoundName(soundId) + " (" + soundId.ToString() + ")";
                    if ((selectedAction.Datalong2 & 1) != 0)
                        chkPlaySoundFlags1.Checked = true;
                    if ((selectedAction.Datalong2 & 2) != 0)
                        chkPlaySoundFlags2.Checked = true;
                    if ((selectedAction.Datalong2 & 4) != 0)
                        chkPlaySoundFlags4.Checked = true;
                    frmCommandPlaySound.Visible = true;
                    break;
                }
                case 17: // Create Item
                case 40: // Delete Item
                {
                    uint itemId = selectedAction.Datalong;
                    if (itemId > 0)
                        btnCreateItemId.Text = GameData.FindItemName(itemId) + " (" + itemId.ToString() + ")";
                    txtCreateItemAmount.Text = selectedAction.Datalong2.ToString();
                    if (selectedAction.Command == 17)
                        lblCreateItemTooltip.Text = "Adds the specified item to the target or source Player\'s inventory.";
                    else
                        lblCreateItemTooltip.Text = "Removes the specified item from the target or source Player\'s inventory.";
                    frmCommandCreateItem.Visible = true;
                    break;
                }
                case 19: // Set Equipment
                {
                    int itemId1 = selectedAction.Dataint;
                    if (itemId1 > 0)
                        btnSetEquipmentMainHand.Text = GameData.FindItemName((uint)itemId1) + " (" + itemId1.ToString() + ")";
                    else if (itemId1 < 0)
                        btnSetEquipmentMainHand.Text = "-IGNORE-";

                    int itemId2 = selectedAction.Dataint2;
                    if (itemId2 > 0)
                        btnSetEquipmentOffHand.Text = GameData.FindItemName((uint)itemId2) + " (" + itemId2.ToString() + ")";
                    else if (itemId2 < 0)
                        btnSetEquipmentOffHand.Text = "-IGNORE-";

                    int itemId3 = selectedAction.Dataint3;
                    if (itemId3 > 0)
                        btnSetEquipmentRanged.Text = GameData.FindItemName((uint)itemId3) + " (" + itemId3.ToString() + ")";
                    else if (itemId3 < 0)
                        btnSetEquipmentRanged.Text = "-IGNORE-";

                    uint useDefault = selectedAction.Datalong;
                    cmbSetEquipmentUseDefault.SelectedIndex = (int)useDefault;

                    if (useDefault == 1)
                    {
                        btnSetEquipmentMainHand.Enabled = false;
                        btnSetEquipmentOffHand.Enabled = false;
                        btnSetEquipmentRanged.Enabled = false;
                    }
                    frmCommandSetEquipment.Visible = true;
                    break;
                }
                case 20: // Set Movement
                {
                    uint motionType = selectedAction.Datalong;
                    cmbSetMovementType.SelectedIndex = GameData.FindIndexOfMotionType(motionType);
                    switch (motionType)
                    {
                        case 0: // IDLE_MOTION_TYPE
                        {
                            cmbSetMovementClearMotionMaster.Enabled = true;
                            cmbSetMovementClearMotionMaster.SelectedIndex = (int)selectedAction.Datalong4;
                            break;
                        }
                        case 1: // RANDOM_MOTION_TYPE
                        {
                            cmbSetMovementBoolParam.Enabled = true;
                            cmbSetMovementBoolParam.SelectedIndex = (int)selectedAction.Datalong2;
                            lblSetMovementBoolParam.Text = "Current Position:";
                            txtSetMovementDistance.Enabled = true;
                            txtSetMovementDistance.Text = selectedAction.X.ToString();
                            cmbSetMovementClearMotionMaster.Enabled = true;
                            cmbSetMovementClearMotionMaster.SelectedIndex = (int)selectedAction.Datalong4;
                            break;
                        }
                        case 2: // WAYPOINT_MOTION_TYPE
                        {
                            cmbSetMovementBoolParam.Enabled = true;
                            cmbSetMovementBoolParam.SelectedIndex = (int)selectedAction.Datalong2;
                            lblSetMovementBoolParam.Text = "Repeat:";
                            lblSetMovementIntParam.Text = "Start Point:";
                            txtSetMovementIntParam.Enabled = true;
                            txtSetMovementIntParam.Text = selectedAction.Datalong3.ToString();
                            lblSetMovementIntParam.Text = "Start Point:";
                            cmbSetMovementClearMotionMaster.Enabled = true;
                            cmbSetMovementClearMotionMaster.SelectedIndex = (int)selectedAction.Datalong4;
                            break;
                        }
                        case 5: // CHASE_MOTION_TYPE
                        {
                            cmbSetMovementBoolParam.Enabled = true;
                            cmbSetMovementBoolParam.SelectedIndex = (int)selectedAction.Datalong2;
                            lblSetMovementBoolParam.Text = "Target Victim:";
                            txtSetMovementDistance.Enabled = true;
                            txtSetMovementDistance.Text = selectedAction.X.ToString();
                            txtSetMovementAngle.Enabled = true;
                            txtSetMovementAngle.Text = selectedAction.O.ToString();
                            break;
                        }
                        case 9: // FLEEING_MOTION_TYPE
                        {
                            cmbSetMovementBoolParam.Enabled = true;
                            cmbSetMovementBoolParam.SelectedIndex = (int)selectedAction.Datalong2;
                            lblSetMovementBoolParam.Text = "Target Victim:";
                            txtSetMovementIntParam.Enabled = true;
                            txtSetMovementIntParam.Text = selectedAction.Datalong3.ToString();
                            lblSetMovementIntParam.Text = "Time:";
                            break;
                        }
                        case 10: // DISTRACT_MOTION_TYPE
                        {
                            txtSetMovementIntParam.Enabled = true;
                            txtSetMovementIntParam.Text = selectedAction.Datalong3.ToString();
                            lblSetMovementIntParam.Text = "Time:";
                            break;
                        }
                        case 14: // FOLLOW_MOTION_TYPE
                        {
                            txtSetMovementDistance.Enabled = true;
                            txtSetMovementDistance.Text = selectedAction.X.ToString();
                            txtSetMovementAngle.Enabled = true;
                            txtSetMovementAngle.Text = selectedAction.O.ToString();
                            break;
                        }
                        case 17: // CHARGE_MOTION_TYPE
                        {
                            cmbSetMovementBoolParam.Enabled = true;
                            cmbSetMovementBoolParam.SelectedIndex = (int)selectedAction.Datalong2;
                            lblSetMovementBoolParam.Text = "Attack:";
                            txtSetMovementIntParam.Enabled = true;
                            txtSetMovementIntParam.Text = selectedAction.Datalong3.ToString();
                            lblSetMovementIntParam.Text = "Delay:";
                            break;
                        }
                        case 18: // DISTANCING_MOTION_TYPE
                        {
                            txtSetMovementDistance.Enabled = true;
                            txtSetMovementDistance.Text = selectedAction.X.ToString();
                            txtSetMovementIntParam.Enabled = true;
                            txtSetMovementIntParam.Text = selectedAction.Datalong3.ToString();
                            lblSetMovementIntParam.Text = "Min Mana %:";
                            break;
                        }
                    }
                    lblSetMovementBoolParam.Location = new Point(cmbSetMovementBoolParam.Location.X - lblSetMovementBoolParam.Size.Width - 4, lblSetMovementBoolParam.Location.Y);
                    lblSetMovementIntParam.Location = new Point(txtSetMovementIntParam.Location.X - lblSetMovementIntParam.Size.Width - 4, lblSetMovementIntParam.Location.Y);
                    frmCommandSetMovement.Visible = true;
                    break;
                }
                case 21: // Set Active Object
                case 42: // Set Melee Attack
                case 43: // Set Combat Movement
                case 77: // Set Fly
                case 86: // Set PvP
                {
                    switch (selectedAction.Command)
                    {
                        case 21: // Set Active Object
                        {
                            lblActiveObjectTooltip.Text = "Makes the source WorldObject into an Active Object. That means its always updated, even if there are no players around.";
                            break;
                        }
                        case 42: // Set Melee Attack
                        {
                            lblActiveObjectTooltip.Text = "Controls whether the source Creature will auto attack its target.";
                            break;
                        }
                        case 43: // Set Combat Movement
                        {
                            lblActiveObjectTooltip.Text = "Controls whether the source Creature will chase its target.";
                            break;
                        }
                        case 77: // Set Fly
                        {
                            lblActiveObjectTooltip.Text = "Makes the source Unit able to fly.";
                            break;
                        }
                        case 86: // Set PvP
                        {
                            lblActiveObjectTooltip.Text = "Flags the target or source Player for PvP combat.";
                            break;
                        }
                    }
                    cmbActiveObjectSetActive.SelectedIndex = (int)selectedAction.Datalong;
                    frmCommandActiveObject.Visible = true;
                    break;
                }
                case 22: // Set Faction
                {
                    uint factionId = selectedAction.Datalong;
                    if (factionId > 0)
                        btnSetFactionId.Text = GameData.FindFactionTemplateName(factionId) + " (" + factionId.ToString() + ")";
                    if ((selectedAction.Datalong2 & 1) != 0)
                        chkSetFactionFlag1.Checked = true;
                    if ((selectedAction.Datalong2 & 2) != 0)
                        chkSetFactionFlag2.Checked = true;
                    if ((selectedAction.Datalong2 & 4) != 0)
                        chkSetFactionFlag4.Checked = true;
                    frmCommandSetFaction.Visible = true;
                    break;
                }
                case 23: // Morph
                case 24: // Mount
                {
                    uint idType = selectedAction.Datalong2;
                    cmbMorphOrMountType.SelectedIndex = (int)idType;
                    uint id = selectedAction.Datalong;

                    if (id > 0)
                    {
                        if (idType == 0)
                            btnMorphOrMountId.Text = GameData.FindCreatureName(id) + " (" + id.ToString() + ")";
                        else
                            btnMorphOrMountId.Text = id.ToString();
                    }

                    if (selectedAction.Command == 23)
                    {
                        lblMorphOrMountTooltip.Text = "Sets the source Creature's display Id to the provided value. Select NONE to restore the Creature's original display Id.";
                        lblMorphOrMountPermanent.Visible = false;
                        cmbMorphOrMountPermanent.Visible = false;
                    }
                    else
                    {
                        lblMorphOrMountTooltip.Text = "The source Creature gets mounted to the provided creature or display Id. Select NONE to unmount.";
                        lblMorphOrMountPermanent.Visible = true;
                        cmbMorphOrMountPermanent.Visible = true;
                        cmbMorphOrMountPermanent.SelectedIndex = (int)selectedAction.Datalong3;
                    }

                    frmCommandMorphOrMount.Visible = true;
                    break;
                }
                case 25: // Set Run
                {
                    cmbSetRunMode.SelectedIndex = (int)selectedAction.Datalong;
                    frmCommandSetRun.Visible = true;
                    break;
                }
                case 27: // Update Entry
                case 56: // Remove Guardians
                {
                    switch (selectedAction.Command)
                    {
                        case 27: // Update Entry
                        {
                            lblUpdateEntryTooltip.Text = "Temporarily changes the source Creature\'s entry, but preserves the same AI.";
                            break;
                        }
                        case 56: // Remove Guardians
                        {
                            lblUpdateEntryTooltip.Text = "Unsummons all Guardian Pets with the given creature Id that are owned by the source Unit. If no creature Id is provided, it unsummons all of them.";
                            break;
                        }
                    }

                    uint creatureId = selectedAction.Datalong;
                    if (creatureId > 0)
                        btnUpdateEntryCreatureId.Text = GameData.FindCreatureName(creatureId) + " (" + creatureId.ToString() + ")";
                    frmCommandUpdateEntry.Visible = true;
                    break;
                }
                case 28: // Set Stand State
                {
                    cmbSetStandState.SelectedIndex = (int)selectedAction.Datalong;
                    frmCommandSetStandState.Visible = true;
                    break;
                }
                case 29: // Modify Threat
                {
                    cmbModifyThreatTarget.SelectedIndex = (int)selectedAction.Datalong;
                    txtModifyThreatPercent.Text = selectedAction.X.ToString();
                    frmCommandModifyThreat.Visible = true;
                    break;
                }
                case 30: // Send Taxi Path
                {
                    uint taxiPath = selectedAction.Datalong;
                    if (taxiPath > 0)
                    {
                        txtSendTaxiPath.Text = GameData.FindTaxiPathDestination(taxiPath);
                        btnSendTaxiPathId.Text = taxiPath.ToString();
                    }
                    frmCommandSendTaxiPath.Visible = true;
                    break;
                }
                case 31: // Terminate Script
                {
                    uint creatureId = selectedAction.Datalong;
                    if (creatureId > 0)
                        btnTerminateScriptCreatureId.Text = GameData.FindCreatureName(creatureId) + " (" + creatureId.ToString() + ")";
                    txtTerminateScriptSearchRadius.Text = selectedAction.Datalong2.ToString();
                    cmbTerminateScriptCondition.SelectedIndex = (int)selectedAction.Datalong3;
                    frmCommandTerminateScript.Visible = true;
                    break;
                }
                case 32: // Terminate Condition
                {
                    if (selectedAction.Datalong > 0)
                        btnTerminateConditionId.Text = selectedAction.Datalong.ToString();
                    uint questId = selectedAction.Datalong2;
                    if (questId > 0)
                        btnTerminateConditionQuest.Text = GameData.FindQuestTitle(questId) + " (" + questId.ToString() + ")";
                    cmbTerminateConditionRule.SelectedIndex = (int)selectedAction.Datalong3;
                    frmCommandTerminateCondition.Visible = true;
                    break;
                }
                case 34: // Set Home Position
                {
                    cmbSetHomePositionMode.SelectedIndex = (int)selectedAction.Datalong;
                    switch (selectedAction.Datalong)
                    {
                        case 0: // Use provided coordinates
                        {
                            txtSetHomePositionX.Text = selectedAction.X.ToString();
                            txtSetHomePositionX.Enabled = true;
                            txtSetHomePositionY.Text = selectedAction.Y.ToString();
                            txtSetHomePositionY.Enabled = true;
                            txtSetHomePositionZ.Text = selectedAction.Z.ToString();
                            txtSetHomePositionZ.Enabled = true;
                            txtSetHomePositionO.Text = selectedAction.O.ToString();
                            txtSetHomePositionO.Enabled = true;
                            break;
                        }
                        case 1: // Use current position
                        case 2: // Reset to Default
                        {
                            txtSetHomePositionX.Enabled = false;
                            txtSetHomePositionY.Enabled = false;
                            txtSetHomePositionZ.Enabled = false;
                            txtSetHomePositionO.Enabled = false;
                            break;
                        }
                    }
                    frmCommandSetHomePosition.Visible = true;
                    break;
                }
                case 35: // Set Facing
                {
                    cmbSetFacingMode.SelectedIndex = (int)selectedAction.Datalong;
                    if (selectedAction.Datalong == 0) // Face Target
                        txtSetFacingOrientation.Enabled = false;
                    else // Use orientation
                    {
                        txtSetFacingOrientation.Text = selectedAction.O.ToString();
                        txtSetFacingOrientation.Enabled = true;
                    }
                    frmCommandSetFacing.Visible = true;
                    break;
                }
                case 36: // Meeting Stone
                {
                    uint areaId = selectedAction.Datalong;
                    if (areaId > 0)
                        btnMeetingStoneAreaId.Text = GameData.FindAreaName(areaId) + " (" + areaId.ToString() + ")";
                    frmCommandMeetingStone.Visible = true;
                    break;
                }
                case 37: // Set Data
                case 38: // Set Data 64
                {
                    int selectedMode = (int)selectedAction.Datalong3;
                    if ((selectedAction.Command == 38) && (selectedMode == 1)) // Save Guid
                        txtSetDataValue.Enabled = false;
                    else
                    {
                        txtSetDataValue.Enabled = true;
                        txtSetDataValue.Text = selectedAction.Datalong2.ToString();
                    }
                    txtSetDataField.Text = selectedAction.Datalong.ToString();
                    if (selectedAction.Command == 37)
                        cmbSetDataMode.DataSource = CommandSetData_ComboOptions;
                    else
                        cmbSetDataMode.DataSource = CommandSetData64_ComboOptions;
                    cmbSetDataMode.SelectedIndex = selectedMode;
                    frmCommandSetData.Visible = true;
                    break;
                }
                case 39: // Start Script
                case 90: // Start Script on Group
                {
                    txtStartScriptId1.Text = selectedAction.Datalong.ToString();
                    txtStartScriptId2.Text = selectedAction.Datalong2.ToString();
                    txtStartScriptId3.Text = selectedAction.Datalong3.ToString();
                    txtStartScriptId4.Text = selectedAction.Datalong4.ToString();
                    txtStartScriptChance1.Text = selectedAction.Dataint.ToString();
                    txtStartScriptChance2.Text = selectedAction.Dataint2.ToString();
                    txtStartScriptChance3.Text = selectedAction.Dataint3.ToString();
                    txtStartScriptChance4.Text = selectedAction.Dataint4.ToString();
                    frmCommandStartScript.Visible = true;
                    break;
                }
                case 44: // Set AI Phase
                case 48: // Deal Damage
                case 52: // Set Invincibility HP
                case 62: // End Scripted Map Event
                {
                    switch (selectedAction.Command)
                    {
                        case 44: // Set AI Phase
                        {
                            lblSetPhaseTooltip.Text = "Changes the current AI phase of the source Creature. Can only be used on creatures with EventAI.";
                            lblSetPhasePhase.Text = "Phase:";
                            lblSetPhaseMode.Text = "Mode:";
                            cmbSetPhaseMode.DataSource = CommandSetPhase_ComboOptions;
                            break;
                        }
                        case 48: // Deal Damage
                        {
                            lblSetPhaseTooltip.Text = "The source Unit deals the specified amount of damage to the Unit target.";
                            lblSetPhasePhase.Text = "Damage:";
                            lblSetPhaseMode.Text = "Mode:";
                            cmbSetPhaseMode.DataSource = CommandDealDamage_ComboOptions;
                            break;
                        }
                        case 52: // Set Invincibility HP
                        {
                            lblSetPhaseTooltip.Text = "Makes the source Creature not take damage below the specified health level.";
                            lblSetPhasePhase.Text = "Health:";
                            lblSetPhaseMode.Text = "Mode:";
                            cmbSetPhaseMode.DataSource = CommandDealDamage_ComboOptions;
                            break;
                        }
                        case 62: // End Scripted Map Event
                        {
                            lblSetPhaseTooltip.Text = "Ends the scripted map event with the given Id.";
                            lblSetPhasePhase.Text = "Event Id:";
                            lblSetPhaseMode.Text = "Success:";
                            cmbSetPhaseMode.DataSource = CommandCombatPulse_ComboOptions;
                            break;
                        }
                    }
                    lblSetPhasePhase.Location = new Point(cmbSetPhaseMode.Location.X - lblSetPhasePhase.Size.Width - 4, lblSetPhasePhase.Location.Y);
                    lblSetPhaseMode.Location = new Point(cmbSetPhaseMode.Location.X - lblSetPhaseMode.Size.Width - 4, lblSetPhaseMode.Location.Y);
                    txtSetPhasePhase.Text = selectedAction.Datalong.ToString();
                    cmbSetPhaseMode.SelectedIndex = (int)selectedAction.Datalong2;
                    frmCommandSetPhase.Visible = true;
                    break;
                }
                case 18: // Despawn Creature
                case 45: // Set Random AI Phase
                case 46: // Set Range AI Phase
                case 54: // Set Server Variable
                case 84: // Set Gossip Menu
                case 85: // Send AI Event
                {
                    txtSetRandomPhase1.Text = selectedAction.Datalong.ToString();
                    txtSetRandomPhase2.Text = selectedAction.Datalong2.ToString();
                    txtSetRandomPhase3.Text = selectedAction.Datalong3.ToString();
                    txtSetRandomPhase4.Text = selectedAction.Datalong4.ToString();
                    switch (selectedAction.Command)
                    {
                        case 18: // Despawn Creature
                        {
                            lblSetRandomPhaseTooltip.Text = "Despawns the source Creature after the specified delay. Respawn delay starts ticking after despawning. Default respawn time is not permanently overriden.";
                            lblSetRandomPhase2.Visible = true;
                            lblSetRandomPhase3.Visible = false;
                            lblSetRandomPhase4.Visible = false;
                            txtSetRandomPhase2.Visible = true;
                            txtSetRandomPhase3.Visible = false;
                            txtSetRandomPhase4.Visible = false;
                            lblSetRandomPhase1.Text = "Despawn Ms:";
                            lblSetRandomPhase2.Text = "Respawn Secs:";
                            break;
                        }
                        case 45: // Set Random AI Phase
                        {
                            lblSetRandomPhaseTooltip.Text = "Randomly chooses one of the provided values and sets the Creature's AI phase to it. Can only be used on creatures with EventAI.";
                            lblSetRandomPhase2.Visible = true;
                            lblSetRandomPhase3.Visible = true;
                            lblSetRandomPhase4.Visible = true;
                            txtSetRandomPhase2.Visible = true;
                            txtSetRandomPhase3.Visible = true;
                            txtSetRandomPhase4.Visible = true;
                            lblSetRandomPhase1.Text = "Phase 1:";
                            lblSetRandomPhase2.Text = "Phase 2:";
                            break;
                        }
                        case 46: // Set Range AI Phase
                        {
                            lblSetRandomPhaseTooltip.Text = "Randomly chooses a value in the provided range and sets the Creature's AI phase to it. Can only be used on creatures with EventAI.";
                            lblSetRandomPhase2.Visible = true;
                            lblSetRandomPhase3.Visible = false;
                            lblSetRandomPhase4.Visible = false;
                            txtSetRandomPhase2.Visible = true;
                            txtSetRandomPhase3.Visible = false;
                            txtSetRandomPhase4.Visible = false;
                            lblSetRandomPhase1.Text = "Minimum:";
                            lblSetRandomPhase2.Text = "Maximum:";
                            break;
                        }
                        case 54: // Set Server Variable
                        {
                            lblSetRandomPhaseTooltip.Text = "Sets the chosen server variable to the provided value.";
                            lblSetRandomPhase2.Visible = true;
                            lblSetRandomPhase3.Visible = false;
                            lblSetRandomPhase4.Visible = false;
                            txtSetRandomPhase2.Visible = true;
                            txtSetRandomPhase3.Visible = false;
                            txtSetRandomPhase4.Visible = false;
                            lblSetRandomPhase1.Text = "Index:";
                            lblSetRandomPhase2.Text = "Value:";
                            break;
                        }
                        case 84: // Set Gossip Menu
                        {
                            lblSetRandomPhaseTooltip.Text = "Changes the source Creature's default gossip menu to the one specified.";
                            lblSetRandomPhase2.Visible = false;
                            lblSetRandomPhase3.Visible = false;
                            lblSetRandomPhase4.Visible = false;
                            txtSetRandomPhase2.Visible = false;
                            txtSetRandomPhase3.Visible = false;
                            txtSetRandomPhase4.Visible = false;
                            lblSetRandomPhase1.Text = "Menu:";
                            break;
                        }
                        case 85: // Send AI Event
                        {
                            lblSetRandomPhaseTooltip.Text = "Notifies the source Creature's AI that an event took place.";
                            lblSetRandomPhase2.Visible = true;
                            lblSetRandomPhase3.Visible = false;
                            lblSetRandomPhase4.Visible = false;
                            txtSetRandomPhase2.Visible = true;
                            txtSetRandomPhase3.Visible = false;
                            txtSetRandomPhase4.Visible = false;
                            lblSetRandomPhase1.Text = "Event Id:";
                            lblSetRandomPhase2.Text = "Data:";
                            break;
                        }
                    }
                    lblSetRandomPhase1.Location = new Point(txtSetRandomPhase1.Location.X - lblSetRandomPhase1.Size.Width - 4, lblSetRandomPhase1.Location.Y);
                    lblSetRandomPhase2.Location = new Point(txtSetRandomPhase2.Location.X - lblSetRandomPhase2.Size.Width - 4, lblSetRandomPhase2.Location.Y);
                    frmCommandSetRandomPhase.Visible = true;
                    break;
                }
                case 47: // Flee
                case 49: // Combat Pulse
                case 51: // Set Sheath State
                case 71: // Respawn Creature
                case 80: // Set GO State
                case 88: // Set Command State
                case 89: // Play Custom Anim
                {
                    switch (selectedAction.Command)
                    {
                        case 47: // Flee
                        {
                            lblFleeTooltip.Text = "The source Creature attempts to flee from the attacker.";
                            lblFleeMode.Text = "Mode:";
                            cmbFleeMode.DataSource = CommandFlee_ComboOptions;
                            break;
                        }
                        case 49: // Combat Pusle
                        {
                            lblFleeTooltip.Text = "Places all players within the instance into combat with the source Creature.";
                            lblFleeMode.Text = "Initial Pulse:";
                            cmbFleeMode.DataSource = CommandCombatPulse_ComboOptions;
                            break;
                        }
                        case 51: // Set Sheath State
                        {
                            lblFleeTooltip.Text = "Changes the source Unit's current sheath state.";
                            lblFleeMode.Text = "Sheath State:";
                            cmbFleeMode.DataSource = CommandSetSheathState_ComboOptions;
                            break;
                        }
                        case 71: // Respawn Creature
                        {
                            lblFleeTooltip.Text = "Respawns the source Creature.";
                            lblFleeMode.Text = "Even Alive:";
                            cmbFleeMode.DataSource = CommandCombatPulse_ComboOptions;
                            break;
                        }
                        case 80: // Set GO State
                        {
                            lblFleeTooltip.Text = "Changes the source GameObject's current state.";
                            lblFleeMode.Text = "State:";
                            cmbFleeMode.DataSource = CommandSetGOState_ComboOptions;
                            break;
                        }
                        case 88: // Set Command State
                        {
                            lblFleeTooltip.Text = "The source Creature is given a pet command. Only works on charmed units.";
                            lblFleeMode.Text = "State:";
                            cmbFleeMode.DataSource = CommandSetCommandState_ComboOptions;
                            break;
                        }
                        case 89: // Play Custom Anim
                        {
                            lblFleeTooltip.Text = "The source GameObject plays one of four possible animations tied to its model.";
                            lblFleeMode.Text = "Anim:";
                            cmbFleeMode.DataSource = CommandPlayCustomAnim_ComboOptions;
                            break;
                        }
                    }
                    lblFleeMode.Location = new Point(cmbFleeMode.Location.X - lblFleeMode.Size.Width - 4, lblFleeMode.Location.Y);
                    cmbFleeMode.SelectedIndex = (int)selectedAction.Datalong;
                    frmCommandFlee.Visible = true;
                    break;
                }
                case 50: // Call For Help
                {
                    txtCallForHelpRadius.Text = selectedAction.X.ToString();
                    frmCommandCallForHelp.Visible = true;
                    break;
                }
                case 53: // Start Game Event
                {
                    uint eventId = selectedAction.Datalong;
                    if (eventId > 0)
                        btnGameEventId.Text = GameData.FindEventName(eventId) + " (" + eventId.ToString() + ")";
                    cmbGameEventAction.SelectedIndex = (int)selectedAction.Datalong2;
                    cmbGameEventOverwrite.SelectedIndex = (int)selectedAction.Datalong3;
                    frmCommandGameEvent.Visible = true;
                    break;
                }
                case 55: // Set Creature Spells List
                {
                    uint template1 = selectedAction.Datalong;
                    if (template1 > 0)
                        btnSetSpellsList1.Text = GameData.FindCreatureSpellsListName(template1) + " (" + template1.ToString() + ")";
                    uint template2 = selectedAction.Datalong2;
                    if (template2 > 0)
                        btnSetSpellsList2.Text = GameData.FindCreatureSpellsListName(template2) + " (" + template2.ToString() + ")";
                    uint template3 = selectedAction.Datalong3;
                    if (template3 > 0)
                        btnSetSpellsList3.Text = GameData.FindCreatureSpellsListName(template3) + " (" + template3.ToString() + ")";
                    uint template4 = selectedAction.Datalong4;
                    if (template4 > 0)
                        btnSetSpellsList4.Text = GameData.FindCreatureSpellsListName(template4) + " (" + template4.ToString() + ")";
                    txtSetSpellsListChance1.Text = selectedAction.Dataint.ToString();
                    txtSetSpellsListChance2.Text = selectedAction.Dataint2.ToString();
                    txtSetSpellsListChance3.Text = selectedAction.Dataint3.ToString();
                    txtSetSpellsListChance4.Text = selectedAction.Dataint4.ToString();
                    frmCommandSetSpellsList.Visible = true;
                    break;
                }
                case 57: // Add Spell Cooldown
                case 58: // Remove Spell Cooldown
                {
                    switch (selectedAction.Command)
                    {
                        case 57: // Add Spell Cooldown
                        {
                            lblSpellCooldownTooltip.Text = "Adds a spell cooldown lasting a specified amount of time to the source Unit.";
                            lblSpellCooldownSeconds.Visible = true;
                            txtSpellCooldownSeconds.Visible = true;
                            break;
                        }
                        case 58: // Remove Spell Cooldown
                        {
                            lblSpellCooldownTooltip.Text = "Removes a spell cooldown from the source Unit. If not spell Id is provided, all spell cooldowns will be cleared.";
                            lblSpellCooldownSeconds.Visible = false;
                            txtSpellCooldownSeconds.Visible = false;
                            break;
                        }
                    }
                    uint spellId = selectedAction.Datalong;
                    if (spellId > 0)
                        btnSpellCooldownId.Text = GameData.FindSpellName(spellId) + " (" + spellId.ToString() + ")";
                    txtSpellCooldownSeconds.Text = selectedAction.Datalong2.ToString();
                    frmCommandSpellCooldown.Visible = true;
                    break;
                }
                case 59: // Set React State
                {
                    cmbSetReactState.SelectedIndex = (int)selectedAction.Datalong;
                    frmCommandSetReactState.Visible = true;
                    break;
                }
                case 60: // Start Waypoints
                {
                    cmbStartWaypointsRepeat.SelectedIndex = (int)selectedAction.Datalong4;
                    cmbStartWaypointsSource.SelectedIndex = (int)selectedAction.Datalong;
                    OnWaypointsSourceChanged();
                    txtStartWaypointsStartPoint.Text = selectedAction.Datalong2.ToString();
                    txtStartWaypointsInitialDelay.Text = selectedAction.Datalong3.ToString();
                    txtStartWaypointsGuid.Text = selectedAction.Dataint.ToString();
                    txtStartWaypointsEntry.Text = selectedAction.Dataint2.ToString();
                    frmCommandStartWaypoints.Visible = true;
                    break;
                }
                case 61: // Start Scripted Map Event
                case 63: // Add Scripted Map Event Target
                case 69: // Edit Scripted Map Event
                {
                    switch (selectedAction.Command)
                    {
                        case 61: // Start Scripted Map Event
                        {
                            lblStartScriptedMapEventTooltip.Text = "Starts a scripted map event with the given Id, targets, conditions and scripts.";
                            txtStartScriptedMapEventTimeLimit.Visible = true;
                            lblStartScriptedMapEventTimeLimit.Visible = true;
                            txtStartScriptedMapEventTimeLimit.Text = selectedAction.Datalong2.ToString();
                            break;
                        }
                        case 63: // Add Scripted Map Event Target
                        {
                            lblStartScriptedMapEventTooltip.Text = "Adds the source WorldObject to the additional targets vector of the scripted map event with the given Id. The conditions will use the script source as target.";
                            txtStartScriptedMapEventTimeLimit.Visible = false;
                            lblStartScriptedMapEventTimeLimit.Visible = false;
                            break;
                        }
                        case 69: // Edit Scripted Map Event
                        {
                            lblStartScriptedMapEventTooltip.Text = "Changes the condition and script Ids used by the scripted map event with the given Id. Fields with a negative value will not be changed.";
                            txtStartScriptedMapEventTimeLimit.Visible = false;
                            lblStartScriptedMapEventTimeLimit.Visible = false;
                            break;
                        }
                    }

                    txtStartScriptedMapEventFailureScript.Text = selectedAction.Dataint4.ToString();
                    txtStartScriptedMapEventSuccessScript.Text = selectedAction.Dataint2.ToString();
                    txtStartScriptedMapEventId.Text = selectedAction.Datalong.ToString();
                    if (selectedAction.Dataint3 > 0)
                        btnStartScriptedMapEventFailureCondition.Text = selectedAction.Dataint3.ToString();
                    else if (selectedAction.Dataint3 < 0)
                        btnStartScriptedMapEventFailureCondition.Text = "-IGNORE";
                    if (selectedAction.Dataint > 0)
                        btnStartScriptedMapEventSuccessCondition.Text = selectedAction.Dataint.ToString();
                    else if (selectedAction.Dataint < 0)
                        btnStartScriptedMapEventSuccessCondition.Text = "-IGNORE";
                    frmCommandStartScriptedMapEvent.Visible = true;
                    break;
                }
                case 64: // Remove Scripted Map Event Target
                {
                    if (selectedAction.Datalong2 > 0)
                        btnRemoveScriptedMapEventTargetCondition.Text = selectedAction.Datalong2.ToString();
                    txtRemoveScriptedMapEventTargetEventId.Text = selectedAction.Datalong.ToString();
                    cmbRemoveScriptedMapEventTarget.SelectedIndex = (int)selectedAction.Datalong3;
                    frmCommandRemoveScriptedMapEventTarget.Visible = true;
                    break;
                }
                case 65: // Set Scripted Map Event Data
                case 66: // Send Scripted Map Event
                {
                    if (selectedAction.Command == 65)
                    {
                        lblSetScriptedMapEventDataTooltip.Text = "Saves data to the scripted map event with the given Id.";
                        txtSetScriptedMapEventData.Text = selectedAction.Datalong3.ToString();
                        cmbSetScriptedMapEventDataMode.DataSource = CommandSetData_ComboOptions;
                        cmbSetScriptedMapEventDataMode.SelectedIndex = (int)selectedAction.Datalong4;
                        lblSetScriptedMapEventDataIndex.Text = "Index:";
                        lblSetScriptedMapEventDataMode.Text = "Mode:";
                        lblSetScriptedMapEventData.Visible = true;
                        txtSetScriptedMapEventData.Visible = true;
                    }
                    else
                    {
                        lblSetScriptedMapEventDataTooltip.Text = "Informs the AI of any Creature targets in the scripted map event with the given Id that something important has happened.";
                        cmbSetScriptedMapEventDataMode.DataSource = CommandSendScriptedMapEvent_ComboOptions;
                        cmbSetScriptedMapEventDataMode.SelectedIndex = (int)selectedAction.Datalong3;
                        lblSetScriptedMapEventDataIndex.Text = "Data:";
                        lblSetScriptedMapEventDataMode.Text = "Targets:";
                        lblSetScriptedMapEventData.Visible = false;
                        txtSetScriptedMapEventData.Visible = false;
                    }
                    lblSetScriptedMapEventDataIndex.Location = new Point(txtSetScriptedMapEventDataIndex.Location.X - lblSetScriptedMapEventDataIndex.Size.Width - 4, lblSetScriptedMapEventDataIndex.Location.Y);
                    lblSetScriptedMapEventDataMode.Location = new Point(cmbSetScriptedMapEventDataMode.Location.X - lblSetScriptedMapEventDataMode.Size.Width - 4, lblSetScriptedMapEventDataMode.Location.Y);
                    txtSetScriptedMapEventDataEventId.Text = selectedAction.Datalong.ToString();
                    txtSetScriptedMapEventDataIndex.Text = selectedAction.Datalong2.ToString();
                    frmCommandSetScriptedMapEventData.Visible = true;
                    break;
                }
                case 67: // Set Default Movement
                {
                    switch (selectedAction.Datalong)
                    {
                        case 0: // Idle Movement
                        {
                            lblSetDefaultMovementParam1.Text = "Param 1:";
                            txtSetDefaultMovementParam1.Enabled = false;
                            break;
                        }
                        case 1: // Random Movement
                        {
                            lblSetDefaultMovementParam1.Text = "Distance:";
                            txtSetDefaultMovementParam1.Enabled = true;
                            break;
                        }
                        case 2: // Waypoint Movement
                        {
                            lblSetDefaultMovementParam1.Text = "Start Point:";
                            txtSetDefaultMovementParam1.Enabled = true;
                            break;
                        }
                    }
                    cmbSetDefaultMovementType.SelectedIndex = (int)selectedAction.Datalong;
                    cmbSetDefaultMovementAlwaysReplace.SelectedIndex = (int)selectedAction.Datalong2;
                    txtSetDefaultMovementParam1.Text = selectedAction.Datalong3.ToString();
                    lblSetDefaultMovementParam1.Location = new Point(txtSetDefaultMovementParam1.Location.X - lblSetDefaultMovementParam1.Size.Width - 4, lblSetDefaultMovementParam1.Location.Y);
                    frmCommandSetDefaultMovement.Visible = true;
                    break;
                }
                case 68: // Start Script For All
                {
                    txtStartScriptForAllScriptId.Text = selectedAction.Datalong.ToString();
                    cmbStartScriptForAllObjectType.SelectedIndex = (int)selectedAction.Datalong2;
                    switch (selectedAction.Datalong2)
                    {
                        case 0: // GameObject
                        {
                            btnStartScriptForAllObjectEntry.Enabled = true;
                            uint objectId = selectedAction.Datalong3;
                            if (objectId > 0)
                                btnStartScriptForAllObjectEntry.Text = GameData.FindGameObjectName(objectId) + " (" + objectId.ToString() + ")";
                            break;
                        }
                        case 2: // Creature
                        {
                            btnStartScriptForAllObjectEntry.Enabled = true;
                            uint creatureId = selectedAction.Datalong3;
                            if (creatureId > 0)
                                btnStartScriptForAllObjectEntry.Text = GameData.FindCreatureName(creatureId) + " (" + creatureId.ToString() + ")";
                            break;
                        }
                        default:
                        {
                            btnStartScriptForAllObjectEntry.Enabled = false;
                            break;
                        }
                    }
                    txtStartScriptForAllDistance.Text = selectedAction.Datalong4.ToString();
                    frmCommandStartScriptForAll.Visible = true;
                    break;
                }
                case 76: // Summon Object
                {
                    uint objectId = selectedAction.Datalong;
                    if (objectId > 0)
                        btnSummonObjectId.Text = GameData.FindGameObjectName(objectId) + " (" + objectId.ToString() + ")";
                    txtSummonObjectRespawnTime.Text = selectedAction.Datalong2.ToString();
                    txtSummonObjectX.Text = selectedAction.X.ToString();
                    txtSummonObjectY.Text = selectedAction.Y.ToString();
                    txtSummonObjectZ.Text = selectedAction.Z.ToString();
                    txtSummonObjectO.Text = selectedAction.O.ToString();
                    frmCommandSummonObject.Visible = true;
                    break;
                }
                case 78: // Join Creature Group
                {
                    if ((selectedAction.Datalong & 1) != 0)
                        chkJoinCreatureGroup1.Checked = true;
                    if ((selectedAction.Datalong & 2) != 0)
                        chkJoinCreatureGroup2.Checked = true;
                    if ((selectedAction.Datalong & 4) != 0)
                        chkJoinCreatureGroup4.Checked = true;
                    if ((selectedAction.Datalong & 8) != 0)
                        chkJoinCreatureGroup8.Checked = true;
                    if ((selectedAction.Datalong & 16) != 0)
                        chkJoinCreatureGroup16.Checked = true;
                    if ((selectedAction.Datalong & 32) != 0)
                        chkJoinCreatureGroup32.Checked = true;
                    if ((selectedAction.Datalong & 64) != 0)
                        chkJoinCreatureGroup64.Checked = true;
                    if ((selectedAction.Datalong & 128) != 0)
                        chkJoinCreatureGroup128.Checked = true;
                    txtJoinCreatureGroupDistance.Text = selectedAction.X.ToString();
                    txtJoinCreatureGroupAngle.Text = selectedAction.O.ToString();
                    frmCommandJoinCreatureGroup.Visible = true;
                    break;
                }
                default: // Unsupported command
                {
                    txtUnknownCommandDatalong1.Text = selectedAction.Datalong.ToString();
                    txtUnknownCommandDatalong2.Text = selectedAction.Datalong2.ToString();
                    txtUnknownCommandDatalong3.Text = selectedAction.Datalong3.ToString();
                    txtUnknownCommandDatalong4.Text = selectedAction.Datalong4.ToString();
                    txtUnknownCommandDataint1.Text = selectedAction.Dataint.ToString();
                    txtUnknownCommandDataint2.Text = selectedAction.Dataint2.ToString();
                    txtUnknownCommandDataint3.Text = selectedAction.Dataint3.ToString();
                    txtUnknownCommandDataint4.Text = selectedAction.Dataint4.ToString();
                    txtUnknownCommandX.Text = selectedAction.X.ToString();
                    txtUnknownCommandY.Text = selectedAction.Y.ToString();
                    txtUnknownCommandZ.Text = selectedAction.Z.ToString();
                    txtUnknownCommandO.Text = selectedAction.O.ToString();
                    frmCommandUnknown.Visible = true;
                    break;
                }
            }
            dontUpdate = false;
        }
        private void lstActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstActions.SelectedItems.Count == 0)
            {
                ResetAndDisableGeneralForm();
                ResetAndHideCommandSpecificForms();
                return;
            }

            dontUpdate = true;
            ListViewItem selectedItem = lstActions.SelectedItems[0];
            ScriptAction selectedAction = (ScriptAction)selectedItem.Tag;
            
            txtCommandDelay.Text = selectedAction.Delay.ToString();
            txtCommandPriority.Text = selectedAction.Priority.ToString();
            txtCommandComment.Text = selectedAction.Comments;
            txtTargetParam1.Text = selectedAction.TargetParam1.ToString();
            txtTargetParam2.Text = selectedAction.TargetParam2.ToString();
            cmbTargetType.SelectedIndex = (int)selectedAction.TargetType;

            if (selectedAction.TargetParam1 != 0)
                btnTargetParam1.Text = selectedAction.TargetParam1.ToString();
            else
                btnTargetParam1.Text = "-NONE-";

            if (selectedAction.Command < CommandTypeNames.GetLength(0))
                cmbCommandId.SelectedIndex = (int)selectedAction.Command;
            else
                cmbCommandId.SelectedIndex = -1;

            if (selectedAction.ConditionId > 0)
                btnCommandCondition.Text = selectedAction.ConditionId.ToString();

            if ((selectedAction.DataFlags & 1) != 0)
                chkSwapInitial.Checked = true;
            if ((selectedAction.DataFlags & 2) != 0)
                chkSwapFinal.Checked = true;
            if ((selectedAction.DataFlags & 4) != 0)
                chkTargetSelf.Checked = true;
            if ((selectedAction.DataFlags & 8) != 0)
                chkAbortScript.Checked = true;
            if ((selectedAction.DataFlags & 16) != 0)
                chkSkipMissingTargets.Checked = true;

            if (Program.highlight)
            {
                if (selectedAction.Delay != 0)
                    lblDelay.BackColor = Color.FromKnownColor(KnownColor.Gold);
                if (selectedAction.TargetParam1 != 0)
                    lblTargetParam1.BackColor = Color.FromKnownColor(KnownColor.Gold);
                if (selectedAction.TargetParam2 != 0)
                    lblTargetParam2.BackColor = Color.FromKnownColor(KnownColor.Gold);
                if (selectedAction.TargetType != 0)
                    lblTargetType.BackColor = Color.FromKnownColor(KnownColor.Gold);
                if (selectedAction.ConditionId != 0)
                    lblCommandCondition.BackColor = Color.FromKnownColor(KnownColor.Gold);
            }

            grpGeneral.Enabled = true;

            ShowCommandSpecificForm(selectedAction);

            dontUpdate = false;
        }
        private void cmbCommandId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Updating command type.
                currentAction.Command = (uint)cmbCommandId.SelectedIndex;
                currentAction.Datalong = 0;
                currentAction.Datalong2 = 0;
                currentAction.Datalong3 = 0;
                currentAction.Datalong4 = 0;
                currentAction.Dataint = 0;
                currentAction.Dataint2 = 0;
                currentAction.Dataint3 = 0;
                currentAction.Dataint4 = 0;
                currentAction.X = 0;
                currentAction.Y = 0;
                currentAction.Z = 0;
                currentAction.O = 0;

                // Show the appropriate command specific form.
                ResetAndHideCommandSpecificForms();
                ShowCommandSpecificForm(currentAction);

                // Update command id in listview.
                currentItem.SubItems[1].Text = cmbCommandId.SelectedIndex.ToString();
            }
        }

        private void btnCommandCondition_Click(object sender, EventArgs e)
        {
            FormConditionFinder frm = new FormConditionFinder();
            if (frm.ShowDialog(GetScriptFieldValue<int>("ConditionId")) == System.Windows.Forms.DialogResult.OK)
            {
                int returnId = frm.ReturnValue;

                if (returnId > 0)
                    btnCommandCondition.Text = returnId.ToString();
                else
                    btnCommandCondition.Text = "-NONE-";

                SetScriptFieldFromValue(returnId, "ConditionId");
            }
        }

        private int GetSelectedCommandType()
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                return (int)currentAction.Command;
            }

            return -1;
        }

        // Generic function for setting script field to specified value;
        private void SetScriptFieldFromValue(double fieldvalue, string fieldname)
        {
            Helpers.SetScriptFieldFromValue<ScriptAction>(lstActions, fieldvalue, fieldname);
        }
        // Generic function for setting field value from a textbox.
        private void SetScriptFieldFromTextbox(TextBox ctrl, string fieldname)
        {
            if (dontUpdate)
                return;

            Helpers.SetScriptFieldFromTextbox<ScriptAction>(lstActions, ctrl, fieldname);
        }
        // Generic function for setting field value from a checkbox.
        private void SetScriptFieldFromCombobox(ComboBox cmbbox, string fieldname, bool usePairValue)
        {
            if (dontUpdate)
                return;

            Helpers.SetScriptFieldFromCombobox<ScriptAction>(lstActions, cmbbox, fieldname, usePairValue);
        }
        // Generic function for updating flags based on checkbox.
        private void SetScriptFlagsFromCheckbox(CheckBox chkbox, string fieldname, uint value)
        {
            if (dontUpdate)
                return;

            Helpers.SetScriptFlagsFromCheckbox<ScriptAction>(lstActions, chkbox, fieldname, value);
        }
        // Generic function for setting a value from another form.
        private void SetScriptFieldFromDataFinderForm<TFinderForm>(Button btn, TextBox txtbox, NameFinder finder, string fieldname) where TFinderForm : FormDataFinder, new()
        {
            Helpers.SetScriptFieldFromDataFinderForm<ScriptAction, TFinderForm>(lstActions, btn, txtbox, finder, fieldname);
        }
        private void SetScriptFieldFromFlagsForm(Button btn, List<Tuple<string, uint>> valuesList, string windowtitle, string fieldname)
        {
            Helpers.SetScriptFieldFromFlagsForm<ScriptAction>(lstActions, btn, valuesList, windowtitle, fieldname);
        }
        // Generic function for getting int value in field.
        private T GetScriptFieldValue<T>(string fieldname) where T : struct, IComparable<T>
        {
            return Helpers.GetScriptFieldValue<ScriptAction, T>(lstActions, fieldname);
        }
        private void txtCommandComment_Leave(object sender, EventArgs e)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Updating comment.
                currentAction.Comments = txtCommandComment.Text;

                // Update comment in listview.
                currentItem.SubItems[2].Text = txtCommandComment.Text;
            }
        }

        private void SetTargetControlsBasedOnType(int target_type)
        {
            btnTargetParam1.Visible = false;
            switch (target_type)
            {
                case 2: // Second Aggro
                case 3: // Last Aggro
                case 4: // Random
                case 5: // Random Not Top
                {
                    lblTargetParam1.Text = "Flags:";
                    lblTargetParam2.Text = "N/A:";
                    txtTargetParam1.Text = "";
                    txtTargetParam1.Enabled = false;
                    btnTargetParam1.Visible = true;
                    SetScriptFieldFromValue(0, "TargetParam2");
                    txtTargetParam2.Text = "";
                    txtTargetParam2.Enabled = false;
                    break;
                }
                case 0: // Provided Target
                case 1: // Current Victim
                case 6: // Owner or Self
                case 7: // Owner
                {
                    lblTargetParam1.Text = "N/A:";
                    lblTargetParam2.Text = "N/A:";
                    SetScriptFieldFromValue(0, "TargetParam1");
                    txtTargetParam1.Text = "";
                    txtTargetParam1.Enabled = false;
                    SetScriptFieldFromValue(0, "TargetParam2");
                    txtTargetParam2.Text = "";
                    txtTargetParam2.Enabled = false;
                    break;
                }
                case 8: // Nearest Creature with Entry
                case 11: // Nearest GameObject with Entry
                case 26: // Random Creature with Entry
                case 27: // Random GameObject with Entry
                {
                    
                    lblTargetParam1.Text = "Entry:";
                    lblTargetParam2.Text = "Radius:";
                    btnTargetParam1.Visible = true;
                    txtTargetParam1.Enabled = false;
                    txtTargetParam2.Enabled = true;
                    break;
                }
                case 9: // Creature GUID
                case 12: // GameObject Guid
                {
                    lblTargetParam1.Text = "GUID:";
                    lblTargetParam2.Text = "N/A:";
                    txtTargetParam1.Enabled = true;
                    txtTargetParam2.Enabled = false;
                    SetScriptFieldFromValue(0, "TargetParam2");
                    txtTargetParam2.Text = "";
                    break;
                }
                case 10: // Creature Instance Data
                case 13: // GameObject Instance Data
                {
                    lblTargetParam1.Text = "Index:";
                    lblTargetParam2.Text = "N/A:";
                    txtTargetParam1.Enabled = true;
                    txtTargetParam2.Enabled = false;
                    SetScriptFieldFromValue(0, "TargetParam2");
                    txtTargetParam2.Text = "";
                    break;
                }
                case 14: // Nearby Friendly
                {
                    lblTargetParam1.Text = "Radius:";
                    lblTargetParam2.Text = "Not Self:";
                    txtTargetParam1.Enabled = true;
                    txtTargetParam2.Enabled = true;
                    break;
                }
                case 15: // Injured Friendly
                case 16: // Injured Friendly Not Self
                {
                    lblTargetParam1.Text = "Radius:";
                    lblTargetParam2.Text = "HP %:";
                    txtTargetParam1.Enabled = true;
                    txtTargetParam2.Enabled = true;
                    break;
                }
                case 17: // Friendly Missing Buff
                case 18: // Friendly Missing Buff Not Self
                {
                    lblTargetParam1.Text = "Radius:";
                    lblTargetParam2.Text = "Spell Id:";
                    txtTargetParam1.Enabled = true;
                    txtTargetParam2.Enabled = true;
                    break;
                }
                case 19: // Friendly CC-ed
                case 23: // Nearest Player
                case 24: // Nearest Hostile Player
                case 25: // Nearest Friendly Player
                {
                    lblTargetParam1.Text = "Radius:";
                    lblTargetParam2.Text = "N/A:";
                    txtTargetParam1.Enabled = true;
                    txtTargetParam2.Enabled = false;
                    SetScriptFieldFromValue(0, "TargetParam2");
                    txtTargetParam2.Text = "";
                    break;
                }
                case 20: // Scripted Map Event Source
                case 21: // Scripted Map Event Target
                {
                    lblTargetParam1.Text = "Event Id:";
                    lblTargetParam2.Text = "N/A:";
                    txtTargetParam1.Enabled = true;
                    txtTargetParam2.Enabled = false;
                    SetScriptFieldFromValue(0, "TargetParam2");
                    txtTargetParam2.Text = "";
                    break;
                }
                case 22: // Scripted Map Event Additional Target
                {
                    lblTargetParam1.Text = "Event Id:";
                    lblTargetParam2.Text = "Entry:";
                    txtTargetParam1.Enabled = true;
                    txtTargetParam2.Enabled = true;
                    break;
                }
            }
        }
        private void cmbTargetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbTargetType, "TargetType", false);
            SetTargetControlsBasedOnType(cmbTargetType.SelectedIndex);
        }
        private void txtCommandDelay_Leave(object sender, EventArgs e)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                uint delay;
                if (!UInt32.TryParse(txtCommandDelay.Text, out delay))
                    txtCommandDelay.Text = "0";

                // Updating delay.
                currentAction.Delay = delay;

                // Update delay in listview.
                currentItem.SubItems[0].Text = txtCommandDelay.Text;
                lstActions.Sort();
            }
        }
        private void txtCommandPriority_Leave(object sender, EventArgs e)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                uint priority;
                if (!UInt32.TryParse(txtCommandPriority.Text, out priority))
                    txtCommandPriority.Text = "0";

                // Updating priority.
                currentAction.Priority = priority;

                // Update priority in listview.
                lstActions.Sort();
            }
        }

        private void btnTargetParam1_Click(object sender, EventArgs e)
        {
            switch (cmbTargetType.SelectedIndex)
            {
                case 2: // Second Aggro
                case 3: // Last Aggro
                case 4: // Random
                case 5: // Random Not Top
                {
                    FormTargetSelectFlags frm = new FormTargetSelectFlags(GetScriptFieldValue<uint>("TargetParam1"));
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        uint selectFlags = frm.ReturnValue;

                        if (selectFlags != 0)
                            btnTargetParam1.Text = selectFlags.ToString();
                        else
                            btnTargetParam1.Text = "-NONE-";

                        SetScriptFieldFromValue(selectFlags, "TargetParam1");
                    }
                    break;
                }
                case 8: // Nearest Creature with Entry
                case 26: // Random Creature with Entry
                {
                    SetScriptFieldFromDataFinderForm<FormCreatureFinder>(btnTargetParam1, null, null, "TargetParam1");
                    break;
                }
                case 11: // Nearest GameObject with Entry
                case 27: // Random GameObject with Entry
                {
                    SetScriptFieldFromDataFinderForm<FormGameObjectFinder>(btnTargetParam1, null, null, "TargetParam1");
                    break;
                }
            }
        }

        private void txtTargetParam1_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtTargetParam1, "TargetParam1");
        }

        private void txtTargetParam2_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtTargetParam2, "TargetParam2");
        }

        private void chkSwapInitial_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkSwapInitial, "DataFlags", 1);
        }

        private void chkSwapFinal_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkSwapFinal, "DataFlags", 2);
        }

        private void chkTargetSelf_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkTargetSelf, "DataFlags", 4);
        }

        private void chkAbortScript_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkAbortScript, "DataFlags", 8);
        }

        private void chkSkipMissingTargets_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkSkipMissingTargets, "DataFlags", 16);
        }

        private void btnActionAdd_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new ListViewItem();

            ScriptAction newAction = new ScriptAction(currentScriptId);

            // We show only delay, command id and comment in the listview.
            newItem.Text = newAction.Delay.ToString();
            newItem.SubItems.Add(newAction.Command.ToString());
            newItem.SubItems.Add(newAction.Comments);

            // Save the ScriptAction to the Tag.
            newItem.Tag = newAction;

            // Add it to the listview.
            lstActions.Items.Add(newItem);

            // Select the new item.
            lstActions.FocusedItem = newItem;
            newItem.Selected = true;
            lstActions.Select();
        }

        private void btnActionCopy_Click(object sender, EventArgs e)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Create new item.
                ListViewItem newItem = new ListViewItem();

                // Copy values of selected action.
                ScriptAction newAction = new ScriptAction(currentScriptId, currentAction.Delay, currentAction.Priority, currentAction.Command, currentAction.Datalong, currentAction.Datalong2, currentAction.Datalong3, currentAction.Datalong4, currentAction.TargetParam1, currentAction.TargetParam2, currentAction.TargetType, currentAction.DataFlags, currentAction.Dataint, currentAction.Dataint2, currentAction.Dataint3, currentAction.Dataint4, currentAction.X, currentAction.Y, currentAction.Z, currentAction.O, currentAction.ConditionId, currentAction.Comments + " - Copy");

                // We show only delay, command id and comment in the listview.
                newItem.Text = newAction.Delay.ToString();
                newItem.SubItems.Add(newAction.Command.ToString());
                newItem.SubItems.Add(newAction.Comments);

                // Save the ScriptAction to the Tag.
                newItem.Tag = newAction;

                // Add it to the listview.
                lstActions.Items.Add(newItem);

                // Select the new item.
                lstActions.FocusedItem = newItem;
                newItem.Selected = true;
                lstActions.Select();
            }
        }

        // Generic form for currently unsupported commands.
        private void txtStartScriptForAllDistance_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtStartScriptForAllDistance, "Datalong4");
        }
        private void txtUnknownCommandDatalong1_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtUnknownCommandDatalong1, "Datalong");
        }
        private void txtUnknownCommandDatalong2_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtUnknownCommandDatalong2, "Datalong2");
        }
        private void txtUnknownCommandDatalong3_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtUnknownCommandDatalong3, "Datalong3");
        }
        private void txtUnknownCommandDatalong4_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtUnknownCommandDatalong4, "Datalong4");
        }
        private void txtUnknownCommandDataint1_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtUnknownCommandDataint1, "Dataint");
        }
        private void txtUnknownCommandDataint2_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtUnknownCommandDataint2, "Dataint2");
        }
        private void txtUnknownCommandDataint3_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtUnknownCommandDataint3, "Dataint3");
        }
        private void txtUnknownCommandDataint4_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtUnknownCommandDataint4, "Dataint4");
        }
        private void txtUnknownCommandX_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtUnknownCommandX, "X");
        }
        private void txtUnknownCommandY_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtUnknownCommandY, "Y");
        }
        private void txtUnknownCommandZ_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtUnknownCommandZ, "Z");
        }
        private void txtUnknownCommandO_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtUnknownCommandO, "O");
        }

        // SCRIPT_COMMAND_TALK (0)
        private void btnTalkText1_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormTextFinder>(btnTalkText1, txtTalkText1, GameData.FindTextWithId, "Dataint");
        }
        private void btnTalkText2_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormTextFinder>(btnTalkText2, txtTalkText2, GameData.FindTextWithId, "Dataint2");
        }
        private void btnTalkText3_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormTextFinder>(btnTalkText3, txtTalkText3, GameData.FindTextWithId, "Dataint3");
        }
        private void btnTalkText4_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormTextFinder>(btnTalkText4, txtTalkText4, GameData.FindTextWithId, "Dataint4");
        }
        private void cmbTalkChatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbTalkChatType, "Datalong", false);
        }

        // SCRIPT_COMMAND_EMOTE (1)

        private void cmbEmoteId_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbEmoteId, "Datalong", true);
        }

        private void cmbEmoteId2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbEmoteId2, "Datalong2", true);
        }

        private void cmbEmoteId3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbEmoteId3, "Datalong3", true);
        }

        private void cmbEmoteId4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbEmoteId4, "Datalong4", true);
        }

        private void cmbEmoteTargeted_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbEmoteTargeted, "Dataint", false);
        }

        // SCRIPT_COMMAND_FIELD_SET (2)
        private void cmbFieldSetFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbFieldSetFields, "Datalong", true);
        }
        private void txtFieldSetValue_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtFieldSetValue, "Datalong2");
        }

        // SCRIPT_COMMAND_MOVE_TO (3)
        private void txtMoveToX_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtMoveToX, "X");
        }
        private void txtMoveToY_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtMoveToY, "Y");
        }
        private void txtMoveToZ_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtMoveToZ, "Z");
        }
        private void txtMoveToO_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtMoveToO, "O");
        }
        private void chkMoveToFlagsForce_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkMoveToFlagsForce, "Datalong4", 1);
        }
        private void chkMoveToFlagsPointMovement_CheckedChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            SetScriptFlagsFromCheckbox(chkMoveToFlagsPointMovement, "Datalong4", 2);
            if (chkMoveToFlagsPointMovement.Checked)
            {
                txtMoveToPointId.Text = "0";
                txtMoveToPointId.Enabled = true;
            }
            else
            {
                SetScriptFieldFromValue(0, "Dataint");
                txtMoveToPointId.Text = "";
                txtMoveToPointId.Enabled = false;
            }
        }
        private void chkMoveOptions1_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkMoveOptions1, "Datalong3", 1);
        }
        private void chkMoveOptions2_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkMoveOptions2, "Datalong3", 2);
        }
        private void chkMoveOptions4_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkMoveOptions4, "Datalong3", 4);
        }
        private void chkMoveOptions8_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkMoveOptions8, "Datalong3", 8);
        }
        private void chkMoveOptions16_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkMoveOptions16, "Datalong3", 16);
        }
        private void chkMoveOptions32_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkMoveOptions32, "Datalong3", 32);
        }
        private void chkMoveOptions64_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkMoveOptions64, "Datalong3", 64);
        }
        private void chkMoveOptions128_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkMoveOptions128, "Datalong3", 128);
        }
        private void chkMoveOptions256_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkMoveOptions256, "Datalong3", 256);
        }
        private void OnMoveCommandTypeChanged(ScriptAction currentAction, uint coordinatesType)
        {
            switch (coordinatesType)
            {
                case 0: // SO_MOVETO_COORDINATES_NORMAL
                case 1: // SO_MOVETO_COORDINATES_RELATIVE_TO_TARGET
                {
                    lblMoveToX.Text = "X coordinate:";
                    lblMoveToO.Text = "Orientation:";
                    txtMoveToY.Enabled = true;
                    txtMoveToZ.Enabled = true;
                    break;
                }
                case 2: // SO_MOVETO_COORDINATES_DISTANCE_FROM_TARGET
                {
                    lblMoveToX.Text = "Distance:";
                    lblMoveToO.Text = "Angle:";
                    txtMoveToY.Enabled = false;
                    txtMoveToY.Text = "0";
                    currentAction.Y = 0;
                    txtMoveToZ.Enabled = false;
                    txtMoveToZ.Text = "0";
                    currentAction.Z = 0;
                    break;
                }
                case 3: // SO_MOVETO_COORDINATES_RANDOM_POINT
                {
                    lblMoveToX.Text = "X coordinate:";
                    lblMoveToO.Text = "Distance:";
                    txtMoveToY.Enabled = true;
                    txtMoveToZ.Enabled = true;
                    break;
                }
            }
        }
        private void cmbMoveToType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                uint coordinatesType = (uint)cmbMoveToType.SelectedIndex;

                // Coordiantes type = datalong.
                currentAction.Datalong = coordinatesType;

                OnMoveCommandTypeChanged(currentAction, coordinatesType);
            }
        }
        private void txtMoveToTime_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtMoveToTime, "Datalong2");
        }
        private void txtMoveToPointId_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtMoveToPointId, "Dataint");
        }

        // SCRIPT_COMMAND_MODIFY_FLAGS (4)
        private List<Tuple<string, uint>> GetValuesListFromModifyFlagsComboBox()
        {
            switch (cmbModifyFlagsFieldId.SelectedIndex)
            {
                case 0: // GAMEOBJECT_FLAGS
                    return GameData.GameObjectFlagsList;
                case 1: // GAMEOBJECT_DYN_FLAGS
                    return GameData.GameObjectDynFlagsList;
                case 2: // UNIT_FIELD_FLAGS
                    return GameData.UnitFieldFlagsList;
                case 3: // UNIT_DYNAMIC_FLAGS
                    return GameData.UnitDynamicFlagsList;
                case 4: // UNIT_NPC_FLAGS
                    return GameData.UnitNpcFlagsList;
                case 5: // PLAYER_FLAGS
                    return GameData.PlayerFlagsList;
            }
            return null;
        }
        private void cmbModifyFlagsFieldId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            SetScriptFieldFromCombobox(cmbModifyFlagsFieldId, "Datalong", true);
            btnModifyFlagsFlags.Text = "-NONE-";
            SetScriptFieldFromValue(0, "Datalong2");
        }
        private void cmbModifyFlagsMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbModifyFlagsMode, "Datalong3", false);
        }
        private void btnModifyFlagsFlags_Click(object sender, EventArgs e)
        {
            List<Tuple<string, uint>> valuesList = GetValuesListFromModifyFlagsComboBox();
            if (valuesList != null)
                SetScriptFieldFromFlagsForm(btnModifyFlagsFlags, valuesList, "Select Flags", "Datalong2");
        }

        // SCRIPT_COMMAND_INTERRUPT_CASTS (5)
        private void btnInterruptCastsSpellId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormSpellFinder>(btnInterruptCastsSpellId, null, GameData.FindSpellName, "Datalong2");
        }
        private void cmbInterruptCastsWithDelayed_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbInterruptCastsWithDelayed, "Datalong", false);
        }

        // SCRIPT_COMMAND_TELEPORT_TO (6)
        private void cmbTeleportMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbTeleportMap, "Datalong", true);
        }
        private void txtTeleportX_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtTeleportX, "X");
        }
        private void txtTeleportY_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtTeleportY, "Y");
        }
        private void txtTeleportZ_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtTeleportZ, "Z");
        }
        private void txtTeleportO_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtTeleportO, "O");
        }
        private void chkTeleportOptions1_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkTeleportOptions1, "Datalong2", 1);
        }
        private void chkTeleportOptions2_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkTeleportOptions2, "Datalong2", 2);
        }
        private void chkTeleportOptions4_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkTeleportOptions4, "Datalong2", 4);
        }
        private void chkTeleportOptions8_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkTeleportOptions8, "Datalong2", 8);
        }
        private void chkTeleportOptions16_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkTeleportOptions16, "Datalong2", 16);
        }
        private void chkTeleportOptions32_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkTeleportOptions32, "Datalong2", 32);
        }

        // SCRIPT_COMMAND_QUEST_EXPLORED (7)
        private void btnQuestCompleteId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormQuestFinder>(btnQuestCompleteId, null, GameData.FindQuestTitle, "Datalong");
        }
        private void txtQuestCompleteDistance_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtQuestCompleteDistance, "Datalong2");
        }
        private void cmbQuestCompleteGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbQuestCompleteGroup, "Datalong3", false);
        }

        // SCRIPT_COMMAND_KILL_CREDIT (8)
        private void cmbKillCreditType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbKillCreditType, "Datalong2", false);
        }
        private void btnKillCreditCreatureId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormCreatureFinder>(btnKillCreditCreatureId, null, GameData.FindCreatureName, "Datalong");
        }

        // SCRIPT_COMMAND_RESPAWN_GAMEOBJECT (9)
        private void txtRespawnGameobjectDelay_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtRespawnGameobjectDelay, "Datalong2");
        }
        private void txtRespawnGameobjectGuid_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtRespawnGameobjectGuid, "Datalong");
        }

        // SCRIPT_COMMAND_TEMP_SUMMON_CREATURE (10)
        private void btnSummonCreatureId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormCreatureFinder>(btnSummonCreatureId, null, GameData.FindCreatureName, "Datalong");
        }
        private void txtSummonCreatureDelay_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSummonCreatureDelay, "Datalong2");
        }
        private void txtSummonCreatureX_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSummonCreatureX, "X");
        }
        private void txtSummonCreatureY_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSummonCreatureY, "Y");
        }
        private void txtSummonCreatureZ_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSummonCreatureZ, "Z");
        }
        private void txtSummonCreatureO_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSummonCreatureO, "O");
        }
        private void cmbSummonCreatureAttackTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSummonCreatureAttackTarget, "Dataint3", true);
        }
        private void cmbSummonCreatureDespawnType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSummonCreatureDespawnType, "Dataint4", true);
        }
        private void txtSummonCreatureScriptId_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSummonCreatureScriptId, "Dataint2");
        }
        private void btnSummonCreatureScriptIdEdit_Click(object sender, EventArgs e)
        {
            uint script_id = 0;
            uint.TryParse(txtSummonCreatureScriptId.Text, out script_id);
            if (script_id > 0)
            {
                FormScriptEditor formEditor = new FormScriptEditor();
                formEditor.Show();
                formEditor.LoadScript(script_id, "generic_scripts");
            }
        }
        private void txtSummonCreatureUniqueLimit_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSummonCreatureUniqueLimit, "Datalong3");
        }
        private void txtSummonCreatureUniqueRange_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSummonCreatureUniqueRange, "Datalong4");
        }
        private void chkSummonCreatureFlags1_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkSummonCreatureFlags1, "Dataint", 1);
        }
        private void chkSummonCreatureFlags2_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkSummonCreatureFlags2, "Dataint", 2);
        }
        private void chkSummonCreatureFlags4_CheckedChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Updating data flags.
                if (chkSummonCreatureFlags4.Checked)
                {
                    currentAction.Dataint += 4;
                    chkSummonCreatureFlags8.Checked = false;
                    txtSummonCreatureUniqueLimit.Enabled = true;
                    txtSummonCreatureUniqueRange.Enabled = true;
                }
                else
                {
                    currentAction.Dataint -= 4;
                    if (!chkSummonCreatureFlags8.Checked)
                    {
                        txtSummonCreatureUniqueLimit.Enabled = false;
                        txtSummonCreatureUniqueLimit.Text = "0";
                        currentAction.Datalong3 = 0;
                        txtSummonCreatureUniqueRange.Enabled = false;
                        txtSummonCreatureUniqueRange.Text = "0";
                        currentAction.Datalong4 = 0;
                    }
                }
            }
        }
        private void chkSummonCreatureFlags8_CheckStateChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Updating data flags.
                if (chkSummonCreatureFlags8.Checked)
                {
                    currentAction.Dataint += 8;
                    chkSummonCreatureFlags4.Checked = false;
                    txtSummonCreatureUniqueLimit.Enabled = true;
                    txtSummonCreatureUniqueRange.Enabled = true;
                }
                else
                {
                    currentAction.Dataint -= 8;
                    if (!chkSummonCreatureFlags4.Checked)
                    {
                        txtSummonCreatureUniqueLimit.Enabled = false;
                        txtSummonCreatureUniqueLimit.Text = "0";
                        currentAction.Datalong3 = 0;
                        txtSummonCreatureUniqueRange.Enabled = false;
                        txtSummonCreatureUniqueRange.Text = "0";
                        currentAction.Datalong4 = 0;
                    }
                }
            }
        }

        private void chkSummonCreatureFlags16_CheckStateChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkSummonCreatureFlags16, "Dataint", 16);
        }

        // SCRIPT_COMMAND_OPEN_DOOR (11)
        private void txtDoorGuid_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtDoorGuid, "Datalong");
        }
        private void txtDoorResetDelay_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtDoorResetDelay, "Datalong2");
        }

        // SCRIPT_COMMAND_REMOVE_AURA (14)
        // SCRIPT_COMMAND_ADD_AURA (74)
        private void btnRemoveAuraSpellId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormSpellFinder>(btnRemoveAuraSpellId, null, GameData.FindSpellName, "Datalong");
        }
        private void chkAddAuraFlag1_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkAddAuraFlag1, "Datalong2", 1);
        }
        private void chkAddAuraFlag2_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkAddAuraFlag2, "Datalong2", 2);
        }
        private void chkAddAuraFlag4_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkAddAuraFlag4, "Datalong2", 4);
        }
        private void chkAddAuraFlag8_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkAddAuraFlag8, "Datalong2", 8);
        }

        // SCRIPT_COMMAND_CAST_SPELL (15)
        private void btnCastSpellId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormSpellFinder>(btnCastSpellId, null, GameData.FindSpellName, "Datalong");
        }
        private void chkCastSpellFlags1_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkCastSpellFlags1, "Datalong2", 1);
        }
        private void chkCastSpellFlags2_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkCastSpellFlags2, "Datalong2", 2);
        }
        private void chkCastSpellFlags4_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkCastSpellFlags4, "Datalong2", 4);
        }
        private void chkCastSpellFlags16_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkCastSpellFlags16, "Datalong2", 16);
        }
        private void chkCastSpellFlags32_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkCastSpellFlags32, "Datalong2", 32);
        }
        private void chkCastSpellFlags64_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkCastSpellFlags64, "Datalong2", 64);
        }
        private void chkCastSpellFlags128_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkCastSpellFlags128, "Datalong2", 128);
        }

        // SCRIPT_COMMAND_PLAY_SOUND (16)
        private void btnPlaySoundId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormSoundFinder>(btnPlaySoundId, null, GameData.FindSoundName, "Datalong");
        }
        private void chkPlaySoundFlags1_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkPlaySoundFlags1, "Datalong2", 1);

            if (chkPlaySoundFlags1.Checked && chkPlaySoundFlags4.Checked)
                chkPlaySoundFlags4.Checked = false;
        }
        private void chkPlaySoundFlags2_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkPlaySoundFlags2, "Datalong2", 2);

            if (chkPlaySoundFlags2.Checked && chkPlaySoundFlags4.Checked)
                chkPlaySoundFlags4.Checked = false;
        }

        private void chkPlaySoundFlags4_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkPlaySoundFlags4, "Datalong2", 4);

            if (chkPlaySoundFlags4.Checked && chkPlaySoundFlags1.Checked)
                chkPlaySoundFlags1.Checked = false;
            if (chkPlaySoundFlags4.Checked && chkPlaySoundFlags2.Checked)
                chkPlaySoundFlags2.Checked = false;
        }

        // SCRIPT_COMMAND_CREATE_ITEM (17)
        private void btnCreateItemId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormItemFinder>(btnCreateItemId, null, GameData.FindItemName, "Datalong");
        }
        private void txtCreateItemAmount_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtCreateItemAmount, "Datalong2");
        }

        // SCRIPT_COMMAND_SET_EQUIPMENT (19)
        private void cmbSetEquipmentUseDefault_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Get the selected option.
                uint selection = (uint)cmbSetEquipmentUseDefault.SelectedIndex;

                // Updating datalong value.
                currentAction.Datalong = selection;

                if (selection > 0)
                {
                    btnSetEquipmentMainHand.Text = "-NONE-";
                    btnSetEquipmentMainHand.Enabled = false;
                    btnSetEquipmentOffHand.Text = "-NONE-";
                    btnSetEquipmentOffHand.Enabled = false;
                    btnSetEquipmentRanged.Text = "-NONE-";
                    btnSetEquipmentRanged.Enabled = false;
                    currentAction.Dataint = 0;
                    currentAction.Dataint2 = 0;
                    currentAction.Dataint3 = 0;
                }
                else
                {
                    btnSetEquipmentMainHand.Enabled = true;
                    btnSetEquipmentOffHand.Enabled = true;
                    btnSetEquipmentRanged.Enabled = true;
                }
            }
        }
        private void btnSetEquipmentMainHand_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormWeaponFinder>(btnSetEquipmentMainHand, null, GameData.FindItemName, "Dataint");
        }
        private void btnSetEquipmentOffHand_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormWeaponFinder>(btnSetEquipmentOffHand, null, GameData.FindItemName, "Dataint2");
        }
        private void btnSetEquipmentRanged_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormWeaponFinder>(btnSetEquipmentRanged, null, GameData.FindItemName, "Dataint3");
        }

        // SCRIPT_COMMAND_MOVEMENT (20
        private void cmbSetMovementType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Get the selected option.
                uint selection = (uint)(cmbSetMovementType.SelectedItem as ComboboxPair).Value;

                // Updating datalong value.
                currentAction.Datalong = selection;

                dontUpdate = true;

                // Reseting controls.
                cmbSetMovementBoolParam.SelectedIndex = 0;
                cmbSetMovementBoolParam.Enabled = false;
                lblSetMovementBoolParam.Text = "Bool Param:";
                txtSetMovementIntParam.Enabled = false;
                txtSetMovementIntParam.Text = "";
                lblSetMovementIntParam.Text = "Int Param:";
                txtSetMovementDistance.Enabled = false;
                txtSetMovementDistance.Text = "";
                txtSetMovementAngle.Enabled = false;
                txtSetMovementAngle.Text = "";
                cmbSetMovementClearMotionMaster.Enabled = false;

                // Reseting script action data.
                currentAction.Datalong2 = 0;
                currentAction.Datalong3 = 0;
                currentAction.X = 0;
                currentAction.O = 0;


                switch (selection)
                {
                    case 0: // IDLE_MOTION_TYPE
                    {
                        cmbSetMovementClearMotionMaster.Enabled = true;
                        break;
                    }
                    case 1: // RANDOM_MOTION_TYPE
                    {
                        cmbSetMovementBoolParam.Enabled = true;
                        cmbSetMovementBoolParam.SelectedIndex = 0;
                        lblSetMovementBoolParam.Text = "Current Position:";
                        txtSetMovementDistance.Enabled = true;
                        txtSetMovementDistance.Text = "0";
                        cmbSetMovementClearMotionMaster.Enabled = true;
                        break;
                    }
                    case 2: // WAYPOINT_MOTION_TYPE
                    {
                        cmbSetMovementBoolParam.Enabled = true;
                        cmbSetMovementBoolParam.SelectedIndex = 0;
                        lblSetMovementBoolParam.Text = "Repeat:";
                        txtSetMovementIntParam.Enabled = true;
                        txtSetMovementIntParam.Text = "0";
                        lblSetMovementIntParam.Text = "Start Point:";
                        cmbSetMovementClearMotionMaster.Enabled = true;
                        break;
                    }
                    case 5: // CHASE_MOTION_TYPE
                    {
                        cmbSetMovementBoolParam.Enabled = true;
                        cmbSetMovementBoolParam.SelectedIndex = 0;
                        lblSetMovementBoolParam.Text = "Target Victim:";
                        txtSetMovementDistance.Enabled = true;
                        txtSetMovementDistance.Text = "0";
                        txtSetMovementAngle.Enabled = true;
                        txtSetMovementAngle.Text = "0";
                        break;
                    }
                    case 9: // FLEEING_MOTION_TYPE
                    {
                        cmbSetMovementBoolParam.Enabled = true;
                        cmbSetMovementBoolParam.SelectedIndex = 0;
                        lblSetMovementBoolParam.Text = "Target Victim:";
                        txtSetMovementIntParam.Enabled = true;
                        txtSetMovementIntParam.Text = "0";
                        lblSetMovementIntParam.Text = "Time:";
                        break;
                    }
                    case 10: // DISTRACT_MOTION_TYPE
                    {
                        txtSetMovementIntParam.Enabled = true;
                        txtSetMovementIntParam.Text = "0";
                        lblSetMovementIntParam.Text = "Time:";
                        break;
                    }
                    case 14: // FOLLOW_MOTION_TYPE
                    {
                        txtSetMovementDistance.Enabled = true;
                        txtSetMovementDistance.Text = "0";
                        txtSetMovementAngle.Enabled = true;
                        txtSetMovementAngle.Text = "0";
                        break;
                    }
                    case 17: // CHARGE_MOTION_TYPE
                    {
                        cmbSetMovementBoolParam.Enabled = true;
                        cmbSetMovementBoolParam.SelectedIndex = 0;
                        lblSetMovementBoolParam.Text = "Attack:";
                        txtSetMovementIntParam.Enabled = true;
                        txtSetMovementIntParam.Text = "0";
                        lblSetMovementIntParam.Text = "Delay:";
                        break;
                    }
                    case 18: // DISTANCING_MOTION_TYPE
                    {
                        txtSetMovementDistance.Enabled = true;
                        txtSetMovementDistance.Text = "0";
                        txtSetMovementIntParam.Enabled = true;
                        txtSetMovementIntParam.Text = "0";
                        lblSetMovementIntParam.Text = "Min Mana %:";
                        break;
                    }
                }

                lblSetMovementBoolParam.Location = new Point(cmbSetMovementBoolParam.Location.X - lblSetMovementBoolParam.Size.Width - 4, lblSetMovementBoolParam.Location.Y);
                lblSetMovementIntParam.Location = new Point(txtSetMovementIntParam.Location.X - lblSetMovementIntParam.Size.Width - 4, lblSetMovementIntParam.Location.Y);
                dontUpdate = false;
            }
        }
        private void cmbSetMovementBoolParam_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSetMovementBoolParam, "Datalong2", false);
        }
        private void txtSetMovementIntParam_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetMovementIntParam, "Datalong3");
        }
        private void txtSetMovementDistance_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetMovementDistance, "X");
        }
        private void txtSetMovementAngle_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetMovementAngle, "O");
        }
        private void cmbSetMovementClearMotionMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSetMovementClearMotionMaster, "Datalong4", false);
        }

        // SCRIPT_COMMAND_SET_ACTIVEOBJECT (21)
        private void cmbActiveObjectSetActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbActiveObjectSetActive, "Datalong", false);
        }

        // SCRIPT_COMMAND_SET_FACTION (22)
        private void btnSetFactionId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormFactionTemplateFinder>(btnSetFactionId, null, GameData.FindFactionTemplateName, "Datalong");
        }
        private void chkSetFactionFlag1_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkSetFactionFlag1, "Datalong2", 1);
        }
        private void chkSetFactionFlag2_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkSetFactionFlag2, "Datalong2", 2);
        }
        private void chkSetFactionFlag4_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkSetFactionFlag4, "Datalong2", 4);
        }

        // SCRIPT_COMMAND_MORPH_TO_ENTRY_OR_MODEL (23)
        // SCRIPT_COMMAND_MOUNT_TO_ENTRY_OR_MODEL (24)
        private void btnMorphOrMountId_Click(object sender, EventArgs e)
        {
            if (cmbMorphOrMountType.SelectedIndex == 0) // Creature Id
                SetScriptFieldFromDataFinderForm<FormCreatureFinder>(btnMorphOrMountId, null, GameData.FindCreatureName, "Datalong");
            else // Display Id
            {
                string id = "";
                DialogResult result = Helpers.ShowInputDialog(ref id, "Display Id");
                if (result == DialogResult.OK)
                {
                    // Get the selected option.
                    uint selectedId;
                    uint.TryParse(id, out selectedId);

                    if (selectedId == 0)
                        btnMorphOrMountId.Text = "-NONE-";
                    else
                        btnMorphOrMountId.Text = selectedId.ToString();

                    SetScriptFieldFromValue(selectedId, "Datalong");
                }
            }
        }
        private void cmbMorphOrMountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            SetScriptFieldFromCombobox(cmbMorphOrMountType, "Datalong2", false);

            // Reseting Id.
            SetScriptFieldFromValue(0, "Datalong");
            btnMorphOrMountId.Text = "-NONE-";
        }

        private void cmbMorphOrMountPermanent_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbMorphOrMountPermanent, "Datalong3", false);
        }

        // SCRIPT_COMMAND_SET_RUN (25)
        private void cmbSetRunMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSetRunMode, "Datalong", false);
        }

        // SCRIPT_COMMAND_UPDATE_ENTRY (27)
        private void btnUpdateEntryCreatureId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormCreatureFinder>(btnUpdateEntryCreatureId, null, GameData.FindCreatureName, "Datalong");
        }

        // SCRIPT_COMMAND_STAND_STATE (28)
        private void cmbSetStandState_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSetStandState, "Datalong", false);
        }

        // SCRIPT_COMMAND_MODIFY_THREAT (29)
        private void cmbModifyThreatTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbModifyThreatTarget, "Datalong", false);
        }
        private void txtModifyThreatPercent_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtModifyThreatPercent, "X");
        }

        // SCRIPT_COMMAND_SEND_TAXI_PATH (30)
        private void btnSendTaxiPathId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormTaxiFinder>(btnSendTaxiPathId, txtSendTaxiPath, GameData.FindTaxiPathDestination, "Datalong");
        }

        // SCRIPT_COMMAND_TERMINATE_SCRIPT (31)
        private void btnTerminateScriptCreatureId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormCreatureFinder>(btnTerminateScriptCreatureId, null, GameData.FindCreatureName, "Datalong");
        }
        private void txtTerminateScriptSearchRadius_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtTerminateScriptSearchRadius, "Datalong2");
        }
        private void cmbTerminateScriptCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbTerminateScriptCondition, "Datalong3", false);
        }

        // SCRIPT_COMMAND_TERMINATE_CONDITION (32)
        private void btnTerminateConditionId_Click(object sender, EventArgs e)
        {
            FormConditionFinder frm = new FormConditionFinder();
            if (frm.ShowDialog(GetScriptFieldValue<int>("Datalong")) == System.Windows.Forms.DialogResult.OK)
            {
                int returnId = frm.ReturnValue;

                if (returnId > 0)
                    btnTerminateConditionId.Text = returnId.ToString();
                else
                    btnTerminateConditionId.Text = "-NONE-";

                SetScriptFieldFromValue(returnId, "Datalong");
            }
        }
        private void btnTerminateConditionQuest_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormQuestFinder>(btnTerminateConditionQuest, null, GameData.FindQuestTitle, "Datalong2");
        }
        private void cmbTerminateConditionRule_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbTerminateConditionRule, "Datalong3", false);
        }

        // SCRIPT_COMMAND_SET_HOME_POSITION (34)
        private void cmbSetHomePositionMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSetHomePositionMode, "Datalong", false);
            switch (cmbSetHomePositionMode.SelectedIndex)
            {
                case 0: // Use provided coordinates
                {

                    txtSetHomePositionX.Enabled = true;
                    txtSetHomePositionY.Enabled = true;
                    txtSetHomePositionZ.Enabled = true;
                    txtSetHomePositionO.Enabled = true;
                    break;
                }
                case 1: // Use current position
                case 2: // Reset to Default
                {
                    SetScriptFieldFromValue(0, "X");
                    SetScriptFieldFromValue(0, "Y");
                    SetScriptFieldFromValue(0, "Z");
                    SetScriptFieldFromValue(0, "O");
                    txtSetHomePositionX.Text = "";
                    txtSetHomePositionX.Enabled = false;
                    txtSetHomePositionY.Text = "";
                    txtSetHomePositionY.Enabled = false;
                    txtSetHomePositionZ.Text = "";
                    txtSetHomePositionZ.Enabled = false;
                    txtSetHomePositionO.Text = "";
                    txtSetHomePositionO.Enabled = false;
                    break;
                }
            }
        }
        private void txtSetHomePositionX_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetHomePositionX, "X");
        }
        private void txtSetHomePositionY_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetHomePositionY, "Y");
        }
        private void txtSetHomePositionZ_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetHomePositionZ, "Z");
        }
        private void txtSetHomePositionO_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetHomePositionO, "O");
        }

        // SCRIPT_COMMAND_TURN_TO (35)
        private void cmbSetFacingMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSetFacingMode, "Datalong", false);
            if (cmbSetFacingMode.SelectedIndex == 0)
            {
                // Face target
                SetScriptFieldFromValue(0, "O");
                txtSetFacingOrientation.Text = "";
                txtSetFacingOrientation.Enabled = false;
            }
            else
            {
                // Use orientation
                txtSetFacingOrientation.Enabled = true;
            }
        }
        private void txtSetFacingOrientation_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetFacingOrientation, "O");
        }

        // SCRIPT_COMMAND_MEETINGSTONE (36)
        private void btnMeetingStoneAreaId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormAreaFinder>(btnMeetingStoneAreaId, null, GameData.FindAreaName, "Datalong");
        }

        // SCRIPT_COMMAND_SET_INST_DATA (37)
        // SCRIPT_COMMAND_SET_INST_DATA64 (38)
        private void txtSetDataField_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetDataField, "Datalong");
        }
        private void txtSetDataValue_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetDataValue, "Datalong2");
        }
        private void cmbSetDataMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Get the selected option.
                uint selection = (uint)cmbSetDataMode.SelectedIndex;

                // Updating datalong value.
                currentAction.Datalong3 = selection;

                if (currentAction.Command == 38) // Set Data 64
                {
                    if (selection == 1) // Source Guid
                    {
                        txtSetDataValue.Text = "";
                        txtSetDataValue.Enabled = false;
                        currentAction.Datalong2 = 0;
                    }
                    else
                        txtSetDataValue.Enabled = true;
                }
            }
        }

        // SCRIPT_COMMAND_START_SCRIPT (39)
        // SCRIPT_COMMAND_START_SCRIPT_ON_GROUP (90)
        private void txtStartScriptId1_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtStartScriptId1, "Datalong");
        }
        private void txtStartScriptId2_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtStartScriptId2, "Datalong2");
        }
        private void txtStartScriptId3_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtStartScriptId3, "Datalong3");
        }
        private void txtStartScriptId4_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtStartScriptId4, "Datalong4");
        }
        private void txtStartScriptChance1_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtStartScriptChance1, "Dataint");
        }
        private void txtStartScriptChance2_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtStartScriptChance2, "Dataint2");
        }
        private void txtStartScriptChance3_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtStartScriptChance3, "Dataint3");
        }
        private void txtStartScriptChance4_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtStartScriptChance4, "Dataint4");
        }
        private void btnStartScriptEdit1_Click(object sender, EventArgs e)
        {
            uint script_id = 0;
            uint.TryParse(txtStartScriptId1.Text, out script_id);
            if (script_id > 0)
            {
                FormScriptEditor formEditor = new FormScriptEditor();
                formEditor.Show();
                formEditor.LoadScript(script_id, "generic_scripts");
            }
        }
        private void btnStartScriptEdit2_Click(object sender, EventArgs e)
        {
            uint script_id = 0;
            uint.TryParse(txtStartScriptId2.Text, out script_id);
            if (script_id > 0)
            {
                FormScriptEditor formEditor = new FormScriptEditor();
                formEditor.Show();
                formEditor.LoadScript(script_id, "generic_scripts");
            }
        }
        private void btnStartScriptEdit3_Click(object sender, EventArgs e)
        {
            uint script_id = 0;
            uint.TryParse(txtStartScriptId3.Text, out script_id);
            if (script_id > 0)
            {
                FormScriptEditor formEditor = new FormScriptEditor();
                formEditor.Show();
                formEditor.LoadScript(script_id, "generic_scripts");
            }
        }
        private void btnStartScriptEdit4_Click(object sender, EventArgs e)
        {
            uint script_id = 0;
            uint.TryParse(txtStartScriptId4.Text, out script_id);
            if (script_id > 0)
            {
                FormScriptEditor formEditor = new FormScriptEditor();
                formEditor.Show();
                formEditor.LoadScript(script_id, "generic_scripts");
            }
        }

        // SCRIPT_COMMAND_SET_PHASE (44)
        private void txtSetPhasePhase_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetPhasePhase, "Datalong");
        }
        private void cmbSetPhaseMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSetPhaseMode, "Datalong2", false);
        }

        // SCRIPT_COMMAND_DESPAWN_CREATURE (18)
        // SCRIPT_COMMAND_SET_PHASE_RANDOM (45)
        // SCRIPT_COMMAND_SET_PHASE_RANGE (46)
        // SCRIPT_COMMAND_SET_SERVER_VARIABLE (54)
        // SCRIPT_COMMAND_SET_GOSSIP_MENU (84)
        // SCRIPT_COMMAND_SEND_SCRIPT_EVENT (85)
        private void txtSetRandomPhase1_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetRandomPhase1, "Datalong");
        }
        private void txtSetRandomPhase2_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetRandomPhase2, "Datalong2");
        }
        private void txtSetRandomPhase3_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetRandomPhase3, "Datalong3");
        }
        private void txtSetRandomPhase4_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetRandomPhase4, "Datalong4");
        }

        // SCRIPT_COMMAND_FLEE (47)
        private void cmbFleeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbFleeMode, "Datalong", false);
        }

        // SCRIPT_COMMAND_CALL_FOR_HELP (50)
        private void txtCallForHelpRadius_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtCallForHelpRadius, "X");
        }

        // SCRIPT_COMMAND_GAME_EVENT (53)
        private void btnGameEventId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormEventFinder>(btnGameEventId, null, GameData.FindEventName, "Datalong");
        }
        private void cmbGameEventAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbGameEventAction, "Datalong2", false);
        }
        private void cmbGameEventOverwrite_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbGameEventOverwrite, "Datalong3", false);
        }

        // SCRIPT_COMMAND_CREATURE_SPELLS (55)
        private void btnSetSpellsTemplate1_Click(object sender, EventArgs e)
        {
            FormCastsEditor frm = new FormCastsEditor();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uint returnId = frm.ReturnValue;

                if (returnId > 0)
                    btnSetSpellsList1.Text = GameData.FindCreatureSpellsListName(returnId) + " (" + returnId.ToString() + ")";
                else
                    btnSetSpellsList1.Text = "-NONE-";

                // Set the field value.
                SetScriptFieldFromValue(returnId, "Datalong");
            }
        }
        private void btnSetSpellsTemplate2_Click(object sender, EventArgs e)
        {
            FormCastsEditor frm = new FormCastsEditor();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uint returnId = frm.ReturnValue;

                if (returnId > 0)
                    btnSetSpellsList2.Text = GameData.FindCreatureSpellsListName(returnId) + " (" + returnId.ToString() + ")";
                else
                    btnSetSpellsList2.Text = "-NONE-";

                // Set the field value.
                SetScriptFieldFromValue(returnId, "Datalong2");
            }
        }
        private void btnSetSpellsTemplate3_Click(object sender, EventArgs e)
        {
            FormCastsEditor frm = new FormCastsEditor();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uint returnId = frm.ReturnValue;

                if (returnId > 0)
                    btnSetSpellsList3.Text = GameData.FindCreatureSpellsListName(returnId) + " (" + returnId.ToString() + ")";
                else
                    btnSetSpellsList3.Text = "-NONE-";

                // Set the field value.
                SetScriptFieldFromValue(returnId, "Datalong3");
            }
        }
        private void btnSetSpellsTemplate4_Click(object sender, EventArgs e)
        {
            FormCastsEditor frm = new FormCastsEditor();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uint returnId = frm.ReturnValue;

                if (returnId > 0)
                    btnSetSpellsList4.Text = GameData.FindCreatureSpellsListName(returnId) + " (" + returnId.ToString() + ")";
                else
                    btnSetSpellsList4.Text = "-NONE-";

                // Set the field value.
                SetScriptFieldFromValue(returnId, "Datalong4");
            }
        }
        private void txtSetSpellsTemplateChance1_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetSpellsListChance1, "Dataint");
        }
        private void txtSetSpellsTemplateChance2_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetSpellsListChance2, "Dataint2");
        }
        private void txtSetSpellsTemplateChance3_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetSpellsListChance3, "Dataint3");
        }
        private void txtSetSpellsTemplateChance4_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetSpellsListChance4, "Dataint4");
        }

        // SCRIPT_COMMAND_ADD_SPELL_COOLDOWN (57)
        private void btnSpellCooldownId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormSpellFinder>(btnSpellCooldownId, null, GameData.FindSpellName, "Datalong");
        }
        private void txtSpellCooldownSeconds_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpellCooldownSeconds, "Datalong2");
        }

        // SCRIPT_COMMAND_SET_REACT_STATE (59)
        private void cmbSetReactState_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSetReactState, "Datalong", false);
        }

        // SCRIPT_COMMAND_START_WAYPOINTS (60)
        private void OnWaypointsSourceChanged()
        {
            if (cmbStartWaypointsSource.SelectedIndex == 3)
            {
                lblStartWaypointsGuid.Enabled = false;
                txtStartWaypointsGuid.Enabled = false;
            }
            else
            {
                lblStartWaypointsGuid.Enabled = true;
                txtStartWaypointsGuid.Enabled = true;
            }
        }
        private void cmbStartWaypointsSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbStartWaypointsSource, "Datalong", false);
            OnWaypointsSourceChanged();
        }
        private void cmbStartWaypointsRepeat_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbStartWaypointsRepeat, "Datalong4", false);
        }
        private void txtStartWaypointsStartPoint_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtStartWaypointsStartPoint, "Datalong2");
        }
        private void txtStartWaypointsInitialDelay_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtStartWaypointsInitialDelay, "Datalong3");
        }
        private void txtStartWaypointsGuid_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtStartWaypointsGuid, "Dataint");
        }
        private void txtStartWaypointsEntry_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtStartWaypointsEntry, "Dataint2");
        }

        // SCRIPT_COMMAND_START_MAP_EVENT (61)
        private void btnStartScriptedMapEventSuccessCondition_Click(object sender, EventArgs e)
        {
            FormConditionFinder frm = new FormConditionFinder();
            bool has_ignore = GetSelectedCommandType() == 69 ? true : false;
            if (frm.ShowDialog(GetScriptFieldValue<int>("Dataint"), has_ignore) == System.Windows.Forms.DialogResult.OK)
            {
                int returnId = frm.ReturnValue;

                if (returnId > 0)
                    btnStartScriptedMapEventSuccessCondition.Text = returnId.ToString();
                else
                    btnStartScriptedMapEventSuccessCondition.Text = "-NONE-";

                SetScriptFieldFromValue(returnId, "Dataint");
            }
        }
        private void btnStartScriptedMapEventFailureCondition_Click(object sender, EventArgs e)
        {
            FormConditionFinder frm = new FormConditionFinder();
            bool has_ignore = GetSelectedCommandType() == 69 ? true : false;
            if (frm.ShowDialog(GetScriptFieldValue<int>("Dataint3"), has_ignore) == System.Windows.Forms.DialogResult.OK)
            {
                int returnId = frm.ReturnValue;

                if (returnId > 0)
                    btnStartScriptedMapEventFailureCondition.Text = returnId.ToString();
                else
                    btnStartScriptedMapEventFailureCondition.Text = "-NONE-";

                SetScriptFieldFromValue(returnId, "Dataint3");
            }
        }
        private void txtStartScriptedMapEventSuccessScript_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtStartScriptedMapEventSuccessScript, "Dataint2");
        }
        private void txtStartScriptedMapEventFailureScript_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtStartScriptedMapEventFailureScript, "Dataint4");
        }
        private void btnStartScriptedMapEventSuccessScriptEdit_Click(object sender, EventArgs e)
        {
            uint script_id = 0;
            uint.TryParse(txtStartScriptedMapEventSuccessScript.Text, out script_id);
            if (script_id > 0)
            {
                FormScriptEditor formEditor = new FormScriptEditor();
                formEditor.Show();
                formEditor.LoadScript(script_id, "generic_scripts");
            }
        }
        private void btnStartScriptedMapEventFailureScriptEdit_Click(object sender, EventArgs e)
        {
            uint script_id = 0;
            uint.TryParse(txtStartScriptedMapEventFailureScript.Text, out script_id);
            if (script_id > 0)
            {
                FormScriptEditor formEditor = new FormScriptEditor();
                formEditor.Show();
                formEditor.LoadScript(script_id, "generic_scripts");
            }
        }
        private void txtStartScriptedMapEventId_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtStartScriptedMapEventId, "Datalong");
        }
        private void txtStartScriptedMapEventTimeLimit_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtStartScriptedMapEventTimeLimit, "Datalong2");
        }

        // SCRIPT_COMMAND_REMOVE_MAP_EVENT_TARGET (64)
        private void btnRemoveScriptedMapEventTargetCondition_Click(object sender, EventArgs e)
        {
            FormConditionFinder frm = new FormConditionFinder();
            if (frm.ShowDialog(GetScriptFieldValue<int>("Datalong2")) == System.Windows.Forms.DialogResult.OK)
            {
                int returnId = frm.ReturnValue;

                if (returnId > 0)
                    btnRemoveScriptedMapEventTargetCondition.Text = returnId.ToString();
                else
                    btnRemoveScriptedMapEventTargetCondition.Text = "-NONE-";

                SetScriptFieldFromValue(returnId, "Datalong2");
            }
        }
        private void txtRemoveScriptedMapEventTargetEventId_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtRemoveScriptedMapEventTargetEventId, "Datalong");
        }
        private void cmbRemoveScriptedMapEventTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbRemoveScriptedMapEventTarget, "Datalong3", false);
        }

        // SCRIPT_COMMAND_SET_MAP_EVENT_DATA (65)
        private void txtSetScriptedMapEventDataEventId_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetScriptedMapEventDataEventId, "Datalong");
        }
        private void txtSetScriptedMapEventDataIndex_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetScriptedMapEventDataIndex, "Datalong2");
        }
        private void cmbSetScriptedMapEventDataMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                if (currentAction.Command == 65) // Set Scripted Map Event Data
                    currentAction.Datalong4 = (uint)cmbSetScriptedMapEventDataMode.SelectedIndex;
                else                             // Send Scripted Map Event
                    currentAction.Datalong3 = (uint)cmbSetScriptedMapEventDataMode.SelectedIndex;
            }
        }
        private void txtSetScriptedMapEventData_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetScriptedMapEventData, "Datalong3");
        }

        // SCRIPT_COMMAND_SET_DEFAULT_MOVEMENT (67)
        private void cmbSetDefaultMovementType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            SetScriptFieldFromCombobox(cmbSetDefaultMovementType, "Datalong", false);

            switch (cmbSetDefaultMovementType.SelectedIndex)
            {
                case 0: // Idle Movement
                {
                    lblSetDefaultMovementParam1.Text = "Param 1:";
                    txtSetDefaultMovementParam1.Enabled = false;
                    txtSetDefaultMovementParam1.Text = "";
                    SetScriptFieldFromValue(0, "Datalong3");
                    break;
                }
                case 1: // Random Movement
                {
                    lblSetDefaultMovementParam1.Text = "Distance:";
                    txtSetDefaultMovementParam1.Enabled = true;
                    break;
                }
                case 2: // Waypoint Movement
                {
                    lblSetDefaultMovementParam1.Text = "Start Point:";
                    txtSetDefaultMovementParam1.Enabled = true;
                    break;
                }
            }
            lblSetDefaultMovementParam1.Location = new Point(txtSetDefaultMovementParam1.Location.X - lblSetDefaultMovementParam1.Size.Width - 4, lblSetDefaultMovementParam1.Location.Y);
        }
        private void cmbSetDefaultMovementAlwaysReplace_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSetDefaultMovementAlwaysReplace, "Datalong2", false);
        }
        private void txtSetDefaultMovementParam1_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetDefaultMovementParam1, "Datalong3");
        }

        // SCRIPT_COMMAND_START_SCRIPT_FOR_ALL (68)
        private void txtStartScriptForAllScriptId_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtStartScriptForAllScriptId, "Datalong");
        }
        private void cmbStartScriptForAllObjectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            switch (cmbStartScriptForAllObjectType.SelectedIndex)
            {
                case 0: // GameObject
                case 2: // Creature
                {
                    btnStartScriptForAllObjectEntry.Enabled = true;
                    break;
                }
                default:
                {
                    btnStartScriptForAllObjectEntry.Enabled = false;
                    break;
                }
            }

            btnStartScriptForAllObjectEntry.Text = "-NONE-";
            SetScriptFieldFromValue(0, "Datalong3");
            SetScriptFieldFromCombobox(cmbStartScriptForAllObjectType, "Datalong2", false);
        }
        private void btnStartScriptForAllObjectEntry_Click(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            switch (cmbStartScriptForAllObjectType.SelectedIndex)
            {
                case 0: // GameObject
                {
                    SetScriptFieldFromDataFinderForm<FormGameObjectFinder>(btnStartScriptForAllObjectEntry, null, GameData.FindGameObjectName, "Datalong3");
                    break;
                }
                case 2: // Creature
                {
                    SetScriptFieldFromDataFinderForm<FormCreatureFinder>(btnStartScriptForAllObjectEntry, null, GameData.FindCreatureName, "Datalong3");
                    break;
                }
            }
        }
        private void btnStartScriptForAllEdit_Click(object sender, EventArgs e)
        {
            uint script_id = 0;
            uint.TryParse(txtStartScriptForAllScriptId.Text, out script_id);
            if (script_id > 0)
            {
                FormScriptEditor formEditor = new FormScriptEditor();
                formEditor.Show();
                formEditor.LoadScript(script_id, "generic_scripts");
            }
        }

        //SCRIPT_COMMAND_SUMMON_OBJECT (76)
        private void btnSummonObjectId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormGameObjectFinder>(btnSummonObjectId, null, GameData.FindGameObjectName, "Datalong");
        }
        private void txtSummonObjectRespawnTime_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSummonObjectRespawnTime, "Datalong2");
        }
        private void txtSummonObjectX_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSummonObjectX, "X");
        }
        private void txtSummonObjectY_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSummonObjectY, "Y");
        }
        private void txtSummonObjectZ_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSummonObjectZ, "Z");
        }
        private void txtSummonObjectO_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSummonObjectO, "O");
        }

        // SCRIPT_COMMAND_JOIN_CREATURE_GROUP (78)

        private void txtJoinCreatureGroupDistance_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtJoinCreatureGroupDistance, "X");
        }

        private void txtJoinCreatureGroupAngle_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtJoinCreatureGroupAngle, "O");
        }

        private void chkJoinCreatureGroup1_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkJoinCreatureGroup1, "Datalong", 1);
        }

        private void chkJoinCreatureGroup2_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkJoinCreatureGroup2, "Datalong", 2);
        }

        private void chkJoinCreatureGroup4_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkJoinCreatureGroup4, "Datalong", 4);
        }

        private void chkJoinCreatureGroup8_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkJoinCreatureGroup8, "Datalong", 8);
        }

        private void chkJoinCreatureGroup16_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkJoinCreatureGroup16, "Datalong", 16);
        }

        private void chkJoinCreatureGroup32_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkJoinCreatureGroup32, "Datalong", 32);
        }

        private void chkJoinCreatureGroup64_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkJoinCreatureGroup64, "Datalong", 64);
        }

        private void chkJoinCreatureGroup128_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkJoinCreatureGroup128, "Datalong", 128);
        }
    }

    // Sorts items in the script actions listbox by delay.
    class ActionSorter : System.Collections.IComparer
    {
        public int Compare(object x, object y) // IComparer Member
        {
            if (!(x is ListViewItem))
                return (0);
            if (!(y is ListViewItem))
                return (0);

            ListViewItem l1 = (ListViewItem)x;
            ListViewItem l2 = (ListViewItem)y;

            ScriptAction action1 = (ScriptAction)l1.Tag;
            ScriptAction action2 = (ScriptAction)l2.Tag;

            if (action1.Delay == action2.Delay)
                return action1.Priority.CompareTo(action2.Priority);

            return action1.Delay.CompareTo(action2.Delay);
        }
    }
}
