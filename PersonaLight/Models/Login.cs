using Biblioteca.Auxiliares;
using Crud;
using Data.Repositorios;
using Dominio.Entidades;
using Dominio.Repositorios;
using System.Linq;

namespace PersonaLight.Models
{
    public class Login
    {
        public Login()
        {
            Usuario = string.Empty;
            Senha = string.Empty;
        }

        public IRepositorio<Usuario> RepositorioUsuario { get; set; }

        public string Usuario { get; set; }
        public string Senha { get; set; }
        
        public bool Logar(string usuario, string senha)
        {
            var usuarioValido = Consulta<Usuario>.Obter(new UsuarioRepositorio())
                .Any(a => Criptografia.DecryptString(a.Login) == usuario && Criptografia.DecryptString(a.Senha) == senha);

            return usuarioValido;
        }
    }
}
