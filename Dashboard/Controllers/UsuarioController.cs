using Dashboard.DTOs;
using Dashboard.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController(UsuarioService usuarioService):ControllerBase
    {
        public async Task<IActionResult> Criar(UsuarioDTO usuario)
        {
            await usuarioService.CriarAsync(usuario);
            return Ok();
        }
    }
}
