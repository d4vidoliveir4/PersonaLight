using Dominio.Entidades.ClassesPai;
using Dominio.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace Crud
{
    public static class Consulta<T> where T : Entidade
    {       
        public static IEnumerable<T> Obter(IRepositorio<T> repositorio)
        {
            var resultado = repositorio.ObterTodos().ToList();
            repositorio.FecharSessao();

            return resultado;
        }
        public static T Obter(IRepositorio<T> repositorio, int id)
        {
            var resultado = repositorio.ObterPor(id);
            repositorio.FecharSessao();

            return resultado;
        }        
        public static bool Existe(IRepositorio<T> repositorio, int id)
        {            
            return Obter(repositorio,id) != null;
        }

    }
}
