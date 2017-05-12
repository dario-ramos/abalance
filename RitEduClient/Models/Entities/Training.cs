using System;
using System.Xml.Serialization;

namespace RitEduClient.Models.Entities
{
    [Serializable()]
    [XmlRoot("training")]
    public sealed class Training
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
    public sealed class TrainingList
    {
        [XmlElement("training")]
        public Training[] Trainings { get; set; }
    }
}
