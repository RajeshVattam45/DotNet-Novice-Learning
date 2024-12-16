using System;

namespace sample1.oops.interfaces
{
    // Interface defining fruit properties.
    interface FruitsInterface
    {
        void FruitName();
        void FruitDescription();
        void FruitColor();
    }

    // Class implementing the FruitsInterface.
    class Apple : FruitsInterface
    {
        // Implement FruitName method.
        public void FruitName()
        {
            Console.WriteLine("Apple");
        }

        // Implement FruitDescription method.
        public void FruitDescription()
        {
            Console.WriteLine("This is an apple.");
        }

        // Implement FruitColor method.
        public void FruitColor()
        {
            Console.WriteLine("Red");
        }

        // Static method to create and use an Apple object.
        //public static void CreateObject()
        //{
        //    Apple appleObject = new Apple();
        //    appleObject.FruitName();
        //    appleObject.FruitDescription();
        //    appleObject.FruitColor();
        //}
    }
}
