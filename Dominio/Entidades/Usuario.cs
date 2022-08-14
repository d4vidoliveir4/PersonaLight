using Dominio.Entidades.ClassesPai;

namespace Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public Usuario() { }

        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }

        public virtual string Login { get; set; }
        public virtual string Senha { get; set; }
    }
}