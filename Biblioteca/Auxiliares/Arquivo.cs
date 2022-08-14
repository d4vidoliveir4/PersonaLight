using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.StaticFiles;
using System.IO;

namespace Biblioteca.Auxiliares
{
    public static class Arquivo
    {
        public static byte[] ConverterIFormToByte(IFormFile arquivo)
        {
            var length = arquivo.Length;

            var fileStream = arquivo.OpenReadStream();
            var bytes = new byte[length];
            fileStream.Read(bytes, 0, (int)arquivo.Length);

            return bytes;
        }

        public static IFormFile ConverterByteToIForm(byte[] dados, string nome)
        {
            var ms = new MemoryStream();
            ms.Write(dados);

            return new FormFile(ms, 0, ms.Length, nome, nome);
        }

        public static string ObterTypeFile(string nome)
        {
            string contentType;
            new FileExtensionContentTypeProvider().TryGetContentType(nome, out contentType);
            return contentType;
        }
    }
}
