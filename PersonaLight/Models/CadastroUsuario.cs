using Biblioteca.Auxiliares;
using Crud;
using Data.Repositorios;
using Dominio.Entidades;
using Dominio.Repositorios;

namespace PersonaLight.Models
{
    public class CadastroUsuario : InternoModel<Usuario>
    {
        public CadastroUsuario() { }

        public CadastroUsuario(int id)
        {
            PreencherDadosAlteracao(id);
        }

        public string SenhaAtual { get; set; }
        public string ConfirmacaoSenhaNova { get; set; }
        protected override IRepositorio<Usuario> Repositorio { get { return new UsuarioRepositorio(); } }

        internal override void PreencherDadosAlteracao(int id)
        {
            var entidade = Consulta<Usuario>.Obter(Repositorio, id);

            if(entidade != null)
                entidade.Login = Criptografia.DecryptString(entidade.Login);

            Entidade = entidade ?? new Usuario() ;
        }

        public override void SalvarEntidade()
        {
            if (SenhaDiferenteDaConfirmacao())
            {
                Erro = "Senha diferente da confirmação!";
            }
            if (Entidade.Id != 0 && SenhaErrada()) 
                Erro =  "Senha incorreta!";                
            
            Entidade.Login = Criptografia.EncryptString(Entidade.Login);
            Entidade.Senha = Criptografia.EncryptString(Entidade.Senha);
            base.SalvarEntidade();

            Email.Enviar("Usuario", "Um usuario foi alterado/incluido.");
        }

        private bool SenhaErrada()
        {
            var usuarioAtual = Consulta<Usuario>.Obter(Repositorio, Entidade.Id);
            return SenhaAtual != Criptografia.DecryptString(usuarioAtual.Senha);
        }

        private bool SenhaDiferenteDaConfirmacao()
        {
            return Entidade.Senha != ConfirmacaoSenhaNova;
        }

        public bool EntidadeInvalida()
        {
            if (string.IsNullOrWhiteSpace(Entidade.Login) || string.IsNullOrWhiteSpace(Entidade.Senha))
                Erro = "Preencha todos os campos!";

            return !Sucesso;
        }
    }
}
