using Kolokwium1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Services
{
     public interface IDbService 
    {
        public List<Medicament> GetMedicament(int IdMedicament);

        public void DeletePatient(int IdPatient);
    }
}
