namespace Lib.PremiumCalculator
{
    public class PremiumCalculator : IPremiumCalculator
    {
        public double GetMonthlyDeathPremium(PremiumCalculatorInput input)
        {
            var occupationRatingFactor = input.Occupation.GetOccupationRatingFactor();
            return (input.DeathCoverAmount * occupationRatingFactor * input.Age) / 1000 * 12;
        }
    }
}
