using Dashboard.Data;
using Dashboard.DTOs;
using Dashboard.Entities;

namespace Dashboard.Services
{
    public class UsuarioService(ApplicationDbContext _context)
    {
        public async Task CriarAsync(UsuarioDTO usuario)
        {
            var novoUsuario = new Usuario
            {
                Nome = usuario.Nome,
                Email = usuario.Email
            };

            _context.Usuarios.Add(novoUsuario);
            await _context.SaveChangesAsync();
        }
    }
}
