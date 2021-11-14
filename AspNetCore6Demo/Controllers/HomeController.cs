using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCore6Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SmtpSettings smtpSettings;

        public HomeController(ILogger<HomeController> logger,
            SmtpSettings smtpSettings)
        {
            _logger = logger;
            this.smtpSettings = smtpSettings;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.SmtpHost = smtpSettings.Host;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}