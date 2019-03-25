using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Compression
{
    class Program
    {
        static void Main(string[] args)
        {
            Compression first = new Compression();
            string str1 = Compression._str;

            first.GetCompression(str1);
            first.GetDecompression(str1);
            Console.WriteLine("Файл 'сжат' и 'восстановлен'");
            Console.ReadLine();
        }
    }
}
