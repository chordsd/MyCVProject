using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MyCVProject.Models;

namespace MyCVProject.Controllers
{
    public class CVController : Controller
    {
        public IActionResult Task()
        {
            return View();
        }

        public IActionResult Education()
        {
            return View();
        }

        public IActionResult WorkExperience()
        {
            return View();
        }

        public IActionResult Skills()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }


    // Action for displaying the form
    public ActionResult TaxCalculation()
    {
         // Create an empty model to be filled by the form
            var model = new TaxCalculationModel();
            return View(model);
    }

    // Action for processing form data and calculating the tax
    [HttpPost]
        public IActionResult Calculate(TaxCalculationModel model)
        {
            // Parse the tax rate from the form value (which is stored as a string in the Country field)
            if (decimal.TryParse(model.Country, out decimal taxRate))
            {
                // Calculate the tax based on the parsed tax rate and income
                model.CalculatedTax = model.Income * taxRate;
            }
            else
            {
                ModelState.AddModelError("", "Invalid tax rate selected.");
            }

            // Pass the calculated data back to the view
            return View("TaxCalculation", model);
        }

    }
}
