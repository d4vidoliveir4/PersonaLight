using PersonaLight.Models;
using Dominio.Entidades;
using System.Linq;
using Xunit;

namespace Teste
{
    public class TestesCadastroUsuario
    {
        [Fact]
        public void TestarConsulta()
        {
            Assert.True(new CadastroUsuario().ListarEntidades().Take(1).Any());
        }
        
        [Fact]
        public void TestarValidacaoInclusao()
        {
            var model = new CadastroUsuario();
            model.Entidade = new Usuario();
            Assert.True(model.EntidadeInvalida());

            model.Entidade.Login = "teste";
            Assert.True(model.EntidadeInvalida());

            model.Entidade.Senha = "teste";
            Assert.False(model.EntidadeInvalida());

        }
        
        [Fact]
        public void Validacoes_SalvarEntidade()
        {
            var model = new CadastroUsuario();
            model.Entidade = new Usuario("teste","teste");
            model.ConfirmacaoSenhaNova = "abc";
            model.SalvarEntidade();
            Assert.False(model.Sucesso);
        }
    }
}
