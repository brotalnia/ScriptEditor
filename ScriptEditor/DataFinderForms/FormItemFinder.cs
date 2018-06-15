using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormItemFinder : ScriptEditor.FormDataFinder
    {
        public FormItemFinder()
        {
            InitializeComponent();
        }
        protected override void AddAllData()
        {
            foreach (ItemInfo item in GameData.ItemInfoList)
            {
                AddItemToListView(item);
            }
        }
        protected override void AddById(uint id)
        {
            foreach (ItemInfo item in GameData.ItemInfoList)
            {
                if (item.ID == id)
                    AddItemToListView(item);
            }
        }
        protected override void AddByIdRange(uint minId, uint maxId)
        {
            foreach (ItemInfo item in GameData.ItemInfoList)
            {
                if ((item.ID >= minId) && (item.ID <= maxId))
                    AddItemToListView(item);
            }
        }
        protected override void AddByText(string searchText)
        {
            foreach (ItemInfo item in GameData.ItemInfoList)
            {
                if (item.Name.Contains(searchText))
                    AddItemToListView(item);
            }
        }
        private void AddItemToListView(ItemInfo item)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = item.ID.ToString();
            lvi.SubItems.Add(item.RequiredLevel.ToString());
            lvi.SubItems.Add(item.ItemLevel.ToString());
            lvi.SubItems.Add(item.Name);

            // Add this item to the listview.
            lstData.Items.Add(lvi);
        }
        private void FormItemFinder_ResizeEnd(object sender, EventArgs e)
        {
            lstData.Columns[3].Width = lstData.ClientSize.Width - lstData.Columns[0].Width - lstData.Columns[1].Width - lstData.Columns[2].Width;
        }
    }
}
