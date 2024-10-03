using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashFlow.Exceptions.ExceptionsBase
{
    public class ErrorOnValidationException : CashFlowException
    {
        public List<string> Errors { get; set; }
        public ErrorOnValidationException(List<string> errorsMessages)
        {
            Errors = errorsMessages;
        }
    }
}