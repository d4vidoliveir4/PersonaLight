using Crud;
using Data.Repositorios;
using Dominio.Entidades;
using Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonaLight.Models
{
    public class CadastroOrcamento : InternoModel<Orcamento>
    {
        public CadastroOrcamento() { }

        public CadastroOrcamento(int id)
        {
            PreencherDadosAlteracao(id);
        }

        protected override IRepositorio<Orcamento> Repositorio => new OrcamentoRepositorio();

        public IEnumerable<Financeiro> ListarFinanceiro()
        {
            var lista = Consulta<Financeiro>.Obter(new FinanceiroRepositorio())
                .Where(w=>w.Data.Month == DateTime.Now.Month && w.Data.Year == DateTime.Now.Year && w.Tipo != Dominio.Enumerados.TipoFinanceiro.Entrada).ToList();

            return lista;
        }

        
        internal override void PreencherDadosAlteracao(int id)
        {
            var entidade = Consulta<Orcamento>.Obter(Repositorio, id);

            Entidade = entidade ?? new Orcamento();
        }
    }
}
