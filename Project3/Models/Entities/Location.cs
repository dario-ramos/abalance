using System;
using System.Xml.Serialization;

namespace RitEduClient.Models.Entities
{
    [Serializable()]
    [XmlRoot("location")]
    public sealed class Location
    {
        [XmlElement("address1")]
        public string Address1 { get; set; }

        [XmlElement("address2")]
        public string Address2 { get; set; }

        [XmlElement("city")]
        public string City { get; set; }

        [XmlElement("countyId")]
        public string CountyId { get; set; }

        [XmlElement("countyName")]
        public string CountyName { get; set; }

        [XmlElement("fax")]
        public string Fax { get; set; }

        [XmlElement("latitude")]
        public string Latitude { get; set; }

        [XmlElement("longitude")]
        public string Longitude { get; set; }

        [XmlElement("phone")]
        public string Phone { get; set; }

        [XmlElement("siteId")]
        public string siteId { get; set; }

        [XmlElement("state")]
        public string State { get; set; }

        [XmlElement("ttyphone")]
        public string TtyPhone { get; set; }

        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("zip")]
        public string Zip { get; set; }
    }

    [Serializable()]
    [XmlRoot("data")]
    public sealed class LocationList
    {
        [XmlElement("location")]
        public Location[] Locations { get; set; }
    }
}
