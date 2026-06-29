namespace Dashboard.Entities
{
    public class Chamado
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Categoria { get; set; }
        public int Criador { get; set; }
        public int Responsavel { get; set; }
    }
}
