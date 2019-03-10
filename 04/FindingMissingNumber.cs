using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingMissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива: ");
            int NumbersInArray = Convert.ToInt32(Console.ReadLine()); 
            
            int[] array = new int[NumbersInArray];

                for (int i = 0; i < array.Length; i++) 
                {
                    Console.WriteLine("Введите элементы массива: ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

            Console.WriteLine();

                for (int i = 0; i < array.Length; i++) 
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();

           Console.WriteLine(FindingNumber(array, NumbersInArray));
           Console.ReadLine();
        }

        public static int FindingNumber(int[] array, int NumbersInArray) 
        {
            var missing = Enumerable.Range(array[0], NumbersInArray).Except(array);
           
                foreach (int j in missing)
                {
                    Console.WriteLine("Пропущенное число: " + j);
                }
            
            return -1;
        }
    }
}
