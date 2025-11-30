using System.ComponentModel.DataAnnotations;

namespace Empreitta.Models
{
    public class Profissional
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public string Cpf { get; set; } = string.Empty;

        public string Telefone { get; set; } = string.Empty;

        [Required]
        public decimal SalarioBase { get; set; }
    }
}
