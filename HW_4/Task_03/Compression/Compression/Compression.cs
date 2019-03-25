using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Compression
{
    class Compression
    {

        public static string _str = string.Empty;

        public void GetCompression(string str)
        {
            _str = str;

            using (StreamReader reader = new StreamReader(@"goncharov_ivan-obyknovennaja_istorija.txt", Encoding.Default))
            {
                str = reader.ReadToEnd();
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"pack.txt"))
            {
                file.Write((new Regex("Гончаров")).Replace(str, "010"));
            }
        }
        public void GetDecompression(string str)
        {
            _str = str;

            using (StreamReader reader = new StreamReader(@"pack.txt"))
            {
                str = reader.ReadToEnd();
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"unpack.txt"))
            {
                file.Write((new Regex("010")).Replace(str, "Гончаров"));
            }
        }
    }
}
