using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace NextAIPolicyEditor2.ElementsFile
{
    class eConfig
    {
        public int list_count { get; set; }
        public int conv_list { get; set; }
        public List<eList> lists { get; set; }
        public eConfig()
        {
            lists = new List<eList>();
        }
    }
    
    class eList
    {
        public string name { get; set; }
        public int offset { get; set; }
        public byte[] header { get; set; }
        public List<string> fields { get; set; }
        public List<string> fields_translated { get; set; }
        public List<string> types { get; set; }
        public List<eItem> items { get; set; }
        public eList()
        {
            offset = -1;
            fields = new List<string>();
            fields_translated = new List<string>();
            types = new List<string>();
            items = new List<eItem>();
        }
    }

    class eItem
    {
        public int ID { get; set; }
        public string name { get; set; }
        public List<object> values { get; set; }
        public eItem()
        {
            values = new List<object>();
        }
    }

    class ConfLoader
    {
        public eConfig config = new eConfig();

        public bool Load(int version)
        {
            string[] cpath = Directory.GetFiles(Application.StartupPath + "\\Configs", "PW_*_v" + version + ".cfg");
            if (cpath.Length == 0)
            {
                MessageBox.Show("Unknown file version: " + version);
                return false;
            }
            else
            {
                StreamReader sr = new StreamReader(cpath[0]);
                config.list_count = Convert.ToInt32(sr.ReadLine());
                config.conv_list = Convert.ToInt32(sr.ReadLine());
                for (int i = 0; i < config.list_count; ++i)
                {
                    Application.DoEvents();
                    string line = "";
                    while (string.IsNullOrEmpty(line)) { line = sr.ReadLine(); }
                    eList list = new eList();
                    list.name = line;
                    string offset = sr.ReadLine();
                    if (offset != "AUTO")
                    {
                        list.offset = Convert.ToInt32(offset);
                    }
                    string[] fields = sr.ReadLine().Split(';');
                    string[] types = sr.ReadLine().Split(';');
                    for (int j = 0; j < types.Length; ++j)
                    {
                        if (types[j].IndexOf(":") > -1 && !types[j].StartsWith("string") && !types[j].StartsWith("wstring") && !types[j].StartsWith("byte") && !types[j].StartsWith("link") && !types[j].StartsWith("combo"))
                        {
                            int count = Convert.ToInt32(types[j].Split(':')[1]);
                            string type = types[j].Split(':')[0];
                            for (int k = 1; k < count + 1; ++k)
                            {
                                list.types.Add(type);
                                string field = fields[j];
                                if (field.IndexOf("%") > -1)
                                {
                                    field = field.Replace("%", "{0}");
                                    field = string.Format(field, k);
                                }
                                list.fields.Add(field);
                            }
                        }
                        else
                        {
                            list.fields.Add(fields[j]);
                            list.types.Add(types[j]);
                        }
                    }
                    config.lists.Add(list);
                }
                sr.Close();
                return true;
            }
        }
    }
}
