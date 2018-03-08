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
    public partial class FormMaskCalculator : Form
    {
        public uint ReturnValue { get; set; } // we return the mask in this
        public FormMaskCalculator(uint phasemask)
        {
            InitializeComponent();
            ReturnValue = phasemask;
        }
        private void FormMaskCalculator_Load(object sender, EventArgs e)
        {
            UpdatePhasesList();
        }
        private void UpdatePhasesList()
        {
            if (ReturnValue == 0)
            {
                txtPhasesList.Text = "No phases are excluded.";
                return;
            }

            txtPhasesList.Text = "";
            for (int i = 0; i < 32; i++)
            {
                uint current = (uint)Math.Pow(2, i);
                if ((ReturnValue & current) != 0)
                    txtPhasesList.Text += "Phase " + i + ": 0x" + current.ToString("x8") + "\r\n";
            }
            txtPhasesList.Text += "\r\n-----------------\r\nTotal mask value: " + ReturnValue.ToString();
        }
        private void btnPhaseAdd_Click(object sender, EventArgs e)
        {
            uint phase = 0;
            if ((txtPhase.Text.Length == 0) || (!uint.TryParse(txtPhase.Text, out phase)))
                return;

            uint mask = (uint)Math.Pow(2, phase);
            if ((ReturnValue & mask) != 0)
                return;
            else
                ReturnValue |= mask;

            UpdatePhasesList();
        }

        private void btnPhaseRemove_Click(object sender, EventArgs e)
        {
            uint phase = 0;
            if ((txtPhase.Text.Length == 0) || (!uint.TryParse(txtPhase.Text, out phase)))
                return;

            uint mask = (uint)Math.Pow(2, phase);
            if ((ReturnValue & mask) != 0)
                ReturnValue -= mask;
            else
                return;

            UpdatePhasesList();
        }
    }
}
