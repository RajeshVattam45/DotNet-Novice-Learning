using System;
using System.ComponentModel.DataAnnotations;

namespace sample1.oops.polymorphism
{
    class PolymorphismClass
    {
        public virtual void Display()
        {
            Console.WriteLine("Hello .net");
        }
    }

    class MyClass : PolymorphismClass
    {
        public override void Display()
        {
            Console.WriteLine("Hello from MyClass class");
        }
    }

    class MyClassTwo : PolymorphismClass
    {
        public void Display()
        {
            Console.WriteLine("Hello from MyClassTwo class");
        }
    }

    class MyClassThree : PolymorphismClass
    {
        public void Display()
        {
            Console.WriteLine("hello from MyClassThree class");
        }
    }
}
