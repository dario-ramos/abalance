using System;
using System.Xml.Serialization;

namespace RitEduClient.Models.Entities
{
    [Serializable()]
    [XmlRoot("person")]
    public sealed class Person
    {
        [XmlElement("contactMethods")]
        public string ContactMethods { get; set; }

        [XmlElement("fName")]
        public string FName { get; set; }

        [XmlElement("honorific")]
        public string Honorific { get; set; }

        [XmlElement("lName")]
        public string LName { get; set; }

        [XmlElement("mName")]
        public string MName { get; set; }

        [XmlElement("personId")]
        public string PersonId { get; set; }

        [XmlElement("role")]
        public string Role { get; set; }

        [XmlElement("suffix")]
        public string Suffix { get; set; }
    }

    [Serializable()]
    [XmlRoot("site")]
    public sealed class Site
    {
        [XmlAttribute("address")]
        public string Address { get; set; }

        [XmlAttribute("siteId")]
        public string SiteId { get; set; }

        [XmlAttribute("siteType")]
        public string SiteType { get; set; }

        [XmlElement("person")]
        public Person[] People { get; set; }
    }

    [Serializable()]
    [XmlRoot("data")]
    public sealed class PeopleList
    {
        [XmlElement("site")]
        public Site[] Sites { get; set; }
    }
}
