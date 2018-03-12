using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormCastsEditor : Form
    {
        public static readonly List<ComboboxPair> TargetTypes = new List<ComboboxPair>();
        public uint ReturnValue { get; set; }

        public FormCastsEditor(uint id = 0)
        {
            InitializeComponent();
            ReturnValue = id;
        }

        private void FormCastsEditor_Load(object sender, EventArgs e)
        {
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
               new ComboboxPair("Friendly", 14),
               new ComboboxPair("Friendly Injured", 15)
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
        }
        private void ResetAllControls()
        {
            txtName.Text = "";
            lblUsedBy.Text = "Used:";
            lblUsedBy.Location = new Point(cmbUsedBy.Location.X - lblUsedBy.Size.Width - 4, lblUsedBy.Location.Y);
            cmbUsedBy.Items.Clear();
            cmbUsedBy.Text = "";

            txtSpell1Availability.Text = "";
            txtSpell2Availability.Text = "";
            txtSpell3Availability.Text = "";
            txtSpell4Availability.Text = "";
            txtSpell5Availability.Text = "";
            txtSpell6Availability.Text = "";
            txtSpell7Availability.Text = "";
            txtSpell8Availability.Text = "";

            btnSpell1Id.Text = "-NONE-";
            btnSpell2Id.Text = "-NONE-";
            btnSpell3Id.Text = "-NONE-";
            btnSpell4Id.Text = "-NONE-";
            btnSpell5Id.Text = "-NONE-";
            btnSpell6Id.Text = "-NONE-";
            btnSpell7Id.Text = "-NONE-";
            btnSpell8Id.Text = "-NONE-";

            cmbSpell1Target.SelectedIndex = 0;
            cmbSpell1Target.Text = "";
            cmbSpell2Target.SelectedIndex = 0;
            cmbSpell2Target.Text = "";
            cmbSpell3Target.SelectedIndex = 0;
            cmbSpell3Target.Text = "";
            cmbSpell4Target.SelectedIndex = 0;
            cmbSpell4Target.Text = "";
            cmbSpell5Target.SelectedIndex = 0;
            cmbSpell5Target.Text = "";
            cmbSpell6Target.SelectedIndex = 0;
            cmbSpell6Target.Text = "";
            cmbSpell7Target.SelectedIndex = 0;
            cmbSpell7Target.Text = "";
            cmbSpell8Target.SelectedIndex = 0;
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
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            lstSpellTemplates.Items.Clear();
            frmData.Enabled = false;
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
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnFilter_Click(this, new EventArgs());
            }
        }

        private void lstSpellTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetAllControls();

            if (lstSpellTemplates.SelectedItems.Count == 0)
            {
                frmData.Enabled = false;
                return;
            }

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

            // Add spell name to buttons.
            if (lbi.Template.SpellId1 > 0)
                btnSpell1Id.Text = GameData.FindSpellName(lbi.Template.SpellId1) + " (" + lbi.Template.SpellId1.ToString() + ")";
            if (lbi.Template.SpellId2 > 0)
                btnSpell2Id.Text = GameData.FindSpellName(lbi.Template.SpellId2) + " (" + lbi.Template.SpellId2.ToString() + ")";
            if (lbi.Template.SpellId3 > 0)
                btnSpell3Id.Text = GameData.FindSpellName(lbi.Template.SpellId3) + " (" + lbi.Template.SpellId3.ToString() + ")";
            if (lbi.Template.SpellId4 > 0)
                btnSpell4Id.Text = GameData.FindSpellName(lbi.Template.SpellId4) + " (" + lbi.Template.SpellId4.ToString() + ")";
            if (lbi.Template.SpellId5 > 0)
                btnSpell5Id.Text = GameData.FindSpellName(lbi.Template.SpellId5) + " (" + lbi.Template.SpellId5.ToString() + ")";
            if (lbi.Template.SpellId6 > 0)
                btnSpell6Id.Text = GameData.FindSpellName(lbi.Template.SpellId6) + " (" + lbi.Template.SpellId6.ToString() + ")";
            if (lbi.Template.SpellId7 > 0)
                btnSpell7Id.Text = GameData.FindSpellName(lbi.Template.SpellId7) + " (" + lbi.Template.SpellId7.ToString() + ")";
            if (lbi.Template.SpellId8 > 0)
                btnSpell8Id.Text = GameData.FindSpellName(lbi.Template.SpellId8) + " (" + lbi.Template.SpellId8.ToString() + ")";

            frmData.Enabled = true;
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
