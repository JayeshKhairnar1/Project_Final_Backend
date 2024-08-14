using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grp4.models
{
    [Table("invoices")]
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public byte[] AltCompId { get; set; }

        [Required]
        public int ModelId { get; set; }

        [Required]
        public int ModelPrice { get; set; }

        [Required]
        public int OrderedQty { get; set; }

        [Required]
        public int TotalPrice { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}
