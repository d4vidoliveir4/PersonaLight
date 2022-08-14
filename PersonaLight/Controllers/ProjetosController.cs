using PersonaLight.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace PersonaLight.Controllers
{
    public class ProjetosController : Controller
    {
        private readonly ILogger<CadastroBlog> _logger;

        public ProjetosController(ILogger<CadastroBlog> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {   
            return View("Index");
        }
                
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
