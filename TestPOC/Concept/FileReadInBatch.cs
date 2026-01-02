using MoreLinq;
using System;
using System.Collections.Generic;
using System.Text;


namespace TestPOC.Concept
{
    internal class FileReadInBatch
    {
        private Dictionary<string, int> capitals;
        public FileReadInBatch()
        {
            Console.WriteLine("FileReadInBatch Constructor called");
            capitals = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Capitals.txt"))
                //.Batch(2) // MoreLinq
                .Chunk(2) // .NET 6+
                .ToDictionary(parts => parts[0].Trim(), parts => int.Parse(parts[1]));
        }

        public int GetPopulation(string city)
        {
            if (capitals.TryGetValue(city, out int population))
            {
                return population;
            }
            else
            {
                throw new KeyNotFoundException($"City '{city}' not found.");
            }
        }
    }
}
