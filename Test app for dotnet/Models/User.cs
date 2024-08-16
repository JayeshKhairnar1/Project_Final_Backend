using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grp4.models
{
    [Table("user")]
    public class User
    {
        [Key]
        [MaxLength(255)]
        public string UserId { get; set; }

        [MaxLength(255)]
        public string AddressLine1 { get; set; }

        [MaxLength(255)]
        public string AddressLine2 { get; set; }

        [MaxLength(255)]
        public string City { get; set; }

        [MaxLength(255)]
        public string CompanyName { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        [MaxLength(255)]
        public string GstNumber { get; set; }

        [MaxLength(255)]
        public string Password { get; set; }

        [MaxLength(255)]
        public string PinCode { get; set; }

        [MaxLength(255)]
        public string State { get; set; }

        [MaxLength(255)]
        public string Telephone { get; set; }

        [MaxLength(255)]
        public string Username { get; set; }
    }
}
