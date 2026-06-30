using Dashboard.Entities;
using Dashboard.Entities.Enum;

public class Chamado
{
    public int Id { get; set; }
    public string Titulo { get; set; } = null!;
    public string Descricao { get; set; } = null!;
    public int CategoriaId { get; set; }
    public Categoria Categoria { get; set; } = null!;
    public StatusChamadoEnum Status { get; set; }
    public int CriadorId { get; set; }
    public Usuario Criador { get; set; } = null!;
    public int? ResponsavelId { get; set; }
    public Usuario? Responsavel { get; set; }
}