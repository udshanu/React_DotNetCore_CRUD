using React.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace React.Entities.Models
{
    public class Owner : Entity
    {
        [Key]
        [Required]
        public long Id { get; set; }

        [StringLength(250)]
        [Required]
        public string Name { get; set; }

        [StringLength(100)]
        [Required]
        public string Address { get; set; }

        [StringLength(100)]
        public string Address2 { get; set; }

        [StringLength(100)]
        public string Address3 { get; set; }

        [StringLength(50)]
        [Required]
        public int PostNumber { get; set; }

        [StringLength(50)]
        [Required]
        public string City { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string Tele { get; set; }
    }
}
