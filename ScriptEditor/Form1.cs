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

            // Assign maps list to a combo box.
            cmbTeleportMap.DataSource = GameData.MapsList;

            // Add options to Move To Coordinates Type combo box.
            cmbMoveToType.Items.Add(new ComboboxPair("Normal coordinates", 0));
            cmbMoveToType.Items.Add(new ComboboxPair("Relative to target", 1));
            cmbMoveToType.Items.Add(new ComboboxPair("Distance from target", 2));

            // Add options to Kill Credit Type combo box.
            cmbKillCreditType.Items.Add(new ComboboxPair("Personal credit", 0));
            cmbKillCreditType.Items.Add(new ComboboxPair("Group credit", 1));

            // Setting default selection for combo boxes.
            cmbSummonCreatureFacingOptions.SelectedIndex = 0;
            cmbSummonCreatureSetRun.SelectedIndex = 0;
            cmbTable.SelectedIndex = 0;

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

            // Field Set Command (2), Flag Set Command (4), Flag Remove Command (5)
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
                case 4: // Flag Set
                case 5: // Flag Remove
                {
                    txtFieldSetValue.Text = selectedAction.Datalong2.ToString();
                    
                    switch (selectedAction.Command)
                    {
                        case 2:
                        {
                            lblFieldSetTooltip.Text = "Sets the chosen update field to the value specified. Can be used on any object, but the fields are different based on the type. Only use if you know what you are doing.";
                            cmbFieldSetFields.DataSource = GameData.UpdateFieldsList;
                            cmbFieldSetFields.SelectedIndex = GameData.FindIndexOfUpdateField(selectedAction.Datalong);
                            break;
                        }
                        case 4:
                        {
                            lblFieldSetTooltip.Text = "Toggles on the specified flags on the chosen field. Can be used on any object, but the fields are different based on the type.";
                            cmbFieldSetFields.DataSource = GameData.FlagFieldsList;
                            cmbFieldSetFields.SelectedIndex = GameData.FindIndexOfFlagsField(selectedAction.Datalong);
                            break;
                        }
                        case 5:
                        {
                            lblFieldSetTooltip.Text = "Toggles off the specified flags on the chosen field. Can be used on any object, but the fields are different based on the type.";
                            cmbFieldSetFields.DataSource = GameData.FlagFieldsList;
                            cmbFieldSetFields.SelectedIndex = GameData.FindIndexOfFlagsField(selectedAction.Datalong);
                            break;
                        }
                    }
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

        private void btnTalkText1_Click(object sender, EventArgs e)
        {
            FormTextFinder frm = new FormTextFinder();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uint textId = frm.ReturnValue;
                if (textId > 0)
                    btnTalkText1.Text = textId.ToString();
                else
                {
                    btnTalkText1.Text = "-NONE-";
                    txtTalkText1.Text = "";
                }

                if (lstActions.SelectedItems.Count > 0)
                {
                    // Get the selected item in the listview.
                    ListViewItem currentItem = lstActions.SelectedItems[0];

                    // Get the associated ScriptAction.
                    ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                    // TextId1 = dataint;
                    currentAction.Dataint = (int)textId;
                    txtTalkText1.Text = GameData.FindTextWithId(textId);
                }

            }

        }

        private void btnTalkText2_Click(object sender, EventArgs e)
        {
            FormTextFinder frm = new FormTextFinder();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uint textId = frm.ReturnValue;
                if (textId > 0)
                    btnTalkText2.Text = textId.ToString();
                else
                {
                    btnTalkText2.Text = "-NONE-";
                    txtTalkText2.Text = "";
                }

                if (lstActions.SelectedItems.Count > 0)
                {
                    // Get the selected item in the listview.
                    ListViewItem currentItem = lstActions.SelectedItems[0];

                    // Get the associated ScriptAction.
                    ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                    // TextId2 = dataint2;
                    currentAction.Dataint2 = (int)textId;
                    txtTalkText2.Text = GameData.FindTextWithId(textId);
                }

            }
        }

        private void btnTalkText3_Click(object sender, EventArgs e)
        {
            FormTextFinder frm = new FormTextFinder();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uint textId = frm.ReturnValue;
                if (textId > 0)
                    btnTalkText3.Text = textId.ToString();
                else
                {
                    btnTalkText3.Text = "-NONE-";
                    txtTalkText3.Text = "";
                }

                if (lstActions.SelectedItems.Count > 0)
                {
                    // Get the selected item in the listview.
                    ListViewItem currentItem = lstActions.SelectedItems[0];

                    // Get the associated ScriptAction.
                    ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                    // TextId3 = dataint3;
                    currentAction.Dataint3 = (int)textId;
                    txtTalkText3.Text = GameData.FindTextWithId(textId);
                }

            }
        }

        private void btnTalkText4_Click(object sender, EventArgs e)
        {
            FormTextFinder frm = new FormTextFinder();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uint textId = frm.ReturnValue;
                if (textId > 0)
                    btnTalkText4.Text = textId.ToString();
                else
                {
                    btnTalkText4.Text = "-NONE-";
                    txtTalkText4.Text = "";
                }

                if (lstActions.SelectedItems.Count > 0)
                {
                    // Get the selected item in the listview.
                    ListViewItem currentItem = lstActions.SelectedItems[0];

                    // Get the associated ScriptAction.
                    ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                    // TextId4 = dataint4;
                    currentAction.Dataint4 = (int)textId;
                    txtTalkText4.Text = GameData.FindTextWithId(textId);
                }

            }
        }

        private void cmbTalkChatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // ChatType = datalong
                currentAction.Datalong = (uint)cmbTalkChatType.SelectedIndex;
            }
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
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Updating buddy type.
                currentAction.BuddyType = (uint)cmbBuddyType.SelectedIndex;
            }
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
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                uint buddyId;
                UInt32.TryParse(txtBuddyId.Text, out buddyId);

                // Updating buddy id.
                currentAction.BuddyId = buddyId;
            }
        }

        private void txtBuddyRadius_Leave(object sender, EventArgs e)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                uint buddyRadius;
                UInt32.TryParse(txtBuddyRadius.Text, out buddyRadius);

                // Updating buddy search radius.
                currentAction.BuddyRadius = buddyRadius;
            }
        }

        private void SetDataFlagsFromCheckbox(CheckBox ctrl, uint value)
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
                if (ctrl.Checked)
                    currentAction.DataFlags += value;
                else
                    currentAction.DataFlags -= value;
            }
        }

        private void chkSwapInitial_CheckedChanged(object sender, EventArgs e)
        {
            SetDataFlagsFromCheckbox(chkSwapInitial, 1);
        }

        private void chkSwapFinal_CheckedChanged(object sender, EventArgs e)
        {
            SetDataFlagsFromCheckbox(chkSwapFinal, 2);
        }

        private void chkTargetSelf_CheckedChanged(object sender, EventArgs e)
        {
            SetDataFlagsFromCheckbox(chkTargetSelf, 4);
        }

        private void chkAbortScript_CheckedChanged(object sender, EventArgs e)
        {
            SetDataFlagsFromCheckbox(chkAbortScript, 8);
        }

        private void cmbEmoteId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Updating emote id.
                currentAction.Datalong = (uint)(cmbEmoteId.SelectedItem as ComboboxPair).Value;
            }
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
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Updating field id.
                currentAction.Datalong = (uint)(cmbFieldSetFields.SelectedItem as ComboboxPair).Value;
            }
        }

        // Generic function for setting datalong value from a textbox.
        private void SetDatalongFromTextbox(TextBox ctrl)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                uint fieldValue;
                UInt32.TryParse(ctrl.Text, out fieldValue);

                // Updating datalong value.
                currentAction.Datalong = fieldValue;
            }
        }
        private void SetDatalong2FromTextbox(TextBox ctrl)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                uint fieldValue;
                UInt32.TryParse(ctrl.Text, out fieldValue);

                // Updating datalong2 value.
                currentAction.Datalong2 = fieldValue;
            }
        }

        private void SetDatalong3FromTextbox(TextBox ctrl)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                uint fieldValue;
                UInt32.TryParse(ctrl.Text, out fieldValue);

                // Updating datalong3 value.
                currentAction.Datalong3 = fieldValue;
            }
        }

        private void SetDatalong4FromTextbox(TextBox ctrl)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                uint fieldValue;
                UInt32.TryParse(ctrl.Text, out fieldValue);

                // Updating datalong4 value.
                currentAction.Datalong4 = fieldValue;
            }
        }

        private void txtFieldSetValue_Leave(object sender, EventArgs e)
        {
            SetDatalong2FromTextbox(txtFieldSetValue);
        }

        private void SetCoordinateX(TextBox ctrl)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                float xCoordinate;
                float.TryParse(ctrl.Text, out xCoordinate);

                // Updating X coordinate.
                currentAction.X = xCoordinate;
            }
        }
        private void txtMoveToX_Leave(object sender, EventArgs e)
        {
            SetCoordinateX(txtMoveToX);
        }

        private void SetCoordinateY(TextBox ctrl)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                float yCoordinate;
                float.TryParse(ctrl.Text, out yCoordinate);

                // Updating Y coordinate.
                currentAction.Y = yCoordinate;
            }
        }

        private void txtMoveToY_Leave(object sender, EventArgs e)
        {
            SetCoordinateY(txtMoveToY);
        }

        private void SetCoordinateZ(TextBox ctrl)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                float zCoordinate;
                float.TryParse(ctrl.Text, out zCoordinate);

                // Updating Z coordinate.
                currentAction.Z = zCoordinate;
            }
        }

        private void txtMoveToZ_Leave(object sender, EventArgs e)
        {
            SetCoordinateZ(txtMoveToZ);
        }

        private void SetCoordinateO(TextBox ctrl)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                float oCoordinate;
                float.TryParse(ctrl.Text, out oCoordinate);

                // Updating orientation.
                currentAction.O = oCoordinate;
            }
        }

        private void txtMoveToO_Leave(object sender, EventArgs e)
        {
            SetCoordinateO(txtMoveToO);
        }

        private void chkMoveToFlagsForce_CheckedChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // datalong4 = eMoveToFlags
                if (chkMoveToFlagsForce.Checked)
                    currentAction.Datalong4 += 1;
                else
                    currentAction.Datalong4 -= 1;
            }
        }

        // Generic function for updating flags in datalong based on checkbox.
        private void SetDatalong3FlagsFromCheckbox(CheckBox ctrl, uint value)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                if (ctrl.Checked)
                    currentAction.Datalong3 += value;
                else
                    currentAction.Datalong3 -= value;
            }
        }

        private void SetDatalong2FlagsFromCheckbox(CheckBox ctrl, uint value)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                if (ctrl.Checked)
                    currentAction.Datalong2 += value;
                else
                    currentAction.Datalong2 -= value;
            }
        }
        private void chkMoveOptions1_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong3FlagsFromCheckbox(chkMoveOptions1, 1);
        }

        private void chkMoveOptions2_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong3FlagsFromCheckbox(chkMoveOptions2, 2);
        }

        private void chkMoveOptions4_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong3FlagsFromCheckbox(chkMoveOptions4, 4);
        }

        private void chkMoveOptions8_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong3FlagsFromCheckbox(chkMoveOptions8, 8);
        }

        private void chkMoveOptions16_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong3FlagsFromCheckbox(chkMoveOptions16, 16);
        }

        private void chkMoveOptions32_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong3FlagsFromCheckbox(chkMoveOptions32, 32);
        }

        private void chkMoveOptions64_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong3FlagsFromCheckbox(chkMoveOptions64, 64);
        }

        private void chkMoveOptions128_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong3FlagsFromCheckbox(chkMoveOptions128, 128);
        }

        private void chkMoveOptions256_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong3FlagsFromCheckbox(chkMoveOptions256, 256);
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

        private void cmbTeleportMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Updating field id.
                currentAction.Datalong = (uint)(cmbTeleportMap.SelectedItem as ComboboxPair).Value;
            }
        }

        private void txtTeleportX_Leave(object sender, EventArgs e)
        {
            SetCoordinateX(txtTeleportX);
        }

        private void txtTeleportY_Leave(object sender, EventArgs e)
        {
            SetCoordinateY(txtTeleportY);
        }

        private void txtTeleportZ_Leave(object sender, EventArgs e)
        {
            SetCoordinateZ(txtTeleportZ);
        }

        private void txtTeleportO_Leave(object sender, EventArgs e)
        {
            SetCoordinateO(txtTeleportO);
        }

        private void chkTeleportOptions1_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong2FlagsFromCheckbox(chkTeleportOptions1, 1);
        }

        private void chkTeleportOptions2_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong2FlagsFromCheckbox(chkTeleportOptions2, 2);
        }

        private void chkTeleportOptions4_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong2FlagsFromCheckbox(chkTeleportOptions4, 4);
        }

        private void chkTeleportOptions8_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong2FlagsFromCheckbox(chkTeleportOptions8, 8);
        }

        private void chkTeleportOptions16_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong2FlagsFromCheckbox(chkTeleportOptions16, 16);
        }

        private void chkTeleportOptions32_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong2FlagsFromCheckbox(chkTeleportOptions32, 32);
        }

        private void btnQuestCompleteId_Click(object sender, EventArgs e)
        {
            FormQuestFinder frm = new FormQuestFinder();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uint questId = frm.ReturnValue;
                if (questId > 0)
                    btnQuestCompleteId.Text = GameData.FindQuestTitle(questId) + " (" + questId.ToString() + ")";
                else
                    btnQuestCompleteId.Text = "-NONE-";

                if (lstActions.SelectedItems.Count > 0)
                {
                    // Get the selected item in the listview.
                    ListViewItem currentItem = lstActions.SelectedItems[0];

                    // Get the associated ScriptAction.
                    ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                    // QuestId = datalong;
                    currentAction.Datalong = questId;
                }

            }
        }

        private void txtQuestCompleteDistance_Leave(object sender, EventArgs e)
        {
            SetDatalong2FromTextbox(txtQuestCompleteDistance);
        }

        private void cmbKillCreditType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Updating credit type.
                currentAction.Datalong2 = (uint)cmbKillCreditType.SelectedIndex;
            }
        }

        private void SetDatalongCreatureIdFromButton(Button ctrl)
        {
            FormCreatureFinder frm = new FormCreatureFinder();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uint creatureId = frm.ReturnValue;
                if (creatureId > 0)
                    ctrl.Text = GameData.FindCreatureName(creatureId) + " (" + creatureId.ToString() + ")";
                else
                    ctrl.Text = "-NONE-";

                if (lstActions.SelectedItems.Count > 0)
                {
                    // Get the selected item in the listview.
                    ListViewItem currentItem = lstActions.SelectedItems[0];

                    // Get the associated ScriptAction.
                    ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                    // CreatureId = datalong;
                    currentAction.Datalong = creatureId;
                }

            }
        }
        private void btnKillCreditCreatureId_Click(object sender, EventArgs e)
        {
            SetDatalongCreatureIdFromButton(btnKillCreditCreatureId);
        }

        private void txtRespawnGameobjectDelay_Leave(object sender, EventArgs e)
        {
            SetDatalong2FromTextbox(txtRespawnGameobjectDelay);
        }

        private void txtRespawnGameobjectGuid_Leave(object sender, EventArgs e)
        {
            SetDatalongFromTextbox(txtRespawnGameobjectGuid);
        }

        private void btnSummonCreatureId_Click(object sender, EventArgs e)
        {
            SetDatalongCreatureIdFromButton(btnSummonCreatureId);
        }

        private void txtSummonCreatureDelay_Leave(object sender, EventArgs e)
        {
            SetDatalong2FromTextbox(txtSummonCreatureDelay);
        }

        private void txtSummonCreatureX_Leave(object sender, EventArgs e)
        {
            SetCoordinateX(txtSummonCreatureX);
        }

        private void txtSummonCreatureY_Leave(object sender, EventArgs e)
        {
            SetCoordinateY(txtSummonCreatureY);
        }

        private void txtSummonCreatureZ_Leave(object sender, EventArgs e)
        {
            SetCoordinateZ(txtSummonCreatureZ);
        }

        private void txtSummonCreatureO_Leave(object sender, EventArgs e)
        {
            SetCoordinateO(txtSummonCreatureO);
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
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Set Run = Dataint
                currentAction.Dataint = cmbSummonCreatureSetRun.SelectedIndex;
            }
        }

        private void txtSummonCreatureUniqueLimit_Leave(object sender, EventArgs e)
        {
            SetDatalong3FromTextbox(txtSummonCreatureUniqueLimit);
        }

        private void txtSummonCreatureUniqueRange_Leave(object sender, EventArgs e)
        {
            SetDatalong4FromTextbox(txtSummonCreatureUniqueRange);
        }

        private void chkSummonCreatureFlags16_CheckedChanged(object sender, EventArgs e)
        {
            SetDataFlagsFromCheckbox(chkSummonCreatureFlags16, 16);
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
