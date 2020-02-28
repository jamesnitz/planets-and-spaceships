using System;
using System.Collections.Generic;
namespace planet_and_spaceships {
    class Program {
        static void Main (string[] args) {
            List<string> planetList = new List<string> () { "Mercury", "Mars" };
            List<string> lastPlanets = new List<string> () { "Neptune", "Pluto" };
            planetList.Add ("Jupiter");
            planetList.Add ("Saturn");
            planetList.AddRange (lastPlanets);
            planetList.Insert (1, "Venus");
            planetList.Insert (2, "Earth");
            List<string> rockyPlanets = planetList.GetRange (0, 4);
            planetList.Remove ("Pluto");

            foreach (string planet in planetList) {
                Console.WriteLine ($"from planet list {planet}");
            }

            foreach (string planet in rockyPlanets) {
                Console.WriteLine ($"Rocky {planet}");
            }

            Random random = new Random ();
            List<int> numbers = new List<int> {
                random.Next (6),
                random.Next (6),
                random.Next (6),
                random.Next (6),
                random.Next (6),
                random.Next (6),
            };

            for (int i = 0; i < numbers.Count; i++) {
                // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
                if (numbers.Contains (i)) {
                    Console.WriteLine ($"numbers list contains {i}");
                } else {
                    Console.WriteLine ($"Nope numbers list don't have {i}");
                }
            }

        }
    }
}