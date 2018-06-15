using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormQuestFinder : ScriptEditor.FormDataFinder
    {
        public FormQuestFinder()
        {
            InitializeComponent();
        }

        protected override void AddAllData()
        {
            foreach (QuestInfo quest in GameData.QuestInfoList)
            {
                AddQuestToListView(quest);
            }
        }
        protected override void AddById(uint id)
        {
            foreach (QuestInfo quest in GameData.QuestInfoList)
            {
                if (quest.ID == id)
                    AddQuestToListView(quest);
            }
        }
        protected override void AddByIdRange(uint minId, uint maxId)
        {
            foreach (QuestInfo quest in GameData.QuestInfoList)
            {
                if ((quest.ID >= minId) && (quest.ID <= maxId))
                    AddQuestToListView(quest);
            }
        }
        protected override void AddByText(string searchText)
        {
            foreach (QuestInfo quest in GameData.QuestInfoList)
            {
                if (quest.Title.Contains(searchText))
                    AddQuestToListView(quest);
            }
        }
        private void AddQuestToListView(QuestInfo quest)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = quest.ID.ToString();
            lvi.SubItems.Add(quest.MinLevel.ToString());
            lvi.SubItems.Add(quest.QuestLevel.ToString());
            lvi.SubItems.Add(quest.Title);

            // Add this quest to the listview.
            lstData.Items.Add(lvi);
        }

        private void FormQuestFinder_ResizeEnd(object sender, EventArgs e)
        {
            lstData.Columns[3].Width = lstData.ClientSize.Width - lstData.Columns[0].Width - lstData.Columns[1].Width - lstData.Columns[2].Width;
        }
    }
}
