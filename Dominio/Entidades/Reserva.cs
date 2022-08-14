using Dominio.Entidades.ClassesPai;
using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Reserva : Entidade
    {
        public Reserva() 
        {
            Orcamento = new Orcamento();
        }

        public Reserva(Orcamento orcamento)
        {
            Orcamento = orcamento;
        }

        public Reserva(string descricao, string referencia, Orcamento orcamento, decimal valorAtual, decimal valorObjetivo, DateTime prazo)
        {
            Descricao = descricao;
            Referencia = referencia;
            Orcamento = orcamento;
            ValorAtual = valorAtual;
            ValorObjetivo = valorObjetivo;
            Prazo = prazo;
        }

        public virtual string Descricao { get; set; }
        public virtual string Referencia { get; set; }
        public virtual Orcamento Orcamento { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N}")]
        public virtual decimal ValorAtual { get; set; }
        public virtual decimal ValorObjetivo { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public virtual DateTime Prazo { get; set; }
    }
}