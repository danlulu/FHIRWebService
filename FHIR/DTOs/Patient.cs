using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FHIR.DTOs
{
    [Route("/Patient/{NHI}")]
    public class Patient
    {
        public string NHI { get; set; }
    }

    public class PatientResponse
    {
        public PatientResponse()
        {
            Address = new List<Address>();
            Gender = new Gender();
            MaritalStatus = new MaritalStatus();
            Identifier = new List<Identifier>();
            Name = new List<Name>();
            ManagingOrganization = new Organization();
            Telecom = new List<Contact>();
            Text = new Text();
        }

        public string ResourceType { get; set; }
        public Text Text { get; set; }
        public List<Identifier> Identifier { get; set; }
        public List<Name> Name { get; set; }
        public List<Contact> Telecom { get; set; }
        public Gender Gender { get; set; }
        public string BirthDate { get; set; }
        public bool DeceasedBoolean { get; set; }
        public string DeceasedDateTime { get; set; }
        public List<Address> Address { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public Organization ManagingOrganization { get; set; }
        public string Active { get; set; }
    }
}