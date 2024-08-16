using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grp4.models
{
    [Table("car_description")]
    public class CarDescription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [MaxLength(255)]
        public string CarName { get; set; }

        public string Description { get; set; }

        [MaxLength(255)]
        public string Path { get; set; }
    }
}
