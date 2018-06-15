using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormTextFinder : ScriptEditor.FormDataFinder
    {
        public string[] languages;
        public string[] chattypes;
        public FormTextFinder()
        {
            InitializeComponent();

            // Language Names
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

            // Chat Type Names
            chattypes = new string[7];
            chattypes[0] = "Say";
            chattypes[1] = "Yell";
            chattypes[2] = "Emote";
            chattypes[3] = "Zone Emote";
            chattypes[4] = "Whisper";
            chattypes[5] = "Boss Whisper";
            chattypes[6] = "Zone Yell";
        }
        protected override void AddAllData()
        {
            foreach (BroadcastText bc in GameData.BroadcastTextsList)
            {
                AddTextToListView(bc);
            }
        }
        protected override void AddById(uint id)
        {
            foreach (BroadcastText bc in GameData.BroadcastTextsList)
            {
                if (bc.ID == id)
                    AddTextToListView(bc);
            }
        }
        protected override void AddByIdRange(uint minId, uint maxId)
        {
            foreach (BroadcastText bc in GameData.BroadcastTextsList)
            {
                if ((bc.ID >= minId) && (bc.ID <= maxId))
                    AddTextToListView(bc);
            }
        }
        protected override void AddByText(string searchText)
        {
            foreach (BroadcastText bc in GameData.BroadcastTextsList)
            {
                // If content is not numeric search for text.
                if (bc.Text.Contains(searchText))
                    AddTextToListView(bc);
            }
        }
        private void AddTextToListView(BroadcastText bc)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = bc.ID.ToString();
            lvi.SubItems.Add(bc.Text);
            lvi.SubItems.Add(chattypes[bc.ChatType]);
            lvi.SubItems.Add(languages[bc.Language]);

            // Add this broadcast text to the listview.
            lstData.Items.Add(lvi);
        }

        private void FormTextFinder_ResizeEnd(object sender, EventArgs e)
        {
            lstData.Columns[1].Width = lstData.ClientSize.Width - lstData.Columns[0].Width - lstData.Columns[2].Width - lstData.Columns[3].Width;
        }
    }
}
