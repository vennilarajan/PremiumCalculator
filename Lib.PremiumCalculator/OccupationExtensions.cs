using System;
using System.Collections.Generic;

namespace Lib.PremiumCalculator
{
    public static class OccupationExtensions
    {
        private const double _professionalOccupationRatingFactor = 1.0;
        private const double _whiteCollarOccupationRatingFactor = 1.25;
        private const double _lightManualOccupationRatingFactor = 1.50;
        private const double _heavyManualOccupationRatingFactor = 1.75;

        private static List<Occupation> _professionalOccupations => 
            new List<Occupation> 
            {
                Occupation.Doctor  
            };

        private static List<Occupation> _whiteCollarOccupations =>
            new List<Occupation>
            {
                Occupation.Author
            };

        private static List<Occupation> _lightManualOccupations =>
            new List<Occupation>
            {
                Occupation.Cleaner,
                Occupation.Florist
            };

        private static List<Occupation> _heavyManualOccupations =>
            new List<Occupation>
            {
                Occupation.Farmer,
                Occupation.Mechanic
            };

        public static double GetOccupationRatingFactor(this Occupation occupation)
        {
            if (_professionalOccupations.Contains(occupation))
                return _professionalOccupationRatingFactor;
            if (_whiteCollarOccupations.Contains(occupation))
                return _whiteCollarOccupationRatingFactor;
            if (_lightManualOccupations.Contains(occupation))
                return _lightManualOccupationRatingFactor;
            if (_heavyManualOccupations.Contains(occupation))
                return _heavyManualOccupationRatingFactor;

            throw new Exception("Occupation rating factor is not set");
        }
    }
}
