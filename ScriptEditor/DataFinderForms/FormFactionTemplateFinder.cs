using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormFactionTemplateFinder : ScriptEditor.FormDataFinder
    {
        public FormFactionTemplateFinder()
        {
            InitializeComponent();
        }
        protected override void AddAllData()
        {
            foreach (FactionTemplateInfo faction in GameData.FactionTemplateInfoList)
            {
                AddFactionToListView(faction);
            }
        }
        protected override void AddById(uint id)
        {
            foreach (FactionTemplateInfo faction in GameData.FactionTemplateInfoList)
            {
                if (faction.ID == id)
                    AddFactionToListView(faction);
            }
        }
        protected override void AddByIdRange(uint minId, uint maxId)
        {
            foreach (FactionTemplateInfo faction in GameData.FactionTemplateInfoList)
            {
                if ((faction.ID >= minId) && (faction.ID <= maxId))
                    AddFactionToListView(faction);
            }
        }
        protected override void AddByText(string searchText)
        {
            foreach (FactionTemplateInfo faction in GameData.FactionTemplateInfoList)
            {
                if (GameData.FindFactionName(faction.FactionId).Contains(searchText))
                    AddFactionToListView(faction);
            }
        }
        private void AddFactionToListView(FactionTemplateInfo factiontemplate)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = factiontemplate.ID.ToString();
            lvi.SubItems.Add(factiontemplate.FactionId.ToString());
            lvi.SubItems.Add(factiontemplate.Flags.ToString());

            string faction_name = "";
            string faction_description = "";

            // Find the name and description of the associated faction.
            foreach (FactionInfo faction in GameData.FactionInfoList)
            {
                if (faction.ID == factiontemplate.FactionId)
                {
                    faction_name = faction.Name;
                    faction_description = faction.Description;
                    break;
                }
            }
            lvi.SubItems.Add(faction_name);
            lvi.SubItems.Add(faction_description);

            // Add this faction to the listview.
            lstData.Items.Add(lvi);
        }
        private void FormFactionTemplateFinder_ResizeEnd(object sender, EventArgs e)
        {
            lstData.Columns[4].Width = lstData.ClientSize.Width - lstData.Columns[0].Width - lstData.Columns[1].Width - lstData.Columns[2].Width - lstData.Columns[3].Width;
        }
    }
}
