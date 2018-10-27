using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace SerilogSample.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private readonly ILogger logger;
        private readonly ITest test;

        public TestController(ILogger logger, ITest test)
        {
            this.logger = logger;
            this.test = test;
        }

        [HttpGet]
        public IActionResult Get()
        {
            logger.Information("This is a log line from a controller.");
            test.DoTest();
            return Ok();
        }

        
    }
}
