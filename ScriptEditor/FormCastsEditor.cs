using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormCastsEditor : Form
    {
        public uint ReturnValue { get; set; }
        public HashSet<uint> NewTemplates = new HashSet<uint>();
        public HashSet<uint> DeletedTemplates = new HashSet<uint>();
        bool dontUpdate = false;

        public FormCastsEditor(uint id = 0)
        {
            InitializeComponent();
            ReturnValue = id;
        }

        private void FormCastsEditor_Load(object sender, EventArgs e)
        {
            dontUpdate = true;
            LoadControls();
            ResetAllControls();
            // If a value was provided on load, we show this template.
            if (ReturnValue != 0)
            {
                txtFilter.Text = ReturnValue.ToString();
                btnFilter_Click(this, new EventArgs());
                if (lstSpellTemplates.Items.Count > 0)
                    lstSpellTemplates.SelectedIndex = 0;
            }
            dontUpdate = false;
        }
        private int GetIndexOfComboValue(ComboBox cmb, int value)
        {
            for (int i = 0; i < cmb.Items.Count; i++)
            {
                if (value == (uint)(cmb.Items[i] as ComboboxPair).Value)
                    return i;
            }
            return -1;
        }
        private List<ComboboxPair> GetSpellTargetsList()
        {
            return new List<ComboboxPair>
             {
               new ComboboxPair("Self", 0),
               new ComboboxPair("Victim", 1),
               new ComboboxPair("Second Aggro", 2),
               new ComboboxPair("Last Aggro", 3),
               new ComboboxPair("Random", 4),
               new ComboboxPair("Random Not Top", 5),
               new ComboboxPair("Owner or Self", 6),
               new ComboboxPair("Owner", 7),
               new ComboboxPair("Random Friendly", 14),
               new ComboboxPair("Injured Friendly", 15),
               new ComboboxPair("Injured Not Self", 16),
               new ComboboxPair("No Buff Friendly", 17),
               new ComboboxPair("No Buff Not Self", 18),
               new ComboboxPair("Friendly In CC", 19)
             };
        }
        private void LoadControls()
        {
            cmbSpell1Target.DataSource = GetSpellTargetsList();
            cmbSpell2Target.DataSource = GetSpellTargetsList();
            cmbSpell3Target.DataSource = GetSpellTargetsList();
            cmbSpell4Target.DataSource = GetSpellTargetsList();
            cmbSpell5Target.DataSource = GetSpellTargetsList();
            cmbSpell6Target.DataSource = GetSpellTargetsList();
            cmbSpell7Target.DataSource = GetSpellTargetsList();
            cmbSpell8Target.DataSource = GetSpellTargetsList();

            // Designer keeps resetting the size...
            txtFilter.AutoSize = false;
            txtFilter.Size = new Size(txtFilter.Size.Width, 23);
            txtName.AutoSize = false;
            txtName.Size = new Size(txtName.Size.Width, 23);
            txtSpell1Probability.AutoSize = false;
            txtSpell1Probability.Size = new Size(txtSpell1Probability.Size.Width, 23);
            txtSpell2Probability.AutoSize = false;
            txtSpell2Probability.Size = new Size(txtSpell2Probability.Size.Width, 23);
            txtSpell3Probability.AutoSize = false;
            txtSpell3Probability.Size = new Size(txtSpell3Probability.Size.Width, 23);
            txtSpell4Probability.AutoSize = false;
            txtSpell4Probability.Size = new Size(txtSpell4Probability.Size.Width, 23);
            txtSpell5Probability.AutoSize = false;
            txtSpell5Probability.Size = new Size(txtSpell5Probability.Size.Width, 23);
            txtSpell6Probability.AutoSize = false;
            txtSpell6Probability.Size = new Size(txtSpell6Probability.Size.Width, 23);
            txtSpell7Probability.AutoSize = false;
            txtSpell7Probability.Size = new Size(txtSpell7Probability.Size.Width, 23);
            txtSpell8Probability.AutoSize = false;
            txtSpell8Probability.Size = new Size(txtSpell8Probability.Size.Width, 23);
            txtSpell1DelayInitialMin.AutoSize = false;
            txtSpell1DelayInitialMin.Size = new Size(txtSpell1DelayInitialMin.Size.Width, 23);
            txtSpell2DelayInitialMin.AutoSize = false;
            txtSpell2DelayInitialMin.Size = new Size(txtSpell2DelayInitialMin.Size.Width, 23);
            txtSpell3DelayInitialMin.AutoSize = false;
            txtSpell3DelayInitialMin.Size = new Size(txtSpell3DelayInitialMin.Size.Width, 23);
            txtSpell4DelayInitialMin.AutoSize = false;
            txtSpell4DelayInitialMin.Size = new Size(txtSpell4DelayInitialMin.Size.Width, 23);
            txtSpell5DelayInitialMin.AutoSize = false;
            txtSpell5DelayInitialMin.Size = new Size(txtSpell5DelayInitialMin.Size.Width, 23);
            txtSpell6DelayInitialMin.AutoSize = false;
            txtSpell6DelayInitialMin.Size = new Size(txtSpell6DelayInitialMin.Size.Width, 23);
            txtSpell7DelayInitialMin.AutoSize = false;
            txtSpell7DelayInitialMin.Size = new Size(txtSpell7DelayInitialMin.Size.Width, 23);
            txtSpell8DelayInitialMin.AutoSize = false;
            txtSpell8DelayInitialMin.Size = new Size(txtSpell8DelayInitialMin.Size.Width, 23);
            txtSpell1DelayInitialMax.AutoSize = false;
            txtSpell1DelayInitialMax.Size = new Size(txtSpell1DelayInitialMax.Size.Width, 23);
            txtSpell2DelayInitialMax.AutoSize = false;
            txtSpell2DelayInitialMax.Size = new Size(txtSpell2DelayInitialMax.Size.Width, 23);
            txtSpell3DelayInitialMax.AutoSize = false;
            txtSpell3DelayInitialMax.Size = new Size(txtSpell3DelayInitialMax.Size.Width, 23);
            txtSpell4DelayInitialMax.AutoSize = false;
            txtSpell4DelayInitialMax.Size = new Size(txtSpell4DelayInitialMax.Size.Width, 23);
            txtSpell5DelayInitialMax.AutoSize = false;
            txtSpell5DelayInitialMax.Size = new Size(txtSpell5DelayInitialMax.Size.Width, 23);
            txtSpell6DelayInitialMax.AutoSize = false;
            txtSpell6DelayInitialMax.Size = new Size(txtSpell6DelayInitialMax.Size.Width, 23);
            txtSpell7DelayInitialMax.AutoSize = false;
            txtSpell7DelayInitialMax.Size = new Size(txtSpell7DelayInitialMax.Size.Width, 23);
            txtSpell8DelayInitialMax.AutoSize = false;
            txtSpell8DelayInitialMax.Size = new Size(txtSpell8DelayInitialMax.Size.Width, 23);
            txtSpell1DelayRepeatMin.AutoSize = false;
            txtSpell1DelayRepeatMin.Size = new Size(txtSpell1DelayRepeatMin.Size.Width, 23);
            txtSpell2DelayRepeatMin.AutoSize = false;
            txtSpell2DelayRepeatMin.Size = new Size(txtSpell2DelayRepeatMin.Size.Width, 23);
            txtSpell3DelayRepeatMin.AutoSize = false;
            txtSpell3DelayRepeatMin.Size = new Size(txtSpell3DelayRepeatMin.Size.Width, 23);
            txtSpell4DelayRepeatMin.AutoSize = false;
            txtSpell4DelayRepeatMin.Size = new Size(txtSpell4DelayRepeatMin.Size.Width, 23);
            txtSpell5DelayRepeatMin.AutoSize = false;
            txtSpell5DelayRepeatMin.Size = new Size(txtSpell5DelayRepeatMin.Size.Width, 23);
            txtSpell6DelayRepeatMin.AutoSize = false;
            txtSpell6DelayRepeatMin.Size = new Size(txtSpell6DelayRepeatMin.Size.Width, 23);
            txtSpell7DelayRepeatMin.AutoSize = false;
            txtSpell7DelayRepeatMin.Size = new Size(txtSpell7DelayRepeatMin.Size.Width, 23);
            txtSpell8DelayRepeatMin.AutoSize = false;
            txtSpell8DelayRepeatMin.Size = new Size(txtSpell8DelayRepeatMin.Size.Width, 23);
            txtSpell1DelayRepeatMax.AutoSize = false;
            txtSpell1DelayRepeatMax.Size = new Size(txtSpell1DelayRepeatMax.Size.Width, 23);
            txtSpell2DelayRepeatMax.AutoSize = false;
            txtSpell2DelayRepeatMax.Size = new Size(txtSpell2DelayRepeatMax.Size.Width, 23);
            txtSpell3DelayRepeatMax.AutoSize = false;
            txtSpell3DelayRepeatMax.Size = new Size(txtSpell3DelayRepeatMax.Size.Width, 23);
            txtSpell4DelayRepeatMax.AutoSize = false;
            txtSpell4DelayRepeatMax.Size = new Size(txtSpell4DelayRepeatMax.Size.Width, 23);
            txtSpell5DelayRepeatMax.AutoSize = false;
            txtSpell5DelayRepeatMax.Size = new Size(txtSpell5DelayRepeatMax.Size.Width, 23);
            txtSpell6DelayRepeatMax.AutoSize = false;
            txtSpell6DelayRepeatMax.Size = new Size(txtSpell6DelayRepeatMax.Size.Width, 23);
            txtSpell7DelayRepeatMax.AutoSize = false;
            txtSpell7DelayRepeatMax.Size = new Size(txtSpell7DelayRepeatMax.Size.Width, 23);
            txtSpell8DelayRepeatMax.AutoSize = false;
            txtSpell8DelayRepeatMax.Size = new Size(txtSpell8DelayRepeatMax.Size.Width, 23);
        }
        private void ResetAllControls()
        {
            dontUpdate = true;

            txtName.Text = "";
            lblUsedBy.Text = "Used:";
            lblUsedBy.Location = new Point(cmbUsedBy.Location.X - lblUsedBy.Size.Width - 4, lblUsedBy.Location.Y);
            cmbUsedBy.Items.Clear();
            cmbUsedBy.Text = "";

            txtSpell1Probability.Text = "";
            txtSpell2Probability.Text = "";
            txtSpell3Probability.Text = "";
            txtSpell4Probability.Text = "";
            txtSpell5Probability.Text = "";
            txtSpell6Probability.Text = "";
            txtSpell7Probability.Text = "";
            txtSpell8Probability.Text = "";

            btnSpell1Id.Text = "-NONE-";
            btnSpell2Id.Text = "-NONE-";
            btnSpell3Id.Text = "-NONE-";
            btnSpell4Id.Text = "-NONE-";
            btnSpell5Id.Text = "-NONE-";
            btnSpell6Id.Text = "-NONE-";
            btnSpell7Id.Text = "-NONE-";
            btnSpell8Id.Text = "-NONE-";

            cmbSpell1Target.SelectedIndex = -1;
            cmbSpell1Target.Text = "";
            cmbSpell2Target.SelectedIndex = -1;
            cmbSpell2Target.Text = "";
            cmbSpell3Target.SelectedIndex = -1;
            cmbSpell3Target.Text = "";
            cmbSpell4Target.SelectedIndex = -1;
            cmbSpell4Target.Text = "";
            cmbSpell5Target.SelectedIndex = -1;
            cmbSpell5Target.Text = "";
            cmbSpell6Target.SelectedIndex = -1;
            cmbSpell6Target.Text = "";
            cmbSpell7Target.SelectedIndex = -1;
            cmbSpell7Target.Text = "";
            cmbSpell8Target.SelectedIndex = -1;
            cmbSpell8Target.Text = "";

            txtSpell1DelayInitialMin.Text = "";
            txtSpell2DelayInitialMin.Text = "";
            txtSpell3DelayInitialMin.Text = "";
            txtSpell4DelayInitialMin.Text = "";
            txtSpell5DelayInitialMin.Text = "";
            txtSpell6DelayInitialMin.Text = "";
            txtSpell7DelayInitialMin.Text = "";
            txtSpell8DelayInitialMin.Text = "";

            txtSpell1DelayInitialMax.Text = "";
            txtSpell2DelayInitialMax.Text = "";
            txtSpell3DelayInitialMax.Text = "";
            txtSpell4DelayInitialMax.Text = "";
            txtSpell5DelayInitialMax.Text = "";
            txtSpell6DelayInitialMax.Text = "";
            txtSpell7DelayInitialMax.Text = "";
            txtSpell8DelayInitialMax.Text = "";

            txtSpell1DelayRepeatMin.Text = "";
            txtSpell2DelayRepeatMin.Text = "";
            txtSpell3DelayRepeatMin.Text = "";
            txtSpell4DelayRepeatMin.Text = "";
            txtSpell5DelayRepeatMin.Text = "";
            txtSpell6DelayRepeatMin.Text = "";
            txtSpell7DelayRepeatMin.Text = "";
            txtSpell8DelayRepeatMin.Text = "";

            txtSpell1DelayRepeatMax.Text = "";
            txtSpell2DelayRepeatMax.Text = "";
            txtSpell3DelayRepeatMax.Text = "";
            txtSpell4DelayRepeatMax.Text = "";
            txtSpell5DelayRepeatMax.Text = "";
            txtSpell6DelayRepeatMax.Text = "";
            txtSpell7DelayRepeatMax.Text = "";
            txtSpell8DelayRepeatMax.Text = "";

            dontUpdate = false;
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            dontUpdate = true;

            lstSpellTemplates.Items.Clear();
            frmData.Enabled = false;
            txtName.Enabled = false;
            cmbUsedBy.Enabled = false;
            ResetAllControls();

            if (txtFilter.TextLength == 0)
                return;

            uint id = 0;
            if (uint.TryParse(txtFilter.Text, out id)) // If content is numeric search for id.
            {
                foreach (CreatureSpellsInfo template in GameData.CreatureSpellsInfoList)
                {
                    if (template.ID == id)
                    {
                        ListBoxItem lbi = new ListBoxItem(template.ID, template.Name, template);
                        lstSpellTemplates.Items.Add(lbi);
                    }
                }
            }
            else // Add items that contain this text.
            {
                foreach (CreatureSpellsInfo template in GameData.CreatureSpellsInfoList)
                {
                    if (template.Name.Contains(txtFilter.Text))
                    {
                        ListBoxItem lbi = new ListBoxItem(template.ID, template.Name, template);
                        lstSpellTemplates.Items.Add(lbi);
                    }
                }
            }

            dontUpdate = false;
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnFilter_Click(this, new EventArgs());
                e.Handled = true;
            }
        }

        private void lstSpellTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetAllControls();

            if (lstSpellTemplates.SelectedItems.Count == 0)
            {
                frmData.Enabled = false;
                txtName.Enabled = false;
                cmbUsedBy.Enabled = false;
                return;
            }

            dontUpdate = true;

            ListBoxItem lbi = lstSpellTemplates.SelectedItem as ListBoxItem;

            txtName.Text = lbi.Name;

            // Find creatures who use this template and add them to combo box.
            foreach (CreatureInfo creature in GameData.CreatureInfoList)
            {
                if (creature.SpellsTemplate == lbi.Id)
                {
                    cmbUsedBy.Items.Add(creature.Name + " (" + creature.ID + ")");
                }
            }

            if (cmbUsedBy.Items.Count > 0)
            {
                lblUsedBy.Text = "Used (" + cmbUsedBy.Items.Count + ")";
                lblUsedBy.Location = new Point(cmbUsedBy.Location.X - lblUsedBy.Size.Width - 4, lblUsedBy.Location.Y);
                cmbUsedBy.SelectedIndex = 0;
            }


            // Show probability, spell name and delays.
            if (lbi.Template.SpellId1 > 0)
            {
                btnSpell1Id.Text = GameData.FindSpellName(lbi.Template.SpellId1) + " (" + lbi.Template.SpellId1.ToString() + ")";
                txtSpell1DelayInitialMin.Text = lbi.Template.DelayInitialMin1.ToString();
                txtSpell1DelayInitialMax.Text = lbi.Template.DelayInitialMax1.ToString();
                txtSpell1DelayRepeatMin.Text = lbi.Template.DelayRepeatMin1.ToString();
                txtSpell1DelayRepeatMax.Text = lbi.Template.DelayRepeatMax1.ToString();
                txtSpell1Probability.Text = lbi.Template.Probability1.ToString();
                cmbSpell1Target.SelectedIndex = GetIndexOfComboValue(cmbSpell1Target, (int)lbi.Template.CastTarget1);
            }
            if (lbi.Template.SpellId2 > 0)
            {
                btnSpell2Id.Text = GameData.FindSpellName(lbi.Template.SpellId2) + " (" + lbi.Template.SpellId2.ToString() + ")";
                txtSpell2DelayInitialMin.Text = lbi.Template.DelayInitialMin2.ToString();
                txtSpell2DelayInitialMax.Text = lbi.Template.DelayInitialMax2.ToString();
                txtSpell2DelayRepeatMin.Text = lbi.Template.DelayRepeatMin2.ToString();
                txtSpell2DelayRepeatMax.Text = lbi.Template.DelayRepeatMax2.ToString();
                txtSpell2Probability.Text = lbi.Template.Probability2.ToString();
                cmbSpell2Target.SelectedIndex = GetIndexOfComboValue(cmbSpell2Target, (int)lbi.Template.CastTarget2);
            }
            if (lbi.Template.SpellId3 > 0)
            {
                btnSpell3Id.Text = GameData.FindSpellName(lbi.Template.SpellId3) + " (" + lbi.Template.SpellId3.ToString() + ")";
                txtSpell3DelayInitialMin.Text = lbi.Template.DelayInitialMin3.ToString();
                txtSpell3DelayInitialMax.Text = lbi.Template.DelayInitialMax3.ToString();
                txtSpell3DelayRepeatMin.Text = lbi.Template.DelayRepeatMin3.ToString();
                txtSpell3DelayRepeatMax.Text = lbi.Template.DelayRepeatMax3.ToString();
                txtSpell3Probability.Text = lbi.Template.Probability3.ToString();
                cmbSpell3Target.SelectedIndex = GetIndexOfComboValue(cmbSpell3Target, (int)lbi.Template.CastTarget3);
            }
            if (lbi.Template.SpellId4 > 0)
            {
                btnSpell4Id.Text = GameData.FindSpellName(lbi.Template.SpellId4) + " (" + lbi.Template.SpellId4.ToString() + ")";
                txtSpell4DelayInitialMin.Text = lbi.Template.DelayInitialMin4.ToString();
                txtSpell4DelayInitialMax.Text = lbi.Template.DelayInitialMax4.ToString();
                txtSpell4DelayRepeatMin.Text = lbi.Template.DelayRepeatMin4.ToString();
                txtSpell4DelayRepeatMax.Text = lbi.Template.DelayRepeatMax4.ToString();
                txtSpell4Probability.Text = lbi.Template.Probability4.ToString();
                cmbSpell4Target.SelectedIndex = GetIndexOfComboValue(cmbSpell4Target, (int)lbi.Template.CastTarget4);
            }
            if (lbi.Template.SpellId5 > 0)
            {
                btnSpell5Id.Text = GameData.FindSpellName(lbi.Template.SpellId5) + " (" + lbi.Template.SpellId5.ToString() + ")";
                txtSpell5DelayInitialMin.Text = lbi.Template.DelayInitialMin5.ToString();
                txtSpell5DelayInitialMax.Text = lbi.Template.DelayInitialMax5.ToString();
                txtSpell5DelayRepeatMin.Text = lbi.Template.DelayRepeatMin5.ToString();
                txtSpell5DelayRepeatMax.Text = lbi.Template.DelayRepeatMax5.ToString();
                txtSpell5Probability.Text = lbi.Template.Probability5.ToString();
                cmbSpell5Target.SelectedIndex = GetIndexOfComboValue(cmbSpell5Target, (int)lbi.Template.CastTarget5);
            }
            if (lbi.Template.SpellId6 > 0)
            {
                btnSpell6Id.Text = GameData.FindSpellName(lbi.Template.SpellId6) + " (" + lbi.Template.SpellId6.ToString() + ")";
                txtSpell6DelayInitialMin.Text = lbi.Template.DelayInitialMin6.ToString();
                txtSpell6DelayInitialMax.Text = lbi.Template.DelayInitialMax6.ToString();
                txtSpell6DelayRepeatMin.Text = lbi.Template.DelayRepeatMin6.ToString();
                txtSpell6DelayRepeatMax.Text = lbi.Template.DelayRepeatMax6.ToString();
                txtSpell6Probability.Text = lbi.Template.Probability6.ToString();
                cmbSpell6Target.SelectedIndex = GetIndexOfComboValue(cmbSpell6Target, (int)lbi.Template.CastTarget6);
            }
            if (lbi.Template.SpellId7 > 0)
            {
                btnSpell7Id.Text = GameData.FindSpellName(lbi.Template.SpellId7) + " (" + lbi.Template.SpellId7.ToString() + ")";
                txtSpell7DelayInitialMin.Text = lbi.Template.DelayInitialMin7.ToString();
                txtSpell7DelayInitialMax.Text = lbi.Template.DelayInitialMax7.ToString();
                txtSpell7DelayRepeatMin.Text = lbi.Template.DelayRepeatMin7.ToString();
                txtSpell7DelayRepeatMax.Text = lbi.Template.DelayRepeatMax7.ToString();
                txtSpell7Probability.Text = lbi.Template.Probability7.ToString();
                cmbSpell7Target.SelectedIndex = GetIndexOfComboValue(cmbSpell7Target, (int)lbi.Template.CastTarget7);
            }
            if (lbi.Template.SpellId8 > 0)
            {
                btnSpell8Id.Text = GameData.FindSpellName(lbi.Template.SpellId8) + " (" + lbi.Template.SpellId8.ToString() + ")";
                txtSpell8DelayInitialMin.Text = lbi.Template.DelayInitialMin8.ToString();
                txtSpell8DelayInitialMax.Text = lbi.Template.DelayInitialMax8.ToString();
                txtSpell8DelayRepeatMin.Text = lbi.Template.DelayRepeatMin8.ToString();
                txtSpell8DelayRepeatMax.Text = lbi.Template.DelayRepeatMax8.ToString();
                txtSpell8Probability.Text = lbi.Template.Probability8.ToString();
                cmbSpell8Target.SelectedIndex = GetIndexOfComboValue(cmbSpell8Target, (int)lbi.Template.CastTarget8);
            }

            txtName.Enabled = true;
            cmbUsedBy.Enabled = true;
            frmData.Enabled = true;

            dontUpdate = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = "";
            DialogResult result_name = Helpers.ShowInputDialog(ref name, "Template Name");
            if ((result_name != DialogResult.OK) || (name == ""))
                return;

            string id_str = "";
            DialogResult result_id = Helpers.ShowInputDialog(ref id_str, "Template Id");
            if ((result_id != DialogResult.OK) || (id_str == ""))
                return;

            uint id = 0;
            if (uint.TryParse(id_str, out id))
            {
                // Check if Id is already taken.
                foreach (CreatureSpellsInfo template in GameData.CreatureSpellsInfoList)
                {
                    if (template.ID == id)
                    {
                        MessageBox.Show("That spells template Id is already taken.", "Invalid Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Create new spells template and add it to the list.
                CreatureSpellsInfo new_template = new CreatureSpellsInfo(id, name);
                GameData.CreatureSpellsInfoList.Add(new_template);
                ListBoxItem lbi = new ListBoxItem(id, name, new_template);
                lstSpellTemplates.Items.Add(lbi);
                lstSpellTemplates.SelectedItem = lbi;
                NewTemplates.Add(id);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (lstSpellTemplates.SelectedItems.Count == 0)
                return;

            ListBoxItem selectedItem = lstSpellTemplates.SelectedItem as ListBoxItem;

            string name = selectedItem.Name;
            DialogResult result_name = Helpers.ShowInputDialog(ref name, "Template Name");
            if ((result_name != DialogResult.OK) || (name == ""))
                return;

            string id_str = (selectedItem.Id + 1).ToString();
            DialogResult result_id = Helpers.ShowInputDialog(ref id_str, "Template Id");
            if ((result_id != DialogResult.OK) || (id_str == ""))
                return;

            uint id = 0;
            if (uint.TryParse(id_str, out id))
            {
                // Check if Id is already taken.
                foreach (CreatureSpellsInfo template in GameData.CreatureSpellsInfoList)
                {
                    if (template.ID == id)
                    {
                        MessageBox.Show("That spells template Id is already taken.", "Invalid Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Create new spells template and add it to the list.
                CreatureSpellsInfo new_template = new CreatureSpellsInfo(id, name, selectedItem.Template);
                GameData.CreatureSpellsInfoList.Add(new_template);
                ListBoxItem lbi = new ListBoxItem(id, name, new_template);
                lstSpellTemplates.Items.Add(lbi);
                lstSpellTemplates.SelectedItem = lbi;
                NewTemplates.Add(id);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstSpellTemplates.SelectedItems.Count == 0)
                return;

            ListBoxItem selectedItem = lstSpellTemplates.SelectedItem as ListBoxItem;
            DeletedTemplates.Add(selectedItem.Id);

            foreach (CreatureSpellsInfo template in GameData.CreatureSpellsInfoList)
            {
                if (template.ID == selectedItem.Id)
                {
                    GameData.CreatureSpellsInfoList.Remove(template);
                    break;
                }
            }
            lstSpellTemplates.SelectedIndex = -1;
            lstSpellTemplates.Items.Remove(selectedItem);
        }
        private string GenerateSaveTemplateQuery(CreatureSpellsInfo template)
        {
            string query = "REPLACE INTO `creature_spells` (`entry`, `name`, `spellId_1`, `probability_1`, `castTarget_1`, `targetParam1_1`, `targetParam2_1`, `castFlags_1`, `delayInitialMin_1`, `delayInitialMax_1`, `delayRepeatMin_1`, `delayRepeatMax_1`, `scriptId_1`, `spellId_2`, `probability_2`, `castTarget_2`, `targetParam1_2`, `targetParam2_2`, `castFlags_2`, `delayInitialMin_2`, `delayInitialMax_2`, `delayRepeatMin_2`, `delayRepeatMax_2`, `scriptId_2`, `spellId_3`, `probability_3`, `castTarget_3`, `targetParam1_3`, `targetParam2_3`, `castFlags_3`, `delayInitialMin_3`, `delayInitialMax_3`, `delayRepeatMin_3`, `delayRepeatMax_3`, `scriptId_3`, `spellId_4`, `probability_4`, `castTarget_4`, `targetParam1_4`, `targetParam2_4`, `castFlags_4`, `delayInitialMin_4`, `delayInitialMax_4`, `delayRepeatMin_4`, `delayRepeatMax_4`, `scriptId_4`, `spellId_5`, `probability_5`, `castTarget_5`, `targetParam1_5`, `targetParam2_5`, `castFlags_5`, `delayInitialMin_5`, `delayInitialMax_5`, `delayRepeatMin_5`, `delayRepeatMax_5`, `scriptId_5`, `spellId_6`, `probability_6`, `castTarget_6`, `targetParam1_6`, `targetParam2_6`, `castFlags_6`, `delayInitialMin_6`, `delayInitialMax_6`, `delayRepeatMin_6`, `delayRepeatMax_6`, `scriptId_6`, `spellId_7`, `probability_7`, `castTarget_7`, `targetParam1_7`, `targetParam2_7`, `castFlags_7`, `delayInitialMin_7`, `delayInitialMax_7`, `delayRepeatMin_7`, `delayRepeatMax_7`, `scriptId_7`, `spellId_8`, `probability_8`, `castTarget_8`, `targetParam1_8`, `targetParam2_8`, `castFlags_8`, `delayInitialMin_8`, `delayInitialMax_8`, `delayRepeatMin_8`, `delayRepeatMax_8`, `scriptId_8`) VALUES (" + template.ID.ToString() + ", '" + Helpers.MySQLEscape(template.Name) + "', " + template.SpellId1.ToString() + ", " + template.Probability1.ToString() + ", " + template.CastTarget1.ToString() + ", " + template.TargetParam1_1.ToString() + ", " + template.TargetParam2_1.ToString() + ", " + template.CastFlags1.ToString() + ", " + template.DelayInitialMin1.ToString() + ", " + template.DelayInitialMax1.ToString() + ", " + template.DelayRepeatMin1.ToString() + ", " + template.DelayRepeatMax1.ToString() + ", " + template.ScriptId1.ToString() + ", " + template.SpellId2.ToString() + ", " + template.Probability2.ToString() + ", " + template.CastTarget2.ToString() + ", " + template.TargetParam1_2.ToString() + ", " + template.TargetParam2_2.ToString() + ", " + template.CastFlags2.ToString() + ", " + template.DelayInitialMin2.ToString() + ", " + template.DelayInitialMax2.ToString() + ", " + template.DelayRepeatMin2.ToString() + ", " + template.DelayRepeatMax2.ToString() + ", " + template.ScriptId2.ToString() + ", " + template.SpellId3.ToString() + ", " + template.Probability3.ToString() + ", " + template.CastTarget3.ToString() + ", " + template.TargetParam1_3.ToString() + ", " + template.TargetParam2_3.ToString() + ", " + template.CastFlags3.ToString() + ", " + template.DelayInitialMin3.ToString() + ", " + template.DelayInitialMax3.ToString() + ", " + template.DelayRepeatMin3.ToString() + ", " + template.DelayRepeatMax3.ToString() + ", " + template.ScriptId3.ToString() + ", " + template.SpellId4.ToString() + ", " + template.Probability4.ToString() + ", " + template.CastTarget4.ToString() + ", " + template.TargetParam1_4.ToString() + ", " + template.TargetParam2_4.ToString() + ", " + template.CastFlags4.ToString() + ", " + template.DelayInitialMin4.ToString() + ", " + template.DelayInitialMax4.ToString() + ", " + template.DelayRepeatMin4.ToString() + ", " + template.DelayRepeatMax4.ToString() + ", " + template.ScriptId4.ToString() + ", " + template.SpellId5.ToString() + ", " + template.Probability5.ToString() + ", " + template.CastTarget5.ToString() + ", " + template.TargetParam1_5.ToString() + ", " + template.TargetParam2_5.ToString() + ", " + template.CastFlags5.ToString() + ", " + template.DelayInitialMin5.ToString() + ", " + template.DelayInitialMax5.ToString() + ", " + template.DelayRepeatMin5.ToString() + ", " + template.DelayRepeatMax5.ToString() + ", " + template.ScriptId5.ToString() + ", " + template.SpellId6.ToString() + ", " + template.Probability6.ToString() + ", " + template.CastTarget6.ToString() + ", " + template.TargetParam1_6.ToString() + ", " + template.TargetParam2_6.ToString() + ", " + template.CastFlags6.ToString() + ", " + template.DelayInitialMin6.ToString() + ", " + template.DelayInitialMax6.ToString() + ", " + template.DelayRepeatMin6.ToString() + ", " + template.DelayRepeatMax6.ToString() + ", " + template.ScriptId6.ToString() + ", " + template.SpellId7.ToString() + ", " + template.Probability7.ToString() + ", " + template.CastTarget7.ToString() + ", " + template.TargetParam1_7.ToString() + ", " + template.TargetParam2_7.ToString() + ", " + template.CastFlags7.ToString() + ", " + template.DelayInitialMin7.ToString() + ", " + template.DelayInitialMax7.ToString() + ", " + template.DelayRepeatMin7.ToString() + ", " + template.DelayRepeatMax7.ToString() + ", " + template.ScriptId7.ToString() + ", " + template.SpellId8.ToString() + ", " + template.Probability8.ToString() + ", " + template.CastTarget8.ToString() + ", " + template.TargetParam1_8.ToString() + ", " + template.TargetParam2_8.ToString() + ", " + template.CastFlags8.ToString() + ", " + template.DelayInitialMin8.ToString() + ", " + template.DelayInitialMax8.ToString() + ", " + template.DelayRepeatMin8.ToString() + ", " + template.DelayRepeatMax8.ToString() + ", " + template.ScriptId8.ToString() + ");\n";
            return query;
        }
        private void btnSaveThis_Click(object sender, EventArgs e)
        {
            if (lstSpellTemplates.SelectedItems.Count == 0)
                return;

            ListBoxItem selectedItem = lstSpellTemplates.SelectedItem as ListBoxItem;

            string query = GenerateSaveTemplateQuery(selectedItem.Template);
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
                    MessageBox.Show(ex.ToString(), "Save Template", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            string deleted_templates = "";
            foreach (uint id in DeletedTemplates)
            {
                bool not_really_deleted = false;

                foreach (CreatureSpellsInfo template in GameData.CreatureSpellsInfoList)
                {
                    if (template.ID == id)
                    {
                        not_really_deleted = true;
                        break;
                    }
                }

                if (not_really_deleted)
                    continue;

                deleted_templates += "DELETE FROM `creature_spells` WHERE `entry`=" + id.ToString() +";\n";
            }
            string new_templates = "";
            foreach (uint id in NewTemplates)
            {
                foreach (CreatureSpellsInfo template in GameData.CreatureSpellsInfoList)
                {
                    if (template.ID == id)
                    {
                        new_templates += GenerateSaveTemplateQuery(template);
                        break;
                    }
                }
            }

            if ((deleted_templates.Length == 0) && (new_templates.Length == 0))
                return;

            string query = "";

            if (deleted_templates.Length > 0)
                query = "-- Removing unused creature spell templates.\n" + deleted_templates + "\n";

            if (new_templates.Length > 0)
                query += "-- New creature spell templates.\n" + new_templates;

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
                    MessageBox.Show(ex.ToString(), "Save Template", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }

        // Generic function for setting script field to specified value;
        private void SetScriptFieldFromValue(float fieldvalue, string fieldname)
        {
            if (lstSpellTemplates.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListBoxItem currentItem = lstSpellTemplates.SelectedItem  as ListBoxItem;

                // Get the associated ScriptAction.
                CreatureSpellsInfo currentTemplate = currentItem.Template;

                NewTemplates.Add(currentTemplate.ID);

                // Get the field we need to change.
                FieldInfo prop = typeof(CreatureSpellsInfo).GetField(fieldname, BindingFlags.Instance | BindingFlags.Public);

                // Updating the value in the field.
                prop.SetValue(currentTemplate, Convert.ChangeType(fieldvalue, prop.FieldType));
            }
        }
        // Generic function for setting field value from a textbox.
        private void SetScriptFieldFromTextbox(TextBox ctrl, string fieldname)
        {
            if (dontUpdate)
                return;

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
            if (lstSpellTemplates.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListBoxItem currentItem = lstSpellTemplates.SelectedItem as ListBoxItem;

                // Get the associated ScriptAction.
                CreatureSpellsInfo currentTemplate = currentItem.Template;

                // Get the field by name.
                FieldInfo prop = typeof(CreatureSpellsInfo).GetField(fieldname, BindingFlags.Instance | BindingFlags.Public);

                // Get the value in this field.
                int currentValue = (int)Convert.ChangeType(prop.GetValue(currentTemplate), typeof(int));

                return currentValue;
            }

            return 0;
        }
        private void txtName_Leave(object sender, EventArgs e)
        {
            if ((lstSpellTemplates.SelectedItems.Count == 0) || (txtName.Text.Length < 1))
                return;

            ListBoxItem selectedItem = lstSpellTemplates.SelectedItem as ListBoxItem;

            selectedItem.Template.Name = txtName.Text;
            selectedItem.Name = txtName.Text;

            // Update text on the listbox.
            int index = lstSpellTemplates.SelectedIndex;
            lstSpellTemplates.Items.RemoveAt(index);
            lstSpellTemplates.Items.Insert(index, selectedItem);
        }

        private void txtSpell1Probability_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell1Probability, "Probability1");
        }

        private void txtSpell2Probability_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell2Probability, "Probability2");
        }

        private void txtSpell3Probability_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell3Probability, "Probability3");
        }

        private void txtSpell4Probability_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell4Probability, "Probability4");
        }

        private void txtSpell5Probability_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell5Probability, "Probability5");
        }

        private void txtSpell6Probability_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell6Probability, "Probability6");
        }

        private void txtSpell7Probability_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell7Probability, "Probability7");
        }

        private void txtSpell8Probability_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell8Probability, "Probability8");
        }

        private void cmbSpell1Target_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSpell1Target, "CastTarget1", true);
        }

        private void cmbSpell2Target_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSpell2Target, "CastTarget2", true);
        }

        private void cmbSpell3Target_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSpell3Target, "CastTarget3", true);
        }

        private void cmbSpell4Target_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSpell4Target, "CastTarget4", true);
        }

        private void cmbSpell5Target_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSpell5Target, "CastTarget5", true);
        }

        private void cmbSpell6Target_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSpell6Target, "CastTarget6", true);
        }

        private void cmbSpell7Target_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSpell7Target, "CastTarget7", true);
        }

        private void cmbSpell8Target_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScriptFieldFromCombobox(cmbSpell8Target, "CastTarget8", true);
        }

        private void txtSpell1DelayInitialMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell1DelayInitialMin, "DelayInitialMin1");
        }

        private void txtSpell2DelayInitialMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell2DelayInitialMin, "DelayInitialMin2");
        }

        private void txtSpell3DelayInitialMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell3DelayInitialMin, "DelayInitialMin3");
        }

        private void txtSpell4DelayInitialMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell4DelayInitialMin, "DelayInitialMin4");
        }

        private void txtSpell5DelayInitialMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell5DelayInitialMin, "DelayInitialMin5");
        }

        private void txtSpell6DelayInitialMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell6DelayInitialMin, "DelayInitialMin6");
        }

        private void txtSpell7DelayInitialMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell7DelayInitialMin, "DelayInitialMin7");
        }

        private void txtSpell8DelayInitialMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell8DelayInitialMin, "DelayInitialMin8");
        }

        private void txtSpell1DelayInitialMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell1DelayInitialMax, "DelayInitialMax1");
        }

        private void txtSpell2DelayInitialMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell2DelayInitialMax, "DelayInitialMax2");
        }

        private void txtSpell3DelayInitialMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell3DelayInitialMax, "DelayInitialMax3");
        }

        private void txtSpell4DelayInitialMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell4DelayInitialMax, "DelayInitialMax4");
        }

        private void txtSpell5DelayInitialMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell5DelayInitialMax, "DelayInitialMax5");
        }

        private void txtSpell6DelayInitialMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell6DelayInitialMax, "DelayInitialMax6");
        }

        private void txtSpell7DelayInitialMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell7DelayInitialMax, "DelayInitialMax7");
        }

        private void txtSpell8DelayInitialMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell8DelayInitialMax, "DelayInitialMax8");
        }

        private void txtSpell1DelayRepeatMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell1DelayRepeatMin, "DelayRepeatMin1");
        }

        private void txtSpell2DelayRepeatMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell2DelayRepeatMin, "DelayRepeatMin2");
        }

        private void txtSpell3DelayRepeatMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell3DelayRepeatMin, "DelayRepeatMin3");
        }

        private void txtSpell4DelayRepeatMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell4DelayRepeatMin, "DelayRepeatMin4");
        }

        private void txtSpell5DelayRepeatMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell5DelayRepeatMin, "DelayRepeatMin5");
        }

        private void txtSpell6DelayRepeatMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell6DelayRepeatMin, "DelayRepeatMin6");
        }

        private void txtSpell7DelayRepeatMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell7DelayRepeatMin, "DelayRepeatMin7");
        }

        private void txtSpell8DelayRepeatMin_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell8DelayRepeatMin, "DelayRepeatMin8");
        }

        private void txtSpell1DelayRepeatMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell1DelayRepeatMax, "DelayRepeatMax1");
        }

        private void txtSpell2DelayRepeatMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell2DelayRepeatMax, "DelayRepeatMax2");
        }

        private void txtSpell3DelayRepeatMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell3DelayRepeatMax, "DelayRepeatMax3");
        }

        private void txtSpell4DelayRepeatMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell4DelayRepeatMax, "DelayRepeatMax4");
        }

        private void txtSpell5DelayRepeatMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell5DelayRepeatMax, "DelayRepeatMax5");
        }

        private void txtSpell6DelayRepeatMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell6DelayRepeatMax, "DelayRepeatMax6");
        }

        private void txtSpell7DelayRepeatMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell7DelayRepeatMax, "DelayRepeatMax7");
        }

        private void txtSpell8DelayRepeatMax_Leave(object sender, EventArgs e)
        {
            SetScriptFieldFromTextbox(txtSpell8DelayRepeatMax, "DelayRepeatMax8");
        }

        private void btnSpell1Id_Click(object sender, EventArgs e)
        {
            if (lstSpellTemplates.SelectedItems.Count == 0)
                return;

            string old_text = btnSpell1Id.Text;

            SetScriptFieldFromDataFinderForm<FormSpellFinder>(btnSpell1Id, null, GameData.FindSpellName, "SpellId1");

            if (((old_text == btnSpell1Id.Text)) || ((old_text != "-NONE-") && (btnSpell1Id.Text != "-NONE-")))
                return;

            dontUpdate = true;

            ListBoxItem currentItem = lstSpellTemplates.SelectedItem as ListBoxItem;

            if (btnSpell1Id.Text == "-NONE-")
            {
                txtSpell1Probability.Text = "";
                currentItem.Template.Probability1 = 0;
                txtSpell1DelayInitialMin.Text = "";
                currentItem.Template.DelayInitialMin1 = 0;
                txtSpell1DelayInitialMax.Text = "";
                currentItem.Template.DelayInitialMax1 = 0;
                txtSpell1DelayRepeatMin.Text = "";
                currentItem.Template.DelayRepeatMin1 = 0;
                txtSpell1DelayRepeatMax.Text = "";
                currentItem.Template.DelayRepeatMax1 = 0;
                cmbSpell1Target.SelectedIndex = -1;
                cmbSpell1Target.SelectedText = "";
                currentItem.Template.CastTarget1 = 0;
                currentItem.Template.CastFlags1 = 0;
                currentItem.Template.ScriptId1 = 0;
            }
            else
            {
                txtSpell1Probability.Text = "100";
                currentItem.Template.Probability1 = 100;
                txtSpell1DelayInitialMin.Text = "0";
                currentItem.Template.DelayInitialMin1 = 0;
                txtSpell1DelayInitialMax.Text = "0";
                currentItem.Template.DelayInitialMax1 = 0;
                txtSpell1DelayRepeatMin.Text = "0";
                currentItem.Template.DelayRepeatMin1 = 0;
                txtSpell1DelayRepeatMax.Text = "0";
                currentItem.Template.DelayRepeatMax1 = 0;
                cmbSpell1Target.SelectedIndex = 1;
                currentItem.Template.CastTarget1 = 1;
            }

            dontUpdate = false;
        }

        private void btnSpell2Id_Click(object sender, EventArgs e)
        {
            if (lstSpellTemplates.SelectedItems.Count == 0)
                return;

            string old_text = btnSpell2Id.Text;

            SetScriptFieldFromDataFinderForm<FormSpellFinder>(btnSpell2Id, null, GameData.FindSpellName, "SpellId2");

            if (((old_text == btnSpell2Id.Text)) || ((old_text != "-NONE-") && (btnSpell2Id.Text != "-NONE-")))
                return;

            dontUpdate = true;

            ListBoxItem currentItem = lstSpellTemplates.SelectedItem as ListBoxItem;

            if (btnSpell2Id.Text == "-NONE-")
            {
                txtSpell2Probability.Text = "";
                currentItem.Template.Probability2 = 0;
                txtSpell2DelayInitialMin.Text = "";
                currentItem.Template.DelayInitialMin2 = 0;
                txtSpell2DelayInitialMax.Text = "";
                currentItem.Template.DelayInitialMax2 = 0;
                txtSpell2DelayRepeatMin.Text = "";
                currentItem.Template.DelayRepeatMin2 = 0;
                txtSpell2DelayRepeatMax.Text = "";
                currentItem.Template.DelayRepeatMax2 = 0;
                cmbSpell2Target.SelectedIndex = -1;
                cmbSpell2Target.SelectedText = "";
                currentItem.Template.CastTarget2 = 0;
                currentItem.Template.CastFlags2 = 0;
                currentItem.Template.ScriptId2 = 0;
            }
            else
            {
                txtSpell2Probability.Text = "100";
                currentItem.Template.Probability2 = 100;
                txtSpell2DelayInitialMin.Text = "0";
                currentItem.Template.DelayInitialMin2 = 0;
                txtSpell2DelayInitialMax.Text = "0";
                currentItem.Template.DelayInitialMax2 = 0;
                txtSpell2DelayRepeatMin.Text = "0";
                currentItem.Template.DelayRepeatMin2 = 0;
                txtSpell2DelayRepeatMax.Text = "0";
                currentItem.Template.DelayRepeatMax2 = 0;
                cmbSpell2Target.SelectedIndex = 1;
                currentItem.Template.CastTarget2 = 1;
            }

            dontUpdate = false;
        }

        private void btnSpell3Id_Click(object sender, EventArgs e)
        {
            if (lstSpellTemplates.SelectedItems.Count == 0)
                return;

            string old_text = btnSpell3Id.Text;

            SetScriptFieldFromDataFinderForm<FormSpellFinder>(btnSpell3Id, null, GameData.FindSpellName, "SpellId3");

            if (((old_text == btnSpell3Id.Text)) || ((old_text != "-NONE-") && (btnSpell3Id.Text != "-NONE-")))
                return;

            dontUpdate = true;

            ListBoxItem currentItem = lstSpellTemplates.SelectedItem as ListBoxItem;

            if (btnSpell3Id.Text == "-NONE-")
            {
                txtSpell3Probability.Text = "";
                currentItem.Template.Probability3 = 0;
                txtSpell3DelayInitialMin.Text = "";
                currentItem.Template.DelayInitialMin3 = 0;
                txtSpell3DelayInitialMax.Text = "";
                currentItem.Template.DelayInitialMax3 = 0;
                txtSpell3DelayRepeatMin.Text = "";
                currentItem.Template.DelayRepeatMin3 = 0;
                txtSpell3DelayRepeatMax.Text = "";
                currentItem.Template.DelayRepeatMax3 = 0;
                cmbSpell3Target.SelectedIndex = -1;
                cmbSpell3Target.SelectedText = "";
                currentItem.Template.CastTarget3 = 0;
                currentItem.Template.CastFlags3 = 0;
                currentItem.Template.ScriptId3 = 0;
            }
            else
            {
                txtSpell3Probability.Text = "100";
                currentItem.Template.Probability3 = 100;
                txtSpell3DelayInitialMin.Text = "0";
                currentItem.Template.DelayInitialMin3 = 0;
                txtSpell3DelayInitialMax.Text = "0";
                currentItem.Template.DelayInitialMax3 = 0;
                txtSpell3DelayRepeatMin.Text = "0";
                currentItem.Template.DelayRepeatMin3 = 0;
                txtSpell3DelayRepeatMax.Text = "0";
                currentItem.Template.DelayRepeatMax3 = 0;
                cmbSpell3Target.SelectedIndex = 1;
                currentItem.Template.CastTarget3 = 1;
            }

            dontUpdate = false;
        }

        private void btnSpell4Id_Click(object sender, EventArgs e)
        {
            if (lstSpellTemplates.SelectedItems.Count == 0)
                return;

            string old_text = btnSpell4Id.Text;

            SetScriptFieldFromDataFinderForm<FormSpellFinder>(btnSpell4Id, null, GameData.FindSpellName, "SpellId4");

            if (((old_text == btnSpell4Id.Text)) || ((old_text != "-NONE-") && (btnSpell4Id.Text != "-NONE-")))
                return;

            dontUpdate = true;

            ListBoxItem currentItem = lstSpellTemplates.SelectedItem as ListBoxItem;

            if (btnSpell4Id.Text == "-NONE-")
            {
                txtSpell4Probability.Text = "";
                currentItem.Template.Probability4 = 0;
                txtSpell4DelayInitialMin.Text = "";
                currentItem.Template.DelayInitialMin4 = 0;
                txtSpell4DelayInitialMax.Text = "";
                currentItem.Template.DelayInitialMax4 = 0;
                txtSpell4DelayRepeatMin.Text = "";
                currentItem.Template.DelayRepeatMin4 = 0;
                txtSpell4DelayRepeatMax.Text = "";
                currentItem.Template.DelayRepeatMax4 = 0;
                cmbSpell4Target.SelectedIndex = -1;
                cmbSpell4Target.SelectedText = "";
                currentItem.Template.CastTarget4 = 0;
                currentItem.Template.CastFlags4 = 0;
                currentItem.Template.ScriptId4 = 0;
            }
            else
            {
                txtSpell4Probability.Text = "100";
                currentItem.Template.Probability4 = 100;
                txtSpell4DelayInitialMin.Text = "0";
                currentItem.Template.DelayInitialMin4 = 0;
                txtSpell4DelayInitialMax.Text = "0";
                currentItem.Template.DelayInitialMax4 = 0;
                txtSpell4DelayRepeatMin.Text = "0";
                currentItem.Template.DelayRepeatMin4 = 0;
                txtSpell4DelayRepeatMax.Text = "0";
                currentItem.Template.DelayRepeatMax4 = 0;
                cmbSpell4Target.SelectedIndex = 1;
                currentItem.Template.CastTarget4 = 1;
            }

            dontUpdate = false;
        }

        private void btnSpell5Id_Click(object sender, EventArgs e)
        {
            if (lstSpellTemplates.SelectedItems.Count == 0)
                return;

            string old_text = btnSpell5Id.Text;

            SetScriptFieldFromDataFinderForm<FormSpellFinder>(btnSpell5Id, null, GameData.FindSpellName, "SpellId5");

            if (((old_text == btnSpell5Id.Text)) || ((old_text != "-NONE-") && (btnSpell5Id.Text != "-NONE-")))
                return;

            dontUpdate = true;

            ListBoxItem currentItem = lstSpellTemplates.SelectedItem as ListBoxItem;

            if (btnSpell5Id.Text == "-NONE-")
            {
                txtSpell5Probability.Text = "";
                currentItem.Template.Probability5 = 0;
                txtSpell5DelayInitialMin.Text = "";
                currentItem.Template.DelayInitialMin5 = 0;
                txtSpell5DelayInitialMax.Text = "";
                currentItem.Template.DelayInitialMax5 = 0;
                txtSpell5DelayRepeatMin.Text = "";
                currentItem.Template.DelayRepeatMin5 = 0;
                txtSpell5DelayRepeatMax.Text = "";
                currentItem.Template.DelayRepeatMax5 = 0;
                cmbSpell5Target.SelectedIndex = -1;
                cmbSpell5Target.SelectedText = "";
                currentItem.Template.CastTarget5 = 0;
                currentItem.Template.CastFlags5 = 0;
                currentItem.Template.ScriptId5 = 0;
            }
            else
            {
                txtSpell5Probability.Text = "100";
                currentItem.Template.Probability5 = 100;
                txtSpell5DelayInitialMin.Text = "0";
                currentItem.Template.DelayInitialMin5 = 0;
                txtSpell5DelayInitialMax.Text = "0";
                currentItem.Template.DelayInitialMax5 = 0;
                txtSpell5DelayRepeatMin.Text = "0";
                currentItem.Template.DelayRepeatMin5 = 0;
                txtSpell5DelayRepeatMax.Text = "0";
                currentItem.Template.DelayRepeatMax5 = 0;
                cmbSpell5Target.SelectedIndex = 1;
                currentItem.Template.CastTarget5 = 1;
            }

            dontUpdate = false;
        }

        private void btnSpell6Id_Click(object sender, EventArgs e)
        {
            if (lstSpellTemplates.SelectedItems.Count == 0)
                return;

            string old_text = btnSpell6Id.Text;

            SetScriptFieldFromDataFinderForm<FormSpellFinder>(btnSpell6Id, null, GameData.FindSpellName, "SpellId6");

            if (((old_text == btnSpell6Id.Text)) || ((old_text != "-NONE-") && (btnSpell6Id.Text != "-NONE-")))
                return;

            dontUpdate = true;

            ListBoxItem currentItem = lstSpellTemplates.SelectedItem as ListBoxItem;

            if (btnSpell6Id.Text == "-NONE-")
            {
                txtSpell6Probability.Text = "";
                currentItem.Template.Probability6 = 0;
                txtSpell6DelayInitialMin.Text = "";
                currentItem.Template.DelayInitialMin6 = 0;
                txtSpell6DelayInitialMax.Text = "";
                currentItem.Template.DelayInitialMax6 = 0;
                txtSpell6DelayRepeatMin.Text = "";
                currentItem.Template.DelayRepeatMin6 = 0;
                txtSpell6DelayRepeatMax.Text = "";
                currentItem.Template.DelayRepeatMax6 = 0;
                cmbSpell6Target.SelectedIndex = -1;
                cmbSpell6Target.SelectedText = "";
                currentItem.Template.CastTarget6 = 0;
                currentItem.Template.CastFlags6 = 0;
                currentItem.Template.ScriptId6 = 0;
            }
            else
            {
                txtSpell6Probability.Text = "100";
                currentItem.Template.Probability6 = 100;
                txtSpell6DelayInitialMin.Text = "0";
                currentItem.Template.DelayInitialMin6 = 0;
                txtSpell6DelayInitialMax.Text = "0";
                currentItem.Template.DelayInitialMax6 = 0;
                txtSpell6DelayRepeatMin.Text = "0";
                currentItem.Template.DelayRepeatMin6 = 0;
                txtSpell6DelayRepeatMax.Text = "0";
                currentItem.Template.DelayRepeatMax6 = 0;
                cmbSpell6Target.SelectedIndex = 1;
                currentItem.Template.CastTarget6 = 1;
            }

            dontUpdate = false;
        }

        private void btnSpell7Id_Click(object sender, EventArgs e)
        {
            if (lstSpellTemplates.SelectedItems.Count == 0)
                return;

            string old_text = btnSpell7Id.Text;

            SetScriptFieldFromDataFinderForm<FormSpellFinder>(btnSpell7Id, null, GameData.FindSpellName, "SpellId7");

            if (((old_text == btnSpell7Id.Text)) || ((old_text != "-NONE-") && (btnSpell7Id.Text != "-NONE-")))
                return;

            dontUpdate = true;

            ListBoxItem currentItem = lstSpellTemplates.SelectedItem as ListBoxItem;

            if (btnSpell7Id.Text == "-NONE-")
            {
                txtSpell7Probability.Text = "";
                currentItem.Template.Probability7 = 0;
                txtSpell7DelayInitialMin.Text = "";
                currentItem.Template.DelayInitialMin7 = 0;
                txtSpell7DelayInitialMax.Text = "";
                currentItem.Template.DelayInitialMax7 = 0;
                txtSpell7DelayRepeatMin.Text = "";
                currentItem.Template.DelayRepeatMin7 = 0;
                txtSpell7DelayRepeatMax.Text = "";
                currentItem.Template.DelayRepeatMax7 = 0;
                cmbSpell7Target.SelectedIndex = -1;
                cmbSpell7Target.SelectedText = "";
                currentItem.Template.CastTarget7 = 0;
                currentItem.Template.CastFlags7 = 0;
                currentItem.Template.ScriptId7 = 0;
            }
            else
            {
                txtSpell7Probability.Text = "100";
                currentItem.Template.Probability7 = 100;
                txtSpell7DelayInitialMin.Text = "0";
                currentItem.Template.DelayInitialMin7 = 0;
                txtSpell7DelayInitialMax.Text = "0";
                currentItem.Template.DelayInitialMax7 = 0;
                txtSpell7DelayRepeatMin.Text = "0";
                currentItem.Template.DelayRepeatMin7 = 0;
                txtSpell7DelayRepeatMax.Text = "0";
                currentItem.Template.DelayRepeatMax7 = 0;
                cmbSpell7Target.SelectedIndex = 1;
                currentItem.Template.CastTarget7 = 1;
            }

            dontUpdate = false;
        }

        private void btnSpell8Id_Click(object sender, EventArgs e)
        {
            if (lstSpellTemplates.SelectedItems.Count == 0)
                return;

            string old_text = btnSpell8Id.Text;

            SetScriptFieldFromDataFinderForm<FormSpellFinder>(btnSpell8Id, null, GameData.FindSpellName, "SpellId8");

            if (((old_text == btnSpell8Id.Text)) || ((old_text != "-NONE-") && (btnSpell8Id.Text != "-NONE-")))
                return;

            dontUpdate = true;

            ListBoxItem currentItem = lstSpellTemplates.SelectedItem as ListBoxItem;

            if (btnSpell8Id.Text == "-NONE-")
            {
                txtSpell8Probability.Text = "";
                currentItem.Template.Probability8 = 0;
                txtSpell8DelayInitialMin.Text = "";
                currentItem.Template.DelayInitialMin8 = 0;
                txtSpell8DelayInitialMax.Text = "";
                currentItem.Template.DelayInitialMax8 = 0;
                txtSpell8DelayRepeatMin.Text = "";
                currentItem.Template.DelayRepeatMin8 = 0;
                txtSpell8DelayRepeatMax.Text = "";
                currentItem.Template.DelayRepeatMax8 = 0;
                cmbSpell8Target.SelectedIndex = -1;
                cmbSpell8Target.SelectedText = "";
                currentItem.Template.CastTarget8 = 0;
                currentItem.Template.CastFlags8 = 0;
                currentItem.Template.ScriptId8 = 0;
            }
            else
            {
                txtSpell8Probability.Text = "100";
                currentItem.Template.Probability8 = 100;
                txtSpell8DelayInitialMin.Text = "0";
                currentItem.Template.DelayInitialMin8 = 0;
                txtSpell8DelayInitialMax.Text = "0";
                currentItem.Template.DelayInitialMax8 = 0;
                txtSpell8DelayRepeatMin.Text = "0";
                currentItem.Template.DelayRepeatMin8 = 0;
                txtSpell8DelayRepeatMax.Text = "0";
                currentItem.Template.DelayRepeatMax8 = 0;
                cmbSpell8Target.SelectedIndex = 1;
                currentItem.Template.CastTarget8 = 1;
            }

            dontUpdate = false;
        }

        private void btnSpell1Edit_Click(object sender, EventArgs e)
        {
            if (lstSpellTemplates.SelectedItems.Count == 0)
                return;

            ListBoxItem currentItem = lstSpellTemplates.SelectedItem as ListBoxItem;

            FormCastFlags flags_form = new FormCastFlags();
            if (flags_form.ShowDialog(ref currentItem.Template.CastFlags1, ref currentItem.Template.ScriptId1, currentItem.Template.CastTarget1, ref currentItem.Template.TargetParam1_1, ref currentItem.Template.TargetParam2_1) == true)
                NewTemplates.Add(currentItem.Id);
        }

        private void btnSpell2Edit_Click(object sender, EventArgs e)
        {
            if (lstSpellTemplates.SelectedItems.Count == 0)
                return;

            ListBoxItem currentItem = lstSpellTemplates.SelectedItem as ListBoxItem;

            FormCastFlags flags_form = new FormCastFlags();
            if (flags_form.ShowDialog(ref currentItem.Template.CastFlags2, ref currentItem.Template.ScriptId2, currentItem.Template.CastTarget2, ref currentItem.Template.TargetParam1_2, ref currentItem.Template.TargetParam2_2) == true)
                NewTemplates.Add(currentItem.Id);
        }

        private void btnSpell3Edit_Click(object sender, EventArgs e)
        {
            if (lstSpellTemplates.SelectedItems.Count == 0)
                return;

            ListBoxItem currentItem = lstSpellTemplates.SelectedItem as ListBoxItem;

            FormCastFlags flags_form = new FormCastFlags();
            if (flags_form.ShowDialog(ref currentItem.Template.CastFlags3, ref currentItem.Template.ScriptId3, currentItem.Template.CastTarget3, ref currentItem.Template.TargetParam1_3, ref currentItem.Template.TargetParam2_3) == true)
                NewTemplates.Add(currentItem.Id);
        }

        private void btnSpell4Edit_Click(object sender, EventArgs e)
        {
            if (lstSpellTemplates.SelectedItems.Count == 0)
                return;

            ListBoxItem currentItem = lstSpellTemplates.SelectedItem as ListBoxItem;

            FormCastFlags flags_form = new FormCastFlags();
            if (flags_form.ShowDialog(ref currentItem.Template.CastFlags4, ref currentItem.Template.ScriptId4, currentItem.Template.CastTarget4, ref currentItem.Template.TargetParam1_4, ref currentItem.Template.TargetParam2_4) == true)
                NewTemplates.Add(currentItem.Id);
        }

        private void btnSpell5Edit_Click(object sender, EventArgs e)
        {
            if (lstSpellTemplates.SelectedItems.Count == 0)
                return;

            ListBoxItem currentItem = lstSpellTemplates.SelectedItem as ListBoxItem;

            FormCastFlags flags_form = new FormCastFlags();
            if (flags_form.ShowDialog(ref currentItem.Template.CastFlags5, ref currentItem.Template.ScriptId5, currentItem.Template.CastTarget5, ref currentItem.Template.TargetParam1_5, ref currentItem.Template.TargetParam2_5) == true)
                NewTemplates.Add(currentItem.Id);
        }

        private void btnSpell6Edit_Click(object sender, EventArgs e)
        {
            if (lstSpellTemplates.SelectedItems.Count == 0)
                return;

            ListBoxItem currentItem = lstSpellTemplates.SelectedItem as ListBoxItem;

            FormCastFlags flags_form = new FormCastFlags();
            if (flags_form.ShowDialog(ref currentItem.Template.CastFlags6, ref currentItem.Template.ScriptId6, currentItem.Template.CastTarget6, ref currentItem.Template.TargetParam1_6, ref currentItem.Template.TargetParam2_6) == true)
                NewTemplates.Add(currentItem.Id);
        }

        private void btnSpell7Edit_Click(object sender, EventArgs e)
        {
            if (lstSpellTemplates.SelectedItems.Count == 0)
                return;

            ListBoxItem currentItem = lstSpellTemplates.SelectedItem as ListBoxItem;

            FormCastFlags flags_form = new FormCastFlags();
            if (flags_form.ShowDialog(ref currentItem.Template.CastFlags7, ref currentItem.Template.ScriptId7, currentItem.Template.CastTarget7, ref currentItem.Template.TargetParam1_7, ref currentItem.Template.TargetParam2_7) == true)
                NewTemplates.Add(currentItem.Id);
        }

        private void btnSpell8Edit_Click(object sender, EventArgs e)
        {
            if (lstSpellTemplates.SelectedItems.Count == 0)
                return;

            ListBoxItem currentItem = lstSpellTemplates.SelectedItem as ListBoxItem;

            FormCastFlags flags_form = new FormCastFlags();
            if (flags_form.ShowDialog(ref currentItem.Template.CastFlags8, ref currentItem.Template.ScriptId8, currentItem.Template.CastTarget8, ref currentItem.Template.TargetParam1_8, ref currentItem.Template.TargetParam2_8) == true)
                NewTemplates.Add(currentItem.Id);
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            ReturnValue = 0;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstSpellTemplates.SelectedItems.Count > 0)
            {
                ListBoxItem selectedItem = lstSpellTemplates.SelectedItem as ListBoxItem;
                ReturnValue = selectedItem.Id;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnValue = 0;
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
    public class ListBoxItem
    {
        public string Name;
        public uint Id;
        public CreatureSpellsInfo Template;
        public ListBoxItem(uint id, string name, CreatureSpellsInfo template)
        {
            Id = id;
            Name = name;
            Template = template;
        }
        public override string ToString()
        {
            return "[" + Id.ToString() + "] " + Name;
        }
    }

}
