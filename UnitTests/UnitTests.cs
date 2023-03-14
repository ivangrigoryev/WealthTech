using Microsoft.VisualStudio.TestTools.UnitTesting;
using WealthTeach;

namespace UnitTests
{
    internal class TestProgram : Program
    {
        public string WealthTeachPublic(int number)
        {
            return WealthTeach(number);
        }
    }

    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestWealthTeach_WhenNumberIsEvenlyDivisibleBy3_ExpectWealth()
        {
            // Arrange
            var p = new TestProgram();

            // Act
            string number = p.WealthTeachPublic(3);

            // Assert
            Assert.AreEqual(number, "Wealth");
        }

        [TestMethod]
        public void TestWealthTeach_WhenNumberIsEvenlyDivisibleBy5_ExpectTech()
        {
            // Arrange
            var p = new TestProgram();

            // Act
            string number = p.WealthTeachPublic(5);

            // Assert
            Assert.AreEqual(number, "Tech");
        }

        [TestMethod]
        public void TestWealthTeach_WhenNumberIsEvenlyDivisibleBy3AND5_ExpectWealthTech()
        {
            // Arrange
            var p = new TestProgram();

            // Act
            string number = p.WealthTeachPublic(15);

            // Assert
            Assert.AreEqual(number, "WealthTech");
        }

        [TestMethod]
        public void TestWealthTeach_WhenNumberIsNotEvenlyDivisibleBy3OR5_ExpectNumber()
        {
            // Arrange
            var p = new TestProgram();

            // Act
            string number = p.WealthTeachPublic(1);

            // Assert
            Assert.AreEqual(number, "1");
        }
    }
}
