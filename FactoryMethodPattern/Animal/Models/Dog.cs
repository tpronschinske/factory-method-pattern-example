using FactoryMethodPattern.Animal.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Animal.Models
{
    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Bark");
        }

        public void Action()
        {
            Console.WriteLine("Dog Is Walking");
        }
    }
}
