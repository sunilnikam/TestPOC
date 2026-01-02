using System;
using System.Collections.Generic;
using System.Text;

namespace TestPOC.Approach
{
    internal class Q06_Heap_vs_Stack
    {
        /*
            In C#, the Stack and the Heap are two distinct memory regions used for 
                different purposes, 
                primarily determined by a variable's type and its context. 
            
        Value types (like int, bool, char, structs) are typically stored on the stack.
        Reference types (like class, object, string, delegate, interface, and arrays) are always allocated on the heap. 

        A key difference is memory management: the stack is automatic and fast (LIFO), 
        while the heap is dynamic and managed by the garbage collector (GC). 

        C# Specifics
            Value Types: Primitives (int, bool), enum, and struct instances are generally on the stack. 
                        However, a value type declared as a field within a class (a reference type) will be stored on the heap along with its parent object.
            Reference Types: Classes, arrays, and strings always have their actual data stored on the heap. 
                        The reference (a pointer to the heap location) is stored on the stack.
            Performance: Stack access is generally faster due to its simple, sequential memory access and better CPU cache performance. 
                        Heap allocation is slightly slower and has overhead associated with garbage collection. 

        */
    }
}
