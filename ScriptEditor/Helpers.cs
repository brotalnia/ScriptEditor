using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
