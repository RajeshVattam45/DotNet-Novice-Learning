using System;

namespace sample1.oops.abstraction
{
    // Abstract class representing an animal.
    abstract class AnimalAbstractionClass
    {
        // Abstract method for the animal's name.
        public abstract void AnimalName();

        // Abstract method for the animal's sound.
        public abstract void MakeSound();
    }

    // Derived class implementing abstract methods.
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

        //public static void CreateObjectMethod()
        //{
        //    LionClass newObject = new LionClass();
        //    newObject.AnimalName();
        //    newObject.MakeSound();
        //}
    }

    // Derived class implementing abstract methods.
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

        //public static void CreateObjectMethod()
        //{
        //    Tiger newObject = new Tiger();
        //    newObject.MakeSound();
        //    newObject.AnimalName();
        //}
    }
}
