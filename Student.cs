using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Student
    {
        public Student(string firstname, string lastname, string course, int year, int semester)
        {
            Firstname = firstname;
            Lastname = lastname;
            this.course = course;
            Year = year;
            Semester = semester;
        }

        private readonly string course;

        public string Firstname { get; }
        public string Lastname { get; }
        public string Course { 
            get { return course.ToUpper(); }
        }
        public int Year { get; }

        public int Semester { get; }

        public void StudentInfo()
        {
            Console.WriteLine($"Firstname: {Firstname}");
            Console.WriteLine($"Lastname: {Lastname}");
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Semester: {Semester}");
            Console.WriteLine();
        }
    }
}
