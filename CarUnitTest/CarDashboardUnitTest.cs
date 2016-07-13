using System;
using CarLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarUnitTest
{
    [TestClass]
    public class CarDashboardUnitTest
    {
        [TestMethod]
        public void IsInteresting_BoringNumber_No()
        {
            //arrange
            CarDashboard dashboard = new CarDashboard();
            int mileNumber = 3;
            int[] awesomePhrases = new int[] { 1337, 256 };
            int expected = 0;

            //act
            int actual;
            actual = dashboard.IsInteresting(mileNumber, awesomePhrases);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsInteresting_AwesomeNumber_Yes()
        {
            //arrange
            CarDashboard dashboard = new CarDashboard();
            int mileNumber = 1337;
            int[] awesomePhrases = new int[] { 1337, 256 };
            int expected = 2;

            //act
            int actual;
            actual = dashboard.IsInteresting(mileNumber, awesomePhrases);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsInteresting_AllZeroFollowedNumber_Yes()
        {
            //arrange
            CarDashboard dashboard = new CarDashboard();
            int mileNumber = 800000;
            int[] awesomePhrases = new int[] { 1337, 256 };
            int expected = 2;

            //act
            int actual;
            actual = dashboard.IsInteresting(mileNumber, awesomePhrases);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsInteresting_AllSameDigitNumber_Yes()
        {
            //arrange
            CarDashboard dashboard = new CarDashboard();
            int mileNumber = 666666;
            int[] awesomePhrases = new int[] { 1337, 256 };
            int expected = 2;

            //act
            int actual;
            actual = dashboard.IsInteresting(mileNumber, awesomePhrases);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsInteresting_PalindromeDigitNumber_Yes()
        {
            //arrange
            CarDashboard dashboard = new CarDashboard();
            int mileNumber = 3278723;
            int[] awesomePhrases = new int[] { 1337, 256 };
            int expected = 2;

            //act
            int actual;
            actual = dashboard.IsInteresting(mileNumber, awesomePhrases);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
