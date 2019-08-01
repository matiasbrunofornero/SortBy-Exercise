using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseOrderBy
{
    public class PrintScreen
    {
        public PrintScreen PrintMessage(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
            Console.Clear();
            return this;
        }

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

        public PrintScreen PrintArray(string[] array)
        {
            Console.WriteLine("[{0}]", string.Join(" ", array));
            return this;
        }

        public PrintScreen PrintDictionaryValues(Dictionary<string, int> dictionary)
        {
            foreach (KeyValuePair<string, int> keyvalue in dictionary)
            {
                Console.Write("| " + keyvalue.Key + " " + keyvalue.Value + " ");
            }
            return this;
        }

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
