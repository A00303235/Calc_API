using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Calc_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        [HttpGet("Add")]
        public IActionResult Add(decimal num1, decimal num2)
        {
            var result = num1 + num2;
            return Ok(result);
        }

        [HttpGet("Subtract")]
        public IActionResult Subtract(decimal num1, decimal num2)
        {
            var result = num1 - num2;
            return Ok(result);
        }

        [HttpGet("Multiply")]
        public IActionResult Multiply(decimal num1, decimal num2)
        {
            var result = num1 * num2;
            return Ok(result);
        }

        [HttpGet("Division")]
        public IActionResult Divide(decimal num1, decimal num2)
        {
            
            var result = num1 / num2;
            return Ok(result);
        }

        [HttpGet ("Modulo")]
        public IActionResult Modulo(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                return BadRequest("Cannot divide by zero.");
            }
            var result = num1 % num2;
            return Ok(result);
        }

    }
}