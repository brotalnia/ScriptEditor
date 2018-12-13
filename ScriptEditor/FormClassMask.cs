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
    public partial class FormClassMask : Form
    {
        public uint ReturnValue { get; set; } // we return the mask in this
        private bool initializing = true;
        public FormClassMask(uint classmask)
        {
            InitializeComponent();
            ReturnValue = classmask;

            if ((classmask & 1) != 0)
                chkClass1.Checked = true;
            if ((classmask & 2) != 0)
                chkClass2.Checked = true;
            if ((classmask & 4) != 0)
                chkClass4.Checked = true;
            if ((classmask & 8) != 0)
                chkClass8.Checked = true;
            if ((classmask & 16) != 0)
                chkClass16.Checked = true;
            if ((classmask & 32) != 0)
                chkClass32.Checked = true;
            if ((classmask & 64) != 0)
                chkClass64.Checked = true;
            if ((classmask & 128) != 0)
                chkClass128.Checked = true;
            if ((classmask & 256) != 0)
                chkClass256.Checked = true;

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

        private void chkClass1_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkClass1.Checked)
                ReturnValue += 1;
            else
                ReturnValue -= 1;
        }

        private void chkClass4_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkClass4.Checked)
                ReturnValue += 4;
            else
                ReturnValue -= 4;
        }

        private void chkClass8_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkClass8.Checked)
                ReturnValue += 8;
            else
                ReturnValue -= 8;
        }

        private void chkClass64_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkClass64.Checked)
                ReturnValue += 64;
            else
                ReturnValue -= 64;
        }

        private void chkClass2_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkClass2.Checked)
                ReturnValue += 2;
            else
                ReturnValue -= 2;
        }

        private void chkClass16_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkClass16.Checked)
                ReturnValue += 16;
            else
                ReturnValue -= 16;
        }

        private void chkClass32_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkClass32.Checked)
                ReturnValue += 32;
            else
                ReturnValue -= 32;
        }

        private void chkClass128_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkClass128.Checked)
                ReturnValue += 128;
            else
                ReturnValue -= 128;
        }

        private void chkClass256_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (chkClass256.Checked)
                ReturnValue += 256;
            else
                ReturnValue -= 256;
        }
    }
}
