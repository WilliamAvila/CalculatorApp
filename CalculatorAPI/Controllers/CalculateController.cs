using Calculator.Service;
using CalculatorAPI.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        MyCalculator? calculator;

        // POST api/<ValuesController>
        [HttpPost(Name = "Calculate")]
        public Double Post(Calculation calc)
        {
            calculator = new MyCalculator(calc.operationSymbol, calc.ArgumentList);
            return calculator.Calculate();
        }
    }

}
