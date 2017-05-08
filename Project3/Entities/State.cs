using System;
using System.Xml.Serialization;

namespace RitEduClient
{
    [Serializable()]
    [XmlRoot("row")]
    public class State
    {
        [XmlElement("State")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable()]
    [XmlRoot("data")]
    public sealed class StateList
    {
        [XmlElement("row")]
        public State[] States { get; set; }
    }
}
