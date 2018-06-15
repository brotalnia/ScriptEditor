using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormCreatureFinder : ScriptEditor.FormDataFinder
    {
        public FormCreatureFinder()
        {
            InitializeComponent();
        }
        protected override void AddAllData()
        {
            foreach (CreatureInfo creature in GameData.CreatureInfoList)
            {
                AddCreatureToListView(creature);
            }
        }
        protected override void AddById(uint id)
        {
            foreach (CreatureInfo creature in GameData.CreatureInfoList)
            {
                if (creature.ID == id)
                    AddCreatureToListView(creature);
            }
        }
        protected override void AddByIdRange(uint minId, uint maxId)
        {
            foreach (CreatureInfo creature in GameData.CreatureInfoList)
            {
                if ((creature.ID >= minId) && (creature.ID <= maxId))
                    AddCreatureToListView(creature);
            }
        }
        protected override void AddByText(string searchText)
        {
            foreach (CreatureInfo creature in GameData.CreatureInfoList)
            {
                if (creature.Name.Contains(searchText))
                    AddCreatureToListView(creature);
            }
        }
        private void AddCreatureToListView(CreatureInfo creature)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = creature.ID.ToString();
            if (creature.MinLevel != creature.MaxLevel)
                lvi.SubItems.Add(creature.MinLevel.ToString() + " - " + creature.MaxLevel.ToString());
            else
                lvi.SubItems.Add(creature.MinLevel.ToString());
            lvi.SubItems.Add(GameData.CreatureRanksList[(int)creature.Rank].Text);
            lvi.SubItems.Add(creature.Name);

            // Add this creature to the listview.
            lstData.Items.Add(lvi);
        }

        private void FormCreatureFinder_ResizeEnd(object sender, EventArgs e)
        {
            lstData.Columns[3].Width = lstData.ClientSize.Width - lstData.Columns[0].Width - lstData.Columns[1].Width - lstData.Columns[2].Width;
        }
    }
}
