using System;
using System.Collections.Generic;
using System.Text;

namespace TestPOC.Concept
{
    public class CancellationTokenTest
    {
        public static async Task TestCancellationToken()
        {
            // 1. External token (e.g., from a user clicking "Cancel" or a browser disconnecting)
            using var userCts = new CancellationTokenSource();

            // Simulate user cancellation after 3 seconds
            _ = Task.Delay(4000).ContinueWith(_ => userCts.Cancel());

            try
            {
                await PerformWorkAsync(userCts.Token);
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Operation stopped.");
            }
        }

        static async Task PerformWorkAsync(CancellationToken externalToken)
        {
            // 2. Create a local timeout token (e.g., 5-second limit)
            using var timeoutCts = new CancellationTokenSource(TimeSpan.FromSeconds(5));

            // 3. LINK the tokens: The resulting linkedToken triggers if 
            //    EITHER externalToken OR timeoutCts is cancelled.
            using var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(externalToken, timeoutCts.Token);

            CancellationToken linkedToken = linkedCts.Token;

            Console.WriteLine("Starting work (will timeout in 5s or user cancel in 3s)...");

            for (int i = 0; i < 10; i++)
            {
                linkedToken.ThrowIfCancellationRequested();

                Console.WriteLine($"Step {i} in progress...");
                await Task.Delay(1000, linkedToken);
            }
        }
    }
}