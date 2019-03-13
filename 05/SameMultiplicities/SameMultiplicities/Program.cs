using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SameMultiplicities
{
    class Program
    {
        public static bool result;
        static void Main(string[] args)
        {

                int[] a = new int[] { 5, 144, 19, 161, 19, 144, 19, 11, 15};
                int[] b = new int[] { 25, 625, 20736, 361, 25921, 361, 20736, 361, 121};

                    PrintArray(a);
                    PrintArray(b);

                result = comp(a, b);

            Console.WriteLine($"Результат: {result}");
            Console.ReadLine();
        }

        static public bool comp(int[] a, int[] b)
        {
            bool _result = false;

                for (int i = 1; i < a.Length; i++)
                {
                        if (CheckSqrNum(b[0]) && a[i-1] == Math.Sqrt(b[i]))
                        {
                            _result = true;
                        }
                            else
                            {
                                _result = false;
                            }
            }
            return _result;
        }

        static void PrintArray (int[] array)
        {
            Console.WriteLine("Заданный массив:");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("{0}\t", array[i]);
                }

            Console.WriteLine();
        }

        static bool CheckSqrNum(int number)
        {
            double n = 0;
            bool check = false;

            n = Math.Sqrt(number);

                if (n == (int)n && number != 0)
                {
                    check = true; ;
                }

            return check;
        }
    }
}
