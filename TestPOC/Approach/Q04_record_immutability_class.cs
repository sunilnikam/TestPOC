using System;
using System.Collections.Generic;
using System.Text;

namespace TestPOC.Approach
{
    internal class Q04_record_immutability_class
    {
        public record Person(string FirstName, string LastName);

        /*
            The record keyword (introduced in C# 9.0) 
            is a modifier for a class or struct that 
            automatically synthesizes several methods, 
                including those for equality comparison, 
                hashing, and 
                string representation (ToString()). 
            
            The primary goal is to provide a concise syntax for working with 
                immutable, 
                value-based data structures, such as Data Transfer Objects (DTOs) or 
                domain models. 

            Immutability is a principle where the state (properties and fields) of an object 
            cannot be changed after it is created or initialized
                Thread Safety: Immutable objects are inherently thread-safe because their state cannot be modified by multiple threads concurrently, eliminating the need for explicit synchronization.
                Predictability: It helps prevent bugs caused by unexpected state changes in different parts of a program.
                Functional Programming Support: Immutability aligns well with functional programming paradigms, where functions operate on data without causing side effects. 
         */
    }
}
