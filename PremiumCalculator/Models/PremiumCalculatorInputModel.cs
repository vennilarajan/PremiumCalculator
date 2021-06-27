using System;

namespace PremiumCalculator.Controllers
{
    public class PremiumCalculatorInputModel
    {
        public string Name { get; set; }
        public double DeathCoverAmount { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
