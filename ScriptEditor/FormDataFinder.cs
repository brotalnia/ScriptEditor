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
        public uint ReturnValue { get; set; } // we return the chosen id in this

        System.Collections.IComparer textComparer;

        public FormDataFinder()
        {
            InitializeComponent();

            // Create a sorter.
            textComparer = new MixedListSorter();

            // Set minimum size of window.
            this.MinimumSize = this.Size;
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
                ListViewItem selectedText = lstData.SelectedItems[0];
                uint textId;
                uint.TryParse(selectedText.Text, out textId);
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
            lstData.Items.Clear();

            uint itemId;

            if (txtSearch.Text == "") // Display all texts.
            {
                lstData.ListViewItemSorter = null; // Disable sorter or it will take forever.
                AddAllData();
            }
            else if (uint.TryParse(txtSearch.Text, out itemId)) // If content is numeric search for id.
            {
                AddById(itemId);
                lstData.ListViewItemSorter = textComparer;
            }
            else // Add items that contain this text.
            {
                AddByText(txtSearch.Text);
                lstData.ListViewItemSorter = textComparer;
            }
        }
        protected virtual void AddAllData() { }
        protected virtual void AddById(uint id) { }
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
        }
    }
}
