using FactoryMethodPattern.Animal.Interfaces;
using FactoryMethodPattern.Animal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Animal.Factory
{
    class TigerFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            return new Tiger();
        }
    }
}
