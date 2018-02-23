using System;
using System.Windows.Forms;

namespace NextAIPolicyEditor2
{
    public static class Conditions
    {
        public static int[] Non_central()
        {
            return new int[] { 0, 1, 2, 3, 4, 8, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };
        }

        public static object[] Read(byte[] data, int type)
        {
            byte[] val1 = new byte[4];
            byte[] val2 = new byte[4];
            switch (type)
            {
                case 1:
                case 3:
                    Array.Copy(data, val1, 4);
                    return new object[] { BitConverter.ToSingle(val1, 0) };
                case 0:
                case 16:
                case 17:
                case 19:
                case 20:
                case 21:
                case 23:
                case 25:
                    Array.Copy(data, val1, 4);
                    return new object[] { BitConverter.ToInt32(val1, 0) };
                case 18:
                case 24:
                    Array.Copy(data, val1, 4);
                    Array.Copy(data, 4, val2, 0, 4);
                    return new object[] { BitConverter.ToInt32(val1, 0), BitConverter.ToInt32(val2, 0) };
                default:
                    return new object[0];
            }
        }

        public static byte[] Write(object[] param, int type)
        {
            param[0] = param[0] == null ? null : param[0].ToString().Replace('.', ',');
            switch (type)
            {
                case 1:
                case 3:
                    return BitConverter.GetBytes(Convert.ToSingle(param[0]));
                case 0:
                case 16:
                case 17:
                case 19:
                case 20:
                case 21:
                case 23:
                case 25:
                    return BitConverter.GetBytes(Convert.ToInt32(param[0]));
                case 18:
                case 24:
                    byte[] data = new byte[8];
                    Array.Copy(BitConverter.GetBytes(Convert.ToInt32(param[0])), data, 4);
                    Array.Copy(BitConverter.GetBytes(Convert.ToInt32(param[1])), 4, data, 0, 4);
                    return data;
                default:
                    return new byte[0];
            }
        }

        public static byte[] CreateEmptyCondition(int type)
        {
            switch (type)
            {
                case 1:
                case 3:
                    return BitConverter.GetBytes(0);
                case 0:
                case 16:
                case 17:
                case 19:
                case 20:
                case 21:
                case 23:
                case 25:
                    return BitConverter.GetBytes(0);
                case 18:
                case 24:
                    byte[] data = new byte[8];
                    Array.Copy(BitConverter.GetBytes(0), data, 4);
                    Array.Copy(BitConverter.GetBytes(0), 4, data, 0, 4);
                    return data;
                default:
                    return new byte[0];
            }
        }

        public static int GetTypeByID(int type)
        {
            switch (type)
            {
                case 6:
                case 7:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    return 1;
                case 5:
                    return 2;
                default:
                    return 3;
            }
        }

        public static void SetSubnoteByID(ref CTriggerDataCondition ctdc)
        {
            switch (ctdc.OperID)
            {
                case 6:
                case 7:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    ctdc.SubNodeL = 2;
                    ctdc.SubNodeR = 4;
                    break;
                case 5:
                    ctdc.SubNodeL = 4;
                    ctdc.SubNodeR = 0;
                    break;
                default:
                    ctdc.SubNodeL = 0;
                    ctdc.SubNodeR = 0;
                    break;
            }
        }

        public static (string[] Fields, string Name) GetInfo(int Type)
        {
            switch (Type)
            {
                case 0:
                    return (new string[] { "ID" }, "time_come");
                case 1:
                    return (new string[] { "Percent" }, "hp_less");
                case 2:
                    return (new string[0], "start_combat");
                case 3:
                    return (new string[] { "Probability" }, "random");
                case 4:
                    return (new string[0], "kill_target");
                case 5:
                    return (new string[0], "not");
                case 6:
                    return (new string[0], "or");
                case 7:
                    return (new string[0], "and");
                case 8:
                    return (new string[0], "on_death");
                case 9:
                    return (new string[0], "plus");
                case 10:
                    return (new string[0], "minus");
                case 11:
                    return (new string[0], "multiply");
                case 12:
                    return (new string[0], "divide");
                case 13:
                    return (new string[0], "compare_greater");
                case 14:
                    return (new string[0], "compare_less");
                case 15:
                    return (new string[0], "compare_equal");
                case 16:
                    return (new string[] { "ID" }, "common_data");
                case 17:
                    return (new string[] { "Value" }, "constant");
                case 18:
                    return (new string[] { "min_damage", "max_damage" }, "on_damage");
                case 19:
                    return (new string[] { "PathID" }, "path_end");
                case 20:
                    return (new string[] { "ID" }, "at_history_stage");
                case 21:
                    return (new string[] { "Value" }, "history_value");
                case 22:
                    return (new string[0], "end_combat");
                case 23:
                    return (new string[] { "ID" }, "local_value");
                case 24:
                    return (new string[] { "PathID", "PathIDType" }, "path_end_2");
                case 25:
                    return (new string[] { "ID" }, "spec_filter");
                case 26:
                    return (new string[0], "room_index");
                default:
                    MessageBox.Show("Unknown condition type: " + Type);
                    return (new string[0], "Unk");
            }
        }
    }
}
