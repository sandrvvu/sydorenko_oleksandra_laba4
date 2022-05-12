using System;
using System.Collections.Generic;
using System.Text;

namespace laba4_program
{
    public class House
    {
        public List<Pet> pets;
        public House()
        {
            this.pets = new List<Pet>();
        }

        public void AddPet(Pet pet)
        {
            this.pets.Add(pet);
        }

        public void GetInfo()
        {
            Console.WriteLine("Тваринки в домi: \n");
            foreach (var pet in pets)
            {
                Console.WriteLine(pet.ToString());
            }
        }
        public void GetVoice()
        {
            Console.WriteLine("\n Що говорять домашнi улюбленцi: \n");
            foreach (var pet in pets)
            {
                pet.Say();
            }
        }
    }
}
