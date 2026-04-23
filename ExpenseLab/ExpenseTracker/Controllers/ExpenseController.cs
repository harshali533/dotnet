using Microsoft.AspNetCore.Mvc;
using ExpenseTracker.Models;
using ExpenseTracker.Services;
using System.Threading.Tasks;

namespace ExpenseTracker.Controllers
{
    public class ExpenseController : Controller
    {
        private ExpenseService service = new ExpenseService();
public async Task<IActionResult> Index()
{
    var data = await service.GetAll();

    ViewBag.Spent = service.GetTotalSpent();
    ViewBag.Received = service.GetTotalReceived();
    ViewBag.Balance = service.GetBalance();

    return View(data);
}
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Expense exp)
        {
            if (ModelState.IsValid)
            {
                await service.Add(exp);
                return RedirectToAction("Index");
            }
            return View(exp);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var data = await service.GetAll();
            var exp = data.Find(x => x.Id == id);
            return View(exp);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Expense exp)
        {
            await service.Update(exp);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}