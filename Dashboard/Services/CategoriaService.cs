using Dashboard.Data;
using Dashboard.DTOs;
using Dashboard.Entities;

namespace Dashboard.Services
{
    public class CategoriaService(ApplicationDbContext _context)
    {
        public async Task CriarCategoriaAsync(CategoriaDTO categoria)
        {
            var novaCategoria = new Categoria
            {
                Nome = categoria.Nome
            };

            _context.Categorias.Add(novaCategoria);
            await _context.SaveChangesAsync();
        }
    }
}
