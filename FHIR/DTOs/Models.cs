using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FHIR.DTOs
{
    [ComplexType]
    public class Identifier
    {
        public string Use { get; set; }
        public string Label { get; set; }
        public string System { get; set; }
        public string Value { get; set; }
    }

    [ComplexType]
    public class Name
    {
        public Name()
        {
            Family = new List<string>();
            Given = new List<string>();
            Prefix = new List<string>();
        }
        public string Use { get; set; }
        public string Text { get; set; }
        public List<string> Family { get; set; }
        public List<string> Given { get; set; }
        public List<string> Prefix { get; set; }
    }

    [ComplexType]
    public class Contact
    {
        public string System { get; set; }
        public string Value { get; set; }
        public string Use { get; set; }
    }

    [ComplexType]
    public class Address
    {
        public Address() 
        {
            Line = new List<string>();
        }
        public string Use { get; set; }
        public string Text { get; set; }
        public List<string> Line { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
    }

    [ComplexType]
    public class Gender
    {
        public Gender()
        {
            Coding = new List<Coding>();
        }
        public List<Coding> Coding { get; set; }
        public string Text { get; set; }
    }

    [ComplexType]
    public class Coding
    {
        public string System { get; set; }
        public string Code { get; set; }
        public string Display { get; set; }
    }

    [ComplexType]
    public class Period
    {
        public string Start { get; set; }
        public string End { get; set; }
    }

    [ComplexType]
    public class Text
    {
        public string Status { get; set; }
        public string Div { get; set; }
    }

    [ComplexType]
    public class Organization
    {
        public string Name { get; set; }
    }
}