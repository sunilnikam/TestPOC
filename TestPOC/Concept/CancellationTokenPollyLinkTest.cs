using Polly;
using Polly.Timeout;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace TestPOC.Concept
{
    public class CancellationTokenPollyLinkTest
    {
        public static async Task ExecuteOperation(CancellationToken outerToken)
        {
            // 1. Define a pipeline with a timeout strategy
            var pipeline = new ResiliencePipelineBuilder()
                .AddTimeout(TimeSpan.FromSeconds(5)) // Polly will link this to the outerToken
                .Build();

            try
            {
                // 2. Pass the 'outerToken' (e.g., from a user request)
                await pipeline.ExecuteAsync(async (innerToken) =>
                {
                    // IMPORTANT: Use 'innerToken' here. 
                    // It is a LINKED token that triggers if:
                    // - outerToken is cancelled (User)
                    // - OR 5 seconds pass (Polly Timeout)
                    await DoWorkAsync(innerToken);
                }, outerToken);
            }
            catch (TimeoutRejectedException)
            {
                Console.WriteLine("Polly's timeout triggered first.");
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("User cancelled the operation.");
            }
        }

        static async Task DoWorkAsync(CancellationToken ct)
        {
            // Simulates a task that respects the linked token
            await Task.Delay(10000, ct);
        }
    }
}