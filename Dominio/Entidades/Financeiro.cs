using Dominio.Entidades.ClassesPai;
using Dominio.Enumerados;
using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Financeiro : Entidade
    {
        public Financeiro() 
        {
            Orcamento = new Orcamento();
            Data = DateTime.Now;
        }

        public Financeiro(DateTime data, Orcamento orcamento)
        {
            Data = data;
            Orcamento = orcamento;
        }

        public Financeiro(string descricao, decimal valor, Orcamento orcamento, TipoFinanceiro tipo, DateTime data)
        {
            Descricao = descricao;
            Valor = valor;
            Orcamento = orcamento;
            Tipo = tipo;
            Data = data;
        }

        public virtual string Descricao { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N}")]
        public virtual decimal Valor { get; set; }
        public virtual Orcamento Orcamento { get; set; }
        public virtual TipoFinanceiro Tipo { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public virtual DateTime Data { get; set; }
    }
}