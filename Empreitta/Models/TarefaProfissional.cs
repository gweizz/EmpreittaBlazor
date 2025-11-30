namespace Empreitta.Models
{
    public class TarefaProfissional
    {
        public int Id { get; set; }
        public int ProfissionalId { get; set; }
        public Profissional Profissional { get; set; }
        public string Obra { get; set; }
        public string Descricao { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataRegistro { get; set; } = DateTime.Now;
        public int Mes { get; set; }
        public int Ano { get; set; }
        public decimal Total => Quantidade * Valor;
    }
}