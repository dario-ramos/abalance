using System;
using System.Collections;
using System.Xml.Serialization;

namespace RitEduClient.Entities
{
    [Serializable()]
    [XmlRoot("row")]
    public sealed class Organization
    {
        [XmlElement("City")]
        public string City { get; set; }

        [XmlElement("CountyName")]
        public string CountyName { get; set; }

        [XmlElement("Email")]
        public string Email { get; set; }

        [XmlElement("OrganizationID")]
        public int Id { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("State")]
        public string State { get; set; }

        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("zip")]
        public string Zip { get; set; }

    }

    [Serializable()]
    [XmlRoot("data")]
    public sealed class OrganizationList
    {
        [XmlElement("row")]
        public Organization[] Organizations { get; set; }
    }

    public sealed class OrganizationComparerByType : IComparer
    {
        public int Compare(object x, object y)
        {
            if(x == null && y == null){
                return 0;
            }
            if(x == null)
            {
                return -1;
            }
            if(y == null)
            {
                return 1;
            }
            Organization orgX = x as Organization;
            Organization orgY = y as Organization;
            return string.Compare(orgX.Type, orgY.Type);
        }
    }
}
