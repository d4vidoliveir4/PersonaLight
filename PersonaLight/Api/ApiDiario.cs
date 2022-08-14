using Crud;
using PersonaLight.Models;
using Data.Repositorios;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace PersonaLight.Api
{
    [Route("m/[controller]")]
    [ApiController]
    public class ApiDiario : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Postagem> Get(string publicKey, string privateKey)
        {
            if (!new Login().Logar(publicKey, privateKey))
                return null;

            return Consulta<Postagem>.Obter(new PostagemRepositorio()).Select(s => { s.Conteudo = string.Empty; return s; });
        }

        [HttpGet("{id}")]
        public Postagem Get(int id, string publicKey, string privateKey)
        {
            if (!new Login().Logar(publicKey, privateKey))
                return null;

            var retorno = Consulta<Postagem>.Obter(new PostagemRepositorio(),id);

            return null;
        }

        [HttpPost]
        public void Post([FromBody] Postagem value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Postagem value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
