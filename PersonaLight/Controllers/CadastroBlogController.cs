using PersonaLight.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PersonaLight.Controllers
{
    public class CadastroBlogController : InternoController
    {
        private readonly ILogger<CadastroBlog> _logger;

        public CadastroBlogController(ILogger<CadastroBlog> logger)
        {
            _logger = logger;
        }

        public override IActionResult Index()
        {
            return View(new CadastroBlog());
        }

        public IActionResult Salvar(CadastroBlog model)
        {
            if(model.EntidadeInvalida())
                return Editar(model);

            model.SalvarEntidade();

            if (!model.Sucesso)
                return Editar(model);

            return RedirectToAction("Diario");
        }

        public IActionResult Diario(int? pagina)
        {
            var model = new CadastroBlog(pagina??1,null);
            return View("Diario", model);
        }

        public IActionResult Editar(int id)
        {
            return Editar(new CadastroBlog(id));
        }
        
        private IActionResult Editar(CadastroBlog model)
        {
            return View("Editar",model);
        }
        
        public IActionResult Excluir(int id)
        {
            if(id == 0)
                return RedirectToAction("Index");

            new CadastroBlog().Excluir(id);
            return RedirectToAction("Index");
        }

        public IActionResult Incluir()
        {
            return View("Editar");
        }

        [HttpPost]
        public JsonResult Ping()
        {
            return Json(true);
        }
    }
}
