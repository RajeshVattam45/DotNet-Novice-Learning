using System;

namespace ClassLibrary1.SolidPrincipals.LSP
{
    // Abstract base class defining common properties and methods for all animals.
    public abstract class AnimalsClass
    {
        public abstract string AnimalName(string animalName);
        public abstract string AnimalColor(string animalColor);
    }

    // Derived class representing lions, inheriting from AnimalsClass.
    public class LionsClass : AnimalsClass
    {

        // Implementation of the AnimalName method for lions.
        public override string AnimalName(string animalName)
        {
            return $"Animal name: {animalName}";
        }

        // Implementation of the AnimalColor method for lions.
        public override string AnimalColor(string animalColor)
        {
            return $"Animal color: {animalColor}";
        }
    }

    // Derived class representing tigers, inheriting from AnimalsClass.
    public class TigerClass : AnimalsClass
    {
        // Implementation of the AnimalName method for tigers.
        public override string AnimalName(string animalName)
        {
            return $"Animal name: {animalName}";
        }

        // Implementation of the AnimalColor method for tigers.
        public override string AnimalColor(string animalColor)
        {
            return $"Animal color: {animalColor}";
        }
    }
}
