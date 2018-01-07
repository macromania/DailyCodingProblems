using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem1.Tests
{
    [TestClass]
    public class SampleTests
    {
        [TestMethod]
        public void Test_Sample_1()
        {
            // Arrange
            var solution = new Solution();
            var input = new[] { 1, 2, 3, 4, 5 };
            var expectation = new[] { 1, 5, 2, 4, 3 };

            // Act
            var actual = solution.Run(input);
            Print(actual);

            // Assert
            CollectionAssert.AreEqual(expectation, actual);
        }

        [TestMethod]
        public void Test_Sample_2()
        {
            // Arrange
            var solution = new Solution();
            var input = new[] { 1, 2, 3, 4};
            var expectation = new[] { 1, 4, 2, 3 };

            // Act
            var actual = solution.Run(input);
            Print(actual);

            // Assert
            CollectionAssert.AreEqual(expectation, actual);
        }

        [TestMethod]
        public void Test_Sample_3()
        {
            // Arrange
            var solution = new Solution();
            var input = new[] { 1, 2, 3, 4, 5, 6, 7};
            var expectation = new[] { 1, 7, 2, 6, 3, 5, 4 };

            // Act
            var actual = solution.Run(input);
            Print(actual);

            // Assert
            CollectionAssert.AreEqual(expectation, actual);
        }

        [TestMethod]
        public void Test_Sample_4()
        {
            // Arrange
            var solution = new Solution();
            var input = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var expectation = new[] { 1, 8, 2, 7, 3, 6, 4, 5 };

            // Act
            var actual = solution.Run(input);
            Print(actual);

            // Assert
            CollectionAssert.AreEqual(expectation, actual);
        }

        private void Print(int[] input)
        {
            foreach (var i in input)
            {
                Console.WriteLine(i);
            }
        }
    }
}
