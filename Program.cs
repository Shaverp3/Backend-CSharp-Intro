using System;
using System.Collections.Generic;

namespace bangazoncli
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // List<string> fruits = new List<string>() {
            //     "apple", "orange", "kiwi", "grapes"
            // };

            // for(int i= 0; i < fruits.Count; i++){
            //     Console.WriteLine(fruits[i]);
            // }

            //fruits.ForEach(fruit => Console.WriteLine(fruit));

            // foreach (string fruit in fruits){
            //     Console.WriteLine(fruit);
            // }

            // List<int> faveNumbers = new List<int>(){
            //     4,11,22,14,111000
            // };
            // foreach (int num in faveNumbers){
            //     Console.WriteLine(num);
            // };

            // fruits.Add("potatoes");

            // fruits.ForEach(fruit => Console.WriteLine(fruit));

            // Dictionary<string, int> toysSold = new Dictionary<string, int>() {
            //     {"Hot Wheels", 344},
            //     {"Legos", 763},
            //     {"Gaming Consoles", 551},
            //     {"Board Games", 298}
            // };
            // toysSold.Add("Bicycles", 87);

            // foreach(KeyValuePair<string, int> toy in toysSold)
            // {Console.WriteLine($"We sold {toy.Value} units of {toy.Key}");
            // };



            /*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
*/
            //Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            // wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            // wordsAndDefinitions.Add("Dumb", "The feeling I had when I had to google the planets ");
            // wordsAndDefinitions.Add("Confused", "Me today");
            // wordsAndDefinitions.Add("Frustrated", "The way I felt trying to do the Numbers list practice exercise");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            // Console.WriteLine($" The definition of Awesome is: {wordsAndDefinitions["Awesome"]}\n The definition of Dumb is: {wordsAndDefinitions["Dumb"]}");


            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            // foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            // {Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            // }




            // Make a new list
            //List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few words
            // Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // // Add each of the 4 bits of data about the word to the Dictionary
            // excitedWord.Add("word", "excited");
            // excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            // excitedWord.Add("part of speech", "adjective");
            // excitedWord.Add("example sentence", "I am excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list
            // dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list
            // Dictionary<string, string> frustratedWord = new Dictionary<string, string>();

            // // Add each of the 4 bits of data about the word to the Dictionary
            // frustratedWord.Add("word", "frustrated");
            // frustratedWord.Add("definition", "feeling or expressing distress and annoyance, especially because of inability to change or achieve something.");
            // frustratedWord.Add("part of speech", "adjective");
            // frustratedWord.Add("example sentence", "I am frustrated with C#!");

            // dictionaryOfWords.Add(frustratedWord);

            // dictionaryOfWords.ForEach(word => Console.WriteLine($"{word} and the rest is"));

            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries

            // foreach (Dictionary<string, string> singleWord in dictionaryOfWords)
            // {
                //     // Iterate the KeyValuePairs of the Dictionary

               // foreach (KeyValuePair<string, string> wordData in singleWord)
                // {Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            //     {
            //         Console.WriteLine($"{wordData.Key}: {wordData.Value}");
            //     }
            // }

            Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
            idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
            idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
            idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
            idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
            idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
            idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
            idioms.Add("Grain", new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
            idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
            idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
            idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

            foreach (KeyValuePair<string, List<string>> item in idioms)
            {Console.WriteLine($"{item.Value}, {item.Key}");
                
            }
        }
    }
}


