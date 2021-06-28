using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lib.PremiumCalculator.Tests
{
    [TestClass]
    public class PremiumCalculatorTests
    {
        [TestMethod]
        public void GivenPremiumCalculatorInputWhenGetMonthlyDeathPremiumIsCalledThenRteurnMonthlyPremium()
        {
            // Arrange
            var input = new PremiumCalculatorInput
            {
                Age = 20,
                DeathCoverAmount = 20000,
                Occupation = Occupation.Author
            };
            var expectedPremium = (input.DeathCoverAmount * input.Occupation.GetOccupationRatingFactor() * input.Age) / 1000 * 12;
            expectedPremium = Math.Round(expectedPremium, 2);

            // Act
            var premiumCalculator = new PremiumCalculator();
            var actualpremium = premiumCalculator.GetMonthlyDeathPremium(input);

            // Assert
            Assert.AreEqual(expectedPremium, actualpremium);
        }
    }
}
