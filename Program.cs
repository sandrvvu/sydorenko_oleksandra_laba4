using System;

namespace laba4_program
{
    class Program
    {
        static void Main(string[] args)
        {
            House pets = new House();
            pets.AddPet(new Cat("Мурчик", "Бiлий", "Мяу", Cat.Type.Кiт));
            pets.AddPet(new Dog("Арчi", "Чорний", "Гав", Dog.Type.Собака));
            pets.AddPet(new Parot("Рiо", "Зелений", "Чiкчiрiк", Parot.Type.Папуга));

            pets.GetInfo();
            pets.GetVoice();
 
        }
    }
}
