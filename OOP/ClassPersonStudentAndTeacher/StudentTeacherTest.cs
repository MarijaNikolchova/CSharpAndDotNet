using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPersonStudentAndTeacher
{
    public static class StudentTeacherTest
    {
        public static void Main()
        {
            Person person = new Person();
            person.Greeting();
            Student student = new Student();
            student.SetAge(21);
            student.Greeting();
            student.ShowAge();
            student.Study();
            Teacher teacher = new Teacher();
            teacher.Greeting();
            teacher.Explain();
        }
    }
}
