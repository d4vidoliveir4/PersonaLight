using PersonaLight.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PersonaLight.Controllers
{
    public class ControleFinanceiroController : InternoController
    {
        private readonly ILogger<ControleFinanceiro> _logger;

        public ControleFinanceiroController(ILogger<ControleFinanceiro> logger)
        {
            _logger = logger;
        }

        public override IActionResult Index()
        {
            return View(new ControleFinanceiro());
        }

        public IActionResult Salvar(ControleFinanceiro model)
        {
            if (model.EntidadeInvalida())
                return Editar(model);

            model.SalvarEntidade();
            if (!model.Sucesso)
                return Editar(model);

            return RedirectToAction("Movimento");
        }

        public IActionResult Movimento(int ano, int mes, int orcamento)
        {
            return View("Index", new ControleFinanceiro(ano, mes, orcamento));
        }
        
        public IActionResult Grafico(int ano, int orcamento)
        {
            return View("Grafico", new ControleFinanceiro().MontarGrafico(ano, orcamento));
        }
        
        public IActionResult Editar(int id)
        {
            return Editar(new ControleFinanceiro(id));
        }
        
        private IActionResult Editar(ControleFinanceiro model)
        {
            return View("Editar",model);
        }
        
        public IActionResult Excluir(int id)
        {
            if(id == 0)
                return RedirectToAction("Index");

            new ControleFinanceiro().Excluir(id);
            return RedirectToAction("Index");
        }

        public IActionResult Incluir()
        {
            return View("Editar");
        }

    }
}
