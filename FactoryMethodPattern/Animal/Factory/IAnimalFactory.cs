using FactoryMethodPattern.Animal.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Animal.Factory
{
    interface IAnimalFactory
    {
        IAnimal CreateAnimal();
    }
}
