using Kolokwium1.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Services
{
    public class DbService : IDbService
    {
        public void DeletePatient(int IdPatient)
        {
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\Kolokwium;Initial Catalog=Kolokwium1;Integrated Security=True");
        }

        public List<Medicament> GetMedicament(int IdMedicament)
        {
            List<Medicament> medicaments = new List<Medicament>();
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\Kolokwium;Initial Catalog=Kolokwium1;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = "SELECT * FROM Medicament WHERE IdMedicament = @IdMedicament";
            command.Parameters.AddWithValue("@IdMedicament", IdMedicament);
            //command.CommandText = "SELECT * FROM PrescriptionMedicament WHERE IdMedicament = @IdMedicament";
            SqlDataReader dataReader = command.ExecuteReader();
            while(dataReader.Read())
            {
                Medicament medicament = new Medicament
                {
                    IdMedicament = IdMedicament,
                    Name = dataReader["Name"].ToString(),
                    Description = dataReader["Description"].ToString(),
                    Type = dataReader["Type"].ToString(),
                    PrescriptionMedicaments = GetPrescriptionMedicaments(IdMedicament)
                };

                medicaments.Add(medicament);
            }

            return medicaments;

        }

        public ICollection<PrescriptionMedicament> GetPrescriptionMedicaments(int IdMedicament)
        {
            List<PrescriptionMedicament> prescriptionMedicaments = new List<PrescriptionMedicament>();
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\Kolokwium;Initial Catalog=Kolokwium1;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = "SELECT * FROM PrescriptionMedicament WHERE IdMedicament = @IdMedicament";
            command.Parameters.AddWithValue("@IdMedicament", IdMedicament);
            SqlDataReader dataReader = command.ExecuteReader();
            while(dataReader.Read())
            {
                PrescriptionMedicament prescriptionMedicament = new PrescriptionMedicament
                {
                    IdMedicament = IdMedicament,
                    IdPrescription = (int)dataReader["IdPrescription"],
                    Dose = (int)dataReader["Dose"],
                    Detalis = dataReader["Detalis"].ToString()
                };

                prescriptionMedicaments.Add(prescriptionMedicament);
            }

            return prescriptionMedicaments;
        }

        
    }
}
