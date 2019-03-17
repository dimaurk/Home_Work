using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Man
    {
        public string _name;
        public int _age;
        public string _gender;
        public int _weight;

        public Man():this("name",0, "gender", 0)
        {
        }

        public Man(string name, int age, string gender, int weight)
        {
            _name = name;
            _age = age;
            _gender = gender;
            _weight = weight;
        }

        public string InputName(string name)
        {
            _name = name;
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            return name;
        }

        public int InputAge(int age)
        {
            _age = age;
            Console.WriteLine("Enter age:");
            age = Convert.ToInt32(Console.ReadLine());
            return age;
        }

        public string InputGender(string gender)
        {
            _gender = gender;
            Console.WriteLine("Enter gender:");
            gender = Console.ReadLine();
            return gender;
        }

        public int InputWeight(int weight)
        {
            _weight = weight;
            Console.WriteLine("Enter weight:");
            weight = Convert.ToInt32(Console.ReadLine());
            return weight;
        }
    }
}
