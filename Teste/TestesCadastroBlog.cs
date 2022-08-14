using PersonaLight.Models;
using System.Linq;
using Xunit;

namespace Teste
{
    public class TestesCadastroBlog
    {
        [Fact]
        public void TestarConsulta()
        {
            Assert.True(new CadastroBlog().ListarEntidades().Take(1).Any());
        }

        [Fact]
        public void TestarValidacaoInclusao()
        {
            var model = new CadastroBlog();
            model.Entidade = new Dominio.Entidades.Postagem();
            model.Entidade.DataPublicacao = new System.DateTime();
            Assert.True(model.EntidadeInvalida());

            model.Conteudo = "teste";
            Assert.True(model.EntidadeInvalida());

            model.Entidade.Titulo = "teste";
            Assert.True(model.EntidadeInvalida());

            model.Entidade.DataPublicacao = System.DateTime.Now;
            Assert.False(model.EntidadeInvalida());
        }

        [Theory]
        [InlineData(1,"")]
        [InlineData(5,null)]
        public void TestarConsultaPaginas(int pagina, string categoria )
        {
            var model = new CadastroBlog(pagina, categoria);
            Assert.True(model.ObterListaPaginaBlog().Take(1).Any());
            Assert.True(model.ObterListaPaginaDiario().Take(1).Any());
        }
    }
}
