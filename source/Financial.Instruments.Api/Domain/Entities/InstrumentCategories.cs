using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Financial.Instruments.Api.Domain.Entities
{
    [Table("tb_instrument_categories")]
    public partial class InstrumentCategories
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public double MinValue { get; set; }

        [Column(TypeName = "money")]
        public double MaxValue { get; set; }
    }
}
