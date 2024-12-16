using System;

namespace sample1.oops.Encapsulations
{
    class EncapsulationsClass
    {
        private string myName;
        public EncapsulationsClass(string name)
        {
            myName = name;
        }

        public string GetName()
        {
            return myName;
        }

        //public static void CreateOBject()
        //{
        //    EncapsulationsClass newObject = new EncapsulationsClass("Rajesh");
        //    Console.WriteLine(newObject.GetName());
        //}
    }
}
