using System;
using System.Collections.Generic;
using System.Text;

namespace laba4_program
{
    class Dog : Pet
    {
         
        public Dog(string name, string color, string voice, Type animal) : base(name, color, voice, animal) { }

        public override void Say()  
        {
            Console.WriteLine($"Собака {Name} гавкає");
        }
    }
}
