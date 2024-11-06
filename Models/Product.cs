using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/*
CB3011836 - Ketheleen Cristine Simão dos Santos
CB3020282 - Ronald Pereira Evangelista
*/

namespace TP03SWII6.Models
{
    [Table("produto")]
    public class Product
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("Name")]
        public string Name { get; set; }

        [Required]
        [Column("Price")]
        public decimal Price { get; set; }

        [Required]
        [Column("Quantity")]
        public int Quantity { get; set; }
    }
}
