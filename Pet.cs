using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    internal abstract class Pet
    {
        public string Firstname { get; }

        public Pet(string firstname)
        {
            Firstname = firstname;
        }

        public abstract string MakeNoise();

        public override string ToString()
        {
            return $"{Firstname} and I am a {GetType().Name} and I {MakeNoise()}";
        }
    }
}
