using System;

namespace sample1.oops.AccessModifiers
{
    class AccessModifiersClass
    {
        public string FruitName = "Apple";
        private string FruitColor = "Red";
        protected string FruitWeight = "100grm";

        // When you try to access public property then it will be accessble.
        public void DisplayFruitName()
        {
            Console.WriteLine(FruitName);
        }

        // When you try to get public it will b eaccessble.
        public void DisplayFruitColor()
        {
            Console.WriteLine(FruitColor);
        }

        // When you try to access protected property will get an error.
        protected void DisplayFruitWeight()
        {
            Console.WriteLine(FruitWeight);
        }
    }
}
