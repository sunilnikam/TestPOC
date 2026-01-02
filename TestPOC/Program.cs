using TestPOC.Concept;

namespace TestPOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //DelegateTest.TestRegular();
            //DelegateTest.TestMulticast();
            //MultiThreading.TestSynchronous();
            //MultiThreading.TestASynchronous();
            //PropertyPattarn propertyPattarn = new PropertyPattarn();
            //propertyPattarn.TestPropertyPattarn();
            //CancellationTokenTest.TestCancellationToken().GetAwaiter().GetResult();
            FileReadInBatch fileReadInBatch = new FileReadInBatch();
            var capital = "Delhi";
            Console.WriteLine($"Population of {capital} is {fileReadInBatch.GetPopulation(capital)}");


            Console.WriteLine($"{Environment.NewLine}Hit enter to close!!");
            Console.ReadLine();
        }
    }
}