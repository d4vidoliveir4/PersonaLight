using PersonaLight.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PersonaLight.Controllers
{
    public class CadastroDesejoController : InternoController
    {
        private readonly ILogger<CadastroDesejo> _logger;

        public CadastroDesejoController(ILogger<CadastroDesejo> logger)
        {
            _logger = logger;
        }

        public override IActionResult Index()
        {
            return View(new CadastroDesejo());
        }

        public IActionResult Salvar(CadastroDesejo model)
        {
            model.SalvarEntidade();
            if (!model.Sucesso)
                return Editar(model);

            return RedirectToAction("Index");
        }
                
        public IActionResult Editar(int id)
        {
            return Editar(new CadastroDesejo(id));
        }
        
        private IActionResult Editar(CadastroDesejo model)
        {
            return View("Editar", model);
        }
        
        public IActionResult Excluir(int id)
        {
            if(id == 0)
                return RedirectToAction("Index");

            new CadastroDesejo().Excluir(id);

            return RedirectToAction("Index");
        }

        public IActionResult Incluir()
        {
            return View("Editar");
        }

    }
}
