using PersonaLight.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PersonaLight.Controllers
{
    public class CadastroDadosMedicosController : InternoController
    {
        private readonly ILogger<CadastroDadosMedicos> _logger;

        public CadastroDadosMedicosController(ILogger<CadastroDadosMedicos> logger)
        {
            _logger = logger;
        }

        public override IActionResult Index()
        {
            return View(new CadastroDadosMedicos());
        }

        public IActionResult Salvar(CadastroDadosMedicos model)
        {
            model.SalvarEntidade();
            if (!model.Sucesso)
                return Editar(model);

            return RedirectToAction("Index");
        }
                
        public IActionResult Editar(int id)
        {
            return Editar(new CadastroDadosMedicos(id));
        }
        
        private IActionResult Editar(CadastroDadosMedicos model)
        {
            return View("Editar", model);
        }
        
        public IActionResult Excluir(int id)
        {
            if(id == 0)
                return RedirectToAction("Index");

            new CadastroDadosMedicos().Excluir(id);

            return RedirectToAction("Index");
        }

        public IActionResult Incluir()
        {
            return View("Editar");
        }

    }
}
