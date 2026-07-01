using Dashboard.DTOs;
using Dashboard.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController(UsuarioService usuarioService):ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Criar(UsuarioDTO usuario)
        {
            await usuarioService.CriarAsync(usuario);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> BuscarTodos()
        {
            var usuarios = await usuarioService.BuscarTodosAsync();
            return Ok(usuarios);
        }
    }
}
