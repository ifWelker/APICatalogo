using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models;


[Table("Categorias")]
public class Categorias
{
    public Categorias()
    {
        Produtos = new Collection<Produtos>();
    }
    [Key]
    public int CategoriaId { get; set; }
    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }
    [Required]
    [MaxLength(300)]
    public string? ImagemUrl { get; set; }
    public ICollection<Produtos>? Produtos { get; set; }
}
