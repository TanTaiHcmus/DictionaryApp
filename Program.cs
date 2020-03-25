using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Collections;

namespace Dictionary2
{   
    class Hash
    {
        private static Hashtable hashtable;
        private static string key;
        private static string sub;
        public static void create()
        {
            hashtable = new Hashtable();
            FileStream f = new FileStream("Dictionary.txt", FileMode.Open);
            StreamReader read = new StreamReader(f, Encoding.UTF8);
            string dword;
            while ((dword = read.ReadLine()) != null)
            {
                int pos = dword.IndexOf("  ");
                if (pos != -1)
                {
                    if (!hashtable.ContainsKey(dword.Substring(0, pos)))
                        hashtable.Add(dword.Substring(0, pos), dword.Substring(pos + 2));
                }
            }
            read.Close();
        }

        public static string Key
        {
            get { return key; }
            set { key = value; }
        }

        public static string Sub
        {
            get { return sub; }
            set { sub = value; }
        }

        public static bool kiemtra()
        {
            if (hashtable.ContainsKey(key)) return true;
            else return false;
        }

        public static string getSub()
        {
            return (hashtable[key].ToString());
        }

        public static bool Add()
        {
            if (!hashtable.ContainsKey(key))
            {
                hashtable.Add(key, sub);
                return true;
            }
            else return false;
        }

        public static bool Edit()
        {
            if (hashtable.ContainsKey(key))
            {
                hashtable[key] = sub;
                return true;
            }
            else return false;
        }
        public static bool Delete()
        {
            if (hashtable.ContainsKey(key))
            {
                hashtable.Remove(key);
                return true;
            }
            else return false;
        }

        public static void Create()
        {
            if (File.Exists(key))
                File.Delete(key);
            FileStream f = new FileStream(key, FileMode.Create);
            StreamWriter writer = new StreamWriter(f);
            foreach (DictionaryEntry str in hashtable)
                writer.WriteLine(str.Key + "  " + str.Value);
            writer.Close();
        }
    }
    class Program
    {
        static void Main()
        {
            Hash.create();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome());
        }
    }
}
