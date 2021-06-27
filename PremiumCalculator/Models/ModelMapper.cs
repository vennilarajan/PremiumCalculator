using Lib.PremiumCalculator;
using System;

namespace PremiumCalculator.Controllers
{
    public static class ModelMapper
    {
        public static PremiumCalculatorInput ToLibraryModel(this PremiumCalculatorInputModel inputModel)
        {
            return new PremiumCalculatorInput
            {
                Age = inputModel.Age,
                DeathCoverAmount = inputModel.DeathCoverAmount,
                Occupation = (Occupation) Enum.Parse(typeof(Occupation), inputModel.Occupation)
            };
        }
    }
}
