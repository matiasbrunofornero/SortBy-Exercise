using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOrderBy.Tests
{
    public class AlphabeticSortMethods
    {
        /// <summary> 
        /// Gets an string array by parameter, this method will verify if the array array was alphabetically ordered, 
        /// word by word, comparing X word with all of the remaining words inside the array with a CompareTo Linq method.
        /// </summary>
        /// <param name="text">This method will return true if the string is correctly ordered and false if not</param>

        public bool IsAlphabeticallySorted(string[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].CompareTo(array[i + 1]) > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
