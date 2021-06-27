using Lib.PremiumCalculator;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PremiumCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PremiumCalculatorController : Controller
    {
        private readonly IPremiumCalculatorService _premiumCalculatorService;
        public PremiumCalculatorController(IPremiumCalculatorService premiumCalculatorService)
        {
            _premiumCalculatorService = premiumCalculatorService;
        }

        [HttpPost]
        public Task<double> GetPremium(PremiumCalculatorInputModel input)
        {
            var premium = _premiumCalculatorService.GetMonthlyDeathPremium(input.ToLibraryModel());
            return Task.FromResult(premium);
        }
    }
}
