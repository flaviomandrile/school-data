using Microsoft.AspNetCore.Mvc;

namespace SchoolData.Controllers
{
    public class ClassiController : Controller
    {
        private readonly ILogger<ClassiController> _logger;

        public ClassiController(ILogger<ClassiController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
