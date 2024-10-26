using ApiPrincipal.Dominio;
using ApiPrincipal.Dominio.Modelo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPrincipal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public ActionResult<RetornoBase<Usuario>> ListarUsuarios()
        {
            return Ok(new RetornoBase<Usuario>());
        }
    }
}
