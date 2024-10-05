using System.ComponentModel.DataAnnotations;

namespace GestaoProdutos.Models
{
    public class Produto
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O valor do produto é obrigatório.")]
        [Range(0, double.MaxValue, ErrorMessage = "O valor do produto deve ser um número positivo.")]
        public double? Valor { get; set; }

        [Required(ErrorMessage = "A disponibilidade do produto é obrigatória.")]
        public EProdutoDisponivel Disponivel { get; set; }

        public Produto()
        {
            Valor = 0;
        }
    }
}
