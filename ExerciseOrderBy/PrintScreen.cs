using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseOrderBy
{
    public class PrintScreen
    {
        /// <summary> Gets an string message by parameter, this method will print it in the screen. </summary>
        /// <param name="text">String message that will be displayed in the screen</param>

        public PrintScreen PrintMessage(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
            Console.Clear();
            return this;
        }

        /// <summary>
        /// Gets an text fileName by parameter, the text inside it will be displayed in screen. 
        /// Using the System.InOut.StreamReader this method will read line by line the selected text.
        /// </summary>
        /// <param name="text">String with the path where is located the input.txt file</param>

        public PrintScreen PrintFile(string fileName)
        {
            using (System.IO.StreamReader sr = new System.IO.StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            return this;
        }

        /// <summary>
        /// Gets an string array by parameter, the text inside it will be displayed in screen,
        /// respecting the format | value | value | value, to display it more clearly.
        /// </summary>
        /// <param name="text">String array that will be displayed in the screen</param>

        public PrintScreen PrintArray(string[] array)
        {
            Console.WriteLine("[{0}]", string.Join(" ", array));
            return this;
        }

        /// <summary>
        /// Gets a dictionary by parameter, the string,int values inside it will be displayed in screen,
        /// respecting the format | word | number | word | number, to display it more clearly.
        /// </summary>
        /// <param name="text">Dictionary that will be displayed in the screen</param>

        public PrintScreen PrintDictionaryValues(Dictionary<string, int> dictionary)
        {
            foreach (KeyValuePair<string, int> keyvalue in dictionary)
            {
                Console.Write("| " + keyvalue.Key + " " + keyvalue.Value + " ");
            }
            return this;
        }

        /// <summary>
        /// Gets a dictionary by parameter, the string,int values inside it will be displayed in screen,
        /// respecting the format | word | number | word | number, to display it more clearly.
        /// Same that method above but in that case, order by amount of words (min to max).
        /// </summary>
        /// <param name="text">Dictionary that will be displayed ordered in the screen</param>

        public PrintScreen PrintOrderedDictionaryValues(Dictionary<string, int> dictionary)
        {
            foreach (KeyValuePair<string, int> keyvalue in dictionary.OrderBy(i => i.Value))
            {
                Console.Write("| " + keyvalue.Key + " " + keyvalue.Value + " ");
            }
            return this;
        }
    }
}
