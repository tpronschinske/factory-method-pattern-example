using FactoryMethodPattern.Animal.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Animal.Models
{
    class Tiger : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Roar");
        }

        public void Action()
        {
            Console.WriteLine("Tiger Is Hunting");
        }
    }
}
