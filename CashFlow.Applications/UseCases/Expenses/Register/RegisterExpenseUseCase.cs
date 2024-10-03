using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashFlow.Communications.Emuns;
using CashFlow.Communications.Requests;
using CashFlow.Communications.Responses;
using CashFlow.Exceptions.ExceptionsBase;



namespace CashFlow.Applications.UseCases.Expenses.Register
{
    public class RegisterExpenseUseCase
    {
        public ResponseRegisterExpenseJson Execute(RequestRegisterExpenseJson request)
        {
            Validate(request);
            return new ResponseRegisterExpenseJson
            {
                Title = request.Title
            };
        }

        private void Validate(RequestRegisterExpenseJson request)
        {
            var validator = new RegisterExpenseValidation();
            var result = validator.Validate(request);
            if(!result.IsValid)
            {
                var errosMessages = result.Errors.Select(e => e.ErrorMessage).ToList();
                throw new ErrorOnValidationException(errosMessages);
            }
        }
    }
}