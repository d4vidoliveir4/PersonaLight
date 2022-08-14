using Crud;
using Dominio.Entidades.ClassesPai;
using Dominio.Repositorios;
using System.Collections.Generic;

namespace PersonaLight.Models
{
    public abstract class InternoModel<T> where T : Entidade
    {
        public int Id { get; set; }
        public T Entidade { get; set; }
        public string Erro { get; set; }
        protected abstract IRepositorio<T> Repositorio { get; }

        internal abstract void PreencherDadosAlteracao(int id);

        public bool Sucesso => string.IsNullOrWhiteSpace(Erro);

        public virtual void SalvarEntidade()
        {
            Erro = Gravacao<T>.Salvar(Repositorio, Entidade);
        }

        public virtual bool Excluir(int id)
        {
            return Exclusao<T>.Excluir(Repositorio, id);
        }

        public virtual IEnumerable<T> ListarEntidades()
        {
            return Consulta<T>.Obter(Repositorio);
        }

    }
}
