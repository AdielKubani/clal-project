using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ClalProjectApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomNumberController : ControllerBase
    {
        private static readonly Stopwatch Stopwatch = new Stopwatch();

        [HttpGet]
        public IActionResult GetRandomNumber(int fromNum = 1, int toNum = 100)
        {
            if (!Stopwatch.IsRunning)
                Stopwatch.Start();

            long elapsedMilliseconds = Stopwatch.ElapsedMilliseconds;

            elapsedMilliseconds = Math.Max(fromNum, Math.Min(toNum, elapsedMilliseconds));

            int randomNum = (int)(elapsedMilliseconds % (toNum - fromNum + 1)) + fromNum;

            Stopwatch.Stop();

            return Ok(randomNum);
        }
    }
}
