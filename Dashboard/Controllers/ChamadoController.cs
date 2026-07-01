using Dashboard.DTOs;
using Dashboard.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChamadoController(ChamadoService chamadoService) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Criar(ChamadoDTO chamado)
        {
            await chamadoService.CriarAsync(chamado);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> BuscarTodos()
        {
            var chamados = await chamadoService.BuscarTodosAsync();
            return Ok(chamados);
        }
    }
}
