using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormWeaponFinder : ScriptEditor.FormDataFinder
    {
        public string[] inventorytypes;
        public FormWeaponFinder()
        {
            InitializeComponent();

            inventorytypes = new string[27];
            inventorytypes[13] = "One-Hand";
            inventorytypes[14] = "Shield";
            inventorytypes[15] = "Ranged";
            inventorytypes[17] = "Two-Hand";
            inventorytypes[21] = "Main-Hand";
            inventorytypes[22] = "Off-Hand";
            inventorytypes[23] = "Holdable";
            inventorytypes[25] = "Thrown";
            inventorytypes[26] = "Ranged";
        }
        protected override void AddAllData()
        {
            foreach (ItemInfo item in GameData.ItemInfoList)
            {
                if (item.IsHoldable())
                    AddItemToListView(item);
            }
        }
        protected override void AddById(uint id)
        {
            foreach (ItemInfo item in GameData.ItemInfoList)
            {
                if ((item.ID == id) && item.IsHoldable())
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
                if (item.Name.Contains(searchText) && item.IsHoldable())
                    AddItemToListView(item);
            }
        }
        private void AddItemToListView(ItemInfo item)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = item.ID.ToString();
            lvi.SubItems.Add(inventorytypes[item.InventoryType]);
            lvi.SubItems.Add(item.DisplayId.ToString());
            lvi.SubItems.Add(item.Name);

            // Add this item to the listview.
            lstData.Items.Add(lvi);
        }

        private void FormWeaponFinder_ResizeEnd(object sender, EventArgs e)
        {
            lstData.Columns[3].Width = lstData.ClientSize.Width - lstData.Columns[0].Width - lstData.Columns[1].Width - lstData.Columns[2].Width;
        }
    }
}
