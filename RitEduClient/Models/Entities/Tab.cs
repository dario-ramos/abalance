using System;
using System.Xml.Serialization;

namespace RitEduClient.Entities
{
    [Serializable()]
    [XmlRoot("row")]
    public sealed class Tab
    {
        [XmlElement("Tab")]
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
    public sealed class TabList
    {
        [XmlElement("row")]
        public Tab[] Tabs { get; set; }
    }
}
