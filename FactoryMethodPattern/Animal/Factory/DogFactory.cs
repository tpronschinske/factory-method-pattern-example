using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodPattern.Animal.Interfaces;
using FactoryMethodPattern.Animal.Models;

namespace FactoryMethodPattern.Animal.Factory
{
    class DogFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            return new Dog();
        }
    }
}
