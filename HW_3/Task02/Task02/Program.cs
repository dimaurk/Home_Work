using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {

            Flowers[] bouquet = new Flowers[5]
            {   new Rose(5,"rose"),
                new Gvozdika(3,"gvozdika"),
                new Tulip(4,"tulip"),
                new Rose(5,"rose"),
                new Dandelion(2,"dundelion")   };

            foreach (Flowers i in bouquet)
            {
                Console.WriteLine(i.ToString());
            }

            int AllPrice = 0;
            for (int i = 0; i < bouquet.Length; i++)
            {
                AllPrice = i + 1;
            }

            Console.WriteLine();
            Console.WriteLine($"Bouquet price:{AllPrice}");
            Console.ReadLine();
        }
    }
}
