using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace React.Entities.Models
{
    public class Owner
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
        public string PostNumber { get; set; }

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
