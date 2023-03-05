using Microsoft.AspNetCore.Mvc;

namespace Survely_api_aspnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly ILogger<TestController> _logger;
        
        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "test")]
        public string Get()
        {
            return "Test Ok!";
        }
    }
}
