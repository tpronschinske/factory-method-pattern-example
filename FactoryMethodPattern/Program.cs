using FactoryMethodPattern.Animal.Factory;
using FactoryMethodPattern.Animal.Interfaces;
using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory tigerFactory = new TigerFactory();
            IAnimal aTiger = tigerFactory.CreateAnimal();
            aTiger.Speak();
            aTiger.Action();


            IAnimalFactory dogFactory = new DogFactory();
            IAnimal aDog = dogFactory.CreateAnimal();
            aDog.Speak();
            aDog.Action();

            Console.ReadKey();
        }
    }
}
