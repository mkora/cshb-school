using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Linq.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestIncrementAll()
        {
            var input = new List<int>() { 1, 2, 3 };
            var expectedOutput = new List<int>() { 2, 3, 4 };
            List<int> output = Program.IncrementAll(input);

            CollectionAssert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void TestGetWhereDivisibleBy()
        {

            var input = new List<int>() { 1, 2, 3, 4, 5 };
            var expectedOutput = new int[] { 2, 4 };
            int[] output = Program.GetWhereDivisibleBy(input, 2);

            CollectionAssert.AreEqual(expectedOutput, output);
        }


        [TestMethod]
        public void TestAnyCapitalsTrue()
        {

            var input = "This is Water by David Foster Wallace";
            bool output = Program.AnyCapitals(input);

            Assert.IsTrue(output);
        }

        [TestMethod]
        public void TestAnyCapitalsFalse()
        {

            var input = "commencement speech";
            bool output = Program.AnyCapitals(input);

            Assert.IsFalse(output);
        }

        [TestMethod]
        public void TestAllCapitalsTrue()
        {

            var input = "COMMENCEMENT SPEECH";
            bool output = Program.AllCapitals(input);

            Assert.IsTrue(output);
        }

        [TestMethod]
        public void TestAllCapitalsFalse()
        {

            var input = "This is Water by David Foster Wallace";
            bool output = Program.AllCapitals(input);

            Assert.IsFalse(output);
        }

        [TestMethod]
        public void TestNumPairs()
        {
            var input = new Dictionary<int, string>() {
                { 1, "a" },
                { 2, "b" },
                { 3, "c" },
                { 4, "d" },
                { 5, "e" }
            };
            var expectedOutput = 5;
            int output = Program.NumPairs(input);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void TestNumPairsWrong()
        {
            var input = new Dictionary<int, string>() {
                { 1, "a" },
                { 2, "b" },
                { 3, "c" },
                { 4, "d" },
                { 5, "e" }
            };
            var expectedOutput = 1;
            int output = Program.NumPairs(input);

            Assert.AreNotEqual(expectedOutput, output);
        }

        [TestMethod]
        public void TestNumPairsWithKeyValue()
        {
            /**
             * Init aa Dictionary <int, string>
             */
            var input = new Dictionary<int, string>() {
                { 1, "abc" },
                { 2, "bcde" },
                { 3, "c" },
                { 4, "de" },
                { 5, "efg" }
            };
            var expectedOutput = 2;
            int output = Program.NumPairsWithKeyValue(input, 1, 3);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void TestGetDistinctWithValuey()
        {

            var input = new List<double>() { 1, 2, 3, 4, 5, 3, 4, 5 };
            var expectedOutput = new List<double>() { 1, 2, 3 };
            List<double> output = Program.GetDistinctWithValue(input, 4);

            CollectionAssert.AreEqual(expectedOutput, output);
        }


        [TestMethod]
        public void TestFindFirstArrayWithLength()
        {
            /**
             * Init a List of int arrays 
             */
            var input = new List<int[]>() {
                new int[] { 1, 2, 3 },
                new int[] { 2, 3, 4, 5, 6 },
                new int[] { 3, 4 },
                new int[] { 4, 5, 6, 7 },
                new int[] { 5 }
            };
            var expectedOutput = new int[] { 1, 2, 3 };
            int[] output = Program.FindFirstArrayWithLength(input, 2);

            CollectionAssert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void TestFindNullFirstArrayWithLength()
        {
            /**
             * Init a List of int arrays 
             */
            var input = new List<int[]>() {
                new int[] { 1, 2, 3 },
                new int[] { 2, 3, 4, 5, 6 },
                new int[] { 3, 4 },
                new int[] { 4, 5, 6, 7 },
                new int[] { 5 }
            };

            Assert.IsNull(Program.FindFirstArrayWithLength(input, 5));
        }

        [TestMethod]
        public void TestGetLastOddElement()
        {
            var input = new int[] { 1, 2, 3, 4, 5, 3, 4, 5 };

            var expectedOutput = 5;
            int output = Program.GetLastOddElement(input);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void TestGetZeroLastOddElement()
        {
            var input = new int[] { 2, 4, 6, 8, 4, 8 };

            var expectedOutput = 0;
            int output = Program.GetLastOddElement(input);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void TestGetMaxStringLength()
        {

            var input = new List<string>() { "abc", "bcde", "c", "de", "efg" };
            var expectedOutput = 4;
            int output = Program.GetMaxStringLength(input);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void TestGetMinListListValue()
        {
            /**
             * Init a List of List<int>
             */
            var input = new List<List<int>>() {
                new List<int> { 1, 2, 3 },
                new List<int> { 2, 3, 4, 5, 6 },
                new List<int> { 3, 4 },
                new List<int> { 4, 5, 6, 7 },
                new List<int> { 5 }
            };

            var expectedOutput = 1;
            int output = Program.GetMinListListValue(input);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void TestGetIntElements()
        {
            var input = new List<object>() { "abc", 1, "bcde", "c", 2, "de", "efg" };
            var expectedOutput = new List<int>() { 1, 2 };
            List<int> output = Program.GetIntElements(input);

            CollectionAssert.AreEqual(expectedOutput, output);
        }

    }
}
