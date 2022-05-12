using System;
using System.Collections.Generic;
using System.Text;

namespace laba4_program
{
    public abstract class Pet
    {
        public enum Type
        {
            Кiт,
            Собака,
            Папуга
        }

        public string Name { get; }
        public string Voice { get; }
        public string Color { get; }
        public Type Animal { get; }

        public Pet(string name, string color, string voice, Type animal)
        {
            Name = name;
            Color = color;
            Voice = voice;
            Animal = animal;

        }
        public abstract void Say();
        public override string ToString()
        {
            return $"{Animal} {Name}, колiр: {Color}, голос: {Voice}";
        } 
    }
}
