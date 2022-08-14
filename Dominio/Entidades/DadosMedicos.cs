using Dominio.Entidades.ClassesPai;
using Dominio.Enumerados;
using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class DadosMedicos : Entidade
    {
        public DadosMedicos() { }

        public DadosMedicos(string comoMeSinto, string pressao, int glicose, decimal peso, decimal temperatura)
        {
            ComoMeSinto = comoMeSinto;
            Pressao = pressao;
            Glicose = glicose;
            Peso = peso;
            Temperatura = temperatura;
        }

        public virtual string ComoMeSinto { get; set; }
        public virtual string Pressao { get; set; }
        public virtual int Glicose { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N}")]
        public virtual decimal Peso { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N}")]
        public virtual decimal Temperatura { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-ddTHH:mm}")]
        public virtual DateTime Data { get; set; }
    }
}