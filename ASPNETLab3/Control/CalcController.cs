namespace ASPNETLab3.Control
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/calc")]
    public class CalcController : ControllerBase
    {
        private readonly ICalcService _calcService;

        public CalcController(ICalcService calcService)
        {
            _calcService = calcService;
        }

        [HttpGet("add")]
        public IActionResult Add(double a, double b)
        {
            var result = _calcService.Add(a, b);
            var htmlResponse = $"<html><body><p>{result}</p></body></html>";
            return Content(htmlResponse, "text/html");
        }

        [HttpGet("subtract")]
        public IActionResult Subtract(double a, double b)
        {
            var result = _calcService.Subtract(a, b);
            var htmlResponse = $"<html><body><p>{result}</p></body></html>";
            return Content(htmlResponse, "text/html");
        }

        [HttpGet("multiply")]
        public IActionResult Multiply(double a, double b)
        {
            var result = _calcService.Multiply(a, b);
            var htmlResponse = $"<html><body><p>{result}</p></body></html>";
            return Content(htmlResponse, "text/html");
        }

        [HttpGet("divide")]
        public IActionResult Divide(double a, double b)
        {
            try
            {
                var result = _calcService.Divide(a, b);
                var htmlResponse = $"<html><body><p>{result}</p></body></html>";
                return Content(htmlResponse, "text/html");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
