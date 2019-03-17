using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Teacher : Man
    {
        public string _subjectOfTeach;

        public Teacher() : this("name", 0, "gender", 0, "subjectOfTeach")
        {
        }

        public Teacher(string name, int age, string gender, int weight, string subjectOfTeach) 
            :base(name, age, gender, weight)
        {
            _subjectOfTeach = subjectOfTeach;
        }

        public string InputSubject(string subjectOfTeach)
        {
            _subjectOfTeach = subjectOfTeach;
            Console.WriteLine("Enter subject of teach:");
            subjectOfTeach = Console.ReadLine();
            return subjectOfTeach;
        }

        //public int GetExperience()
        //{
        //    return _age = _age - 25;
        //}
    }
}
