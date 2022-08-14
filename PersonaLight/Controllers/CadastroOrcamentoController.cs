using PersonaLight.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PersonaLight.Controllers
{
    public class CadastroOrcamentoController : InternoController
    {
        private readonly ILogger<CadastroOrcamento> _logger;

        public CadastroOrcamentoController(ILogger<CadastroOrcamento> logger)
        {
            _logger = logger;
        }

        public override IActionResult Index()
        {
            return View(new CadastroOrcamento());
        }

        public IActionResult Salvar(CadastroOrcamento model)
        {
            model.SalvarEntidade();
            
            if(!model.Sucesso)
                return Editar(model);

            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            return Editar(new CadastroOrcamento(id));
        }
        
        private IActionResult Editar(CadastroOrcamento model)
        {
            return View("Editar", model);
        }
        
        public IActionResult Excluir(int id)
        {
            if(id == 0)
                return RedirectToAction("Index");

            new CadastroOrcamento().Excluir(id);

            return RedirectToAction("Index");
        }

        public IActionResult Incluir()
        {
            return View("Editar");
        }

    }
}
