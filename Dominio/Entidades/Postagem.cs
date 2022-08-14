using Dominio.Entidades.ClassesPai;
using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Postagem : Entidade
    {
        public Postagem() 
        { 
            DataPublicacao = DateTime.Now;
        }

        public Postagem(DateTime dataPublicacao)
        {
            DataPublicacao = dataPublicacao;
            DataAlteracao = DateTime.Now;
        }

        public Postagem(string titulo, string conteudo, DateTime dataPublicacao, bool publicado, string tags)
        {
            Titulo = titulo;
            Conteudo = conteudo;
            DataPublicacao = dataPublicacao;
            Publicado = publicado;
            Tags = tags;
            DataAlteracao = DateTime.Now;
        }

        public virtual string Titulo { get; set; }
        public virtual string Conteudo { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-ddTHH:mm}")]
        public virtual DateTime DataPublicacao { get; set; }
        public virtual DateTime DataAlteracao { get; set; }
        public virtual bool Publicado { get; set; }
        public virtual string Tags { get; set; }

        public virtual bool PostagemPublica()
        {
            return Publicado && DataPublicacao <= DateTime.Now; ;
        }
    }
}