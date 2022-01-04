using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ScriptEditor
{
    public static class Helpers
    {
        // Escape characters that will break the query.
        public static string MySQLEscape(string str)
        {
            return MySql.Data.MySqlClient.MySqlHelper.EscapeString(str);

            /*
            return Regex.Replace(str, @"[\x00'""\b\n\r\t\cZ\\%_]",
                delegate (Match match)
                {
                    string v = match.Value;
                    switch (v)
                    {
                        case "\x00":            // ASCII NUL (0x00) character
                        return "\\0";
                        case "\b":              // BACKSPACE character
                        return "\\b";
                        case "\n":              // NEWLINE (linefeed) character
                        return "\\n";
                        case "\r":              // CARRIAGE RETURN character
                        return "\\r";
                        case "\t":              // TAB
                        return "\\t";
                        case "\u001A":          // Ctrl-Z
                        return "\\Z";
                        default:
                        return "\\" + v;
                    }
                });
            */
        }
        // Shows an input box that returns a value.
        public static DialogResult ShowInputDialog(ref string input, string name)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = name;
            inputBox.MaximizeBox = false;
            inputBox.MinimizeBox = false;
            inputBox.StartPosition = FormStartPosition.CenterParent;

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

        public static DialogResult ShowFlagInputDialog(ref uint flags, string name, List<Tuple<string, uint>> valuesList)
        {
            System.Drawing.Size size = new System.Drawing.Size(10 + 120 + 120 + 10, 10 + 24 + (valuesList.Count / 2) * 24 + 30 + 10);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = name;
            inputBox.MaximizeBox = false;
            inputBox.MinimizeBox = false;
            inputBox.StartPosition = FormStartPosition.CenterParent;

            List<CheckBox> checkBoxes = new List<CheckBox>();
            for (int i = 0; i < valuesList.Count; i++)
            {
                int x = (i & 1) != 0 ? 120 : 10;
                int y = 10 + (i / 2) * 24;
                CheckBox checkBox = new CheckBox();
                checkBox.Location = new System.Drawing.Point(x, y);
                checkBox.Text = valuesList[i].Item1;
                checkBox.Tag = valuesList[i].Item2;
                checkBox.AutoSize = true;
                if ((flags & valuesList[i].Item2) != 0)
                    checkBox.Checked = true;
                checkBoxes.Add(checkBox);
                inputBox.Controls.Add(checkBox);
            }

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(inputBox.Size.Width / 2 - 5 - okButton.Size.Width, 10 + 24 + (valuesList.Count / 2) * 24 + 10);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(inputBox.Size.Width / 2 + 5, 10 + 24 + (valuesList.Count / 2) * 24 + 10);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            if (result == DialogResult.OK)
            {
                flags = 0;
                foreach (CheckBox checkBox in checkBoxes)
                {
                    if (checkBox.Checked)
                        flags |= (uint)checkBox.Tag;
                }
            }
            return result;
        }

        // Shows a dialog with the query.
        public static DialogResult ShowSaveDialog(ref string query)
        {
            System.Drawing.Size size = new System.Drawing.Size(800, 450);
            Form saveBox = new Form();

            saveBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            saveBox.ClientSize = size;
            saveBox.Text = "Save Script";
            saveBox.MaximizeBox = false;
            saveBox.MinimizeBox = false;
            saveBox.StartPosition = FormStartPosition.CenterParent;

            System.Windows.Forms.RichTextBox textBox = new RichTextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, size.Height - 40);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = query;
            textBox.Multiline = true;
            textBox.WordWrap = false;
            textBox.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            saveBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "Save";
            okButton.Location = new System.Drawing.Point(size.Width / 2 - okButton.Size.Width - 2, textBox.Location.Y + textBox.Size.Height + 5);
            saveBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "Cancel";
            cancelButton.Location = new System.Drawing.Point(okButton.Location.X + okButton.Size.Width + 4, textBox.Location.Y + textBox.Size.Height + 5);
            saveBox.Controls.Add(cancelButton);

            saveBox.CancelButton = cancelButton;

            DialogResult result = saveBox.ShowDialog();
            query = textBox.Text;
            return result;
        }

        public static string GetValueNameFromList(uint value, List<Tuple<string, uint>> valuesList)
        {
            if (valuesList != null)
            {
                foreach (var pair in valuesList)
                    if (pair.Item2 == value)
                        return pair.Item1;
            }
            
            return value.ToString();
        }

        public static string GetStringFromFlags(uint flags, List<Tuple<string, uint>> valuesList = null)
        {
            string str = "";
            for (uint i = 0; i < 32; i++)
            {
                uint flag = (uint)Math.Pow(2, i);
                if ((flags & flag) != 0)
                {
                    if (str.Length > 0)
                        str += ", ";

                    str += GetValueNameFromList(flag, valuesList);
                }
            }
            return str;
        }

        // Generic function for getting the object represented by the currently selected list view item.
        public static TScriptField GetCurrentlySelectedItem<TScriptField>(ListView listView) where TScriptField : class
        {
            if (listView.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = listView.SelectedItems[0];

                // Get the associated script field.
                return (TScriptField)currentItem.Tag;
            }
            return null;
        }
        // Generic function for setting script field to specified value;
        public static void SetScriptFieldFromValue<TScriptField>(ListView listView, double fieldvalue, string fieldname) where TScriptField : class
        {
            TScriptField currentItem = GetCurrentlySelectedItem<TScriptField>(listView);
            if (currentItem != null)
            {
                // Get the field we need to change.
                FieldInfo prop = typeof(TScriptField).GetField(fieldname, BindingFlags.Instance | BindingFlags.Public);

                // Updating the value in the field.
                prop.SetValue(currentItem, Convert.ChangeType(fieldvalue, prop.FieldType));
            }
        }
        // Generic function for setting field value from a textbox.
        public static void SetScriptFieldFromTextbox<TScriptField>(ListView listView, TextBox ctrl, string fieldname) where TScriptField : class
        {
            // Get the value from the textbox.
            double fieldValue;
            double.TryParse(ctrl.Text, out fieldValue);

            // Set the field value.
            SetScriptFieldFromValue<TScriptField>(listView, fieldValue, fieldname);
        }
        // Generic function for setting field value from a checkbox.
        public static void SetScriptFieldFromCombobox<TScriptField>(ListView listView, ComboBox cmbbox, string fieldname, bool usePairValue) where TScriptField : class
        {
            // We can use either selected index or the pair value.
            int selectedValue = usePairValue ? (cmbbox.SelectedItem as ComboboxPair).Value : cmbbox.SelectedIndex;

            // Set the field value.
            SetScriptFieldFromValue<TScriptField>(listView, selectedValue, fieldname);
        }
        // Generic function for updating flags based on checkbox.
        public static void SetScriptFlagsFromCheckbox<TScriptField>(ListView listView, CheckBox chkbox, string fieldname, uint value) where TScriptField : class
        {
            TScriptField currentItem = GetCurrentlySelectedItem<TScriptField>(listView);
            if (currentItem != null)
            {
                // Get the field we need to change.
                FieldInfo prop = typeof(TScriptField).GetField(fieldname, BindingFlags.Instance | BindingFlags.Public);

                // Get the old value in this field.
                uint currentValue = (uint)Convert.ChangeType(prop.GetValue(currentItem), typeof(uint));

                if (chkbox.Checked)
                    currentValue += value;
                else
                    currentValue -= value;

                prop.SetValue(currentItem, Convert.ChangeType(currentValue, prop.FieldType));
            }
        }
        // Generic function for setting a value from another form.
        public static void SetScriptFieldFromDataFinderForm<TScriptField, TFinderForm>(ListView listView, Button btn, TextBox txtbox, NameFinder finder, string fieldname) where TFinderForm : FormDataFinder, new()  
                                                                                                                                                                            where TScriptField : class
        {
            FormDataFinder frm = new TFinderForm();
            if (frm.ShowDialog(GetScriptFieldValue<TScriptField, int>(listView, fieldname)) == System.Windows.Forms.DialogResult.OK)
            {
                int returnId = frm.ReturnValue;

                if (returnId > 0)
                {
                    // If there is no textbox provided the text is shown on the button.
                    if (txtbox == null)
                    {
                        if (finder == null)
                            btn.Text = returnId.ToString();
                        else
                            btn.Text = finder((uint)returnId) + " (" + returnId.ToString() + ")";
                    }
                    else
                    {
                        btn.Text = returnId.ToString();
                        if (finder == null)
                            txtbox.Text = returnId.ToString();
                        else
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
                SetScriptFieldFromValue<TScriptField>(listView, returnId, fieldname);
            }
        }
        public static void SetScriptFieldFromFlagsForm<TScriptField>(ListView listView, Button btn, List<Tuple<string, uint>> valuesList, string windowtitle, string fieldname) where TScriptField : class
        {
            uint flags = GetScriptFieldValue<TScriptField, uint>(listView, fieldname);
            if (Helpers.ShowFlagInputDialog(ref flags, windowtitle, valuesList) == System.Windows.Forms.DialogResult.OK)
            {
                if (flags > 0)
                {
                    btn.Text = Helpers.GetStringFromFlags(flags, valuesList);
                }
                else
                {
                    btn.Text = "-NONE-";
                }

                // Set the field value.
                SetScriptFieldFromValue<TScriptField>(listView, flags, fieldname);
            }
        }
        // Generic function for getting int value in field.
        public static TNumber GetScriptFieldValue<TScriptField, TNumber>(ListView listView, string fieldname) where TNumber : struct, IComparable<TNumber>
                                                                                                               where TScriptField : class
        {
            TScriptField currentItem = GetCurrentlySelectedItem<TScriptField>(listView);
            if (currentItem != null)
            {
                // Get the field by name.
                FieldInfo prop = typeof(TScriptField).GetField(fieldname, BindingFlags.Instance | BindingFlags.Public);

                // Get the value in this field.
                TNumber currentValue = (TNumber)Convert.ChangeType(prop.GetValue(currentItem), typeof(TNumber));

                return currentValue;
            }

            return default(TNumber);
        }
    }
}
