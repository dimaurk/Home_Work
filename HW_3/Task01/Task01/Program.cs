using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student");
            Student stud1 = new Student();

            string name = stud1._name;  
            int age = stud1._age;
            string gender = stud1._gender;   
            int weight = stud1._weight;

            Console.WriteLine($"Person1(name:{stud1.InputName(name)}, age:{stud1.InputAge(age)}," +
                                  $"gender:{stud1.InputGender(gender)}, weight:{stud1.InputWeight(weight)}," +
                                  $" Year of study:{stud1.InputYear()}, Year(+1)={stud1.IncreaseYear()})");
 
            Console.WriteLine();


            Console.WriteLine("Teacher");
            Teacher teach1 = new Teacher();

            string subjectOfTeach = teach1._subjectOfTeach;

            Console.WriteLine($"Teacher (name:{teach1.InputName(name)}, age:{teach1.InputAge(age)}," +
                                  $"gender:{teach1.InputGender(gender)}, weight:{teach1.InputWeight(weight)}," +
                                  $"subject:{teach1.InputSubject(subjectOfTeach)})");

            Console.ReadLine();

        }
    }
}
