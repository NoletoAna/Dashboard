using Dashboard.DTOs;
using Dashboard.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController(CategoriaService categoriaService) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Criar(CategoriaDTO categoria)
        {
            await categoriaService.CriarAsync(categoria);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> BuscarTodos()
        {
            var categorias = await categoriaService.BuscarTodosAsync();
            return Ok(categorias);
        }
    }
}
