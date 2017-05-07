using System.Xml.Serialization;

namespace RitEduClient
{
    public class OrganizationType
    {
        [XmlElement("typeId")]
        int Id { get; set; }
        [XmlElement("type")]
        string Name { get; set; }
    }

    [XmlRoot("data")]
    public class OrganizationTypeList
    {
        [XmlArrayItem("row", Type = typeof(OrganizationType))]
        OrganizationType[] Rows { get; set; }
    }
}
