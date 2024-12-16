using System;

namespace sample1.oops.StringAccessModifiers
{
    // Class to represent Access modifiers.
    class StringLiteratures
    {
        public string FruitName = "Apple";
        private string FruitColor = "Red";
        protected string FruitWeight = "100grm";

        /// <summary>
        /// When you try to access public property then it will be accessble.
        /// </summary>
        public void DisplayFruitName()
        {
            Console.WriteLine(FruitName);
        }

        /// <summary>
        ///  When you try to get public it will b eaccessble.
        /// </summary>
        public void DisplayFruitColor()
        {
            Console.WriteLine(FruitColor);
        }

        /// <summary>
        /// When you try to access protected property will get an error.
        /// </summary>
        protected void DisplayFruitWeight()
        {
            Console.WriteLine(FruitWeight);
        }
    }
}
