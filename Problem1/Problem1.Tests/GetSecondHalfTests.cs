using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem1.Tests
{
    [TestClass]
    public class GetSecondHalfTests
    {
        [TestMethod]
        public void Should_Get_SecondHalf_For_Odd_List()
        {
            // Arrange
            var input = new[] { 1, 2, 3, 4, 5 };
            var solution = new Solution();
            var expectation = new[] { 5, 4 };

            // Act
            var secondHalf = solution.GetSecondHalfReversed(input);

            // Assert
            CollectionAssert.AreEqual(expectation, secondHalf);
        }

        [TestMethod]
        public void Should_Get_SecondHalf_For_Even_List()
        {
            // Arrange
            var input = new[] { 1, 2, 3, 4 };
            var solution = new Solution();
            var expectation = new[] { 4 };

            // Act
            var secondHalf = solution.GetSecondHalfReversed(input);

            // Assert
            CollectionAssert.AreEqual(expectation, secondHalf);
        }
    }
}
