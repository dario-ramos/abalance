using System;
using System.Xml.Serialization;

namespace RitEduClient.Entities
{
    [Serializable()]
    [XmlRoot("data")]
    public sealed class OrganizationGeneralInfo
    {
        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("email")]
        public string Email { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("numcalls")]
        public string NumCalls { get; set; }

        [XmlElement("nummembers")]
        public string NumMembers { get; set; }

        [XmlElement("website")]
        public string Website { get; set; }
    }
}
