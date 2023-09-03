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
        Image imgConditionsEditor = ScriptEditor.Properties.Resources.condition_editor_button_black;
        Image imgConditionsEditorHighlighted = ScriptEditor.Properties.Resources.condition_editor_button;
        Image imgGitLink = ScriptEditor.Properties.Resources.gitlink1;
        Image imgGitLinkHighlighted = ScriptEditor.Properties.Resources.gitlink2;

        public Form1()
        {
            InitializeComponent();

            // Assign event handlers to menu items

            // Editors
            tsmiScripts.Click += picScriptEditor_Click;
            tsmiCreatureEvents.Click += picEventEditor_Click;
            tsmiCreatureSpells.Click += picCastsEditor_Click;
            tsmiConditions.Click += picConditionEditor_Click;

            // Finders
            tsmiAreaFinder.Click += (sender, e) =>
            {
                FormAreaFinder finder = new FormAreaFinder();
                finder.ShowDialog();
            };
            tsmiCreatureFinder.Click += (sender, e) =>
            {
                FormCreatureFinder finder = new FormCreatureFinder();
                finder.ShowDialog();
            };
            tsmiEventFinder.Click += (sender, e) =>
            {
                FormEventFinder finder = new FormEventFinder();
                finder.ShowDialog();
            };
            tsmiFactionFinder.Click += (sender, e) =>
            {
                FormFactionFinder finder = new FormFactionFinder();
                finder.ShowDialog();
            };
            tsmiFactionTemplateFinder.Click += (sender, e) =>
            {
                FormFactionTemplateFinder finder = new FormFactionTemplateFinder();
                finder.ShowDialog();
            };
            tsmiGameObjectFinder.Click += (sender, e) =>
            {
                FormGameObjectFinder finder = new FormGameObjectFinder();
                finder.ShowDialog();
            };
            tsmiItemFinder.Click += (sender, e) =>
            {
                FormItemFinder finder = new FormItemFinder();
                finder.ShowDialog();
            };
            tsmiQuestFinder.Click += (sender, e) =>
            {
                FormQuestFinder finder = new FormQuestFinder();
                finder.ShowDialog();
            };
            tsmiSoundFinder.Click += (sender, e) =>
            {
                FormSoundFinder finder = new FormSoundFinder();
                finder.ShowDialog();
            };
            tsmiSpellFinder.Click += (sender, e) =>
            {
                FormSpellFinder finder = new FormSpellFinder();
                finder.ShowDialog();
            };
            tsmiTaxiFinder.Click += (sender, e) =>
            {
                FormTaxiFinder finder = new FormTaxiFinder();
                finder.ShowDialog();
            };
            tsmiTextFinder.Click += (sender, e) =>
            {
                FormTextFinder finder = new FormTextFinder();
                finder.ShowDialog();
            };

            // Helpers
            tsmiFlagsGameObjectDynUF.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "Game Object Dynamic Flags (UF)", GameData.GameObjectDynFlagsList);
            };
            tsmiFlagsGameObjectUF.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "Game Object Flags (UF)", GameData.GameObjectFlagsList);
            };
            tsmiFlagsGeneric.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "Generic Flags", null);
            };
            tsmiFlagsNpcUF.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "NPC Flags (UF)", GameData.UnitNpcFlagsList);
            };
            tsmiFlagsPlayerUF.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "Player Flags (UF)", GameData.UnitNpcFlagsList);
            };
            tsmiFlagsUnitDynamicUF.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "Unit Dynamic Flags (UF)", GameData.UnitDynamicFlagsList);
            };
            tsmiFlagsUnitUF.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "Unit Flags (UF)", GameData.UnitFieldFlagsList);
            };

            tsmiFlagsSpellAttributes.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "Spell Attributes", GameData.SpellAttributesList);
            };
            tsmiFlagsSpellAttributesEx.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "Spell AttributesEx", GameData.SpellAttributesExList);
            };
            tsmiFlagsSpellAttributesEx2.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "Spell AttributesEx2", GameData.SpellAttributesEx2List);
            };
            tsmiFlagsSpellAttributesEx3.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "Spell AttributesEx3", GameData.SpellAttributesEx3List);
            };
            tsmiFlagsSpellAttributesEx4.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "Spell AttributesEx4", GameData.SpellAttributesEx4List);
            };
            tsmiFlagsSpellMechanic.Click += (sender, e) =>
            {
                uint flags = 0;
                Helpers.ShowFlagInputDialog(ref flags, "Spell Mechanic Mask", GameData.SpellMechanicMaskList);
            };
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

        private void picConditionEditor_MouseEnter(object sender, EventArgs e)
        {
            picConditionEditor.BackgroundImage = imgConditionsEditorHighlighted;
            player.Play();
        }

        private void picConditionEditor_MouseLeave(object sender, EventArgs e)
        {
            picConditionEditor.BackgroundImage = imgConditionsEditor;
        }

        private void picConditionEditor_Click(object sender, EventArgs e)
        {
            FormConditionFinder editor = new FormConditionFinder();
            editor.ShowStandalone();
        }
    }
}
