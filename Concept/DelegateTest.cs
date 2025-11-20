using System;
using System.Collections.Generic;
using System.Text;

namespace TestPOC.Concept
{
    delegate void Calculator(int x, int y);
    public static class DelegateTest
    {
        public static void TestRegular()
        {
            Calculator calculator = new Calculator(DelegateTest.Add);
            calculator(10, 20);

            calculator = new Calculator(DelegateTest.Subtract);
            calculator(30, 15);

            Console.WriteLine("Press any key to exit...");
        }

        public static void TestMulticast()
        {
            Calculator calculator = new Calculator(DelegateTest.Add);
            calculator += DelegateTest.Subtract;
            calculator(50, 25);
            Console.WriteLine("Press any key to exit...");
        }

        public static void TestAnonymousMethod()
        {
            Calculator calculator = delegate (int x, int y)
            {
                Console.WriteLine($"Product: {x * y}");
            };
            calculator(5, 6);
            Console.WriteLine("Press any key to exit...");
        }
        
        public static void TestLambdaExpression()
        {
            Calculator calculator = (x, y) =>
            {
                Console.WriteLine($"Quotient: {x / y}");
            };
            calculator(20, 4);
            Console.WriteLine("Press any key to exit...");
        }       

        public static void Add(int a, int b)
        {
            Console.WriteLine($"Sum: {a + b}");
        }

        public static void Subtract(int a, int b)
        {
            Console.WriteLine($"Difference: {a - b}");
        }
    }
}
