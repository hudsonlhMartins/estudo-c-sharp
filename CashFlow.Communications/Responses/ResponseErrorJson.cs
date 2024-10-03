using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashFlow.Communications.Responses
{
    public class ResponseErrorJson
    {
        public List<string> ErrorMessage { get; set; }

        public ResponseErrorJson(List<string> errorMessage)
        {
            ErrorMessage = errorMessage;
        }
         public ResponseErrorJson(string errorMessage)
        {
            ErrorMessage = [errorMessage];
        }
    }
}