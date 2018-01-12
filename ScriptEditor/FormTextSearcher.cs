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
    public partial class FormTextSearcher : Form
    {
        public uint ReturnValue { get; set; } // we return the chosen id in this

        public string[] languages;
        public string[] chattypes;
        System.Collections.IComparer textComparer;

        public FormTextSearcher()
        {
            InitializeComponent();

            // Create a sorter.
            textComparer = new TextSorter();

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
                lstBroadcastTexts.Columns[1].Width = 400; // to avoid horizontal scrollbar
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
                lstBroadcastTexts.ListViewItemSorter = textComparer;
            }
        }

        private void lstBroadcastTexts_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (lstBroadcastTexts.ListViewItemSorter == null)
                return;

            // Sort the texts when column is clicked.
            TextSorter s = (TextSorter)lstBroadcastTexts.ListViewItemSorter;
            s.Column = e.Column;

            if (s.Order == System.Windows.Forms.SortOrder.Ascending)
                s.Order = System.Windows.Forms.SortOrder.Descending;
            else
                s.Order = System.Windows.Forms.SortOrder.Ascending;
            lstBroadcastTexts.Sort();
        }
    }

    // Sorter for the broadcast texts listview.
    class TextSorter : System.Collections.IComparer
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

            int intValue1;

            if (Int32.TryParse(l1.SubItems[Column].Text, out intValue1))
            {
                int intValue2;
                Int32.TryParse(l2.SubItems[Column].Text, out intValue2);

                if (Order == SortOrder.Ascending)
                {
                    return intValue1.CompareTo(intValue2);
                }
                else
                {
                    return intValue2.CompareTo(intValue1);
                }
            }
            else
            {
                string str1 = l1.SubItems[Column].Text;
                string str2 = l2.SubItems[Column].Text;

                if (Order == SortOrder.Ascending)
                {
                    return str1.CompareTo(str2);
                }
                else
                {
                    return str2.CompareTo(str1);
                }
            }
        }
    }
}
