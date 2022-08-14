using Biblioteca.Auxiliares;
using Crud;
using Data.Repositorios;
using Dominio.Entidades;
using Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PersonaLight.Models
{
    public class CadastroBlog : InternoModel<Postagem>
    {
        public CadastroBlog() { }

        public CadastroBlog(int id)
        {
            PreencherDadosAlteracao(id);
        }
        
        public CadastroBlog(int pagina, string categoria)
        {
            Pagina = pagina;
            Categoria = categoria;
        }

        [AllowHtml]
        public string Conteudo { get; set; }             

        public int Pagina { get;  set; }
        public string Categoria { get;  set; }
        protected override IRepositorio<Postagem> Repositorio =>  new PostagemRepositorio(); 

        public override IEnumerable<Postagem> ListarEntidades()
        {
            var lista = base.ListarEntidades();

            if (Id != 0)
                lista = lista.Where(w => w.Id == Id).ToList();

            return lista.OrderByDescending(o => o.DataPublicacao);
        }

        public IEnumerable<Postagem> ObterListaPaginaBlog()
        {
            var lista = ListarEntidades()
                .Where(w => w.PostagemPublica());

            if (Categoria != null)
                lista = lista.Where(w => (w.Tags?.ToUpper() ?? string.Empty).Contains(Categoria.ToUpper()) ||
                            Categoria == string.Empty || Categoria == null);

             return  lista.Skip((Pagina - 1) * 7).Take(7);
        }
        
        public IEnumerable<Postagem> ObterListaPaginaDiario()
        {
            return ListarEntidades().Skip((Pagina - 1) * 7).Take(7);
        }

        internal override void PreencherDadosAlteracao(int id)
        {
            var entidade = Consulta<Postagem>.Obter(Repositorio, id);

            Entidade = entidade?? new Postagem();
            Conteudo = entidade?.Conteudo;
        }

        public override void SalvarEntidade()
        {
            Entidade.Conteudo = Conteudo;
            Entidade.DataAlteracao = DateTime.Now;
            base.SalvarEntidade();
            Email.Enviar("Postagem", "Uma postagem foi alterada/incluida.");
        }

        public bool EntidadeInvalida()
        {
            if (string.IsNullOrWhiteSpace(Conteudo) || string.IsNullOrWhiteSpace(Entidade.Titulo) || Entidade.DataPublicacao == null || Entidade.DataPublicacao == new DateTime())
                Erro = "Preencha o Título e o Conteudo!";

            return !Sucesso;
        }
    }
}
