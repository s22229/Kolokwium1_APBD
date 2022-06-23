using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Models
{
    public class Prescription
    {
        [Required]
        public int IdPrescriprion { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public int IdPatient { get; set; }
        [Required]
        public int IdDoctor { get; set; }

        public ICollection<PrescriptionMedicament> prescriptionMedicaments { get; set; }
    }
}
