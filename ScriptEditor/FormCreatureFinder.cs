using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormCreatureFinder : Form
    {
        public uint ReturnValue { get; set; } // we return the chosen id in this

        System.Collections.IComparer listSorter;

        public FormCreatureFinder()
        {
            InitializeComponent();

            // Create a sorter.
            listSorter = new MixedListSorter();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnValue = 0;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstCreatures.SelectedItems.Count > 0)
            {
                ListViewItem selectedQuest = lstCreatures.SelectedItems[0];
                uint creatureId;
                UInt32.TryParse(selectedQuest.Text, out creatureId);
                ReturnValue = creatureId;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            ReturnValue = 0;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstCreatures.Items.Clear();

            uint creatureId;

            if (txtSearch.Text == "") // display all texts
            {
                lstCreatures.ListViewItemSorter = null; // disable sorter or it will take forever
                lstCreatures.Columns[3].Width = 400; // to avoid horizontal scrollbar
                foreach (CreatureInfo creature in GameData.CreatureInfoList)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = creature.ID.ToString();
                    lvi.SubItems.Add(creature.MinLevel.ToString() + " - " + creature.MaxLevel.ToString());
                    lvi.SubItems.Add(GameData.CreatureRanksList[(int)creature.Rank].Text);
                    lvi.SubItems.Add(creature.Name);
                    
                    // Add this quest to the listview.
                    lstCreatures.Items.Add(lvi);
                }
            }
            else if (UInt32.TryParse(txtSearch.Text, out creatureId))
            {
                foreach (CreatureInfo creature in GameData.CreatureInfoList)
                {
                    // If content is numeric search for id.
                    if (creature.ID == creatureId)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = creature.ID.ToString();
                        lvi.SubItems.Add(creature.MinLevel.ToString() + " - " + creature.MaxLevel.ToString());
                        lvi.SubItems.Add(GameData.CreatureRanksList[(int)creature.Rank].Text);
                        lvi.SubItems.Add(creature.Name);

                        // Add this quest to the listview.
                        lstCreatures.Items.Add(lvi);
                        break;
                    }
                }
                lstCreatures.ListViewItemSorter = listSorter;
            }
            else
            {
                foreach (CreatureInfo creature in GameData.CreatureInfoList)
                {
                    // If content is not numeric search for title text.
                    if (creature.Name.Contains(txtSearch.Text))
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = creature.ID.ToString();
                        lvi.SubItems.Add(creature.MinLevel.ToString() + " - " + creature.MaxLevel.ToString());
                        lvi.SubItems.Add(GameData.CreatureRanksList[(int)creature.Rank].Text);
                        lvi.SubItems.Add(creature.Name);

                        // Add this quest to the listview.
                        lstCreatures.Items.Add(lvi);
                    }
                }
                if (lstCreatures.Items.Count > 20)
                    lstCreatures.Columns[3].Width = 400; // to avoid horizontal scrollbar
                lstCreatures.ListViewItemSorter = listSorter;
            }
        }

        private void lstQuests_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (lstCreatures.ListViewItemSorter == null)
                return;

            // Sort the texts when column is clicked.
            MixedListSorter s = (MixedListSorter)lstCreatures.ListViewItemSorter;
            s.Column = e.Column;

            if (s.Order == System.Windows.Forms.SortOrder.Ascending)
                s.Order = System.Windows.Forms.SortOrder.Descending;
            else
                s.Order = System.Windows.Forms.SortOrder.Ascending;
            lstCreatures.Sort();
        }
    }
}
