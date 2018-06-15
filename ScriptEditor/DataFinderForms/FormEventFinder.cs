using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormEventFinder : ScriptEditor.FormDataFinder
    {
        public FormEventFinder()
        {
            InitializeComponent();
        }
        protected override void AddAllData()
        {
            foreach (GameEventInfo game_event in GameData.GameEventInfoList)
            {
                AddGameEventToListView(game_event);
            }
        }
        protected override void AddById(uint id)
        {
            foreach (GameEventInfo game_event in GameData.GameEventInfoList)
            {
                if (game_event.ID == id)
                    AddGameEventToListView(game_event);
            }
        }
        protected override void AddByIdRange(uint minId, uint maxId)
        {
            foreach (GameEventInfo game_event in GameData.GameEventInfoList)
            {
                if ((game_event.ID >= minId) && (game_event.ID <= maxId))
                    AddGameEventToListView(game_event);
            }
        }
        protected override void AddByText(string searchText)
        {
            foreach (GameEventInfo game_event in GameData.GameEventInfoList)
            {
                if (game_event.Name.Contains(searchText))
                    AddGameEventToListView(game_event);
            }
        }
        private void AddGameEventToListView(GameEventInfo game_event)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = game_event.ID.ToString();
            lvi.SubItems.Add(game_event.Occurrence.ToString());
            lvi.SubItems.Add(game_event.Length.ToString());
            lvi.SubItems.Add(game_event.Name);
            lvi.SubItems.Add("1." + (game_event.PatchMin + 2).ToString());
            lvi.SubItems.Add("1." + (game_event.PatchMax + 2).ToString());

            // Add this game event entry to the listview.
            lstData.Items.Add(lvi);
        }
        private void FormEventFinder_ResizeEnd(object sender, EventArgs e)
        {
            lstData.Columns[3].Width = lstData.ClientSize.Width - lstData.Columns[0].Width - lstData.Columns[1].Width - lstData.Columns[2].Width - lstData.Columns[4].Width - lstData.Columns[5].Width;
        }
    }
}
