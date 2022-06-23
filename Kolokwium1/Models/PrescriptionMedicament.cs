using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Models
{
    public class PrescriptionMedicament
    {
        [Required]
        public int IdMedicament { get; set; }
        [Required]
        public int IdPrescription { get; set; }
        [Required]
        public int Dose { get; set; }
        [Required]
        [MaxLength(100)]
        public string Detalis { get; set; }
    }
}
