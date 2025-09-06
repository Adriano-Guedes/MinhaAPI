using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaAPI.Domain
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        [Required]
        [StringLength(255)]
        public string? Nome { get; set; }
        [Required]
        [StringLength(2000)]
        public string? Descricao { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco { get; set; }
        [Required]
        [StringLength(300)]
        public string? ImagemURL { get; set; }
        public float Estoque { get; set; }
        public DateTime DataCadastro { get; set; }

        public Categoria? Categoria { get; set; }
    }
}
