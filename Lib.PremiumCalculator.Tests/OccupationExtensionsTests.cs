using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lib.PremiumCalculator.Tests
{
    [TestClass]
    public class OccupationExtensionsTests
    {
        [DataTestMethod]
        [DataRow(Occupation.Cleaner, 1.50)]
        [DataRow(Occupation.Doctor, 1.0)]
        [DataRow(Occupation.Author, 1.25)]
        [DataRow(Occupation.Farmer, 1.75)]
        [DataRow(Occupation.Mechanic, 1.75)]
        [DataRow(Occupation.Florist, 1.50)]
        public void GivenOccupationWhenGetOccupationRatingFactorCalledReturnsTheRatingFactor(Occupation occupation, double expectedRatingFactor)
        {
            var ratingFactor = occupation.GetOccupationRatingFactor();
            Assert.AreEqual(expectedRatingFactor, ratingFactor);
        }
    }
}
