using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor.DataFinderForms
{
    public partial class FormGameObjectFinder : ScriptEditor.FormDataFinder
    {
        public FormGameObjectFinder()
        {
            InitializeComponent();
        }

        protected override void AddAllData()
        {
            foreach (GameObjectInfo gameobject in GameData.GameObjectInfoList)
            {
                AddGameObjectToListView(gameobject);
            }
        }
        protected override void AddById(uint id)
        {
            foreach (GameObjectInfo gameobject in GameData.GameObjectInfoList)
            {
                if (gameobject.ID == id)
                    AddGameObjectToListView(gameobject);
            }
        }
        protected override void AddByIdRange(uint minId, uint maxId)
        {
            foreach (GameObjectInfo gameobject in GameData.GameObjectInfoList)
            {
                if ((gameobject.ID >= minId) && (gameobject.ID <= maxId))
                    AddGameObjectToListView(gameobject);
            }
        }
        protected override void AddByText(string searchText)
        {
            foreach (GameObjectInfo gameobject in GameData.GameObjectInfoList)
            {
                if (gameobject.Name.Contains(searchText))
                    AddGameObjectToListView(gameobject);
            }
        }
        private void AddGameObjectToListView(GameObjectInfo gameobject)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = gameobject.ID.ToString();
            lvi.SubItems.Add(gameobject.Type.ToString());
            lvi.SubItems.Add(gameobject.DisplayId.ToString());
            lvi.SubItems.Add(gameobject.Name);

            // Add this gameobject to the listview.
            lstData.Items.Add(lvi);
        }
        private void FormGameObjectFinder_ResizeEnd(object sender, EventArgs e)
        {
            lstData.Columns[3].Width = lstData.ClientSize.Width - lstData.Columns[0].Width - lstData.Columns[1].Width - lstData.Columns[2].Width;
        }
    }
}
