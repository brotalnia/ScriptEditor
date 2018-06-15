using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormTaxiFinder : ScriptEditor.FormDataFinder
    {
        public FormTaxiFinder()
        {
            InitializeComponent();
        }
        protected override void AddAllData()
        {
            foreach (TaxiInfo path in GameData.TaxiInfoList)
            {
                AddPathToListView(path);
            }
        }
        protected override void AddById(uint id)
        {
            foreach (TaxiInfo path in GameData.TaxiInfoList)
            {
                if (path.ID == id)
                    AddPathToListView(path);
            }
        }
        protected override void AddByIdRange(uint minId, uint maxId)
        {
            foreach (TaxiInfo path in GameData.TaxiInfoList)
            {
                if ((path.ID >= minId) && (path.ID <= maxId))
                    AddPathToListView(path);
            }
        }
        protected override void AddByText(string searchText)
        {
            foreach (TaxiInfo path in GameData.TaxiInfoList)
            {
                if (path.Source.Contains(searchText) || path.Destination.Contains(searchText))
                    AddPathToListView(path);
            }
        }
        private void AddPathToListView(TaxiInfo path)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = path.ID.ToString();
            lvi.SubItems.Add(path.Source);
            lvi.SubItems.Add(path.Destination);

            // Add this taxi path to the listview.
            lstData.Items.Add(lvi);
        }
        private void FormTaxiFinder_ResizeEnd(object sender, EventArgs e)
        {
            lstData.Columns[1].Width = (lstData.ClientSize.Width - lstData.Columns[0].Width) / 2;
            lstData.Columns[2].Width = (lstData.ClientSize.Width - lstData.Columns[0].Width) / 2;
        }
    }
}
