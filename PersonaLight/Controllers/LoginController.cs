using Biblioteca.Auxiliares;
using PersonaLight.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PersonaLight.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                Email.Enviar("Login", $"Foi realizado um acesso já autenticado na data {DateTime.Now.ToString()}");
                return RedirectToAction("Diario", "CadastroBlog");
            }
            return View(new Login());
        }

        public IActionResult UsuarioInvalido()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logar([Bind] Login login)
        {
            if (CamposInvalidos(login))
                return View("Index", new Login());

            if (ModelState.IsValid)
            {
                var LoginStatus = login.Logar(login.Usuario, login.Senha);

                if (LoginStatus)
                {
                    ClaimsIdentity userIdentity = new ClaimsIdentity("login");
                    userIdentity.AddClaim(new Claim(ClaimTypes.Name, login.Usuario));
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                    await HttpContext.SignInAsync(principal, new AuthenticationProperties
                    {
                        ExpiresUtc = DateTime.UtcNow.AddDays(1),
                        IsPersistent = true
                    });

                    Email.Enviar("Login", $"Foi realizado uma autenticação na data {DateTime.Now.ToString()}");
                    return RedirectToAction("Diario", "CadastroBlog");
                }
                else
                {
                    return View("Index", new Login());
                }
            }
            else
            {
                return View();
            }
        }

        private bool CamposInvalidos(Login login)
        {
            return login == null || 
                   login.Usuario == null || login.Usuario == string.Empty ||
                   login.Senha == null || login.Senha == string.Empty;
        }

        [HttpGet]
        public async Task<IActionResult> Deslogar()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index");
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
    }
}
