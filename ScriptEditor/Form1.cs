using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ScriptEditor
{
    public partial class Form1 : Form
    {
        public string connString = "Server=localhost;Database=mangos;Uid=root;Pwd=root;";
        public string mysqlUser = "root";
        public string mysqlPass = "root";
        public string mysqlHost = "localhost";
        public string mysqlDB = "mangos";
        public static uint currentScriptId = 0;

        public static List<BroadcastText> BroadcastTextsList = new List<BroadcastText>();
        List<ComboboxPair> UpdateFieldsList = new List<ComboboxPair>();
        List<ComboboxPair> FlagFieldsList = new List<ComboboxPair>();

        bool dontUpdate = false;

        public Form1()
        {
            InitializeComponent();
        }

        public struct BroadcastText
        {
            public uint ID;
            public string Text;
            public uint ChatType;
            public uint Language;
            public BroadcastText(uint id, string text, uint chattype, uint language)
            {
                ID = id;
                Text = text;
                ChatType = chattype;
                Language = language;
            }
        }

        public class ScriptAction
        {
            public uint Id;
            public uint Delay;
            public uint Command;
            public uint Datalong;
            public uint Datalong2;
            public uint Datalong3;
            public uint Datalong4;
            public uint BuddyId;
            public uint BuddyRadius;
            public uint BuddyType;
            public uint DataFlags;
            public int Dataint;
            public int Dataint2;
            public int Dataint3;
            public int Dataint4;
            public float X;
            public float Y;
            public float Z;
            public float O;
            public string Comments;
            public ScriptAction(uint id, uint delay, uint command, uint datalong, uint datalong2, uint datalong3, uint datalong4, uint buddyid, uint buddyradius, uint buddytype, uint dataflags, int dataint, int dataint2, int dataint3, int dataint4, float x, float y, float z, float o, string comments)
            {
                Id = id;
                Delay = delay;
                Command = command;
                Datalong = datalong;
                Datalong2 = datalong2;
                Datalong3 = datalong3;
                Datalong4 = datalong4;
                BuddyId = buddyid;
                BuddyRadius = buddyradius;
                BuddyType = buddytype;
                DataFlags = dataflags;
                Dataint = dataint;
                Dataint2 = dataint2;
                Dataint3 = dataint3;
                Dataint4 = dataint4;
                X = x;
                Y = y;
                Z = z;
                O = o;
                Comments = comments;
            }
            public ScriptAction()
            {
                Id = Form1.currentScriptId;
                Delay = 0;
                Command = 0;
                Datalong = 0;
                Datalong2 = 0;
                Datalong3 = 0;
                Datalong4 = 0;
                BuddyId = 0;
                BuddyRadius = 0;
                BuddyType = 0;
                DataFlags = 0;
                Dataint = 0;
                Dataint2 = 0;
                Dataint3 = 0;
                Dataint4 = 0;
                X = 0;
                Y = 0;
                Z = 0;
                O = 0;
                Comments = "New Action - Edit me!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadControls();
            LoadConfig();
            LoadBroadcastTexts();
        }

        public class ComboboxPair
        {
            public string Text { get; set; }
            public int Value { get; set; }
            
            public ComboboxPair(string text, int value)
            {
                this.Text = text;
                this.Value = value;
            }
            public override string ToString()
            {
                return Text;
            }
        }
        private void LoadControls()
        {
            dontUpdate = true;

            // Assign sorter to listview.
            lstActions.ListViewItemSorter = new ActionSorter();

            // Add options to Commands combo box.
            cmbCommandId.Items.Add(new ComboboxPair("Talk", 0));
            cmbCommandId.Items.Add(new ComboboxPair("Emote", 1));
            cmbCommandId.Items.Add(new ComboboxPair("Field Set", 2));
            cmbCommandId.Items.Add(new ComboboxPair("Move", 3));
            cmbCommandId.Items.Add(new ComboboxPair("Flag Set", 4));
            cmbCommandId.Items.Add(new ComboboxPair("Flag Remove", 5));
            cmbCommandId.Items.Add(new ComboboxPair("Teleport", 6));
            cmbCommandId.Items.Add(new ComboboxPair("Complete Quest", 7));
            cmbCommandId.Items.Add(new ComboboxPair("Kill Credit", 8));
            cmbCommandId.Items.Add(new ComboboxPair("Respawn GameObject", 9));
            cmbCommandId.Items.Add(new ComboboxPair("Summon Creature", 10));
            cmbCommandId.Items.Add(new ComboboxPair("Open Door", 11));
            cmbCommandId.Items.Add(new ComboboxPair("Close Door", 12));
            cmbCommandId.Items.Add(new ComboboxPair("Activate GameObject", 13));
            cmbCommandId.Items.Add(new ComboboxPair("Remove Aura", 14));
            cmbCommandId.Items.Add(new ComboboxPair("Cast Spell", 15));
            cmbCommandId.Items.Add(new ComboboxPair("Play Sound", 16));
            cmbCommandId.Items.Add(new ComboboxPair("Create Item", 17));
            cmbCommandId.Items.Add(new ComboboxPair("Despawn Creature", 18));
            cmbCommandId.Items.Add(new ComboboxPair("Set Equipment", 19));
            cmbCommandId.Items.Add(new ComboboxPair("Set Movement Type", 20));
            cmbCommandId.Items.Add(new ComboboxPair("Make Active Object", 21));
            cmbCommandId.Items.Add(new ComboboxPair("Set Faction", 22));
            cmbCommandId.Items.Add(new ComboboxPair("Morph", 23));
            cmbCommandId.Items.Add(new ComboboxPair("Mount", 24));
            cmbCommandId.Items.Add(new ComboboxPair("Toggle Run or Walk", 25));
            cmbCommandId.Items.Add(new ComboboxPair("Start Attack", 26));
            cmbCommandId.Items.Add(new ComboboxPair("Set Lock State", 27));
            cmbCommandId.Items.Add(new ComboboxPair("Set Stand State", 28));
            cmbCommandId.Items.Add(new ComboboxPair("Set NPC Flags", 29));
            cmbCommandId.Items.Add(new ComboboxPair("Start Taxi Path", 30));
            cmbCommandId.Items.Add(new ComboboxPair("Terminate Script", 31));
            cmbCommandId.Items.Add(new ComboboxPair("Terminate Condition", 32));
            cmbCommandId.Items.Add(new ComboboxPair("Enter Evade Mode", 33));
            cmbCommandId.Items.Add(new ComboboxPair("Set Home Position", 34));
            cmbCommandId.Items.Add(new ComboboxPair("Set Orientation", 35));
            cmbCommandId.Items.Add(new ComboboxPair("MeetingStone Queue", 36));
            cmbCommandId.Items.Add(new ComboboxPair("Set Data", 37));
            cmbCommandId.Items.Add(new ComboboxPair("Set Data 64", 38));
            cmbCommandId.SelectedIndex = 0;

            // Add option to Buddy Type combo box.
            cmbBuddyType.Items.Add(new ComboboxPair("Creature Entry", 0));
            cmbBuddyType.Items.Add(new ComboboxPair("Creature GUID", 1));
            cmbBuddyType.Items.Add(new ComboboxPair("Creature Instance Data", 2));
            cmbBuddyType.Items.Add(new ComboboxPair("Gameobject Entry", 3));
            cmbBuddyType.Items.Add(new ComboboxPair("Gameobject GUID", 4));
            cmbBuddyType.Items.Add(new ComboboxPair("Gameobject Instance Data", 5));
            cmbBuddyType.SelectedIndex = 0;

            // Add options to Talk Command Chat Type combo box.
            cmbTalkChatType.Items.Add(new ComboboxPair("-NONE-", 0));
            cmbTalkChatType.Items.Add(new ComboboxPair("Yell", 1));
            cmbTalkChatType.Items.Add(new ComboboxPair("Text Emote", 2));
            cmbTalkChatType.Items.Add(new ComboboxPair("Zone Emote", 3));
            cmbTalkChatType.Items.Add(new ComboboxPair("Whisper", 4));
            cmbTalkChatType.Items.Add(new ComboboxPair("Boss Whisper", 5));
            cmbTalkChatType.Items.Add(new ComboboxPair("Zone Yell", 6));
            cmbTalkChatType.SelectedIndex = 0;

            // Add options to Emote Command Id combo box.
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_NONE", 0));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_TALK(DNR)", 1));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_BOW", 2));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_WAVE(DNR)", 3));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_CHEER(DNR)", 4));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_EXCLAMATION(DNR)", 5));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_QUESTION", 6));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_EAT", 7));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_DANCE", 10));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_LAUGH", 11));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_SLEEP", 12));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_SIT", 13));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_RUDE(DNR)", 14));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_ROAR(DNR)", 15));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_KNEEL", 16));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_KISS", 17));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_CRY", 18));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_CHICKEN", 19));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_BEG", 20));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_APPLAUD", 21));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_SHOUT(DNR)", 22));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_FLEX", 23));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_SHY(DNR)", 24));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_POINT(DNR)", 25));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_STAND", 26));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_READYUNARMED", 27));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_WORK", 28));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_POINT(DNR)", 29));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_NONE", 30));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_WOUND", 33));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_WOUNDCRITICAL", 34));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_ATTACKUNARMED", 35));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_ATTACK1H", 36));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_ATTACK2HTIGHT", 37));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_ATTACK2HLOOSE", 38));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_PARRYUNARMED", 39));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_PARRYSHIELD", 43));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_READYUNARMED", 44));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_READY1H", 45));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_READYBOW", 48));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_SPELLPRECAST", 50));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_SPELLCAST", 51));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_BATTLEROAR", 53));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_SPECIALATTACK1H", 54));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_KICK", 60));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_ATTACKTHROWN", 61));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_STUN", 64));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_DEAD", 65));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_SALUTE", 66));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_KNEEL", 68));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_USESTANDING", 69));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_WAVE_NOSHEATHE", 70));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_CHEER_NOSHEATHE", 71));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_EAT_NOSHEATHE", 92));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_STUN_NOSHEATHE", 93));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_DANCE", 94));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_SALUTE_NOSHEATH", 113));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_USESTANDING_NOSHEATHE", 133));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_LAUGH_NOSHEATHE", 153));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_WORK_NOSHEATHE", 173));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_SPELLPRECAST", 193));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_READYRIFLE", 213));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_READYRIFLE", 214));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_WORK_NOSHEATHE_MINING", 233));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_WORK_NOSHEATHE_CHOPWOOD", 234));
            cmbEmoteId.Items.Add(new ComboboxPair("zzOLDONESHOT_LIFTOFF", 253));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_LIFTOFF", 254));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_YES(DNR)", 273));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_NO(DNR)", 274));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_TRAIN(DNR)", 275));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_LAND", 293));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_AT_EASE", 313));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_READY1H", 333));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_SPELLKNEELSTART", 353));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_SUBMERGED", 373));
            cmbEmoteId.Items.Add(new ComboboxPair("ONESHOT_SUBMERGE", 374));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_READY2H", 375));
            cmbEmoteId.Items.Add(new ComboboxPair("STATE_READYBOW", 376));

            // Add update field ids to a list.
            UpdateFieldsList.Add(new ComboboxPair("OBJECT_FIELD_SCALE_X", 4));
            UpdateFieldsList.Add(new ComboboxPair("ITEM_FIELD_OWNER", 6));
            UpdateFieldsList.Add(new ComboboxPair("ITEM_FIELD_CONTAINED", 8));
            UpdateFieldsList.Add(new ComboboxPair("ITEM_FIELD_CREATOR", 10));
            UpdateFieldsList.Add(new ComboboxPair("ITEM_FIELD_GIFTCREATOR", 12));
            UpdateFieldsList.Add(new ComboboxPair("ITEM_FIELD_STACK_COUNT", 14));
            UpdateFieldsList.Add(new ComboboxPair("ITEM_FIELD_DURATION", 15));
            UpdateFieldsList.Add(new ComboboxPair("ITEM_FIELD_SPELL_CHARGES", 16));
            UpdateFieldsList.Add(new ComboboxPair("ITEM_FIELD_SPELL_CHARGES_01", 17));
            UpdateFieldsList.Add(new ComboboxPair("ITEM_FIELD_SPELL_CHARGES_02", 18));
            UpdateFieldsList.Add(new ComboboxPair("ITEM_FIELD_SPELL_CHARGES_03", 19));
            UpdateFieldsList.Add(new ComboboxPair("ITEM_FIELD_SPELL_CHARGES_04", 20));
            UpdateFieldsList.Add(new ComboboxPair("ITEM_FIELD_FLAGS", 21));
            UpdateFieldsList.Add(new ComboboxPair("ITEM_FIELD_ENCHANTMENT", 22));
            UpdateFieldsList.Add(new ComboboxPair("ITEM_FIELD_PROPERTY_SEED", 43));
            UpdateFieldsList.Add(new ComboboxPair("ITEM_FIELD_RANDOM_PROPERTIES_ID", 44));
            UpdateFieldsList.Add(new ComboboxPair("ITEM_FIELD_ITEM_TEXT_ID", 45));
            UpdateFieldsList.Add(new ComboboxPair("ITEM_FIELD_DURABILITY", 46));
            UpdateFieldsList.Add(new ComboboxPair("ITEM_FIELD_MAXDURABILITY", 47));
            UpdateFieldsList.Add(new ComboboxPair("CONTAINER_FIELD_NUM_SLOTS", 48));
            UpdateFieldsList.Add(new ComboboxPair("CONTAINER_ALIGN_PAD", 49));
            UpdateFieldsList.Add(new ComboboxPair("CONTAINER_FIELD_SLOT_1", 50));
            UpdateFieldsList.Add(new ComboboxPair("CONTAINER_FIELD_SLOT_LAST", 104));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_CHARM", 6));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_SUMMON", 8));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_CHARMEDBY", 10));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_SUMMONEDBY", 12));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_CREATEDBY", 14));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_TARGET", 16));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_PERSUADED", 18));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_CHANNEL_OBJECT", 20));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_HEALTH", 22));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_POWER1", 23));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_POWER2", 24));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_POWER3", 25));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_POWER4", 26));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_POWER5", 27));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_MAXHEALTH", 28));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_MAXPOWER1", 29));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_MAXPOWER2", 30));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_MAXPOWER3", 31));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_MAXPOWER4", 32));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_MAXPOWER5", 33));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_LEVEL", 34));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_FACTIONTEMPLATE", 35));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_BYTES_0", 36));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_VIRTUAL_ITEM_SLOT_DISPLAY", 37));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_VIRTUAL_ITEM_SLOT_DISPLAY_01", 38));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_VIRTUAL_ITEM_SLOT_DISPLAY_02", 39));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_VIRTUAL_ITEM_INFO", 40));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_VIRTUAL_ITEM_INFO_01", 41));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_VIRTUAL_ITEM_INFO_02", 42));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_VIRTUAL_ITEM_INFO_03", 43));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_VIRTUAL_ITEM_INFO_04", 44));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_VIRTUAL_ITEM_INFO_05", 45));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_FLAGS", 46));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_AURA", 47));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_AURA_LAST", 94));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_AURAFLAGS", 95));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_AURAFLAGS_01", 96));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_AURAFLAGS_02", 97));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_AURAFLAGS_03", 98));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_AURAFLAGS_04", 99));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_AURAFLAGS_05", 100));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_AURALEVELS", 101));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_AURALEVELS_LAST", 112));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_AURAAPPLICATIONS", 113));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_AURAAPPLICATIONS_LAST", 124));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_AURASTATE", 125));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_BASEATTACKTIME", 126));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_OFFHANDATTACKTIME", 127));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_RANGEDATTACKTIME", 128));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_BOUNDINGRADIUS", 129));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_COMBATREACH", 130));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_DISPLAYID", 131));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_NATIVEDISPLAYID", 132));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_MOUNTDISPLAYID", 133));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_MINDAMAGE", 134));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_MAXDAMAGE", 135));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_MINOFFHANDDAMAGE", 136));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_MAXOFFHANDDAMAGE", 137));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_BYTES_1", 138));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_PETNUMBER", 139));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_PET_NAME_TIMESTAMP", 140));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_PETEXPERIENCE", 141));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_PETNEXTLEVELEXP", 142));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_DYNAMIC_FLAGS", 143));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_CHANNEL_SPELL", 144));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_MOD_CAST_SPEED", 145));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_CREATED_BY_SPELL", 146));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_NPC_FLAGS", 147));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_NPC_EMOTESTATE", 148));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_TRAINING_POINTS", 149));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_STAT0", 150));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_STAT1", 151));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_STAT2", 152));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_STAT3", 153));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_STAT4", 154));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_RESISTANCES", 155));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_RESISTANCES_01", 156));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_RESISTANCES_02", 157));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_RESISTANCES_03", 158));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_RESISTANCES_04", 159));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_RESISTANCES_05", 160));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_RESISTANCES_06", 161));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_BASE_MANA", 162));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_BASE_HEALTH", 163));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_BYTES_2", 164));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_ATTACK_POWER", 165));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_ATTACK_POWER_MODS", 166));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_ATTACK_POWER_MULTIPLIER", 167));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_RANGED_ATTACK_POWER", 168));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_RANGED_ATTACK_POWER_MODS", 169));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_RANGED_ATTACK_POWER_MULTIPLIER", 170));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_MINRANGEDDAMAGE", 171));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_MAXRANGEDDAMAGE", 172));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_POWER_COST_MODIFIER", 174));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_POWER_COST_MODIFIER_02", 175));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_POWER_COST_MODIFIER_03", 176));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_POWER_COST_MODIFIER_04", 177));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_POWER_COST_MODIFIER_05", 178));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_POWER_COST_MODIFIER_06", 179));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_POWER_COST_MULTIPLIER", 180));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_POWER_COST_MULTIPLIER_01", 181));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_POWER_COST_MULTIPLIER_02", 182));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_POWER_COST_MULTIPLIER_03", 183));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_POWER_COST_MULTIPLIER_04", 184));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_POWER_COST_MULTIPLIER_05", 185));
            UpdateFieldsList.Add(new ComboboxPair("UNIT_FIELD_POWER_COST_MULTIPLIER_06", 186));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_DUEL_ARBITER", 188));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FLAGS", 190));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_GUILDID", 191));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_GUILDRANK", 192));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_BYTES", 193));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_BYTES_2", 194));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_BYTES_3", 195));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_DUEL_TEAM", 196));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_GUILD_TIMESTAMP", 197));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_QUEST_LOG_1_1", 198));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_QUEST_LOG_1_2", 199));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_QUEST_LOG_1_3", 200));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_QUEST_LOG_LAST_1", 255));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_QUEST_LOG_LAST_2", 256));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_QUEST_LOG_LAST_3", 257));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_VISIBLE_ITEM_1_CREATOR", 258));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_VISIBLE_ITEM_1_0", 260));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_VISIBLE_ITEM_1_PROPERTIES", 268));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_VISIBLE_ITEM_LAST_CREATOR", 474));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_VISIBLE_ITEM_LAST_0", 476));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_VISIBLE_ITEM_LAST_PROPERTIES", 484));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_INV_SLOT_HEAD", 486));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_PACK_SLOT_1", 532));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_PACK_SLOT_LAST", 562));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_BANK_SLOT_1", 564));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_BANK_SLOT_LAST", 610));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_BANKBAG_SLOT_1", 612));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_BANKBAG_SLOT_LAST", 2926));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_VENDORBUYBACK_SLOT_1", 624));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_VENDORBUYBACK_SLOT_LAST", 646));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_KEYRING_SLOT_1", 648));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_KEYRING_SLOT_LAST", 710));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FARSIGHT", 712));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_COMBO_TARGET", 714));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_XP", 716));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_NEXT_LEVEL_XP", 717));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_SKILL_INFO_1_1", 718));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_CHARACTER_POINTS1", 1102));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_CHARACTER_POINTS2", 1103));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_TRACK_CREATURES", 1104));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_TRACK_RESOURCES", 1105));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_BLOCK_PERCENTAGE", 1106));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_DODGE_PERCENTAGE", 1107));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_PARRY_PERCENTAGE", 1108));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_CRIT_PERCENTAGE", 1109));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_RANGED_CRIT_PERCENTAGE", 1110));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_EXPLORED_ZONES_1", 1111));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_REST_STATE_EXPERIENCE", 1175));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_COINAGE", 1176));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_POSSTAT0", 1177));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_POSSTAT1", 1178));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_POSSTAT2", 1179));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_POSSTAT3", 1180));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_POSSTAT4", 1181));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_NEGSTAT0", 1182));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_NEGSTAT1", 1183));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_NEGSTAT2", 1184));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_NEGSTAT3", 1185));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_NEGSTAT4", 1186));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_RESISTANCEBUFFMODSPOSITIVE", 1187));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_RESISTANCEBUFFMODSNEGATIVE", 1194));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_MOD_DAMAGE_DONE_POS", 1201));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_MOD_DAMAGE_DONE_NEG", 1208));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_MOD_DAMAGE_DONE_PCT", 1215));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_BYTES", 1222));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_AMMO_ID", 1223));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_SELF_RES_SPELL", 1224));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_PVP_MEDALS", 1225));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_BUYBACK_PRICE_1", 1226));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_BUYBACK_PRICE_LAST", 1237));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_BUYBACK_TIMESTAMP_1", 1238));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_BUYBACK_TIMESTAMP_LAST", 1249));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_SESSION_KILLS", 1250));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_YESTERDAY_KILLS", 1251));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_LAST_WEEK_KILLS", 1252));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_THIS_WEEK_KILLS", 1253));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_THIS_WEEK_CONTRIBUTION", 1254));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_LIFETIME_HONORABLE_KILLS", 1255));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_LIFETIME_DISHONORABLE_KILLS", 1256));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_YESTERDAY_CONTRIBUTION", 1257));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_LAST_WEEK_CONTRIBUTION", 1258));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_LAST_WEEK_RANK", 1259));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_BYTES2", 1260));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_WATCHED_FACTION_INDEX", 1261));
            UpdateFieldsList.Add(new ComboboxPair("PLAYER_FIELD_COMBAT_RATING_1", 1262));
            UpdateFieldsList.Add(new ComboboxPair("OBJECT_FIELD_CREATED_BY", 6));
            UpdateFieldsList.Add(new ComboboxPair("GAMEOBJECT_DISPLAYID", 8));
            UpdateFieldsList.Add(new ComboboxPair("GAMEOBJECT_FLAGS", 9));
            UpdateFieldsList.Add(new ComboboxPair("GAMEOBJECT_ROTATION", 10));
            UpdateFieldsList.Add(new ComboboxPair("GAMEOBJECT_STATE", 14));
            UpdateFieldsList.Add(new ComboboxPair("GAMEOBJECT_POS_X", 15));
            UpdateFieldsList.Add(new ComboboxPair("GAMEOBJECT_POS_Y", 16));
            UpdateFieldsList.Add(new ComboboxPair("GAMEOBJECT_POS_Z", 17));
            UpdateFieldsList.Add(new ComboboxPair("GAMEOBJECT_FACING", 18));
            UpdateFieldsList.Add(new ComboboxPair("GAMEOBJECT_DYN_FLAGS", 19));
            UpdateFieldsList.Add(new ComboboxPair("GAMEOBJECT_FACTION", 20));
            UpdateFieldsList.Add(new ComboboxPair("GAMEOBJECT_TYPE_ID", 21));
            UpdateFieldsList.Add(new ComboboxPair("GAMEOBJECT_LEVEL", 22));
            UpdateFieldsList.Add(new ComboboxPair("GAMEOBJECT_ARTKIT", 23));
            UpdateFieldsList.Add(new ComboboxPair("GAMEOBJECT_ANIMPROGRESS", 24));
            UpdateFieldsList.Add(new ComboboxPair("DYNAMICOBJECT_CASTER", 6));
            UpdateFieldsList.Add(new ComboboxPair("DYNAMICOBJECT_BYTES", 8));
            UpdateFieldsList.Add(new ComboboxPair("DYNAMICOBJECT_SPELLID", 9));
            UpdateFieldsList.Add(new ComboboxPair("DYNAMICOBJECT_RADIUS", 10));
            UpdateFieldsList.Add(new ComboboxPair("DYNAMICOBJECT_POS_X", 11));
            UpdateFieldsList.Add(new ComboboxPair("DYNAMICOBJECT_POS_Y", 12));
            UpdateFieldsList.Add(new ComboboxPair("DYNAMICOBJECT_POS_Z", 13));
            UpdateFieldsList.Add(new ComboboxPair("DYNAMICOBJECT_FACING", 14));
            UpdateFieldsList.Add(new ComboboxPair("CORPSE_FIELD_OWNER", 6));
            UpdateFieldsList.Add(new ComboboxPair("CORPSE_FIELD_FACING", 8));
            UpdateFieldsList.Add(new ComboboxPair("CORPSE_FIELD_POS_X", 9));
            UpdateFieldsList.Add(new ComboboxPair("CORPSE_FIELD_POS_Y", 10));
            UpdateFieldsList.Add(new ComboboxPair("CORPSE_FIELD_POS_Z", 11));
            UpdateFieldsList.Add(new ComboboxPair("CORPSE_FIELD_DISPLAY_ID", 12));
            UpdateFieldsList.Add(new ComboboxPair("CORPSE_FIELD_ITEM", 13));
            UpdateFieldsList.Add(new ComboboxPair("CORPSE_FIELD_BYTES_1", 32));
            UpdateFieldsList.Add(new ComboboxPair("CORPSE_FIELD_BYTES_2", 33));
            UpdateFieldsList.Add(new ComboboxPair("CORPSE_FIELD_GUILD", 34));
            UpdateFieldsList.Add(new ComboboxPair("CORPSE_FIELD_FLAGS", 35));
            UpdateFieldsList.Add(new ComboboxPair("CORPSE_FIELD_DYNAMIC_FLAGS", 36));

            // Add update fields with flags to a list.
            FlagFieldsList.Add(new ComboboxPair("GAMEOBJECT_FLAGS", 9));
            FlagFieldsList.Add(new ComboboxPair("GAMEOBJECT_DYN_FLAGS", 19));
            FlagFieldsList.Add(new ComboboxPair("ITEM_FIELD_FLAGS", 21));
            FlagFieldsList.Add(new ComboboxPair("CORPSE_FIELD_FLAGS", 35));
            FlagFieldsList.Add(new ComboboxPair("CORPSE_FIELD_DYNAMIC_FLAGS", 36));
            FlagFieldsList.Add(new ComboboxPair("UNIT_FIELD_FLAGS", 46));
            FlagFieldsList.Add(new ComboboxPair("UNIT_DYNAMIC_FLAGS", 143));
            FlagFieldsList.Add(new ComboboxPair("UNIT_NPC_FLAGS", 147));
            FlagFieldsList.Add(new ComboboxPair("PLAYER_FLAGS", 190));

            // Assign fields list to combo box.
            cmbFieldSetFields.DataSource = FlagFieldsList;

            // Add options to Teleport Map combo box.
            cmbTeleportMap.Items.Add(new ComboboxPair("Eastern Kingdoms", 0));
            cmbTeleportMap.Items.Add(new ComboboxPair("Kalimdor", 1));
            cmbTeleportMap.Items.Add(new ComboboxPair("Testing", 13));
            cmbTeleportMap.Items.Add(new ComboboxPair("Scott Test", 25));
            cmbTeleportMap.Items.Add(new ComboboxPair("CashTest", 29));
            cmbTeleportMap.Items.Add(new ComboboxPair("Alterac Valley", 30));
            cmbTeleportMap.Items.Add(new ComboboxPair("Shadowfang Keep", 33));
            cmbTeleportMap.Items.Add(new ComboboxPair("Stormwind Stockade", 34));
            cmbTeleportMap.Items.Add(new ComboboxPair("Stormwind Prison", 35));
            cmbTeleportMap.Items.Add(new ComboboxPair("Deadmines", 36));
            cmbTeleportMap.Items.Add(new ComboboxPair("Azshara Crater", 37));
            cmbTeleportMap.Items.Add(new ComboboxPair("Collin\'s Test", 42));
            cmbTeleportMap.Items.Add(new ComboboxPair("Wailing Caverns", 43));
            cmbTeleportMap.Items.Add(new ComboboxPair("Monastery", 44));
            cmbTeleportMap.Items.Add(new ComboboxPair("Razorfen Kraul", 47));
            cmbTeleportMap.Items.Add(new ComboboxPair("Blackfathom Deeps", 48));
            cmbTeleportMap.Items.Add(new ComboboxPair("Uldaman", 70));
            cmbTeleportMap.Items.Add(new ComboboxPair("Gnomeregan", 90));
            cmbTeleportMap.Items.Add(new ComboboxPair("Sunken Temple", 109));
            cmbTeleportMap.Items.Add(new ComboboxPair("Razorfen Downs", 129));
            cmbTeleportMap.Items.Add(new ComboboxPair("Emerald Dream", 169));
            cmbTeleportMap.Items.Add(new ComboboxPair("Scarlet Monastery", 189));
            cmbTeleportMap.Items.Add(new ComboboxPair("Zul\'Farrak", 209));
            cmbTeleportMap.Items.Add(new ComboboxPair("Blackrock Spire", 229));
            cmbTeleportMap.Items.Add(new ComboboxPair("Blackrock Depths", 230));
            cmbTeleportMap.Items.Add(new ComboboxPair("Onyxia\'s Lair", 249));
            cmbTeleportMap.Items.Add(new ComboboxPair("Caverns of Time", 269));
            cmbTeleportMap.Items.Add(new ComboboxPair("Scholomance", 289));
            cmbTeleportMap.Items.Add(new ComboboxPair("Zul\'Gurub", 309));
            cmbTeleportMap.Items.Add(new ComboboxPair("Stratholme", 329));
            cmbTeleportMap.Items.Add(new ComboboxPair("Maraudon", 349));
            cmbTeleportMap.Items.Add(new ComboboxPair("Deeprun Tram", 369));
            cmbTeleportMap.Items.Add(new ComboboxPair("Ragefire Chasm", 389));
            cmbTeleportMap.Items.Add(new ComboboxPair("Molten Core", 409));
            cmbTeleportMap.Items.Add(new ComboboxPair("Dire Maul", 429));
            cmbTeleportMap.Items.Add(new ComboboxPair("Alliance PVP Barracks", 449));
            cmbTeleportMap.Items.Add(new ComboboxPair("Horde PVP Barracks", 450));
            cmbTeleportMap.Items.Add(new ComboboxPair("Development Land", 451));
            cmbTeleportMap.Items.Add(new ComboboxPair("Blackwing Lair", 469));
            cmbTeleportMap.Items.Add(new ComboboxPair("Warsong Gulch", 489));
            cmbTeleportMap.Items.Add(new ComboboxPair("Ruins of Ahn\'Qiraj", 509));
            cmbTeleportMap.Items.Add(new ComboboxPair("Arathi Basin", 529));
            cmbTeleportMap.Items.Add(new ComboboxPair("Ahn\'Qiraj Temple", 531));
            cmbTeleportMap.Items.Add(new ComboboxPair("Naxxramas", 533));

            // Add options to Move To Coordinates Type combo box.
            cmbMoveToType.Items.Add(new ComboboxPair("Normal coordinates", 0));
            cmbMoveToType.Items.Add(new ComboboxPair("Relative to target", 1));
            cmbMoveToType.Items.Add(new ComboboxPair("Distance from target", 2));

            cmbTable.SelectedIndex = 0;
            //MessageBox.Show((cmbCommandId.SelectedItem as ComboboxPair).Value.ToString());
            dontUpdate = false;
        }
        
        private void LoadConfig()
        {
            if (!System.IO.File.Exists(@"config.ini"))
            {
                MessageBox.Show("Your config file seems to have vanished into the nether! But worry not, i shall use my ultra-safe mind reading device to guess your database connection details. Surely nothing can go wrong, gnomish inventions are renowned for their safety after all!", "No config found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"config.ini");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("User="))
                    mysqlUser = line.Replace("User=", "");
                else if (line.Contains("Pass="))
                    mysqlPass = line.Replace("Pass=", "");
                else if (line.Contains("Host="))
                    mysqlHost = line.Replace("Host=", "");
                else if (line.Contains("DB="))
                    mysqlDB = line.Replace("DB=", "");
            }

            connString = "Server=" + mysqlHost + ";Database=" + mysqlDB + ";Uid=" + mysqlUser + ";Pwd=" + mysqlPass + ";";
        }

        private void LoadBroadcastTexts()
        {
            BroadcastTextsList.Clear();

            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT ID, MaleText, FemaleText, Type, Language FROM broadcast_text ORDER BY ID";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string txt = reader.GetString(1); // Get MaleText

                    if (string.IsNullOrEmpty(txt)) // If MaleText is empty get FemaleText
                        txt = reader.GetString(2);

                    // Add the new broadcast text entry to the list.
                    BroadcastTextsList.Add(new BroadcastText(reader.GetUInt32(0), txt, reader.GetUInt32(3), reader.GetUInt32(4)));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dontUpdate = true;
            lstActions.Items.Clear();
            ResetAndDisableGeneralForm();
            ResetAndHideCommandSpecificForms();

            // If no script id just clear data.
            if ((txtScriptId.Text.Length == 0) || (!UInt32.TryParse(txtScriptId.Text, out currentScriptId)))
            {
                lblId.Text = "No script loaded.";
                currentScriptId = 0;
                return;
            }

            lblId.Text = "Editing script " + txtScriptId.Text + " from " + cmbTable.Text + ".";

            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT id, delay, command, datalong, datalong2, datalong3, datalong4, buddy_id, buddy_radius, buddy_type, data_flags, dataint, dataint2, dataint3, dataint4, x, y, z, o, comments FROM " + cmbTable.SelectedItem.ToString() + " WHERE id=" + txtScriptId.Text + " ORDER BY delay";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem();

                    ScriptAction action = new ScriptAction(reader.GetUInt32(0), reader.GetUInt32(1), reader.GetUInt32(2), reader.GetUInt32(3), reader.GetUInt32(4), reader.GetUInt32(5), reader.GetUInt32(6), reader.GetUInt32(7), reader.GetUInt32(8), reader.GetUInt32(9), reader.GetUInt32(10), reader.GetInt32(11), reader.GetInt32(12), reader.GetInt32(13), reader.GetInt32(14), reader.GetFloat(15), reader.GetFloat(16), reader.GetFloat(17), reader.GetFloat(18), reader[19].ToString());
                    
                    // We show only delay, command id and comment in the listview.
                    lvi.Text = action.Delay.ToString();
                    lvi.SubItems.Add(action.Command.ToString());
                    lvi.SubItems.Add(action.Comments);

                    // Save the ScriptAction to the Tag.
                    lvi.Tag = action;

                    // Add it to the listview.
                    lstActions.Items.Add(lvi);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
            dontUpdate = false;
        }

        private void btnActionRemove_Click(object sender, EventArgs e)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item.
                ListViewItem deleteItem = lstActions.SelectedItems[0];

                // Delete the item from the listview.
                lstActions.Items.Remove(deleteItem);
            }
        }

        private void ResetAndDisableGeneralForm()
        {
            dontUpdate = true;

            // Text Boxes.
            txtCommandDelay.Text = "";
            txtCommandComment.Text = "";
            txtBuddyId.Text = "";
            txtBuddyRadius.Text = "";
            
            // Combo Boxes.
            cmbBuddyType.SelectedIndex = 0;
            cmbBuddyType.Text = "";
            cmbCommandId.SelectedIndex = 0;
            cmbCommandId.Text = "";

            // Check Boxes.
            chkAbortScript.Checked = false;
            chkSwapFinal.Checked = false;
            chkSwapInitial.Checked = false;
            chkTargetSelf.Checked = false;

            // Make the form disabled.
            grpGeneral.Enabled = false;

            dontUpdate = false;
        }
        private void ResetAndHideCommandSpecificForms()
        {
            dontUpdate = true;

            // Talk Command (0)
            frmCommandTalk.Visible = false;
            btnTalkText1.Text = "-NONE-";
            btnTalkText2.Text = "-NONE-";
            btnTalkText3.Text = "-NONE-";
            btnTalkText4.Text = "-NONE-";
            txtTalkText1.Text = "";
            txtTalkText2.Text = "";
            txtTalkText3.Text = "";
            txtTalkText4.Text = "";
            cmbTalkChatType.SelectedIndex = 0;

            // Emote Command (1)
            frmCommandEmote.Visible = false;
            cmbEmoteId.SelectedIndex = 0;

            // Field Set Command (2), Flag Set Command (4), Flag Remove Command (5)
            cmbFieldSetFields.SelectedIndex = 0;
            txtFieldSetValue.Text = "";
            frmCommandFieldSet.Visible = false;

            // Move To Command (3)
            cmbMoveToType.SelectedIndex = 0;
            txtMoveToTime.Text = "";
            txtMoveToX.Text = "";
            txtMoveToY.Text = "";
            txtMoveToY.Enabled = true;
            txtMoveToZ.Text = "";
            txtMoveToZ.Enabled = true;
            txtMoveToO.Text = "";
            txtMoveToO.Enabled = true;
            grpMoveToOptions.Enabled = true;
            chkMoveOptions1.Checked = false;
            chkMoveOptions2.Checked = false;
            chkMoveOptions4.Checked = false;
            chkMoveOptions8.Checked = false;
            chkMoveOptions16.Checked = false;
            chkMoveOptions32.Checked = false;
            chkMoveOptions64.Checked = false;
            chkMoveOptions128.Checked = false;
            chkMoveOptions256.Checked = false;
            chkMoveToFlagsForce.Checked = false;
            frmCommandMoveTo.Visible = false;

            // Teleport Command (6)
            txtTeleportX.Text = "";
            txtTeleportY.Text = "";
            txtTeleportZ.Text = "";
            txtTeleportO.Text = "";
            cmbTeleportMap.SelectedIndex = 0;
            frmCommandTeleport.Visible = false;

            dontUpdate = false;
        }
        private void ShowCommandSpecificForm(ScriptAction selectedAction)
        {
            dontUpdate = true;
            switch (selectedAction.Command)
            {
                case 0: // Talk
                {
                    cmbTalkChatType.SelectedIndex = (int)selectedAction.Datalong;
                    uint textId1 = (uint)selectedAction.Dataint;
                    uint textId2 = (uint)selectedAction.Dataint2;
                    uint textId3 = (uint)selectedAction.Dataint3;
                    uint textId4 = (uint)selectedAction.Dataint4;
                    if (textId1 > 0)
                    {
                        txtTalkText1.Text = FindTextWithId(textId1);
                        btnTalkText1.Text = textId1.ToString();
                    }
                    else
                    {
                        txtTalkText1.Text = "";
                        btnTalkText1.Text = "-NONE-";
                    }
                    if (textId2 > 0)
                    {
                        txtTalkText2.Text = FindTextWithId(textId2);
                        btnTalkText2.Text = textId2.ToString();
                    }
                    else
                    {
                        txtTalkText2.Text = "";
                        btnTalkText2.Text = "-NONE-";
                    }
                    if (textId3 > 0)
                    {
                        txtTalkText3.Text = FindTextWithId(textId3);
                        btnTalkText3.Text = textId3.ToString();
                    }
                    else
                    {
                        txtTalkText3.Text = "";
                        btnTalkText3.Text = "-NONE-";
                    }
                    if (textId4 > 0)
                    {
                        txtTalkText4.Text = FindTextWithId(textId4);
                        btnTalkText4.Text = textId4.ToString();
                    }
                    else
                    {
                        txtTalkText4.Text = "";
                        btnTalkText4.Text = "-NONE-";
                    }
                    frmCommandTalk.Visible = true;
                    break;
                }
                case 1: // Emote
                {
                    cmbEmoteId.SelectedIndex = FindIndexOfEmote(selectedAction.Datalong);
                    frmCommandEmote.Visible = true;
                    break;
                }
                case 2: // Field Set
                case 4: // Flag Set
                case 5: // Flag Remove
                {
                    txtFieldSetValue.Text = selectedAction.Datalong2.ToString();
                    
                    switch (selectedAction.Command)
                    {
                        case 2:
                        {
                            lblFieldSetTooltip.Text = "Sets the chosen update field to the value specified. Can be used on any object, but the fields are different based on the type. Only use if you know what you are doing.";
                            cmbFieldSetFields.DataSource = UpdateFieldsList;
                            cmbFieldSetFields.SelectedIndex = FindIndexOfUpdateField(selectedAction.Datalong);
                            break;
                        }
                        case 4:
                        {
                            lblFieldSetTooltip.Text = "Toggles on the specified flags on the chosen field. Can be used on any object, but the fields are different based on the type.";
                            cmbFieldSetFields.DataSource = FlagFieldsList;
                            cmbFieldSetFields.SelectedIndex = FindIndexOfFlagsField(selectedAction.Datalong);
                            break;
                        }
                        case 5:
                        {
                            lblFieldSetTooltip.Text = "Toggles off the specified flags on the chosen field. Can be used on any object, but the fields are different based on the type.";
                            cmbFieldSetFields.DataSource = FlagFieldsList;
                            cmbFieldSetFields.SelectedIndex = FindIndexOfFlagsField(selectedAction.Datalong);
                            break;
                        }
                    }
                    frmCommandFieldSet.Visible = true;
                    break;
                }
                case 3: // Move To
                {
                    cmbMoveToType.SelectedIndex = (int)selectedAction.Datalong;
                    txtMoveToTime.Text = selectedAction.Datalong2.ToString();

                    // coordinates
                    txtMoveToX.Text = selectedAction.X.ToString();
                    txtMoveToY.Text = selectedAction.Y.ToString();
                    txtMoveToZ.Text = selectedAction.Z.ToString();
                    txtMoveToO.Text = selectedAction.O.ToString();

                    // movement options
                    if ((selectedAction.Datalong3 & 1) != 0)
                        chkMoveOptions1.Checked = true;
                    if ((selectedAction.Datalong3 & 2) != 0)
                        chkMoveOptions2.Checked = true;
                    if ((selectedAction.Datalong3 & 4) != 0)
                        chkMoveOptions4.Checked = true;
                    if ((selectedAction.Datalong3 & 8) != 0)
                        chkMoveOptions8.Checked = true;
                    if ((selectedAction.Datalong3 & 16) != 0)
                        chkMoveOptions16.Checked = true;
                    if ((selectedAction.Datalong3 & 32) != 0)
                        chkMoveOptions32.Checked = true;
                    if ((selectedAction.Datalong3 & 64) != 0)
                        chkMoveOptions64.Checked = true;
                    if ((selectedAction.Datalong3 & 128) != 0)
                        chkMoveOptions128.Checked = true;
                    if ((selectedAction.Datalong3 & 256) != 0)
                        chkMoveOptions256.Checked = true;

                    // move to flags
                    if ((selectedAction.Datalong4 & 1) != 0)
                        chkMoveToFlagsForce.Checked = true;

                    // some fields unavailable based on coordinates_type
                    switch (selectedAction.Datalong)
                    {
                        case 0: // SO_MOVETO_COORDINATES_NORMAL
                        case 1: // SO_MOVETO_COORDINATES_RELATIVE_TO_TARGET
                        {
                            lblMoveToX.Text = "X coordinate:";
                            txtMoveToY.Enabled = true;
                            txtMoveToZ.Enabled = true;
                            break;
                        }
                        case 2: // SO_MOVETO_COORDINATES_DISTANCE_FROM_TARGET
                        {
                            lblMoveToX.Text = "Distance:";
                            txtMoveToY.Enabled = false;
                            txtMoveToZ.Enabled = false;
                            break;
                        }
                    }

                    // movement options and orientation unavailable with speed
                    if (selectedAction.Datalong2 > 0)
                    {
                        txtMoveToO.Enabled = false;
                        grpMoveToOptions.Enabled = false;
                    }
                    else
                    {
                        txtMoveToO.Enabled = true;
                        grpMoveToOptions.Enabled = true;
                    }

                    frmCommandMoveTo.Visible = true;
                    break;
                }
                case 6: // Teleport
                {
                    txtTeleportX.Text = selectedAction.X.ToString();
                    txtTeleportY.Text = selectedAction.Y.ToString();
                    txtTeleportZ.Text = selectedAction.Z.ToString();
                    txtTeleportO.Text = selectedAction.O.ToString();
                    cmbTeleportMap.SelectedIndex = FindIndexOfMap(selectedAction.Datalong);
                    frmCommandTeleport.Visible = true;
                    break;
                }
            }
            dontUpdate = false;
        }
        private void lstActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstActions.SelectedItems.Count == 0)
            {
                ResetAndDisableGeneralForm();
                ResetAndHideCommandSpecificForms();
                return;
            }

            dontUpdate = true;
            ListViewItem selectedItem = lstActions.SelectedItems[0];
            ScriptAction selectedAction = (ScriptAction)selectedItem.Tag;
            
            txtCommandDelay.Text = selectedAction.Delay.ToString();
            txtCommandComment.Text = selectedAction.Comments;
            txtBuddyId.Text = selectedAction.BuddyId.ToString();
            txtBuddyRadius.Text = selectedAction.BuddyRadius.ToString();
            cmbBuddyType.SelectedIndex = (int)selectedAction.BuddyType;
            cmbCommandId.SelectedIndex = (int)selectedAction.Command;

            if ((selectedAction.DataFlags & 1) != 0)
                chkSwapInitial.Checked = true;
            if ((selectedAction.DataFlags & 2) != 0)
                chkSwapFinal.Checked = true;
            if ((selectedAction.DataFlags & 4) != 0)
                chkTargetSelf.Checked = true;
            if ((selectedAction.DataFlags & 8) != 0)
                chkAbortScript.Checked = true;

            grpGeneral.Enabled = true;

            ShowCommandSpecificForm(selectedAction);

            dontUpdate = false;
        }

        public int FindIndexOfMap(uint id)
        {
            for (int i = 0; i < cmbTeleportMap.Items.Count; i++)
            {
                if (id == (uint)(cmbTeleportMap.Items[i] as ComboboxPair).Value)
                    return i;
            }
            return 0;
        }
        public int FindIndexOfUpdateField(uint id)
        {
            for (int i = 0; i < UpdateFieldsList.Count; i++)
            {
                if (id == (uint)(UpdateFieldsList[i] as ComboboxPair).Value)
                    return i;
            }
            return 0;
        }

        public int FindIndexOfFlagsField(uint id)
        {
            for (int i = 0; i < FlagFieldsList.Count; i++)
            {
                if (id == (uint)(FlagFieldsList[i] as ComboboxPair).Value)
                    return i;
            }
            return 0;
        }
        public int FindIndexOfEmote(uint id)
        {
            for (int i = 0; i < cmbEmoteId.Items.Count; i++)
            {
                if (id == (uint)(cmbEmoteId.Items[i] as ComboboxPair).Value)
                    return i;
            }
            return 0;
        }
        public string FindTextWithId(uint id)
        {
            foreach (BroadcastText bc in BroadcastTextsList)
            {
                if (bc.ID == id)
                    return bc.Text;
            }

            return "";
        }

        private void btnTalkText1_Click(object sender, EventArgs e)
        {
            FormTextSearcher frm = new FormTextSearcher();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uint textId = frm.ReturnValue;
                if (textId > 0)
                    btnTalkText1.Text = textId.ToString();
                else
                {
                    btnTalkText1.Text = "-NONE-";
                    txtTalkText1.Text = "";
                }

                if (lstActions.SelectedItems.Count > 0)
                {
                    // Get the selected item in the listview.
                    ListViewItem currentItem = lstActions.SelectedItems[0];

                    // Get the associated ScriptAction.
                    ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                    // TextId1 = dataint;
                    currentAction.Dataint = (int)textId;
                    txtTalkText1.Text = FindTextWithId(textId);
                }

            }

        }

        private void btnTalkText2_Click(object sender, EventArgs e)
        {
            FormTextSearcher frm = new FormTextSearcher();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uint textId = frm.ReturnValue;
                if (textId > 0)
                    btnTalkText2.Text = textId.ToString();
                else
                {
                    btnTalkText2.Text = "-NONE-";
                    txtTalkText2.Text = "";
                }

                if (lstActions.SelectedItems.Count > 0)
                {
                    // Get the selected item in the listview.
                    ListViewItem currentItem = lstActions.SelectedItems[0];

                    // Get the associated ScriptAction.
                    ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                    // TextId2 = dataint2;
                    currentAction.Dataint2 = (int)textId;
                    txtTalkText2.Text = FindTextWithId(textId);
                }

            }
        }

        private void btnTalkText3_Click(object sender, EventArgs e)
        {
            FormTextSearcher frm = new FormTextSearcher();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uint textId = frm.ReturnValue;
                if (textId > 0)
                    btnTalkText3.Text = textId.ToString();
                else
                {
                    btnTalkText3.Text = "-NONE-";
                    txtTalkText3.Text = "";
                }

                if (lstActions.SelectedItems.Count > 0)
                {
                    // Get the selected item in the listview.
                    ListViewItem currentItem = lstActions.SelectedItems[0];

                    // Get the associated ScriptAction.
                    ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                    // TextId3 = dataint3;
                    currentAction.Dataint3 = (int)textId;
                    txtTalkText3.Text = FindTextWithId(textId);
                }

            }
        }

        private void btnTalkText4_Click(object sender, EventArgs e)
        {
            FormTextSearcher frm = new FormTextSearcher();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uint textId = frm.ReturnValue;
                if (textId > 0)
                    btnTalkText4.Text = textId.ToString();
                else
                {
                    btnTalkText4.Text = "-NONE-";
                    txtTalkText4.Text = "";
                }

                if (lstActions.SelectedItems.Count > 0)
                {
                    // Get the selected item in the listview.
                    ListViewItem currentItem = lstActions.SelectedItems[0];

                    // Get the associated ScriptAction.
                    ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                    // TextId4 = dataint4;
                    currentAction.Dataint4 = (int)textId;
                    txtTalkText4.Text = FindTextWithId(textId);
                }

            }
        }

        private void cmbTalkChatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // ChatType = datalong
                currentAction.Datalong = (uint)cmbTalkChatType.SelectedIndex;
            }
        }

        private void txtCommandComment_Leave(object sender, EventArgs e)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Updating comment.
                currentAction.Comments = txtCommandComment.Text;

                // Update comment in listview.
                currentItem.SubItems[2].Text = txtCommandComment.Text;
            }
        }

        private void cmbBuddyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Updating buddy type.
                currentAction.BuddyType = (uint)cmbBuddyType.SelectedIndex;
            }
        }

        private void cmbCommandId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Updating command type.
                currentAction.Command = (uint)cmbCommandId.SelectedIndex;
                currentAction.Datalong = 0;
                currentAction.Datalong2 = 0;
                currentAction.Datalong3 = 0;
                currentAction.Datalong4 = 0;
                currentAction.Dataint = 0;
                currentAction.Dataint2 = 0;
                currentAction.Dataint3 = 0;
                currentAction.Dataint4 = 0;
                currentAction.X = 0;
                currentAction.Y = 0;
                currentAction.Z = 0;
                currentAction.O = 0;

                // Show the appropriate command specific form.
                ResetAndHideCommandSpecificForms();
                ShowCommandSpecificForm(currentAction);

                // Update command id in listview.
                currentItem.SubItems[1].Text = cmbCommandId.SelectedIndex.ToString();
            }
        }

        private void txtCommandDelay_Leave(object sender, EventArgs e)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                uint delay;
                if (!UInt32.TryParse(txtCommandDelay.Text, out delay))
                    txtCommandDelay.Text = "0";

                // Updating delay.
                currentAction.Delay = delay;

                // Update delay in listview.
                currentItem.SubItems[0].Text = txtCommandDelay.Text;
                lstActions.Sort();
            }
        }

        private void txtBuddyId_Leave(object sender, EventArgs e)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                uint buddyId;
                UInt32.TryParse(txtBuddyId.Text, out buddyId);

                // Updating buddy id.
                currentAction.BuddyId = buddyId;
            }
        }

        private void txtBuddyRadius_Leave(object sender, EventArgs e)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                uint buddyRadius;
                UInt32.TryParse(txtBuddyRadius.Text, out buddyRadius);

                // Updating buddy search radius.
                currentAction.BuddyRadius = buddyRadius;
            }
        }

        private void chkSwapInitial_CheckedChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Updating data flags.
                if (chkSwapInitial.Checked)
                    currentAction.DataFlags += 1;
                else
                    currentAction.DataFlags -= 1;
            }
        }

        private void cmbEmoteId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Updating emote id.
                currentAction.Datalong = (uint)(cmbEmoteId.SelectedItem as ComboboxPair).Value;
            }
        }

        private void btnActionNew_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();

            ScriptAction action = new ScriptAction();

            // We show only delay, command id and comment in the listview.
            lvi.Text = action.Delay.ToString();
            lvi.SubItems.Add(action.Command.ToString());
            lvi.SubItems.Add(action.Comments);

            // Save the ScriptAction to the Tag.
            lvi.Tag = action;

            // Add it to the listview.
            lstActions.Items.Add(lvi);
        }

        private void chkSwapFinal_CheckedChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Updating data flags.
                if (chkSwapFinal.Checked)
                    currentAction.DataFlags += 2;
                else
                    currentAction.DataFlags -= 2;
            }
        }

        private void chkTargetSelf_CheckedChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Updating data flags.
                if (chkTargetSelf.Checked)
                    currentAction.DataFlags += 4;
                else
                    currentAction.DataFlags -= 4;
            }
        }

        private void chkAbortScript_CheckedChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Updating data flags.
                if (chkAbortScript.Checked)
                    currentAction.DataFlags += 8;
                else
                    currentAction.DataFlags -= 8;
            }
        }

        private void cmbFieldSetFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Updating field id.
                currentAction.Datalong = (uint)(cmbFieldSetFields.SelectedItem as ComboboxPair).Value;
            }
        }

        private void txtFieldSetValue_Leave(object sender, EventArgs e)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                uint fieldValue;
                UInt32.TryParse(txtFieldSetValue.Text, out fieldValue);

                // Updating field value.
                currentAction.Datalong2 = fieldValue;
            }
        }

        private void SetCoordinateX(TextBox ctrl)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                float xCoordinate;
                float.TryParse(ctrl.Text, out xCoordinate);

                // Updating X coordinate.
                currentAction.X = xCoordinate;
            }
        }
        private void txtMoveToX_Leave(object sender, EventArgs e)
        {
            SetCoordinateX(txtMoveToX);
        }

        private void SetCoordinateY(TextBox ctrl)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                float yCoordinate;
                float.TryParse(ctrl.Text, out yCoordinate);

                // Updating Y coordinate.
                currentAction.Y = yCoordinate;
            }
        }

        private void txtMoveToY_Leave(object sender, EventArgs e)
        {
            SetCoordinateY(txtMoveToY);
        }

        private void SetCoordinateZ(TextBox ctrl)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                float zCoordinate;
                float.TryParse(ctrl.Text, out zCoordinate);

                // Updating Z coordinate.
                currentAction.Z = zCoordinate;
            }
        }

        private void txtMoveToZ_Leave(object sender, EventArgs e)
        {
            SetCoordinateZ(txtMoveToZ);
        }

        private void SetCoordinateO(TextBox ctrl)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                float oCoordinate;
                float.TryParse(ctrl.Text, out oCoordinate);

                // Updating orientation.
                currentAction.O = oCoordinate;
            }
        }

        private void txtMoveToO_Leave(object sender, EventArgs e)
        {
            SetCoordinateO(txtMoveToO);
        }

        private void chkMoveToFlagsForce_CheckedChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // datalong4 = eMoveToFlags
                if (chkMoveToFlagsForce.Checked)
                    currentAction.Datalong4 += 1;
                else
                    currentAction.Datalong4 -= 1;
            }
        }

        // Generic function for updating flags in datalong based on checkbox.
        private void SetDatalong3FlagsFromCheckbox(CheckBox ctrl, uint value)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                if (ctrl.Checked)
                    currentAction.Datalong3 += value;
                else
                    currentAction.Datalong3 -= value;
            }
        }
        private void chkMoveOptions1_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong3FlagsFromCheckbox(chkMoveOptions1, 1);
        }

        private void chkMoveOptions2_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong3FlagsFromCheckbox(chkMoveOptions2, 2);
        }

        private void chkMoveOptions4_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong3FlagsFromCheckbox(chkMoveOptions4, 4);
        }

        private void chkMoveOptions8_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong3FlagsFromCheckbox(chkMoveOptions8, 8);
        }

        private void chkMoveOptions16_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong3FlagsFromCheckbox(chkMoveOptions16, 16);
        }

        private void chkMoveOptions32_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong3FlagsFromCheckbox(chkMoveOptions32, 32);
        }

        private void chkMoveOptions64_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong3FlagsFromCheckbox(chkMoveOptions64, 64);
        }

        private void chkMoveOptions128_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong3FlagsFromCheckbox(chkMoveOptions128, 128);
        }

        private void chkMoveOptions256_CheckedChanged(object sender, EventArgs e)
        {
            SetDatalong3FlagsFromCheckbox(chkMoveOptions256, 256);
        }

        private void cmbMoveToType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                uint coordinatesType = (uint)cmbMoveToType.SelectedIndex;

                // Coordiantes type = datalong.
                currentAction.Datalong = coordinatesType;

                switch (coordinatesType)
                {
                    case 0: // SO_MOVETO_COORDINATES_NORMAL
                    case 1: // SO_MOVETO_COORDINATES_RELATIVE_TO_TARGET
                        {
                            lblMoveToX.Text = "X coordinate:";
                            txtMoveToY.Enabled = true;
                            txtMoveToZ.Enabled = true;
                            break;
                        }
                    case 2: // SO_MOVETO_COORDINATES_DISTANCE_FROM_TARGET
                        {
                            lblMoveToX.Text = "Distance:";
                            txtMoveToY.Enabled = false;
                            txtMoveToY.Text = "";
                            currentAction.Y = 0;
                            txtMoveToZ.Enabled = false;
                            txtMoveToZ.Text = "";
                            currentAction.Z = 0;
                            break;
                        }
                }
            }
        }

        private void txtMoveToTime_Leave(object sender, EventArgs e)
        {
            if (lstActions.SelectedItems.Count > 0)
            {
                dontUpdate = true;

                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                uint speed;
                if (!UInt32.TryParse(txtMoveToTime.Text, out speed))
                    txtMoveToTime.Text = "";

                // Updating orientation.
                currentAction.Datalong2 = speed;

                // Orientation and movement options cannot be used with speed.
                if (speed > 0)
                {
                    txtMoveToO.Enabled = false;
                    txtMoveToO.Text = "";
                    currentAction.O = 0;

                    grpMoveToOptions.Enabled = false;
                    currentAction.Datalong3 = 0;
                    chkMoveOptions1.Checked = false;
                    chkMoveOptions2.Checked = false;
                    chkMoveOptions4.Checked = false;
                    chkMoveOptions8.Checked = false;
                    chkMoveOptions16.Checked = false;
                    chkMoveOptions32.Checked = false;
                    chkMoveOptions64.Checked = false;
                    chkMoveOptions128.Checked = false;
                    chkMoveOptions256.Checked = false;
                }
                else
                {
                    txtMoveToO.Enabled = true;
                    grpMoveToOptions.Enabled = true;
                }

                dontUpdate = false;
            }
        }

        private void cmbTeleportMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dontUpdate)
                return;

            if (lstActions.SelectedItems.Count > 0)
            {
                // Get the selected item in the listview.
                ListViewItem currentItem = lstActions.SelectedItems[0];

                // Get the associated ScriptAction.
                ScriptAction currentAction = (ScriptAction)currentItem.Tag;

                // Updating field id.
                currentAction.Datalong = (uint)(cmbTeleportMap.SelectedItem as ComboboxPair).Value;
            }
        }

        private void txtTeleportX_Leave(object sender, EventArgs e)
        {
            SetCoordinateX(txtTeleportX);
        }

        private void txtTeleportY_Leave(object sender, EventArgs e)
        {
            SetCoordinateY(txtTeleportY);
        }

        private void txtTeleportZ_Leave(object sender, EventArgs e)
        {
            SetCoordinateZ(txtTeleportZ);
        }

        private void txtTeleportO_Leave(object sender, EventArgs e)
        {
            SetCoordinateO(txtTeleportO);
        }
    }

    // Sorts items in the script actions listbox by delay.
    class ActionSorter : System.Collections.IComparer
    {
        public int Column = 0;
        public System.Windows.Forms.SortOrder Order = SortOrder.Ascending;
        public int Compare(object x, object y) // IComparer Member
        {
            if (!(x is ListViewItem))
                return (0);
            if (!(y is ListViewItem))
                return (0);

            ListViewItem l1 = (ListViewItem)x;
            ListViewItem l2 = (ListViewItem)y;

            int value1;
            int value2;

            Int32.TryParse(l1.SubItems[Column].Text, out value1);
            Int32.TryParse(l2.SubItems[Column].Text, out value2);

            if (Order == SortOrder.Ascending)
            {
                return value1.CompareTo(value2);
            }
            else
            {
                return value2.CompareTo(value1);
            }
        }
    }
}
