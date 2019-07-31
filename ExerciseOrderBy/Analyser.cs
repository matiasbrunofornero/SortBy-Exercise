using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExerciseOrderBy
{
    public class Analyser
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER key to display the loaded text");
            Console.ReadKey();
            Console.Clear();

            /// <summary>
            /// In string fileName we need to indicate when the text to use is located.
            /// StreamReader will be displayed line by line the entire text in screen.
            /// </summary>

            string fileName = @"C:\Users\mbruno009\Desktop\input.txt";
            using (System.IO.StreamReader sr = new System.IO.StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine("\n\nPress ENTER key to display the ordered text in ascending");
            Console.ReadKey();
            Console.Clear();

            /// <summary>
            /// With ReadAllText method, copy the file's text into to string.
            /// After that, we convert all the string to lowercase in order to 
            /// identify, for example, words "place" and "Place" as the same.
            /// With Replace method, we will ensure that special characters are not count,
            /// replacing all the special characters with a space character.
            /// And the last step will be save all the strings in an array string.
            /// </summary>

            string text = System.IO.File.ReadAllText(fileName);
            string lowerText = text.ToLower();
            Regex regex = new Regex("[^a-z0-9]");
            lowerText = regex.Replace(lowerText, " ");
            string[] each = lowerText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            /// <summary>
            /// Linq OrderBy method just will take the each array and will order the words in descending mode.
            /// After that, words will be saved in the orderedArray in desc mode.
            /// </summary>

            string[] orderedArray = each.OrderBy(x => x.ToLower()).ToArray();
            Console.WriteLine("[{0}]", string.Join(" ", orderedArray));

            Console.WriteLine("\n\nPress ENTER key to display the amount of each word in text");
            Console.ReadKey();
            Console.Clear();

            /// <summary>
            /// We need to create a Dictionary to save the differents words into the string.
            /// Execute a for cycle in order to go through the whole array and if any word is already in it,
            /// If a word is not in the dictionary, it just be added to it.
            /// Otherwise, if a word is already in the dictionary, the counter will be incremented in 1.
            /// </summary>

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 0; i < each.Length; i++)
            {
                if (dictionary.ContainsKey(each[i]))
                {
                    int value = dictionary[each[i]];
                    dictionary[each[i]] = value + 1;
                }
                else
                {
                    dictionary.Add(each[i], 1);
                }
            }

            /// <summary>
            /// By last, we'll use the KeyValuePair, where the string will save the word and 
            /// the int will save the amount of time that appears in the text 
            /// and we will use a Console.Write to print in the screen the amount of each word in the string
            /// with the indicated format in the exercise.
            /// After that, we will use Linq to sort the KVP by order of repetitions and display final result.
            /// </summary>

            foreach (KeyValuePair<string, int> keyvalue in dictionary)
            {
                Console.Write("| " + keyvalue.Key + " " + keyvalue.Value + " ");
            }

            Console.WriteLine("\n\nPress ENTER key to display the sort array by repetitions");
            Console.ReadKey();
            Console.Clear();

            foreach (KeyValuePair<string, int> keyvalue in dictionary.OrderBy(i => i.Value))
            {
                Console.Write("| " + keyvalue.Key + " " + keyvalue.Value + " ");
            }

            Console.WriteLine("\n\nPress ENTER key to finish the execution");
            Console.ReadKey();
        }
    }
}