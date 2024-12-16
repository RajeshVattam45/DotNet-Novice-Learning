using System;

namespace sample1.oops.interfaces
{
    /// <summary>
    /// Interface defining fruit properties.
    /// </summary>
    interface FruitsInterface
    {
        void FruitName();
        void FruitDescription();
        void FruitColor();
    }

    // Class implementing the FruitsInterface.
    class Apple : FruitsInterface
    {
        /// <summary>
        /// Implement FruitName method.
        /// </summary>
        public void FruitName()
        {
            Console.WriteLine("Apple");
        }

        /// <summary>
        ///  Implement FruitDescription method.
        /// </summary>
        public void FruitDescription()
        {
            Console.WriteLine("This is an apple.");
        }

        /// <summary>
        /// Implement FruitColor method.
        /// </summary>
        public void FruitColor()
        {
            Console.WriteLine("Red");
        }
    }
}
