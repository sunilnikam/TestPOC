using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TestPOC.Class;

namespace TestPOC.Approach
{
    internal class Q01_HashTable
    {
        public static Hashtable SumAmountsPerAssetClass(IEnumerable<Transaction> transactions)
        {
            // The data structure used for aggregation is a non-generic Hashtable
            Hashtable totalsByClass = new Hashtable();
            
            foreach (var transaction in transactions)
            {
                if (transaction.AssetClass != null)
                {
                    if (totalsByClass.ContainsKey(transaction.AssetClass))
                    {
                        // Retrieve existing amount (stored as object) and cast it back to decimal
                        //decimal currentTotal = (decimal)totalsByClass[transaction.AssetClass];
                        // Add the new amount and update the value
                        totalsByClass[transaction.AssetClass] = (decimal)(totalsByClass[transaction.AssetClass] ?? 0) + (decimal)transaction.Amount;
                    }
                    else
                    {
                        // If the asset class is new, add the key-value pair
                        totalsByClass.Add(transaction.AssetClass, transaction.Amount);
                    }
                }
            }
            return totalsByClass;
        }
    }
}
