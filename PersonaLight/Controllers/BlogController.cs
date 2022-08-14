using PersonaLight.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace PersonaLight.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<CadastroBlog> _logger;

        public BlogController(ILogger<CadastroBlog> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int? pagina, string cat)
        {   
            return View("Index", new CadastroBlog(pagina ?? 1, cat ?? string.Empty));
        }
                
        public IActionResult N(int id)
        {
            return View("Visualizar", new CadastroBlog(id));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
