using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.IO.Compression;

namespace Compression
{
    class Compression
    {
        public void GetCompression(string readFile, string compFile)
        {
            using (FileStream readStr = new FileStream(readFile, FileMode.OpenOrCreate))
            {
                using (FileStream writeStr = File.Create(compFile))
                {
                    using (GZipStream archiveStr = new GZipStream(writeStr, CompressionMode.Compress))
                    {
                        readStr.CopyTo(archiveStr);
                        Console.WriteLine($"Сжатие файла { readFile } завершено.\n");
                        Console.WriteLine($"Исходный размер: { readStr.Length.ToString() }(байт)");
                        Console.WriteLine($"Сжатый размер: { writeStr.Length.ToString() }(байт).\n");
                    }
                }
            }
        }
        public void GetDecompression(string compFile, string uncopFile)
        {
            using (FileStream readStr = new FileStream(compFile, FileMode.OpenOrCreate))
            {
                using (FileStream writeStr = File.Create(uncopFile))
                {
                    using (GZipStream unarchiveStr = new GZipStream(readStr, CompressionMode.Decompress))
                    {
                        unarchiveStr.CopyTo(writeStr);
                        Console.WriteLine($"Восстановлен файл: { uncopFile }");
                    }
                }
            }
        }
    }
}
