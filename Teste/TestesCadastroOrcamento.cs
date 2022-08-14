using PersonaLight.Models;
using System.Linq;
using Xunit;

namespace Teste
{
    public class TestesCadastroOrcamento
    {
        [Fact]
        public void TestarConsulta()
        {
            Assert.True(new CadastroOrcamento().ListarEntidades().Take(1).Any());
        }

        [Fact]
        public void TestarConsulta_ListarFinanceiro()
        {         
            Assert.True(new CadastroOrcamento().ListarFinanceiro().Take(1).Any());
        }
    }
}
