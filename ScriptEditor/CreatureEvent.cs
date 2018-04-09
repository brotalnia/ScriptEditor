using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScriptEditor
{
    class CreatureEvent
    {
        public uint Id;
        public uint CreatureId;
        public uint Type;
        public uint Chance;
        public uint InversePhaseMask;
        public uint ConditionId;
        public uint Flags;
        public int Param1;
        public int Param2;
        public int Param3;
        public int Param4;
        public uint ScriptId1;
        public uint ScriptId2;
        public uint ScriptId3;
        public string Comment;

        public CreatureEvent(uint id, uint creatureid, uint conditionid, uint type, uint inversephasemask, uint chance, uint flags, int param1, int param2, int param3, int param4, uint scriptid1, uint scriptid2, uint scriptid3, string comment)
        {
            Id = id;
            CreatureId = creatureid;
            Type = type;
            Chance = chance;
            InversePhaseMask = inversephasemask;
            ConditionId = conditionid;
            Flags = flags;
            Param1 = param1;
            Param2 = param2;
            Param3 = param3;
            Param4 = param4;
            ScriptId1 = scriptid1;
            ScriptId2 = scriptid2;
            ScriptId3 = scriptid3;
            Comment = comment;
        }
        public CreatureEvent(uint id, uint creatureid)
        {
            Id = id;
            CreatureId = creatureid;
            Type = 0;
            Chance = 100;
            InversePhaseMask = 0;
            ConditionId = 0;
            Flags = 0;
            Param1 = 0;
            Param2 = 0;
            Param3 = 0;
            Param4 = 0;
            ScriptId1 = 0;
            ScriptId2 = 0;
            ScriptId3 = 0;
            Comment = "New Event - Edit me!";
        }
    }
}
