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
        public static readonly List<TaxiInfo> TaxiInfoList = new List<TaxiInfo>();
        public static readonly List<ConditionInfo> ConditionInfoList = new List<ConditionInfo>();
        public static readonly List<AreaInfo> AreaInfoList = new List<AreaInfo>();
        public static readonly List<SoundInfo> SoundInfoList = new List<SoundInfo>();
        public static readonly List<FactionInfo> FactionInfoList = new List<FactionInfo>();
        public static readonly List<FactionTemplateInfo> FactionTemplateInfoList = new List<FactionTemplateInfo>();
        public static readonly List<GameEventInfo> GameEventInfoList = new List<GameEventInfo>();
        public static readonly List<GameObjectInfo> GameObjectInfoList = new List<GameObjectInfo>();
        public static readonly List<CreatureSpellsInfo> CreatureSpellsInfoList = new List<CreatureSpellsInfo>();
        public static readonly List<ComboboxPair> UpdateFieldsList = new List<ComboboxPair>();
        public static readonly List<ComboboxPair> FlagFieldsList = new List<ComboboxPair>();
        public static readonly List<ComboboxPair> MapsList = new List<ComboboxPair>();
        public static readonly List<ComboboxPair> EmotesList = new List<ComboboxPair>();
        public static readonly List<ComboboxPair> TextEmotesList = new List<ComboboxPair>();
        public static readonly List<ComboboxPair> CreatureRanksList = new List<ComboboxPair>();
        public static readonly List<ComboboxPair> MotionTypesList = new List<ComboboxPair>();
        public static readonly List<ComboboxPair> MotionTypesFullList = new List<ComboboxPair>();
        public static readonly List<ComboboxPair> ConditionNamesList = new List<ComboboxPair>();
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
        public static int FindIndexOfMotionType(uint id)
        {
            for (int i = 0; i < MotionTypesList.Count; i++)
            {
                if (id == (uint)(MotionTypesList[i] as ComboboxPair).Value)
                    return i;
            }
            return 0;
        }
        public static int FindIndexOfMotionTypeFull(uint id)
        {
            if (id >= 1024)
                return FindIndexOfMotionTypeFullInternal(1024);
            else if ((id >= 512) && (id < 1024))
                return FindIndexOfMotionTypeFullInternal(512);
            else if ((id >= 256) && (id < 512))
                return FindIndexOfMotionTypeFullInternal(256);

            return FindIndexOfMotionTypeFullInternal(id);
        }
        private static int FindIndexOfMotionTypeFullInternal(uint id)
        {
            for (int i = 0; i < MotionTypesFullList.Count; i++)
            {
                if (id == (uint)(MotionTypesFullList[i] as ComboboxPair).Value)
                    return i;
            }

            return -1;
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
        public static int FindIndexOfTextEmote(uint id)
        {
            for (int i = 0; i < TextEmotesList.Count; i++)
            {
                if (id == (uint)(TextEmotesList[i] as ComboboxPair).Value)
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
        public static string FindGameObjectName(uint id)
        {
            foreach (GameObjectInfo gameobject in GameObjectInfoList)
            {
                if (gameobject.ID == id)
                    return gameobject.Name;
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
        public static string FindTaxiPathDestination(uint id)
        {
            foreach (TaxiInfo item in TaxiInfoList)
            {
                if (item.ID == id)
                    return item.Source + " - " + item.Destination;
            }

            return "";
        }
        public static string FindConditionName(int id)
        {
            foreach (ComboboxPair condition in ConditionNamesList)
            {
                if (condition.Value == id)
                    return condition.Text;
            }

            return "";
        }
        public static string FindAreaName(uint id)
        {
            foreach (AreaInfo area in AreaInfoList)
            {
                if (area.ID == id)
                    return area.Name;
            }

            return "";
        }
        public static string FindSoundName(uint id)
        {
            foreach (SoundInfo sound in SoundInfoList)
            {
                if (sound.ID == id)
                    return sound.Name;
            }

            return "";
        }
        public static string FindFactionName(uint id)
        {
            foreach (FactionInfo faction in FactionInfoList)
            {
                if (faction.ID == id)
                    return faction.Name;
            }

            return "";
        }
        public static string FindFactionTemplateName(uint id)
        {
            foreach (FactionTemplateInfo factiontemplate in FactionTemplateInfoList)
            {
                if (factiontemplate.ID == id)
                    return FindFactionName(factiontemplate.FactionId);
            }

            return "";
        }
        public static string FindEventName(uint id)
        {
            foreach (GameEventInfo gamevent in GameEventInfoList)
            {
                if (gamevent.ID == id)
                    return gamevent.Name;
            }

            return "";
        }
        public static string FindCreatureSpellsTemplateName(uint id)
        {
            foreach (CreatureSpellsInfo template in CreatureSpellsInfoList)
            {
                if (template.ID == id)
                    return template.Name;
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
        public static void LoadGameObjects(string connString)
        {
            GameObjectInfoList.Clear();

            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT `entry`, `type`, `displayId`, `name` FROM `gameobject_template` t1 WHERE `patch`=(SELECT max(`patch`) FROM `gameobject_template` t2 WHERE t1.`entry`=t2.`entry`) ORDER BY `entry`";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add the new gameobject entry to the list.
                    GameObjectInfoList.Add(new GameObjectInfo(reader.GetUInt32(0), reader.GetUInt32(1), reader.GetUInt32(2), reader.GetString(3)));
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
            command.CommandText = "SELECT entry, minlevel, maxlevel, rank, name, spells_template FROM creature_template t1 WHERE patch=(SELECT max(patch) FROM creature_template t2 WHERE t1.entry=t2.entry) ORDER BY entry";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add the new creature entry to the list.
                    CreatureInfoList.Add(new CreatureInfo(reader.GetUInt32(0), reader.GetUInt32(1), reader.GetUInt32(2), reader.GetUInt32(3), reader.GetUInt32(5), reader.GetString(4)));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }
        public static void LoadCreatureSpells(string connString)
        {
            CreatureSpellsInfoList.Clear();

            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM creature_spells ORDER BY entry";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    CreatureSpellsInfo template = new CreatureSpellsInfo(reader.GetUInt32(0), reader.GetString(1));

                    template.SpellId1 = reader.GetUInt32(2);
                    template.Probability1 = reader.GetUInt32(3);
                    template.CastTarget1 = reader.GetUInt32(4);
                    template.TargetParam1_1 = reader.GetUInt32(5);
                    template.TargetParam2_1 = reader.GetUInt32(6);
                    template.CastFlags1 = reader.GetUInt32(7);
                    template.DelayInitialMin1 = reader.GetUInt32(8);
                    template.DelayInitialMax1 = reader.GetUInt32(9);
                    template.DelayRepeatMin1 = reader.GetUInt32(10);
                    template.DelayRepeatMax1 = reader.GetUInt32(11);
                    template.ScriptId1 = reader.GetUInt32(12);

                    template.SpellId2 = reader.GetUInt32(13);
                    template.Probability2 = reader.GetUInt32(14);
                    template.CastTarget2 = reader.GetUInt32(15);
                    template.TargetParam1_2 = reader.GetUInt32(16);
                    template.TargetParam2_2 = reader.GetUInt32(17);
                    template.CastFlags2 = reader.GetUInt32(18);
                    template.DelayInitialMin2 = reader.GetUInt32(19);
                    template.DelayInitialMax2 = reader.GetUInt32(20);
                    template.DelayRepeatMin2 = reader.GetUInt32(21);
                    template.DelayRepeatMax2 = reader.GetUInt32(22);
                    template.ScriptId2 = reader.GetUInt32(23);

                    template.SpellId3 = reader.GetUInt32(24);
                    template.Probability3 = reader.GetUInt32(25);
                    template.CastTarget3 = reader.GetUInt32(26);
                    template.TargetParam1_3 = reader.GetUInt32(27);
                    template.TargetParam2_3 = reader.GetUInt32(28);
                    template.CastFlags3 = reader.GetUInt32(29);
                    template.DelayInitialMin3 = reader.GetUInt32(30);
                    template.DelayInitialMax3 = reader.GetUInt32(31);
                    template.DelayRepeatMin3 = reader.GetUInt32(32);
                    template.DelayRepeatMax3 = reader.GetUInt32(33);
                    template.ScriptId3 = reader.GetUInt32(34);

                    template.SpellId4 = reader.GetUInt32(35);
                    template.Probability4 = reader.GetUInt32(36);
                    template.CastTarget4 = reader.GetUInt32(37);
                    template.TargetParam1_4 = reader.GetUInt32(38);
                    template.TargetParam2_4 = reader.GetUInt32(39);
                    template.CastFlags4 = reader.GetUInt32(40);
                    template.DelayInitialMin4 = reader.GetUInt32(41);
                    template.DelayInitialMax4 = reader.GetUInt32(42);
                    template.DelayRepeatMin4 = reader.GetUInt32(43);
                    template.DelayRepeatMax4 = reader.GetUInt32(44);
                    template.ScriptId4 = reader.GetUInt32(45);

                    template.SpellId5 = reader.GetUInt32(46);
                    template.Probability5 = reader.GetUInt32(47);
                    template.CastTarget5 = reader.GetUInt32(48);
                    template.TargetParam1_5 = reader.GetUInt32(49);
                    template.TargetParam2_5 = reader.GetUInt32(50);
                    template.CastFlags5 = reader.GetUInt32(51);
                    template.DelayInitialMin5 = reader.GetUInt32(52);
                    template.DelayInitialMax5 = reader.GetUInt32(53);
                    template.DelayRepeatMin5 = reader.GetUInt32(54);
                    template.DelayRepeatMax5 = reader.GetUInt32(55);
                    template.ScriptId5 = reader.GetUInt32(56);

                    template.SpellId6 = reader.GetUInt32(57);
                    template.Probability6 = reader.GetUInt32(58);
                    template.CastTarget6 = reader.GetUInt32(59);
                    template.TargetParam1_6 = reader.GetUInt32(60);
                    template.TargetParam2_6 = reader.GetUInt32(61);
                    template.CastFlags6 = reader.GetUInt32(62);
                    template.DelayInitialMin6 = reader.GetUInt32(63);
                    template.DelayInitialMax6 = reader.GetUInt32(64);
                    template.DelayRepeatMin6 = reader.GetUInt32(65);
                    template.DelayRepeatMax6 = reader.GetUInt32(66);
                    template.ScriptId6 = reader.GetUInt32(67);

                    template.SpellId7 = reader.GetUInt32(68);
                    template.Probability7 = reader.GetUInt32(69);
                    template.CastTarget7 = reader.GetUInt32(70);
                    template.TargetParam1_7 = reader.GetUInt32(71);
                    template.TargetParam2_7 = reader.GetUInt32(72);
                    template.CastFlags7 = reader.GetUInt32(73);
                    template.DelayInitialMin7 = reader.GetUInt32(74);
                    template.DelayInitialMax7 = reader.GetUInt32(75);
                    template.DelayRepeatMin7 = reader.GetUInt32(76);
                    template.DelayRepeatMax7 = reader.GetUInt32(77);
                    template.ScriptId7 = reader.GetUInt32(78);

                    template.SpellId8 = reader.GetUInt32(79);
                    template.Probability8 = reader.GetUInt32(80);
                    template.CastTarget8 = reader.GetUInt32(81);
                    template.TargetParam1_8 = reader.GetUInt32(82);
                    template.TargetParam2_8 = reader.GetUInt32(83);
                    template.CastFlags8 = reader.GetUInt32(84);
                    template.DelayInitialMin8 = reader.GetUInt32(85);
                    template.DelayInitialMax8 = reader.GetUInt32(86);
                    template.DelayRepeatMin8 = reader.GetUInt32(87);
                    template.DelayRepeatMax8 = reader.GetUInt32(88);
                    template.ScriptId8 = reader.GetUInt32(89);

                    // Add the new creature spells template to the list.
                    CreatureSpellsInfoList.Add(template);
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
            command.CommandText = "SELECT ID, effect1, effect2, effect3, name1, description1 FROM spell_template WHERE build=5875 ORDER BY ID";
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
            command.CommandText = "SELECT entry, RequiredLevel, ItemLevel, InventoryType, displayid, name FROM item_template t1 WHERE patch=(SELECT max(patch) FROM item_template t2 WHERE t1.entry=t2.entry) ORDER BY entry";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add the new item entry to the list.
                    ItemInfoList.Add(new ItemInfo(reader.GetUInt32(0), reader.GetUInt32(1), reader.GetUInt32(2), reader.GetUInt32(3), reader.GetUInt32(4), reader.GetString(5)));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }
        public static void LoadCondition(string connString)
        {
            ConditionInfoList.Clear();

            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT condition_entry, type, value1, value2, value3, value4, flags FROM conditions ORDER BY condition_entry";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add the new condition entry to the list.
                    ConditionInfoList.Add(new ConditionInfo(reader.GetUInt32(0), reader.GetInt32(1), reader.GetUInt32(2), reader.GetUInt32(3), reader.GetUInt32(4), reader.GetUInt32(5), reader.GetUInt32(6)));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }
        public static void LoadAreas(string connString)
        {
            AreaInfoList.Clear();

            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT Entry, MapId, ZoneId, Name FROM area_template ORDER BY Entry";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add the new area entry to the list.
                    AreaInfoList.Add(new AreaInfo(reader.GetUInt32(0), reader.GetUInt32(1), reader.GetUInt32(2), reader.GetString(3)));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }
        public static void LoadSounds(string connString)
        {
            SoundInfoList.Clear();

            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT ID, name FROM sound_entries ORDER BY ID";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add the new sound entry to the list.
                    SoundInfoList.Add(new SoundInfo(reader.GetUInt32(0), reader.GetString(1)));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }
        public static void LoadFactions(string connString)
        {
            FactionInfoList.Clear();

            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT ID, name1, description1 FROM faction WHERE build=5875 ORDER BY ID";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add the new faction entry to the list.
                    FactionInfoList.Add(new FactionInfo(reader.GetUInt32(0), reader.GetString(1), reader.GetString(2)));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }
        public static void LoadFactionTemplates(string connString)
        {
            FactionTemplateInfoList.Clear();

            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT ID, factionId, factionFlags FROM faction_template WHERE build=5875 ORDER BY ID";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add the new faction template entry to the list.
                    FactionTemplateInfoList.Add(new FactionTemplateInfo(reader.GetUInt32(0), reader.GetUInt32(1), reader.GetUInt32(2)));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }
        public static void LoadGameEvents(string connString)
        {
            GameEventInfoList.Clear();

            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT entry, occurence, length, description, patch_min, patch_max FROM game_event ORDER BY entry";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add the new game event entry to the list.
                    GameEventInfoList.Add(new GameEventInfo(reader.GetUInt32(0), reader.GetUInt32(1), reader.GetUInt32(2), reader.GetString(3), reader.GetUInt32(4), reader.GetUInt32(5)));
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

            // Add text emotes to a list.
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_AGREE", 1));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_AMAZE", 2));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_ANGRY", 3));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_APOLOGIZE", 4));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_APPLAUD", 5));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_BASHFUL", 6));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_BECKON", 7));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_BEG", 8));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_BITE", 9));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_BLEED", 10));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_BLINK", 11));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_BLUSH", 12));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_BONK", 13));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_BORED", 14));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_BOUNCE", 15));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_BRB", 16));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_BOW", 17));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_BURP", 18));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_BYE", 19));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_CACKLE", 20));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_CHEER", 21));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_CHICKEN", 22));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_CHUCKLE", 23));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_CLAP", 24));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_CONFUSED", 25));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_CONGRATULATE", 26));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_COUGH", 27));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_COWER", 28));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_CRACK", 29));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_CRINGE", 30));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_CRY", 31));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_CURIOUS", 32));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_CURTSEY", 33));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_DANCE", 34));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_DRINK", 35));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_DROOL", 36));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_EAT", 37));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_EYE", 38));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_FART", 39));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_FIDGET", 40));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_FLEX", 41));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_FROWN", 42));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_GASP", 43));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_GAZE", 44));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_GIGGLE", 45));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_GLARE", 46));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_GLOAT", 47));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_GREET", 48));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_GRIN", 49));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_GROAN", 50));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_GROVEL", 51));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_GUFFAW", 52));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_HAIL", 53));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_HAPPY", 54));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_HELLO", 55));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_HUG", 56));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_HUNGRY", 57));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_KISS", 58));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_KNEEL", 59));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_LAUGH", 60));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_LAYDOWN", 61));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_MESSAGE", 62));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_MOAN", 63));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_MOON", 64));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_MOURN", 65));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_NO", 66));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_NOD", 67));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_NOSEPICK", 68));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_PANIC", 69));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_PEER", 70));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_PLEAD", 71));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_POINT", 72));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_POKE", 73));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_PRAY", 74));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_ROAR", 75));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_ROFL", 76));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_RUDE", 77));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SALUTE", 78));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SCRATCH", 79));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SEXY", 80));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SHAKE", 81));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SHOUT", 82));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SHRUG", 83));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SHY", 84));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SIGH", 85));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SIT", 86));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SLEEP", 87));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SNARL", 88));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SPIT", 89));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_STARE", 90));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SURPRISED", 91));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SURRENDER", 92));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_TALK", 93));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_TALKEX", 94));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_TALKQ", 95));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_TAP", 96));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_THANK", 97));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_THREATEN", 98));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_TIRED", 99));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_VICTORY", 100));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_WAVE", 101));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_WELCOME", 102));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_WHINE", 103));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_WHISTLE", 104));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_WORK", 105));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_YAWN", 106));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_BOGGLE", 107));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_CALM", 108));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_COLD", 109));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_COMFORT", 110));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_CUDDLE", 111));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_DUCK", 112));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_INSULT", 113));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_INTRODUCE", 114));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_JK", 115));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_LICK", 116));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_LISTEN", 117));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_LOST", 118));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_MOCK", 119));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_PONDER", 120));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_POUNCE", 121));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_PRAISE", 122));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_PURR", 123));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_PUZZLE", 124));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_RAISE", 125));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_READY", 126));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SHIMMY", 127));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SHIVER", 128));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SHOO", 129));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SLAP", 130));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SMIRK", 131));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SNIFF", 132));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SNUB", 133));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SOOTHE", 134));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_STINK", 135));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_TAUNT", 136));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_TEASE", 137));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_THIRSTY", 138));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_VETO", 139));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SNICKER", 140));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_STAND", 141));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_TICKLE", 142));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_VIOLIN", 143));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SMILE", 163));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_RASP", 183));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_PITY", 203));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_GROWL", 204));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_BARK", 205));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SCARED", 223));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_FLOP", 224));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_LOVE", 225));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_MOO", 226));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_OPENFIRE", 327));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_FLIRT", 328));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_JOKE", 329));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_COMMEND", 243));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_WINK", 363));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_PAT", 364));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_SERIOUS", 365));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_MOUNTSPECIAL", 366));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_GOODLUCK", 367));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_BLAME", 368));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_BLANK", 369));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_BRANDISH", 370));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_BREATH", 371));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_DISAGREE", 372));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_DOUBT", 373));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_EMBARRASS", 374));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_ENCOURAGE", 375));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_ENEMY", 376));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_EYEBROW", 377));
            TextEmotesList.Add(new ComboboxPair("TEXTEMOTE_TOAST", 378));

            // Add creature rank names to list.
            CreatureRanksList.Add(new ComboboxPair("Normal", 0));
            CreatureRanksList.Add(new ComboboxPair("Elite", 1));
            CreatureRanksList.Add(new ComboboxPair("Rare Elite", 2));
            CreatureRanksList.Add(new ComboboxPair("Boss", 3));
            CreatureRanksList.Add(new ComboboxPair("Rare", 4));

            // Add motion types to list. (for command 20)
            MotionTypesList.Add(new ComboboxPair("IDLE_MOTION_TYPE", 0));
            MotionTypesList.Add(new ComboboxPair("RANDOM_MOTION_TYPE", 1));
            MotionTypesList.Add(new ComboboxPair("WAYPOINT_MOTION_TYPE", 2));
            MotionTypesList.Add(new ComboboxPair("CONFUSED_MOTION_TYPE", 4));
            MotionTypesList.Add(new ComboboxPair("CHASE_MOTION_TYPE", 5));
            MotionTypesList.Add(new ComboboxPair("HOME_MOTION_TYPE", 6));
            MotionTypesList.Add(new ComboboxPair("FLEEING_MOTION_TYPE", 9));
            MotionTypesList.Add(new ComboboxPair("DISTRACT_MOTION_TYPE", 10));
            MotionTypesList.Add(new ComboboxPair("FOLLOW_MOTION_TYPE", 14));
            MotionTypesList.Add(new ComboboxPair("CHARGE_MOTION_TYPE", 17));

            // Add all motion types to list.
            MotionTypesFullList.Add(new ComboboxPair("IDLE_MOTION_TYPE", 0));
            MotionTypesFullList.Add(new ComboboxPair("RANDOM_MOTION_TYPE", 1));
            MotionTypesFullList.Add(new ComboboxPair("WAYPOINT_MOTION_TYPE", 2));
            MotionTypesFullList.Add(new ComboboxPair("CONFUSED_MOTION_TYPE", 4));
            MotionTypesFullList.Add(new ComboboxPair("CHASE_MOTION_TYPE", 5));
            MotionTypesFullList.Add(new ComboboxPair("HOME_MOTION_TYPE", 6));
            MotionTypesFullList.Add(new ComboboxPair("FLIGHT_MOTION_TYPE", 7));
            MotionTypesFullList.Add(new ComboboxPair("POINT_MOTION_TYPE", 8));
            MotionTypesFullList.Add(new ComboboxPair("FLEEING_MOTION_TYPE", 9));
            MotionTypesFullList.Add(new ComboboxPair("DISTRACT_MOTION_TYPE", 10));
            MotionTypesFullList.Add(new ComboboxPair("ASSISTANCE_MOTION_TYPE", 11));
            MotionTypesFullList.Add(new ComboboxPair("ASSISTANCE_DISTRACT_MOTION_TYPE", 12));
            MotionTypesFullList.Add(new ComboboxPair("TIMED_FLEEING_MOTION_TYPE", 13));
            MotionTypesFullList.Add(new ComboboxPair("FOLLOW_MOTION_TYPE", 14));
            MotionTypesFullList.Add(new ComboboxPair("EFFECT_MOTION_TYPE", 15));
            MotionTypesFullList.Add(new ComboboxPair("PATROL_MOTION_TYPE", 16));
            MotionTypesFullList.Add(new ComboboxPair("CHARGE_MOTION_TYPE", 17));
            MotionTypesFullList.Add(new ComboboxPair("WAYPOINT_SPECIAL_REACHED", 256));
            MotionTypesFullList.Add(new ComboboxPair("WAYPOINT_SPECIAL_STARTED", 512));
            MotionTypesFullList.Add(new ComboboxPair("WAYPOINT_SPECIAL_FINISHED_LAST", 1024));

            // Add taxi paths to list.
            TaxiInfoList.Add(new TaxiInfo(6, "Stormwind, Elwynn", "Sentinel Hill, Westfall"));
            TaxiInfoList.Add(new TaxiInfo(7, "Sentinel Hill, Westfall", "Stormwind, Elwynn"));
            TaxiInfoList.Add(new TaxiInfo(8, "Lakeshire, Redridge", "Stormwind, Elwynn"));
            TaxiInfoList.Add(new TaxiInfo(9, "Stormwind, Elwynn", "Lakeshire, Redridge"));
            TaxiInfoList.Add(new TaxiInfo(12, "Ironforge, Dun Morogh", "Stormwind, Elwynn"));
            TaxiInfoList.Add(new TaxiInfo(13, "Stormwind, Elwynn", "Ironforge, Dun Morogh"));
            TaxiInfoList.Add(new TaxiInfo(15, "Thelsamar, Loch Modan", "Ironforge, Dun Morogh"));
            TaxiInfoList.Add(new TaxiInfo(16, "Ironforge, Dun Morogh", "Thelsamar, Loch Modan"));
            TaxiInfoList.Add(new TaxiInfo(17, "Menethil Harbor, Wetlands", "Ironforge, Dun Morogh"));
            TaxiInfoList.Add(new TaxiInfo(18, "Ironforge, Dun Morogh", "Menethil Harbor, Wetlands"));
            TaxiInfoList.Add(new TaxiInfo(20, "Undercity, Tirisfal", "The Sepulcher, Silverpine Forest"));
            TaxiInfoList.Add(new TaxiInfo(21, "The Sepulcher, Silverpine Forest", "Undercity, Tirisfal"));
            TaxiInfoList.Add(new TaxiInfo(22, "Darkshire, Duskwood", "Stormwind, Elwynn"));
            TaxiInfoList.Add(new TaxiInfo(23, "Stormwind, Elwynn", "Darkshire, Duskwood"));
            TaxiInfoList.Add(new TaxiInfo(24, "Tarren Mill, Hillsbrad", "Undercity, Tirisfal"));
            TaxiInfoList.Add(new TaxiInfo(25, "Undercity, Tirisfal", "Tarren Mill, Hillsbrad"));
            TaxiInfoList.Add(new TaxiInfo(26, "Southshore, Hillsbrad", "Ironforge, Dun Morogh"));
            TaxiInfoList.Add(new TaxiInfo(27, "Ironforge, Dun Morogh", "Southshore, Hillsbrad"));
            TaxiInfoList.Add(new TaxiInfo(30, "Refuge Pointe, Arathi", "Ironforge, Dun Morogh"));
            TaxiInfoList.Add(new TaxiInfo(31, "Ironforge, Dun Morogh", "Refuge Pointe, Arathi"));
            TaxiInfoList.Add(new TaxiInfo(32, "Hammerfall, Arathi", "Undercity, Tirisfal"));
            TaxiInfoList.Add(new TaxiInfo(33, "Undercity, Tirisfal", "Hammerfall, Arathi"));
            TaxiInfoList.Add(new TaxiInfo(34, "Grom'gol, Stranglethorn", "Booty Bay, Stranglethorn"));
            TaxiInfoList.Add(new TaxiInfo(35, "Booty Bay, Stranglethorn", "Grom'gol, Stranglethorn"));
            TaxiInfoList.Add(new TaxiInfo(36, "Booty Bay, Stranglethorn", "Kargath, Badlands"));
            TaxiInfoList.Add(new TaxiInfo(37, "Kargath, Badlands", "Booty Bay, Stranglethorn"));
            TaxiInfoList.Add(new TaxiInfo(38, "Kargath, Badlands", "Undercity, Tirisfal"));
            TaxiInfoList.Add(new TaxiInfo(39, "Undercity, Tirisfal", "Kargath, Badlands"));
            TaxiInfoList.Add(new TaxiInfo(40, "Stormwind, Elwynn", "Booty Bay, Stranglethorn"));
            TaxiInfoList.Add(new TaxiInfo(41, "Booty Bay, Stranglethorn", "Stormwind, Elwynn"));
            TaxiInfoList.Add(new TaxiInfo(42, "Orgrimmar, Durotar", "Thunder Bluff, Mulgore"));
            TaxiInfoList.Add(new TaxiInfo(44, "Crossroads, The Barrens", "Thunder Bluff, Mulgore"));
            TaxiInfoList.Add(new TaxiInfo(45, "Crossroads, The Barrens", "Orgrimmar, Durotar"));
            TaxiInfoList.Add(new TaxiInfo(46, "Thunder Bluff, Mulgore", "Crossroads, The Barrens"));
            TaxiInfoList.Add(new TaxiInfo(47, "Orgrimmar, Durotar", "Crossroads, The Barrens"));
            TaxiInfoList.Add(new TaxiInfo(50, "Astranaar, Ashenvale", "Auberdine, Darkshore"));
            TaxiInfoList.Add(new TaxiInfo(51, "Auberdine, Darkshore", "Astranaar, Ashenvale"));
            TaxiInfoList.Add(new TaxiInfo(52, "Sun Rock Retreat, Stonetalon Mountains", "Thunder Bluff, Mulgore"));
            TaxiInfoList.Add(new TaxiInfo(53, "Thunder Bluff, Mulgore", "Sun Rock Retreat, Stonetalon Mountains"));
            TaxiInfoList.Add(new TaxiInfo(54, "Freewind Post, Thousand Needles", "Thunder Bluff, Mulgore"));
            TaxiInfoList.Add(new TaxiInfo(55, "Thunder Bluff, Mulgore", "Freewind Post, Thousand Needles"));
            TaxiInfoList.Add(new TaxiInfo(56, "Theramore, Dustwallow Marsh", "Thalanaar, Feralas"));
            TaxiInfoList.Add(new TaxiInfo(57, "Thalanaar, Feralas", "Theramore, Dustwallow Marsh"));
            TaxiInfoList.Add(new TaxiInfo(58, "Stonetalon Peak, Stonetalon Mountains", "Auberdine, Darkshore"));
            TaxiInfoList.Add(new TaxiInfo(59, "Auberdine, Darkshore", "Stonetalon Peak, Stonetalon Mountains"));
            TaxiInfoList.Add(new TaxiInfo(82, "Booty Bay, Stranglethorn", "Stonard, Swamp of Sorrows"));
            TaxiInfoList.Add(new TaxiInfo(101, "Auberdine, Darkshore", "Rut'theran Village, Teldrassil"));
            TaxiInfoList.Add(new TaxiInfo(102, "Rut'theran Village, Teldrassil", "Auberdine, Darkshore"));
            TaxiInfoList.Add(new TaxiInfo(121, "Stonard, Swamp of Sorrows", "Booty Bay, Stranglethorn"));
            TaxiInfoList.Add(new TaxiInfo(141, "Nijel's Point, Desolace", "Theramore, Dustwallow Marsh"));
            TaxiInfoList.Add(new TaxiInfo(161, "Shadowprey Village, Desolace", "Thunder Bluff, Mulgore"));
            TaxiInfoList.Add(new TaxiInfo(162, "Thunder Bluff, Mulgore", "Shadowprey Village, Desolace"));
            TaxiInfoList.Add(new TaxiInfo(163, "Theramore, Dustwallow Marsh", "Nijel's Point, Desolace"));
            TaxiInfoList.Add(new TaxiInfo(181, "Auberdine, Darkshore", "Theramore, Dustwallow Marsh"));
            TaxiInfoList.Add(new TaxiInfo(182, "Theramore, Dustwallow Marsh", "Auberdine, Darkshore"));
            TaxiInfoList.Add(new TaxiInfo(201, "Gadgetzan, Tanaris", "Theramore, Dustwallow Marsh"));
            TaxiInfoList.Add(new TaxiInfo(222, "Theramore, Dustwallow Marsh", "Gadgetzan, Tanaris"));
            TaxiInfoList.Add(new TaxiInfo(223, "Gadgetzan, Tanaris", "Orgrimmar, Durotar"));
            TaxiInfoList.Add(new TaxiInfo(224, "Orgrimmar, Durotar", "Gadgetzan, Tanaris"));
            TaxiInfoList.Add(new TaxiInfo(225, "Feathermoon, Feralas", "Auberdine, Darkshore"));
            TaxiInfoList.Add(new TaxiInfo(226, "Auberdine, Darkshore", "Feathermoon, Feralas"));
            TaxiInfoList.Add(new TaxiInfo(227, "Camp Mojache, Feralas", "Thunder Bluff, Mulgore"));
            TaxiInfoList.Add(new TaxiInfo(228, "Thunder Bluff, Mulgore", "Camp Mojache, Feralas"));
            TaxiInfoList.Add(new TaxiInfo(229, "Aerie Peak, The Hinterlands", "Southshore, Hillsbrad"));
            TaxiInfoList.Add(new TaxiInfo(230, "Southshore, Hillsbrad", "Aerie Peak, The Hinterlands"));
            TaxiInfoList.Add(new TaxiInfo(241, "Transport, Booty Bay - Ratchet", "Transport, Orgrimmar Zepplins"));
            TaxiInfoList.Add(new TaxiInfo(242, "Valormok, Azshara", "Orgrimmar, Durotar"));
            TaxiInfoList.Add(new TaxiInfo(243, "Orgrimmar, Durotar", "Valormok, Azshara"));
            TaxiInfoList.Add(new TaxiInfo(244, "Nethergarde Keep, Blasted Lands", "Stormwind, Elwynn"));
            TaxiInfoList.Add(new TaxiInfo(245, "Stormwind, Elwynn", "Nethergarde Keep, Blasted Lands"));
            TaxiInfoList.Add(new TaxiInfo(249, "Sentinel Hill, Westfall", "Lakeshire, Redridge"));
            TaxiInfoList.Add(new TaxiInfo(250, "Sentinel Hill, Westfall", "Darkshire, Duskwood"));
            TaxiInfoList.Add(new TaxiInfo(252, "Darkshire, Duskwood", "Sentinel Hill, Westfall"));
            TaxiInfoList.Add(new TaxiInfo(253, "Southshore Ferry, Hillsbrad", "Menethil Harbor, Wetlands"));
            TaxiInfoList.Add(new TaxiInfo(254, "Lakeshire, Redridge", "Sentinel Hill, Westfall"));
            TaxiInfoList.Add(new TaxiInfo(255, "Sentinel Hill, Westfall", "Booty Bay, Stranglethorn"));
            TaxiInfoList.Add(new TaxiInfo(256, "Booty Bay, Stranglethorn", "Sentinel Hill, Westfall"));
            TaxiInfoList.Add(new TaxiInfo(257, "Lakeshire, Redridge", "Darkshire, Duskwood"));
            TaxiInfoList.Add(new TaxiInfo(258, "Darkshire, Duskwood", "Lakeshire, Redridge"));
            TaxiInfoList.Add(new TaxiInfo(259, "Darkshire, Duskwood", "Booty Bay, Stranglethorn"));
            TaxiInfoList.Add(new TaxiInfo(260, "Booty Bay, Stranglethorn", "Darkshire, Duskwood"));
            TaxiInfoList.Add(new TaxiInfo(261, "Darkshire, Duskwood", "Nethergarde Keep, Blasted Lands"));
            TaxiInfoList.Add(new TaxiInfo(262, "Nethergarde Keep, Blasted Lands", "Darkshire, Duskwood"));
            TaxiInfoList.Add(new TaxiInfo(263, "Ironforge, Dun Morogh", "Aerie Peak, The Hinterlands"));
            TaxiInfoList.Add(new TaxiInfo(264, "Aerie Peak, The Hinterlands", "Ironforge, Dun Morogh"));
            TaxiInfoList.Add(new TaxiInfo(265, "Thelsamar, Loch Modan", "Menethil Harbor, Wetlands"));
            TaxiInfoList.Add(new TaxiInfo(266, "Menethil Harbor, Wetlands", "Thelsamar, Loch Modan"));
            TaxiInfoList.Add(new TaxiInfo(267, "Thelsamar, Loch Modan", "Refuge Pointe, Arathi"));
            TaxiInfoList.Add(new TaxiInfo(268, "Refuge Pointe, Arathi", "Thelsamar, Loch Modan"));
            TaxiInfoList.Add(new TaxiInfo(269, "Menethil Harbor, Wetlands", "Refuge Pointe, Arathi"));
            TaxiInfoList.Add(new TaxiInfo(270, "Refuge Pointe, Arathi", "Menethil Harbor, Wetlands"));
            TaxiInfoList.Add(new TaxiInfo(271, "Menethil Harbor, Wetlands", "Southshore, Hillsbrad"));
            TaxiInfoList.Add(new TaxiInfo(272, "Southshore, Hillsbrad", "Menethil Harbor, Wetlands"));
            TaxiInfoList.Add(new TaxiInfo(273, "Refuge Pointe, Arathi", "Southshore, Hillsbrad"));
            TaxiInfoList.Add(new TaxiInfo(274, "Southshore, Hillsbrad", "Refuge Pointe, Arathi"));
            TaxiInfoList.Add(new TaxiInfo(275, "Refuge Pointe, Arathi", "Aerie Peak, The Hinterlands"));
            TaxiInfoList.Add(new TaxiInfo(276, "Aerie Peak, The Hinterlands", "Refuge Pointe, Arathi"));
            TaxiInfoList.Add(new TaxiInfo(279, "Crossroads, The Barrens", "Sun Rock Retreat, Stonetalon Mountains"));
            TaxiInfoList.Add(new TaxiInfo(280, "Sun Rock Retreat, Stonetalon Mountains", "Crossroads, The Barrens"));
            TaxiInfoList.Add(new TaxiInfo(281, "Crossroads, The Barrens", "Freewind Post, Thousand Needles"));
            TaxiInfoList.Add(new TaxiInfo(282, "Freewind Post, Thousand Needles", "Crossroads, The Barrens"));
            TaxiInfoList.Add(new TaxiInfo(283, "Crossroads, The Barrens", "Valormok, Azshara"));
            TaxiInfoList.Add(new TaxiInfo(284, "Valormok, Azshara", "Crossroads, The Barrens"));
            TaxiInfoList.Add(new TaxiInfo(285, "Transport, Grom'gol - Orgrimmar", "Transport, Orgrimmar Zepplins"));
            TaxiInfoList.Add(new TaxiInfo(286, "Bloodvenom Post, Felwood", "Crossroads, The Barrens"));
            TaxiInfoList.Add(new TaxiInfo(287, "Crossroads, The Barrens", "Bloodvenom Post, Felwood"));
            TaxiInfoList.Add(new TaxiInfo(289, "Auberdine, Darkshore", "Moonglade"));
            TaxiInfoList.Add(new TaxiInfo(290, "Thunder Bluff, Mulgore", "Valormok, Azshara"));
            TaxiInfoList.Add(new TaxiInfo(291, "Valormok, Azshara", "Thunder Bluff, Mulgore"));
            TaxiInfoList.Add(new TaxiInfo(292, "Transport, Menethil Ships", "Generic, World target"));
            TaxiInfoList.Add(new TaxiInfo(293, "Transport, Rut'theran - Auberdine", "Transport, Menethil Ships"));
            TaxiInfoList.Add(new TaxiInfo(295, "Transport, Menethil Ships", "Transport, Rut'theran - Auberdine"));
            TaxiInfoList.Add(new TaxiInfo(298, "Everlook, Winterspring", "Moonglade"));
            TaxiInfoList.Add(new TaxiInfo(301, "Transport, Orgrimmar Zepplins", "Grom'gol, Stranglethorn"));
            TaxiInfoList.Add(new TaxiInfo(302, "Transport, Orgrimmar Zepplins", "Generic, World target for Zeppelin Paths"));
            TaxiInfoList.Add(new TaxiInfo(303, "Transport, Feathermoon - Feralas", "Generic, World target for Zeppelin Paths"));
            TaxiInfoList.Add(new TaxiInfo(304, "Brackenwall Village, Dustwallow Marsh", "Crossroads, The Barrens"));
            TaxiInfoList.Add(new TaxiInfo(305, "Zoram'gar Outpost, Ashenvale", "Crossroads, The Barrens"));
            TaxiInfoList.Add(new TaxiInfo(306, "Everlook, Winterspring", "Bloodvenom Post, Felwood"));
            TaxiInfoList.Add(new TaxiInfo(307, "Bloodvenom Post, Felwood", "Everlook, Winterspring"));
            TaxiInfoList.Add(new TaxiInfo(308, "Freewind Post, Thousand Needles", "Gadgetzan, Tanaris"));
            TaxiInfoList.Add(new TaxiInfo(309, "Thunder Bluff, Mulgore", "Gadgetzan, Tanaris"));
            TaxiInfoList.Add(new TaxiInfo(310, "Gadgetzan, Tanaris", "Freewind Post, Thousand Needles"));
            TaxiInfoList.Add(new TaxiInfo(311, "Gadgetzan, Tanaris", "Thunder Bluff, Mulgore"));
            TaxiInfoList.Add(new TaxiInfo(312, "Dun Baldar, Alterac Valley", "Ironforge, Dun Morogh"));
            TaxiInfoList.Add(new TaxiInfo(313, "Frostwolf Keep, Alterac Valley", "Undercity, Tirisfal"));
            TaxiInfoList.Add(new TaxiInfo(314, "Ironforge, Dun Morogh", "Dun Baldar, Alterac Valley"));
            TaxiInfoList.Add(new TaxiInfo(315, "Nighthaven, Moonglade", "Rut'theran Village, Teldrassil"));
            TaxiInfoList.Add(new TaxiInfo(316, "Nighthaven, Moonglade", "Thunder Bluff, Mulgore"));
            TaxiInfoList.Add(new TaxiInfo(317, "Kargath, Badlands", "Stonard, Swamp of Sorrows"));
            TaxiInfoList.Add(new TaxiInfo(318, "Stonard, Swamp of Sorrows", "Kargath, Badlands"));
            TaxiInfoList.Add(new TaxiInfo(319, "Kargath, Badlands", "Hammerfall, Arathi"));
            TaxiInfoList.Add(new TaxiInfo(320, "Hammerfall, Arathi", "Kargath, Badlands"));
            TaxiInfoList.Add(new TaxiInfo(321, "Hammerfall, Arathi", "Tarren Mill, Hillsbrad"));
            TaxiInfoList.Add(new TaxiInfo(322, "Tarren Mill, Hillsbrad", "Hammerfall, Arathi"));
            TaxiInfoList.Add(new TaxiInfo(323, "Gadgetzan, Tanaris", "Thalanaar, Feralas"));
            TaxiInfoList.Add(new TaxiInfo(324, "Thalanaar, Feralas", "Gadgetzan, Tanaris"));
            TaxiInfoList.Add(new TaxiInfo(325, "Thalanaar, Feralas", "Feathermoon, Feralas"));
            TaxiInfoList.Add(new TaxiInfo(326, "Feathermoon, Feralas", "Thalanaar, Feralas"));
            TaxiInfoList.Add(new TaxiInfo(327, "Splintertree Post, Ashenvale", "Orgrimmar, Durotar"));
            TaxiInfoList.Add(new TaxiInfo(328, "Orgrimmar, Durotar", "Splintertree Post, Ashenvale"));
            TaxiInfoList.Add(new TaxiInfo(329, "Talrendis Point, Azshara", "Auberdine, Darkshore"));
            TaxiInfoList.Add(new TaxiInfo(330, "Auberdine, Darkshore", "Talrendis Point, Azshara"));
            TaxiInfoList.Add(new TaxiInfo(332, "Talrendis Point, Azshara", "Talonbranch Glade, Felwood"));
            TaxiInfoList.Add(new TaxiInfo(333, "Splintertree Post, Ashenvale", "Crossroads, The Barrens"));
            TaxiInfoList.Add(new TaxiInfo(334, "Crossroads, The Barrens", "Splintertree Post, Ashenvale"));
            TaxiInfoList.Add(new TaxiInfo(335, "Orgrimmar, Durotar", "Brackenwall Village, Dustwallow Marsh"));
            TaxiInfoList.Add(new TaxiInfo(336, "Brackenwall Village, Dustwallow Marsh", "Orgrimmar, Durotar"));
            TaxiInfoList.Add(new TaxiInfo(338, "Orgrimmar, Durotar", "Bloodvenom Post, Felwood"));
            TaxiInfoList.Add(new TaxiInfo(339, "Everlook, Winterspring", "Talonbranch Glade, Felwood"));
            TaxiInfoList.Add(new TaxiInfo(341, "Bloodvenom Post, Felwood", "Orgrimmar, Durotar"));
            TaxiInfoList.Add(new TaxiInfo(343, "Stonard, Swamp of Sorrows", "Grom'gol, Stranglethorn"));
            TaxiInfoList.Add(new TaxiInfo(344, "Grom'gol, Stranglethorn", "Stonard, Swamp of Sorrows"));
            TaxiInfoList.Add(new TaxiInfo(345, "Thunder Bluff, Mulgore", "Brackenwall Village, Dustwallow Marsh"));
            TaxiInfoList.Add(new TaxiInfo(346, "Chillwind Camp, Western Plaguelands", "Southshore, Hillsbrad"));
            TaxiInfoList.Add(new TaxiInfo(347, "Southshore, Hillsbrad", "Chillwind Camp, Western Plaguelands"));
            TaxiInfoList.Add(new TaxiInfo(348, "Brackenwall Village, Dustwallow Marsh", "Thunder Bluff, Mulgore"));
            TaxiInfoList.Add(new TaxiInfo(349, "Aerie Peak, The Hinterlands", "Light's Hope Chapel, Eastern Plaguelands"));
            TaxiInfoList.Add(new TaxiInfo(350, "Zoram'gar Outpost, Ashenvale", "Splintertree Post, Ashenvale"));
            TaxiInfoList.Add(new TaxiInfo(351, "Splintertree Post, Ashenvale", "Zoram'gar Outpost, Ashenvale"));
            TaxiInfoList.Add(new TaxiInfo(352, "Light's Hope Chapel, Eastern Plaguelands", "Aerie Peak, The Hinterlands"));
            TaxiInfoList.Add(new TaxiInfo(353, "Camp Mojache, Feralas", "Crossroads, The Barrens"));
            TaxiInfoList.Add(new TaxiInfo(354, "Crossroads, The Barrens", "Zoram'gar Outpost, Ashenvale"));
            TaxiInfoList.Add(new TaxiInfo(355, "Crossroads, The Barrens", "Camp Mojache, Feralas"));
            TaxiInfoList.Add(new TaxiInfo(356, "Shadowprey Village, Desolace", "Sun Rock Retreat, Stonetalon Mountains"));
            TaxiInfoList.Add(new TaxiInfo(357, "Undercity, Tirisfal", "Light's Hope Chapel, Eastern Plaguelands"));
            TaxiInfoList.Add(new TaxiInfo(358, "Sun Rock Retreat, Stonetalon Mountains", "Shadowprey Village, Desolace"));
            TaxiInfoList.Add(new TaxiInfo(359, "Light's Hope Chapel, Eastern Plaguelands", "Undercity, Tirisfal"));
            TaxiInfoList.Add(new TaxiInfo(360, "Crossroads, The Barrens", "Brackenwall Village, Dustwallow Marsh"));
            TaxiInfoList.Add(new TaxiInfo(361, "Grom'gol, Stranglethorn", "Kargath, Badlands"));
            TaxiInfoList.Add(new TaxiInfo(362, "Kargath, Badlands", "Grom'gol, Stranglethorn"));
            TaxiInfoList.Add(new TaxiInfo(363, "Everlook, Winterspring", "Moonglade"));
            TaxiInfoList.Add(new TaxiInfo(364, "Moonglade", "Bloodvenom Post, Felwood"));
            TaxiInfoList.Add(new TaxiInfo(365, "Bloodvenom Post, Felwood", "Moonglade"));
            TaxiInfoList.Add(new TaxiInfo(366, "Moonglade", "Everlook, Winterspring"));
            TaxiInfoList.Add(new TaxiInfo(367, "Moonglade", "Everlook, Winterspring"));
            TaxiInfoList.Add(new TaxiInfo(368, "Moonglade", "Auberdine, Darkshore"));
            TaxiInfoList.Add(new TaxiInfo(369, "Talonbranch Glade, Felwood", "Auberdine, Darkshore"));
            TaxiInfoList.Add(new TaxiInfo(371, "Talonbranch Glade, Felwood", "Everlook, Winterspring"));
            TaxiInfoList.Add(new TaxiInfo(372, "Talonbranch Glade, Felwood", "Talrendis Point, Azshara"));
            TaxiInfoList.Add(new TaxiInfo(373, "Nijel's Point, Desolace", "Feathermoon, Feralas"));
            TaxiInfoList.Add(new TaxiInfo(374, "Feathermoon, Feralas", "Nijel's Point, Desolace"));
            TaxiInfoList.Add(new TaxiInfo(375, "Camp Mojache, Feralas", "Shadowprey Village, Desolace"));
            TaxiInfoList.Add(new TaxiInfo(376, "Shadowprey Village, Desolace", "Camp Mojache, Feralas"));
            TaxiInfoList.Add(new TaxiInfo(377, "Flame Crest, Burning Steppes", "Kargath, Badlands"));
            TaxiInfoList.Add(new TaxiInfo(378, "Kargath, Badlands", "Flame Crest, Burning Steppes"));
            TaxiInfoList.Add(new TaxiInfo(379, "Flame Crest, Burning Steppes", "Stonard, Swamp of Sorrows"));
            TaxiInfoList.Add(new TaxiInfo(380, "Stonard, Swamp of Sorrows", "Flame Crest, Burning Steppes"));
            TaxiInfoList.Add(new TaxiInfo(381, "Morgan's Vigil, Burning Steppes", "Nethergarde Keep, Blasted Lands"));
            TaxiInfoList.Add(new TaxiInfo(382, "Nethergarde Keep, Blasted Lands", "Morgan's Vigil, Burning Steppes"));
            TaxiInfoList.Add(new TaxiInfo(383, "Undercity, Tirisfal", "Frostwolf Keep, Alterac Valley"));
            TaxiInfoList.Add(new TaxiInfo(384, "Nijel's Point, Desolace", "Auberdine, Darkshore"));
            TaxiInfoList.Add(new TaxiInfo(385, "Auberdine, Darkshore", "Nijel's Point, Desolace"));
            TaxiInfoList.Add(new TaxiInfo(386, "Auberdine, Darkshore", "Talonbranch Glade, Felwood"));
            TaxiInfoList.Add(new TaxiInfo(387, "Thunder Bluff, Mulgore", "Orgrimmar, Durotar"));
            TaxiInfoList.Add(new TaxiInfo(388, "Gadgetzan, Tanaris", "Brackenwall Village, Dustwallow Marsh"));
            TaxiInfoList.Add(new TaxiInfo(389, "Gadgetzan, Tanaris", "Camp Mojache, Feralas"));
            TaxiInfoList.Add(new TaxiInfo(390, "Brackenwall Village, Dustwallow Marsh", "Gadgetzan, Tanaris"));
            TaxiInfoList.Add(new TaxiInfo(391, "Camp Mojache, Feralas", "Gadgetzan, Tanaris"));
            TaxiInfoList.Add(new TaxiInfo(392, "Gadgetzan, Tanaris", "Crossroads, The Barrens"));
            TaxiInfoList.Add(new TaxiInfo(393, "Crossroads, The Barrens", "Gadgetzan, Tanaris"));
            TaxiInfoList.Add(new TaxiInfo(394, "Gadgetzan, Tanaris", "Cenarion Hold, Silithus"));
            TaxiInfoList.Add(new TaxiInfo(395, "Gadgetzan, Tanaris", "Cenarion Hold, Silithus"));
            TaxiInfoList.Add(new TaxiInfo(398, "Everlook, Winterspring", "Orgrimmar, Durotar"));
            TaxiInfoList.Add(new TaxiInfo(399, "Orgrimmar, Durotar", "Everlook, Winterspring"));
            TaxiInfoList.Add(new TaxiInfo(400, "Valormok, Azshara", "Bloodvenom Post, Felwood"));
            TaxiInfoList.Add(new TaxiInfo(401, "Bloodvenom Post, Felwood", "Valormok, Azshara"));
            TaxiInfoList.Add(new TaxiInfo(402, "Thorium Point, Searing Gorge", "Ironforge, Dun Morogh"));
            TaxiInfoList.Add(new TaxiInfo(404, "Ironforge, Dun Morogh", "Thorium Point, Searing Gorge"));
            TaxiInfoList.Add(new TaxiInfo(406, "Kargath, Badlands", "Thorium Point, Searing Gorge"));
            TaxiInfoList.Add(new TaxiInfo(407, "Thorium Point, Searing Gorge", "Kargath, Badlands"));
            TaxiInfoList.Add(new TaxiInfo(408, "Flame Crest, Burning Steppes", "Thorium Point, Searing Gorge"));
            TaxiInfoList.Add(new TaxiInfo(409, "Thorium Point, Searing Gorge", "Flame Crest, Burning Steppes"));
            TaxiInfoList.Add(new TaxiInfo(410, "Morgan's Vigil, Burning Steppes", "Thorium Point, Searing Gorge"));
            TaxiInfoList.Add(new TaxiInfo(411, "Thorium Point, Searing Gorge", "Morgan's Vigil, Burning Steppes"));
            TaxiInfoList.Add(new TaxiInfo(412, "Revantusk Village, The Hinterlands", "Tarren Mill, Hillsbrad"));
            TaxiInfoList.Add(new TaxiInfo(413, "Tarren Mill, Hillsbrad", "Revantusk Village, The Hinterlands"));
            TaxiInfoList.Add(new TaxiInfo(414, "Undercity, Tirisfal", "Revantusk Village, The Hinterlands"));
            TaxiInfoList.Add(new TaxiInfo(415, "Revantusk Village, The Hinterlands", "Undercity, Tirisfal"));
            TaxiInfoList.Add(new TaxiInfo(416, "Camp Taurajo, The Barrens", "Crossroads, The Barrens"));
            TaxiInfoList.Add(new TaxiInfo(417, "Crossroads, The Barrens", "Camp Taurajo, The Barrens"));
            TaxiInfoList.Add(new TaxiInfo(419, "Thunder Bluff, Mulgore", "Camp Taurajo, The Barrens"));
            TaxiInfoList.Add(new TaxiInfo(420, "Camp Taurajo, The Barrens", "Thunder Bluff, Mulgore"));
            TaxiInfoList.Add(new TaxiInfo(421, "Camp Taurajo, The Barrens", "Freewind Post, Thousand Needles"));
            TaxiInfoList.Add(new TaxiInfo(422, "Freewind Post, Thousand Needles", "Camp Taurajo, The Barrens"));
            TaxiInfoList.Add(new TaxiInfo(423, "Cenarion Hold, Silithus", "Gadgetzan, Tanaris"));
            TaxiInfoList.Add(new TaxiInfo(424, "Cenarion Hold, Silithus", "Gadgetzan, Tanaris"));
            TaxiInfoList.Add(new TaxiInfo(425, "Morgan's Vigil, Burning Steppes", "Stormwind, Elwynn"));
            TaxiInfoList.Add(new TaxiInfo(427, "Stormwind, Elwynn", "Morgan's Vigil, Burning Steppes"));
            TaxiInfoList.Add(new TaxiInfo(428, "Ironforge, Dun Morogh", "Chillwind Camp, Western Plaguelands"));
            TaxiInfoList.Add(new TaxiInfo(429, "Chillwind Camp, Western Plaguelands", "Ironforge, Dun Morogh"));
            TaxiInfoList.Add(new TaxiInfo(431, "Chillwind Camp, Western Plaguelands", "Light's Hope Chapel, Eastern Plaguelands"));
            TaxiInfoList.Add(new TaxiInfo(432, "Light's Hope Chapel, Eastern Plaguelands", "Chillwind Camp, Western Plaguelands"));
            TaxiInfoList.Add(new TaxiInfo(436, "Naxxramas", "Generic, World target for Zeppelin Paths"));
            TaxiInfoList.Add(new TaxiInfo(437, "Light's Hope Chapel, Eastern Plaguelands", "Ironforge, Dun Morogh"));
            TaxiInfoList.Add(new TaxiInfo(438, "Ironforge, Dun Morogh", "Light's Hope Chapel, Eastern Plaguelands"));
            TaxiInfoList.Add(new TaxiInfo(439, "Generic, World target", "Generic, World target for Zeppelin Paths"));
            TaxiInfoList.Add(new TaxiInfo(440, "The Sepulcher, Silverpine Forest", "Tarren Mill, Hillsbrad"));
            TaxiInfoList.Add(new TaxiInfo(441, "Tarren Mill, Hillsbrad", "The Sepulcher, Silverpine Forest"));
            TaxiInfoList.Add(new TaxiInfo(443, "Astranaar, Ashenvale", "Stonetalon Peak, Stonetalon Mountains"));
            TaxiInfoList.Add(new TaxiInfo(444, "Stonetalon Peak, Stonetalon Mountains", "Astranaar, Ashenvale"));
            TaxiInfoList.Add(new TaxiInfo(445, "Theramore, Dustwallow Marsh", "Talrendis Point, Azshara"));
            TaxiInfoList.Add(new TaxiInfo(446, "Talrendis Point, Azshara", "Theramore, Dustwallow Marsh"));
            TaxiInfoList.Add(new TaxiInfo(447, "Talrendis Point, Azshara", "Everlook, Winterspring"));
            TaxiInfoList.Add(new TaxiInfo(448, "Everlook, Winterspring", "Talrendis Point, Azshara"));
            TaxiInfoList.Add(new TaxiInfo(449, "Cenarion Hold, Silithus", "Camp Mojache, Feralas"));
            TaxiInfoList.Add(new TaxiInfo(450, "Camp Mojache, Feralas", "Cenarion Hold, Silithus"));
            TaxiInfoList.Add(new TaxiInfo(451, "Cenarion Hold, Silithus", "Feathermoon, Feralas"));
            TaxiInfoList.Add(new TaxiInfo(452, "Marshal's Refuge, Un'Goro Crater", "Gadgetzan, Tanaris"));
            TaxiInfoList.Add(new TaxiInfo(453, "Marshal's Refuge, Un'Goro Crater", "Gadgetzan, Tanaris"));
            TaxiInfoList.Add(new TaxiInfo(454, "Marshal's Refuge, Un'Goro Crater", "Cenarion Hold, Silithus"));
            TaxiInfoList.Add(new TaxiInfo(455, "Marshal's Refuge, Un'Goro Crater", "Cenarion Hold, Silithus"));
            TaxiInfoList.Add(new TaxiInfo(456, "Cenarion Hold, Silithus", "Marshal's Refuge, Un'Goro Crater"));
            TaxiInfoList.Add(new TaxiInfo(457, "Cenarion Hold, Silithus", "Marshal's Refuge, Un'Goro Crater"));
            TaxiInfoList.Add(new TaxiInfo(458, "Gadgetzan, Tanaris", "Marshal's Refuge, Un'Goro Crater"));
            TaxiInfoList.Add(new TaxiInfo(459, "Gadgetzan, Tanaris", "Marshal's Refuge, Un'Goro Crater"));
            TaxiInfoList.Add(new TaxiInfo(460, "Ratchet, The Barrens", "Theramore, Dustwallow Marsh"));
            TaxiInfoList.Add(new TaxiInfo(461, "Ratchet, The Barrens", "Crossroads, The Barrens"));
            TaxiInfoList.Add(new TaxiInfo(462, "Crossroads, The Barrens", "Ratchet, The Barrens"));
            TaxiInfoList.Add(new TaxiInfo(464, "Theramore, Dustwallow Marsh", "Ratchet, The Barrens"));
            TaxiInfoList.Add(new TaxiInfo(465, "Talrendis Point, Azshara", "Ratchet, The Barrens"));
            TaxiInfoList.Add(new TaxiInfo(466, "Ratchet, The Barrens", "Talrendis Point, Azshara"));
            TaxiInfoList.Add(new TaxiInfo(467, "Astranaar, Ashenvale", "Talrendis Point, Azshara"));
            TaxiInfoList.Add(new TaxiInfo(468, "Talrendis Point, Azshara", "Astranaar, Ashenvale"));
            TaxiInfoList.Add(new TaxiInfo(469, "Lakeshire, Redridge", "Morgan's Vigil, Burning Steppes"));
            TaxiInfoList.Add(new TaxiInfo(470, "Morgan's Vigil, Burning Steppes", "Lakeshire, Redridge"));
            TaxiInfoList.Add(new TaxiInfo(471, "Feathermoon, Feralas", "Cenarion Hold, Silithus"));
            TaxiInfoList.Add(new TaxiInfo(472, "Filming", "Generic, World target for Zeppelin Paths"));
            TaxiInfoList.Add(new TaxiInfo(473, "Revantusk Village, The Hinterlands", "Light's Hope Chapel, Eastern Plaguelands"));
            TaxiInfoList.Add(new TaxiInfo(474, "Light's Hope Chapel, Eastern Plaguelands", "Revantusk Village, The Hinterlands"));
            TaxiInfoList.Add(new TaxiInfo(475, "Aerie Peak, The Hinterlands", "Chillwind Camp, Western Plaguelands"));
            TaxiInfoList.Add(new TaxiInfo(476, "Chillwind Camp, Western Plaguelands", "Aerie Peak, The Hinterlands"));
            TaxiInfoList.Add(new TaxiInfo(477, "Nijel's Point, Desolace", "Stonetalon Peak, Stonetalon Mountains"));
            TaxiInfoList.Add(new TaxiInfo(478, "Stonetalon Peak, Stonetalon Mountains", "Nijel's Point, Desolace"));
            TaxiInfoList.Add(new TaxiInfo(479, "Moonglade", "Talonbranch Glade, Felwood"));
            TaxiInfoList.Add(new TaxiInfo(480, "Talonbranch Glade, Felwood", "Moonglade"));
            TaxiInfoList.Add(new TaxiInfo(481, "Splintertree Post, Ashenvale", "Valormok, Azshara"));
            TaxiInfoList.Add(new TaxiInfo(482, "Valormok, Azshara", "Splintertree Post, Ashenvale"));
            TaxiInfoList.Add(new TaxiInfo(484, "Hammerfall, Arathi", "Revantusk Village, The Hinterlands"));
            TaxiInfoList.Add(new TaxiInfo(485, "Revantusk Village, The Hinterlands", "Hammerfall, Arathi"));
            TaxiInfoList.Add(new TaxiInfo(486, "Camp Mojache, Feralas", "Freewind Post, Thousand Needles"));
            TaxiInfoList.Add(new TaxiInfo(487, "Freewind Post, Thousand Needles", "Camp Mojache, Feralas"));
            TaxiInfoList.Add(new TaxiInfo(494, "Plaguewood Tower, Eastern Plaguelands", "Northpass Tower, Eastern Plaguelands"));
            TaxiInfoList.Add(new TaxiInfo(495, "Plaguewood Tower, Eastern Plaguelands", "Eastwall Tower, Eastern Plaguelands"));
            TaxiInfoList.Add(new TaxiInfo(496, "Plaguewood Tower, Eastern Plaguelands", "Crown Guard Tower, Eastern Plaguelands"));
            TaxiInfoList.Add(new TaxiInfo(499, "Everlook, Winterspring", "Valormok, Azshara"));
            TaxiInfoList.Add(new TaxiInfo(500, "Valormok, Azshara", "Everlook, Winterspring"));

            // Add condition names.
            ConditionNamesList.Add(new ComboboxPair("NOT", -3));
            ConditionNamesList.Add(new ComboboxPair("OR", -2));
            ConditionNamesList.Add(new ComboboxPair("AND", -1));
            ConditionNamesList.Add(new ComboboxPair("NONE", 0));
            ConditionNamesList.Add(new ComboboxPair("AURA", 1));
            ConditionNamesList.Add(new ComboboxPair("ITEM", 2));
            ConditionNamesList.Add(new ComboboxPair("ITEM_EQUIPPED", 3));
            ConditionNamesList.Add(new ComboboxPair("AREAID", 4));
            ConditionNamesList.Add(new ComboboxPair("REPUTATION_RANK_MIN", 5));
            ConditionNamesList.Add(new ComboboxPair("TEAM", 6));
            ConditionNamesList.Add(new ComboboxPair("SKILL", 7));
            ConditionNamesList.Add(new ComboboxPair("QUESTREWARDED", 8));
            ConditionNamesList.Add(new ComboboxPair("QUESTTAKEN", 9));
            ConditionNamesList.Add(new ComboboxPair("AD_COMMISSION_AURA", 10));
            ConditionNamesList.Add(new ComboboxPair("WAR_EFFORT_STAGE", 11));
            ConditionNamesList.Add(new ComboboxPair("ACTIVE_GAME_EVENT", 12));
            ConditionNamesList.Add(new ComboboxPair("AREA_FLAG", 13));
            ConditionNamesList.Add(new ComboboxPair("RACE_CLASS", 14));
            ConditionNamesList.Add(new ComboboxPair("LEVEL", 15));
            ConditionNamesList.Add(new ComboboxPair("SOURCE_ENTRY", 16));
            ConditionNamesList.Add(new ComboboxPair("SPELL", 17));
            ConditionNamesList.Add(new ComboboxPair("INSTANCE_SCRIPT", 18));
            ConditionNamesList.Add(new ComboboxPair("QUESTAVAILABLE", 19));
            ConditionNamesList.Add(new ComboboxPair("NEARBY_CREATURE", 20));
            ConditionNamesList.Add(new ComboboxPair("NEARBY_GAMEOBJECT", 21));
            ConditionNamesList.Add(new ComboboxPair("QUEST_NONE", 22));
            ConditionNamesList.Add(new ComboboxPair("ITEM_WITH_BANK", 23));
            ConditionNamesList.Add(new ComboboxPair("WOW_PATCH", 24));
            ConditionNamesList.Add(new ComboboxPair("DEAD_OR_AWAY", 25));
            ConditionNamesList.Add(new ComboboxPair("ACTIVE_HOLIDAY", 26));
            ConditionNamesList.Add(new ComboboxPair("TARGET_GENDER", 27));
            ConditionNamesList.Add(new ComboboxPair("LEARNABLE_ABILITY", 28));
            ConditionNamesList.Add(new ComboboxPair("SKILL_BELOW", 29));
            ConditionNamesList.Add(new ComboboxPair("REPUTATION_RANK_MAX", 30));
            ConditionNamesList.Add(new ComboboxPair("HAS_FLAG", 31));
            ConditionNamesList.Add(new ComboboxPair("LAST_WAYPOINT", 32));
            ConditionNamesList.Add(new ComboboxPair("MAP_ID", 33));
            ConditionNamesList.Add(new ComboboxPair("INSTANCE_DATA", 34));
            ConditionNamesList.Add(new ComboboxPair("MAP_EVENT_DATA", 35));
            ConditionNamesList.Add(new ComboboxPair("MAP_EVENT_ACTIVE", 36));
            ConditionNamesList.Add(new ComboboxPair("LINE_OF_SIGHT", 37));
            ConditionNamesList.Add(new ComboboxPair("DISTANCE", 38));
            ConditionNamesList.Add(new ComboboxPair("IS_MOVING", 39));
            ConditionNamesList.Add(new ComboboxPair("HAS_PET", 40));
            ConditionNamesList.Add(new ComboboxPair("HEALTH_PERCENT", 41));
            ConditionNamesList.Add(new ComboboxPair("MANA_PERCENT", 42));
            ConditionNamesList.Add(new ComboboxPair("IS_IN_COMBAT", 43));
            ConditionNamesList.Add(new ComboboxPair("IS_HOSTILE_TO", 44));
            ConditionNamesList.Add(new ComboboxPair("IS_IN_GROUP", 45));
            ConditionNamesList.Add(new ComboboxPair("IS_ALIVE", 46));
            ConditionNamesList.Add(new ComboboxPair("MAP_EVENT_TARGETS", 47));
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
        public uint SpellsTemplate;
        public string Name;
        public CreatureInfo(uint id, uint minlevel, uint maxlevel, uint rank, uint spellstemplate, string name)
        {
            ID = id;
            Name = name;
            MinLevel = minlevel;
            MaxLevel = maxlevel;
            Rank = rank;
            SpellsTemplate = spellstemplate;
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
        public uint InventoryType;
        public uint DisplayId;
        public string Name;
        public ItemInfo(uint id, uint requiredlevel, uint itemlevel, uint inventorytype, uint displayid, string name)
        {
            ID = id;
            Name = name;
            RequiredLevel = requiredlevel;
            ItemLevel = itemlevel;
            InventoryType = inventorytype;
            DisplayId = displayid;
        }
        public bool IsHoldable()
        {
            switch (InventoryType)
            {
                case 13: // Weapon
                case 14: // Shield
                case 15: // Ranged
                case 17: // 2H Weapon
                case 21: // Main Hand
                case 22: // Off Hand
                case 23: // Holdable
                case 25: // Thrown
                case 26: // Light Ranged
                    return true;
            }
            return false;
        }
    }
    public struct TaxiInfo
    {
        public uint ID;
        public string Source;
        public string Destination;
        public TaxiInfo(uint id, string source, string destination)
        {
            ID = id;
            Source = source;
            Destination = destination;
        }
    }
    public struct ConditionInfo
    {
        public uint ID;
        public int Type;
        public uint Value1;
        public uint Value2;
        public uint Value3;
        public uint Value4;
        public uint Flags;
        public ConditionInfo(uint id, int type, uint value1, uint value2, uint value3, uint value4, uint flags)
        {
            ID = id;
            Type = type;
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Flags = flags;
        }
    }
    public struct AreaInfo
    {
        public uint ID;
        public uint Map;
        public uint Zone;
        public string Name;
        public AreaInfo(uint id, uint map, uint zone, string name)
        {
            ID = id;
            Map = map;
            Zone = zone;
            Name = name;
        }
    }
    public struct SoundInfo
    {
        public uint ID;
        public string Name;
        public SoundInfo(uint id, string name)
        {
            ID = id;
            Name = name;
        }
    }
    public struct FactionInfo
    {
        public uint ID;
        public string Name;
        public string Description;
        public FactionInfo(uint id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
    }
    public struct FactionTemplateInfo
    {
        public uint ID;
        public uint FactionId;
        public uint Flags;
        public FactionTemplateInfo(uint id, uint factionid, uint flags)
        {
            ID = id;
            FactionId = factionid;
            Flags = flags;
        }
    }
    public struct GameEventInfo
    {
        public uint ID;
        public uint Occurrence;
        public uint Length;
        public string Name;
        public uint PatchMin;
        public uint PatchMax;
        public GameEventInfo(uint id, uint occurrence, uint length, string name, uint patchmin, uint patchmax)
        {
            ID = id;
            Occurrence = occurrence;
            Length = length;
            Name = name;
            PatchMin = patchmin;
            PatchMax = patchmax;
        }
    }
    public struct GameObjectInfo
    {
        public uint ID;
        public uint Type;
        public uint DisplayId;
        public string Name;
        public GameObjectInfo(uint id, uint type, uint displayid, string name)
        {
            ID = id;
            Type = type;
            DisplayId = displayid;
            Name = name;
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
