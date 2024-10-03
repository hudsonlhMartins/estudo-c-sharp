using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CashFlow.Applications.UseCases.Expenses.Register;
using CashFlow.Communications.Requests;
using CashFlow.Communications.Responses;
using CashFlow.Exceptions.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpensesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] RequestRegisterExpenseJson expense)
        {
            try{
                var useCase = new RegisterExpenseUseCase();
                var res = useCase.Execute(expense);
                return Created(string.Empty, res);
            }
            catch(ErrorOnValidationException ex){
                var errorResponse = new ResponseErrorJson(ex.Errors);
             
                return BadRequest(errorResponse);
            }
            catch{
                var errorResponse = new ResponseErrorJson("Unkown error");
                return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
            }
        }
    }
}