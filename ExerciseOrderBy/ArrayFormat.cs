using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExerciseOrderBy
{
    public class ArrayFormat
    {
        /// <summary>
        /// Gets a string by parameter, FormatSpecialCharacters method will remove all characters 
        /// that do not match with the regular expression and replace it with empty characters (space).
        /// </summary>
        /// <param name="text">Text that will be formatted</param>
        /// <returns>This method will return the original string without any special characters</returns>

        public string FormatSpecialCharacters(string text)
        {
            Regex expression = new Regex("[^a-z0-9]");
            text = expression.Replace(text, " ");
            return text;
        }

        /// <summary>
        /// Gets a string by parameter, TextToFormattedArray method will convert the string in a string array. 
        /// After special characters clean, the formatted text will be separated in different strings that 
        /// string will be separated between them taking the space character as limit.
        /// </summary>
        /// <param name="text">Text that will be convert to array</param>
        /// <returns>This method will return the original string converted in a string array</returns>

        public string[] TextToFormattedArray(string text)
        {
            string formattedText = FormatSpecialCharacters(text);
            string[] array = formattedText.Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries);
            return array;
        }

        /// <summary>
        /// Gets a array by parameter, OrderByAscending method will order the array respecting a rule. 
        /// </summary>
        /// <param name="text">Array that will be ordered follow a rule</param>
        /// <returns>This method will return the original array alphabetically ordered</returns>

        public string[] OrderByAscending(string[] array)
        {
            string[] orderedArray = array.OrderBy(x => x.ToLower()).ToArray();
            return orderedArray;
        }
    }
}
