using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ClalProjectApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomNumberController : ControllerBase
    {
        private static readonly Stopwatch Stopwatch = new Stopwatch();

        [HttpGet("{fromNum}/{toNum}")]
        public IActionResult GetRandomNumber(int fromNum, int toNum)
        {
            if (fromNum >= toNum)
            {
                return BadRequest("fromNum must be less than toNum");
            }

            if (!Stopwatch.IsRunning)
            {
                Stopwatch.Start();
            }

            long elapsedMilliseconds = Stopwatch.ElapsedMilliseconds;

            elapsedMilliseconds = Math.Max(fromNum, Math.Min(toNum, elapsedMilliseconds));

            int randomNum = (int)(elapsedMilliseconds % (toNum - fromNum + 1)) + fromNum;

            Stopwatch.Stop();

            return Ok(randomNum);
        }
    }
}
