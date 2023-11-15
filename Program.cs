using System;
using School;
using PetStore;

namespace HelloWorld
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person("Onyeka", "Nwizu", new DateOnly(2002,1,1));
            var person2 = new Person("Favour", "Ike", new DateOnly(2000, 1, 1));

            person.Pets.Add(new Dog("Nwanku"));
            person.Pets.Add(new Dog("Freddy"));

            person2.Pets.Add(new Cat("Miss Linda"));

            var people = new List<Person>() { person, person2 };

            foreach (var p in people)
            {
                Console.WriteLine(p);
                foreach (var pets in p.Pets)
                {
                    Console.WriteLine($" - { pets }");
                }
            }

            Console.WriteLine();
            var student = new Student(firstname: "Ada", lastname:"ike", course:"bscs", year:2, semester:1);
            student.StudentInfo();
        }
    }
}