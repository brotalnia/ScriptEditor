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
    public partial class FormRaceMask : Form
    {
        public uint ReturnValue { get; set; } // we return the mask in this
        private bool initializing = true;
        public FormRaceMask(uint racemask)
        {
            InitializeComponent();
            ReturnValue = racemask;

            if ((racemask & 1) != 0)
                chkRace1.Checked = true;
            if ((racemask & 2) != 0)
                chkRace2.Checked = true;
            if ((racemask & 4) != 0)
                chkRace4.Checked = true;
            if ((racemask & 8) != 0)
                chkRace8.Checked = true;
            if ((racemask & 16) != 0)
                chkRace16.Checked = true;
            if ((racemask & 32) != 0)
                chkRace32.Checked = true;
            if ((racemask & 64) != 0)
                chkRace64.Checked = true;
            if ((racemask & 128) != 0)
                chkRace128.Checked = true;

            initializing = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void chkRace1_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkRace1.Checked)
                ReturnValue += 1;
            else
                ReturnValue -= 1;
        }

        private void chkRace4_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkRace4.Checked)
                ReturnValue += 4;
            else
                ReturnValue -= 4;
        }

        private void chkRace8_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkRace8.Checked)
                ReturnValue += 8;
            else
                ReturnValue -= 8;
        }

        private void chkRace64_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkRace64.Checked)
                ReturnValue += 64;
            else
                ReturnValue -= 64;
        }

        private void chkRace2_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkRace2.Checked)
                ReturnValue += 2;
            else
                ReturnValue -= 2;
        }

        private void chkRace16_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkRace16.Checked)
                ReturnValue += 16;
            else
                ReturnValue -= 16;
        }

        private void chkRace32_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkRace32.Checked)
                ReturnValue += 32;
            else
                ReturnValue -= 32;
        }

        private void chkRace128_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkRace128.Checked)
                ReturnValue += 128;
            else
                ReturnValue -= 128;
        }

    }
}
