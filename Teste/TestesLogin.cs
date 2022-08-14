using PersonaLight.Models;
using Xunit;

namespace Teste
{
    public class TestesLogin
    {
        [Fact]
        public void TestarLogar()
        {
            Assert.False(new Login().Logar("teste","teste"));
        }        
    }
}
