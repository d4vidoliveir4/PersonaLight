using Data.NHibernate;
using Dominio.Entidades.ClassesPai;
using Dominio.Repositorios;
using NHibernate;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositorios.ClassesPai
{
    public class Repositorio<T> : IRepositorio<T> where T : Entidade
    {
        public Repositorio()
        {
            Session = FluentNHibernateHelper.OpenSession();
        }

        protected ISession Session { get; set; }

        public void Salvar(T entidade)
        {
            using (var tran = Session.BeginTransaction())
            {
                Session.SaveOrUpdate(entidade);
                tran.Commit();
            }
        }

        public void Excluir(T contato)
        {
            using (var tran = Session.BeginTransaction())
            {
                Session.Delete(contato);
                tran.Commit();
            }
        }
        
        public void Excluir(int id)
        {
            var entidade = ObterPor(id);
            Excluir(entidade);
        }

        public T ObterPor(int id)
        {
            return Session.Get<T>(id);
        }

        public List<T> ObterTodos()
        {
            return Session.Query<T>().ToList();
        }

        public void FecharSessao()
        {
            Session.Close();
        }
    }
}
