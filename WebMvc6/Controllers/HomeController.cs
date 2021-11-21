using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebMvc6.Models;

namespace WebMvc6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly swaggerClient _api;

        public HomeController(ILogger<HomeController> logger, swaggerClient api)
        {
            _logger = logger;
            _api = api;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> PrivacyAsync()
        {
            ViewBag.Courses = await _api.GetAllCourseAsync();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}