using Dominio.Entidades.ClassesPai;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Orcamento : Entidade
    {
        public Orcamento() { }

        public Orcamento(string descricao, decimal valor) 
        {
            Descricao = descricao;
            Valor = valor;
        }

        public virtual string Descricao { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N}")]
        public virtual decimal Valor { get; set; }
    }
}