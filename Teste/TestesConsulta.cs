using Crud;
using Data.Repositorios;
using Dominio.Entidades;
using System.Linq;
using Xunit;

namespace Teste
{
    public class TestesConsulta
    {
        [Fact]
        public void TestarConsultas()
        {
            Assert.True(Consulta<Financeiro>.Obter(new FinanceiroRepositorio()).Take(1).Any());
            Assert.True(Consulta<Orcamento>.Obter(new OrcamentoRepositorio()).Take(1).Any());
            Assert.True(Consulta<Postagem>.Obter(new PostagemRepositorio()).Take(1).Any());
            Assert.True(Consulta<Reserva>.Obter(new ReservaRepositorio()).Take(1).Any());
            Assert.True(Consulta<Usuario>.Obter(new UsuarioRepositorio()).Take(1).Any());
            Assert.True(Consulta<DadosMedicos>.Obter(new DadosMedicosRepositorio()).Take(1).Any());
            Assert.True(Consulta<Desejo>.Obter(new DesejoRepositorio()).Take(1).Any());
        }

    }
}
