using System;
using System.Collections.Generic;
using System.Text;

namespace TestPOC.Approach
{
    internal class Q08_Overloading_Overriding
    {
        // What is the difference between method overloading and method overriding in C#?
        //  Method Overloading:
        //  Method overloading is a compile-time polymorphism feature that allows multiple methods in the same class to have the same name but different parameter lists (different types, number, or order of parameters).
        //  It enables methods to perform similar functions with different inputs.

        // Method Overriding:
        //  Method overriding is a runtime polymorphism feature that allows a derived class to provide a specific implementation of a method that is already defined in its base class.
        //  It enables a derived class to modify the behavior of a method inherited from its base class.
        // Needs base class method to be marked as virtual, abstract, or already override
        // and override keyword in derived class

        // Preventing Further Overrides (sealed)
            // Use override to provide a new implementation
                //public sealed override void Display()



    }
}
