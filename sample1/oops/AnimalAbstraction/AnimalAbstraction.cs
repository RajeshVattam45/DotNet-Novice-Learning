using System;

namespace sample1.oops.AnimalAbstraction
{
    /// <summary>
    /// Abstract class defining the blueprint for animal behavior.
    /// </summary>
    abstract class AnimalAbstractionClass
    {
        // Abstract method for the animal's name.
        public abstract void AnimalName();

        // Abstract method for the animal's sound.
        public abstract void MakeSound();
    }

    /// <summary>
    /// Derived class implementing abstract methods.
    /// </summary>
    class LionClass : AnimalAbstractionClass
    {
        // Implementation of AnimalName.
        public override void AnimalName()
        {
            Console.WriteLine("Lion");
        }

        // Implementation of MakeSound.
        public override void MakeSound()
        {
            Console.WriteLine("Sound");
        }
    }

    /// <summary>
    /// Derived class implementing abstract methods.
    /// </summary>
    class Tiger : AnimalAbstractionClass
    {
        // Implementation of AnimalName.
        public override void AnimalName()
        {
            Console.WriteLine("Tiger");
        }

        // Implementation of MakeSound.
        public override void MakeSound()
        {
            Console.WriteLine("Sound2");
        }
    }
}
