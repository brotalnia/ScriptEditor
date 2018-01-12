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
    public partial class FormTextFinder : Form
    {
        public uint ReturnValue { get; set; } // we return the chosen id in this

        public string[] languages;
        public string[] chattypes;
        System.Collections.IComparer textComparer;

        public FormTextFinder()
        {
            InitializeComponent();

            // Create a sorter.
            textComparer = new MixedListSorter();

            // Handling language names this way so i don't have to make a switch case.
            languages = new string[34];
            languages[0] = "Universal";
            languages[1] = "Orcish";
            languages[2] = "Darnassian";
            languages[3] = "Taurahe";
            languages[6] = "Dwarvish";
            languages[7] = "Common";
            languages[8] = "Demonic";
            languages[9] = "Titan";
            languages[10] = "Thalassian";
            languages[11] = "Draconic";
            languages[12] = "Kalimag";
            languages[13] = "Gnomish";
            languages[14] = "Troll";
            languages[33] = "Gutterspeak";

            // Same for chat type.
            chattypes = new string[7];
            chattypes[0] = "Say";
            chattypes[1] = "Yell";
            chattypes[2] = "Emote";
            chattypes[3] = "Zone Emote";
            chattypes[4] = "Whisper";
            chattypes[5] = "Boss Whisper";
            chattypes[6] = "Zone Yell";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnValue = 0;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstBroadcastTexts.SelectedItems.Count > 0)
            {
                ListViewItem selectedText = lstBroadcastTexts.SelectedItems[0];
                uint textId;
                UInt32.TryParse(selectedText.Text, out textId);
                ReturnValue = textId;
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
            lstBroadcastTexts.Items.Clear();

            uint textId;

            if (txtSearch.Text == "") // display all texts
            {
                lstBroadcastTexts.ListViewItemSorter = null; // disable sorter or it will take forever
                lstBroadcastTexts.Columns[1].Width = 400; // to avoid horizontal scrollbar
                foreach (Form1.BroadcastText bc in Form1.BroadcastTextsList)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = bc.ID.ToString();
                    lvi.SubItems.Add(bc.Text);
                    lvi.SubItems.Add(chattypes[bc.ChatType]);
                    lvi.SubItems.Add(languages[bc.Language]);

                    // Add this broadcast text to the listview.
                    lstBroadcastTexts.Items.Add(lvi);
                }
            }
            else if (UInt32.TryParse(txtSearch.Text, out textId))
            {
                foreach (Form1.BroadcastText bc in Form1.BroadcastTextsList)
                {
                    // If content is numeric search for id.
                    if (bc.ID == textId)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = bc.ID.ToString();
                        lvi.SubItems.Add(bc.Text);
                        lvi.SubItems.Add(chattypes[bc.ChatType]);
                        lvi.SubItems.Add(languages[bc.Language]);

                        // Add this broadcast text to the listview.
                        lstBroadcastTexts.Items.Add(lvi);
                        break;
                    }
                }
                lstBroadcastTexts.ListViewItemSorter = textComparer;
            }
            else
            {
                foreach (Form1.BroadcastText bc in Form1.BroadcastTextsList)
                {
                    // If content is not numeric search for text.
                    if (bc.Text.Contains(txtSearch.Text))
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = bc.ID.ToString();
                        lvi.SubItems.Add(bc.Text);
                        lvi.SubItems.Add(chattypes[bc.ChatType]);
                        lvi.SubItems.Add(languages[bc.Language]);

                        // Add this broadcast text to the listview.
                        lstBroadcastTexts.Items.Add(lvi);
                    }
                }
                if (lstBroadcastTexts.Items.Count > 20)
                    lstBroadcastTexts.Columns[1].Width = 400; // to avoid horizontal scrollbar
                lstBroadcastTexts.ListViewItemSorter = textComparer;
            }
        }

        private void lstBroadcastTexts_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (lstBroadcastTexts.ListViewItemSorter == null)
                return;

            // Sort the texts when column is clicked.
            MixedListSorter s = (MixedListSorter)lstBroadcastTexts.ListViewItemSorter;
            s.Column = e.Column;

            if (s.Order == System.Windows.Forms.SortOrder.Ascending)
                s.Order = System.Windows.Forms.SortOrder.Descending;
            else
                s.Order = System.Windows.Forms.SortOrder.Ascending;
            lstBroadcastTexts.Sort();
        }
    }
}
