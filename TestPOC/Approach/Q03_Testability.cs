using System;
using System.Collections.Generic;
using System.Text;

namespace TestPOC.Approach
{
    internal class Q03_Testability
    {
        /*
         refactor it using a service-oriented architecture,
        Dependency Injection (DI), 
            Defind Interfaces for dependencies
            Inject at runtime with concreate / mock implementations
            Use mocking frameworks for unit testing
            Create testable service/ log class, and inject- Write unit tests to validate each component independently

        and ensure there is no static state

        Wire up dependencies in composition root (e.g., Main method or startup class)
        Unit test using Moq or similar framework to mock dependencies and verify interactions


        Lengthy answer
        There are three primary Dependency Injection (DI) patterns: 
            Constructor Injection, 
            Property (or Setter) Injection, and 
            Method Injection. 

Pattern 	Description	Best Use Case
Constructor Injection	Dependencies are provided via a class's constructor.	Primary/Required dependencies. Best for ensuring that an object is always in a valid state immediately after creation. This is the preferred default method.
Property Injection	Dependencies are provided through public properties (setters).	Optional dependencies. Useful when a component can function with or without the dependency, or when circular dependencies are unavoidable in legacy code.
Method Injection	Dependencies are provided as parameters to a specific method.	Context-specific/Transient dependencies. Used when a dependency is only needed for a single method call and not by the entire class instance.

         */
    }
}
