using PersonaLight.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PersonaLight.Controllers
{
    public class CadastroUsuarioController : InternoController
    {
        private readonly ILogger<CadastroUsuario> _logger;

        public CadastroUsuarioController(ILogger<CadastroUsuario> logger)
        {
            _logger = logger;
        }

        public override IActionResult Index()
        {
            return View(new CadastroUsuario());
        }

        public IActionResult Salvar(CadastroUsuario model)
        {
            if (model.EntidadeInvalida())
                return Editar(model);

            model.SalvarEntidade();
            if (!model.Sucesso)
                return Editar(model);

            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            return Editar(new CadastroUsuario(id));
        }

        private IActionResult Editar(CadastroUsuario model)
        {
            return View("Editar",model);
        }

        public IActionResult Incluir()
        {
            return View("Editar");
        }

        public IActionResult Excluir(int id)
        {
            if (id == 0)
                return RedirectToAction("Index");

            new CadastroUsuario().Excluir(id);
            return RedirectToAction("Index");
        }

    }
}
