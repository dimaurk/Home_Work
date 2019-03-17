using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Student : Man
    {
        public int _yearOfStudy;
        const int yearP1 = 1;

        public Student() : this(1)
        {
        }

        public Student(int yearOfStudy)
        {
           
        }

        public int InputYear()
        {
            Console.WriteLine("Enter year of study:");
            _yearOfStudy = Convert.ToInt32(Console.ReadLine());
            return _yearOfStudy;
        }
        
        public int IncreaseYear()
        {
            return _yearOfStudy += 1;
        }
    }
}
