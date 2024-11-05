using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP03SWII6.Models
{
    [Table("produto")]
    public class Product
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
    }
}
