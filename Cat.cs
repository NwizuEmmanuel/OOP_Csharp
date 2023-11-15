using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    internal class Cat : Pet
    {
        public Cat(string firstname) : base(firstname)
        {
        }

        public override string MakeNoise()
        {
            return "Meow";
        }
    }
}
