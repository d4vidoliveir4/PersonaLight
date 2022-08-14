using Biblioteca.Auxiliares;
using Crud;
using Data.Repositorios;
using Dominio.Entidades;
using Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonaLight.Models
{
    public class ControleFinanceiro : InternoModel<Financeiro>
    {
        public ControleFinanceiro()
        {
            Ano = DateTime.Now.Year;
            Mes = DateTime.Now.Month;
        }

        public ControleFinanceiro(int id)
        {
            PreencherDadosAlteracao(id);
        }

        public ControleFinanceiro(int ano, int mes, int idOrcamento)
        {
            Ano = ano != 0 ? ano : DateTime.Now.Year;
            Mes = mes != 0 ? mes : DateTime.Now.Month;
            IdOrcamento = idOrcamento;
        }

        public List<Item> ListaTipo => ListasBase.ObterTiposFinanceiro();
        public List<Item> ListaMes => ListasBase.ObterListaMeses();       
        public List<Item> ListaAno => ListasBase.ObterUltimos10Anos();        

        public int Ano { get; set; }
        public int Mes { get; set; }
        public int IdOrcamento { get; set; }
        public string DadosGrafico { get; set; }

        protected override IRepositorio<Financeiro> Repositorio => new FinanceiroRepositorio();

        internal ControleFinanceiro MontarGrafico(int ano, int idOrcamento)
        {
            IdOrcamento = idOrcamento;
            if(ano == 0)
                ano = DateTime.Now.Year;

            DadosGrafico = "[";
            var resultado = ListarEntidades()
                .Where(w => w.Data.Year == ano &&
                            w.Tipo == Dominio.Enumerados.TipoFinanceiro.Saida);

            if (IdOrcamento > 0)
                resultado = resultado.Where(w => w.Orcamento.Id == IdOrcamento);

            for (var mes=1;mes<=12;mes++)
                DadosGrafico += $"{Math.Truncate(resultado.Where(w=>w.Data.Month==mes).Sum(s => s.Valor))},";
            DadosGrafico += "]";

            return this;
        }

        public IEnumerable<Item> ListarOrcamentosFiltro()
        {
            var lista = new List<Item> { new Item(0, "Todos") };
            lista.AddRange(ListarOrcamentos().Select(s => new Item(s.Id, s.Descricao??string.Empty)));
            return lista;
        }

        public IEnumerable<Orcamento> ListarOrcamentos()
        {
            return Consulta<Orcamento>.Obter(new OrcamentoRepositorio()).OrderBy(o => o.Descricao);
        }
        
        public IEnumerable<Financeiro> ListarFinanceiroDoMes()
        {
            var retorno = ListarEntidades().Where(w => w.Data.Month == Mes && w.Data.Year == Ano);
            if (IdOrcamento > 0)
                retorno = retorno.Where(w => w.Orcamento.Id == IdOrcamento);

            return retorno.OrderBy(o => o.Data);
        }
        
        internal override void PreencherDadosAlteracao(int id)
        {
            var usuario = Consulta<Financeiro>.Obter(Repositorio, id);

            Entidade = usuario ?? new Financeiro();
        }

        public bool EntidadeInvalida()
        {
            if (Entidade.Orcamento == null || Entidade.Orcamento.Id == 0 || Entidade.Valor == 0 || Entidade.Data == null || Entidade.Data == new DateTime() || string.IsNullOrWhiteSpace(Entidade.Descricao))
                Erro = "Preencha todos os campos!";

            return !Sucesso;
        }

    }
}
