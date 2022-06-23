using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Models
{
    public class Medicament
    {
        [Required]
        public int IdMedicament { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        [MaxLength(100)]
        [Required]
        public string Description { get; set; }
        [MaxLength(100)]
        [Required]
        public string Type { get; set; }

        public ICollection<PrescriptionMedicament> PrescriptionMedicaments { get; set; }
        
    }
}
