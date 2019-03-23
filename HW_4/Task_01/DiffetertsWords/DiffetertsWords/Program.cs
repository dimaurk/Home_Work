using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffetertsWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Text._Str;
            Text.ReadText(str);

            Console.WriteLine("Количество повторений слов:\n");
            Text.SortText(str);

            Console.ReadLine();
        }
    }
}
