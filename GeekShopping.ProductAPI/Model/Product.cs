using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace GeekShopping.ProductAPI.Model
{
    [Table("Produtos")]
    public class Product : BaseEntity
    {
        [Column("Nome")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Column("Preco")]
        [Required]
        [Range(1, 10000)]
        public decimal Price { get; set; }

        [Column("Descricao")]
        [StringLength(500)]
        public string Description { get; set; }

        [Column("NomeCategoria")]
        [StringLength(50)]
        public string CategoryName { get; set; }

        [Column("UrlImagem")]
        [StringLength(300)]
        public string ImageUrl { get; set; }
    }
}
