using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormSpellFinder : ScriptEditor.FormDataFinder
    {
        public FormSpellFinder()
        {
            InitializeComponent();
        }
        protected override void AddAllData()
        {
            foreach (SpellInfo spell in GameData.SpellInfoList)
            {
                AddSpellToListView(spell);
            }
        }
        protected override void AddById(uint id)
        {
            foreach (SpellInfo spell in GameData.SpellInfoList)
            {
                if (spell.ID == id)
                    AddSpellToListView(spell);
            }
        }
        protected override void AddByIdRange(uint minId, uint maxId)
        {
            foreach (SpellInfo spell in GameData.SpellInfoList)
            {
                if ((spell.ID >= minId) && (spell.ID <= maxId))
                    AddSpellToListView(spell);
            }
        }
        protected override void AddByText(string searchText)
        {
            foreach (SpellInfo spell in GameData.SpellInfoList)
            {
                // If content is not numeric search for text.
                if (spell.Name.Contains(searchText) || spell.Description.Contains(searchText))
                    AddSpellToListView(spell);
            }
        }
        private void AddSpellToListView(SpellInfo spell)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = spell.ID.ToString();
            lvi.SubItems.Add(GameData.FindSpellEffectName(spell.Effect1));
            lvi.SubItems.Add(GameData.FindSpellEffectName(spell.Effect2));
            lvi.SubItems.Add(GameData.FindSpellEffectName(spell.Effect3));
            lvi.SubItems.Add(spell.Name);
            lvi.SubItems.Add(spell.Description);

            // Add this spell to the listview.
            lstData.Items.Add(lvi);
        }
        private void FormSpellFinder_ResizeEnd(object sender, EventArgs e)
        {
            lstData.Columns[5].Width = lstData.ClientSize.Width - lstData.Columns[0].Width - lstData.Columns[1].Width - lstData.Columns[2].Width - lstData.Columns[3].Width - lstData.Columns[4].Width;
        }
    }
}
