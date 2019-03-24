using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleConection
{
    class Program
    {
        static void Main(string[] args)
        {
            var newList = new SingleLink<string>();

            newList.AddRecord("привет");
            newList.AddRecord("как");
            newList.AddRecord("дела");

                foreach (var e in newList)
                {
                    Console.WriteLine(e);
                }
                Console.WriteLine();

            //Array.Sort<string>(newList);

                foreach (var e in newList)
                {
                    Console.WriteLine(e);
                }

            Console.ReadLine();
        }
    }
}