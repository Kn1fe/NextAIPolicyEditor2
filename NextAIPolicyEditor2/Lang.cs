using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace NextAIPolicyEditor2
{
    static public class Lang
    {
        public static Dictionary<string, Dictionary<string, string>> Langs = new Dictionary<string, Dictionary<string, string>>();
        static Dictionary<string, string> _Lang => Langs[CurrentLang];
        static string CurrentLang = "";

        public static void Init()
        {
            string[] files = Directory.GetFiles(Application.StartupPath + "\\Lang", "*.lang");
            foreach (string file in files)
            {
                Dictionary<string, string> l = new Dictionary<string, string>();
                StreamReader sr = new StreamReader(file);
                while (!sr.EndOfStream)
                {
                    string[] t = sr.ReadLine().Split('=');
                    if (t.Length > 1) l.Add(t[0], t[1]);
                }
                sr.Close();
                Langs.Add(Path.GetFileNameWithoutExtension(file), l);
            }
        }

        public static void SetLang(string Lang)
        {
            CurrentLang = Lang;
        }

        public static string Translate(string text)
        {
            return !_Lang.ContainsKey(text) ? text : _Lang[text];
        }
    }
}