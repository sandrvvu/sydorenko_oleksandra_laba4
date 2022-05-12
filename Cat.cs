using System;
using System.Collections.Generic;
using System.Text;

namespace laba4_program
{
      class Cat : Pet
    {
         
        public Cat(string name, string color, string voice, Type animal) : base(name,color,voice,animal) { }

         public override void Say()
        {
            Console.WriteLine($"Кiт {Name} мявчить");
        }

    }
}
