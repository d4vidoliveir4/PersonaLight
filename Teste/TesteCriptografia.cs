using Biblioteca.Auxiliares;
using Xunit;

namespace Teste
{
    public class TesteCriptografia
    {        
        [Fact]
        public void TestarCriptografia()
        {
            var textoCriptografado = Criptografia.EncryptString("abcdefghijklmnopqrstuvwxyz");
            Assert.Equal("abcdefghijklmnopqrstuvwxyz",Criptografia.DecryptString(textoCriptografado));
        }

    }
}
