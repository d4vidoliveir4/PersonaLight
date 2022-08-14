using PersonaLight.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PersonaLight.Controllers
{
    public class CadastroReservaController : InternoController
    {
        private readonly ILogger<CadastroReserva> _logger;

        public CadastroReservaController(ILogger<CadastroReserva> logger)
        {
            _logger = logger;
        }

        public override IActionResult Index()
        {
            return View(new CadastroReserva());
        }

        public IActionResult Salvar(CadastroReserva model)
        {
            model.SalvarEntidade();
            if (!model.Sucesso)
                return Editar(model);

            return RedirectToAction("Index");
        }
                
        public IActionResult Editar(int id)
        {
            return Editar(new CadastroReserva(id));
        }
        
        private IActionResult Editar(CadastroReserva model)
        {
            return View("Editar", model);
        }
        
        public IActionResult Excluir(int id)
        {
            if(id == 0)
                return RedirectToAction("Index");

            new CadastroReserva().Excluir(id);

            return RedirectToAction("Index");
        }

        public IActionResult Incluir()
        {
            return View("Editar");
        }

    }
}
