using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseOrderBy
{
    public class WordCounter
    {
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
