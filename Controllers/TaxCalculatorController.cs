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
            decimal taxRate = 0.2m; // Default tax rate
            if (taxCode == "1257L")
            {
                if (income > 12570 && income < 55271)
                {
                    return (income - 12570) * 0.2m;
                }
                else if (income > 55270 && income < 100000)
                {

                    return (income - 55270) * 0.4m + 37700 * 0.2m;
                }
                else if (income > 100000 && income < 125140)
                {
                    decimal personalAllowance = (12570 - (125140 - income) / 2);
                    return (income - 55270) * 0.4m + (55270 - personalAllowance) * 0.2m;
                }
                else if (income > 125140) return income * 0.45m;
            }
            else if (taxCode == "BR") taxRate = 0.2m; // Basic rate
            else if (taxCode == "D0") taxRate = 0.4m; // Higher rate
            else if (taxCode == "D1") taxRate = 0.45m; // Additional rate

            return income * taxRate;
        }
    }
}
