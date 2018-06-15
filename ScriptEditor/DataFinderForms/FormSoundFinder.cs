using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormSoundFinder : ScriptEditor.FormDataFinder
    {
        public FormSoundFinder()
        {
            InitializeComponent();
        }
        protected override void AddAllData()
        {
            foreach (SoundInfo sound in GameData.SoundInfoList)
            {
                AddSoundToListView(sound);
            }
        }
        protected override void AddById(uint id)
        {
            foreach (SoundInfo sound in GameData.SoundInfoList)
            {
                if (sound.ID == id)
                    AddSoundToListView(sound);
            }
        }
        protected override void AddByIdRange(uint minId, uint maxId)
        {
            foreach (SoundInfo sound in GameData.SoundInfoList)
            {
                if ((sound.ID >= minId) && (sound.ID <= maxId))
                    AddSoundToListView(sound);
            }
        }
        protected override void AddByText(string searchText)
        {
            foreach (SoundInfo sound in GameData.SoundInfoList)
            {
                if (sound.Name.Contains(searchText))
                    AddSoundToListView(sound);
            }
        }
        private void AddSoundToListView(SoundInfo sound)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = sound.ID.ToString();
            lvi.SubItems.Add(sound.Name);

            // Add this sound entry to the listview.
            lstData.Items.Add(lvi);
        }
        private void FormSoundFinder_ResizeEnd(object sender, EventArgs e)
        {
            lstData.Columns[1].Width = lstData.ClientSize.Width - lstData.Columns[0].Width;
        }
    }
}
