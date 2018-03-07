using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormConditionFinder : ScriptEditor.FormDataFinder
    {
        public FormConditionFinder()
        {
            InitializeComponent();
        }

        protected override void AddAllData()
        {
            foreach (ConditionInfo condition in GameData.ConditionInfoList)
            {
                AddConditionToListView(condition);
            }
        }
        protected override void AddById(uint id)
        {
            foreach (ConditionInfo condition in GameData.ConditionInfoList)
            {
                if (condition.ID == id)
                    AddConditionToListView(condition);
            }
        }
        private void AddConditionToListView(ConditionInfo condition)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = condition.ID.ToString();
            lvi.SubItems.Add(GameData.FindConditionName(condition.Type));
            lvi.SubItems.Add(condition.Value1.ToString());
            lvi.SubItems.Add(condition.Value2.ToString());
            lvi.SubItems.Add(condition.Flags.ToString());

            // Add this condition to the listview.
            lstData.Items.Add(lvi);
        }
    }
}
