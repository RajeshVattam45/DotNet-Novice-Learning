using System;
using System.ComponentModel.DataAnnotations;

namespace sample1.oops.polymorphism
{
    // Base class demonstrating polymorphism with a virtual method.
    class BaseClass
    {
        public virtual void DisplayContent()
        {
            Console.WriteLine("Hello .net");
        }
    }

    // Derived class overriding the Display method.
    class MyClass : BaseClass
    {
        public override void DisplayContent()
        {
            Console.WriteLine("Hello from MyClass class");
        }
    }

    class MyClassTwo : BaseClass
    {
        public void DisplayContent()
        {
            Console.WriteLine("Hello from MyClassTwo class");
        }
    }

    class MyClassThree : BaseClass
    {
        public void DisplayContent()
        {
            Console.WriteLine("hello from MyClassThree class");
        }
    }
}
