﻿using System;
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

            // foreach (string planet in planetList) {
            //     Console.WriteLine ($"from planet list {planet}");
            // }

            // foreach (string planet in rockyPlanets) {
            //     Console.WriteLine ($"Rocky {planet}");
            // }

            Random random = new Random ();
            List<int> numbers = new List<int> {
                random.Next (6),
                random.Next (6),
                random.Next (6),
                random.Next (6),
                random.Next (6),
                random.Next (6),
            };

            // for (int i = 0; i < numbers.Count; i++) {
            //     // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
            //     if (numbers.Contains (i)) {
            //         Console.WriteLine ($"numbers list contains {i}");
            //     } else {
            //         Console.WriteLine ($"Nope numbers list don't have {i}");
            //     }

            //DICTIONARIES
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string> ();
            wordsAndDefinitions.Add ("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add ("SlickIce1", "When you're definitely it");
            wordsAndDefinitions.Add ("Ice", "The moment at which one gets an ice");
            //explain this []
            // Console.WriteLine (wordsAndDefinitions["Awesome"]);
            // Console.WriteLine (wordsAndDefinitions["Ice"]);
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions) {
                // 
            }

            //Dictionary exercise 2
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>> ();
            Dictionary<string, string> excitement = new Dictionary<string, string> () { { "word", "excitement" }, { "definition", "jubilation" }, { "part of speech", "adj." }, { "example", "Nascar got dat excitement" }
            };

            Dictionary<string, string> candy = new Dictionary<string, string> () { { "word", "candy" }, { "definition", "pow pow" }, { "part of speech", "noun." }, { "example", "Kroger got candy" }
            };

            Dictionary<string, string> juice = new Dictionary<string, string> () { { "word", "juice" }, { "definition", "delish liquid" }, { "part of speech", "noun." }, { "example", "love me some juice" }
            };

            dictionaryOfWords.Add (excitement);
            dictionaryOfWords.Add (candy);
            dictionaryOfWords.Add (juice);

            // foreach (Dictionary<string, string> word in dictionaryOfWords) {
            //     foreach (KeyValuePair<string, string> entry in word) {
            //         Console.WriteLine ($"{entry.Key}, {entry.Value}");
            //     }
            // }

            //IDIOMS
            Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>> ();
            idioms.Add ("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
            idioms.Add ("Injury", new List<string> { "Add", "insult", "to", "injury" });
            idioms.Add ("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
            idioms.Add ("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
            idioms.Add ("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
            idioms.Add ("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
            idioms.Add ("Grain", new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
            idioms.Add ("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
            idioms.Add ("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
            idioms.Add ("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

            foreach (KeyValuePair<string, List<string>> singleIdiom in idioms) {
                string joinedIdiom = string.Join (" ", singleIdiom.Value);
                Console.WriteLine ($"{singleIdiom.Key} {joinedIdiom}");
            }

        }

    }
}