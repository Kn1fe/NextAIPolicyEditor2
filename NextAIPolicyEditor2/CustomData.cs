using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NextAIPolicyEditor2.ElementsFile;
using System.IO;

namespace NextAIPolicyEditor2
{
    static class CustomData
    {
        static Dictionary<string, Dictionary<int, string>> Skills = new Dictionary<string, Dictionary<int, string>>();
        static Dictionary<int, string> Mobs = new Dictionary<int, string>();
        static Dictionary<int, string> Npcs = new Dictionary<int, string>();
        static Dictionary<int, string> Mines = new Dictionary<int, string>();
        static Dictionary<int, List<string>> Ai = new Dictionary<int, List<string>>();

        public static void Init()
        {
            string[] files = Directory.GetFiles(Application.StartupPath + "\\Skills", "*.lang");
            foreach (string file in files)
            {
                Dictionary<int, string> list = new Dictionary<int, string>();
                StreamReader sr = new StreamReader(file);
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');
                    list.Add(int.Parse(line[0]), line[1]);
                }
                Skills.Add(Path.GetFileNameWithoutExtension(file), list);
                sr.Close();
            }
        }

        public static void LoadElements(MainForm f)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Mobs.Clear();
                Npcs.Clear();
                Mines.Clear();
                ElementsData el = new ElementsData(ofd.FileName, f);
                el.Read();
                // Mobs
                eList list = el.Elements.lists.Where(x => x.name.Contains("MONSTER_ESSENCE")).ToList().First();
                foreach (eItem item in list.items)
                {
                    Mobs.Add(item.ID, item.name);
                    int.TryParse(item.values[list.fields.IndexOf("common_strategy")].ToString(), out int ai);
                    string name = string.Format("{0}({1})", string.IsNullOrEmpty(item.name) ? "NoName" : item.name, item.ID);
                    if (Ai.ContainsKey(ai))
                    {
                        Ai[ai].Add(name);
                    }
                    else
                    {
                        Ai.Add(ai, new List<string>(new string[] { name }));
                    }
                }
                // Npc
                list = el.Elements.lists.Where(x => x.name.Contains("NPC_ESSENCE")).ToList().First();
                foreach (eItem item in list.items)
                {
                    Npcs.Add(item.ID, item.name);
                }
                // Mine
                list = el.Elements.lists.Where(x => x.name.Contains("MINE_ESSENCE")).ToList().First();
                foreach (eItem item in list.items)
                {
                    Mines.Add(item.ID, item.name);
                }
            }
        }

        public static string GetMob(int id)
        {
            return Mobs.ContainsKey(id) ? Mobs[id] : "";
        }

        public static string GetNpc(int id)
        {
            return Npcs.ContainsKey(id) ? Npcs[id] : "";
        }

        public static string GetMine(int id)
        {
            return Mines.ContainsKey(id) ? Mines[id] : "";
        }

        public static List<string> GetAi(int id)
        {
            return Ai.ContainsKey(id) ? Ai[id] : new List<string>();
        }
    }
}
