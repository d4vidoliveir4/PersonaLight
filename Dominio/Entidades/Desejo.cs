using Dominio.Entidades.ClassesPai;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Desejo : Entidade
    {
        public Desejo() 
        {
        }

        public Desejo(string descricao, decimal valor, int ordem, bool realizado)
        {
            Descricao = descricao;
            Valor = valor;
            Ordem = ordem;
            Realizado = realizado;
        }

        public virtual string Descricao { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N}")]
        public virtual decimal Valor { get; set; }

        public virtual int Ordem { get; set; }
        public virtual bool Realizado { get; set; }
    }
}