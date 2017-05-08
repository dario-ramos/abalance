using System;
using System.Xml.Serialization;

namespace RitEduClient.Entities
{
    [Serializable()]
    [XmlRoot("row")]
    public sealed class Organization
    {
        [XmlElement("City")]
        public string City { get; set; }

        [XmlElement("CountyName")]
        public string CountyName { get; set; }

        [XmlElement("Email")]
        public string Email { get; set; }

        [XmlElement("OrganizationID")]
        public int Id { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("State")]
        public string State { get; set; }

        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("zip")]
        public string Zip { get; set; }
    }

    [Serializable()]
    [XmlRoot("data")]
    public sealed class OrganizationList
    {
        [XmlElement("row")]
        public Organization[] Organizations { get; set; }
    }
}
