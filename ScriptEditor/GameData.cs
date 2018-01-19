using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace ScriptEditor
{
    public static class GameData
    {
        public static readonly List<BroadcastText> BroadcastTextsList = new List<BroadcastText>();
        public static readonly List<QuestInfo> QuestInfoList = new List<QuestInfo>();
        public static readonly List<CreatureInfo> CreatureInfoList = new List<CreatureInfo>();
        public static readonly List<SpellInfo> SpellInfoList = new List<SpellInfo>();
        public static readonly List<ItemInfo> ItemInfoList = new List<ItemInfo>();
        public static readonly List<ComboboxPair> UpdateFieldsList = new List<ComboboxPair>();
        public static readonly List<ComboboxPair> FlagFieldsList = new List<ComboboxPair>();
        public static readonly List<ComboboxPair> MapsList = new List<ComboboxPair>();
        public static readonly List<ComboboxPair> EmotesList = new List<ComboboxPair>();
        public static readonly List<ComboboxPair> CreatureRanksList = new List<ComboboxPair>();
        public static int FindIndexOfMap(uint id)
        {
            for (int i = 0; i < MapsList.Count; i++)
            {
                if (id == (uint)(MapsList[i] as ComboboxPair).Value)
                    return i;
            }
            return 0;
        }
        public static int FindIndexOfUpdateField(uint id)
        {
            for (int i = 0; i < UpdateFieldsList.Count; i++)
            {
                if (id == (uint)(UpdateFieldsList[i] as ComboboxPair).Value)
                    return i;
            }
            return 0;
        }

        public static int FindIndexOfFlagsField(uint id)
        {
            for (int i = 0; i < FlagFieldsList.Count; i++)
            {
                if (id == (uint)(FlagFieldsList[i] as ComboboxPair).Value)
                    return i;
            }
            return 0;
        }
        public static int FindIndexOfEmote(uint id)
        {
            for (int i = 0; i < EmotesList.Count; i++)
            {
                if (id == (uint)(EmotesList[i] as ComboboxPair).Value)
                    return i;
            }
            return 0;
        }
        public static string FindTextWithId(uint id)
        {
            foreach (BroadcastText bc in BroadcastTextsList)
            {
                if (bc.ID == id)
                    return bc.Text;
            }

            return "";
        }

        public static string FindQuestTitle(uint id)
        {
            foreach (QuestInfo quest in QuestInfoList)
            {
                if (quest.ID == id)
                    return quest.Title;
            }

            return "";
        }

        public static string FindCreatureName(uint id)
        {
            foreach (CreatureInfo creature in CreatureInfoList)
            {
                if (creature.ID == id)
                    return creature.Name;
            }

            return "";
        }
        public static string FindSpellName(uint id)
        {
            foreach (SpellInfo spell in SpellInfoList)
            {
                if (spell.ID == id)
                    return spell.Name;
            }

            return "";
        }
        public static string FindItemName(uint id)
        {
            foreach (ItemInfo item in ItemInfoList)
            {
                if (item.ID == id)
                    return item.Name;
            }

            return "";
        }
        public static void LoadBroadcastTexts(string connString)
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
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }
        public static void LoadQuests(string connString)
        {
            QuestInfoList.Clear();

            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT entry, MinLevel, QuestLevel, Title FROM quest_template t1 WHERE patch=(SELECT max(patch) FROM quest_template t2 WHERE t1.entry=t2.entry) ORDER BY entry";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add the new quest entry to the list.
                    QuestInfoList.Add(new QuestInfo(reader.GetUInt32(0), reader.GetUInt32(1), reader.GetUInt32(2), reader.GetString(3)));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }
        public static void LoadCreatures(string connString)
        {
            CreatureInfoList.Clear();

            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT entry, minlevel, maxlevel, rank, name FROM creature_template t1 WHERE patch=(SELECT max(patch) FROM creature_template t2 WHERE t1.entry=t2.entry) ORDER BY entry";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add the new creature entry to the list.
                    CreatureInfoList.Add(new CreatureInfo(reader.GetUInt32(0), reader.GetUInt32(1), reader.GetUInt32(2), reader.GetUInt32(3), reader.GetString(4)));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }
        public static void LoadSpells(string connString)
        {
            SpellInfoList.Clear();

            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT ID, effect1, effect2, effect3, name1, description1 FROM spell_template ORDER BY ID";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add the spell entry to the list.
                    SpellInfoList.Add(new SpellInfo(reader.GetUInt32(0), reader.GetUInt32(1), reader.GetUInt32(2), reader.GetUInt32(3), reader.GetString(4), reader.GetString(5)));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }
        public static void LoadItems(string connString)
        {
            ItemInfoList.Clear();

            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT entry, RequiredLevel, ItemLevel, name FROM item_template t1 WHERE patch=(SELECT max(patch) FROM item_template t2 WHERE t1.entry=t2.entry) ORDER BY entry";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add the new item entry to the list.
                    ItemInfoList.Add(new ItemInfo(reader.GetUInt32(0), reader.GetUInt32(1), reader.GetUInt32(2), reader.GetString(3)));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }
        static GameData()
        {
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

            // Add all maps to a list.
            MapsList.Add(new ComboboxPair("Eastern Kingdoms", 0));
            MapsList.Add(new ComboboxPair("Kalimdor", 1));
            MapsList.Add(new ComboboxPair("Testing", 13));
            MapsList.Add(new ComboboxPair("Scott Test", 25));
            MapsList.Add(new ComboboxPair("CashTest", 29));
            MapsList.Add(new ComboboxPair("Alterac Valley", 30));
            MapsList.Add(new ComboboxPair("Shadowfang Keep", 33));
            MapsList.Add(new ComboboxPair("Stormwind Stockade", 34));
            MapsList.Add(new ComboboxPair("Stormwind Prison", 35));
            MapsList.Add(new ComboboxPair("Deadmines", 36));
            MapsList.Add(new ComboboxPair("Azshara Crater", 37));
            MapsList.Add(new ComboboxPair("Collin\'s Test", 42));
            MapsList.Add(new ComboboxPair("Wailing Caverns", 43));
            MapsList.Add(new ComboboxPair("Monastery", 44));
            MapsList.Add(new ComboboxPair("Razorfen Kraul", 47));
            MapsList.Add(new ComboboxPair("Blackfathom Deeps", 48));
            MapsList.Add(new ComboboxPair("Uldaman", 70));
            MapsList.Add(new ComboboxPair("Gnomeregan", 90));
            MapsList.Add(new ComboboxPair("Sunken Temple", 109));
            MapsList.Add(new ComboboxPair("Razorfen Downs", 129));
            MapsList.Add(new ComboboxPair("Emerald Dream", 169));
            MapsList.Add(new ComboboxPair("Scarlet Monastery", 189));
            MapsList.Add(new ComboboxPair("Zul\'Farrak", 209));
            MapsList.Add(new ComboboxPair("Blackrock Spire", 229));
            MapsList.Add(new ComboboxPair("Blackrock Depths", 230));
            MapsList.Add(new ComboboxPair("Onyxia\'s Lair", 249));
            MapsList.Add(new ComboboxPair("Caverns of Time", 269));
            MapsList.Add(new ComboboxPair("Scholomance", 289));
            MapsList.Add(new ComboboxPair("Zul\'Gurub", 309));
            MapsList.Add(new ComboboxPair("Stratholme", 329));
            MapsList.Add(new ComboboxPair("Maraudon", 349));
            MapsList.Add(new ComboboxPair("Deeprun Tram", 369));
            MapsList.Add(new ComboboxPair("Ragefire Chasm", 389));
            MapsList.Add(new ComboboxPair("Molten Core", 409));
            MapsList.Add(new ComboboxPair("Dire Maul", 429));
            MapsList.Add(new ComboboxPair("Alliance PVP Barracks", 449));
            MapsList.Add(new ComboboxPair("Horde PVP Barracks", 450));
            MapsList.Add(new ComboboxPair("Development Land", 451));
            MapsList.Add(new ComboboxPair("Blackwing Lair", 469));
            MapsList.Add(new ComboboxPair("Warsong Gulch", 489));
            MapsList.Add(new ComboboxPair("Ruins of Ahn\'Qiraj", 509));
            MapsList.Add(new ComboboxPair("Arathi Basin", 529));
            MapsList.Add(new ComboboxPair("Ahn\'Qiraj Temple", 531));
            MapsList.Add(new ComboboxPair("Naxxramas", 533));

            // Add emotes to a list.
            EmotesList.Add(new ComboboxPair("ONESHOT_NONE", 0));
            EmotesList.Add(new ComboboxPair("ONESHOT_TALK(DNR)", 1));
            EmotesList.Add(new ComboboxPair("ONESHOT_BOW", 2));
            EmotesList.Add(new ComboboxPair("ONESHOT_WAVE(DNR)", 3));
            EmotesList.Add(new ComboboxPair("ONESHOT_CHEER(DNR)", 4));
            EmotesList.Add(new ComboboxPair("ONESHOT_EXCLAMATION(DNR)", 5));
            EmotesList.Add(new ComboboxPair("ONESHOT_QUESTION", 6));
            EmotesList.Add(new ComboboxPair("ONESHOT_EAT", 7));
            EmotesList.Add(new ComboboxPair("STATE_DANCE", 10));
            EmotesList.Add(new ComboboxPair("ONESHOT_LAUGH", 11));
            EmotesList.Add(new ComboboxPair("STATE_SLEEP", 12));
            EmotesList.Add(new ComboboxPair("STATE_SIT", 13));
            EmotesList.Add(new ComboboxPair("ONESHOT_RUDE(DNR)", 14));
            EmotesList.Add(new ComboboxPair("ONESHOT_ROAR(DNR)", 15));
            EmotesList.Add(new ComboboxPair("ONESHOT_KNEEL", 16));
            EmotesList.Add(new ComboboxPair("ONESHOT_KISS", 17));
            EmotesList.Add(new ComboboxPair("ONESHOT_CRY", 18));
            EmotesList.Add(new ComboboxPair("ONESHOT_CHICKEN", 19));
            EmotesList.Add(new ComboboxPair("ONESHOT_BEG", 20));
            EmotesList.Add(new ComboboxPair("ONESHOT_APPLAUD", 21));
            EmotesList.Add(new ComboboxPair("ONESHOT_SHOUT(DNR)", 22));
            EmotesList.Add(new ComboboxPair("ONESHOT_FLEX", 23));
            EmotesList.Add(new ComboboxPair("ONESHOT_SHY(DNR)", 24));
            EmotesList.Add(new ComboboxPair("ONESHOT_POINT(DNR)", 25));
            EmotesList.Add(new ComboboxPair("STATE_STAND", 26));
            EmotesList.Add(new ComboboxPair("STATE_READYUNARMED", 27));
            EmotesList.Add(new ComboboxPair("STATE_WORK", 28));
            EmotesList.Add(new ComboboxPair("STATE_POINT(DNR)", 29));
            EmotesList.Add(new ComboboxPair("STATE_NONE", 30));
            EmotesList.Add(new ComboboxPair("ONESHOT_WOUND", 33));
            EmotesList.Add(new ComboboxPair("ONESHOT_WOUNDCRITICAL", 34));
            EmotesList.Add(new ComboboxPair("ONESHOT_ATTACKUNARMED", 35));
            EmotesList.Add(new ComboboxPair("ONESHOT_ATTACK1H", 36));
            EmotesList.Add(new ComboboxPair("ONESHOT_ATTACK2HTIGHT", 37));
            EmotesList.Add(new ComboboxPair("ONESHOT_ATTACK2HLOOSE", 38));
            EmotesList.Add(new ComboboxPair("ONESHOT_PARRYUNARMED", 39));
            EmotesList.Add(new ComboboxPair("ONESHOT_PARRYSHIELD", 43));
            EmotesList.Add(new ComboboxPair("ONESHOT_READYUNARMED", 44));
            EmotesList.Add(new ComboboxPair("ONESHOT_READY1H", 45));
            EmotesList.Add(new ComboboxPair("ONESHOT_READYBOW", 48));
            EmotesList.Add(new ComboboxPair("ONESHOT_SPELLPRECAST", 50));
            EmotesList.Add(new ComboboxPair("ONESHOT_SPELLCAST", 51));
            EmotesList.Add(new ComboboxPair("ONESHOT_BATTLEROAR", 53));
            EmotesList.Add(new ComboboxPair("ONESHOT_SPECIALATTACK1H", 54));
            EmotesList.Add(new ComboboxPair("ONESHOT_KICK", 60));
            EmotesList.Add(new ComboboxPair("ONESHOT_ATTACKTHROWN", 61));
            EmotesList.Add(new ComboboxPair("STATE_STUN", 64));
            EmotesList.Add(new ComboboxPair("STATE_DEAD", 65));
            EmotesList.Add(new ComboboxPair("ONESHOT_SALUTE", 66));
            EmotesList.Add(new ComboboxPair("STATE_KNEEL", 68));
            EmotesList.Add(new ComboboxPair("STATE_USESTANDING", 69));
            EmotesList.Add(new ComboboxPair("ONESHOT_WAVE_NOSHEATHE", 70));
            EmotesList.Add(new ComboboxPair("ONESHOT_CHEER_NOSHEATHE", 71));
            EmotesList.Add(new ComboboxPair("ONESHOT_EAT_NOSHEATHE", 92));
            EmotesList.Add(new ComboboxPair("STATE_STUN_NOSHEATHE", 93));
            EmotesList.Add(new ComboboxPair("ONESHOT_DANCE", 94));
            EmotesList.Add(new ComboboxPair("ONESHOT_SALUTE_NOSHEATH", 113));
            EmotesList.Add(new ComboboxPair("STATE_USESTANDING_NOSHEATHE", 133));
            EmotesList.Add(new ComboboxPair("ONESHOT_LAUGH_NOSHEATHE", 153));
            EmotesList.Add(new ComboboxPair("STATE_WORK_NOSHEATHE", 173));
            EmotesList.Add(new ComboboxPair("STATE_SPELLPRECAST", 193));
            EmotesList.Add(new ComboboxPair("ONESHOT_READYRIFLE", 213));
            EmotesList.Add(new ComboboxPair("STATE_READYRIFLE", 214));
            EmotesList.Add(new ComboboxPair("STATE_WORK_NOSHEATHE_MINING", 233));
            EmotesList.Add(new ComboboxPair("STATE_WORK_NOSHEATHE_CHOPWOOD", 234));
            EmotesList.Add(new ComboboxPair("zzOLDONESHOT_LIFTOFF", 253));
            EmotesList.Add(new ComboboxPair("ONESHOT_LIFTOFF", 254));
            EmotesList.Add(new ComboboxPair("ONESHOT_YES(DNR)", 273));
            EmotesList.Add(new ComboboxPair("ONESHOT_NO(DNR)", 274));
            EmotesList.Add(new ComboboxPair("ONESHOT_TRAIN(DNR)", 275));
            EmotesList.Add(new ComboboxPair("ONESHOT_LAND", 293));
            EmotesList.Add(new ComboboxPair("STATE_AT_EASE", 313));
            EmotesList.Add(new ComboboxPair("STATE_READY1H", 333));
            EmotesList.Add(new ComboboxPair("STATE_SPELLKNEELSTART", 353));
            EmotesList.Add(new ComboboxPair("STATE_SUBMERGED", 373));
            EmotesList.Add(new ComboboxPair("ONESHOT_SUBMERGE", 374));
            EmotesList.Add(new ComboboxPair("STATE_READY2H", 375));
            EmotesList.Add(new ComboboxPair("STATE_READYBOW", 376));

            // Add creature rank names to list.
            CreatureRanksList.Add(new ComboboxPair("Normal", 0));
            CreatureRanksList.Add(new ComboboxPair("Elite", 1));
            CreatureRanksList.Add(new ComboboxPair("Rare Elite", 2));
            CreatureRanksList.Add(new ComboboxPair("Boss", 3));
            CreatureRanksList.Add(new ComboboxPair("Rare", 4));
        }
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
    public struct QuestInfo
    {
        public uint ID;
        public uint MinLevel;
        public uint QuestLevel;
        public string Title;
        public QuestInfo(uint id, uint minlevel, uint questlevel, string title)
        {
            ID = id;
            Title = title;
            MinLevel = minlevel;
            QuestLevel = questlevel;
        }
    }
    public struct CreatureInfo
    {
        public uint ID;
        public uint MinLevel;
        public uint MaxLevel;
        public uint Rank;
        public string Name;
        public CreatureInfo(uint id, uint minlevel, uint maxlevel, uint rank, string name)
        {
            ID = id;
            Name = name;
            MinLevel = minlevel;
            MaxLevel = maxlevel;
            Rank = rank;
        }
    }
    public struct SpellInfo
    {
        public uint ID;
        public uint Effect1;
        public uint Effect2;
        public uint Effect3;
        public string Name;
        public string Description;
        public SpellInfo(uint id, uint effect1, uint effect2, uint effect3, string name, string description)
        {
            ID = id;
            Effect1 = effect1;
            Effect2 = effect2;
            Effect3 = effect3;
            Name = name;
            Description = description;
        }
    }
    public struct ItemInfo
    {
        public uint ID;
        public uint RequiredLevel;
        public uint ItemLevel;
        public string Name;
        public ItemInfo(uint id, uint requiredlevel, uint itemlevel, string name)
        {
            ID = id;
            Name = name;
            RequiredLevel = requiredlevel;
            ItemLevel = itemlevel;
        }
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
}
