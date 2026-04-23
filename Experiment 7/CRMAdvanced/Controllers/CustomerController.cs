using Microsoft.AspNetCore.Mvc;
using CRMAdvanced.Models;

namespace CRMAdvanced.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}