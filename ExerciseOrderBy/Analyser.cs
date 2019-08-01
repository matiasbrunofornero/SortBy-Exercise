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
            /// <summary>
            /// In string fileName program will display the file loaded input.txt in our folder.
            /// StreamReader will be displayed line by line the entire text in screen.
            /// </summary>

            string fileName = System.IO.Directory.GetCurrentDirectory().Replace(@"bin\Debug\netstandard2.0", @"input.txt");

            string startMessage = "Press ENTER key to display the loaded text";
            string byAscendingMessage = "\n\nPress ENTER key to display the ordered text in ascending";

            PrintScreen printScreen = new PrintScreen();
            printScreen.PrintMessage(startMessage).PrintFile(fileName);
            printScreen.PrintMessage(byAscendingMessage);

            /// <summary>
            /// With ReadAllText method, copy the file's text into to string.
            /// After that, we convert all the string to lowercase in order to 
            /// identify, for example, words "place" and "Place" as the same.
            /// With Replace method, we will ensure that special characters are not count,
            /// replacing all the special characters with a space character.
            /// And the last step will be save all the strings in an array string.
            /// </summary>

            ArrayFormat arrayFormat = new ArrayFormat();
            string lowerText = System.IO.File.ReadAllText(fileName).ToLower();
            string[] formattedArray = arrayFormat.TextToFormattedArray(lowerText);

            /// <summary>
            /// Linq OrderBy method just will take the each array and will order the words in descending mode.
            /// After that, words will be saved in the orderedArray in desc mode.
            /// </summary>

            string[] orderedArray = arrayFormat.OrderByAscending(formattedArray);
            printScreen.PrintArray(orderedArray);

            string amountWords = "\n\nPress ENTER key to display the amount of each word in text";
            printScreen.PrintMessage(amountWords);

            /// <summary>
            /// We need to create a Dictionary to save the differents words into the string.
            /// Execute a for cycle in order to go through the whole array and if any word is already in it,
            /// If a word is not in the dictionary, it just be added to it.
            /// Otherwise, if a word is already in the dictionary, the counter will be incremented in 1.
            /// </summary>

            WordCounter wordCounter = new WordCounter();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary = wordCounter.DictionaryCountWords(orderedArray, dictionary);

            /// <summary>
            /// By last, we'll use the KeyValuePair, where the string will save the word and 
            /// the int will save the amount of time that appears in the text 
            /// and we will use a Console.Write to print in the screen the amount of each word in the string
            /// with the indicated format in the exercise.
            /// After that, we will use Linq to sort the KVP by order of repetitions and display final result.
            /// </summary>

            string repetitionsMessage = "\n\nPress ENTER key to display the sort array by repetitions";
            printScreen.PrintDictionaryValues(dictionary).PrintMessage(repetitionsMessage);
            printScreen.PrintOrderedDictionaryValues(dictionary);

            string finalMessage = "\n\nPress ENTER key to finish the execution";
            printScreen.PrintMessage(finalMessage);
        }
    }
}