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
    public partial class FormTargetSelectFlags : Form
    {
        public uint ReturnValue { get; set; } // we return the mask in this
        private bool initializing = true;
        public FormTargetSelectFlags(uint selectFlags)
        {
            InitializeComponent();
            ReturnValue = selectFlags;

            if ((selectFlags & 1) != 0)
                chkFlag1.Checked = true;
            if ((selectFlags & 2) != 0)
                chkFlag2.Checked = true;
            if ((selectFlags & 4) != 0)
                chkFlag4.Checked = true;
            if ((selectFlags & 8) != 0)
                chkFlag8.Checked = true;
            if ((selectFlags & 16) != 0)
                chkFlag16.Checked = true;
            if ((selectFlags & 64) != 0)
                chkFlag64.Checked = true;
            if ((selectFlags & 128) != 0)
                chkFlag128.Checked = true;
            if ((selectFlags & 256) != 0)
                chkFlag256.Checked = true;
            if ((selectFlags & 512) != 0)
                chkFlag512.Checked = true;
            if ((selectFlags & 1024) != 0)
                chkFlag1024.Checked = true;
            if ((selectFlags & 2048) != 0)
                chkFlag2048.Checked = true;
            if ((selectFlags & 4096) != 0)
                chkFlag4096.Checked = true;
            if ((selectFlags & 8192) != 0)
                chkFlag8192.Checked = true;

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

        private void chkFlag1_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkFlag1.Checked)
                ReturnValue += 1;
            else
                ReturnValue -= 1;
        }

        private void chkFlag2_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkFlag2.Checked)
                ReturnValue += 2;
            else
                ReturnValue -= 2;
        }

        private void chkFlag4_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkFlag4.Checked)
                ReturnValue += 4;
            else
                ReturnValue -= 4;
        }

        private void chkFlag8_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkFlag8.Checked)
                ReturnValue += 8;
            else
                ReturnValue -= 8;
        }

        private void chkFlag16_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkFlag16.Checked)
                ReturnValue += 16;
            else
                ReturnValue -= 16;
        }

        private void chkFlag32_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkFlag32.Checked)
                ReturnValue += 32;
            else
                ReturnValue -= 32;
        }

        private void chkFlag64_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkFlag64.Checked)
                ReturnValue += 64;
            else
                ReturnValue -= 64;
        }

        private void chkFlag128_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkFlag128.Checked)
                ReturnValue += 128;
            else
                ReturnValue -= 128;
        }

        private void chkFlag256_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkFlag256.Checked)
                ReturnValue += 256;
            else
                ReturnValue -= 256;
        }

        private void chkFlag512_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkFlag512.Checked)
                ReturnValue += 512;
            else
                ReturnValue -= 512;
        }

        private void chkFlag1024_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkFlag1024.Checked)
                ReturnValue += 1024;
            else
                ReturnValue -= 1024;
        }

        private void chkFlag2048_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkFlag2048.Checked)
                ReturnValue += 2048;
            else
                ReturnValue -= 2048;
        }

        private void chkFlag4096_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkFlag4096.Checked)
                ReturnValue += 4096;
            else
                ReturnValue -= 4096;
        }

        private void chkFlag8192_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkFlag8192.Checked)
                ReturnValue += 8192;
            else
                ReturnValue -= 8192;
        }
    }
}
