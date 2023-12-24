﻿using System;
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
        public static readonly List<ConditionInfo> OriginalConditionInfoList = new List<ConditionInfo>();
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
        public static readonly List<ComboboxPair> SkillsList = new List<ComboboxPair>();
        public static readonly List<ComboboxPair> SpellEffectNamesList = new List<ComboboxPair>();
        public static readonly List<ComboboxPair> SpellAuraNamesList = new List<ComboboxPair>();
        public static readonly List<ComboboxPair> ReputationRankList = new List<ComboboxPair>();
        public static readonly List<ComboboxPair> TeamNamesList = new List<ComboboxPair>();
        public static readonly List<ComboboxPair> GenderNamesList = new List<ComboboxPair>();
        public static readonly List<ComboboxPair> LootStateNamesList = new List<ComboboxPair>();
        public static readonly List<ComboboxPair> GOStateNamesList = new List<ComboboxPair>();
        public static readonly List<ComboboxPair> ContentPatchesList = new List<ComboboxPair>();
        public static readonly List<Tuple<string, uint>> GameObjectFlagsList = new List<Tuple<string, uint>>();
        public static readonly List<Tuple<string, uint>> GameObjectDynFlagsList = new List<Tuple<string, uint>>();
        public static readonly List<Tuple<string, uint>> UnitFieldFlagsList = new List<Tuple<string, uint>>();
        public static readonly List<Tuple<string, uint>> UnitDynamicFlagsList = new List<Tuple<string, uint>>();
        public static readonly List<Tuple<string, uint>> UnitNpcFlagsList = new List<Tuple<string, uint>>();
        public static readonly List<Tuple<string, uint>> PlayerFlagsList = new List<Tuple<string, uint>>();
        public static readonly List<Tuple<string, uint>> SpellMechanicMaskList = new List<Tuple<string, uint>>();
        public static readonly List<Tuple<string, uint>> SpellAttributesList = new List<Tuple<string, uint>>();
        public static readonly List<Tuple<string, uint>> SpellAttributesExList = new List<Tuple<string, uint>>();
        public static readonly List<Tuple<string, uint>> SpellAttributesEx2List = new List<Tuple<string, uint>>();
        public static readonly List<Tuple<string, uint>> SpellAttributesEx3List = new List<Tuple<string, uint>>();
        public static readonly List<Tuple<string, uint>> SpellAttributesEx4List = new List<Tuple<string, uint>>();
        public static readonly List<Tuple<string, uint>> SpellProcFlagsList = new List<Tuple<string, uint>>();
        public static readonly List<Tuple<string, uint>> SpellProcFlagsExList = new List<Tuple<string, uint>>();

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
        public static string FindConditionTypeName(int type)
        {
            foreach (ComboboxPair condition in ConditionNamesList)
            {
                if (condition.Value == type)
                    return condition.Text;
            }

            return "";
        }
        public static ConditionInfo FindConditionWithId(uint id)
        {
            foreach (ConditionInfo condition in ConditionInfoList)
            {
                if (condition.ID == id)
                    return condition;
            }

            return null;
        }
        public static string FindConditionName(uint id)
        {
            ConditionInfo condition = FindConditionWithId(id);
            if (condition != null)
                return FindConditionTypeName(condition.Type);

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
        public static string FindCreatureSpellsListName(uint id)
        {
            foreach (CreatureSpellsInfo template in CreatureSpellsInfoList)
            {
                if (template.ID == id)
                    return template.Name;
            }

            return "";
        }
        public static string FindSpellEffectName(uint id)
        {
            foreach (ComboboxPair spell in SpellEffectNamesList)
            {
                if (spell.Value == id)
                    return spell.Text;
            }

            return "Effect " + id.ToString();
        }
        public static string FindSpellAuraName(uint id)
        {
            foreach (ComboboxPair spell in SpellAuraNamesList)
            {
                if (spell.Value == id)
                    return spell.Text;
            }

            return "Aura " + id.ToString();
        }
        public static int FindIndexOfSpellAuraName(uint id)
        {
            for (int i = 0; i < SpellAuraNamesList.Count; i++)
            {
                if (id == (uint)(SpellAuraNamesList[i] as ComboboxPair).Value)
                    return i;
            }
            return 0;
        }
        public static string FindReputationRankName(uint id)
        {
            foreach (ComboboxPair rank in ReputationRankList)
            {
                if (rank.Value == id)
                    return rank.Text;
            }

            return "Rank " + id.ToString();
        }
        public static string FindTeamName(uint id)
        {
            foreach (ComboboxPair team in TeamNamesList)
            {
                if (team.Value == id)
                    return team.Text;
            }

            return id.ToString();
        }
        public static string FindGenderName(uint id)
        {
            foreach (ComboboxPair gender in GenderNamesList)
            {
                if (gender.Value == id)
                    return gender.Text;
            }

            return id.ToString();
        }
        public static string FindLootStateName(uint id)
        {
            foreach (ComboboxPair state in LootStateNamesList)
            {
                if (state.Value == id)
                    return state.Text;
            }

            return id.ToString();
        }
        public static string FindGOStateName(uint id)
        {
            foreach (ComboboxPair state in GOStateNamesList)
            {
                if (state.Value == id)
                    return state.Text;
            }

            return id.ToString();
        }

        public static string FindContentPatchName(uint id)
        {
            foreach (ComboboxPair patch in ContentPatchesList)
            {
                if (patch.Value == id)
                    return patch.Text;
            }

            return id.ToString();
        }

        public static string GetRaceNamesFromMask(uint mask)
        {
            List<string> races = new List<string>();
            if ((mask & 1) != 0)
                races.Add("Human");
            if ((mask & 2) != 0)
                races.Add("Orc");
            if ((mask & 4) != 0)
                races.Add("Dwarf");
            if ((mask & 8) != 0)
                races.Add("Night Elf");
            if ((mask & 16) != 0)
                races.Add("Undead");
            if ((mask & 32) != 0)
                races.Add("Tauren");
            if ((mask & 64) != 0)
                races.Add("Gnome");
            if ((mask & 128) != 0)
                races.Add("Troll");

            if (races.Count > 0)
            {
                string return_string = "";
                for (int i = 0; i < races.Count; i++)
                {
                    if (i != 0)
                        return_string += ", ";
                    return_string += races[i];
                }
                return return_string;
            }

            return "-NONE-";
        }
        public static string GetClassNamesFromMask(uint mask)
        {
            List<string> classes = new List<string>();
            if ((mask & 1) != 0)
                classes.Add("Warrior");
            if ((mask & 2) != 0)
                classes.Add("Paladin");
            if ((mask & 4) != 0)
                classes.Add("Hunter");
            if ((mask & 8) != 0)
                classes.Add("Rogue");
            if ((mask & 16) != 0)
                classes.Add("Priest");
            if ((mask & 64) != 0)
                classes.Add("Shaman");
            if ((mask & 128) != 0)
                classes.Add("Mage");
            if ((mask & 256) != 0)
                classes.Add("Warlock");
            if ((mask & 1024) != 0)
                classes.Add("Druid");

            if (classes.Count > 0)
            {
                string return_string = "";
                for (int i = 0; i < classes.Count; i++)
                {
                    if (i != 0)
                        return_string += ", ";
                    return_string += classes[i];
                }
                return return_string;
            }

            return "-NONE-";
        }

        public static void LoadBroadcastTexts(string connString)
        {
            BroadcastTextsList.Clear();

            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT `entry`, `male_text`, `female_text`, `chat_type`, `language_id` FROM `broadcast_text` ORDER BY `entry`";
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
            command.CommandText = "SELECT `entry`, `MinLevel`, `QuestLevel`, `Title` FROM `quest_template` t1 WHERE `patch`=(SELECT max(`patch`) FROM `quest_template` t2 WHERE t1.`entry`=t2.`entry`) ORDER BY `entry`";
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
            command.CommandText = "SELECT `entry`, `level_min`, `level_max`, `rank`, `name`, `spell_list_id` FROM `creature_template` t1 WHERE `patch`=(SELECT max(`patch`) FROM `creature_template` t2 WHERE t1.`entry`=t2.`entry`) ORDER BY `entry`";
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
            command.CommandText = "SELECT * FROM `creature_spells` ORDER BY `entry`";
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
            command.CommandText = "SELECT `entry`, `effect1`, `effect2`, `effect3`, `name`, `description` FROM `spell_template` t1 WHERE `build`=(SELECT max(`build`) FROM `spell_template` t2 WHERE t1.`entry`=t2.`entry` && `build` <= 5875) ORDER BY `entry`";
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
            command.CommandText = "SELECT `entry`, `required_level`, `item_level`, `inventory_type`, `display_id`, `name` FROM `item_template` t1 WHERE `patch`=(SELECT max(`patch`) FROM `item_template` t2 WHERE t1.`entry`=t2.`entry`) ORDER BY `entry`";
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
            OriginalConditionInfoList.Clear();

            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT `condition_entry`, `type`, `value1`, `value2`, `value3`, `value4`, `flags` FROM `conditions` ORDER BY `condition_entry`";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add unsupported condition types to the list.
                    int conditionType = reader.GetInt32(1);
                    if (String.IsNullOrEmpty(FindConditionTypeName(conditionType)))
                        ConditionNamesList.Add(new ComboboxPair("UNKNOWN_" + conditionType.ToString(), conditionType));

                    // Add the new condition entry to the list.
                    ConditionInfoList.Add(new ConditionInfo(reader.GetUInt32(0), conditionType, reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetUInt32(6)));
                    OriginalConditionInfoList.Add(new ConditionInfo(reader.GetUInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetUInt32(6)));
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
            command.CommandText = "SELECT `entry`, `map_id`, `zone_id`, `name` FROM `area_template` ORDER BY `entry`";
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
            command.CommandText = "SELECT `id`, `name` FROM `sound_entries` ORDER BY `id`";
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
            command.CommandText = "SELECT `id`, `reputation_list_id`, `team`, `name`, `description` FROM `faction` t1 WHERE `build`=(SELECT max(`build`) FROM `faction` t2 WHERE t1.`id`=t2.`id` && `build` <= 5875) ORDER BY `id`";
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Add the new faction entry to the list.
                    FactionInfoList.Add(new FactionInfo(reader.GetUInt32(0), reader.GetInt32(1), reader.GetUInt32(2), reader.GetString(3), reader.GetString(4)));
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
            command.CommandText = "SELECT `id`, `faction_id`, `faction_flags` FROM `faction_template` t1 WHERE `build`=(SELECT max(`build`) FROM `faction_template` t2 WHERE t1.`id`=t2.`id` && `build` <= 5875) ORDER BY `id`";
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
            command.CommandText = "SELECT `entry`, `occurence`, `length`, `description`, `patch_min`, `patch_max` FROM `game_event` ORDER BY `entry`";
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
            MotionTypesList.Add(new ComboboxPair("CONFUSED_MOTION_TYPE", 5));
            MotionTypesList.Add(new ComboboxPair("CHASE_MOTION_TYPE", 6));
            MotionTypesList.Add(new ComboboxPair("HOME_MOTION_TYPE", 7));
            MotionTypesList.Add(new ComboboxPair("FLEEING_MOTION_TYPE", 10));
            MotionTypesList.Add(new ComboboxPair("DISTRACT_MOTION_TYPE", 11));
            MotionTypesList.Add(new ComboboxPair("FOLLOW_MOTION_TYPE", 15));
            MotionTypesList.Add(new ComboboxPair("CHARGE_MOTION_TYPE", 18));
            MotionTypesList.Add(new ComboboxPair("DISTANCING_MOTION_TYPE", 19));

            // Add all motion types to list.
            MotionTypesFullList.Add(new ComboboxPair("IDLE_MOTION_TYPE", 0));
            MotionTypesFullList.Add(new ComboboxPair("RANDOM_MOTION_TYPE", 1));
            MotionTypesFullList.Add(new ComboboxPair("WAYPOINT_MOTION_TYPE", 2));
            MotionTypesFullList.Add(new ComboboxPair("CYCLIC_MOTION_TYPE", 3));
            MotionTypesFullList.Add(new ComboboxPair("CONFUSED_MOTION_TYPE", 5));
            MotionTypesFullList.Add(new ComboboxPair("CHASE_MOTION_TYPE", 6));
            MotionTypesFullList.Add(new ComboboxPair("HOME_MOTION_TYPE", 7));
            MotionTypesFullList.Add(new ComboboxPair("FLIGHT_MOTION_TYPE", 8));
            MotionTypesFullList.Add(new ComboboxPair("POINT_MOTION_TYPE", 9));
            MotionTypesFullList.Add(new ComboboxPair("FLEEING_MOTION_TYPE", 10));
            MotionTypesFullList.Add(new ComboboxPair("DISTRACT_MOTION_TYPE", 11));
            MotionTypesFullList.Add(new ComboboxPair("ASSISTANCE_MOTION_TYPE", 12));
            MotionTypesFullList.Add(new ComboboxPair("ASSISTANCE_DISTRACT_MOTION_TYPE", 13));
            MotionTypesFullList.Add(new ComboboxPair("TIMED_FLEEING_MOTION_TYPE", 14));
            MotionTypesFullList.Add(new ComboboxPair("FOLLOW_MOTION_TYPE", 15));
            MotionTypesFullList.Add(new ComboboxPair("EFFECT_MOTION_TYPE", 16));
            MotionTypesFullList.Add(new ComboboxPair("PATROL_MOTION_TYPE", 17));
            MotionTypesFullList.Add(new ComboboxPair("CHARGE_MOTION_TYPE", 18));
            MotionTypesFullList.Add(new ComboboxPair("DISTANCING_MOTION_TYPE", 19));

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
            ConditionNamesList.Add(new ComboboxPair("SAVED_VARIABLE", 11));
            ConditionNamesList.Add(new ComboboxPair("ACTIVE_GAME_EVENT", 12));
            ConditionNamesList.Add(new ComboboxPair("CANT_PATH_TO_VICTIM", 13));
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
            ConditionNamesList.Add(new ComboboxPair("GENDER", 27));
            ConditionNamesList.Add(new ComboboxPair("IS_PLAYER", 28));
            ConditionNamesList.Add(new ComboboxPair("SKILL_BELOW", 29));
            ConditionNamesList.Add(new ComboboxPair("REPUTATION_RANK_MAX", 30));
            ConditionNamesList.Add(new ComboboxPair("HAS_FLAG", 31));
            ConditionNamesList.Add(new ComboboxPair("LAST_WAYPOINT", 32));
            ConditionNamesList.Add(new ComboboxPair("MAP_ID", 33));
            ConditionNamesList.Add(new ComboboxPair("INSTANCE_DATA", 34));
            ConditionNamesList.Add(new ComboboxPair("MAP_EVENT_DATA", 35));
            ConditionNamesList.Add(new ComboboxPair("MAP_EVENT_ACTIVE", 36));
            ConditionNamesList.Add(new ComboboxPair("LINE_OF_SIGHT", 37));
            ConditionNamesList.Add(new ComboboxPair("DISTANCE_TO_TARGET", 38));
            ConditionNamesList.Add(new ComboboxPair("IS_MOVING", 39));
            ConditionNamesList.Add(new ComboboxPair("HAS_PET", 40));
            ConditionNamesList.Add(new ComboboxPair("HEALTH_PERCENT", 41));
            ConditionNamesList.Add(new ComboboxPair("MANA_PERCENT", 42));
            ConditionNamesList.Add(new ComboboxPair("IS_IN_COMBAT", 43));
            ConditionNamesList.Add(new ComboboxPair("REACTION", 44));
            ConditionNamesList.Add(new ComboboxPair("IS_IN_GROUP", 45));
            ConditionNamesList.Add(new ComboboxPair("IS_ALIVE", 46));
            ConditionNamesList.Add(new ComboboxPair("MAP_EVENT_TARGETS", 47));
            ConditionNamesList.Add(new ComboboxPair("OBJECT_IS_SPAWNED", 48));
            ConditionNamesList.Add(new ComboboxPair("OBJECT_LOOT_STATE", 49));
            ConditionNamesList.Add(new ComboboxPair("OBJECT_FIT_CONDITION", 50));
            ConditionNamesList.Add(new ComboboxPair("PVP_RANK", 51));
            ConditionNamesList.Add(new ComboboxPair("DB_GUID", 52));
            ConditionNamesList.Add(new ComboboxPair("LOCAL_TIME", 53));
            ConditionNamesList.Add(new ComboboxPair("DISTANCE_TO_POSITION", 54));
            ConditionNamesList.Add(new ComboboxPair("OBJECT_GO_STATE", 55));
            ConditionNamesList.Add(new ComboboxPair("NEARBY_PLAYER", 56));
            ConditionNamesList.Add(new ComboboxPair("CREATURE_GROUP_MEMBER", 57));
            ConditionNamesList.Add(new ComboboxPair("CREATURE_GROUP_DEAD", 58));

            // Add skill names.
            SkillsList.Add(new ComboboxPair("Frost", 6));
            SkillsList.Add(new ComboboxPair("Fire", 8));
            SkillsList.Add(new ComboboxPair("Arms", 26));
            SkillsList.Add(new ComboboxPair("Combat", 38));
            SkillsList.Add(new ComboboxPair("Subtlety", 39));
            SkillsList.Add(new ComboboxPair("Poisons", 40));
            SkillsList.Add(new ComboboxPair("Swords", 43));
            SkillsList.Add(new ComboboxPair("Axes", 44));
            SkillsList.Add(new ComboboxPair("Bows", 45));
            SkillsList.Add(new ComboboxPair("Guns", 46));
            SkillsList.Add(new ComboboxPair("Beast Mastery", 50));
            SkillsList.Add(new ComboboxPair("Survival", 51));
            SkillsList.Add(new ComboboxPair("Maces", 54));
            SkillsList.Add(new ComboboxPair("Two-Handed Swords", 55));
            SkillsList.Add(new ComboboxPair("Holy", 56));
            SkillsList.Add(new ComboboxPair("Shadow Magic", 78));
            SkillsList.Add(new ComboboxPair("Defense", 95));
            SkillsList.Add(new ComboboxPair("Language: Common", 98));
            SkillsList.Add(new ComboboxPair("Dwarven Racial", 101));
            SkillsList.Add(new ComboboxPair("Language: Orcish", 109));
            SkillsList.Add(new ComboboxPair("Language: Dwarven", 111));
            SkillsList.Add(new ComboboxPair("Language: Darnassian", 113));
            SkillsList.Add(new ComboboxPair("Language: Taurahe", 115));
            SkillsList.Add(new ComboboxPair("Dual Wield", 118));
            SkillsList.Add(new ComboboxPair("Tauren Racial", 124));
            SkillsList.Add(new ComboboxPair("Orc Racial", 125));
            SkillsList.Add(new ComboboxPair("Night Elf Racial", 126));
            SkillsList.Add(new ComboboxPair("First Aid", 129));
            SkillsList.Add(new ComboboxPair("Feral Combat", 134));
            SkillsList.Add(new ComboboxPair("Staves", 136));
            SkillsList.Add(new ComboboxPair("Language: Thalassian", 137));
            SkillsList.Add(new ComboboxPair("Language: Draconic", 138));
            SkillsList.Add(new ComboboxPair("Language: Demon Tongue", 139));
            SkillsList.Add(new ComboboxPair("Language: Titan", 140));
            SkillsList.Add(new ComboboxPair("Language: Old Tongue", 141));
            SkillsList.Add(new ComboboxPair("Survival", 142));
            SkillsList.Add(new ComboboxPair("Horse Riding", 148));
            SkillsList.Add(new ComboboxPair("Wolf Riding", 149));
            SkillsList.Add(new ComboboxPair("Tiger Riding", 150));
            SkillsList.Add(new ComboboxPair("Ram Riding", 152));
            SkillsList.Add(new ComboboxPair("Swimming", 155));
            SkillsList.Add(new ComboboxPair("Two-Handed Maces", 160));
            SkillsList.Add(new ComboboxPair("Unarmed", 162));
            SkillsList.Add(new ComboboxPair("Marksmanship", 163));
            SkillsList.Add(new ComboboxPair("Blacksmithing", 164));
            SkillsList.Add(new ComboboxPair("Leatherworking", 165));
            SkillsList.Add(new ComboboxPair("Alchemy", 171));
            SkillsList.Add(new ComboboxPair("Two-Handed Axes", 172));
            SkillsList.Add(new ComboboxPair("Daggers", 173));
            SkillsList.Add(new ComboboxPair("Thrown", 176));
            SkillsList.Add(new ComboboxPair("Herbalism", 182));
            SkillsList.Add(new ComboboxPair("GENERIC (DND)", 183));
            SkillsList.Add(new ComboboxPair("Retribution", 184));
            SkillsList.Add(new ComboboxPair("Cooking", 185));
            SkillsList.Add(new ComboboxPair("Mining", 186));
            SkillsList.Add(new ComboboxPair("Pet - Imp", 188));
            SkillsList.Add(new ComboboxPair("Pet - Felhunter", 189));
            SkillsList.Add(new ComboboxPair("Tailoring", 197));
            SkillsList.Add(new ComboboxPair("Engineering", 202));
            SkillsList.Add(new ComboboxPair("Pet - Spider", 203));
            SkillsList.Add(new ComboboxPair("Pet - Voidwalker", 204));
            SkillsList.Add(new ComboboxPair("Pet - Succubus", 205));
            SkillsList.Add(new ComboboxPair("Pet - Infernal", 206));
            SkillsList.Add(new ComboboxPair("Pet - Doomguard", 207));
            SkillsList.Add(new ComboboxPair("Pet - Wolf", 208));
            SkillsList.Add(new ComboboxPair("Pet - Cat", 209));
            SkillsList.Add(new ComboboxPair("Pet - Bear", 210));
            SkillsList.Add(new ComboboxPair("Pet - Boar", 211));
            SkillsList.Add(new ComboboxPair("Pet - Crocilisk", 212));
            SkillsList.Add(new ComboboxPair("Pet - Carrion Bird", 213));
            SkillsList.Add(new ComboboxPair("Pet - Crab", 214));
            SkillsList.Add(new ComboboxPair("Pet - Gorilla", 215));
            SkillsList.Add(new ComboboxPair("Pet - Raptor", 217));
            SkillsList.Add(new ComboboxPair("Pet - Tallstrider", 218));
            SkillsList.Add(new ComboboxPair("Racial - Undead", 220));
            SkillsList.Add(new ComboboxPair("Crossbows", 226));
            SkillsList.Add(new ComboboxPair("Wands", 228));
            SkillsList.Add(new ComboboxPair("Polearms", 229));
            SkillsList.Add(new ComboboxPair("Pet - Scorpid", 236));
            SkillsList.Add(new ComboboxPair("Arcane", 237));
            SkillsList.Add(new ComboboxPair("Pet - Turtle", 251));
            SkillsList.Add(new ComboboxPair("Assassination", 253));
            SkillsList.Add(new ComboboxPair("Fury", 256));
            SkillsList.Add(new ComboboxPair("Protection", 257));
            SkillsList.Add(new ComboboxPair("Beast Training", 261));
            SkillsList.Add(new ComboboxPair("Protection", 267));
            SkillsList.Add(new ComboboxPair("Pet - Generic", 270));
            SkillsList.Add(new ComboboxPair("Plate Mail", 293));
            SkillsList.Add(new ComboboxPair("Language: Gnomish", 313));
            SkillsList.Add(new ComboboxPair("Language: Troll", 315));
            SkillsList.Add(new ComboboxPair("Enchanting", 333));
            SkillsList.Add(new ComboboxPair("Demonology", 354));
            SkillsList.Add(new ComboboxPair("Affliction", 355));
            SkillsList.Add(new ComboboxPair("Fishing", 356));
            SkillsList.Add(new ComboboxPair("Enhancement", 373));
            SkillsList.Add(new ComboboxPair("Restoration", 374));
            SkillsList.Add(new ComboboxPair("Elemental Combat", 375));
            SkillsList.Add(new ComboboxPair("Skinning", 393));
            SkillsList.Add(new ComboboxPair("Mail", 413));
            SkillsList.Add(new ComboboxPair("Leather", 414));
            SkillsList.Add(new ComboboxPair("Cloth", 415));
            SkillsList.Add(new ComboboxPair("Shield", 433));
            SkillsList.Add(new ComboboxPair("Fist Weapons", 473));
            SkillsList.Add(new ComboboxPair("Raptor Riding", 533));
            SkillsList.Add(new ComboboxPair("Mechanostrider Piloting", 553));
            SkillsList.Add(new ComboboxPair("Undead Horsemanship", 554));
            SkillsList.Add(new ComboboxPair("Restoration", 573));
            SkillsList.Add(new ComboboxPair("Balance", 574));
            SkillsList.Add(new ComboboxPair("Destruction", 593));
            SkillsList.Add(new ComboboxPair("Holy", 594));
            SkillsList.Add(new ComboboxPair("Discipline", 613));
            SkillsList.Add(new ComboboxPair("Lockpicking", 633));
            SkillsList.Add(new ComboboxPair("Pet - Bat", 653));
            SkillsList.Add(new ComboboxPair("Pet - Hyena", 654));
            SkillsList.Add(new ComboboxPair("Pet - Owl", 655));
            SkillsList.Add(new ComboboxPair("Pet - Wind Serpent", 656));
            SkillsList.Add(new ComboboxPair("Language: Gutterspeak", 673));
            SkillsList.Add(new ComboboxPair("Kodo Riding", 713));
            SkillsList.Add(new ComboboxPair("Racial - Troll", 733));
            SkillsList.Add(new ComboboxPair("Racial - Gnome", 753));
            SkillsList.Add(new ComboboxPair("Racial - Human", 754));
            SkillsList.Add(new ComboboxPair("Pet - Event - Remote Control", 758));
            SkillsList.Add(new ComboboxPair("Riding", 762));

            // Add spell effect names.
            SpellEffectNamesList.Add(new ComboboxPair("None", 0));
            SpellEffectNamesList.Add(new ComboboxPair("Instakill", 1));
            SpellEffectNamesList.Add(new ComboboxPair("School Damage", 2));
            SpellEffectNamesList.Add(new ComboboxPair("Dummy", 3));
            SpellEffectNamesList.Add(new ComboboxPair("Portal Teleport", 4));
            SpellEffectNamesList.Add(new ComboboxPair("Teleport Units", 5));
            SpellEffectNamesList.Add(new ComboboxPair("Apply Aura", 6));
            SpellEffectNamesList.Add(new ComboboxPair("Environmental Damage", 7));
            SpellEffectNamesList.Add(new ComboboxPair("Power Drain", 8));
            SpellEffectNamesList.Add(new ComboboxPair("Health Leech", 9));
            SpellEffectNamesList.Add(new ComboboxPair("Heal", 10));
            SpellEffectNamesList.Add(new ComboboxPair("Bind", 11));
            SpellEffectNamesList.Add(new ComboboxPair("Portal", 12));
            SpellEffectNamesList.Add(new ComboboxPair("Ritual Base", 13));
            SpellEffectNamesList.Add(new ComboboxPair("Ritual Specialize", 14));
            SpellEffectNamesList.Add(new ComboboxPair("Ritual Activate Portal", 15));
            SpellEffectNamesList.Add(new ComboboxPair("Quest Complete", 16));
            SpellEffectNamesList.Add(new ComboboxPair("Weapon Damage + (noschool)", 17));
            SpellEffectNamesList.Add(new ComboboxPair("Resurrect", 18));
            SpellEffectNamesList.Add(new ComboboxPair("Extra Attacks", 19));
            SpellEffectNamesList.Add(new ComboboxPair("Dodge", 20));
            SpellEffectNamesList.Add(new ComboboxPair("Evade", 21));
            SpellEffectNamesList.Add(new ComboboxPair("Parry", 22));
            SpellEffectNamesList.Add(new ComboboxPair("Block", 23));
            SpellEffectNamesList.Add(new ComboboxPair("Create Item", 24));
            SpellEffectNamesList.Add(new ComboboxPair("Weapon", 25));
            SpellEffectNamesList.Add(new ComboboxPair("Defense", 26));
            SpellEffectNamesList.Add(new ComboboxPair("Persistent Area Aura", 27));
            SpellEffectNamesList.Add(new ComboboxPair("Summon", 28));
            SpellEffectNamesList.Add(new ComboboxPair("Leap", 29));
            SpellEffectNamesList.Add(new ComboboxPair("Energize", 30));
            SpellEffectNamesList.Add(new ComboboxPair("Weapon % Dmg", 31));
            SpellEffectNamesList.Add(new ComboboxPair("Trigger Missile", 32));
            SpellEffectNamesList.Add(new ComboboxPair("Open Lock", 33));
            SpellEffectNamesList.Add(new ComboboxPair("Apply Area Aura", 35));
            SpellEffectNamesList.Add(new ComboboxPair("Learn Spell", 36));
            SpellEffectNamesList.Add(new ComboboxPair("Spell Defense", 37));
            SpellEffectNamesList.Add(new ComboboxPair("Dispel", 38));
            SpellEffectNamesList.Add(new ComboboxPair("Language", 39));
            SpellEffectNamesList.Add(new ComboboxPair("Dual Wield", 40));
            SpellEffectNamesList.Add(new ComboboxPair("Summon Wild", 41));
            SpellEffectNamesList.Add(new ComboboxPair("Summon Guardian", 42));
            SpellEffectNamesList.Add(new ComboboxPair("Teleport Units (Face Caster)", 43));
            SpellEffectNamesList.Add(new ComboboxPair("Skill Step", 44));
            SpellEffectNamesList.Add(new ComboboxPair("Add Honor", 45));
            SpellEffectNamesList.Add(new ComboboxPair("Spawn", 46));
            SpellEffectNamesList.Add(new ComboboxPair("Spell Cast UI", 47));
            SpellEffectNamesList.Add(new ComboboxPair("Stealth", 48));
            SpellEffectNamesList.Add(new ComboboxPair("Detect", 49));
            SpellEffectNamesList.Add(new ComboboxPair("Summon Object", 50));
            SpellEffectNamesList.Add(new ComboboxPair("Force Critical Hit", 51));
            SpellEffectNamesList.Add(new ComboboxPair("Guarantee Hit", 52));
            SpellEffectNamesList.Add(new ComboboxPair("Enchant Item Permanent", 53));
            SpellEffectNamesList.Add(new ComboboxPair("Enchant Item Temporary", 54));
            SpellEffectNamesList.Add(new ComboboxPair("Tame Creature", 55));
            SpellEffectNamesList.Add(new ComboboxPair("Summon Pet", 56));
            SpellEffectNamesList.Add(new ComboboxPair("Learn Pet Spell", 57));
            SpellEffectNamesList.Add(new ComboboxPair("Weapon Damage +", 58));
            SpellEffectNamesList.Add(new ComboboxPair("Open Lock (Item)", 59));
            SpellEffectNamesList.Add(new ComboboxPair("Proficiency", 60));
            SpellEffectNamesList.Add(new ComboboxPair("Send Event", 61));
            SpellEffectNamesList.Add(new ComboboxPair("Power Burn", 62));
            SpellEffectNamesList.Add(new ComboboxPair("Threat", 63));
            SpellEffectNamesList.Add(new ComboboxPair("Trigger Spell", 64));
            SpellEffectNamesList.Add(new ComboboxPair("Health Funnel", 65));
            SpellEffectNamesList.Add(new ComboboxPair("Power Funnel", 66));
            SpellEffectNamesList.Add(new ComboboxPair("Heal Max Health", 67));
            SpellEffectNamesList.Add(new ComboboxPair("Interrupt Cast", 68));
            SpellEffectNamesList.Add(new ComboboxPair("Distract", 69));
            SpellEffectNamesList.Add(new ComboboxPair("Pull", 70));
            SpellEffectNamesList.Add(new ComboboxPair("Pickpocket", 71));
            SpellEffectNamesList.Add(new ComboboxPair("Add Farsight", 72));
            SpellEffectNamesList.Add(new ComboboxPair("Summon Possessed", 73));
            SpellEffectNamesList.Add(new ComboboxPair("Summon Totem", 74));
            SpellEffectNamesList.Add(new ComboboxPair("Heal Mechanical", 75));
            SpellEffectNamesList.Add(new ComboboxPair("Summon Object (Wild)", 76));
            SpellEffectNamesList.Add(new ComboboxPair("Script Effect", 77));
            SpellEffectNamesList.Add(new ComboboxPair("Attack", 78));
            SpellEffectNamesList.Add(new ComboboxPair("Sanctuary", 79));
            SpellEffectNamesList.Add(new ComboboxPair("Add Combo Points", 80));
            SpellEffectNamesList.Add(new ComboboxPair("Create House", 81));
            SpellEffectNamesList.Add(new ComboboxPair("Bind Sight", 82));
            SpellEffectNamesList.Add(new ComboboxPair("Duel", 83));
            SpellEffectNamesList.Add(new ComboboxPair("Stuck", 84));
            SpellEffectNamesList.Add(new ComboboxPair("Summon Player", 85));
            SpellEffectNamesList.Add(new ComboboxPair("Activate Object", 86));
            SpellEffectNamesList.Add(new ComboboxPair("Summon Totem (slot 1)", 87));
            SpellEffectNamesList.Add(new ComboboxPair("Summon Totem (slot 2)", 88));
            SpellEffectNamesList.Add(new ComboboxPair("Summon Totem (slot 3)", 89));
            SpellEffectNamesList.Add(new ComboboxPair("Summon Totem (slot 4)", 90));
            SpellEffectNamesList.Add(new ComboboxPair("Threat (All)", 91));
            SpellEffectNamesList.Add(new ComboboxPair("Enchant Held Item", 92));
            SpellEffectNamesList.Add(new ComboboxPair("Summon Phantasm", 93));
            SpellEffectNamesList.Add(new ComboboxPair("Self Resurrect", 94));
            SpellEffectNamesList.Add(new ComboboxPair("Skinning", 95));
            SpellEffectNamesList.Add(new ComboboxPair("Charge", 96));
            SpellEffectNamesList.Add(new ComboboxPair("Summon Critter", 97));
            SpellEffectNamesList.Add(new ComboboxPair("Knock Back", 98));
            SpellEffectNamesList.Add(new ComboboxPair("Disenchant", 99));
            SpellEffectNamesList.Add(new ComboboxPair("Inebriate", 100));
            SpellEffectNamesList.Add(new ComboboxPair("Feed Pet", 101));
            SpellEffectNamesList.Add(new ComboboxPair("Dismiss Pet", 102));
            SpellEffectNamesList.Add(new ComboboxPair("Reputation", 103));
            SpellEffectNamesList.Add(new ComboboxPair("Summon Object (slot 1)", 104));
            SpellEffectNamesList.Add(new ComboboxPair("Summon Object (slot 2)", 105));
            SpellEffectNamesList.Add(new ComboboxPair("Summon Object (slot 3)", 106));
            SpellEffectNamesList.Add(new ComboboxPair("Summon Object (slot 4)", 107));
            SpellEffectNamesList.Add(new ComboboxPair("Dispel Mechanic", 108));
            SpellEffectNamesList.Add(new ComboboxPair("Summon Dead Pet", 109));
            SpellEffectNamesList.Add(new ComboboxPair("Destroy All Totems", 110));
            SpellEffectNamesList.Add(new ComboboxPair("Durability Damage", 111));
            SpellEffectNamesList.Add(new ComboboxPair("Summon Demon", 112));
            SpellEffectNamesList.Add(new ComboboxPair("Resurrect (Flat)", 113));
            SpellEffectNamesList.Add(new ComboboxPair("Attack Me", 114));
            SpellEffectNamesList.Add(new ComboboxPair("Durability Damage Pct(%)", 115));
            SpellEffectNamesList.Add(new ComboboxPair("Skin Player Corpse", 116));
            SpellEffectNamesList.Add(new ComboboxPair("Spirit Heal", 117));
            SpellEffectNamesList.Add(new ComboboxPair("Skill", 118));
            SpellEffectNamesList.Add(new ComboboxPair("Apply Area Aura Pet", 119));
            SpellEffectNamesList.Add(new ComboboxPair("Teleport Graveyard", 120));
            SpellEffectNamesList.Add(new ComboboxPair("Normalized Weapon Dmg", 121));
            SpellEffectNamesList.Add(new ComboboxPair("Silithyst Cap Reward", 122));
            SpellEffectNamesList.Add(new ComboboxPair("Send Taxi", 123));
            SpellEffectNamesList.Add(new ComboboxPair("Pull Player", 124));
            SpellEffectNamesList.Add(new ComboboxPair("Threat Pct(%)", 125));
            SpellEffectNamesList.Add(new ComboboxPair("Unused 126", 126));
            SpellEffectNamesList.Add(new ComboboxPair("Unused 127", 127));
            SpellEffectNamesList.Add(new ComboboxPair("Apply Area Aura Friend", 128));
            SpellEffectNamesList.Add(new ComboboxPair("Apply Area Aura Enemy", 129));
            
            // Add spell aura names.
            SpellAuraNamesList.Add(new ComboboxPair("None", 0));
            SpellAuraNamesList.Add(new ComboboxPair("Bind Sight", 1));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Possess", 2));
            SpellAuraNamesList.Add(new ComboboxPair("Periodic Damage", 3));
            SpellAuraNamesList.Add(new ComboboxPair("Dummy", 4));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Confuse", 5));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Charm", 6));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Fear", 7));
            SpellAuraNamesList.Add(new ComboboxPair("Periodic Heal", 8));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Attack Speed", 9));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Threat", 10));
            SpellAuraNamesList.Add(new ComboboxPair("Taunt", 11));
            SpellAuraNamesList.Add(new ComboboxPair("Stun", 12));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Damage Done", 13));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Damage Taken", 14));
            SpellAuraNamesList.Add(new ComboboxPair("Damage Shield", 15));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Stealth", 16));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Detect", 17));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Invisibility", 18));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Invisibility Detection", 19));
            SpellAuraNamesList.Add(new ComboboxPair("OBS Mod Intellect", 20));
            SpellAuraNamesList.Add(new ComboboxPair("OBS Mod Spirit", 21));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Resistance", 22));
            SpellAuraNamesList.Add(new ComboboxPair("Periodic Trigger", 23));
            SpellAuraNamesList.Add(new ComboboxPair("Periodic Energize", 24));
            SpellAuraNamesList.Add(new ComboboxPair("Pacify", 25));
            SpellAuraNamesList.Add(new ComboboxPair("Root", 26));
            SpellAuraNamesList.Add(new ComboboxPair("Silence", 27));
            SpellAuraNamesList.Add(new ComboboxPair("Reflect Spells %", 28));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Stat", 29));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Skill", 30));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Speed", 31));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Speed Mounted", 32));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Speed Slow", 33));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Increase Health", 34));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Increase Energy", 35));
            SpellAuraNamesList.Add(new ComboboxPair("Shapeshift", 36));
            SpellAuraNamesList.Add(new ComboboxPair("Immune Effect", 37));
            SpellAuraNamesList.Add(new ComboboxPair("Immune State", 38));
            SpellAuraNamesList.Add(new ComboboxPair("Immune School", 39));
            SpellAuraNamesList.Add(new ComboboxPair("Immune Damage", 40));
            SpellAuraNamesList.Add(new ComboboxPair("Immune Dispel Type", 41));
            SpellAuraNamesList.Add(new ComboboxPair("Proc Trigger Spell", 42));
            SpellAuraNamesList.Add(new ComboboxPair("Proc Trigger Damage", 43));
            SpellAuraNamesList.Add(new ComboboxPair("Track Creatures", 44));
            SpellAuraNamesList.Add(new ComboboxPair("Track Resources", 45));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Parry Skill", 46));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Parry Percent", 47));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Dodge Skill", 48));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Dodge Percent", 49));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Block Skill", 50));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Block Percent", 51));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Crit Percent", 52));
            SpellAuraNamesList.Add(new ComboboxPair("Periodic Leech", 53));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Hit Chance", 54));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Spell Hit Chance", 55));
            SpellAuraNamesList.Add(new ComboboxPair("Transform", 56));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Spell Crit Chance", 57));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Speed Swim", 58));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Creature Dmg Done", 59));
            SpellAuraNamesList.Add(new ComboboxPair("Pacify & Silence", 60));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Scale", 61));
            SpellAuraNamesList.Add(new ComboboxPair("Periodic Health Funnel", 62));
            SpellAuraNamesList.Add(new ComboboxPair("Periodic Mana Funnel", 63));
            SpellAuraNamesList.Add(new ComboboxPair("Periodic Mana Leech", 64));
            SpellAuraNamesList.Add(new ComboboxPair("Haste - Spells", 65));
            SpellAuraNamesList.Add(new ComboboxPair("Feign Death", 66));
            SpellAuraNamesList.Add(new ComboboxPair("Disarm", 67));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Stalked", 68));
            SpellAuraNamesList.Add(new ComboboxPair("School Absorb", 69));
            SpellAuraNamesList.Add(new ComboboxPair("Extra Attacks", 70));
            SpellAuraNamesList.Add(new ComboboxPair("Mod School Spell Crit Chance", 71));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Power Cost", 72));
            SpellAuraNamesList.Add(new ComboboxPair("Mod School Power Cost", 73));
            SpellAuraNamesList.Add(new ComboboxPair("Reflect School Spells %", 74));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Language", 75));
            SpellAuraNamesList.Add(new ComboboxPair("Far Sight", 76));
            SpellAuraNamesList.Add(new ComboboxPair("Immune Mechanic", 77));
            SpellAuraNamesList.Add(new ComboboxPair("Mounted", 78));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Dmg %", 79));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Stat %", 80));
            SpellAuraNamesList.Add(new ComboboxPair("Split Damage", 81));
            SpellAuraNamesList.Add(new ComboboxPair("Water Breathing", 82));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Base Resistance", 83));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Health Regen", 84));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Power Regen", 85));
            SpellAuraNamesList.Add(new ComboboxPair("Create Death Item", 86));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Dmg % Taken", 87));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Health Regen Percent", 88));
            SpellAuraNamesList.Add(new ComboboxPair("Periodic Damage Percent", 89));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Resist Chance", 90));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Detect Range", 91));
            SpellAuraNamesList.Add(new ComboboxPair("Prevent Fleeing", 92));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Uninteractible", 93));
            SpellAuraNamesList.Add(new ComboboxPair("Interrupt Regen", 94));
            SpellAuraNamesList.Add(new ComboboxPair("Ghost", 95));
            SpellAuraNamesList.Add(new ComboboxPair("Spell Magnet", 96));
            SpellAuraNamesList.Add(new ComboboxPair("Mana Shield", 97));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Skill Talent", 98));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Attack Power", 99));
            SpellAuraNamesList.Add(new ComboboxPair("Auras Visible", 100));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Resistance %", 101));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Creature Attack Power", 102));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Total Threat (Fade)", 103));
            SpellAuraNamesList.Add(new ComboboxPair("Water Walk", 104));
            SpellAuraNamesList.Add(new ComboboxPair("Feather Fall", 105));
            SpellAuraNamesList.Add(new ComboboxPair("Hover", 106));
            SpellAuraNamesList.Add(new ComboboxPair("Add Flat Modifier", 107));
            SpellAuraNamesList.Add(new ComboboxPair("Add % Modifier", 108));
            SpellAuraNamesList.Add(new ComboboxPair("Add Class Target Trigger", 109));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Power Regen %", 110));
            SpellAuraNamesList.Add(new ComboboxPair("Add Class Caster Hit Trigger", 111));
            SpellAuraNamesList.Add(new ComboboxPair("Override Class Scripts", 112));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Ranged Dmg Taken", 113));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Ranged % Dmg Taken", 114));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Healing", 115));
            SpellAuraNamesList.Add(new ComboboxPair("Regen During Combat", 116));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Mechanic Resistance", 117));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Healing %", 118));
            SpellAuraNamesList.Add(new ComboboxPair("Share Pet Tracking", 119));
            SpellAuraNamesList.Add(new ComboboxPair("Untrackable", 120));
            SpellAuraNamesList.Add(new ComboboxPair("Empathy (Lore, whatever)", 121));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Offhand Dmg %", 122));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Power Cost %", 123));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Ranged Attack Power", 124));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Melee Dmg Taken", 125));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Melee % Dmg Taken", 126));
            SpellAuraNamesList.Add(new ComboboxPair("Rngd Atk Pwr Attckr Bonus", 127));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Possess Pet", 128));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Speed Always", 129));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Mounted Speed Always", 130));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Creature Ranged Attack Power", 131));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Increase Energy %", 132));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Increase Health %", 133));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Interrupted Mana Regen", 134));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Healing Done", 135));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Healing Done %", 136));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Total Stat %", 137));
            SpellAuraNamesList.Add(new ComboboxPair("Haste - Melee", 138));
            SpellAuraNamesList.Add(new ComboboxPair("Force Reaction", 139));
            SpellAuraNamesList.Add(new ComboboxPair("Haste - Ranged", 140));
            SpellAuraNamesList.Add(new ComboboxPair("Haste - Ranged (Ammo Only)", 141));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Base Resistance %", 142));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Resistance Exclusive", 143));
            SpellAuraNamesList.Add(new ComboboxPair("Safe Fall", 144));
            SpellAuraNamesList.Add(new ComboboxPair("Charisma", 145));
            SpellAuraNamesList.Add(new ComboboxPair("Persuaded", 146));
            SpellAuraNamesList.Add(new ComboboxPair("Add Creature Immunity", 147));
            SpellAuraNamesList.Add(new ComboboxPair("Retain Combo Points", 148));
            SpellAuraNamesList.Add(new ComboboxPair("Resist Pushback", 149));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Shield Block %", 150));
            SpellAuraNamesList.Add(new ComboboxPair("Track Stealthed", 151));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Detected Range", 152));
            SpellAuraNamesList.Add(new ComboboxPair("Split Damage Flat", 153));
            SpellAuraNamesList.Add(new ComboboxPair("Stealth Level Modifier", 154));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Water Breathing", 155));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Reputation Gain", 156));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Pet Damage", 157));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Shield Block", 158));
            SpellAuraNamesList.Add(new ComboboxPair("No PVP Credit", 159));
            SpellAuraNamesList.Add(new ComboboxPair("AoE Avoidance", 160));
            SpellAuraNamesList.Add(new ComboboxPair("Health Regen In Combat", 161));
            SpellAuraNamesList.Add(new ComboboxPair("Power Burn Mana", 162));
            SpellAuraNamesList.Add(new ComboboxPair("Crit Damage Bonus", 163));
            SpellAuraNamesList.Add(new ComboboxPair("Aura 164", 164));
            SpellAuraNamesList.Add(new ComboboxPair("Melee AP Attacker Bonus", 165));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Attack Power %", 166));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Ranged Attack Power %", 167));
            SpellAuraNamesList.Add(new ComboboxPair("Damage Done Versus", 168));
            SpellAuraNamesList.Add(new ComboboxPair("Crit % Versus", 169));
            SpellAuraNamesList.Add(new ComboboxPair("Detect Amore", 170));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Speed Not Stacking", 171));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Mounted Speed Not Stacking", 172));
            SpellAuraNamesList.Add(new ComboboxPair("Allow Champion Spells", 173));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Spell Dmg of Stat %", 174));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Spell Heal of Stat %", 175));
            SpellAuraNamesList.Add(new ComboboxPair("Spirit of Redemption", 176));
            SpellAuraNamesList.Add(new ComboboxPair("AoE Charm", 177));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Debuff Resistance", 178));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Attacker Spell Crit Chance", 179));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Flat Spell Dmg Versus", 180));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Flat Spell Dmg Crit Versus", 181));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Resistance of Stat %", 182));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Critical Threat", 183));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Attacker Melee Hit Chance", 184));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Attacker Ranged Hit Chance", 185));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Attacker Spell Hit Chance", 186));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Attacker Melee Crit Chance", 187));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Attacker Ranged Crit Chance", 188));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Rating", 189));
            SpellAuraNamesList.Add(new ComboboxPair("Mod Faction Reputation Gain", 190));
            SpellAuraNamesList.Add(new ComboboxPair("Use Normal Movement Speed", 191));
            SpellAuraNamesList.Add(new ComboboxPair("Custom Aura Spell", 192));

            // Add reputation rank names.
            ReputationRankList.Add(new ComboboxPair("Hated", 0));
            ReputationRankList.Add(new ComboboxPair("Hostile", 1));
            ReputationRankList.Add(new ComboboxPair("Unfriendly", 2));
            ReputationRankList.Add(new ComboboxPair("Neutral", 3));
            ReputationRankList.Add(new ComboboxPair("Friendly", 4));
            ReputationRankList.Add(new ComboboxPair("Honored", 5));
            ReputationRankList.Add(new ComboboxPair("Revered", 6));
            ReputationRankList.Add(new ComboboxPair("Exalted", 7));

            // Add team names.
            TeamNamesList.Add(new ComboboxPair("Crossfaction", 1));
            TeamNamesList.Add(new ComboboxPair("Horde", 67));
            TeamNamesList.Add(new ComboboxPair("Alliance", 469));

            // Add gender names.
            GenderNamesList.Add(new ComboboxPair("Male", 0));
            GenderNamesList.Add(new ComboboxPair("Female", 1));
            GenderNamesList.Add(new ComboboxPair("None", 2));

            // Add loot state names.
            LootStateNamesList.Add(new ComboboxPair("Not Ready", 0));
            LootStateNamesList.Add(new ComboboxPair("Ready", 1));
            LootStateNamesList.Add(new ComboboxPair("Activated", 2));
            LootStateNamesList.Add(new ComboboxPair("Just Deactivated", 3));

            // Add GO state names.
            GOStateNamesList.Add(new ComboboxPair("Active", 0));
            GOStateNamesList.Add(new ComboboxPair("Ready", 1));
            GOStateNamesList.Add(new ComboboxPair("Alternative", 2));

            // Add content patch names.
            ContentPatchesList.Add(new ComboboxPair("1.2 - Mysteries of Maraudon", 0));
            ContentPatchesList.Add(new ComboboxPair("1.3 - Ruins of the Dire Maul", 1));
            ContentPatchesList.Add(new ComboboxPair("1.4 - The Call to War", 2));
            ContentPatchesList.Add(new ComboboxPair("1.5 - Battlegrounds", 3));
            ContentPatchesList.Add(new ComboboxPair("1.6 - Assault on Blackwing Lair", 4));
            ContentPatchesList.Add(new ComboboxPair("1.7 - Rise of the Blood God", 5));
            ContentPatchesList.Add(new ComboboxPair("1.8 - Dragons of Nightmare", 6));
            ContentPatchesList.Add(new ComboboxPair("1.9 - The Gates of Ahn\'Qiraj", 7));
            ContentPatchesList.Add(new ComboboxPair("1.10 - Storms of Azeroth", 8));
            ContentPatchesList.Add(new ComboboxPair("1.11 - Shadow of the Necropolis", 9));
            ContentPatchesList.Add(new ComboboxPair("1.12 - Drums of War", 10));

            // GameObject Flags from Update Fields
            GameObjectFlagsList.Add(new Tuple<string, uint>("InUse", 1));
            GameObjectFlagsList.Add(new Tuple<string, uint>("Locked", 2));
            GameObjectFlagsList.Add(new Tuple<string, uint>("InteractCondition", 4));
            GameObjectFlagsList.Add(new Tuple<string, uint>("Transport", 8));
            GameObjectFlagsList.Add(new Tuple<string, uint>("NoInteract", 16));
            GameObjectFlagsList.Add(new Tuple<string, uint>("NoDespawn", 32));
            GameObjectFlagsList.Add(new Tuple<string, uint>("Triggered", 64));

            // GameObject Dynamic Flags from Update Fields
            GameObjectDynFlagsList.Add(new Tuple<string, uint>("Activate", 1));
            GameObjectDynFlagsList.Add(new Tuple<string, uint>("Animate", 2));
            GameObjectDynFlagsList.Add(new Tuple<string, uint>("NoInteract", 4));

            // Unit Flags from Update Fields
            UnitFieldFlagsList.Add(new Tuple<string, uint>("Unk0", 1));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("Spawning", 2));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("DisableMove", 4));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("PlayerControlled", 8));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("PetRename", 16));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("PetAbandon", 32));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("Unk6", 64));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("NotAttackable1", 128));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("ImmuneToPlayer", 256));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("ImmuneToNPC", 512));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("Looting", 1024));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("PetInCombat", 2048));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("PvP", 4096));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("Silenced", 8192));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("Unk14", 16384));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("UseSwimAnimation", 32768));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("NotAttackable2", 65536));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("Pacified", 131072));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("Stunned", 262144));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("InCombat", 524288));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("TaxiFlight", 1048576));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("Disarmed", 2097152));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("Confused", 4194304));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("Fleeing", 8388608));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("Possessed", 16777216));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("NotSelectable", 33554432));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("Skinnable", 67108864));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("AurasVisible", 134217728));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("Unk28", 268435456));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("PreventAnim", 536870912));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("Sheathe", 1073741824));
            UnitFieldFlagsList.Add(new Tuple<string, uint>("Immune", 2147483648));

            // Unit Dynamic Flags from Update Fields
            UnitDynamicFlagsList.Add(new Tuple<string, uint>("Lootable", 1));
            UnitDynamicFlagsList.Add(new Tuple<string, uint>("TrackUnit", 2));
            UnitDynamicFlagsList.Add(new Tuple<string, uint>("Tapped", 4));
            UnitDynamicFlagsList.Add(new Tuple<string, uint>("TappedByPlayer", 8));
            UnitDynamicFlagsList.Add(new Tuple<string, uint>("SpecialInfo", 16));
            UnitDynamicFlagsList.Add(new Tuple<string, uint>("Dead", 32));

            // Unit NPC Flags from Update Fields
            UnitNpcFlagsList.Add(new Tuple<string, uint>("Gossip", 1));
            UnitNpcFlagsList.Add(new Tuple<string, uint>("QuestGiver", 2));
            UnitNpcFlagsList.Add(new Tuple<string, uint>("Vendor", 4));
            UnitNpcFlagsList.Add(new Tuple<string, uint>("FlightMaster", 8));
            UnitNpcFlagsList.Add(new Tuple<string, uint>("Trainer", 16));
            UnitNpcFlagsList.Add(new Tuple<string, uint>("SpiritHealer", 32));
            UnitNpcFlagsList.Add(new Tuple<string, uint>("SpiritGuid", 64));
            UnitNpcFlagsList.Add(new Tuple<string, uint>("Innkeeper", 128));
            UnitNpcFlagsList.Add(new Tuple<string, uint>("Banker", 256));
            UnitNpcFlagsList.Add(new Tuple<string, uint>("Petitioner", 512));
            UnitNpcFlagsList.Add(new Tuple<string, uint>("TabardDesigner", 1024));
            UnitNpcFlagsList.Add(new Tuple<string, uint>("Battlemaster", 2048));
            UnitNpcFlagsList.Add(new Tuple<string, uint>("Auctioneer", 4096));
            UnitNpcFlagsList.Add(new Tuple<string, uint>("Stablemaster", 8192));
            UnitNpcFlagsList.Add(new Tuple<string, uint>("Repair", 16384));

            // Player Flags from Update Fields
            PlayerFlagsList.Add(new Tuple<string, uint>("GroupLeader", 1));
            PlayerFlagsList.Add(new Tuple<string, uint>("AFK", 2));
            PlayerFlagsList.Add(new Tuple<string, uint>("DND", 4));
            PlayerFlagsList.Add(new Tuple<string, uint>("GM", 8));
            PlayerFlagsList.Add(new Tuple<string, uint>("Ghost", 16));
            PlayerFlagsList.Add(new Tuple<string, uint>("Resting", 32));
            PlayerFlagsList.Add(new Tuple<string, uint>("Unk7", 64));
            PlayerFlagsList.Add(new Tuple<string, uint>("FFA", 128));
            PlayerFlagsList.Add(new Tuple<string, uint>("ContestedPvP", 256));
            PlayerFlagsList.Add(new Tuple<string, uint>("InPvP", 512));
            PlayerFlagsList.Add(new Tuple<string, uint>("HideHelm", 1024));
            PlayerFlagsList.Add(new Tuple<string, uint>("HideCloak", 2048));
            PlayerFlagsList.Add(new Tuple<string, uint>("PartialPlayTime", 4096));
            PlayerFlagsList.Add(new Tuple<string, uint>("NoPlayTime", 8192));
            PlayerFlagsList.Add(new Tuple<string, uint>("Unk15", 16384));
            PlayerFlagsList.Add(new Tuple<string, uint>("Unk16", 32768));
            PlayerFlagsList.Add(new Tuple<string, uint>("Sanctuary", 65536));
            PlayerFlagsList.Add(new Tuple<string, uint>("TaxiBenchmark", 131072));
            PlayerFlagsList.Add(new Tuple<string, uint>("PvPTimer", 262144));

            // Spell mechanic masks.
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Charm", 1));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Disorient", 2));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Disarm", 4));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Distract", 8));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Fear", 16));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Fumble", 32));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Root", 64));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Pacify", 128));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Silence", 256));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Sleep", 512));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Snare", 1024));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Stun", 2048));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Freeze", 4096));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Knockout", 8192));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Bleed", 16384));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Bandage", 32768));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Polymoprh", 65536));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Banish", 131072));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Shield", 262144));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Shackle", 524288));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Mount", 1048576));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Persuade", 2097152));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Turn", 4194304));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Horror", 8388608));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Invulnerability", 16777216));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Interrupt", 33554432));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Daze", 67108864));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Discovery", 134217728));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Immune Shield", 268435456));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Sapped", 536870912));
            SpellMechanicMaskList.Add(new Tuple<string, uint>("Slow Cast Speed", 1073741824));

            // Spell Attributes
            SpellAttributesList.Add(new Tuple<string, uint>("Proc Failure Burns Charge", 1));
            SpellAttributesList.Add(new Tuple<string, uint>("Uses Ranged Slot", 2));
            SpellAttributesList.Add(new Tuple<string, uint>("On Next Swing (No Damage)", 4));
            SpellAttributesList.Add(new Tuple<string, uint>("Need Exotic Ammo", 8));
            SpellAttributesList.Add(new Tuple<string, uint>("Is Ability", 16));
            SpellAttributesList.Add(new Tuple<string, uint>("Is Tradeskill", 32));
            SpellAttributesList.Add(new Tuple<string, uint>("Passive", 64));
            SpellAttributesList.Add(new Tuple<string, uint>("Do Not Display (Spellbook, Aura Icon, Combat Log)", 128));
            SpellAttributesList.Add(new Tuple<string, uint>("Do Not Log", 256));
            SpellAttributesList.Add(new Tuple<string, uint>("Held Item Only", 512));
            SpellAttributesList.Add(new Tuple<string, uint>("On Next Swing", 1024));
            SpellAttributesList.Add(new Tuple<string, uint>("Wearer Casts Proc Trigger", 2048));
            SpellAttributesList.Add(new Tuple<string, uint>("Daytime Only", 4096));
            SpellAttributesList.Add(new Tuple<string, uint>("Night Only", 8192));
            SpellAttributesList.Add(new Tuple<string, uint>("Only Indoors", 16384));
            SpellAttributesList.Add(new Tuple<string, uint>("Only Outdoors", 32768));
            SpellAttributesList.Add(new Tuple<string, uint>("Not Shapeshifted", 65536));
            SpellAttributesList.Add(new Tuple<string, uint>("Only Stealthed", 131072));
            SpellAttributesList.Add(new Tuple<string, uint>("Do Not Sheath", 262144));
            SpellAttributesList.Add(new Tuple<string, uint>("Scales w/ Creature Level", 524288));
            SpellAttributesList.Add(new Tuple<string, uint>("Cancels Auto Attack Combat", 1048576));
            SpellAttributesList.Add(new Tuple<string, uint>("No Active Defense", 2097152));
            SpellAttributesList.Add(new Tuple<string, uint>("Track Target in Cast (Player Only)", 4194304));
            SpellAttributesList.Add(new Tuple<string, uint>("Allow Cast While Dead", 8388608));
            SpellAttributesList.Add(new Tuple<string, uint>("Allow While Mounted", 16777216));
            SpellAttributesList.Add(new Tuple<string, uint>("Cooldown On Event", 33554432));
            SpellAttributesList.Add(new Tuple<string, uint>("Aura Is Debuff", 67108864));
            SpellAttributesList.Add(new Tuple<string, uint>("Allow While Sitting", 134217728));
            SpellAttributesList.Add(new Tuple<string, uint>("Not In Combat (Only Peaceful)", 268435456));
            SpellAttributesList.Add(new Tuple<string, uint>("No Immunities", 536870912));
            SpellAttributesList.Add(new Tuple<string, uint>("Heartbeat Resist", 1073741824));
            SpellAttributesList.Add(new Tuple<string, uint>("No Aura Cancel", 2147483648));

            // Spell AttributesEx
            SpellAttributesExList.Add(new Tuple<string, uint>("Dismiss Pet First", 1));
            SpellAttributesExList.Add(new Tuple<string, uint>("Use All Mana", 2));
            SpellAttributesExList.Add(new Tuple<string, uint>("Is Channelled", 4));
            SpellAttributesExList.Add(new Tuple<string, uint>("No Redirection", 8));
            SpellAttributesExList.Add(new Tuple<string, uint>("No Skill Increase", 16));
            SpellAttributesExList.Add(new Tuple<string, uint>("Allow While Stealthed", 32));
            SpellAttributesExList.Add(new Tuple<string, uint>("Is Self Channelled", 64));
            SpellAttributesExList.Add(new Tuple<string, uint>("No Reflection", 128));
            SpellAttributesExList.Add(new Tuple<string, uint>("Only Peaceful Targets", 256));
            SpellAttributesExList.Add(new Tuple<string, uint>("Initiates Combat (Enables Auto-Attack)", 512));
            SpellAttributesExList.Add(new Tuple<string, uint>("No Threat", 1024));
            SpellAttributesExList.Add(new Tuple<string, uint>("Aura Unique", 2048));
            SpellAttributesExList.Add(new Tuple<string, uint>("Failure Breaks Stealth", 4096));
            SpellAttributesExList.Add(new Tuple<string, uint>("Toggle Far Sight", 8192));
            SpellAttributesExList.Add(new Tuple<string, uint>("Track Target in Channel", 16384));
            SpellAttributesExList.Add(new Tuple<string, uint>("Immunity Purges Effect", 32768));
            SpellAttributesExList.Add(new Tuple<string, uint>("Immunity to Hostile & Friendly Effects", 65536));
            SpellAttributesExList.Add(new Tuple<string, uint>("No AutoCast (AI)", 131072));
            SpellAttributesExList.Add(new Tuple<string, uint>("Prevents Anim", 262144));
            SpellAttributesExList.Add(new Tuple<string, uint>("Exclude Caster", 524288));
            SpellAttributesExList.Add(new Tuple<string, uint>("Finishing Move - Damage", 1048576));
            SpellAttributesExList.Add(new Tuple<string, uint>("Threat only on Miss", 2097152));
            SpellAttributesExList.Add(new Tuple<string, uint>("Finishing Move - Duration", 4194304));
            SpellAttributesExList.Add(new Tuple<string, uint>("Ignore Caster & Target Restrictions", 8388608));
            SpellAttributesExList.Add(new Tuple<string, uint>("Special Skillup", 16777216));
            SpellAttributesExList.Add(new Tuple<string, uint>("Aura Stays After Combat", 33554432));
            SpellAttributesExList.Add(new Tuple<string, uint>("Require All Targets", 67108864));
            SpellAttributesExList.Add(new Tuple<string, uint>("Discount Power On Miss", 134217728));
            SpellAttributesExList.Add(new Tuple<string, uint>("No Aura Icon", 268435456));
            SpellAttributesExList.Add(new Tuple<string, uint>("Name in Channel Bar", 536870912));
            SpellAttributesExList.Add(new Tuple<string, uint>("Combo on Block", 1073741824));
            SpellAttributesExList.Add(new Tuple<string, uint>("Cast When Learned", 2147483648));

            // Spell AttributesEx2
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Allow Dead Target", 1));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("No shapeshift UI", 2));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Ignore Line of Sight", 4));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Allow Low Level Buff", 8));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Use Shapeshift Bar", 16));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Auto Repeat", 32));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Cannot cast on tapped", 64));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Do Not Report Spell Failure", 128));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Include In Advanced Combat Log", 256));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Always Cast As Unit", 512));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Special Taming Flag", 1024));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("No Target Per-Second Costs", 2048));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Chain From Caster", 4096));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Enchant own item only", 8192));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Allow While Invisible", 16384));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Enable After Parry", 32768));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("No Active Pets", 65536));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Do Not Reset Combat Timers", 131072));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Requires Dead Pet", 262144));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Allow While Not Shapeshifted (caster form)", 524288));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Initiate Combat Post-Cast (Enables Auto-Attack)", 1048576));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Fail on all targets immune", 2097152));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("No Initial Threat", 4194304));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Proc Cooldown On Failure", 8388608));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Item Cast With Owner Skill", 16777216));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Don't Block Mana Regen", 33554432));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("No School Immunities", 67108864));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Ignore Weaponskill", 134217728));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Not an Action", 268435456));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Can't Crit", 536870912));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Active Threat", 1073741824));
            SpellAttributesEx2List.Add(new Tuple<string, uint>("Retain Item Cast", 2147483648));

            // Spell AttributesEx3
            SpellAttributesEx3List.Add(new Tuple<string, uint>("PvP Enabling", 1));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("No Proc Equip Requirement", 2));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("No Casting Bar Text", 4));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Completely Blocked", 8));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("No Res Timer", 16));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("No Durability Loss", 32));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("No Avoidance", 64));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("DoT Stacking Rule", 128));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Only On Player", 256));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Not a Proc", 512));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Requires Main-Hand Weapon", 1024));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Only Battlegrounds", 2048));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Only On Ghosts", 4096));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Hide Channel Bar", 8192));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Hide In Raid Filter", 16384));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Normal Ranged Attack", 32768));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Suppress Caster Procs", 65536));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Suppress Target Procs", 131072));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Always Hit", 262144));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Instant Target Procs", 524288));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Allow Aura While Dead", 1048576));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Only Proc Outdoors", 2097152));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Casting Cancels Autorepeat", 4194304));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("No Damage History", 8388608));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Requires Off-Hand Weapon", 16777216));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Treat As Periodic", 33554432));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Can Proc From Procs", 67108864));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Only Proc on Caster", 134217728));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Ignore Caster & Target Restrictions", 268435456));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Ignore Caster Modifiers", 536870912));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Do Not Display Range", 1073741824));
            SpellAttributesEx3List.Add(new Tuple<string, uint>("Not On AOE Immune", 2147483648));

            // Spell AttributesEx4
            SpellAttributesEx4List.Add(new Tuple<string, uint>("Ignore Resistances", 1));
            SpellAttributesEx4List.Add(new Tuple<string, uint>("Class Trigger Only On Target", 2));
            SpellAttributesEx4List.Add(new Tuple<string, uint>("Aura Expires Offline", 4));
            SpellAttributesEx4List.Add(new Tuple<string, uint>("No Helpful Threat", 8));
            SpellAttributesEx4List.Add(new Tuple<string, uint>("No Harmful Threat", 16));
            SpellAttributesEx4List.Add(new Tuple<string, uint>("Allow Client Targeting", 32));
            SpellAttributesEx4List.Add(new Tuple<string, uint>("Cannot Be Stolen", 64));
            SpellAttributesEx4List.Add(new Tuple<string, uint>("Allow Cast While Casting", 128));
            SpellAttributesEx4List.Add(new Tuple<string, uint>("Ignore Damage Taken Modifiers", 256));
            SpellAttributesEx4List.Add(new Tuple<string, uint>("Combat Feedback When Usable", 512));

            // Spell Proc Flags
            SpellProcFlagsList.Add(new Tuple<string, uint>("Heartbeat", 1));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Kill", 2));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Deal Melee Swing", 4));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Take Melee Swing", 8));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Deal Melee Ability", 16));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Take Melee Ability", 32));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Deal Ranged Attack", 64));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Take Ranged Attack", 128));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Deal Ranged Ability", 256));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Take Ranged Ability", 512));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Deal Helpful Ability", 1024));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Take Helpful Ability", 2048));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Deal Harmful Ability", 4096));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Take Harmful Ability", 8192));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Deal Helpful Spell", 16384));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Take Helpful Spell", 32768));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Deal Harmful Spell", 65536));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Take Harmful Spell", 131072));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Deal Harmful Periodic", 262144));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Take Harmful Periodic", 524288));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Taken Any Damage", 1048576));
            SpellProcFlagsList.Add(new Tuple<string, uint>("On Trap Activation", 2097152));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Main Hand Weapon Swing", 4194304));
            SpellProcFlagsList.Add(new Tuple<string, uint>("Off Hand Weapon Swing", 8388608));

            // Spell Proc Flags Ex
            SpellProcFlagsExList.Add(new Tuple<string, uint>("Normal Hit", 1));
            SpellProcFlagsExList.Add(new Tuple<string, uint>("Critical Hit", 2));
            SpellProcFlagsExList.Add(new Tuple<string, uint>("Miss", 4));
            SpellProcFlagsExList.Add(new Tuple<string, uint>("Resist", 8));
            SpellProcFlagsExList.Add(new Tuple<string, uint>("Dodge", 16));
            SpellProcFlagsExList.Add(new Tuple<string, uint>("Parry", 32));
            SpellProcFlagsExList.Add(new Tuple<string, uint>("Block", 64));
            SpellProcFlagsExList.Add(new Tuple<string, uint>("Evade", 128));
            SpellProcFlagsExList.Add(new Tuple<string, uint>("Immune", 256));
            SpellProcFlagsExList.Add(new Tuple<string, uint>("Deflect", 512));
            SpellProcFlagsExList.Add(new Tuple<string, uint>("Absorb", 1024));
            SpellProcFlagsExList.Add(new Tuple<string, uint>("Reflect", 2048));
            SpellProcFlagsExList.Add(new Tuple<string, uint>("Interrupt", 4096));
            SpellProcFlagsExList.Add(new Tuple<string, uint>("Reserved1", 8192));
            SpellProcFlagsExList.Add(new Tuple<string, uint>("Reserved2", 16384));
            SpellProcFlagsExList.Add(new Tuple<string, uint>("Reserved3", 32768));
            SpellProcFlagsExList.Add(new Tuple<string, uint>("Trigger Always", 65536));
            SpellProcFlagsExList.Add(new Tuple<string, uint>("No Periodic", 131072));
            SpellProcFlagsExList.Add(new Tuple<string, uint>("Periodic Positive", 262144));
            SpellProcFlagsExList.Add(new Tuple<string, uint>("Cast End", 524288));
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
        public uint SpellListId;
        public string Name;
        public CreatureInfo(uint id, uint minlevel, uint maxlevel, uint rank, uint spelllistid, string name)
        {
            ID = id;
            Name = name;
            MinLevel = minlevel;
            MaxLevel = maxlevel;
            Rank = rank;
            SpellListId = spelllistid;
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
    public class ConditionInfo
    {
        public uint ID;
        public int Type;
        public int Value1;
        public int Value2;
        public int Value3;
        public int Value4;
        public uint Flags;
        public ConditionInfo(uint id, int type, int value1, int value2, int value3, int value4, uint flags)
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
        public int Reputation;
        public uint Team;
        public string Name;
        public string Description;
        public FactionInfo(uint id, int reputation, uint team, string name, string description)
        {
            ID = id;
            Reputation = reputation;
            Team = team;
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

        public static int GetIndexFromComboboxPairValue(System.Windows.Forms.ComboBox cmb, int value)
        {
            for (int i = 0; i < cmb.Items.Count; i++)
            {
                if ((cmb.Items[i] as ComboboxPair).Value == value)
                    return i;
            }
            return -1;
        }
    }

    
}
