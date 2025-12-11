using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BPCalculator;

namespace BPCalculator.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public BloodPressure BloodPressure { get; set; } = new BloodPressure();

        public void OnGet()
        {
            BloodPressure = new BloodPressure
            {
                Systolic = 100,
                Diastolic = 60
            };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            if (BloodPressure.Systolic <= BloodPressure.Diastolic)
            {
                ModelState.AddModelError("", "Systolic must be greater than Diastolic");
                return Page();
            }

            return Page();
        }
    }
}
