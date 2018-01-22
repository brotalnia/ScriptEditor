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

namespace ScriptEditor
{
    public partial class Form1 : Form
    {
        // MySQL connection data.
        public string connString = "Server=localhost;Database=mangos;Uid=root;Pwd=root;";
        public string mysqlUser = "root";
        public string mysqlPass = "root";
        public string mysqlHost = "localhost";
        public string mysqlDB = "mangos";

        // Save what we are currently working on.
        public uint currentScriptId = 0;
        public string currentScriptTable = "";

        // Used to prevent control events triggering when reseting data.
        bool dontUpdate = false;

        // Used to get the name of quests, creatures, etc.
        public delegate string NameFinder(uint id);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadControls();
            LoadConfig();
            GameData.LoadBroadcastTexts(connString);
            GameData.LoadQuests(connString);
            GameData.LoadCreatures(connString);
            GameData.LoadSpells(connString);
            GameData.LoadItems(connString);
        }

        private void LoadControls()
        {
            dontUpdate = true;

            // Assign sorter to listview.
            lstActions.ListViewItemSorter = new ActionSorter();

            // Add options to Commands combo box.
            cmbCommandId.Items.Add(new ComboboxPair("Talk", 0));
            cmbCommandId.Items.Add(new ComboboxPair("Emote", 1));
            cmbCommandId.Items.Add(new ComboboxPair("Field Set", 2));
            cmbCommandId.Items.Add(new ComboboxPair("Move", 3));
            cmbCommandId.Items.Add(new ComboboxPair("Flag Set", 4));
            cmbCommandId.Items.Add(new ComboboxPair("Flag Remove", 5));
            cmbCommandId.Items.Add(new ComboboxPair("Teleport", 6));
            cmbCommandId.Items.Add(new ComboboxPair("Complete Quest", 7));
            cmbCommandId.Items.Add(new ComboboxPair("Kill Credit", 8));
            cmbCommandId.Items.Add(new ComboboxPair("Respawn GameObject", 9));
            cmbCommandId.Items.Add(new ComboboxPair("Summon Creature", 10));
            cmbCommandId.Items.Add(new ComboboxPair("Open Door", 11));
            cmbCommandId.Items.Add(new ComboboxPair("Close Door", 12));
            cmbCommandId.Items.Add(new ComboboxPair("Activate GameObject", 13));
            cmbCommandId.Items.Add(new ComboboxPair("Remove Aura", 14));
            cmbCommandId.Items.Add(new ComboboxPair("Cast Spell", 15));
            cmbCommandId.Items.Add(new ComboboxPair("Play Sound", 16));
            cmbCommandId.Items.Add(new ComboboxPair("Create Item", 17));
            cmbCommandId.Items.Add(new ComboboxPair("Despawn Creature", 18));
            cmbCommandId.Items.Add(new ComboboxPair("Set Equipment", 19));
            cmbCommandId.Items.Add(new ComboboxPair("Set Movement Type", 20));
            cmbCommandId.Items.Add(new ComboboxPair("Make Active Object", 21));
            cmbCommandId.Items.Add(new ComboboxPair("Set Faction", 22));
            cmbCommandId.Items.Add(new ComboboxPair("Morph", 23));
            cmbCommandId.Items.Add(new ComboboxPair("Mount", 24));
            cmbCommandId.Items.Add(new ComboboxPair("Toggle Run or Walk", 25));
            cmbCommandId.Items.Add(new ComboboxPair("Start Attack", 26));
            cmbCommandId.Items.Add(new ComboboxPair("Set Lock State", 27));
            cmbCommandId.Items.Add(new ComboboxPair("Set Stand State", 28));
            cmbCommandId.Items.Add(new ComboboxPair("Set NPC Flags", 29));
            cmbCommandId.Items.Add(new ComboboxPair("Start Taxi Path", 30));
            cmbCommandId.Items.Add(new ComboboxPair("Terminate Script", 31));
            cmbCommandId.Items.Add(new ComboboxPair("Terminate Condition", 32));
            cmbCommandId.Items.Add(new ComboboxPair("Enter Evade Mode", 33));
            cmbCommandId.Items.Add(new ComboboxPair("Set Home Position", 34));
            cmbCommandId.Items.Add(new ComboboxPair("Set Orientation", 35));
            cmbCommandId.Items.Add(new ComboboxPair("MeetingStone Queue", 36));
            cmbCommandId.Items.Add(new ComboboxPair("Set Data", 37));
            cmbCommandId.Items.Add(new ComboboxPair("Set Data 64", 38));
            cmbCommandId.SelectedIndex = 0;

            // Add option to Buddy Type combo box.
            cmbBuddyType.Items.Add(new ComboboxPair("Creature Entry", 0));
            cmbBuddyType.Items.Add(new ComboboxPair("Creature GUID", 1));
            cmbBuddyType.Items.Add(new ComboboxPair("Creature Instance Data", 2));
            cmbBuddyType.Items.Add(new ComboboxPair("Gameobject Entry", 3));
            cmbBuddyType.Items.Add(new ComboboxPair("Gameobject GUID", 4));
            cmbBuddyType.Items.Add(new ComboboxPair("Gameobject Instance Data", 5));
            cmbBuddyType.SelectedIndex = 0;

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
            cmbEmoteId.DataSource = GameData.EmotesList;

            // Assign fields list to combo box.
            cmbFieldSetFields.DataSource = GameData.FlagFieldsList;

            // Assign maps list to combo box.
            cmbTeleportMap.DataSource = GameData.MapsList;

            // Add options to Move To Coordinates Type combo box.
            cmbMoveToType.Items.Add(new ComboboxPair("Normal coordinates", 0));
            cmbMoveToType.Items.Add(new ComboboxPair("Relative to target", 1));
            cmbMoveToType.Items.Add(new ComboboxPair("Distance from target", 2));

            // Add options to Kill Credit Type combo box.
            cmbKillCreditType.Items.Add(new ComboboxPair("Personal credit", 0));
            cmbKillCreditType.Items.Add(new ComboboxPair("Group credit", 1));

            // Assign motion types list to combo box.
            cmbSetMovementType.DataSource = GameData.MotionTypesList;

            // Assign update fields to combo box.
            cmbFieldSetFields.DataSource = GameData.UpdateFieldsList;

            // Assign flag fields to combo box.
            cmbModifyFlagsFieldId.DataSource = GameData.FlagFieldsList;

            // Setting default selection for combo boxes.
            cmbSummonCreatureFacingOptions.SelectedIndex = 0;
            cmbSummonCreatureSetRun.SelectedIndex = 0;
            cmbTable.SelectedIndex = 0;
            cmbSetMovementType.SelectedIndex = 0;

            //MessageBox.Show((cmbCommandId.SelectedItem as ComboboxPair).Value.ToString());
            dontUpdate = false;
        }
        
        private void LoadConfig()
        {
            if (!System.IO.File.Exists(@"config.ini"))
            {
                MessageBox.Show("Your config file seems to have vanished into the nether! But worry not, i shall use my ultra-safe mind reading device to guess your database connection details. Surely nothing can go wrong, gnomish inventions are renowned for their safety after all!", "No config found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"config.ini");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("User="))
                    mysqlUser = line.Replace("User=", "");
                else if (line.Contains("Pass="))
                    mysqlPass = line.Replace("Pass=", "");
                else if (line.Contains("Host="))
                    mysqlHost = line.Replace("Host=", "");
                else if (line.Contains("DB="))
                    mysqlDB = line.Replace("DB=", "");
            }

            connString = "Server=" + mysqlHost + ";Database=" + mysqlDB + ";Uid=" + mysqlUser + ";Pwd=" + mysqlPass + ";";
        }

        
        private void btnFind_Click(object sender, EventArgs e)
        {
            dontUpdate = true;
            lstActions.Items.Clear();
            ResetAndDisableGeneralForm();
            ResetAndHideCommandSpecificForms();

            // If no script id just clear data.
            if ((txtScriptId.Text.Length == 0) || (!UInt32.TryParse(txtScriptId.Text, out currentScriptId)))
            {
                lblId.Text = "No script loaded.";
                currentScriptId = 0;
                currentScriptTable = "";
                return;
            }

            currentScriptTable = cmbTable.Text;

            lblId.Text = "Editing script " + txtScriptId.Text + " from " + currentScriptTable + ".";

            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT id, delay, command, datalong, datalong2, datalong3, datalong4, buddy_id, buddy_radius, buddy_type, data_flags, dataint, dataint2, dataint3, dataint4, x, y, z, o, comments FROM " + cmbTable.SelectedItem.ToString() + " WHERE id=" + txtScriptId.Text + " ORDER BY delay";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem();

                    ScriptAction action = new ScriptAction(reader.GetUInt32(0), reader.GetUInt32(1), reader.GetUInt32(2), reader.GetUInt32(3), reader.GetUInt32(4), reader.GetUInt32(5), reader.GetUInt32(6), reader.GetUInt32(7), reader.GetUInt32(8), reader.GetUInt32(9), reader.GetUInt32(10), reader.GetInt32(11), reader.GetInt32(12), reader.GetInt32(13), reader.GetInt32(14), reader.GetFloat(15), reader.GetFloat(16), reader.GetFloat(17), reader.GetFloat(18), reader[19].ToString());
                    
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
            dontUpdate = false;
        }

        private void btnActionRemove_Click(object sender, EventArgs e)
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
            txtCommandComment.Text = "";
            txtBuddyId.Text = "";
            txtBuddyRadius.Text = "";
            
            // Combo Boxes.
            cmbBuddyType.SelectedIndex = 0;
            cmbBuddyType.Text = "";
            cmbCommandId.SelectedIndex = 0;
            cmbCommandId.Text = "";

            // Check Boxes.
            chkAbortScript.Checked = false;
            chkSwapFinal.Checked = false;
            chkSwapInitial.Checked = false;
            chkTargetSelf.Checked = false;

            // Make the form disabled.
            grpGeneral.Enabled = false;

            dontUpdate = false;
        }
        private void ResetAndHideCommandSpecificForms()
        {
            dontUpdate = true;

            // Talk Command (0)
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

            // Emote Command (1)
            frmCommandEmote.Visible = false;
            cmbEmoteId.SelectedIndex = 0;

            // Field Set Command (2)
            // todo: just hide checkboxes, no panels, unified groupbox with all flags
            cmbFieldSetFields.SelectedIndex = 0;
            txtFieldSetValue.Text = "";
            frmCommandFieldSet.Visible = false;

            // Move To Command (3)
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
            frmCommandMoveTo.Visible = false;

            // Modify Flags Command (4)
            cmbModifyFlagsFieldId.SelectedIndex = 0;
            cmbModifyFlagsMode.SelectedIndex = 0;
            Command4ResetAllCheckboxes();
            frmCommandModifyFlags.Visible = false;

            // Teleport Command (6)
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

            // Quest Complete Command (7)
            btnQuestCompleteId.Text = "-NONE-";
            txtQuestCompleteDistance.Text = "";
            frmCommandQuestComplete.Visible = false;

            // Kill Credit Command (8)
            btnKillCreditCreatureId.Text = "-NONE-";
            cmbKillCreditType.SelectedIndex = 0;
            frmCommandKillCredit.Visible = false;

            // Respawn GameObject Command (9)
            txtRespawnGameobjectDelay.Text = "";
            txtRespawnGameobjectGuid.Text = "";
            frmCommandRespawnGameobject.Visible = false;

            // Summon Creature Command (10)
            btnSummonCreatureId.Text = "-NONE-";
            txtSummonCreatureDelay.Text = "";
            txtSummonCreatureUniqueLimit.Text = "";
            txtSummonCreatureUniqueRange.Text = "";
            txtSummonCreatureX.Text = "";
            txtSummonCreatureY.Text = "";
            txtSummonCreatureZ.Text = "";
            txtSummonCreatureO.Text = "";
            cmbSummonCreatureSetRun.SelectedIndex = 0;
            cmbSummonCreatureFacingOptions.SelectedIndex = 0;
            chkSummonCreatureFlags16.Checked = false;
            chkSummonCreatureFlags32.Checked = false;
            chkSummonCreatureFlags64.Checked = false;
            frmCommandSummonCreature.Visible = false;

            // Open/Close Door and Activate GameObject Commands (11, 12, 13)
            txtDoorGuid.Text = "";
            txtDoorResetDelay.Text = "";
            frmCommandDoor.Visible = false;

            // Remove Aura Command (14)
            btnRemoveAuraSpellId.Text = "-NONE-";
            frmCommandRemoveAura.Visible = false;

            // Cast Spell Command (15)
            btnCastSpellId.Text = "-NONE-";
            chkCastSpellFlags1.Checked = false;
            chkCastSpellFlags2.Checked = false;
            frmCommandCastSpell.Visible = false;

            // Play Sound Command (16)
            txtPlaySoundId.Text = "";
            chkPlaySoundFlags1.Checked = false;
            chkPlaySoundFlags2.Checked = false;
            frmCommandPlaySound.Visible = false;

            // Create Item Command (17)
            btnCreateItemId.Text = "-NONE-";
            txtCreateItemAmount.Text = "";
            frmCommandCreateItem.Visible = false;

            // Despawn Creature Command (18)
            txtDespawnCreatureDelay.Text = "";
            frmCommandDespawnCreature.Visible = false;

            // Set Equipment Command (19)
            btnSetEquipmentMainHand.Text = "-NONE-";
            btnSetEquipmentOffHand.Text = "-NONE-";
            btnSetEquipmentRanged.Text = "-NONE-";
            cmbSetEquipmentUseDefault.SelectedIndex = 0;
            frmCommandSetEquipment.Visible = false;

            // Set Movement Command (20)
            cmbSetMovementType.SelectedIndex = 0;
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
            lblSetMovementBoolParam.Location = new Point(cmbSetMovementBoolParam.Location.X - lblSetMovementBoolParam.Size.Width - 4, lblSetMovementBoolParam.Location.Y);
            lblSetMovementIntParam.Location = new Point(txtSetMovementIntParam.Location.X - lblSetMovementIntParam.Size.Width - 4, lblSetMovementIntParam.Location.Y);
            frmCommandSetMovement.Visible = false;

            // Set Active Object Command (21)
            cmbActiveObjectSetActive.SelectedIndex = 0;
            frmCommandActiveObject.Visible = false;

            // Set Faction Command (22)
            txtSetFactionId.Text = "";
            chkSetFactionFlag1.Checked = false;
            chkSetFactionFlag2.Checked = false;
            chkSetFactionFlag4.Checked = false;
            frmCommandSetFaction.Visible = false;

            // Morph (23) and Mount Commands (24)
            btnMorphOrMountId.Text = "-NONE-";
            cmbMorphOrMountType.SelectedIndex = 0;
            frmCommandMorphOrMount.Visible = false;

            // Set Run Command (25)
            cmbSetRunMode.SelectedIndex = 0;
            frmCommandSetRun.Visible = false;

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

                    // move to flags
                    if ((selectedAction.Datalong4 & 1) != 0)
                        chkMoveToFlagsForce.Checked = true;

                    // some fields unavailable based on coordinates_type
                    switch (selectedAction.Datalong)
                    {
                        case 0: // SO_MOVETO_COORDINATES_NORMAL
                        case 1: // SO_MOVETO_COORDINATES_RELATIVE_TO_TARGET
                        {
                            lblMoveToX.Text = "X coordinate:";
                            txtMoveToY.Enabled = true;
                            txtMoveToZ.Enabled = true;
                            break;
                        }
                        case 2: // SO_MOVETO_COORDINATES_DISTANCE_FROM_TARGET
                        {
                            lblMoveToX.Text = "Distance:";
                            txtMoveToY.Enabled = false;
                            txtMoveToZ.Enabled = false;
                            break;
                        }
                    }

                    // movement options and orientation unavailable with speed
                    if (selectedAction.Datalong2 > 0)
                    {
                        txtMoveToO.Enabled = false;
                        grpMoveToOptions.Enabled = false;
                    }
                    else
                    {
                        txtMoveToO.Enabled = true;
                        grpMoveToOptions.Enabled = true;
                    }

                    frmCommandMoveTo.Visible = true;
                    break;
                }
                case 4: // Modify Flags
                {
                    cmbModifyFlagsFieldId.SelectedIndex = GameData.FindIndexOfFlagsField(selectedAction.Datalong);
                    cmbModifyFlagsMode.SelectedIndex = (int)selectedAction.Datalong3;
                    Command4SetCheckboxesBasedOnFlags(selectedAction.Datalong2);
                    Command4SetCheckboxNamesBasedOnFieldIndex(cmbModifyFlagsFieldId.SelectedIndex);
                    frmCommandModifyFlags.Visible = true;
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
                {
                    uint questId = selectedAction.Datalong;
                    if (questId > 0)
                        btnQuestCompleteId.Text = GameData.FindQuestTitle(questId) + " (" + questId.ToString() + ")";
                    txtQuestCompleteDistance.Text = selectedAction.Datalong2.ToString();
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
                {
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
                    cmbSummonCreatureSetRun.SelectedIndex = selectedAction.Dataint;
                    cmbSummonCreatureFacingOptions.SelectedIndex = selectedAction.Dataint2;
                    if ((selectedAction.DataFlags & 16) != 0)
                        chkSummonCreatureFlags16.Checked = true;
                    if ((selectedAction.DataFlags & 32) != 0)
                        chkSummonCreatureFlags32.Checked = true;
                    if ((selectedAction.DataFlags & 64) != 0)
                        chkSummonCreatureFlags64.Checked = true;
                    if (!chkSummonCreatureFlags32.Checked && !chkSummonCreatureFlags64.Checked)
                    {
                        txtSummonCreatureUniqueLimit.Enabled = false;
                        txtSummonCreatureUniqueRange.Enabled = false;
                    }
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
                case 13: // Activate object
                {
                    txtDoorGuid.Visible = false;
                    txtDoorResetDelay.Visible = false;
                    lblDoorGuid.Visible = false;
                    lblDoorResetDelay.Visible = false;
                    lblDoorTooltip.Text = "The source GameObject is used by the provided Unit target. This command has no additional parameters.";
                    frmCommandDoor.Visible = true;
                    break;
                }
                case 14: // Remove Aura
                {
                    uint spellId = selectedAction.Datalong;
                    if (spellId > 0)
                        btnRemoveAuraSpellId.Text = GameData.FindSpellName(spellId) + " (" + spellId.ToString() + ")";
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
                    frmCommandCastSpell.Visible = true;
                    break;
                }
                case 16: // Play Sound
                {
                    txtPlaySoundId.Text = selectedAction.Datalong.ToString();
                    if ((selectedAction.Datalong2 & 1) != 0)
                        chkPlaySoundFlags1.Checked = true;
                    if ((selectedAction.Datalong2 & 2) != 0)
                        chkPlaySoundFlags2.Checked = true;
                    frmCommandPlaySound.Visible = true;
                    break;
                }
                case 17: // Create Item
                {
                    uint itemId = selectedAction.Datalong;
                    if (itemId > 0)
                        btnCreateItemId.Text = GameData.FindItemName(itemId) + " (" + itemId.ToString() + ")";
                    txtCreateItemAmount.Text = selectedAction.Datalong2.ToString();
                    frmCommandCreateItem.Visible = true;
                    break;
                }
                case 18: // Despawn Creture
                {
                    txtDespawnCreatureDelay.Text = selectedAction.Datalong.ToString();
                    frmCommandDespawnCreature.Visible = true;
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
                        case 2: // WAYPOINT_MOTION_TYPE
                        {
                            cmbSetMovementBoolParam.Enabled = true;
                            cmbSetMovementBoolParam.SelectedIndex = (int)selectedAction.Datalong2;
                            lblSetMovementBoolParam.Text = "Repeat:";
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
                    }
                    lblSetMovementBoolParam.Location = new Point(cmbSetMovementBoolParam.Location.X - lblSetMovementBoolParam.Size.Width - 4, lblSetMovementBoolParam.Location.Y);
                    lblSetMovementIntParam.Location = new Point(txtSetMovementIntParam.Location.X - lblSetMovementIntParam.Size.Width - 4, lblSetMovementIntParam.Location.Y);
                    frmCommandSetMovement.Visible = true;
                    break;
                }
                case 21: // Set Active Object
                {
                    cmbActiveObjectSetActive.SelectedIndex = (int)selectedAction.Datalong;
                    frmCommandActiveObject.Visible = true;
                    break;
                }
                case 22: // Set Faction
                {
                    txtSetFactionId.Text = selectedAction.Datalong.ToString();
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
                        lblMorphOrMountTooltip.Text = "Sets the source Creature's display Id to the provided value. Select NONE to restore the Creature's original display Id.";
                    else
                        lblMorphOrMountTooltip.Text = "The source Creature gets mounted to the provided creature or display Id. Select NONE to unmount.";

                    frmCommandMorphOrMount.Visible = true;
                    break;
                }
                case 25: // Set Run
                {
                    cmbSetRunMode.SelectedIndex = (int)selectedAction.Datalong;
                    frmCommandSetRun.Visible = true;
                    break;
                }
                case 26: // Start Attack
                {
                    txtDoorGuid.Visible = false;
                    txtDoorResetDelay.Visible = false;
                    lblDoorGuid.Visible = false;
                    lblDoorResetDelay.Visible = false;
                    lblDoorTooltip.Text = "The source Creature begins attacking the target Unit. This command has no additional parameters.";
                    frmCommandDoor.Visible = true;
                    break;
                }
            }
            dontUpdate = false;
        }
        private void lstActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstActions.SelectedItems.Count == 0)
            {
                ResetAndDisableGeneralForm();
                ResetAndHideCommandSpecificForms();
                return;
            }

            dontUpdate = true;
            ListViewItem selectedItem = lstActions.SelectedItems[0];
            ScriptAction selectedAction = (ScriptAction)selectedItem.Tag;
            
            txtCommandDelay.Text = selectedAction.Delay.ToString();
            txtCommandComment.Text = selectedAction.Comments;
            txtBuddyId.Text = selectedAction.BuddyId.ToString();
            txtBuddyRadius.Text = selectedAction.BuddyRadius.ToString();
            cmbBuddyType.SelectedIndex = (int)selectedAction.BuddyType;
            cmbCommandId.SelectedIndex = (int)selectedAction.Command;

            if ((selectedAction.DataFlags & 1) != 0)
                chkSwapInitial.Checked = true;
            if ((selectedAction.DataFlags & 2) != 0)
                chkSwapFinal.Checked = true;
            if ((selectedAction.DataFlags & 4) != 0)
                chkTargetSelf.Checked = true;
            if ((selectedAction.DataFlags & 8) != 0)
                chkAbortScript.Checked = true;

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
        // Shows an input box that returns a value.
        private static DialogResult ShowInputDialog(ref string input, string name)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = name;
            inputBox.MaximizeBox = false;
            inputBox.MinimizeBox = false;
            inputBox.StartPosition = FormStartPosition.CenterParent;

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }
        // Generic function for setting script field to specified value;
        private void SetScriptFieldFromValue(float fieldvalue, string fieldname)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Get the field we need to change.
                FieldInfo prop = typeof(ScriptAction).GetField(fieldname, BindingFlags.Instance | BindingFlags.Public);

                // Updating the value in the field.
                prop.SetValue(currentAction, Convert.ChangeType(fieldvalue, prop.FieldType));
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

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Get the field we need to change.
                FieldInfo prop = typeof(ScriptAction).GetField(fieldname, BindingFlags.Instance | BindingFlags.Public);

                // Get the old value in this field.
                uint currentValue = (uint)prop.GetValue(currentAction);

                if (chkbox.Checked)
                    currentValue += value;
                else
                    currentValue -= value;

                prop.SetValue(currentAction, Convert.ChangeType(currentValue, prop.FieldType));
            }
        }
        // Generic function for setting a value from another form.
        private void SetScriptFieldFromDataFinderForm<TFinderForm>(Button btn, TextBox txtbox, NameFinder finder, string fieldname) where TFinderForm : FormDataFinder, new()
        {
            FormDataFinder frm = new TFinderForm();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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

        private void cmbBuddyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbBuddyType, "BuddyType", false);
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

        private void txtBuddyId_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtBuddyId, "BuddyId");
        }

        private void txtBuddyRadius_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtBuddyRadius, "BuddyRadius");
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

        private void cmbEmoteId_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbEmoteId, "Datalong", true);
        }

        private void btnActionNew_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();

            ScriptAction action = new ScriptAction(currentScriptId);

            // We show only delay, command id and comment in the listview.
            lvi.Text = action.Delay.ToString();
            lvi.SubItems.Add(action.Command.ToString());
            lvi.SubItems.Add(action.Comments);

            // Save the ScriptAction to the Tag.
            lvi.Tag = action;

            // Add it to the listview.
            lstActions.Items.Add(lvi);
        }

        private void cmbFieldSetFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbFieldSetFields, "Datalong", true);
        }

        private void txtFieldSetValue_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtFieldSetValue, "Datalong2");
        }
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

                switch (coordinatesType)
                {
                    case 0: // SO_MOVETO_COORDINATES_NORMAL
                    case 1: // SO_MOVETO_COORDINATES_RELATIVE_TO_TARGET
                    {
                        lblMoveToX.Text = "X coordinate:";
                        txtMoveToY.Enabled = true;
                        txtMoveToZ.Enabled = true;
                        break;
                    }
                    case 2: // SO_MOVETO_COORDINATES_DISTANCE_FROM_TARGET
                    {
                        lblMoveToX.Text = "Distance:";
                        txtMoveToY.Enabled = false;
                        txtMoveToY.Text = "";
                        currentAction.Y = 0;
                        txtMoveToZ.Enabled = false;
                        txtMoveToZ.Text = "";
                        currentAction.Z = 0;
                        break;
                    }
                }
            }
        }

        private void txtMoveToTime_Leave(object sender, EventArgs e)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                dontUpdate = true;

                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                uint speed;
                if (!UInt32.TryParse(txtMoveToTime.Text, out speed))
                    txtMoveToTime.Text = "";

                // Updating orientation.
                currentAction.Datalong2 = speed;

                // Orientation and movement options cannot be used with speed.
                if (speed > 0)
                {
                    txtMoveToO.Enabled = false;
                    txtMoveToO.Text = "";
                    currentAction.O = 0;

                    grpMoveToOptions.Enabled = false;
                    currentAction.Datalong3 = 0;
                    chkMoveOptions1.Checked = false;
                    chkMoveOptions2.Checked = false;
                    chkMoveOptions4.Checked = false;
                    chkMoveOptions8.Checked = false;
                    chkMoveOptions16.Checked = false;
                    chkMoveOptions32.Checked = false;
                    chkMoveOptions64.Checked = false;
                    chkMoveOptions128.Checked = false;
                    chkMoveOptions256.Checked = false;
                }
                else
                {
                    txtMoveToO.Enabled = true;
                    grpMoveToOptions.Enabled = true;
                }

                dontUpdate = false;
            }
        }

        private void Command4ResetAllCheckboxes()
        {
            chkModifyFlags1.Checked = false;
            chkModifyFlags2.Checked = false;
            chkModifyFlags4.Checked = false;
            chkModifyFlags8.Checked = false;
            chkModifyFlags16.Checked = false;
            chkModifyFlags32.Checked = false;
            chkModifyFlags64.Checked = false;
            chkModifyFlags128.Checked = false;
            chkModifyFlags256.Checked = false;
            chkModifyFlags512.Checked = false;
            chkModifyFlags1024.Checked = false;
            chkModifyFlags2048.Checked = false;
            chkModifyFlags4096.Checked = false;
            chkModifyFlags8192.Checked = false;
            chkModifyFlags16384.Checked = false;
            chkModifyFlags32768.Checked = false;
            chkModifyFlags65536.Checked = false;
            chkModifyFlags131072.Checked = false;
            chkModifyFlags262144.Checked = false;
            chkModifyFlags524288.Checked = false;
            chkModifyFlags1048576.Checked = false;
            chkModifyFlags2097152.Checked = false;
            chkModifyFlags4194304.Checked = false;
            chkModifyFlags8388608.Checked = false;
            chkModifyFlags16777216.Checked = false;
            chkModifyFlags33554432.Checked = false;
            chkModifyFlags67108864.Checked = false;
            chkModifyFlags134217728.Checked = false;
            chkModifyFlags268435456.Checked = false;
            chkModifyFlags536870912.Checked = false;
            chkModifyFlags1.Visible = false;
            chkModifyFlags2.Visible = false;
            chkModifyFlags4.Visible = false;
            chkModifyFlags8.Visible = false;
            chkModifyFlags16.Visible = false;
            chkModifyFlags32.Visible = false;
            chkModifyFlags64.Visible = false;
            chkModifyFlags128.Visible = false;
            chkModifyFlags256.Visible = false;
            chkModifyFlags512.Visible = false;
            chkModifyFlags1024.Visible = false;
            chkModifyFlags2048.Visible = false;
            chkModifyFlags4096.Visible = false;
            chkModifyFlags8192.Visible = false;
            chkModifyFlags16384.Visible = false;
            chkModifyFlags32768.Visible = false;
            chkModifyFlags65536.Visible = false;
            chkModifyFlags131072.Visible = false;
            chkModifyFlags262144.Visible = false;
            chkModifyFlags524288.Visible = false;
            chkModifyFlags1048576.Visible = false;
            chkModifyFlags2097152.Visible = false;
            chkModifyFlags4194304.Visible = false;
            chkModifyFlags8388608.Visible = false;
            chkModifyFlags16777216.Visible = false;
            chkModifyFlags33554432.Visible = false;
            chkModifyFlags67108864.Visible = false;
            chkModifyFlags134217728.Visible = false;
            chkModifyFlags268435456.Visible = false;
            chkModifyFlags536870912.Visible = false;
        }
        private void Command4SetCheckboxesBasedOnFlags(uint flags)
        {
            if ((flags & 1) != 0)
                chkModifyFlags1.Checked = true;
            if ((flags & 2) != 0)
                chkModifyFlags2.Checked = true;
            if ((flags & 4) != 0)
                chkModifyFlags4.Checked = true;
            if ((flags & 8) != 0)
                chkModifyFlags8.Checked = true;
            if ((flags & 16) != 0)
                chkModifyFlags16.Checked = true;
            if ((flags & 32) != 0)
                chkModifyFlags32.Checked = true;
            if ((flags & 64) != 0)
                chkModifyFlags64.Checked = true;
            if ((flags & 128) != 0)
                chkModifyFlags128.Checked = true;
            if ((flags & 256) != 0)
                chkModifyFlags256.Checked = true;
            if ((flags & 512) != 0)
                chkModifyFlags512.Checked = true;
            if ((flags & 1024) != 0)
                chkModifyFlags1024.Checked = true;
            if ((flags & 2048) != 0)
                chkModifyFlags2048.Checked = true;
            if ((flags & 4096) != 0)
                chkModifyFlags4096.Checked = true;
            if ((flags & 8192) != 0)
                chkModifyFlags8192.Checked = true;
            if ((flags & 16384) != 0)
                chkModifyFlags16384.Checked = true;
            if ((flags & 32768) != 0)
                chkModifyFlags32768.Checked = true;
            if ((flags & 65536) != 0)
                chkModifyFlags65536.Checked = true;
            if ((flags & 131072) != 0)
                chkModifyFlags131072.Checked = true;
            if ((flags & 262144) != 0)
                chkModifyFlags262144.Checked = true;
            if ((flags & 524288) != 0)
                chkModifyFlags524288.Checked = true;
            if ((flags & 1048576) != 0)
                chkModifyFlags1048576.Checked = true;
            if ((flags & 2097152) != 0)
                chkModifyFlags2097152.Checked = true;
            if ((flags & 4194304) != 0)
                chkModifyFlags4194304.Checked = true;
            if ((flags & 8388608) != 0)
                chkModifyFlags8388608.Checked = true;
            if ((flags & 16777216) != 0)
                chkModifyFlags16777216.Checked = true;
            if ((flags & 33554432) != 0)
                chkModifyFlags33554432.Checked = true;
            if ((flags & 67108864) != 0)
                chkModifyFlags67108864.Checked = true;
            if ((flags & 134217728) != 0)
                chkModifyFlags134217728.Checked = true;
            if ((flags & 268435456) != 0)
                chkModifyFlags268435456.Checked = true;
            if ((flags & 536870912) != 0)
                chkModifyFlags536870912.Checked = true;
        }

        private void Command4SetCheckboxNamesBasedOnFieldIndex(int field)
        {
            switch (field)
            {
                case 0: // GAMEOBJECT_FLAGS
                {
                    chkModifyFlags1.Text = "IN_USE";
                    chkModifyFlags1.Visible = true;
                    chkModifyFlags2.Text = "LOCKED";
                    chkModifyFlags2.Visible = true;
                    chkModifyFlags4.Text = "INTERACT_COND";
                    chkModifyFlags4.Visible = true;
                    chkModifyFlags8.Text = "TRANSPORT";
                    chkModifyFlags8.Visible = true;
                    chkModifyFlags16.Text = "NO_INTERACT";
                    chkModifyFlags16.Visible = true;
                    chkModifyFlags32.Text = "NODESPAWN";
                    chkModifyFlags32.Visible = true;
                    chkModifyFlags64.Text = "TRIGGERED";
                    chkModifyFlags64.Visible = true;
                    break;
                }
                case 1: // GAMEOBJECT_DYN_FLAGS
                {
                    chkModifyFlags1.Text = "ACTIVATE";
                    chkModifyFlags1.Visible = true;
                    chkModifyFlags2.Text = "ANIMATE";
                    chkModifyFlags2.Visible = true;
                    chkModifyFlags4.Text = "NO_INTERACT";
                    chkModifyFlags4.Visible = true;
                    break;
                }
                case 2: // ITEM_FIELD_FLAGS
                {
                    chkModifyFlags1.Text = "BINDED";
                    chkModifyFlags1.Visible = true;
                    chkModifyFlags2.Text = "UNK1";
                    chkModifyFlags2.Visible = true;
                    chkModifyFlags4.Text = "UNLOCKED";
                    chkModifyFlags4.Visible = true;
                    chkModifyFlags8.Text = "WRAPPED";
                    chkModifyFlags8.Visible = true;
                    chkModifyFlags16.Text = "UNK4";
                    chkModifyFlags16.Visible = true;
                    chkModifyFlags32.Text = "UNK5";
                    chkModifyFlags32.Visible = true;
                    chkModifyFlags64.Text = "UNK6";
                    chkModifyFlags64.Visible = true;
                    chkModifyFlags128.Text = "UNK7";
                    chkModifyFlags128.Visible = true;
                    chkModifyFlags256.Text = "UNK8";
                    chkModifyFlags256.Visible = true;
                    chkModifyFlags512.Text = "READABLE";
                    chkModifyFlags512.Visible = true;
                    chkModifyFlags1024.Text = "UNK10";
                    chkModifyFlags1024.Visible = true;
                    chkModifyFlags2048.Text = "UNK11";
                    chkModifyFlags2048.Visible = true;
                    chkModifyFlags4096.Text = "UNK12";
                    chkModifyFlags4096.Visible = true;
                    chkModifyFlags8192.Text = "UNK13";
                    chkModifyFlags8192.Visible = true;
                    chkModifyFlags16384.Text = "UNK14";
                    chkModifyFlags16384.Visible = true;
                    chkModifyFlags32768.Text = "UNK15";
                    chkModifyFlags32768.Visible = true;
                    chkModifyFlags65536.Text = "UNK16";
                    chkModifyFlags65536.Visible = true;
                    chkModifyFlags131072.Text = "UNK17";
                    chkModifyFlags131072.Visible = true;
                    break;
                }
                case 3: // CORPSE_FIELD_FLAGS
                {
                    chkModifyFlags1.Text = "BONES";
                    chkModifyFlags1.Visible = true;
                    chkModifyFlags2.Text = "UNK1";
                    chkModifyFlags2.Visible = true;
                    chkModifyFlags4.Text = "UNK2";
                    chkModifyFlags4.Visible = true;
                    chkModifyFlags8.Text = "HIDE_HELM";
                    chkModifyFlags8.Visible = true;
                    chkModifyFlags16.Text = "HIDE_CLOAK";
                    chkModifyFlags16.Visible = true;
                    chkModifyFlags32.Text = "LOOTABLE";
                    chkModifyFlags32.Visible = true;
                    break;
                }
                case 4: // CORPSE_FIELD_DYNAMIC_FLAGS
                {
                    chkModifyFlags1.Text = "LOOTABLE";
                    chkModifyFlags1.Visible = true;
                    break;
                }
                case 5: // UNIT_FIELD_FLAGS
                {
                    chkModifyFlags1.Text = "UNK_0";
                    chkModifyFlags1.Visible = true;
                    chkModifyFlags2.Text = "NON_ATTACKABLE";
                    chkModifyFlags2.Visible = true;
                    chkModifyFlags4.Text = "DISABLE_MOVE";
                    chkModifyFlags4.Visible = true;
                    chkModifyFlags8.Text = "PVP_ATTACKABLE";
                    chkModifyFlags8.Visible = true;
                    chkModifyFlags16.Text = "PET_RENAME";
                    chkModifyFlags16.Visible = true;
                    chkModifyFlags32.Text = "PET_ABANDON";
                    chkModifyFlags32.Visible = true;
                    chkModifyFlags64.Text = "UNK_6";
                    chkModifyFlags64.Visible = true;
                    chkModifyFlags128.Text = "NOT_ATTACKABLE_1";
                    chkModifyFlags128.Visible = true;
                    chkModifyFlags256.Text = "OOC_NOT_ATTACKABLE";
                    chkModifyFlags256.Visible = true;
                    chkModifyFlags512.Text = "PASSIVE";
                    chkModifyFlags512.Visible = true;
                    chkModifyFlags1024.Text = "LOOTING";
                    chkModifyFlags1024.Visible = true;
                    chkModifyFlags2048.Text = "PET_IN_COMBAT";
                    chkModifyFlags2048.Visible = true;
                    chkModifyFlags4096.Text = "PVP";
                    chkModifyFlags4096.Visible = true;
                    chkModifyFlags8192.Text = "SILENCED";
                    chkModifyFlags8192.Visible = true;
                    chkModifyFlags16384.Text = "UNK_14";
                    chkModifyFlags16384.Visible = true;
                    chkModifyFlags32768.Text = "USE_SWIM_ANIMATION";
                    chkModifyFlags32768.Visible = true;
                    chkModifyFlags65536.Text = "UNK_16";
                    chkModifyFlags65536.Visible = true;
                    chkModifyFlags131072.Text = "PACIFIED";
                    chkModifyFlags131072.Visible = true;
                    chkModifyFlags262144.Text = "DISABLE_ROTATE";
                    chkModifyFlags262144.Visible = true;
                    chkModifyFlags524288.Text = "IN_COMBAT";
                    chkModifyFlags524288.Visible = true;
                    chkModifyFlags1048576.Text = "TAXI_FLIGHT";
                    chkModifyFlags1048576.Visible = true;
                    chkModifyFlags2097152.Text = "DISARMED";
                    chkModifyFlags2097152.Visible = true;
                    chkModifyFlags4194304.Text = "CONFUSED";
                    chkModifyFlags4194304.Visible = true;
                    chkModifyFlags8388608.Text = "FLEEING";
                    chkModifyFlags8388608.Visible = true;
                    chkModifyFlags16777216.Text = "PLAYER_CONTROLLED";
                    chkModifyFlags16777216.Visible = true;
                    chkModifyFlags33554432.Text = "NOT_SELECTABLE";
                    chkModifyFlags33554432.Visible = true;
                    chkModifyFlags67108864.Text = "SKINNABLE";
                    chkModifyFlags67108864.Visible = true;
                    chkModifyFlags134217728.Text = "AURAS_VISIBLE";
                    chkModifyFlags134217728.Visible = true;
                    chkModifyFlags268435456.Text = "UNK_28";
                    chkModifyFlags268435456.Visible = true;
                    chkModifyFlags536870912.Text = "UNK_29";
                    chkModifyFlags536870912.Visible = true;
                    break;
                }
                case 6: // UNIT_DYNAMIC_FLAGS
                {
                    chkModifyFlags1.Text = "LOOTABLE";
                    chkModifyFlags1.Visible = true;
                    chkModifyFlags2.Text = "TRACK_UNIT";
                    chkModifyFlags2.Visible = true;
                    chkModifyFlags4.Text = "TAPPED";
                    chkModifyFlags4.Visible = true;
                    chkModifyFlags8.Text = "TAPPED_BY_PLAYER";
                    chkModifyFlags8.Visible = true;
                    chkModifyFlags16.Text = "SPECIALINFO";
                    chkModifyFlags16.Visible = true;
                    chkModifyFlags32.Text = "DEAD";
                    chkModifyFlags32.Visible = true;
                    break;
                }
                case 7: // UNIT_NPC_FLAGS
                {
                    chkModifyFlags1.Text = "GOSSIP";
                    chkModifyFlags1.Visible = true;
                    chkModifyFlags2.Text = "QUESTGIVER";
                    chkModifyFlags2.Visible = true;
                    chkModifyFlags4.Text = "VENDOR";
                    chkModifyFlags4.Visible = true;
                    chkModifyFlags8.Text = "FLIGHTMASTER";
                    chkModifyFlags8.Visible = true;
                    chkModifyFlags16.Text = "TRAINER";
                    chkModifyFlags16.Visible = true;
                    chkModifyFlags32.Text = "SPIRITHEALER";
                    chkModifyFlags32.Visible = true;
                    chkModifyFlags64.Text = "SPIRITGUIDE";
                    chkModifyFlags64.Visible = true;
                    chkModifyFlags128.Text = "INNKEEPER";
                    chkModifyFlags128.Visible = true;
                    chkModifyFlags256.Text = "BANKER";
                    chkModifyFlags256.Visible = true;
                    chkModifyFlags512.Text = "PETITIONER";
                    chkModifyFlags512.Visible = true;
                    chkModifyFlags1024.Text = "TABARDDESIGNER";
                    chkModifyFlags1024.Visible = true;
                    chkModifyFlags2048.Text = "BATTLEMASTER";
                    chkModifyFlags2048.Visible = true;
                    chkModifyFlags4096.Text = "AUCTIONEER";
                    chkModifyFlags4096.Visible = true;
                    chkModifyFlags8192.Text = "STABLEMASTER";
                    chkModifyFlags8192.Visible = true;
                    chkModifyFlags16384.Text = "REPAIR";
                    chkModifyFlags16384.Visible = true;
                    break;
                }
                case 8: // PLAYER_FLAGS
                {
                    chkModifyFlags1.Text = "GROUP_LEADER";
                    chkModifyFlags1.Visible = true;
                    chkModifyFlags2.Text = "AFK";
                    chkModifyFlags2.Visible = true;
                    chkModifyFlags4.Text = "DND";
                    chkModifyFlags4.Visible = true;
                    chkModifyFlags8.Text = "GM";
                    chkModifyFlags8.Visible = true;
                    chkModifyFlags16.Text = "GHOST";
                    chkModifyFlags16.Visible = true;
                    chkModifyFlags32.Text = "RESTING";
                    chkModifyFlags32.Visible = true;
                    chkModifyFlags64.Text = "UNK7";
                    chkModifyFlags64.Visible = true;
                    chkModifyFlags128.Text = "FFA_PVP";
                    chkModifyFlags128.Visible = true;
                    chkModifyFlags256.Text = "CONTESTED_PVP";
                    chkModifyFlags256.Visible = true;
                    chkModifyFlags512.Text = "IN_PVP";
                    chkModifyFlags512.Visible = true;
                    chkModifyFlags1024.Text = "HIDE_HELM";
                    chkModifyFlags1024.Visible = true;
                    chkModifyFlags2048.Text = "HIDE_CLOAK";
                    chkModifyFlags2048.Visible = true;
                    chkModifyFlags4096.Text = "PARTIAL_PLAY_TIME";
                    chkModifyFlags4096.Visible = true;
                    chkModifyFlags8192.Text = "NO_PLAY_TIME";
                    chkModifyFlags8192.Visible = true;
                    chkModifyFlags16384.Text = "UNK15";
                    chkModifyFlags16384.Visible = true;
                    chkModifyFlags32768.Text = "UNK16";
                    chkModifyFlags32768.Visible = true;
                    chkModifyFlags65536.Text = "SANCTUARY";
                    chkModifyFlags65536.Visible = true;
                    chkModifyFlags131072.Text = "TAXI_BENCHMARK";
                    chkModifyFlags131072.Visible = true;
                    chkModifyFlags262144.Text = "PVP_TIMER";
                    chkModifyFlags262144.Visible = true;
                    break;
                }
            }
        }

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

        private void btnQuestCompleteId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormQuestFinder>(btnQuestCompleteId, null, GameData.FindQuestTitle, "Datalong");
        }

        private void txtQuestCompleteDistance_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtQuestCompleteDistance, "Datalong2");
        }

        private void cmbKillCreditType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbKillCreditType, "Datalong2", false);
        }
        
        private void btnKillCreditCreatureId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormCreatureFinder>(btnKillCreditCreatureId, null, GameData.FindCreatureName, "Datalong");
        }

        private void txtRespawnGameobjectDelay_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtRespawnGameobjectDelay, "Datalong2");
        }

        private void txtRespawnGameobjectGuid_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtRespawnGameobjectGuid, "Datalong");
        }

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

        private void cmbSummonCreatureFacingOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Facing Options = Dataint2
                currentAction.Dataint2 = cmbSummonCreatureFacingOptions.SelectedIndex;

                // If facing source/target orientation is not needed.
                if (cmbSummonCreatureFacingOptions.SelectedIndex > 0)
                {
                    currentAction.O = 0;
                    txtSummonCreatureO.Text = "0";
                    txtSummonCreatureO.Enabled = false;
                }
                else
                    txtSummonCreatureO.Enabled = true;
            }
        }

        private void cmbSummonCreatureSetRun_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSummonCreatureSetRun, "Dataint", false);
        }

        private void txtSummonCreatureUniqueLimit_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSummonCreatureUniqueLimit, "Datalong3");
        }

        private void txtSummonCreatureUniqueRange_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSummonCreatureUniqueRange, "Datalong4");
        }

        private void chkSummonCreatureFlags16_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkSummonCreatureFlags16, "DataFlags", 16);
        }

        private void chkSummonCreatureFlags32_CheckedChanged(object sender, EventArgs e)
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
                if (chkSummonCreatureFlags32.Checked)
                {
                    currentAction.DataFlags += 32;
                    chkSummonCreatureFlags64.Checked = false;
                    txtSummonCreatureUniqueLimit.Enabled = true;
                    txtSummonCreatureUniqueRange.Enabled = true;
                }
                else
                {
                    currentAction.DataFlags -= 32;
                    if (!chkSummonCreatureFlags64.Checked)
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

        private void chkSummonCreatureFlags64_CheckStateChanged(object sender, EventArgs e)
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
                if (chkSummonCreatureFlags64.Checked)
                {
                    currentAction.DataFlags += 64;
                    chkSummonCreatureFlags32.Checked = false;
                    txtSummonCreatureUniqueLimit.Enabled = true;
                    txtSummonCreatureUniqueRange.Enabled = true;
                }
                else
                {
                    currentAction.DataFlags -= 64;
                    if (!chkSummonCreatureFlags32.Checked)
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

        private void txtDoorGuid_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtDoorGuid, "Datalong");
        }

        private void txtDoorResetDelay_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtDoorResetDelay, "Datalong2");
        }
        private void btnRemoveAuraSpellId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormSpellFinder>(btnRemoveAuraSpellId, null, GameData.FindSpellName, "Datalong");
        }

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

        private void txtPlaySoundId_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtPlaySoundId, "Datalong");
        }

        private void chkPlaySoundFlags1_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkPlaySoundFlags1, "Datalong2", 1);
        }

        private void chkPlaySoundFlags2_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkPlaySoundFlags2, "Datalong2", 2);
        }

        private void btnCreateItemId_Click(object sender, EventArgs e)
        {
            SetScriptFieldFromDataFinderForm<FormItemFinder>(btnCreateItemId, null, GameData.FindItemName, "Datalong");
        }

        private void txtCreateItemAmount_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtCreateItemAmount, "Datalong2");
        }

        private void txtDespawnCreatureDelay_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtDespawnCreatureDelay, "Datalong");
        }

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

                // Reseting script action data.
                currentAction.Datalong2 = 0;
                currentAction.Datalong3 = 0;
                currentAction.X = 0;
                currentAction.O = 0;


                switch (selection)
                {
                    case 2: // WAYPOINT_MOTION_TYPE
                    {
                        cmbSetMovementBoolParam.Enabled = true;
                        cmbSetMovementBoolParam.SelectedIndex = 0;
                        lblSetMovementBoolParam.Text = "Repeat:";
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

        private void cmbActiveObjectSetActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbActiveObjectSetActive, "Datalong", false);
        }

        private void txtSetFactionId_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSetFactionId, "Datalong");
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

        private void btnMorphOrMountId_Click(object sender, EventArgs e)
        {
            if (cmbMorphOrMountType.SelectedIndex == 0) // Creature Id
                SetScriptFieldFromDataFinderForm<FormCreatureFinder>(btnMorphOrMountId, null, GameData.FindCreatureName, "Datalong");
            else // Display Id
            {
                string id = "";
                DialogResult result = ShowInputDialog(ref id, "Display Id");
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

        private void cmbSetRunMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSetRunMode, "Datalong", false);
        }

        private void cmbModifyFlagsFieldId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            SetScriptFieldFromCombobox(cmbModifyFlagsFieldId, "Datalong", true);
            Command4ResetAllCheckboxes();
            Command4SetCheckboxNamesBasedOnFieldIndex(cmbModifyFlagsFieldId.SelectedIndex);
            SetScriptFieldFromValue(0, "Datalong2");
        }

        private void cmbModifyFlagsMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbModifyFlagsMode, "Datalong3", false);
        }

        private void chkModifyFlags1_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags1, "Datalong2", 1);
        }

        private void chkModifyFlags2_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags2, "Datalong2", 2);
        }

        private void chkModifyFlags4_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags4, "Datalong2", 4);
        }

        private void chkModifyFlags8_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags8, "Datalong2", 8);
        }

        private void chkModifyFlags16_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags16, "Datalong2", 16);
        }

        private void chkModifyFlags32_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags32, "Datalong2", 32);
        }

        private void chkModifyFlags64_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags64, "Datalong2", 64);
        }

        private void chkModifyFlags128_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags128, "Datalong2", 128);
        }

        private void chkModifyFlags256_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags256, "Datalong2", 256);
        }

        private void chkModifyFlags512_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags512, "Datalong2", 512);
        }

        private void chkModifyFlags1024_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags1024, "Datalong2", 1024);
        }

        private void chkModifyFlags2048_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags2048, "Datalong2", 2048);
        }

        private void chkModifyFlags4096_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags4096, "Datalong2", 4096);
        }

        private void chkModifyFlags8192_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags8192, "Datalong2", 8192);
        }

        private void chkModifyFlags16384_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags16384, "Datalong2", 16384);
        }

        private void chkModifyFlags32768_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags32768, "Datalong2", 32768);
        }

        private void chkModifyFlags65536_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags65536, "Datalong2", 65536);
        }

        private void chkModifyFlags131072_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags131072, "Datalong2", 131072);
        }

        private void chkModifyFlags262144_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags262144, "Datalong2", 262144);
        }

        private void chkModifyFlags524288_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags524288, "Datalong2", 524288);
        }

        private void chkModifyFlags1048576_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags1048576, "Datalong2", 1048576);
        }

        private void chkModifyFlags2097152_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags2097152, "Datalong2", 2097152);
        }

        private void chkModifyFlags4194304_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags4194304, "Datalong2", 4194304);
        }

        private void chkModifyFlags8388608_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags8388608, "Datalong2", 8388608);
        }

        private void chkModifyFlags16777216_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags16777216, "Datalong2", 16777216);
        }

        private void chkModifyFlags33554432_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags33554432, "Datalong2", 33554432);
        }

        private void chkModifyFlags67108864_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags67108864, "Datalong2", 67108864);
        }

        private void chkModifyFlags134217728_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags134217728, "Datalong2", 134217728);
        }

        private void chkModifyFlags268435456_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags268435456, "Datalong2", 268435456);
        }

        private void chkModifyFlags536870912_CheckedChanged(object sender, EventArgs e)
        {
            SetScriptFlagsFromCheckbox(chkModifyFlags536870912, "Datalong2", 536870912);
        }
    }

    // Sorts items in the script actions listbox by delay.
    class ActionSorter : System.Collections.IComparer
    {
        public int Column = 0;
        public System.Windows.Forms.SortOrder Order = SortOrder.Ascending;
        public int Compare(object x, object y) // IComparer Member
        {
            if (!(x is ListViewItem))
                return (0);
            if (!(y is ListViewItem))
                return (0);

            ListViewItem l1 = (ListViewItem)x;
            ListViewItem l2 = (ListViewItem)y;

            int value1;
            int value2;

            Int32.TryParse(l1.SubItems[Column].Text, out value1);
            Int32.TryParse(l2.SubItems[Column].Text, out value2);

            if (Order == SortOrder.Ascending)
            {
                return value1.CompareTo(value2);
            }
            else
            {
                return value2.CompareTo(value1);
            }
        }
    }
}
