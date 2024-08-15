using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grp4.models
{
    [Table("vehicles")]
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [Column(TypeName = "enum('A','E','I','S')")]
        public string CompType { get; set; }

        [Required]
        [Column(TypeName = "enum('N','Y')")]
        public string IsConfigurable { get; set; }

        [ForeignKey("Component")]
        public long CompId { get; set; }

        [ForeignKey("Model")]
        public long ModId { get; set; }

        // Navigation Properties
        public Component Component { get; set; }
        public Model Model { get; set; }
    }
}
