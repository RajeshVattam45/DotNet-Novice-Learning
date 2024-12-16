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
        /// <summary>
        /// Implementation of FruitName method.
        /// </summary>
        public void FruitName()
        {
            Console.WriteLine("Mango");
        }

        /// <summary>
        /// Implementation of FruitColor method.
        /// </summary>
        public void FruitColor()
        {
            Console.WriteLine("Red");
        }

        /// <summary>
        /// Implementation of FruitWight method.
        /// </summary>
        public void FruitWight()
        {
            Console.WriteLine("100grm");
        }
    }
}
