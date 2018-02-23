using System.IO;
using System.Collections.Generic;
using System.Text;
using System;
using System.Windows.Forms;
using System.Linq;

namespace NextAIPolicyEditor2.ElementsFile
{
    class eFile
    {
        public short version;
        public short sig;
        public List<eList> lists;
        public eFile()
        {
            lists = new List<eList>();
        }
    }

    class ElementsData
    {
        string fPath;

        public eFile Elements = new eFile();

        MainForm f;

        public ElementsData(string path, MainForm f)
        {
            this.f = f;
            fPath = path;
        }

        public void Read()
        {
            BinaryReader br = new BinaryReader(new FileStream(fPath, FileMode.Open, FileAccess.Read));
            Elements.version = br.ReadInt16();
            Elements.sig = br.ReadInt16();
            ConfLoader cf = new ConfLoader();
            if (cf.Load(Elements.version))
            {
                f.Progress.Maximum = cf.config.lists.Count;
                f.Progress.Value = 0;
                for (int i = 0; i < cf.config.lists.Count; ++i)
                {
                    ++f.Progress.Value;
                    if (cf.config.lists[i].offset > 0)
                    {
                        cf.config.lists[i].header = br.ReadBytes(cf.config.lists[i].offset);
                    }
                    else
                    {
                        if (i == 20)
                        {
                            byte[] head = br.ReadBytes(4);
                            byte[] count = br.ReadBytes(4);
                            byte[] body = br.ReadBytes(BitConverter.ToInt32(count, 0));
                            byte[] tail = br.ReadBytes(4);
                            cf.config.lists[i].header = new byte[head.Length + count.Length + body.Length + tail.Length];
                            Array.Copy(head, 0, cf.config.lists[i].header, 0, head.Length);
                            Array.Copy(count, 0, cf.config.lists[i].header, 4, count.Length);
                            Array.Copy(body, 0, cf.config.lists[i].header, 8, body.Length);
                            Array.Copy(tail, 0, cf.config.lists[i].header, 8 + body.Length, tail.Length);
                        }
                        if (i == 100)
                        {
                            byte[] head = br.ReadBytes(4);
                            byte[] count = br.ReadBytes(4);
                            byte[] body = br.ReadBytes(BitConverter.ToInt32(count, 0));
                            cf.config.lists[i].header = new byte[head.Length + count.Length + body.Length];
                            Array.Copy(head, 0, cf.config.lists[i].header, 0, head.Length);
                            Array.Copy(count, 0, cf.config.lists[i].header, 4, count.Length);
                            Array.Copy(body, 0, cf.config.lists[i].header, 8, body.Length);
                        }
                    }
                    if (i == cf.config.conv_list)
                    {
                        byte[] pattern = (Encoding.GetEncoding("GBK")).GetBytes("facedata\\");
                        long sourcePosition = br.BaseStream.Position;
                        int listLength = -72 - pattern.Length;
                        bool run = true;
                        while (run)
                        {
                            run = false;
                            for (int x = 0; x < pattern.Length; x++)
                            {
                                listLength++;
                                if (br.ReadByte() != pattern[x])
                                {
                                    run = true;
                                    break;
                                }
                            }
                        }
                        br.BaseStream.Position = sourcePosition;
                        cf.config.lists[i].types[0] = "byte:" + listLength;
                        eItem item = new eItem();
                        item.values.Add(ReadValue(br, cf.config.lists[i].types[0]));
                        cf.config.lists[i].items.Add(item);
                    }
                    else
                    {
                        int count = br.ReadInt32();
                        for (int j = 0; j < count; ++j)
                        {
                            Application.DoEvents();
                            eItem item = new eItem();
                            for (int k = 0; k < cf.config.lists[i].types.Count; ++k)
                            {
                                item.values.Add(ReadValue(br, cf.config.lists[i].types[k]));
                                if (cf.config.lists[i].fields[k].ToLower() == "id")
                                {
                                    item.ID = Convert.ToInt32(item.values.Last());
                                }
                                else if (cf.config.lists[i].fields[k].ToLower() == "name")
                                {
                                    item.name = item.values.Last().ToString();
                                }
                            }
                            cf.config.lists[i].items.Add(item);
                        }
                    }
                    Elements.lists.Add(cf.config.lists[i]);
                }
            }
            br.Close();
            MessageBox.Show("Загружен Elements.data версии: " + Elements.version);
            f.Progress.Value = 0;
        }

        object ReadValue(BinaryReader br, string type)
        {
            if (type.Contains("int32") || type.Contains("link") || type.Contains("combo"))
            {
                return br.ReadInt32();
            }
            else if (type.Contains("float"))
            {
                return br.ReadSingle();
            }
            else if (type.Contains("byte"))
            {
                return br.ReadBytes(Convert.ToInt32(type.Split(':')[1]));
            }
            else if (type.Contains("wstring"))
            {
                return Encoding.Unicode.GetString(br.ReadBytes(Convert.ToInt32(type.Split(':')[1]))).ToString().Split('\0')[0];
            }
            else if (type.Contains("string"))
            {
                return Encoding.GetEncoding("GBK").GetString(br.ReadBytes(Convert.ToInt32(type.Split(':')[1]))).ToString().Split('\0')[0];
            }
            else
            {
                return "";
            }
        }

        public void Save()
        {

        }
    }
}
