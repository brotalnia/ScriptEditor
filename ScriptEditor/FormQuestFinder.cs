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
    public partial class FormQuestFinder : Form
    {
        public uint ReturnValue { get; set; } // we return the chosen id in this

        System.Collections.IComparer textComparer;

        public FormQuestFinder()
        {
            InitializeComponent();

            // Create a sorter.
            textComparer = new MixedListSorter();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnValue = 0;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstQuests.SelectedItems.Count > 0)
            {
                ListViewItem selectedQuest = lstQuests.SelectedItems[0];
                uint questId;
                UInt32.TryParse(selectedQuest.Text, out questId);
                ReturnValue = questId;
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
            lstQuests.Items.Clear();

            uint questId;

            if (txtSearch.Text == "") // display all texts
            {
                lstQuests.ListViewItemSorter = null; // disable sorter or it will take forever
                lstQuests.Columns[3].Width = 400; // to avoid horizontal scrollbar
                foreach (Form1.QuestInfo quest in Form1.QuestInfoList)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = quest.ID.ToString();
                    lvi.SubItems.Add(quest.MinLevel.ToString());
                    lvi.SubItems.Add(quest.QuestLevel.ToString());
                    lvi.SubItems.Add(quest.Title);
                    
                    // Add this quest to the listview.
                    lstQuests.Items.Add(lvi);
                }
            }
            else if (UInt32.TryParse(txtSearch.Text, out questId))
            {
                foreach (Form1.QuestInfo quest in Form1.QuestInfoList)
                {
                    // If content is numeric search for id.
                    if (quest.ID == questId)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = quest.ID.ToString();
                        lvi.SubItems.Add(quest.MinLevel.ToString());
                        lvi.SubItems.Add(quest.QuestLevel.ToString());
                        lvi.SubItems.Add(quest.Title);

                        // Add this quest to the listview.
                        lstQuests.Items.Add(lvi);
                        break;
                    }
                }
                lstQuests.ListViewItemSorter = textComparer;
            }
            else
            {
                foreach (Form1.QuestInfo quest in Form1.QuestInfoList)
                {
                    // If content is not numeric search for title text.
                    if (quest.Title.Contains(txtSearch.Text))
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = quest.ID.ToString();
                        lvi.SubItems.Add(quest.MinLevel.ToString());
                        lvi.SubItems.Add(quest.QuestLevel.ToString());
                        lvi.SubItems.Add(quest.Title);

                        // Add this quest to the listview.
                        lstQuests.Items.Add(lvi);
                    }
                }
                if (lstQuests.Items.Count > 20)
                    lstQuests.Columns[3].Width = 400; // to avoid horizontal scrollbar
                lstQuests.ListViewItemSorter = textComparer;
            }
        }

        private void lstQuests_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (lstQuests.ListViewItemSorter == null)
                return;

            // Sort the texts when column is clicked.
            MixedListSorter s = (MixedListSorter)lstQuests.ListViewItemSorter;
            s.Column = e.Column;

            if (s.Order == System.Windows.Forms.SortOrder.Ascending)
                s.Order = System.Windows.Forms.SortOrder.Descending;
            else
                s.Order = System.Windows.Forms.SortOrder.Ascending;
            lstQuests.Sort();
        }
    }
}
