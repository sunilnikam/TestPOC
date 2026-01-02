using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestPOC.Concept
{
    internal class MultiThreading
    {
        public static void TestSynchronous()
        {
            Console.WriteLine(Method1_Sync());
            Console.WriteLine(Method2_Sync(10));
            Console.WriteLine(Method3_Sync());
            Console.Read();
        }
        public static void TestASynchronous()
        {
            var task1 = System.Threading.Tasks.Task.Run(() => Console.WriteLine(Method1()));
            var task2 = System.Threading.Tasks.Task.Run(() => Console.WriteLine(Method2()));
            var task3 = System.Threading.Tasks.Task.Run(() => Console.WriteLine(Method3()));
            Console.Read();
        }

        public static void TestTasjAsyncAwait()
        {
            var task = Method1_2();
            Console.Read();
        }
        #region Test 1
        // Test 1
        public static int Method1()
        {
            Thread.Sleep(500);
            return 10;
        }
        public static int Method2()
        {
            return 20;
        }

        public static int Method3()
        {
            return 30;
        }
        #endregion Test 1

        // Test 2
        public static int Method1_Sync()
        {
            Thread.Sleep(500);
            return 10;
        }

        public static int Method2_Sync(int i)
        {
            return i * 20;
        }

        public static int Method3_Sync()
        {
            return 30;
        }

        public static async Task Method1_2()
        {
            Console.WriteLine("Method1_2");
            var i = await Task.Run(() => { return Method1(); });

            Console.WriteLine(i);

            int j = Method2_Sync(i);
            Console.WriteLine(j);
        }   

    }
}
