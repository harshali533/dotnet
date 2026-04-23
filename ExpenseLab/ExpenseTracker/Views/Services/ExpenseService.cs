using ExpenseTracker.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Services
{
    public class ExpenseService
    {
        private static List<Expense> expenses = new List<Expense>();

        public async Task<List<Expense>> GetAll()
        {
            return await Task.FromResult(expenses);
        }

        public async Task Add(Expense exp)
        {
            exp.Id = expenses.Count + 1;
            expenses.Add(exp);
            await Task.CompletedTask;
        }

        public async Task Update(Expense exp)
        {
            var existing = expenses.FirstOrDefault(x => x.Id == exp.Id);
            if (existing != null)
            {
                existing.Title = exp.Title;
                existing.Amount = exp.Amount;
                existing.Type = exp.Type;
                existing.Date = exp.Date;
            }
            await Task.CompletedTask;
        }

        public async Task Delete(int id)
        {
            var item = expenses.FirstOrDefault(x => x.Id == id);
            if (item != null)
                expenses.Remove(item);

            await Task.CompletedTask;
        }

        public double GetTotalSpent()
        {
            return expenses.Where(x => x.Type == "Spent").Sum(x => x.Amount);
        }

        public double GetTotalReceived()
        {
            return expenses.Where(x => x.Type == "Received").Sum(x => x.Amount);
        }

        public double GetBalance()
        {
            return GetTotalReceived() - GetTotalSpent();
        }
    }
}