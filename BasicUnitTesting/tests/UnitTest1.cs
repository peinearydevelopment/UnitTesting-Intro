using lib;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        [Test]
        [TestCase("\t", "\n")]
        public void Test1(string input, bool expected)
        {
            // Arrange
            string testString = null;

            // Act
            var isNullOrWhitespace = CustomString.IsNullOrWhiteSpace(input);

            // Assert
            Assert.IsTrue(expected);
        }

        [Test]
        [Description(@"Given:
                        A person
                       When:
                        A new person provided keyword is added
                       Then:
                        The keyword should be returned for that person")]
        public void Test2()
        {
            Assert.IsTrue(CustomString.IsNullOrWhiteSpace(""));
        }

        [Test]
        public void Test3()
        {
            // Arrange
            var testString = new string(' ', new Random().Next(1, int.MaxValue / 2));

            // Act
            var isNullOrWhitespace = CustomString.IsNullOrWhiteSpace(testString);

            // Assert
            Assert.IsTrue(isNullOrWhitespace, "property x wasn't expected value");
        }

        [Test]
        public void TabShouldBeWhitespace()
        {
            Assert.IsTrue(CustomString.IsNullOrWhiteSpace("\t"));
        }

        [Test]
        public void Test5()
        {
            Assert.IsTrue(CustomString.IsNullOrWhiteSpace("\n"));
        }

        [Test]
        public void Test6()
        {
            Assert.IsTrue(CustomString.IsNullOrWhiteSpace("\r"));
        }

        [Test]
        public void Test7()
        {
            Assert.IsFalse(CustomString.IsNullOrWhiteSpace("a"));
        }
    }
}