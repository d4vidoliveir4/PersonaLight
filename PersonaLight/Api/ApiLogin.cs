using PersonaLight.Models;
using Microsoft.AspNetCore.Mvc;

namespace PersonaLight.Api
{
    [Route("m/[controller]")]
    [ApiController]
    public class ApiLogin : ControllerBase
    {
        [HttpGet]
        public bool Logar(string publicKey, string privateKey)
        {
            return new Login().Logar(publicKey, privateKey);

        }
    }
}

