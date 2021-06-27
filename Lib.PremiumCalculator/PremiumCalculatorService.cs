namespace Lib.PremiumCalculator
{
    public class PremiumCalculatorService : IPremiumCalculatorService
    {
        private readonly IPremiumCalculator _premiumCalculator;
        public PremiumCalculatorService(IPremiumCalculator premiumCalculator)
        {
            _premiumCalculator = premiumCalculator;
        }

        public double GetMonthlyDeathPremium(PremiumCalculatorInput input)
        {
            return _premiumCalculator.GetMonthlyDeathPremium(input);
        }
    }
}
