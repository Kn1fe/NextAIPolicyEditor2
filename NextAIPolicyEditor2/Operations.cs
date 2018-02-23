using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NextAIPolicyEditor2
{
    public static class Operations
    {
        public static Dictionary<string, string> Channels = new Dictionary<string, string>();
        public static string[] Targets = new string[] { "aggro_first", "aggro_second", "aggro_second_rand", "most_hp", "most_mp", "least_hp", "class_combo", "self", "monster_killer", "monster_birthplace_faction", "hate_random_one", "hate_nearest", "hate_farthest", "hate_first_redirected", "num" };
        public static Dictionary<string, Dictionary<string, int>> Enums = new Dictionary<string, Dictionary<string, int>>();

        public static void Init()
        {
            Channels.Add("", "Normal");
            Channels.Add("$A", "$A");
            Channels.Add("$B", "$B");
            Channels.Add("$F", "$F");
            Channels.Add("$I", "$I");
            Channels.Add("$S", "$S");
            Channels.Add("$N", "$N");
            Channels.Add("$X", "$X");
            Channels.Add("$T", "$T");

            Enums.Add("DispearCondition", new Dictionary<string, int> { { "Never", 0 }, { "FollowSummoner", 1 }, { "FollowSummonTarget", 2 }, { "FollowSummonerOrSummonTarget", 3 }, { "Num", 4 } });
            Enums.Add("PatrolType", new Dictionary<string, int> { { "StopAtEnd", 0 }, { "Return", 1 }, { "Loop", 2 }, { "Num", 3 } });
            Enums.Add("SpeedType", new Dictionary<string, int> { { "Begin", 1 }, { "Slow", 1 }, { "Fast", 2 }, { "End", 2 } });
            Enums.Add("VarType", new Dictionary<string, int> { { "GlobalVarID", 0 }, { "LocalVarID", 1 }, { "Const", 2 }, { "Random", 3 }, { "Num", 4 } });
            Enums.Add("OperatorType", new Dictionary<string, int> { { "Add", 0 }, { "Sub", 1 }, { "Mul", 2 }, { "Div", 3 }, { "Mod", 4 }, { "Num", 5 } });
            Enums.Add("PointType", new Dictionary<string, int> { { "MineCar", 0 }, { "MineBase", 1 }, { "MineCarArrived", 2 } });
            Enums.Add("AppendDataMask", new Dictionary<string, int> { { "Name", 1 }, { "LocalVar0", 2 }, { "LocalVar1", 4 }, { "LocalVar2", 8 } });
        }

        public static object[] Read(BinaryReader br, int Type, int Version)
        {
            switch (Type)
            {
                case 0:
                    return new object[]
                    {
                        br.ReadInt32()
                    };
                case 1:
                    return new object[]
                    {
                        br.ReadInt32(),
                        br.ReadInt32()
                    };
                case 2:
                    int size = br.ReadInt32();
                    string text = Encoding.Unicode.GetString(br.ReadBytes(size));
                    string channel = "";
                    if (text.StartsWith("$")) channel = text.Substring(0, 2);
                    if (!string.IsNullOrEmpty(channel)) text = text.Substring(2);

                    if (Version > 16)
                    {
                        return new object[]
                        {
                            channel,
                            text,
                            br.ReadInt32()
                        };
                    }
                    else
                    {
                        return new object[]
                        {
                            channel,
                            text
                        };
                    }
                case 3:
                    return new object[0];
                case 4:
                    return new object[]
                    {
                        br.ReadInt32()
                    };
                case 5:
                    return new object[]
                    {
                        br.ReadInt32()
                    };
                case 6:
                    return new object[]
                    {
                        br.ReadInt32()
                    };
                case 7:
                    return new object[]
                    {
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32()
                    };
                case 8:
                    return new object[]
                    {
                        br.ReadInt32()
                    };
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    return new object[0];
                case 14:
                    return new object[]
                    {
                        br.ReadInt32(),
                        br.ReadInt32()
                    };
                case 15:
                    return new object[]
                    {
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32()
                    };
                case 16:
                    return new object[]
                    {
                        br.ReadInt32(),
                        br.ReadInt32()
                    };
                case 17:
                    return new object[]
                    {
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                    };
                case 18:
                    return new object[]
                    {
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32()
                    };
                case 19:
                    return new object[]
                    {
                        new AIFile().GBKBytesToString(br.ReadBytes(128)),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32()
                    };
                case 20:
                    return new object[]
                    {
                        br.ReadInt32(),
                        br.ReadInt32()
                    };
                case 21:
                    return new object[]
                    {
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32()
                    };
                case 22:
                    return new object[]
                    {
                        br.ReadInt32()
                    };
                case 23:
                    return new object[]
                    {
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32()
                    };
                case 24:
                    return new object[]
                    {
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32()
                    };
                case 25:
                    return new object[]
                    {
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32()
                    };
                case 26:
                    return new object[]
                    {
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32()
                    };
                case 27:
                    return new object[]
                    {
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32()
                    };
                case 28:
                    return new object[]
                    {
                        br.ReadInt32(),
                        br.ReadInt32()
                    };
                case 29:
                    return new object[]
                    {
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32()
                    };
                case 30:
                    return new object[]
                    {
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32()
                    };
                case 31:
                    return new object[]
                    {
                        br.ReadInt32(),
                        br.ReadSingle(),
                        br.ReadSingle(),
                        br.ReadSingle(),
                        br.ReadSingle(),
                        br.ReadSingle(),
                        br.ReadSingle()
                    };
                case 32:
                    return new object[]
                    {
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32(),
                        br.ReadInt32()
                    };
                case 33:
                    return new object[]
                    {
                        br.ReadSingle(),
                        br.ReadSingle(),
                        br.ReadSingle(),
                        br.ReadSingle(),
                        br.ReadSingle(),
                        br.ReadSingle()
                    };
                default:
                    MessageBox.Show("Unknown operation type: " + Type);
                    return new object[0];
            }
        }

        public static void Write(BinaryWriter bw, int Type, int Version, object[] data)
        {
            switch (Type)
            {
                case 0:
                    bw.Write(Convert.ToInt32(data[0]));
                    break;
                case 1:
                    bw.Write(Convert.ToInt32(data[0]));
                    bw.Write(Convert.ToInt32(data[1]));
                    break;
                case 2:
                    byte[] text = Encoding.Unicode.GetBytes(data[0].ToString() + data[1].ToString());
                    bw.Write(text.Length);
                    bw.Write(text);
                    if (Version > 16)
                    {
                        bw.Write(Convert.ToInt32(data[2]));
                    }
                    break;
                case 3:
                    break;
                case 4:
                    bw.Write(Convert.ToInt32(data[0]));
                    break;
                case 5:
                    bw.Write(Convert.ToInt32(data[0]));
                    break;
                case 6:
                    bw.Write(Convert.ToInt32(data[0]));
                    break;
                case 7:
                    bw.Write(Convert.ToInt32(data[0]));
                    bw.Write(Convert.ToInt32(data[1]));
                    bw.Write(Convert.ToInt32(data[2]));
                    break;
                case 8:
                    bw.Write(Convert.ToInt32(data[0]));
                    break;
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    break;
                case 14:
                    bw.Write(Convert.ToInt32(data[0]));
                    bw.Write(Convert.ToInt32(data[1]));
                    break;
                case 15:
                    bw.Write(Convert.ToInt32(data[0]));
                    bw.Write(Convert.ToInt32(data[1]));
                    bw.Write(Convert.ToInt32(data[2]));
                    break;
                case 16:
                    bw.Write(Convert.ToInt32(data[0]));
                    bw.Write(Convert.ToInt32(data[1]));
                    break;
                case 17:
                    bw.Write(Convert.ToInt32(data[0]));
                    bw.Write(Convert.ToInt32(data[1]));
                    bw.Write(Convert.ToInt32(data[2]));
                    bw.Write(Convert.ToInt32(data[3]));
                    bw.Write(Convert.ToInt32(data[4]));
                    bw.Write(Convert.ToInt32(data[5]));
                    break;
                case 18:
                    bw.Write(Convert.ToInt32(data[0]));
                    bw.Write(Convert.ToInt32(data[1]));
                    bw.Write(Convert.ToInt32(data[2]));
                    bw.Write(Convert.ToInt32(data[3]));
                    break;
                case 19:
                    bw.Write(new AIFile().GBKStringToBytes(data[0].ToString()));
                    bw.Write(Convert.ToInt32(data[1]));
                    bw.Write(Convert.ToInt32(data[2]));
                    bw.Write(Convert.ToInt32(data[3]));
                    break;
                case 20:
                    bw.Write(Convert.ToInt32(data[0]));
                    bw.Write(Convert.ToInt32(data[1]));
                    break;
                case 21:
                    bw.Write(Convert.ToInt32(data[0]));
                    bw.Write(Convert.ToInt32(data[1]));
                    bw.Write(Convert.ToInt32(data[2]));
                    break;
                case 22:
                    bw.Write(Convert.ToInt32(data[0]));
                    break;
                case 23:
                    bw.Write(Convert.ToInt32(data[0]));
                    bw.Write(Convert.ToInt32(data[1]));
                    bw.Write(Convert.ToInt32(data[2]));
                    bw.Write(Convert.ToInt32(data[3]));
                    bw.Write(Convert.ToInt32(data[4]));
                    bw.Write(Convert.ToInt32(data[5]));
                    bw.Write(Convert.ToInt32(data[6]));
                    break;
                case 24:
                    bw.Write(Convert.ToInt32(data[0]));
                    bw.Write(Convert.ToInt32(data[1]));
                    bw.Write(Convert.ToInt32(data[2]));
                    bw.Write(Convert.ToInt32(data[3]));
                    bw.Write(Convert.ToInt32(data[4]));
                    bw.Write(Convert.ToInt32(data[5]));
                    bw.Write(Convert.ToInt32(data[6]));
                    bw.Write(Convert.ToInt32(data[7]));
                    bw.Write(Convert.ToInt32(data[8]));
                    break;
                case 25:
                    bw.Write(Convert.ToInt32(data[0]));
                    bw.Write(Convert.ToInt32(data[1]));
                    bw.Write(Convert.ToInt32(data[2]));
                    bw.Write(Convert.ToInt32(data[3]));
                    bw.Write(Convert.ToInt32(data[4]));
                    break;
                case 26:
                    bw.Write(Convert.ToInt32(data[0]));
                    bw.Write(Convert.ToInt32(data[1]));
                    bw.Write(Convert.ToInt32(data[2]));
                    bw.Write(Convert.ToInt32(data[3]));
                    break;
                case 27:
                    bw.Write(Convert.ToInt32(data[0]));
                    bw.Write(Convert.ToInt32(data[1]));
                    bw.Write(Convert.ToInt32(data[2]));
                    break;
                case 28:
                    bw.Write(Convert.ToInt32(data[0]));
                    bw.Write(Convert.ToInt32(data[1]));
                    break;
                case 29:
                    bw.Write(Convert.ToInt32(data[0]));
                    bw.Write(Convert.ToInt32(data[1]));
                    bw.Write(Convert.ToInt32(data[2]));
                    bw.Write(Convert.ToInt32(data[3]));
                    bw.Write(Convert.ToInt32(data[4]));
                    bw.Write(Convert.ToInt32(data[5]));
                    bw.Write(Convert.ToInt32(data[6]));
                    break;
                case 30:
                    bw.Write(Convert.ToInt32(data[0]));
                    bw.Write(Convert.ToInt32(data[1]));
                    bw.Write(Convert.ToInt32(data[2]));
                    bw.Write(Convert.ToInt32(data[3]));
                    bw.Write(Convert.ToInt32(data[4]));
                    bw.Write(Convert.ToInt32(data[5]));
                    bw.Write(Convert.ToInt32(data[6]));
                    bw.Write(Convert.ToInt32(data[7]));
                    bw.Write(Convert.ToInt32(data[8]));
                    break;
                case 31:
                    bw.Write(Convert.ToInt32(data[0]));
                    bw.Write(Convert.ToSingle(data[1]));
                    bw.Write(Convert.ToDouble(data[2]));
                    bw.Write(Convert.ToSingle(data[3]));
                    bw.Write(Convert.ToDouble(data[4]));
                    break;
                case 32:
                    bw.Write(Convert.ToInt32(data[0]));
                    bw.Write(Convert.ToInt32(data[1]));
                    bw.Write(Convert.ToInt32(data[2]));
                    bw.Write(Convert.ToInt32(data[3]));
                    break;
                case 33:
                    bw.Write(Convert.ToSingle(data[0]));
                    bw.Write(Convert.ToDouble(data[1]));
                    bw.Write(Convert.ToSingle(data[2]));
                    bw.Write(Convert.ToDouble(data[3]));
                    break;
                default:
                    MessageBox.Show("Unknown operation type: " + Type);
                    break;
            }
        }

        public static object[] GetEmptyOperation(int Type, int Version)
        {
            switch (Type)
            {
                case 0:
                    return new object[] { 0 };
                case 1:
                    return new object[] { 0, 0 };
                case 2:
                    if (Version > 16)
                    {
                        return new object[] { "", "message", 0 };
                    }
                    else
                    {
                        return new object[] { "", "message" };
                    }
                case 3:
                    return new object[0];
                case 4:
                    return new object[] { 0 };
                case 5:
                    return new object[] { 0 };
                case 6:
                    return new object[] { 0 };
                case 7:
                    return new object[] { 0, 0, 0 };
                case 8:
                    return new object[] { 0 };
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    return new object[0];
                case 14:
                    return new object[] { 0, 0 };
                case 15:
                    return new object[] { 0, 0, 0 };
                case 16:
                    return new object[] { 0, 0 };
                case 17:
                    return new object[] { 0, 0, 0, 0, 0, 0 };
                case 18:
                    return new object[] { 0, 0, 0, 0 };
                case 19:
                    return new object[] { "", 0, 0, 0 };
                case 20:
                    return new object[] { 0, 0 };
                case 21:
                    return new object[] { 0, 0, 0 };
                case 22:
                    return new object[] { 0 };
                case 23:
                    return new object[] { 0, 0, 0, 0, 0, 0, 0 };
                case 24:
                    return new object[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                case 25:
                    return new object[] { 0, 0, 0, 0, 0 };
                case 26:
                    return new object[] { 0, 0, 0, 0 };
                case 27:
                    return new object[] { 0, 0, 0 };
                case 28:
                    return new object[] { 0, 0 };
                case 29:
                    return new object[] { 0, 0, 0, 0, 0, 0, 0 };
                case 30:
                    return new object[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                case 31:
                    return new object[] { 0, 0, 0, 0, 0 };
                case 32:
                    return new object[] { 0, 0, 0, 0 };
                case 33:
                    return new object[] { 0, 0, 0, 0 };
                default:
                    MessageBox.Show("Unknown operation type: " + Type);
                    return new object[0];
            }
        }

        public static (string[] Fields, string Name) GetInfo(int Type, int Version)
        {
            switch (Type)
            {
                case 0:
                    return (new string[] { "Type" }, "attack_type");
                case 1:
                    return (new string[] { "Skill", "Level" }, "use_skill");
                case 2:
                    if (Version > 16)
                    {
                        return (new string[] { "channel", "msg", "AppendDataMask" }, "talk");
                    }
                    else
                    {
                        return (new string[] { "channel", "msg" }, "talk");
                    }
                case 3:
                    return (new string[0], "reset_hate_list");
                case 4:
                    return (new string[] { "ID" }, "run_trigger");
                case 5:
                    return (new string[] { "ID" }, "stop_trigger");
                case 6:
                    return (new string[] { "ID" }, "active_trigger");
                case 7:
                    return (new string[] { "ID", "Period", "Counter" }, "create_timer");
                case 8:
                    return (new string[] { "ID" }, "kill_timer");
                case 9:
                    return (new string[0], "flee");
                case 10:
                    return (new string[0], "set_hate_tfirst");
                case 11:
                    return (new string[0], "set_hate_tlast");
                case 12:
                    return (new string[0], "set_hate_fifty_percent");
                case 13:
                    return (new string[0], "skip_operation");
                case 14:
                    return (new string[] { "ID", "ctrl_id" }, "active_controller");
                case 15:
                    return (new string[] { "ID", "Value", "IsValue" }, "set_global");
                case 16:
                    return (new string[] { "ID", "Value" }, "revise_global");
                case 17:
                    return (new string[] { "MonsterID", "Range", "Life", "DispearCondition", "PathID", "MonsterNum" }, "summon_monster");
                case 18:
                    return (new string[] { "WorldID", "PathID", "PatrolType", "SpeedType" }, "walk_along");
                case 19:
                    return (new string[] { "ActionName", "LoopCount", "Interval", "PlayTime" }, "play_action");
                case 20:
                    return (new string[] { "ID", "Value" }, "revise_history");
                case 21:
                    return (new string[] { "ID", "Value", "IsHistoryValue" }, "set_history");
                case 22:
                    return (new string[] { "PointType" }, "deliver_faction_pvp_points");
                case 23:
                    return (new string[] { "Dst", "VarType", "Src1", "VarType", "OperatorType", "Src2", "VarType" }, "calc_var");
                case 24:
                    return (new string[] { "DispearCondition", "MonsterID", "MonsterIDType", "Range", "Life", "PathID", "PathIDType", "MonsterNum", "MonsterNumType" }, "summon_monster_2");
                case 25:
                    return (new string[] { "WorldID", "PathID", "PathIDType", "PatrolType", "SpeedType" }, "walk_along_2");
                case 26:
                    return (new string[] { "Skill", "SkillType", "Level", "LevelType" }, "use_skill_2");
                case 27:
                    return (new string[] { "ID", "IDType", "Stop" }, "active_controller_2");
                case 28:
                    return (new string[] { "ID", "IDType" }, "deliver_task");
                case 29:
                    return (new string[] { "LifeType", "MineID", "MineIDType", "Range", "Life", "MineNum", "MineNumType" }, "summon_mine");
                case 30:
                    return (new string[] { "LifeType", "NPCID", "NPCIDType", "Range", "Life", "PathID", "PathIDType", "NPCNum", "NPCNumType" }, "summon_npc");
                case 31:
                    return (new string[] { "ID", "min_x", "min_y", "min_z", "max_x", "max_y", "max_z" }, "deliver_random_task_in_region");
                case 32:
                    return (new string[] { "ID", "IDType", "Range", "PlayerNum" }, "deliver_task_in_hate_list");
                case 33:
                    return (new string[] { "min_x", "min_y", "min_z", "max_x", "max_y", "max_z" }, "clear_tower_task_in_region");
                default:
                    MessageBox.Show("Unknown operation type: " + Type);
                    return (new string[0], "Unk");
            }
        }
    }
}
