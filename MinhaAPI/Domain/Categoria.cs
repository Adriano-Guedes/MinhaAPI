using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaAPI.Domain
{
    [Table("Categorias")]
    public class Categoria
    {
        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }

        [Key]
        public int CategoriaId { get; set; }
        [Required]
        [StringLength(255)]
        public string? Nome { get; set; }
        [Required]
        [StringLength(300)]
        public string? ImagemURL { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
    }
}
