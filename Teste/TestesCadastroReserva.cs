using PersonaLight.Models;
using System.Linq;
using Xunit;

namespace Teste
{
    public class TestesCadastroReserva
    {
        [Fact]
        public void TestarConsulta()
        {
            Assert.True(new CadastroReserva().ListarEntidades().Take(1).Any());
        }

        [Fact]
        public void TestarConsulta_ListarOrcamentos()
        {          
            Assert.True(new CadastroReserva().ListarOrcamentos().Take(1).Any());
        }
    }
}
