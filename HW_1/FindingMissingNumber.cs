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

            string[] array = new string[NumbersInArray];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элементы массива: ");
                array[i] = Console.ReadLine();
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

        public static int FindingNumber(string[] array, int NumbersInArray)
        {
            try
            {
                int[] numbers = array.Select(int.Parse).ToArray();

                var missing = Enumerable.Range(numbers[0], NumbersInArray).Except(numbers);

                foreach (var j in missing)
                {
                    Console.WriteLine("Пропущенное число: " + j);
                }
            }
            catch
            {
                Console.WriteLine("Проверьте правильность введеных значений");
            }
            return -1;
        }
    }
}
