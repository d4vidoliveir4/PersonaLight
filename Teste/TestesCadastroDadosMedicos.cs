using PersonaLight.Models;
using System.Linq;
using Xunit;

namespace Teste
{
    public class TestesCadastroDadosMedicos
    {
        [Fact]
        public void TestarConsulta()
        {
            Assert.True(new CadastroDadosMedicos().ListarEntidades().Take(1).Any());
        }
    }
}
