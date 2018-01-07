using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem1.Tests
{
    [TestClass]
    public class FindMiddleTests
    {
        [TestMethod]
        public void Should_Find_Middle_For_Odd_List()
        {
            // Arrange
            var input = new int[] {1, 2, 3, 4, 5};
            var solution = new Solution();
         
            // Act
            var middle = solution.FindMiddle(input);

            // Assert
            Assert.AreEqual(2, middle);
        }

        [TestMethod]
        public void Should_Find_Middle_For_Even_List()
        {
            // Arrange
            var input = new int[] { 1, 2, 3, 4 };
            var solution = new Solution();

            // Act
            var middle = solution.FindMiddle(input);

            // Assert
            Assert.AreEqual(2, middle);
        }
    }
}
