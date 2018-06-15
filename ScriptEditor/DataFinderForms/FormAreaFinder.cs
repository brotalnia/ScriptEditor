using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormAreaFinder : ScriptEditor.FormDataFinder
    {
        public FormAreaFinder()
        {
            InitializeComponent();
        }
        protected override void AddAllData()
        {
            foreach (AreaInfo area in GameData.AreaInfoList)
            {
                AddAreaToListView(area);
            }
        }
        protected override void AddById(uint id)
        {
            foreach (AreaInfo area in GameData.AreaInfoList)
            {
                if (area.ID == id)
                    AddAreaToListView(area);
            }
        }
        protected override void AddByIdRange(uint minId, uint maxId)
        {
            foreach (AreaInfo area in GameData.AreaInfoList)
            {
                if ((area.ID >= minId) && (area.ID <= maxId))
                    AddAreaToListView(area);
            }
        }
        protected override void AddByText(string searchText)
        {
            foreach (AreaInfo area in GameData.AreaInfoList)
            {
                if (area.Name.Contains(searchText))
                    AddAreaToListView(area);
            }
        }
        private void AddAreaToListView(AreaInfo area)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = area.ID.ToString();
            lvi.SubItems.Add(area.Map.ToString());
            lvi.SubItems.Add(area.Zone.ToString());
            lvi.SubItems.Add(area.Name);

            // Add this area to the listview.
            lstData.Items.Add(lvi);
        }
        private void FormAreaFinder_ResizeEnd(object sender, EventArgs e)
        {
            lstData.Columns[3].Width = lstData.ClientSize.Width - lstData.Columns[0].Width - lstData.Columns[1].Width - lstData.Columns[2].Width;
        }
    }
}
