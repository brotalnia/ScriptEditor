using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace ScriptEditor
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer(ScriptEditor.Properties.Resources.MouseOver);

        // Images for the buttons that change when moused over.
        Image imgScriptEditor = ScriptEditor.Properties.Resources.script_editor_button_black;
        Image imgScriptEditorHighlighted = ScriptEditor.Properties.Resources.script_editor_button;
        Image imgEventEditor = ScriptEditor.Properties.Resources.event_editor_button_black;
        Image imgEventEditorHighlighted = ScriptEditor.Properties.Resources.event_editor_button;
        Image imgCastsEditor = ScriptEditor.Properties.Resources.cast_editor_button_black;
        Image imgCastsEditorHighlighted = ScriptEditor.Properties.Resources.cast_editor_button;
        Image imgGitLink = ScriptEditor.Properties.Resources.gitlink1;
        Image imgGitLinkHighlighted = ScriptEditor.Properties.Resources.gitlink2;

        public Form1()
        {
            InitializeComponent();
        }

        private void picScriptEditor_MouseEnter(object sender, EventArgs e)
        {
            picScriptEditor.BackgroundImage = imgScriptEditorHighlighted;
            player.Play();
        }

        private void picScriptEditor_MouseLeave(object sender, EventArgs e)
        {
            picScriptEditor.BackgroundImage = imgScriptEditor;
        }

        private void picEventEditor_MouseEnter(object sender, EventArgs e)
        {
            picEventEditor.BackgroundImage = imgEventEditorHighlighted;
            player.Play();
        }

        private void picEventEditor_MouseLeave(object sender, EventArgs e)
        {
            picEventEditor.BackgroundImage = imgEventEditor;
        }

        private void picScriptEditor_Click(object sender, EventArgs e)
        {
            FormScriptEditor editor = new FormScriptEditor();
            editor.Show();
        }

        private void picEventEditor_Click(object sender, EventArgs e)
        {
            FormEventEditor editor = new FormEventEditor();
            editor.Show();
        }

        private void picGitLink_MouseEnter(object sender, EventArgs e)
        {
            picGitLink.BackgroundImage = imgGitLinkHighlighted;
            player.Play();
        }

        private void picGitLink_MouseLeave(object sender, EventArgs e)
        {
            picGitLink.BackgroundImage = imgGitLink;
        }

        private void picGitLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/brotalnia/ScriptEditor");
        }

        private void picCastsEditor_MouseEnter(object sender, EventArgs e)
        {
            picCastsEditor.BackgroundImage = imgCastsEditorHighlighted;
            player.Play();
        }

        private void picCastsEditor_MouseLeave(object sender, EventArgs e)
        {
            picCastsEditor.BackgroundImage = imgCastsEditor;
        }

        private void picCastsEditor_Click(object sender, EventArgs e)
        {
            FormCastsEditor editor = new FormCastsEditor();
            editor.Show();
        }
    }
}
