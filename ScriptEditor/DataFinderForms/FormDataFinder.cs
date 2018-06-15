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
    public partial class FormDataFinder : Form
    {
        public int ReturnValue { get; set; } // we return the chosen id in this

        System.Collections.IComparer textComparer;

        public FormDataFinder()
        {
            InitializeComponent();

            // Create a sorter.
            textComparer = new MixedListSorter();

            // Set minimum size of window.
            this.MinimumSize = this.Size;

            // Return item on double click.
            lstData.Activation = ItemActivation.TwoClick;
        }

        public DialogResult ShowDialog(int current_id, bool has_ignore_option = false)
        {
            if (current_id > 0)
            {
                txtSearch.Text = current_id.ToString();
                btnSearch_Click(null, null);
            }

            if (has_ignore_option)
                btnSelectUnchanged.Visible = true;

            return this.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnValue = 0;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstData.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstData.SelectedItems[0];
                uint selectedId;
                uint.TryParse(selectedItem.Text, out selectedId);
                ReturnValue = (int)selectedId;
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

        private bool ExtractIdRange(ref uint minEntryId, ref uint maxEntryId)
        {
            if (txtSearch.Text.Contains("-"))
            {
                string[] idRanges = txtSearch.Text.Split('-');

                if (idRanges.Length == 2)
                {
                    uint minId = 0;
                    uint maxId = 0;
                    if (uint.TryParse(idRanges[0], out minId) && uint.TryParse(idRanges[1], out maxId))
                    {
                        if (minId < maxId)
                        {
                            minEntryId = minId;
                            maxEntryId = maxId;
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstData.Items.Clear();

            uint minEntryId = 0;
            uint maxEntryId = 0;

            if (txtSearch.Text == "") // Display all texts.
            {
                lstData.ListViewItemSorter = null; // Disable sorter or it will take forever.
                AddAllData();
            }
            else if (uint.TryParse(txtSearch.Text, out minEntryId)) // If content is numeric search for id.
            {
                AddById(minEntryId);
                lstData.ListViewItemSorter = textComparer;
            }
            else if (ExtractIdRange(ref minEntryId, ref maxEntryId)) // Check if a range is provided
            {
                if (minEntryId + 1000 < maxEntryId)
                    lstData.ListViewItemSorter = null;
                else
                    lstData.ListViewItemSorter = textComparer;

                AddByIdRange(minEntryId, maxEntryId);
            }
            else // Add items that contain this text.
            {
                AddByText(txtSearch.Text);
                lstData.ListViewItemSorter = textComparer;
            }
        }
        protected virtual void AddAllData() { }
        protected virtual void AddById(uint id) { }
        protected virtual void AddByIdRange(uint minId, uint maxId) { }
        protected virtual void AddByText(string searchText) { }
        private void lstData_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (lstData.ListViewItemSorter == null)
                return;

            // Sort the items when column is clicked.
            MixedListSorter s = (MixedListSorter)lstData.ListViewItemSorter;
            s.Column = e.Column;

            if (s.Order == System.Windows.Forms.SortOrder.Ascending)
                s.Order = System.Windows.Forms.SortOrder.Descending;
            else
                s.Order = System.Windows.Forms.SortOrder.Ascending;
            lstData.Sort();
        }

        private void FormDataFinder_ResizeEnd(object sender, EventArgs e)
        {
            lstData.Width = this.Size.Width - 30;
            lstData.Height = this.Size.Height - lstData.Location.Y - 65;
            btnCancel.Location = new Point(lstData.Size.Width + lstData.Location.X - btnCancel.Size.Width, lstData.Location.Y + lstData.Height + 5);
            btnSelect.Location = new Point(btnCancel.Location.X - btnSelect.Size.Width - 6, btnCancel.Location.Y);
            btnSelectNone.Location = new Point(btnSelect.Location.X - btnSelectNone.Size.Width - 6, btnSelect.Location.Y);
            btnSearch.Location = new Point(lstData.Size.Width + lstData.Location.X - btnSearch.Size.Width, btnSearch.Location.Y);
            txtSearch.Width = btnSearch.Location.X - txtSearch.Location.X - 7;
            btnSelectUnchanged.Location = new Point(btnSelectNone.Location.X - btnSelectUnchanged.Size.Width - 6, btnSelectNone.Location.Y);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearch_Click(this, new EventArgs());
                e.Handled = true;
            }
        }

        private void lstData_ItemActivate(object sender, EventArgs e)
        {
            btnSelect_Click(sender, e);
        }

        private void btnSelectUnchanged_Click(object sender, EventArgs e)
        {
            ReturnValue = -1;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
