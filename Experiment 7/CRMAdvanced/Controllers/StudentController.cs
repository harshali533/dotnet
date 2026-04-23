using Microsoft.AspNetCore.Mvc;
using CRMAdvanced.Models;

namespace CRMAdvanced.Controllers
{
    public class StudentController : Controller
    {
        // GET: Show Form
        public IActionResult Create()
        {
            return View();
        }

        // POST: Submit Form
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                // If data is valid
                ViewBag.Message = "Data saved successfully!";
                return View();
            }

            // If validation fails
            return View(student);
        }
    }
}