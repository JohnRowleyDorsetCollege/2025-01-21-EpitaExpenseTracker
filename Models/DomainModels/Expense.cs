﻿namespace EpitaExpenseTracker.Models.DomainModels
{
    public class Expense
    {
        public int Id { get; set; }
        public string? Description { get; set; } = string.Empty;
        public decimal Value { get; set; }

    }
}
