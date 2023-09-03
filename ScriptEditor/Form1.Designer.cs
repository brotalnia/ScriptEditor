namespace ScriptEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picScriptEditor = new System.Windows.Forms.PictureBox();
            this.picEventEditor = new System.Windows.Forms.PictureBox();
            this.picGitLink = new System.Windows.Forms.PictureBox();
            this.picCastsEditor = new System.Windows.Forms.PictureBox();
            this.picConditionEditor = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiEditors = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScripts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreatureEvents = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreatureSpells = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConditions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFinders = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAreaFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreatureFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEventFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFactionFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFactionTemplateFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGameObjectFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItemFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuestFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSoundFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSpellFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTaxiFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTextFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlags = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsGeneric = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFlagsGameObjectUF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsGameObjectDynUF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsUnitUF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsUnitDynamicUF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsNpcUF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsPlayerUF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsSpellMechanic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFlagsSpellAttributes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsSpellAttributesEx = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsSpellAttributesEx2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsSpellAttributesEx3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsSpellAttributesEx4 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picScriptEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEventEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGitLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCastsEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConditionEditor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picScriptEditor
            // 
            this.picScriptEditor.BackColor = System.Drawing.Color.Transparent;
            this.picScriptEditor.BackgroundImage = global::ScriptEditor.Properties.Resources.script_editor_button_black;
            this.picScriptEditor.InitialImage = null;
            this.picScriptEditor.Location = new System.Drawing.Point(17, 126);
            this.picScriptEditor.Name = "picScriptEditor";
            this.picScriptEditor.Size = new System.Drawing.Size(138, 97);
            this.picScriptEditor.TabIndex = 0;
            this.picScriptEditor.TabStop = false;
            this.picScriptEditor.Click += new System.EventHandler(this.picScriptEditor_Click);
            this.picScriptEditor.MouseEnter += new System.EventHandler(this.picScriptEditor_MouseEnter);
            this.picScriptEditor.MouseLeave += new System.EventHandler(this.picScriptEditor_MouseLeave);
            // 
            // picEventEditor
            // 
            this.picEventEditor.BackColor = System.Drawing.Color.Transparent;
            this.picEventEditor.BackgroundImage = global::ScriptEditor.Properties.Resources.event_editor_button_black;
            this.picEventEditor.InitialImage = null;
            this.picEventEditor.Location = new System.Drawing.Point(175, 126);
            this.picEventEditor.Name = "picEventEditor";
            this.picEventEditor.Size = new System.Drawing.Size(138, 97);
            this.picEventEditor.TabIndex = 1;
            this.picEventEditor.TabStop = false;
            this.picEventEditor.Click += new System.EventHandler(this.picEventEditor_Click);
            this.picEventEditor.MouseEnter += new System.EventHandler(this.picEventEditor_MouseEnter);
            this.picEventEditor.MouseLeave += new System.EventHandler(this.picEventEditor_MouseLeave);
            // 
            // picGitLink
            // 
            this.picGitLink.BackColor = System.Drawing.Color.Transparent;
            this.picGitLink.BackgroundImage = global::ScriptEditor.Properties.Resources.gitlink1;
            this.picGitLink.Location = new System.Drawing.Point(8, 29);
            this.picGitLink.Name = "picGitLink";
            this.picGitLink.Size = new System.Drawing.Size(314, 47);
            this.picGitLink.TabIndex = 2;
            this.picGitLink.TabStop = false;
            this.picGitLink.Click += new System.EventHandler(this.picGitLink_Click);
            this.picGitLink.MouseEnter += new System.EventHandler(this.picGitLink_MouseEnter);
            this.picGitLink.MouseLeave += new System.EventHandler(this.picGitLink_MouseLeave);
            // 
            // picCastsEditor
            // 
            this.picCastsEditor.BackColor = System.Drawing.Color.Transparent;
            this.picCastsEditor.BackgroundImage = global::ScriptEditor.Properties.Resources.cast_editor_button_black;
            this.picCastsEditor.InitialImage = null;
            this.picCastsEditor.Location = new System.Drawing.Point(17, 233);
            this.picCastsEditor.Name = "picCastsEditor";
            this.picCastsEditor.Size = new System.Drawing.Size(138, 97);
            this.picCastsEditor.TabIndex = 3;
            this.picCastsEditor.TabStop = false;
            this.picCastsEditor.Click += new System.EventHandler(this.picCastsEditor_Click);
            this.picCastsEditor.MouseEnter += new System.EventHandler(this.picCastsEditor_MouseEnter);
            this.picCastsEditor.MouseLeave += new System.EventHandler(this.picCastsEditor_MouseLeave);
            // 
            // picConditionEditor
            // 
            this.picConditionEditor.BackColor = System.Drawing.Color.Transparent;
            this.picConditionEditor.BackgroundImage = global::ScriptEditor.Properties.Resources.condition_editor_button_black;
            this.picConditionEditor.InitialImage = null;
            this.picConditionEditor.Location = new System.Drawing.Point(175, 233);
            this.picConditionEditor.Name = "picConditionEditor";
            this.picConditionEditor.Size = new System.Drawing.Size(138, 97);
            this.picConditionEditor.TabIndex = 4;
            this.picConditionEditor.TabStop = false;
            this.picConditionEditor.Click += new System.EventHandler(this.picConditionEditor_Click);
            this.picConditionEditor.MouseEnter += new System.EventHandler(this.picConditionEditor_MouseEnter);
            this.picConditionEditor.MouseLeave += new System.EventHandler(this.picConditionEditor_MouseLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditors,
            this.tsmiFinders,
            this.tsmiHelpers});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(330, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiEditors
            // 
            this.tsmiEditors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiScripts,
            this.tsmiCreatureEvents,
            this.tsmiCreatureSpells,
            this.tsmiConditions});
            this.tsmiEditors.Name = "tsmiEditors";
            this.tsmiEditors.Size = new System.Drawing.Size(52, 20);
            this.tsmiEditors.Text = "Editors";
            // 
            // tsmiScripts
            // 
            this.tsmiScripts.Name = "tsmiScripts";
            this.tsmiScripts.Size = new System.Drawing.Size(153, 22);
            this.tsmiScripts.Text = "Scripts";
            // 
            // tsmiCreatureEvents
            // 
            this.tsmiCreatureEvents.Name = "tsmiCreatureEvents";
            this.tsmiCreatureEvents.Size = new System.Drawing.Size(153, 22);
            this.tsmiCreatureEvents.Text = "Creature Events";
            // 
            // tsmiCreatureSpells
            // 
            this.tsmiCreatureSpells.Name = "tsmiCreatureSpells";
            this.tsmiCreatureSpells.Size = new System.Drawing.Size(153, 22);
            this.tsmiCreatureSpells.Text = "Creature Spells";
            // 
            // tsmiConditions
            // 
            this.tsmiConditions.Name = "tsmiConditions";
            this.tsmiConditions.Size = new System.Drawing.Size(153, 22);
            this.tsmiConditions.Text = "Conditions";
            // 
            // tsmiFinders
            // 
            this.tsmiFinders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAreaFinder,
            this.tsmiCreatureFinder,
            this.tsmiEventFinder,
            this.tsmiFactionFinder,
            this.tsmiFactionTemplateFinder,
            this.tsmiGameObjectFinder,
            this.tsmiItemFinder,
            this.tsmiQuestFinder,
            this.tsmiSoundFinder,
            this.tsmiSpellFinder,
            this.tsmiTaxiFinder,
            this.tsmiTextFinder});
            this.tsmiFinders.Name = "tsmiFinders";
            this.tsmiFinders.Size = new System.Drawing.Size(54, 20);
            this.tsmiFinders.Text = "Finders";
            // 
            // tsmiAreaFinder
            // 
            this.tsmiAreaFinder.Name = "tsmiAreaFinder";
            this.tsmiAreaFinder.Size = new System.Drawing.Size(156, 22);
            this.tsmiAreaFinder.Text = "Area";
            // 
            // tsmiCreatureFinder
            // 
            this.tsmiCreatureFinder.Name = "tsmiCreatureFinder";
            this.tsmiCreatureFinder.Size = new System.Drawing.Size(156, 22);
            this.tsmiCreatureFinder.Text = "Creature";
            // 
            // tsmiEventFinder
            // 
            this.tsmiEventFinder.Name = "tsmiEventFinder";
            this.tsmiEventFinder.Size = new System.Drawing.Size(156, 22);
            this.tsmiEventFinder.Text = "Event Finder";
            // 
            // tsmiFactionFinder
            // 
            this.tsmiFactionFinder.Name = "tsmiFactionFinder";
            this.tsmiFactionFinder.Size = new System.Drawing.Size(156, 22);
            this.tsmiFactionFinder.Text = "Faction";
            // 
            // tsmiFactionTemplateFinder
            // 
            this.tsmiFactionTemplateFinder.Name = "tsmiFactionTemplateFinder";
            this.tsmiFactionTemplateFinder.Size = new System.Drawing.Size(156, 22);
            this.tsmiFactionTemplateFinder.Text = "Faction Template";
            // 
            // tsmiGameObjectFinder
            // 
            this.tsmiGameObjectFinder.Name = "tsmiGameObjectFinder";
            this.tsmiGameObjectFinder.Size = new System.Drawing.Size(156, 22);
            this.tsmiGameObjectFinder.Text = "Game Object";
            // 
            // tsmiItemFinder
            // 
            this.tsmiItemFinder.Name = "tsmiItemFinder";
            this.tsmiItemFinder.Size = new System.Drawing.Size(156, 22);
            this.tsmiItemFinder.Text = "Item";
            // 
            // tsmiQuestFinder
            // 
            this.tsmiQuestFinder.Name = "tsmiQuestFinder";
            this.tsmiQuestFinder.Size = new System.Drawing.Size(156, 22);
            this.tsmiQuestFinder.Text = "Quest";
            // 
            // tsmiSoundFinder
            // 
            this.tsmiSoundFinder.Name = "tsmiSoundFinder";
            this.tsmiSoundFinder.Size = new System.Drawing.Size(156, 22);
            this.tsmiSoundFinder.Text = "Sound";
            // 
            // tsmiSpellFinder
            // 
            this.tsmiSpellFinder.Name = "tsmiSpellFinder";
            this.tsmiSpellFinder.Size = new System.Drawing.Size(156, 22);
            this.tsmiSpellFinder.Text = "Spell";
            // 
            // tsmiTaxiFinder
            // 
            this.tsmiTaxiFinder.Name = "tsmiTaxiFinder";
            this.tsmiTaxiFinder.Size = new System.Drawing.Size(156, 22);
            this.tsmiTaxiFinder.Text = "Taxi";
            // 
            // tsmiTextFinder
            // 
            this.tsmiTextFinder.Name = "tsmiTextFinder";
            this.tsmiTextFinder.Size = new System.Drawing.Size(156, 22);
            this.tsmiTextFinder.Text = "Broadcast Text";
            // 
            // tsmiHelpers
            // 
            this.tsmiHelpers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFlags});
            this.tsmiHelpers.Name = "tsmiHelpers";
            this.tsmiHelpers.Size = new System.Drawing.Size(55, 20);
            this.tsmiHelpers.Text = "Helpers";
            // 
            // tsmiFlags
            // 
            this.tsmiFlags.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFlagsGeneric,
            this.toolStripSeparator1,
            this.tsmiFlagsGameObjectUF,
            this.tsmiFlagsGameObjectDynUF,
            this.tsmiFlagsUnitUF,
            this.tsmiFlagsUnitDynamicUF,
            this.tsmiFlagsNpcUF,
            this.tsmiFlagsPlayerUF,
            this.toolStripSeparator2,
            this.tsmiFlagsSpellAttributes,
            this.tsmiFlagsSpellAttributesEx,
            this.tsmiFlagsSpellAttributesEx2,
            this.tsmiFlagsSpellAttributesEx3,
            this.tsmiFlagsSpellAttributesEx4,
            this.tsmiFlagsSpellMechanic});
            this.tsmiFlags.Name = "tsmiFlags";
            this.tsmiFlags.Size = new System.Drawing.Size(152, 22);
            this.tsmiFlags.Text = "Flags";
            // 
            // tsmiFlagsGeneric
            // 
            this.tsmiFlagsGeneric.Name = "tsmiFlagsGeneric";
            this.tsmiFlagsGeneric.Size = new System.Drawing.Size(203, 22);
            this.tsmiFlagsGeneric.Text = "Generic";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // tsmiFlagsGameObjectUF
            // 
            this.tsmiFlagsGameObjectUF.Name = "tsmiFlagsGameObjectUF";
            this.tsmiFlagsGameObjectUF.Size = new System.Drawing.Size(203, 22);
            this.tsmiFlagsGameObjectUF.Text = "Game Object Flags (UF)";
            // 
            // tsmiFlagsGameObjectDynUF
            // 
            this.tsmiFlagsGameObjectDynUF.Name = "tsmiFlagsGameObjectDynUF";
            this.tsmiFlagsGameObjectDynUF.Size = new System.Drawing.Size(203, 22);
            this.tsmiFlagsGameObjectDynUF.Text = "Game Object Dynamic (UF)";
            // 
            // tsmiFlagsUnitUF
            // 
            this.tsmiFlagsUnitUF.Name = "tsmiFlagsUnitUF";
            this.tsmiFlagsUnitUF.Size = new System.Drawing.Size(203, 22);
            this.tsmiFlagsUnitUF.Text = "Unit (UF)";
            // 
            // tsmiFlagsUnitDynamicUF
            // 
            this.tsmiFlagsUnitDynamicUF.Name = "tsmiFlagsUnitDynamicUF";
            this.tsmiFlagsUnitDynamicUF.Size = new System.Drawing.Size(203, 22);
            this.tsmiFlagsUnitDynamicUF.Text = "Unit Dynamic (UF)";
            // 
            // tsmiFlagsNpcUF
            // 
            this.tsmiFlagsNpcUF.Name = "tsmiFlagsNpcUF";
            this.tsmiFlagsNpcUF.Size = new System.Drawing.Size(203, 22);
            this.tsmiFlagsNpcUF.Text = "NPC (UF)";
            // 
            // tsmiFlagsPlayerUF
            // 
            this.tsmiFlagsPlayerUF.Name = "tsmiFlagsPlayerUF";
            this.tsmiFlagsPlayerUF.Size = new System.Drawing.Size(203, 22);
            this.tsmiFlagsPlayerUF.Text = "Player (UF)";
            // 
            // tsmiFlagsSpellMechanic
            // 
            this.tsmiFlagsSpellMechanic.Name = "tsmiFlagsSpellMechanic";
            this.tsmiFlagsSpellMechanic.Size = new System.Drawing.Size(203, 22);
            this.tsmiFlagsSpellMechanic.Text = "Spell Mechanic";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // tsmiFlagsSpellAttributes
            // 
            this.tsmiFlagsSpellAttributes.Name = "tsmiFlagsSpellAttributes";
            this.tsmiFlagsSpellAttributes.Size = new System.Drawing.Size(203, 22);
            this.tsmiFlagsSpellAttributes.Text = "Spell Attributes";
            // 
            // tsmiFlagsSpellAttributesEx
            // 
            this.tsmiFlagsSpellAttributesEx.Name = "tsmiFlagsSpellAttributesEx";
            this.tsmiFlagsSpellAttributesEx.Size = new System.Drawing.Size(203, 22);
            this.tsmiFlagsSpellAttributesEx.Text = "Spell AttributesEx";
            // 
            // tsmiFlagsSpellAttributesEx2
            // 
            this.tsmiFlagsSpellAttributesEx2.Name = "tsmiFlagsSpellAttributesEx2";
            this.tsmiFlagsSpellAttributesEx2.Size = new System.Drawing.Size(203, 22);
            this.tsmiFlagsSpellAttributesEx2.Text = "Spell AttributesEx2";
            // 
            // tsmiFlagsSpellAttributesEx3
            // 
            this.tsmiFlagsSpellAttributesEx3.Name = "tsmiFlagsSpellAttributesEx3";
            this.tsmiFlagsSpellAttributesEx3.Size = new System.Drawing.Size(203, 22);
            this.tsmiFlagsSpellAttributesEx3.Text = "Spell AttributesEx3";
            // 
            // tsmiFlagsSpellAttributesEx4
            // 
            this.tsmiFlagsSpellAttributesEx4.Name = "tsmiFlagsSpellAttributesEx4";
            this.tsmiFlagsSpellAttributesEx4.Size = new System.Drawing.Size(203, 22);
            this.tsmiFlagsSpellAttributesEx4.Text = "Spell AttributesEx4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ScriptEditor.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(330, 371);
            this.Controls.Add(this.picConditionEditor);
            this.Controls.Add(this.picCastsEditor);
            this.Controls.Add(this.picGitLink);
            this.Controls.Add(this.picEventEditor);
            this.Controls.Add(this.picScriptEditor);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "VMaNGOS Developer Tools";
            ((System.ComponentModel.ISupportInitialize)(this.picScriptEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEventEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGitLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCastsEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picConditionEditor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picScriptEditor;
        private System.Windows.Forms.PictureBox picEventEditor;
        private System.Windows.Forms.PictureBox picGitLink;
        private System.Windows.Forms.PictureBox picCastsEditor;
        private System.Windows.Forms.PictureBox picConditionEditor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditors;
        private System.Windows.Forms.ToolStripMenuItem tsmiScripts;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreatureEvents;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreatureSpells;
        private System.Windows.Forms.ToolStripMenuItem tsmiConditions;
        private System.Windows.Forms.ToolStripMenuItem tsmiFinders;
        private System.Windows.Forms.ToolStripMenuItem tsmiAreaFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreatureFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiEventFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiFactionFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiFactionTemplateFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiGameObjectFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiItemFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuestFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiSoundFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpellFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiTaxiFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiTextFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpers;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlags;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsGeneric;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsGameObjectUF;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsGameObjectDynUF;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsUnitUF;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsUnitDynamicUF;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsNpcUF;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsPlayerUF;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsSpellMechanic;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsSpellAttributes;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsSpellAttributesEx;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsSpellAttributesEx2;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsSpellAttributesEx3;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsSpellAttributesEx4;
    }
}