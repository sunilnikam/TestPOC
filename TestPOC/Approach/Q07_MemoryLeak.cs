using System;
using System.Collections.Generic;
using System.Text;

namespace TestPOC.Approach
{
    internal class Q07_MemoryLeak
    {
        // through unmanaged references and the management of long-lived objects holding references to other resources
        //  improper event handling with long-lived subscribers and short-lived publishers.
        // Regular example is Opening a StreamReader or FileStream and not closing it properly can leak file handles

        //  What are some common causes of memory leaks in C# applications, and how can they be mitigated?
        // Common Causes of Memory Leaks in C# Applications:
        //  1. Event Handlers: Not unsubscribing from events can prevent objects from being garbage collected.
        //  2. Static References: Objects referenced by static fields remain in memory for the lifetime of the application.
        //  3. Unmanaged Resources: Failing to release unmanaged resources (like file handles, database connections) can lead to memory leaks.
        //  4. Large Object Heap Fragmentation: Frequent allocation and deallocation of large objects can lead to fragmentation in the Large Object Heap (LOH).
        // Mitigation Strategies:
        //  1. Unsubscribe from Events: Always unsubscribe from events when they are no longer needed.
        //  2. Avoid Static References: Be cautious with static fields and ensure they do not hold references to objects that should be collected.
        //  3. Implement IDisposable: Use the IDisposable interface to properly release unmanaged resources.
        //  4. Use Weak References: For caches or similar scenarios, consider using WeakReference to allow garbage collection.
        //  5. Monitor Memory Usage: Use profiling tools to monitor memory usage and identify potential leaks.
        //  6. Optimize Large Object Usage: Minimize the allocation of large objects and consider pooling strategies.
        //  7. Regularly Review Code: Conduct code reviews to identify potential memory management issues.
        //  8. Use Memory Profiling Tools: Utilize tools like dotMemory, ANTS Memory Profiler, or Visual Studio's built-in diagnostics to detect and analyze memory leaks.
        //  9. Avoid Circular References: Be cautious with circular references, especially in complex object graphs.
        //  10. Keep Dependencies Updated: Ensure that third-party libraries are up-to-date, as they may contain fixes for memory leaks.
        // By following these strategies, developers can effectively mitigate memory leaks in C# applications and ensure optimal memory management.


        // Other considerations:
        // mismanaging object lifetimes and unmanaged resources,

    }
}
