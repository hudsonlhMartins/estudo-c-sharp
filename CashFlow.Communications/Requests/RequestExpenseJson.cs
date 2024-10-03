using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashFlow.Communications.Emuns;

namespace CashFlow.Communications.Requests
{
    public class RequestRegisterExpenseJson
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }

        public PaymentType PaymentType { get; set; }

    }
}