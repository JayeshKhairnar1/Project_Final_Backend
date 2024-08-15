using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grp4.models
{
    public class Invoice
    {
        public int Id { get; set; }
        public byte[] AltCompId { get; set; }
        public int ModelId { get; set; }
        public int ModelPrice { get; set; }
        public int OrderedQty { get; set; }
        public int TotalPrice { get; set; }
        public int UserId { get; set; }

        // Navigation Properties
        public Model Model { get; set; }
        public User User { get; set; }
    }
}
