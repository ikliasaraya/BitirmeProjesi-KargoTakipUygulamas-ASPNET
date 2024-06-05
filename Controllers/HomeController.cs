using KargoTakipUygulaması.Models;
using KargoTakipUygulaması.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace KargoTakipUygulaması.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<IActionResult> TrackCargo(string cargoId)
        {
            if (string.IsNullOrEmpty(cargoId))
            {
                ViewData["Error"] = "Kargo ID boş olamaz.";
                return View("Index");
            }

            var cargo = await _context.Cargos.FindAsync(cargoId);

            if (cargo == null)
            {
                ViewData["Error"] = "Kargo bulunamadı.";
                return View("Index");
            }

            ViewData["Cargo"] = cargo;
            return View("Index");
        }
    }
}
