﻿using System;
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
        uint selectFlags = 0;
        public FormCastFlags()
        {
            InitializeComponent();
        }
        // Returns true if any values were changed.
        public bool ShowDialog(ref uint flags, ref uint script, uint targettype, ref uint targetparam1, ref uint targetparam2)
        {
            // --------
            // Assigning initial values to form controls.
            // --------

            switch (targettype)
            {
                case 2: // Second Aggro
                case 3: // Last Aggro
                case 4: // Random
                case 5: // Random Not Top
                case 6: // Nearest
                case 7: // Farthest
                {
                    grpTargetParams.Enabled = true;
                    lblTargetParam1.Text = "Select Flags:";
                    if (targetparam1 != 0)
                        btnTargetParam1.Text = targetparam1.ToString();
                    selectFlags = targetparam1;
                    txtTargetParam1.Text = targetparam1.ToString();
                    btnTargetParam1.Visible = true;
                    break;
                }
                case 16: // Friendly
                {
                    grpTargetParams.Enabled = true;
                    lblTargetParam1.Text = "Radius:";
                    lblTargetParam2.Text = "Exclude self:";
                    txtTargetParam1.Enabled = true;
                    txtTargetParam2.Enabled = true;
                    txtTargetParam1.Text = targetparam1.ToString();
                    txtTargetParam2.Text = targetparam2.ToString();
                    break;
                }
                case 17: // Friendly Injured
                case 18: // Friendly Injured Not Self
                {
                    grpTargetParams.Enabled = true;
                    lblTargetParam1.Text = "Radius:";
                    lblTargetParam2.Text = "HP Percent:";
                    txtTargetParam1.Enabled = true;
                    txtTargetParam2.Enabled = true;
                    txtTargetParam1.Text = targetparam1.ToString();
                    txtTargetParam2.Text = targetparam2.ToString();
                    break;
                }
                case 19: // Friendly Missing Buff
                case 20: // Friendly Missing Buff Not Self
                {
                    grpTargetParams.Enabled = true;
                    lblTargetParam1.Text = "Radius:";
                    lblTargetParam2.Text = "Spell Id:";
                    txtTargetParam1.Enabled = true;
                    txtTargetParam2.Enabled = true;
                    txtTargetParam1.Text = targetparam1.ToString();
                    txtTargetParam2.Text = targetparam2.ToString();
                    break;
                }
                case 21: // Friendly CC
                {
                    grpTargetParams.Enabled = true;
                    lblTargetParam1.Text = "Radius:";
                    txtTargetParam1.Enabled = true;
                    txtTargetParam1.Text = targetparam1.ToString();
                    break;
                }
                case 25: // Nearest Player
                case 26: // Nearest Hostile Player
                case 27: // Nearest Friendly Player
                {
                    grpTargetParams.Enabled = true;
                    lblTargetParam1.Text = "Radius:";
                    txtTargetParam1.Enabled = true;
                    txtTargetParam1.Text = targetparam1.ToString();
                    break;
                }
            }

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

            // CF_ONLY_IN_MELEE
            if ((flags & 64) != 0)
                chkCastFlag64.Checked = true;

            // CF_NOT_IN_MELEE
            if ((flags & 128) != 0)
                chkCastFlag128.Checked = true;

            // CF_TARGET_CASTING
            if ((flags & 256) != 0)
                chkCastFlag256.Checked = true;

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

            // CF_ONLY_IN_MELEE
            if (chkCastFlag64.Checked)
                new_flags += 64;

            // CF_NOT_IN_MELEE
            if (chkCastFlag128.Checked)
                new_flags += 128;

            // CF_TARGET_CASTING
            if (chkCastFlag256.Checked)
                new_flags += 256;

            uint new_targetparam1 = 0;
            uint.TryParse(txtTargetParam1.Text, out new_targetparam1);

            uint new_targetparam2 = 0;
            uint.TryParse(txtTargetParam2.Text, out new_targetparam2);

            uint new_script = 0;
            uint.TryParse(txtScriptId.Text, out new_script);

            if ((flags == new_flags) && (script == new_script) && (new_targetparam1 == targetparam1) && (new_targetparam2 == targetparam2))
                return false;

            // Return new values.
            flags = new_flags;
            script = new_script;
            targetparam1 = new_targetparam1;
            targetparam2 = new_targetparam2;

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

        private void btnSelectFlags_Click(object sender, EventArgs e)
        {
            FormTargetSelectFlags formSelectFlags = new FormTargetSelectFlags(selectFlags);
            if (formSelectFlags.ShowDialog() == DialogResult.OK)
            {
                selectFlags = formSelectFlags.ReturnValue;
                txtTargetParam1.Text = selectFlags.ToString();
                if (selectFlags != 0)
                    btnTargetParam1.Text = selectFlags.ToString();
                else
                    btnTargetParam1.Text = "-NONE-";
            }
        }
    }
}
