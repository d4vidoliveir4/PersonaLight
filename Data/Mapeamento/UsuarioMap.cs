using Dominio.Entidades;
using Data.Mapeamento.ClassesPai;

namespace Data.Mapeamento
{
    class UsuarioMap : Map<Usuario>
    {
        public UsuarioMap()
        {           
            Map(x => x.Login);
            Map(x => x.Senha);
            Table("Usuario");
        }
    }
}