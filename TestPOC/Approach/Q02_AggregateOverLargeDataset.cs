using System;
using System.Collections.Generic;
using System.Text;

namespace TestPOC.Approach
{
    internal class Q02_AggregateOverLargeDataset
    {
        public void AsParallel()
        {
            var largeData = Enumerable.Range(1, 100000000);
            long totalSum = largeData.AsParallel().Sum();
        }

        public void Parallel_ForEach(List<int> largeData)
        {
            long totalSum = 0;
            object lockObject = new object();
            Parallel.ForEach(largeData, item =>
            {
                lock (lockObject) // Ensure only one thread updates totalSum at a time
                {
                    totalSum += item;
                }
            });
        }

        public void Parallel_ForEach_LocalInitFinally(List<int> largeData)
        {
            long totalSum = 0;
            object lockObject = new object();
            Parallel.ForEach(
                largeData,
                () => 0L, // localInit: Initialize a local sum for each thread
                (item, loopState, localSum) => // body: Accumulate into the local sum
                {
                    localSum += item;
                    return localSum;
                },
                localSum => // localFinally: Merge the local sum into the overall total
                {
                    lock (lockObject)
                    {
                        totalSum += localSum;
                    }
                }
            );

        }
    }
}
