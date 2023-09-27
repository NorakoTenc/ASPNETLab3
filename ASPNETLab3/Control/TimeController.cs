namespace ASPNETLab3.Control
{
    using Microsoft.AspNetCore.Mvc;
    using System.Text;

    [ApiController]
    [Route("api/time")]
    public class TimeController : ControllerBase
    {
        private readonly ITimeOfDayService _timeOfDayService;

        public TimeController(ITimeOfDayService timeOfDayService)
        {
            _timeOfDayService = timeOfDayService;
        }

        [HttpGet]
        public IActionResult GetTimeOfDay()
        {
            var timeOfDay = _timeOfDayService.GetTimeOfDay();
            var htmlResponse = $"<html><body><p>{timeOfDay}</p></body></html>";
            return Content(htmlResponse, "text/html", Encoding.UTF8);
        }
    }

}
