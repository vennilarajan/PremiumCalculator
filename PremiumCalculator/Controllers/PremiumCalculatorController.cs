﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PremiumCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
