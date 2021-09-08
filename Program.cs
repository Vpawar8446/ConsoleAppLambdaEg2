using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppLambdaEg2
{
    class Student
    {  
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student {Name ="John", Age=24},
                new Student {Name="Smith", Age=20},
                new Student {Name="Sandy", Age=23}
            };

            var names = students.Select(x => x.Name);
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();

            /*var age = students.Select(x => x.Age);
            foreach (var ages in age)
            {
                Console.WriteLine(ages);
            }
            Console.Read();*/
        }
    }
}
