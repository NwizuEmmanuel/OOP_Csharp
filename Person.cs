using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    internal class Person
    {
        public string Firstname { get; }
        public string Lastname { get; }
        public DateOnly Birthday { get; }
        public List<Pet> Pets { get; }

        public Person(string firstname, string lastname, DateOnly birthday)
        {
            Firstname = firstname;
            Lastname = lastname;
            Birthday = birthday;
            Pets = new List<Pet>();
        }

        public override string ToString()
        {
            return $"Human: {Firstname} {Lastname}";
        }
    }
}
