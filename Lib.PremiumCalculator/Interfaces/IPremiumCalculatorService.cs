namespace Lib.PremiumCalculator
{
    public interface IPremiumCalculatorService
    {
        double GetMonthlyDeathPremium(PremiumCalculatorInput input);
    }
}
