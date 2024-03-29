﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExerciseOrderBy.Tests
{
    [TestClass]
    public class ArrayFormatTests
    {
        [TestMethod]
        [TestCategory("ArrayFormat Tests")]
        public void FormatSpecialCharacters_StringWasCorrectlyFormattedToStringWithoutSpecialCharacters()
        {
            ArrayFormat arrayFormat = new ArrayFormat();
            string fileName = System.IO.Directory.GetCurrentDirectory().Replace(@"ExerciseOrderBy.Tests\bin\Debug", @"\ExerciseOrderBy\input.txt");

            string lowerText = System.IO.File.ReadAllText(fileName).ToLower();
            string text = arrayFormat.FormatSpecialCharacters(lowerText);

            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            Assert.IsTrue(regexItem.IsMatch(text), "Formatted message contains at least one special character");
        }

        [TestMethod]
        [TestCategory("ArrayFormat Tests")]
        public void TextToFormattedArray_TextWasCorrectlyFormattedToArray()
        {
            ArrayFormat arrayFormat = new ArrayFormat();
            string fileName = System.IO.Directory.GetCurrentDirectory().Replace(@"ExerciseOrderBy.Tests\bin\Debug", @"\ExerciseOrderBy\input.txt");

            string lowerText = System.IO.File.ReadAllText(fileName).ToLower();
            string[] formattedArray = arrayFormat.TextToFormattedArray(lowerText);

            Assert.AreEqual("String[]", formattedArray.GetType().Name, "String was not correctly convert to array");
        }

        [TestMethod]
        [TestCategory("ArrayFormat Tests")]
        public void OrderByAscending_StringArrayWasCorrectlyOrderedByAscending()
        {
            ArrayFormat arrayFormat = new ArrayFormat();
            string fileName = System.IO.Directory.GetCurrentDirectory().Replace(@"ExerciseOrderBy.Tests\bin\Debug", @"\ExerciseOrderBy\input.txt");

            string lowerText = System.IO.File.ReadAllText(fileName).ToLower();
            string[] formattedArray = arrayFormat.TextToFormattedArray(lowerText);
            string[] orderedArray = arrayFormat.OrderByAscending(formattedArray);

            Assert.IsTrue(arrayFormat.IsAlphabeticallySorted(orderedArray), "String is not alphabetically ordered after method execution");
        }
    }
}
