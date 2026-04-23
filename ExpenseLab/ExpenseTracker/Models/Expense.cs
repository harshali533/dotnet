using System;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Range(1, 100000)]
        public double Amount { get; set; }

        [Required]
       public string? Type { get; set; } // Spent or Received

        public DateTime Date { get; set; }
    }
}