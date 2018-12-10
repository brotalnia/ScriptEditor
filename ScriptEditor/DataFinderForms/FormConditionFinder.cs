using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormConditionFinder : ScriptEditor.FormDataFinder
    {
        private bool dontUpdate = false;
        private bool editMode = false;

        private void ResetBaseControls()
        {
            cmbConditionType.SelectedIndex = -1;
            cmbConditionType.Enabled = false;
            txtConditionId.Text = "";
            txtConditionId.Enabled = false;
            chkConditionFlag1.Checked = false;
            chkConditionFlag1.Enabled = false;
            chkConditionFlag2.Checked = false;
            chkConditionFlag2.Enabled = false;
        }
        private void ResetAndHideConditionSpecificForms()
        {
            // CONDITION_NOT (-3)
            // CONDITION_OR (-2)
            // CONDITION_AND (-1)
            btnConditionNotCondition1.Text = "-NONE-";
            btnConditionNotCondition2.Text = "-NONE-";
            frmConditionNot.Visible = false;
        }

        private void ShowConditionSpecificForm(ConditionInfo selectedCondition)
        {
            if (!editMode)
                return;

            switch (selectedCondition.Type)
            {
                case -3: // CONDITION_NOT
                case -2: // CONDITION_OR
                case -1: // CONDITION_AND
                {
                    switch (selectedCondition.Type)
                    {
                        case -3: // CONDITION_NOT
                        {
                            lblConditionNotTooltip.Text = "Returns true if the specified condition is false. The referenced condition needs to have an entry Id that is lower than that of the current condition.";
                            lblConditionNotCondition1.Text = "Condition Id:";
                            lblConditionNotCondition2.Visible = false;
                            btnConditionNotCondition2.Visible = false;
                            break;
                        }
                        case -2: // CONDITION_OR
                        {
                            lblConditionNotTooltip.Text = "Returns true if either one of specified conditions is true. The referenced conditions need to have an entry Id that is lower than that of the current condition.";
                            lblConditionNotCondition1.Text = "Condition Id 1:";
                            lblConditionNotCondition2.Visible = true;
                            btnConditionNotCondition2.Visible = true;
                            break;
                        }
                        case -1: // CONDITION_AND
                        {
                            lblConditionNotTooltip.Text = "Returns true only if both of the specified conditions return true. The referenced conditions need to have an entry Id that is lower than that of the current condition.";
                            lblConditionNotCondition1.Text = "Condition Id 1:";
                            lblConditionNotCondition2.Visible = true;
                            btnConditionNotCondition2.Visible = true;
                            break;
                        }
                    }

                    lblConditionNotCondition1.Visible = true;
                    btnConditionNotCondition1.Visible = true;

                    uint conditionId1 = selectedCondition.Value1;
                    if (conditionId1 > 0)
                        btnConditionNotCondition1.Text = conditionId1.ToString() + " - " + GameData.FindConditionName(conditionId1);
                    uint conditionId2 = selectedCondition.Value2;
                    if (conditionId2 > 0)
                        btnConditionNotCondition2.Text = conditionId2.ToString() + " - " + GameData.FindConditionName(conditionId2);


                    frmConditionNot.Visible = true;
                    break;
                }
                case 0: // CONDITION_NONE
                {
                    lblConditionNotTooltip.Text = "Always returns true. This condition has no additional parameters.";
                    lblConditionNotCondition1.Visible = false;
                    lblConditionNotCondition2.Visible = false;
                    btnConditionNotCondition1.Visible = false;
                    btnConditionNotCondition2.Visible = false;
                    frmConditionNot.Visible = true;
                    break;
                }
            }
        }

        public FormConditionFinder()
        {
            InitializeComponent();
            dontUpdate = true;
            lstData.Height = 305;
            cmbConditionType.DataSource = GameData.ConditionNamesList;
            txtConditionId.AutoSize = false;
            txtConditionId.Height = 21;
            cmbConditionType.SelectedIndex = -1;
            dontUpdate = false;
        }

        protected override void AddAllData()
        {
            dontUpdate = true;
            ResetBaseControls();
            ResetAndHideConditionSpecificForms();
            dontUpdate = false;

            foreach (ConditionInfo condition in GameData.ConditionInfoList)
            {
                AddConditionToListView(condition);
            }
        }
        protected override void AddById(uint id)
        {
            dontUpdate = true;
            ResetBaseControls();
            ResetAndHideConditionSpecificForms();
            dontUpdate = false;

            foreach (ConditionInfo condition in GameData.ConditionInfoList)
            {
                if (condition.ID == id)
                    AddConditionToListView(condition);
            }
        }
        protected override void AddByIdRange(uint minId, uint maxId)
        {
            dontUpdate = true;
            ResetBaseControls();
            ResetAndHideConditionSpecificForms();
            dontUpdate = false;

            foreach (ConditionInfo condition in GameData.ConditionInfoList)
            {
                if ((condition.ID >= minId) && (condition.ID <= maxId))
                    AddConditionToListView(condition);
            }
        }
        private void AddConditionToListView(ConditionInfo condition)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = condition.ID.ToString();
            lvi.SubItems.Add(GameData.FindConditionTypeName(condition.Type));
            lvi.SubItems.Add(condition.Value1.ToString());
            lvi.SubItems.Add(condition.Value2.ToString());
            lvi.SubItems.Add(condition.Value3.ToString());
            lvi.SubItems.Add(condition.Value4.ToString());
            lvi.SubItems.Add(condition.Flags.ToString());
            lvi.Tag = condition;

            // Add this condition to the listview.
            lstData.Items.Add(lvi);
        }

        private void FormConditionFinder_ResizeEnd(object sender, EventArgs e)
        {
            lstData.Columns[1].Width = lstData.ClientSize.Width - lstData.Columns[0].Width - lstData.Columns[2].Width - lstData.Columns[3].Width - lstData.Columns[4].Width - lstData.Columns[5].Width - lstData.Columns[6].Width;
        }
        private void UpdateSelectedItem()
        {
            if (lstData.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstData.SelectedItems[0];

                // Get the associated ConditionInfo.
                ConditionInfo currentCondition = (ConditionInfo)currentItem.Tag;

                currentItem.Text = currentCondition.ID.ToString();
                currentItem.SubItems[1].Text = GameData.FindConditionTypeName(currentCondition.Type);
                currentItem.SubItems[2].Text = currentCondition.Value1.ToString();
                currentItem.SubItems[3].Text = currentCondition.Value2.ToString();
                currentItem.SubItems[4].Text = currentCondition.Value3.ToString();
                currentItem.SubItems[5].Text = currentCondition.Value4.ToString();
            }
        }

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstData.SelectedItems.Count == 0)
            {
                dontUpdate = true;
                ResetBaseControls();
                ResetAndHideConditionSpecificForms();
                dontUpdate = false;
                return;
            }

            dontUpdate = true;
            ListViewItem selectedItem = lstData.SelectedItems[0];
            ConditionInfo selectedCondition = (ConditionInfo)selectedItem.Tag;

            cmbConditionType.SelectedIndex = selectedCondition.Type + 3;
            cmbConditionType.Enabled = true;

            txtConditionId.Text = selectedCondition.ID.ToString();
            txtConditionId.Enabled = true;

            chkConditionFlag1.Enabled = true;
            chkConditionFlag2.Enabled = true;

            if ((selectedCondition.Flags & 1) != 0)
                chkConditionFlag1.Checked = true;
            if ((selectedCondition.Flags & 2) != 0)
                chkConditionFlag2.Checked = true;

            ShowConditionSpecificForm(selectedCondition);
            dontUpdate = false;
        }

        private void cmbConditionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstData.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstData.SelectedItems[0];

                // Get the associated ConditionInfo.
                ConditionInfo currentCondition = (ConditionInfo)currentItem.Tag;

                currentCondition.Type = cmbConditionType.SelectedIndex - 3;
                currentCondition.Value1 = 0;
                currentCondition.Value2 = 0;
                currentCondition.Value3 = 0;
                currentCondition.Value4 = 0;
                UpdateSelectedItem();

                dontUpdate = true;
                ResetAndHideConditionSpecificForms();
                ShowConditionSpecificForm(currentCondition);
                dontUpdate = false;
            }
        }

        // Generic function for setting script field to specified value;
        private void SetScriptFieldFromValue(float fieldvalue, string fieldname)
        {
            if (lstData.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstData.SelectedItems[0];

                // Get the associated ConditionInfo.
                ConditionInfo currentEvent = (ConditionInfo)currentItem.Tag;

                // Get the field we need to change.
                FieldInfo prop = typeof(ConditionInfo).GetField(fieldname, BindingFlags.Instance | BindingFlags.Public);

                // Updating the value in the field.
                prop.SetValue(currentEvent, Convert.ChangeType(fieldvalue, prop.FieldType));

                UpdateSelectedItem();
            }
        }
        // Generic function for setting field value from a textbox.
        private void SetScriptFieldFromTextbox(TextBox ctrl, string fieldname)
        {
            // Get the value from the textbox.
            float fieldValue;
            float.TryParse(ctrl.Text, out fieldValue);

            // Set the field value.
            SetScriptFieldFromValue(fieldValue, fieldname);
        }
        // Generic function for setting field value from a checkbox.
        private void SetScriptFieldFromCombobox(ComboBox cmbbox, string fieldname, bool usePairValue)
        {
            if (dontUpdate)
                return;

            // We can use either selected index or the pair value.
            int selectedValue = usePairValue ? (cmbbox.SelectedItem as ComboboxPair).Value : cmbbox.SelectedIndex;

            // Set the field value.
            SetScriptFieldFromValue(selectedValue, fieldname);
        }
        // Generic function for updating flags based on checkbox.
        private void SetScriptFlagsFromCheckbox(CheckBox chkbox, string fieldname, uint value)
        {
            if (dontUpdate)
                return;

            if (lstData.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstData.SelectedItems[0];

                // Get the associated ConditionInfo.
                ConditionInfo currentEvent = (ConditionInfo)currentItem.Tag;

                // Get the field we need to change.
                FieldInfo prop = typeof(ConditionInfo).GetField(fieldname, BindingFlags.Instance | BindingFlags.Public);

                // Get the old value in this field.
                uint currentValue = (uint)prop.GetValue(currentEvent);

                if (chkbox.Checked)
                    currentValue += value;
                else
                    currentValue -= value;

                prop.SetValue(currentEvent, Convert.ChangeType(currentValue, prop.FieldType));

                UpdateSelectedItem();
            }
        }
        // Generic function for setting a value from another form.
        private void SetScriptFieldFromDataFinderForm<TFinderForm>(Button btn, TextBox txtbox, NameFinder finder, string fieldname) where TFinderForm : FormDataFinder, new()
        {
            FormDataFinder frm = new TFinderForm();
            if (frm.ShowDialog(GetScriptFieldValue(fieldname)) == System.Windows.Forms.DialogResult.OK)
            {
                int returnId = frm.ReturnValue;

                if (returnId > 0)
                {
                    // If there is no textbox provided the text is shown on the button.
                    if (txtbox == null)
                        btn.Text = finder((uint)returnId) + " (" + returnId.ToString() + ")";
                    else
                    {
                        btn.Text = returnId.ToString();
                        txtbox.Text = finder((uint)returnId);
                    }
                }
                else if (returnId < 0)
                {
                    btn.Text = "-IGNORE-";
                }
                else
                {
                    btn.Text = "-NONE-";
                    if (txtbox != null)
                        txtbox.Text = "";
                }

                // Set the field value.
                SetScriptFieldFromValue(returnId, fieldname);
            }
        }
        // Generic function for getting int value in field.
        private int GetScriptFieldValue(string fieldname)
        {
            if (lstData.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstData.SelectedItems[0];

                // Get the associated ConditionInfo.
                ConditionInfo currentAction = (ConditionInfo)currentItem.Tag;

                // Get the field by name.
                FieldInfo prop = typeof(ConditionInfo).GetField(fieldname, BindingFlags.Instance | BindingFlags.Public);

                // Get the value in this field.
                int currentValue = (int)Convert.ChangeType(prop.GetValue(currentAction), typeof(int));

                return currentValue;
            }
            return 0;
        }
        private bool IsAvailableConditionId(uint conditionId)
        {
            bool ok = (conditionId > 0);
            foreach (ConditionInfo condition in GameData.ConditionInfoList)
            {
                if (condition.ID == conditionId)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
        private void txtConditionId_Leave(object sender, EventArgs e)
        {
            uint conditionId;
            if (uint.TryParse(txtConditionId.Text, out conditionId))
            {
                if (conditionId != GetScriptFieldValue("ID"))
                {
                    if (IsAvailableConditionId(conditionId))
                    {
                        if (lstData.SelectedItems.Count > 0)
                        {
                            ListViewItem currentItem = lstData.SelectedItems[0];
                            currentItem.Text = conditionId.ToString();
                            ConditionInfo currentCondition = (ConditionInfo)currentItem.Tag;
                            currentCondition.ID = conditionId;
                        }
                    }
                    else
                    {
                        txtConditionId.Text = GetScriptFieldValue("ID").ToString();
                        MessageBox.Show("A condition with that Id already exists.", "Invalid Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                txtConditionId.Text = GetScriptFieldValue("ID").ToString();
        }

        private void chkConditionFlag1_CheckedChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstData.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstData.SelectedItems[0];

                // Get the associated ConditionInfo.
                ConditionInfo currentCondition = (ConditionInfo)currentItem.Tag;

                // Get the old value in this field.
                uint currentValue = currentCondition.Flags;

                if (chkConditionFlag1.Checked)
                    currentValue += 1;
                else
                    currentValue -= 1;

                currentCondition.Flags = currentValue;
                currentItem.SubItems[6].Text = currentValue.ToString();
            }
        }

        private void chkConditionFlag2_CheckedChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstData.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstData.SelectedItems[0];

                // Get the associated ConditionInfo.
                ConditionInfo currentCondition = (ConditionInfo)currentItem.Tag;

                // Get the old value in this field.
                uint currentValue = currentCondition.Flags;

                if (chkConditionFlag2.Checked)
                    currentValue += 2;
                else
                    currentValue -= 2;

                currentCondition.Flags = currentValue;
                currentItem.SubItems[6].Text = currentValue.ToString();
            }
        }

        private void btnEditAdd_Click(object sender, EventArgs e)
        {
            if (!editMode)
            {
                editMode = true;
                lstData.Height = 123;
                txtConditionId.Visible = true;
                chkConditionFlag1.Visible = true;
                chkConditionFlag2.Visible = true;
                cmbConditionType.Visible = true;
                btnSave.Visible = true;
                btnSaveAll.Visible = true;
                btnDelete.Visible = true;
                btnEditAdd.Text = "Add";

                if (lstData.SelectedItems.Count > 0)
                {
                    // Get the selected item in the listview.
                    ListViewItem currentItem = lstData.SelectedItems[0];

                    // Get the associated ConditionInfo.
                    ConditionInfo currentCondition = (ConditionInfo)currentItem.Tag;

                    ShowConditionSpecificForm(currentCondition);
                }
            }
            else
            {
                string newId = "";
                DialogResult result_name = Helpers.ShowInputDialog(ref newId, "Condition Id");
                if ((result_name != DialogResult.OK) || (newId == ""))
                    return;

                uint conditionId;
                if (!uint.TryParse(newId, out conditionId) || !IsAvailableConditionId(conditionId))
                {
                    MessageBox.Show("A condition with that Id already exists.", "Invalid Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create new condition.
                ConditionInfo condition = new ConditionInfo(conditionId, 0, 0, 0, 0, 0, 0);
                GameData.ConditionInfoList.Add(condition);

                // Create new listview option.
                ListViewItem lvi = new ListViewItem();
                lvi.Text = newId;
                lvi.SubItems.Add(GameData.FindConditionTypeName(condition.Type));
                lvi.SubItems.Add(condition.Value1.ToString());
                lvi.SubItems.Add(condition.Value2.ToString());
                lvi.SubItems.Add(condition.Value3.ToString());
                lvi.SubItems.Add(condition.Value4.ToString());
                lvi.SubItems.Add(condition.Flags.ToString());
                lvi.Tag = condition;

                // Add this condition to the listview.
                lstData.Items.Add(lvi);

                // Select the new item.
                lstData.SelectedItems.Clear();
                lstData.FocusedItem = lvi;
                lvi.Selected = true;
                lstData.Select();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstData.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstData.SelectedItems[0];

                // Get the associated ConditionInfo.
                ConditionInfo currentCondition = (ConditionInfo)currentItem.Tag;

                // Remove the condition and listview item.
                GameData.ConditionInfoList.Remove(currentCondition);
                currentItem.Tag = null;
                currentItem.Remove();
            }
        }

        private string GenerateSaveQuery(ConditionInfo saveCondition)
        {
            ConditionInfo condition = GameData.OriginalConditionInfoList.Find(i => i.ID == saveCondition.ID);

            if (condition != null)
            {
                // Update existing condition.
                List<string> fields = new List<string>();
                if (saveCondition.Type != condition.Type)
                    fields.Add("`type`=" + saveCondition.Type.ToString());
                if (saveCondition.Value1 != condition.Value1)
                    fields.Add("`value1`=" + saveCondition.Value1.ToString());
                if (saveCondition.Value2 != condition.Value2)
                    fields.Add("`value2`=" + saveCondition.Value2.ToString());
                if (saveCondition.Value3 != condition.Value3)
                    fields.Add("`value3`=" + saveCondition.Value3.ToString());
                if (saveCondition.Value4 != condition.Value4)
                    fields.Add("`value4`=" + saveCondition.Value4.ToString());
                if (saveCondition.Flags != condition.Flags)
                    fields.Add("`flags`=" + saveCondition.Flags.ToString());

                if (fields.Count > 0)
                {
                    string query = "UPDATE `conditions` SET ";
                    for (int i = 0; i < fields.Count; i++)
                    {
                        if (i != 0)
                            query += ", ";
                        query += fields[i];
                    }
                    query += " WHERE `condition_entry`=" + saveCondition.ID.ToString() + ";\n";
                    return query;
                }

                // Nothing to update.
                return "";
            }
            // Insert a new condition.
            return "INSERT INTO `conditions` (`condition_entry`, `type`, `value1`, `value2`, `value3`, `value4`, `flags`) VALUES (" + saveCondition.ID.ToString() + ", " + saveCondition.Type.ToString() + ", " + saveCondition.Value1.ToString() + ", " + saveCondition.Value2.ToString() + ", " + saveCondition.Value3.ToString() + ", " + saveCondition.Value4.ToString() + ", " + saveCondition.Flags.ToString() + ");\n";
        }
        private void ShowDialogAndSave(string query)
        {
            if (Helpers.ShowSaveDialog(ref query) == DialogResult.OK)
            {
                MySqlConnection conn = new MySqlConnection(Program.connString);
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = query;
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Save Condition", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstData.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstData.SelectedItems[0];

                // Get the associated ConditionInfo.
                ConditionInfo currentCondition = (ConditionInfo)currentItem.Tag;

                string query = GenerateSaveQuery(currentCondition);
                if (query.Length == 0)
                {
                    if (MessageBox.Show("You have not made any changes!\nDo you want to generate a query for this condition anyway?", "Nothing to save", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        query = "REPLACE INTO `conditions` (`condition_entry`, `type`, `value1`, `value2`, `value3`, `value4`, `flags`) VALUES (" + currentCondition.ID.ToString() + ", " + currentCondition.Type.ToString() + ", " + currentCondition.Value1.ToString() + ", " + currentCondition.Value2.ToString() + ", " + currentCondition.Value3.ToString() + ", " + currentCondition.Value4.ToString() + ", " + currentCondition.Flags.ToString() + ");\n";
                    else
                        return;
                }

                ShowDialogAndSave(query);
            }
        }
        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            List<uint> deletedConditions = new List<uint>();
            foreach (ConditionInfo originalCondition in GameData.OriginalConditionInfoList)
            {
                if (GameData.ConditionInfoList.Find(i => i.ID == originalCondition.ID) == null)
                    deletedConditions.Add(originalCondition.ID);
            }

            string query = "";
            foreach (uint deletedId in deletedConditions)
            {
                query += "DELETE FROM `conditions` WHERE `condition_entry`=" + deletedId.ToString() + ";\n";
            }

            foreach (ConditionInfo condition in GameData.ConditionInfoList)
            {
                query += GenerateSaveQuery(condition);
            }

            if (query.Length == 0)
            {
                MessageBox.Show("You have not made any changes!", "Nothing to save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Helpers.ShowSaveDialog(ref query) == DialogResult.OK)
            {
                MySqlConnection conn = new MySqlConnection(Program.connString);
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = query;
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Save Condition", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }

        // CONDITION_NOT
        // CONDITION_OR
        // CONDITION_AND
        private void btnConditionNotCondition1_Click(object sender, EventArgs e)
        {
            FormConditionFinder frm = new FormConditionFinder();
            if (frm.ShowDialog(GetScriptFieldValue("Value1")) == System.Windows.Forms.DialogResult.OK)
            {
                int returnId = frm.ReturnValue;

                if (returnId > 0)
                    btnConditionNotCondition1.Text = returnId.ToString() + " - " + GameData.FindConditionName((uint)returnId);
                else
                    btnConditionNotCondition1.Text = "-NONE-";

                SetScriptFieldFromValue(returnId, "Value1");
            }
        }
        private void btnConditionNotCondition2_Click(object sender, EventArgs e)
        {
            FormConditionFinder frm = new FormConditionFinder();
            if (frm.ShowDialog(GetScriptFieldValue("Value2")) == System.Windows.Forms.DialogResult.OK)
            {
                int returnId = frm.ReturnValue;

                if (returnId > 0)
                    btnConditionNotCondition2.Text = returnId.ToString() + " - " + GameData.FindConditionName((uint)returnId);
                else
                    btnConditionNotCondition2.Text = "-NONE-";

                SetScriptFieldFromValue(returnId, "Value2");
            }
        }

    }
}
