using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3.Builder;
using Lab3.ConcreteBuilder;

namespace Lab3
{
    class AnimalFactory
    {
        public static Zabawka createAnimal (AnimalType animalElement)
        {
            switch (animalElement)
            {
                case AnimalType.Niedźwiadek:
                    return new Niedzwiadek();
                case AnimalType.Tygrysek:
                    return new Tygrysek();
                case AnimalType.Piesek:
                    return new Piesek();
                case AnimalType.Kotek:
                    return new Kotek();
                case AnimalType.Kangurek:
                    return new Kangurek();
                default:
                    throw new Exception("Invalid animal type");
            }
        }
    }
}
