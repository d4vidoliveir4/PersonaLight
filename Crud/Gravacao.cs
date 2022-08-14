using Dominio.Entidades.ClassesPai;
using Dominio.Repositorios;
using System;

namespace Crud
{
    public static class Gravacao<T> where T : Entidade
    {
        public static string Salvar(IRepositorio<T> repositorio, T entidade)
        {
            try
            {
                repositorio.Salvar(entidade);
                repositorio.FecharSessao();

                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }           
        }

    }
}
