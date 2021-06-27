namespace Lib.PremiumCalculator
{
    public interface IPremiumCalculator
    {
        double GetMonthlyDeathPremium(PremiumCalculatorInput input);
    }
}
