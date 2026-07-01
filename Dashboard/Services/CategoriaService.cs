using Dashboard.Data;
using Dashboard.DTOs;
using Dashboard.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Services
{
    public class CategoriaService(ApplicationDbContext _context)
    {
        public async Task CriarAsync(CategoriaDTO categoria)
        {
            var novaCategoria = new Categoria
            {
                Nome = categoria.Nome
            };

            _context.Categorias.Add(novaCategoria);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Categoria>> BuscarTodosAsync()
        {
            return await _context.Categorias.ToListAsync();
        }
    }
}
