using FHIR.DTOs;
using System.Collections.Generic;

namespace FHIR
{
    public class DataRepository
    {
        public PatientResponse GetPatient(Patient query)
        {
            PatientResponse response = new PatientResponse();

            if (query.NHI.ToUpper() == "ABC1234")
            {
                var FullName = "Mr Daniel Lulu";
                var Address = "1 Healthshare Avenue, Hamilton";
                var DateOfBirth = "1985-03-11";

                response.ResourceType = "Patient";
                response.Text.Status = "generated";
                response.Text.Div = "<div><p>" + FullName + "</p><p>Date of Birth: " + DateOfBirth + "</p><p>" + Address + "</p></div>";
                response.Identifier.Add(new Identifier()
                {
                    Use = "Official",
                    Label = "NHI",
                    Value = query.NHI
                });
                response.Name.Add(new Name()
                {
                    Text = FullName,
                    Family = new List<string>() { "Lulu" },
                    Given = new List<string>() { "Daniel" },
                    Prefix = new List<string>() { "Mr" },
                });
                response.Telecom.Add(new Contact()
                {
                    System = "email",
                    Value = "dan@yahoo.com",
                    Use = "home"
                });
                response.Telecom.Add(new Contact()
                {
                    System = "phone",
                    Value = "07 123 4567",
                    Use = "home"
                });
                response.Telecom.Add(new Contact()
                {
                    System = "phone",
                    Value = "021 123 4567",
                    Use = "mobile"
                });
                response.Gender.Coding.Add(new Coding()
                {
                    System = "http://hl7.org/fhir/v3/AdministrativeGender",
                    Code = "M",
                    Display = "Male"
                });
                response.BirthDate = DateOfBirth;
                response.DeceasedBoolean = false;
                response.Address.Add(new Address()
                {
                    Use = "home",
                    Text = Address
                });
                response.MaritalStatus.Coding.Add(new Coding()
                {
                    System = "http://hl7.org/fhir/v3/MaritalStatus",
                    Code = "M",
                    Display = "Married"
                });
                response.ManagingOrganization.Name = "HealthShare Limited";
                response.Active = "true";
            }

            return response;
        }

    }
}