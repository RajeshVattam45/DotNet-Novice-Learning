using System;

namespace sample1.oops.interfaces
{
    // Interface for fruit name.
    interface FruitNameInterface
    {
        void FruitName();
    }

    // Interface for fruit color.
    interface FruitColorInterface
    {
        void FruitColor();
    }

    // Interface for fruit weight.
    interface FruitWightInterface
    {
        void FruitWight();
    }

    // Class implementing multiple interfaces.
    class AppleClass : FruitNameInterface, FruitColorInterface, FruitWightInterface
    {
        // Implementation of FruitName method.
        public void FruitName()
        {
            Console.WriteLine("Mango");
        }

        // Implementation of FruitColor method.
        public void FruitColor()
        {
            Console.WriteLine("Red");
        }

        // Implementation of FruitWight method.
        public void FruitWight()
        {
            Console.WriteLine("100grm");
        }

        // Static method to create and use an object.
        //public static void CreateObjects()
        //{
        //    AppleClass mangoObject = new AppleClass();
        //    mangoObject.FruitName();
        //    mangoObject.FruitColor();
        //    mangoObject.FruitWight();
        //}
    }
}
