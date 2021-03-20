using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormFactionFinder : ScriptEditor.FormDataFinder
    {
        public FormFactionFinder()
        {
            InitializeComponent();
        }
        protected override void AddAllData()
        {
            foreach (FactionInfo faction in GameData.FactionInfoList)
            {
                AddFactionToListView(faction);
            }
        }
        protected override void AddById(uint id)
        {
            foreach (FactionInfo faction in GameData.FactionInfoList)
            {
                if (faction.ID == id)
                    AddFactionToListView(faction);
            }
        }
        protected override void AddByIdRange(uint minId, uint maxId)
        {
            foreach (FactionInfo faction in GameData.FactionInfoList)
            {
                if ((faction.ID >= minId) && (faction.ID <= maxId))
                    AddFactionToListView(faction);
            }
        }
        protected override void AddByText(string searchText)
        {
            foreach (FactionInfo faction in GameData.FactionInfoList)
            {
                if (faction.Name.ToUpper().Contains(searchText))
                    AddFactionToListView(faction);
            }
        }
        private void AddFactionToListView(FactionInfo faction)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = faction.ID.ToString();
            lvi.SubItems.Add(faction.Reputation.ToString());
            lvi.SubItems.Add(faction.Team.ToString());
            lvi.SubItems.Add(faction.Name);
            lvi.SubItems.Add(faction.Description);

            // Add this faction to the listview.
            lstData.Items.Add(lvi);
        }
        private void FormFactionFinder_ResizeEnd(object sender, EventArgs e)
        {
            lstData.Columns[4].Width = lstData.ClientSize.Width - lstData.Columns[0].Width - lstData.Columns[1].Width - lstData.Columns[2].Width - lstData.Columns[3].Width;
        }
    }
}
