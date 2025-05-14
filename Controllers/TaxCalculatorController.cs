using CVWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CVWebApp.Controllers
{
    public class TaxCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View(new TaxCalculator());
        }

        [HttpPost]
        public ActionResult Calculate(TaxCalculator model)
        {
            if (ModelState.IsValid)
            {
                model.TaxAmount = CalculateTax(model.Income, model.TaxCode);
            }
            return View("Index", model);
        }

        private decimal CalculateTax(decimal income, string taxCode)
        {
            // Example logic for tax calculation
            decimal taxRate = 0m; // Default tax rate
            if (taxCode == "1257L") taxRate = 0m; // Example tax code
            else if (taxCode == "BR") taxRate = 0.2m; // Basic rate
            else if (taxCode == "D0") taxRate = 0.4m; // Higher rate
            else if (taxCode == "D1") taxRate = 0.45m; // Additional rate

            return income * taxRate;
        }
    }
}
