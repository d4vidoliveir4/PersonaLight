using PersonaLight.Models;
using Dominio.Entidades;
using System.Linq;
using Xunit;

namespace Teste
{
    public class TestesCadastroDesejo
    {
        [Fact]
        public void TestarConsulta()
        {
            Assert.True(new CadastroDesejo().ListarEntidades().Take(1).Any());
        }
        
    }
}
