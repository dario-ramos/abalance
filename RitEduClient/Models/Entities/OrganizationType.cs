﻿using System;
using System.Xml.Serialization;

namespace RitEduClient.Entities
{
    [Serializable()]
    [XmlRoot("row")]
    public sealed class OrganizationType
    {
        [XmlElement("typeId")]
        public int Id { get; set; }
        [XmlElement("type")]
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
    public sealed class OrganizationTypeList
    {
        [XmlElement("row")]
        public OrganizationType[] OrganizationTypes { get; set; }
    }
}
