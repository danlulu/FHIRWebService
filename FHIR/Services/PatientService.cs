using FHIR.DTOs;
using ServiceStack;

namespace FHIR.Services
{
    public class PatientService : Service
    {
        public DataRepository dr { get; set; }

        public object Any(Patient query)
        {
            return dr.GetPatient(query);
        }
    }
}