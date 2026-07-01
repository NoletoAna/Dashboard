using Dashboard.Data;
using Dashboard.DTOs;
using Dashboard.Entities;
using Dashboard.Entities.Enum;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Services
{
    public class ChamadoService(ApplicationDbContext _context)
    {
        public async Task CriarAsync(ChamadoDTO chamado)
        {
            var novoChamado = new Chamado
            {
                Titulo = chamado.Titulo,
                Descricao = chamado.Descricao,
                CategoriaId = chamado.Categoria,
                Status = chamado.Status,
                CriadorId = chamado.Criador,
                ResponsavelId = chamado.Responsavel
            };

            _context.Chamados.Add(novoChamado);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Chamado>> BuscarTodosAsync()
        {
            return await _context.Chamados.ToListAsync();
        }
    }
}
