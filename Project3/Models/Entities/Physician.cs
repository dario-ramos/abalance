using System;
using System.Xml.Serialization;

namespace RitEduClient.Models.Entities
{
    [Serializable()]
    [XmlRoot("physician")]
    public sealed class Physician
    {
        [XmlElement("fName")]
        public string FName { get; set; }

        [XmlElement("mName")]
        public string MName { get; set; }

        [XmlElement("license")]
        public string License { get; set; }

        [XmlElement("lName")]
        public string LName { get; set; }

        [XmlElement("personId")]
        public string PersonId { get; set; }

        [XmlElement("phone")]
        public string Phone { get; set; }

        [XmlElement("suffix")]
        public string Suffix { get; set; }
    }

    [Serializable()]
    [XmlRoot("data")]
    public sealed class PhysicianList
    {
        [XmlElement("physician")]
        public Physician[] Physicians { get; set; }
    }
}
