using Dominio.Entidades.ClassesPai;
using Dominio.Repositorios;
using System;

namespace Crud
{
    public static class Exclusao<T> where T : Entidade
    {
        public static bool Excluir(IRepositorio<T> repositorio, int id)
        {
            try
            {
                repositorio.Excluir(id);
                repositorio.FecharSessao();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
