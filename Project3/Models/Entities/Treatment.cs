using System;
using System.Xml.Serialization;

namespace RitEduClient.Models.Entities
{
    [Serializable()]
    [XmlRoot("treatment")]
    public sealed class Treatment
    {
        [XmlElement("abbreviation")]
        public string Abbreviation { get; set; }

        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("typeId")]
        public string TypeId { get; set; }
    }

    [Serializable()]
    [XmlRoot("data")]
    public sealed class TreatmentList
    {
        [XmlElement("treatment")]
        public Treatment[] Treatments { get; set; }
    }
}
