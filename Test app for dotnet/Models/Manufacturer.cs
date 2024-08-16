using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grp4.models
{
    [Table("manufacturers")]
    public class Manufacturer
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string ManuName { get; set; }

        [ForeignKey("Segment")]
        public int SegId { get; set; }

        // Navigation Property
        public Segment Segment { get; set; }
    }
}
