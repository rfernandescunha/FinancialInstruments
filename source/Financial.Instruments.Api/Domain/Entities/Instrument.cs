using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Financial.Instruments.Api.Domain.Entities
{
    [Table("tb_instrument")]
    public partial class Instrument
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal MarketValue { get; set; }

        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Type { get; set; }

        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Category { get; set; }

    }
}
