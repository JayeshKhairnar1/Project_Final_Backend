using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grp4.models
{
    [Table("alternate_components")]
    public class AlternateComponent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public double DeltaPrice { get; set; }

        [Required]
        public long CompId { get; set; }

        [Required]
        public long ModId { get; set; }

        public long? AltCompId { get; set; }

        [ForeignKey("CompId")]
        public virtual Component Component { get; set; }

        [ForeignKey("ModId")]
        public virtual Model Model { get; set; }
    }
}
