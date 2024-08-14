using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grp4.models
{
    [Table("models")]
    public class Model
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string ImagePath { get; set; }

        [Required]
        public int MinQty { get; set; }

        [Required]
        [MaxLength(255)]
        public string ModName { get; set; }

        [Required]
        public int Price { get; set; }

        public int SafetyRating { get; set; } = 5;

        [ForeignKey("Manufacturer")]
        public long ManuId { get; set; }

        [ForeignKey("Segment")]
        public int SegId { get; set; }

        // Navigation Properties
        public Manufacturer Manufacturer { get; set; }
        public Segment Segment { get; set; }
    }
}
