using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;

namespace Compression
{
    class Program
    {
        static void Main(string[] args)
        {
            Compression first = new Compression();
            string read = "goncharov_ivan-obyknovennaja_istorija.txt";
            string compr = "pack.txt";
            string uncompr = "unpack.txt";

            first.GetCompression(read, compr);
            first.GetDecompression(compr, uncompr);

            Console.ReadLine();
        }
    }
}
