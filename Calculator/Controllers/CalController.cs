using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalController : ControllerBase
    {
        [HttpGet]
        [Route("add")]
        public object add(decimal x, decimal y)
        {
            return (x + y).ToString();
        }
        [HttpGet]
        [Route("subtract")]
        public object subtract(decimal x, decimal y)
        {
            return (x - y).ToString();
        }
        [HttpGet]
        [Route("multiply")]
        public object multiply(decimal x, decimal y)
        {
            return (x * y).ToString();
        }

        [HttpGet]
        [Route("divide")]
        public object divide(decimal x, decimal y)
        {
            if (y == 0)
                return new DivideByZeroException("Divide By Zero").Message;
            return (x / y).ToString();
        }
    }
}
