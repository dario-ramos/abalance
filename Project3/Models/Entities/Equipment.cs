using System;
using System.Xml.Serialization;

namespace RitEduClient.Models.Entities
{
    [Serializable()]
    [XmlRoot("equipment")]
    public sealed class Equipment
    {
        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("quantity")]
        public string Quantity { get; set; }

        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("typeId")]
        public string TypeId { get; set; }
    }

    [Serializable()]
    [XmlRoot("data")]
    public sealed class EquipmentList
    {
        [XmlElement("equipment")]
        public Equipment[] Equipments { get; set; }
    }
}

