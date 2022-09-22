using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPersonStudentAndTeacher
{
    public class Person
    {
        internal int Age { get; set; }

        public void Greeting()
        {
            Console.WriteLine("Hello!");
        }

        public void SetAge(int age)
        {
            Age = age;
        }
    }
}
