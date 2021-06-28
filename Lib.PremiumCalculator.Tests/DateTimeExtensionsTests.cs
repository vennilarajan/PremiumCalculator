using Lib.PremiumCalculator.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lib.PremiumCalculator.Tests
{
    [TestClass]
    public class DateTimeExtensionsTests
    {
        [TestMethod]
        public void GivenDateWhenCalculateAGeIsCalledReturnsAgeAsOfToday()
        {
            // Arrange
            var dateofBirth = new DateTime(1986, 10, 29);
            var expectedAge = 34;

            // Act
            var actualAge = dateofBirth.CalculateAge();

            // Assert
            Assert.AreEqual(expectedAge, actualAge);
        }
    }
}
