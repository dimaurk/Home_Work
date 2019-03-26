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

        public void GetCompression(string sourceFile, string compressedFile)
        {
            using (FileStream readStr = new FileStream(sourceFile, FileMode.OpenOrCreate))
            {
                using (FileStream writeStr = File.Create(compressedFile))
                {
                    using (GZipStream archiveStr = new GZipStream(writeStr, CompressionMode.Compress))
                    {
                        readStr.CopyTo(archiveStr);
                        Console.WriteLine("Сжатие файла {0} завершено. Исходный размер: {1}  сжатый размер: {2}.",
                            sourceFile, readStr.Length.ToString(), writeStr.Length.ToString());
                    }
                }
            }
        }
        public void GetDecompression(string compressedFile, string targetFile)
        {
            using (FileStream readStr = new FileStream(compressedFile, FileMode.OpenOrCreate))
            {
                using (FileStream writeStr = File.Create(targetFile))
                {
                    using (GZipStream unarchiveStr = new GZipStream(readStr, CompressionMode.Decompress))
                    {
                        unarchiveStr.CopyTo(writeStr);
                        Console.WriteLine("Восстановлен файл: {0}", targetFile);
                    }
                }
            }
        }
    }
}
