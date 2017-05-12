using System;
using System.Xml.Serialization;

namespace RitEduClient.Entities
{
    [Serializable()]
    [XmlRoot("row")]
    public sealed class County
    {
        [XmlElement("CountyId")]
        public int Id { get; set; }
        [XmlElement("CountyName")]
        public string Name { get; set; }

        /**
         * Override default string representation
         */
        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable()]
    [XmlRoot("data")]
    public sealed class CountyList
    {
        [XmlElement("row")]
        public County[] Counties { get; set; }
    }
}
