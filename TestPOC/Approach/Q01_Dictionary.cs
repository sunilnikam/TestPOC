using System;
using System.Collections.Generic;
using System.Text;
using TestPOC.Class;

namespace TestPOC.Approach
{
    internal class Q01_Dictionary
    {
        public static Dictionary<string, decimal> SumAmountsPerAssetClass(IEnumerable<Transaction> transactions)
        {
            // The data structure used for aggregation
            Dictionary<string, decimal> totalsByClass = new Dictionary<string, decimal>();

            foreach (var transaction in transactions)
            {
                if (transaction.AssetClass != null)
                {
                    if (totalsByClass.ContainsKey(transaction.AssetClass))
                    {
                        // If the asset class already exists, add the amount
                        totalsByClass[transaction.AssetClass] += transaction.Amount;
                    }
                    else
                    {
                        // If the asset class is new, add it to the dictionary
                        totalsByClass.Add(transaction.AssetClass, transaction.Amount);
                    }
                }
            }
            return totalsByClass;
        }
    }
}
