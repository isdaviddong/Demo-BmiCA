using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Entities;
using WebUI.UseCases;

namespace WebUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public int fieldHeight { get; set; }
        [BindProperty]
        public int fieldWeight { get; set; }
        public float BmiResult { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPostCalculate()
        {
            var bmi = new BMI() { Height = fieldHeight, Weight = fieldWeight };
            BMICalculator bMICalculator = new BMICalculator();
            BmiResult = bMICalculator.CalculateBMI(bmi);
        }
    }
}
