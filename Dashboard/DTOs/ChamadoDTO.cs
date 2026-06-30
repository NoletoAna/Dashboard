using Dashboard.Entities;
using Dashboard.Entities.Enum;
namespace Dashboard.DTOs;

public record ChamadoDTO
(
    string Titulo,
    string Descricao,
    int Categoria,
    int Criador,
    int ? Responsavel, 
    StatusChamadoEnum Status
);



