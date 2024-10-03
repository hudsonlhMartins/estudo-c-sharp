using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using CashFlow.Communications.Requests;
using FluentValidation;

namespace CashFlow.Applications.UseCases.Expenses.Register
{
    public class RegisterExpenseValidation : AbstractValidator<RequestRegisterExpenseJson>
    {
        public RegisterExpenseValidation()
        {
            RuleFor(expense => expense.Title).NotEmpty().NotEmpty().WithMessage("Title is required");
            RuleFor(expense => expense.Amount).GreaterThan(0).WithMessage("Amount must be greater than zero");
            RuleFor(expense => expense.Date).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Date must be less than or equal to today");
            RuleFor(expense => expense.PaymentType).IsInEnum().WithMessage("Payment type is invalid");
        }
    }
}