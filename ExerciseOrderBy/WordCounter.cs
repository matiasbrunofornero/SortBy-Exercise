using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseOrderBy
{
    public class WordCounter
    {
        /// <summary>
        /// Gets an string array by parameter and a dictionary previously created, 
        /// this method will add inside the dictionary the words in the array respecting the following rule:
        /// if the found word in the array was not added previously to dictionary, it will be added.
        /// Otherwise, if the word was added previously to dictionary, the count of this word will be incremented in 1.
        /// </summary>
        /// <param name="text">Array that will be use to count the words and dictionary where the words will be saved</param>
        /// <returns>This method will return a dictionary with the updated count of each word in the array string</returns>

        public Dictionary<string, int> DictionaryCountWords(string[] array, Dictionary<string, int> dictionary)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (dictionary.ContainsKey(array[i]))
                {
                    int value = dictionary[array[i]];
                    dictionary[array[i]] = value + 1;
                }
                else
                {
                    dictionary.Add(array[i], 1);
                }
            }
            return dictionary;
        }
    }
}
