﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests;

namespace UnitTests.Test
{
    /**
     * Notes:
     *  - Don't forget to  add a reference to the project in the unit test project
     *  
     *  - Open Test Explorer (Test -> Windows -> Test Explorer) and Run All Tests || Run -> Analyze Code Coverage
     */

    [TestClass]
    public class ProgramTest
    {
        /**
         * Test SumArray
         */
        [TestMethod]
        public void TestSumArray()
        {
            /**
             * A collection of helper classes to test various conditions within unit tests:
             * 
             * Class Assert. Methods:
             * 
             * AreEqual                 Tests whether the specified inputs are equal and throws an exception if they are not equal.
             * 
             * AreNotEqual              Tests whether the specified inputs are unequal and throws an exception if they are equal.
             * 
             * AreNotSame               Tests whether the specified objects refer to different objects and throws an exception
             *                          if the two inputs refer to the same object.
             *                          
             * AreSame                  Tests whether the specified objects both refer to the same object and throws an exception
             *                          if the two inputs do not refer to the same object.
             *                          
             * Equals                   Static equals overloads are used for comparing instances of two types for reference equality.
             *                          This method should not be used for comparison of two instances for equality. This object will
             *                          always throw with Assert.Fail. Please use Assert.AreEqual and associated overloads in your unit tests.
             *                          
             * Fail                     Throws an AssertFailedException.
             * 
             * Inconclusive             Throws an AssertInconclusiveException.
             * 
             * IsFalse                  Tests whether the specified condition is false and throws an exception if the condition is true.
             * 
             * IsInstanceOfType         Tests whether the specified object is an instance of the expected type and throws an exception
             *                          if the expected type is not in the inheritance hierarchy of the object.
             *                          
             * IsNotInstanceOfType      Tests whether the specified object is not an instance of the wrong type and throws an exception
             *                          if the specified type is in the inheritance hierarchy of the object.
             * 
             * IsNotNull                Tests whether the specified object is non-null and throws an exception if it is null.
             * 
             * IsNull                   Tests whether the specified object is null and throws an exception if it is not.
             * 
             * IsTrue                   Tests whether the specified condition is true and throws an exception if the condition is false.
             * 
             * ReplaceNullChars         Replaces null characters ('\0') with "\0".
             * 
             * ThrowsException          Tests whether the code specified by delegate action throws exact given exception of type T
             *                          (and not of derived type) and throws AssertFailedException
             * 
             * ThrowsExceptionAsync     Tests whether the code specified by delegate action throws exact given exception of type T
             *                          (and not of derived type) and throws 
             * 
             * Source:
             * https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.testtools.unittesting.assert?redirectedfrom=MSDN&view=mstest-net-1.2.0#methods
             */

            int[] vals = { 1, 2, 3, 4, 5 };
            int expectedRes = 15;
            int res = Program.SumArray(vals);
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void TestSumNullArray()
        {
            int expectedRes = 0;
            int res = Program.SumArray(null);
            Assert.AreEqual(expectedRes, res);
        }

        [TestMethod]
        public void TestSumEmptyArray()
        {
            int[] vals = { };
            int expectedRes = 0;
            int res = Program.SumArray(vals);
            Assert.AreEqual(expectedRes, res);
        }

        /**
         * Test GetValueAtIndex
         */
        [TestMethod]
        public void TestGetValueAtIndex()
        {
            int[] vals = { 1, 2, 3, 4, 5 };
            int index = 2;
            int expectedRes = 3;
            int res = Program.GetValueAtIndex(vals, index);
            Assert.AreEqual(expectedRes, res);
        }

        /**
         * Testing Exceptions
         */
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestGetValueAtIndexNullArray()
        {
            int index = 2;
            int res = Program.GetValueAtIndex(null, index);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetValueAtIndexOutOfRangeMax()
        {
            int[] vals = { 1, 2, 3, 4, 5 };
            int index = 20;
            int res = Program.GetValueAtIndex(vals, index);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetValueAtIndexOutOfRangeMin()
        {
            int[] vals = { 1, 2, 3, 4, 5 };
            int index = -100;
            int res = Program.GetValueAtIndex(vals, index);
        }
    }
}
