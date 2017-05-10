using System;
using System.Xml.Serialization;

namespace RitEduClient.Entities
{
    [Serializable()]
    [XmlRoot("row")]
    public class City
    {
        [XmlElement("city")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable()]
    [XmlRoot("data")]
    public sealed class CityList
    {
        [XmlElement("row")]
        public City[] Cities { get; set; }
    }
}
