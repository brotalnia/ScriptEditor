using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormCastFlags : Form
    {
        public FormCastFlags()
        {
            InitializeComponent();
        }
        // Returns true if any values were changed.
        public bool ShowDialog(ref uint flags, ref uint script)
        {
            // --------
            // Assigning initial values to form controls.
            // --------

            txtScriptId.Text = script.ToString();

            // CF_INTERRUPT_PREVIOUS
            if ((flags & 1) != 0)
                chkCastFlag1.Checked = true;

            // CF_TRIGGERED
            if ((flags & 2) != 0)
                chkCastFlag2.Checked = true;

            // CF_FORCE_CAST
            if ((flags & 4) != 0)
                chkCastFlag4.Checked = true;

            // CF_MAIN_RANGED_SPELL
            if ((flags & 8) != 0)
                chkCastFlag8.Checked = true;

            // CF_TARGET_CASTS_ON_SELF
            if ((flags & 16) != 0)
                chkCastFlag16.Checked = true;

            // CF_AURA_NOT_PRESENT
            if ((flags & 32) != 0)
                chkCastFlag32.Checked = true;

            // Show the form.
            this.ShowDialog();

            // --------
            // Get the new values.
            // --------

            uint new_flags = 0;

            // CF_INTERRUPT_PREVIOUS
            if (chkCastFlag1.Checked)
                new_flags += 1;

            // CF_TRIGGERED
            if (chkCastFlag2.Checked)
                new_flags += 2;

            // CF_FORCE_CAST
            if (chkCastFlag4.Checked)
                new_flags += 4;

            // CF_MAIN_RANGED_SPELL
            if (chkCastFlag8.Checked)
                new_flags += 8;

            // CF_TARGET_CASTS_ON_SELF
            if (chkCastFlag16.Checked)
                new_flags += 16;

            // CF_AURA_NOT_PRESENT
            if (chkCastFlag32.Checked)
                new_flags += 32;

            uint new_script = 0;
            uint.TryParse(txtScriptId.Text, out new_script);

            if ((flags == new_flags) && (script == new_script))
                return false;

            // Return new values.
            flags = new_flags;
            script = new_script;

            return true;
        }

        private void btnEditScript_Click(object sender, EventArgs e)
        {
            uint script_id = 0;
            uint.TryParse(txtScriptId.Text, out script_id);
            if (script_id > 0)
            {
                FormScriptEditor script_editor = new FormScriptEditor();
                script_editor.Show();
                script_editor.LoadScript(script_id, "creature_spells_scripts");
            }
        }
    }
}
