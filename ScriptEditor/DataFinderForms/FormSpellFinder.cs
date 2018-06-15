using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormSpellFinder : ScriptEditor.FormDataFinder
    {
        public string[] effects;
        public FormSpellFinder()
        {
            InitializeComponent();

            // Effect Names
            effects = new string[130];
            effects[0] = "NONE";
            effects[1] = "INSTAKILL";
            effects[2] = "SCHOOL_DAMAGE";
            effects[3] = "DUMMY";
            effects[4] = "PORTAL_TELEPORT";
            effects[5] = "TELEPORT_UNITS";
            effects[6] = "APPLY_AURA";
            effects[7] = "ENVIRONMENTAL_DAMAGE";
            effects[8] = "POWER_DRAIN";
            effects[9] = "HEALTH_LEECH";
            effects[10] = "HEAL";
            effects[11] = "BIND";
            effects[12] = "PORTAL";
            effects[13] = "RITUAL_BASE";
            effects[14] = "RITUAL_SPECIALIZE";
            effects[15] = "RITUAL_ACTIVATE_PORTAL";
            effects[16] = "QUEST_COMPLETE";
            effects[17] = "WEAPON_DAMAGE_NOSCHOOL";
            effects[18] = "RESURRECT";
            effects[19] = "ADD_EXTRA_ATTACKS";
            effects[20] = "DODGE";
            effects[21] = "EVADE";
            effects[22] = "PARRY";
            effects[23] = "BLOCK";
            effects[24] = "CREATE_ITEM";
            effects[25] = "WEAPON";
            effects[26] = "DEFENSE";
            effects[27] = "PERSISTENT_AREA_AURA";
            effects[28] = "SUMMON";
            effects[29] = "LEAP";
            effects[30] = "ENERGIZE";
            effects[31] = "WEAPON_PERCENT_DAMAGE";
            effects[32] = "TRIGGER_MISSILE";
            effects[33] = "OPEN_LOCK";
            effects[34] = "SUMMON_CHANGE_ITEM";
            effects[35] = "APPLY_AREA_AURA_PARTY";
            effects[36] = "LEARN_SPELL";
            effects[37] = "SPELL_DEFENSE";
            effects[38] = "DISPEL";
            effects[39] = "LANGUAGE";
            effects[40] = "DUAL_WIELD";
            effects[41] = "SUMMON_WILD";
            effects[42] = "SUMMON_GUARDIAN";
            effects[43] = "TELEPORT_UNITS_FACE_CASTER";
            effects[44] = "SKILL_STEP";
            effects[45] = "ADD_HONOR";
            effects[46] = "SPAWN";
            effects[47] = "TRADE_SKILL";
            effects[48] = "STEALTH";
            effects[49] = "DETECT";
            effects[50] = "TRANS_DOOR";
            effects[51] = "FORCE_CRITICAL_HIT";
            effects[52] = "GUARANTEE_HIT";
            effects[53] = "ENCHANT_ITEM";
            effects[54] = "ENCHANT_ITEM_TEMPORARY";
            effects[55] = "TAMECREATURE";
            effects[56] = "SUMMON_PET";
            effects[57] = "LEARN_PET_SPELL";
            effects[58] = "WEAPON_DAMAGE";
            effects[59] = "OPEN_LOCK_ITEM";
            effects[60] = "PROFICIENCY";
            effects[61] = "SEND_EVENT";
            effects[62] = "POWER_BURN";
            effects[63] = "THREAT";
            effects[64] = "TRIGGER_SPELL";
            effects[65] = "HEALTH_FUNNEL";
            effects[66] = "POWER_FUNNEL";
            effects[67] = "HEAL_MAX_HEALTH";
            effects[68] = "INTERRUPT_CAST";
            effects[69] = "DISTRACT";
            effects[70] = "PULL";
            effects[71] = "PICKPOCKET";
            effects[72] = "ADD_FARSIGHT";
            effects[73] = "SUMMON_POSSESSED";
            effects[74] = "SUMMON_TOTEM";
            effects[75] = "HEAL_MECHANICAL";
            effects[76] = "SUMMON_OBJECT_WILD";
            effects[77] = "SCRIPT_EFFECT";
            effects[78] = "ATTACK";
            effects[79] = "SANCTUARY";
            effects[80] = "ADD_COMBO_POINTS";
            effects[81] = "CREATE_HOUSE";
            effects[82] = "BIND_SIGHT";
            effects[83] = "DUEL";
            effects[84] = "STUCK";
            effects[85] = "SUMMON_PLAYER";
            effects[86] = "ACTIVATE_OBJECT";
            effects[87] = "SUMMON_TOTEM_SLOT1";
            effects[88] = "SUMMON_TOTEM_SLOT2";
            effects[89] = "SUMMON_TOTEM_SLOT3";
            effects[90] = "SUMMON_TOTEM_SLOT4";
            effects[91] = "THREAT_ALL";
            effects[92] = "ENCHANT_HELD_ITEM";
            effects[93] = "SUMMON_PHANTASM";
            effects[94] = "SELF_RESURRECT";
            effects[95] = "SKINNING";
            effects[96] = "CHARGE";
            effects[97] = "SUMMON_CRITTER";
            effects[98] = "KNOCK_BACK";
            effects[99] = "DISENCHANT";
            effects[100] = "INEBRIATE";
            effects[101] = "FEED_PET";
            effects[102] = "DISMISS_PET";
            effects[103] = "REPUTATION";
            effects[104] = "SUMMON_OBJECT_SLOT1";
            effects[105] = "SUMMON_OBJECT_SLOT2";
            effects[106] = "SUMMON_OBJECT_SLOT3";
            effects[107] = "SUMMON_OBJECT_SLOT4";
            effects[108] = "DISPEL_MECHANIC";
            effects[109] = "SUMMON_DEAD_PET";
            effects[110] = "DESTROY_ALL_TOTEMS";
            effects[111] = "DURABILITY_DAMAGE";
            effects[112] = "SUMMON_DEMON";
            effects[113] = "RESURRECT_NEW";
            effects[114] = "ATTACK_ME";
            effects[115] = "DURABILITY_DAMAGE_PCT";
            effects[116] = "SKIN_PLAYER_CORPSE";
            effects[117] = "SPIRIT_HEAL";
            effects[118] = "SKILL";
            effects[119] = "APPLY_AREA_AURA_PET";
            effects[120] = "TELEPORT_GRAVEYARD";
            effects[121] = "NORMALIZED_WEAPON_DMG";
            effects[122] = "SILITHYST_CAP_REWARD";
            effects[123] = "SEND_TAXI";
            effects[124] = "PLAYER_PULL";
            effects[125] = "MODIFY_THREAT_PERCENT";
            effects[126] = "UNUSED_126";
            effects[127] = "UNUSED_127";
            effects[128] = "APPLY_AREA_AURA_FRIEND";
            effects[129] = "APPLY_AREA_AURA_ENEMY";
        }
        protected override void AddAllData()
        {
            foreach (SpellInfo spell in GameData.SpellInfoList)
            {
                AddSpellToListView(spell);
            }
        }
        protected override void AddById(uint id)
        {
            foreach (SpellInfo spell in GameData.SpellInfoList)
            {
                if (spell.ID == id)
                    AddSpellToListView(spell);
            }
        }
        protected override void AddByIdRange(uint minId, uint maxId)
        {
            foreach (SpellInfo spell in GameData.SpellInfoList)
            {
                if ((spell.ID >= minId) && (spell.ID <= maxId))
                    AddSpellToListView(spell);
            }
        }
        protected override void AddByText(string searchText)
        {
            foreach (SpellInfo spell in GameData.SpellInfoList)
            {
                // If content is not numeric search for text.
                if (spell.Name.Contains(searchText) || spell.Description.Contains(searchText))
                    AddSpellToListView(spell);
            }
        }
        private void AddSpellToListView(SpellInfo spell)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = spell.ID.ToString();
            lvi.SubItems.Add(effects[spell.Effect1]);
            lvi.SubItems.Add(effects[spell.Effect2]);
            lvi.SubItems.Add(effects[spell.Effect3]);
            lvi.SubItems.Add(spell.Name);
            lvi.SubItems.Add(spell.Description);

            // Add this spell to the listview.
            lstData.Items.Add(lvi);
        }
        private void FormSpellFinder_ResizeEnd(object sender, EventArgs e)
        {
            lstData.Columns[5].Width = lstData.ClientSize.Width - lstData.Columns[0].Width - lstData.Columns[1].Width - lstData.Columns[2].Width - lstData.Columns[3].Width - lstData.Columns[4].Width;
        }
    }
}
