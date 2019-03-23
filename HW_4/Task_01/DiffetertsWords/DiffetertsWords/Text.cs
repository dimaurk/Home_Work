using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffetertsWords
{
    class Text
    {
        private static string _str = "Hi, how are you. Hi, i am fine thanks, and how are you. \n";

        public static string _Str
        {
            get
            {
                return _str;
            }

            set
            {
                _str = value;
            }
        }

        public Text(string str)
        {
            _Str = str;
        }

        public static void ReadText(string str)
        {
            _Str = str;
            Console.WriteLine(str);
        }

        public static void SortText(string str)
        {
            _Str = str;

            string[] array = str.Split(new char[] { '\n', '\r', ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            var sort = array.GroupBy(n => n.ToLower());

            foreach (var s in sort)
            {
                Console.WriteLine("Слово - {0} [количесво повторений: {1}]", s.Key, s.Count());
            }
        }
    }
}
