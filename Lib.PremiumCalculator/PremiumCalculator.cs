using System;

namespace Lib.PremiumCalculator
{
    public class PremiumCalculator : IPremiumCalculator
    {
        public double GetMonthlyDeathPremium(PremiumCalculatorInput input)
        {
            var occupationRatingFactor = input.Occupation.GetOccupationRatingFactor();
            var premium = (input.DeathCoverAmount * occupationRatingFactor * input.Age) / 1000 * 12;
            return Math.Round(premium, 2);
        }
    }
}
