namespace Empreitta.Models
{
    public class TarefaCalculo
    {
        public string Obra { get; set; }
        public string Descricao { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Valor { get; set; }

        public decimal Total => Quantidade * Valor;
    }
}
