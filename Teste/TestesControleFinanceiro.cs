using PersonaLight.Models;
using System;
using System.Linq;
using Xunit;

namespace Teste
{
    public class TestesControleFinanceiro
    {
        [Fact]
        public void TestarConsulta()
        {
            var model = new ControleFinanceiro();
            Assert.True(model.ListarEntidades().Take(1).Any());
        }

        [Fact]
        public void TestarValidacaoInclusao()
        {
            var model = new ControleFinanceiro();
            model.Entidade = new Dominio.Entidades.Financeiro();
            Assert.True(model.EntidadeInvalida());

            model.Entidade.Valor = 100;
            Assert.True(model.EntidadeInvalida());

            model.Entidade.Descricao = "teste";
            Assert.True(model.EntidadeInvalida());

            model.Entidade.Orcamento.Id = 1;
            Assert.False(model.EntidadeInvalida());
        }

        [Fact]
        public void TestarConsulta_ListarFinanceiroDoMes()
        {
            var model = new ControleFinanceiro(DateTime.Now.Year,DateTime.Now.Month,0);
            Assert.True(model.ListarFinanceiroDoMes().Take(1).Any());
        }

        [Fact]
        public void TestarConsulta_ListarOrcamentos()
        {
            var model = new ControleFinanceiro();            
            Assert.True(model.ListarOrcamentos().Take(1).Any());
        }
    }
}
